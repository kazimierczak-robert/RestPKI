from django.shortcuts import render
from django.http import HttpResponse
from django.contrib.auth.models import User
from django.views import View
from django.contrib.auth import authenticate
from django.views.decorators.csrf import csrf_exempt
import django.utils.timezone as timezone

from rest_framework import viewsets, mixins, permissions, renderers, status
from rest_framework.response import Response
from rest_framework.authtoken.models import Token
from rest_framework.decorators import api_view, permission_classes
from rest_framework.decorators import detail_route
from rest_framework.exceptions import PermissionDenied

from OpenSSL import crypto

from datetime import datetime

from .models import Job, Employee, Certificate, CancellationReason, Key, CRL, Message
from .serializers import UserSerializer, JobSerializer, EmployeeSerializer, CertificateSerializer, \
    CancellationReasonSerializer, KeySerializer, CRLSerializer, MessageSerializer

@csrf_exempt
@api_view(['POST', ])
@permission_classes((permissions.AllowAny, ))
def token_login(request):
    try:
        username = request.POST.get("username")
        password = request.POST.get("password")
        user = authenticate(username=username, password=password)
        if not user:
            return Response({"error": "Login failed"}, status=status.HTTP_401_UNAUTHORIZED)
        token, _ = Token.objects.get_or_create(user=user)
        employee = Employee.objects.get(user=user)
        employee.login_date = timezone.now()
        employee.save()
        return Response({"token": token.key})
    except Exception as e:
        print(e)
        return Response({"error": "Login failed"}, status=status.HTTP_401_UNAUTHORIZED)

@csrf_exempt
@api_view(['POST', ])
def token_logout(request):
    employee = Employee.objects.get(user=request.user)
    employee.logout_date = timezone.now()
    employee.save()
    request.user.auth_token.delete()
    return Response({"success": "Logout successful"})


class UserViewSet(mixins.CreateModelMixin,
                   mixins.RetrieveModelMixin,
                   mixins.UpdateModelMixin,
                   mixins.DestroyModelMixin,
                   mixins.ListModelMixin,
                  viewsets. GenericViewSet):
    queryset = User.objects.all()
    serializer_class = UserSerializer
    permission_classes = (permissions.IsAuthenticated,)
    #renderer_classes = [renderers.JSONRenderer]  # w przegladrce jako JSON sie pojawi

    @detail_route(methods=['get'], url_path='info')
    def info(self, request, pk=None):
        return HttpResponse(self.request.user.username)

class JobViewSet(viewsets.ModelViewSet):
    queryset = Job.objects.all()
    serializer_class = JobSerializer
    permission_classes = (permissions.IsAuthenticated,)

class EmployeeViewSet(mixins.CreateModelMixin,
                   mixins.RetrieveModelMixin,
                   mixins.UpdateModelMixin,
                   mixins.DestroyModelMixin,
                   mixins.ListModelMixin,
                  viewsets. GenericViewSet):
    queryset = Employee.objects.all()
    serializer_class = EmployeeSerializer
    permission_classes = (permissions.IsAuthenticated,)

    def list(self, request):
        if not request.user.is_staff:
            me = Employee.objects.get(user=request.user)
            serializer = self.serializer_class(me)
        else:
            all_employees = Employee.objects.all()
            serializer = self.serializer_class(all_employees, many=True)
        return Response(serializer.data)

    def update(self, request, pk=None, partial=False):  # pk = ID
        instance = self.get_object()  # get Employee from request
        serializer = self.serializer_class(instance, data=request.data, partial=partial)
        if serializer.is_valid():
            serializer.save(last_edition_date=timezone.now(), last_edited_by=Employee.objects.get(user=request.user))
            return Response(serializer.validated_data, status=status.HTTP_200_OK)

        return Response({
            'status': 'Bad request',
            'message': serializer.errors
        }, status=status.HTTP_400_BAD_REQUEST)

    def create(self, request):
        serializer = self.serializer_class(data=request.data)

        if serializer.is_valid():
            user = User.objects.create_user(username=serializer.data['name'], password=serializer.data['name'])
            createdby = Employee.objects.get(user=request.user)
            Employee.objects.create(user=user,
                                    last_edition_date=timezone.now(),
                                    last_edited_by=createdby,
                                    created_by=createdby,
                                    **serializer.validated_data)
            return Response({"status":"ok"}, status=status.HTTP_201_CREATED)
            # lepiej nie serializer.validated_data, bo on nie potrafi zserializowac Job

        return Response({
            'status': 'Bad request',
            'message': serializer.errors
        }, status=status.HTTP_400_BAD_REQUEST)

    def destroy(self, request, pk=None):
        instance = self.get_object()  # get Employee from request
        serializer = self.serializer_class(instance, data=request.data, partial=True)
        if serializer.is_valid():
            serializer.save(isWorking=False)
            # uniewaznik certyfikaty usera
            return Response(serializer.validated_data, status=status.HTTP_200_OK)

        return Response({
            'status': 'Bad request',
            'message': serializer.errors
        }, status=status.HTTP_400_BAD_REQUEST)


def create_self_signed_cert(name, surname):
    # create a key pair
    k = crypto.PKey()
    k.generate_key(crypto.TYPE_RSA, 1024)

    # create a self-signed cert
    cert = crypto.X509()
    cert.get_subject().C = "PL"
    cert.get_subject().ST = "Poznan"
    cert.get_subject().L = "Poznan"
    cert.get_subject().O = str(name)+" "+str(surname)
    cert.get_subject().OU = "Politechnika Poznanska"
    cert.get_subject().CN = str(name).lower()+".pki.put.poznan.pl"
    #cert.set_serial_number(1000)
    cert.gmtime_adj_notBefore(0)
    cert.gmtime_adj_notAfter(31556952)  # in seconds = 1 year
    cert.set_issuer(cert.get_subject())
    cert.set_pubkey(k)
    cert.sign(k, 'sha256')

    certificate = crypto.dump_certificate(crypto.FILETYPE_PEM, cert).decode('utf-8')
    private_key = crypto.dump_privatekey(crypto.FILETYPE_PEM, k).decode('utf-8')
    public_key = crypto.dump_publickey(crypto.FILETYPE_PEM, k).decode('utf-8')
    not_before = cert.get_notBefore()
    not_after = cert.get_notAfter()
    return certificate, private_key, public_key, not_before, not_after

def renew_cert(cert_obj, key_obj):
    pass

@csrf_exempt
@api_view(['GET',])
@permission_classes((permissions.IsAuthenticated, ))
def gen_or_renew_cert(request):
    employee = Employee.objects.get(user=request.user)
    certificate = Certificate.objects.filter(employee_id=employee).first()
    if certificate:
        # certyfikat istnieje - trzeba go odnowic
        pass
    else:
        # certyfikat nie istnieje - trzeba go stworzyc
        current_tz = timezone.get_current_timezone()

        new_cert = create_self_signed_cert(employee.name, employee.surname)
        print(new_cert[0])

        not_before = datetime.strptime(new_cert[3].decode('utf-8'),"%Y%m%d%H%M%SZ")
        not_before = current_tz.localize(not_before)  # for convert to non-naive time

        not_after = datetime.strptime(new_cert[4].decode('utf-8'),"%Y%m%d%H%M%SZ")
        not_after = current_tz.localize(not_after)

        cert_obj = Certificate.objects.create(employee_id=employee ,cert=new_cert[0], not_valid_before=not_before, not_valid_after=not_after,
                                expiration_date=not_after)
        Key.objects.create(certificate_id=cert_obj, enc_private_key=new_cert[1], public_key=new_cert[2],
                           not_valid_before_private_key=not_before, not_valid_before_public_key=not_before,
                           not_valid_after_private_key=not_after, not_valid_after_public_key=not_after)

        data = {
            "status": "ok",
            "cert": new_cert[0],
        }
        return Response(data, status=status.HTTP_200_OK)


class CertificateViewSet(mixins.RetrieveModelMixin,
                   mixins.DestroyModelMixin,
                   mixins.ListModelMixin,
                  viewsets. GenericViewSet):
    queryset = Certificate.objects.all()
    serializer_class = CertificateSerializer
    permission_classes = (permissions.IsAuthenticated,)

class CancellationReasonViewSet(viewsets.ModelViewSet):
    queryset = CancellationReason.objects.all()
    serializer_class = CancellationReasonSerializer
    permission_classes = (permissions.IsAuthenticated,)

class KeyViewSet(mixins.RetrieveModelMixin,
                   mixins.DestroyModelMixin,
                   mixins.ListModelMixin,
                  viewsets. GenericViewSet):
    queryset = Key.objects.all()
    serializer_class = KeySerializer
    permission_classes = (permissions.IsAuthenticated,)

class CRLViewSet(mixins.RetrieveModelMixin,
                   mixins.ListModelMixin,
                  viewsets. GenericViewSet):
    queryset = CRL.objects.all()
    serializer_class = CRLSerializer
    permission_classes = (permissions.IsAuthenticated,)

class MessageViewSet(mixins.CreateModelMixin,
                   mixins.RetrieveModelMixin,
                   mixins.ListModelMixin,
                  viewsets. GenericViewSet):
    queryset = Message.objects.all()
    serializer_class = MessageSerializer
    permission_classes = (permissions.IsAuthenticated,)

from django.shortcuts import render
from django.http import HttpResponse
from django.contrib.auth.models import User
from django.views import View
from django.contrib.auth import authenticate
from django.views.decorators.csrf import csrf_exempt
import django.utils.timezone as timezone

from rest_framework import viewsets, mixins, permissions, renderers
from rest_framework.response import Response
from rest_framework.status import HTTP_401_UNAUTHORIZED, HTTP_400_BAD_REQUEST, HTTP_200_OK, HTTP_201_CREATED
from rest_framework.authtoken.models import Token
from rest_framework.decorators import api_view, permission_classes
from rest_framework.decorators import detail_route
from rest_framework.exceptions import PermissionDenied


from .models import Job, Employee, Certificate, CertificateRequest, CancellationReason, \
    CertificateExpirationRequest, Key, CRL, Message
from .serializers import UserSerializer, JobSerializer, EmployeeSerializer, CertificateSerializer, \
    CertificateRequestSerializer, CancellationReasonSerializer, CertificateExpirationRequestSerializer, \
    KeySerializer, CRLSerializer, MessageSerializer

@csrf_exempt
@api_view(['POST', ])
@permission_classes((permissions.AllowAny, ))
def token_login(request):
    try:
        username = request.POST.get("username")
        password = request.POST.get("password")
        user = authenticate(username=username, password=password)
        if not user:
            return Response({"error": "Login failed"}, status=HTTP_401_UNAUTHORIZED)
        token, _ = Token.objects.get_or_create(user=user)
        employee = Employee.objects.get(user=user)
        employee.login_date = timezone.now()
        employee.save()
        return Response({"token": token.key})
    except Exception as e:
        print(e)
        return Response({"error": "Login failed"}, status=HTTP_401_UNAUTHORIZED)

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
            raise PermissionDenied({"error": "You don't have permission to access"})
        all_employees = Employee.objects.all()
        serializer = EmployeeSerializer(all_employees, many=True)
        return Response(serializer.data)

    def update(self, request, *args, **kwargs):
        partial = kwargs.pop('partial', False)
        instance = self.get_object()
        serializer = self.serializer_class(instance, data=request.data, partial=partial)
        if serializer.is_valid():
            serializer.save(last_edition_date=timezone.now(), last_edited_by=Employee.objects.get(user=request.user))
            return Response(serializer.validated_data, status=HTTP_200_OK)

        return Response({
            'status': 'Bad request',
            'message': serializer.errors
        }, status=HTTP_400_BAD_REQUEST)

    def create(self, request):
        serializer = self.serializer_class(data=request.data)

        if serializer.is_valid():
            createdby = Employee.objects.get(user=request.user)
            Employee.objects.create(last_edition_date=timezone.now(),
                                    last_edited_by=createdby,
                                    created_by=createdby,
                                    **serializer.validated_data)
            return Response(serializer.validated_data, status=HTTP_201_CREATED)

        return Response({
            'status': 'Bad request',
            'message': serializer.errors
        }, status=HTTP_400_BAD_REQUEST)


class CertificateViewSet(viewsets.ModelViewSet):
    queryset = Certificate.objects.all()
    serializer_class = CertificateSerializer
    permission_classes = (permissions.IsAuthenticated,)

class CertificateRequestViewSet(viewsets.ModelViewSet):
    queryset = CertificateRequest.objects.all()
    serializer_class = CertificateRequestSerializer
    permission_classes = (permissions.IsAuthenticated,)

class CancellationReasonViewSet(viewsets.ModelViewSet):
    queryset = CancellationReason.objects.all()
    serializer_class = CancellationReasonSerializer
    permission_classes = (permissions.IsAuthenticated,)

class CertificateExpirationRequestViewSet(viewsets.ModelViewSet):
    queryset = CertificateExpirationRequest.objects.all()
    serializer_class = CertificateExpirationRequestSerializer
    permission_classes = (permissions.IsAuthenticated,)

class KeyViewSet(viewsets.ModelViewSet):
    queryset = Key.objects.all()
    serializer_class = KeySerializer
    permission_classes = (permissions.IsAuthenticated,)

class CRLViewSet(viewsets.ModelViewSet):
    queryset = CRL.objects.all()
    serializer_class = CRLSerializer
    permission_classes = (permissions.IsAuthenticated,)

class MessageViewSet(viewsets.ModelViewSet):
    queryset = Message.objects.all()
    serializer_class = MessageSerializer
    permission_classes = (permissions.IsAuthenticated,)

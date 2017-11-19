from django.contrib.auth.models import User

from rest_framework import serializers
from .models import Job, Employee, Certificate, CertificateRequest, CancellationReason, \
    CertificateExpirationRequest, Key, CRL, Message

class UserSerializer(serializers.ModelSerializer):
    class Meta:
        model = User
        fields = '__all__'

class JobSerializer(serializers.ModelSerializer):
    class Meta:
        model = Job
        fields = '__all__'

class EmployeeSerializer(serializers.ModelSerializer):
    class Meta:
        model = Employee
        fields = '__all__'


class CertificateSerializer(serializers.ModelSerializer):
    class Meta:
        model = Certificate
        fields = '__all__'


class CertificateRequestSerializer(serializers.ModelSerializer):
    class Meta:
        model = CertificateRequest
        fields = '__all__'

class CancellationReasonSerializer(serializers.ModelSerializer):
    class Meta:
        model = CancellationReason
        fields = '__all__'


class CertificateExpirationRequestSerializer(serializers.ModelSerializer):
    class Meta:
        model = CertificateExpirationRequest
        fields = '__all__'

class KeySerializer(serializers.ModelSerializer):
    class Meta:
        model = Key
        fields = '__all__'

class CRLSerializer(serializers.ModelSerializer):
    class Meta:
        model = CRL
        fields = '__all__'

class MessageSerializer(serializers.ModelSerializer):
    class Meta:
        model = Message
        fields = '__all__'
from django.contrib.auth.models import User

from rest_framework import serializers
from .models import Job, Employee, Certificate, CancellationReason, Key, CRL, Message

class UserSerializer(serializers.ModelSerializer):
    class Meta:
        model = User
        fields = ('username',)

class JobSerializer(serializers.ModelSerializer):
    class Meta:
        model = Job
        fields = '__all__'
        extra_kwargs = {
            'description': {
                'validators': [],
            }
        }


class EmployeeSerializer(serializers.ModelSerializer):
    class Meta:
        model = Employee
        fields = ('id','name','surname','pesel','address','birth_day','job_id','company_email','isWorking',)
        read_only_fields = ('isWorking', 'company_email',)


class CertificateSerializer(serializers.ModelSerializer):
    class Meta:
        model = Certificate
        fields = '__all__'

class CancellationReasonSerializer(serializers.ModelSerializer):
    class Meta:
        model = CancellationReason
        fields = '__all__'

class KeySerializer(serializers.ModelSerializer):
    class Meta:
        model = Key
        fields = '__all__'

class CRLSerializer(serializers.ModelSerializer):
    reason_id = CancellationReason()

    class Meta:
        model = CRL
        fields = ('certificate_id', 'reason_id', 'cancellation_date',)
        read_only_fields = ('cancellation_date',)

class MessageSerializer(serializers.ModelSerializer):
    class Meta:
        model = Message
        fields = ('id', 'sender_id', 'recipient_id','enc_topic', 'enc_message', 'send_date','copy',)
        read_only_fields = ('send_date',)

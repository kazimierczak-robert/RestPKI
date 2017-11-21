# -*- coding: utf-8 -*-
from django.db import models
from django.contrib.auth.models import User
import django.utils.timezone as timezone  # date and time

from django.db.models.signals import post_save
from django.dispatch import receiver
from rest_framework.authtoken.models import Token
from django.conf import settings

@receiver(post_save, sender=settings.AUTH_USER_MODEL)
def create_auth_token(sender, instance=None, created=False, **kwargs):
    if created:
        Token.objects.create(user=instance)

class Job(models.Model):
    description = models.TextField(unique=True)

class Employee(models.Model):
    user = models.OneToOneField(User, on_delete=models.CASCADE, default=None)
    name = models.CharField(max_length=50)
    surname = models.CharField(max_length=50)
    pesel = models.CharField(max_length=13, unique=True)
    address = models.CharField(max_length=50)
    birth_day = models.DateField()
    job_id = models.ForeignKey(Job, on_delete=models.CASCADE)
    company_email = models.EmailField(unique=True)
    password = models.CharField(max_length=64)  # hex
    login_date = models.DateTimeField(null=True)
    logout_date = models.DateTimeField(null=True)
    created_by = models.ForeignKey('self', on_delete=models.CASCADE, default=None, related_name='+')
    creation_date = models.DateTimeField(default=timezone.now)
    last_edited_by = models.ForeignKey('self', on_delete=models.CASCADE, default=None, null=True, related_name='+')
    last_edition_date = models.DateTimeField(null=True)

class Certificate(models.Model):
    employee_id = models.ForeignKey(Employee, on_delete=models.CASCADE)
    not_valid_before = models.DateTimeField(default=timezone.now)
    not_valid_after = models.DateTimeField()
    creation_date = models.DateTimeField(default=timezone.now)
    expiration_date = models.DateTimeField(null=True)  # it can be earlier than NotValidAfter

class CertificateRequest(models.Model):  # generating certificate equals update certificate
    employee_id = models.ForeignKey(Employee, on_delete=models.CASCADE)
    request_date = models.DateTimeField(default=timezone.now)
    enc_private_key = models.CharField(max_length=342)  # 2048 bit/8 (1 char: 1B) -> 256B * 4/3 (3 chars - 4B)
    public_key = models.CharField(max_length=342)
    is_accepted = models.BooleanField()
    decision_date = models.DateTimeField(null=True)

class CancellationReason(models.Model):
    descrption = models.TextField(unique=True)


class CertificateExpirationRequest(models.Model):
    employee_id = models.ForeignKey(Employee, on_delete=models.CASCADE)
    request_date = models.DateTimeField(default=timezone.now)
    reason_id = models.ForeignKey(CancellationReason, on_delete=models.CASCADE)
    is_accepted = models.BooleanField(default=False)
    decision_date = models.DateTimeField(null=True)


class Key(models.Model):
    certificate_id = models.ForeignKey(Certificate, on_delete=models.CASCADE)
    enc_private_key = models.CharField(max_length=342)
    public_key = models.CharField(max_length=342)
    not_valid_before_private_key = models.DateTimeField()
    not_valid_after_private_key = models.DateTimeField()
    not_valid_before_public_key = models.DateTimeField()
    not_valid_after_public_key = models.DateTimeField()

class CRL(models.Model):
    certificate_id = models.OneToOneField(Certificate, on_delete=models.CASCADE)
    reason_id = models.ForeignKey(CancellationReason, on_delete=models.CASCADE)
    cancellation_date = models.DateTimeField(default=timezone.now)


class Message(models.Model):
    sender_id = models.ForeignKey(Employee, on_delete=models.CASCADE, related_name='+')
    recipient_id = models.ForeignKey(Employee, on_delete=models.CASCADE, related_name='+')
    enc_topic = models.TextField()
    enc_message = models.TextField()
    send_date = models.DateTimeField(default=timezone.now)

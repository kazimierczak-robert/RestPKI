# -*- coding: utf-8 -*-
from django.db import models
from django.contrib.auth.models import User
import django.utils.timezone as timezone  # date and time

from django.db.models.signals import post_save
from django.dispatch import receiver
from rest_framework.authtoken.models import Token
from django.conf import settings


class Job(models.Model):
    description = models.TextField(unique=True)

    def __str__(self):
        return str(self.description)

class Employee(models.Model):
    user = models.OneToOneField(User, on_delete=models.CASCADE, default=None)
    name = models.CharField(max_length=50)
    surname = models.CharField(max_length=50)
    pesel = models.CharField(max_length=13, unique=True)
    address = models.CharField(max_length=50)
    birth_day = models.DateField()
    job_id = models.ForeignKey(Job)
    company_email = models.EmailField(unique=True)
    #password = models.CharField(max_length=64)  # hex
    login_date = models.DateTimeField(null=True, blank=True)
    logout_date = models.DateTimeField(null=True, blank=True)
    created_by = models.ForeignKey('self', on_delete=models.CASCADE, default=None, related_name='+', null=True, blank=True)
    creation_date = models.DateTimeField(default=timezone.now)
    last_edited_by = models.ForeignKey('self', on_delete=models.CASCADE, default=None, null=True, related_name='+', blank=True)
    last_edition_date = models.DateTimeField(default=timezone.now)
    isWorking = models.BooleanField(default=True)

    def __str__(self):
        return self.name

class Certificate(models.Model):
    employee_id = models.ForeignKey(Employee, on_delete=models.CASCADE)
    not_valid_before = models.DateTimeField(default=timezone.now)
    not_valid_after = models.DateTimeField()
    creation_date = models.DateTimeField(default=timezone.now)
    expiration_date = models.DateTimeField(null=True, blank=True)  # it can be earlier than NotValidAfter

class CertificateRequest(models.Model):  # generating certificate equals update certificate
    employee_id = models.ForeignKey(Employee, on_delete=models.CASCADE)
    request_date = models.DateTimeField(default=timezone.now)
    enc_private_key = models.CharField(max_length=342)  # 2048 bit/8 (1 char: 1B) -> 256B * 4/3 (3 chars - 4B)
    public_key = models.CharField(max_length=342)
    is_accepted = models.BooleanField()
    decision_date = models.DateTimeField(null=True, blank=True)

class CancellationReason(models.Model):
    descrption = models.TextField(unique=True)


class CertificateExpirationRequest(models.Model):
    employee_id = models.ForeignKey(Employee, on_delete=models.CASCADE)
    request_date = models.DateTimeField(default=timezone.now)
    reason_id = models.ForeignKey(CancellationReason, on_delete=models.CASCADE)
    is_accepted = models.BooleanField(default=False)
    decision_date = models.DateTimeField(null=True, blank=True)


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

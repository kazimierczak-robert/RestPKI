# -*- coding: utf-8 -*-
from django.db import models
import django.utils.timezone as timezone  # date and time

class Job(models.Model):
    Description = models.TextField(unique=True)

class Employee(models.Model):
    Name = models.CharField(max_length=50)
    Surname = models.CharField(max_length=50)
    PESEL = models.CharField(max_length=13, unique=True)
    Address = models.CharField(max_length=50)
    BirthDay = models.DateField()
    JobID = models.ForeignKey(Job, on_delete=models.CASCADE)
    CompanyEmail = models.EmailField(unique=True)
    Password = models.CharField(max_length=64)  # hex
    LogInDate = models.DateTimeField(null=True)
    LogOutDate = models.DateTimeField(null=True)
    CreatedBy = models.ForeignKey('self', on_delete=models.CASCADE, default=None, related_name='+')
    CreationDate = models.DateTimeField(default=timezone.now)
    LastEditedBy = models.ForeignKey('self', on_delete=models.CASCADE, default=None, null=True, related_name='+')
    LastEditionDate = models.DateTimeField(null=True)

class Certificate(models.Model):
    EmployeeID = models.ForeignKey(Employee, on_delete=models.CASCADE)
    NotValidBefore = models.DateTimeField(default=timezone.now)
    NotValidAfter = models.DateTimeField()
    CreationDate = models.DateTimeField(default=timezone.now)
    ExpirationDate = models.DateTimeField(null=True)  # it can be earlier than NotValidAfter

class CertificateRequest(models.Model):  # generating certificate equals update certificate
    EmployeeID = models.ForeignKey(Employee, on_delete=models.CASCADE)
    RequestDate = models.DateTimeField(default=timezone.now)
    EncPrivateKey = models.CharField(max_length=342)  # 2048 bit/8 (1 char: 1B) -> 256B * 4/3 (3 chars - 4B)
    PublicKey = models.CharField(max_length=342)
    IsAccepted = models.BooleanField()
    DecisionDate = models.DateTimeField(null=True)

class CancellationReason(models.Model):
    Descrption = models.TextField(unique=True)


class CertificateExpirationRequest(models.Model):
    EmployeeID = models.ForeignKey(Employee, on_delete=models.CASCADE)
    RequestDate = models.DateTimeField(default=timezone.now)
    ReasonID = models.ForeignKey(CancellationReason, on_delete=models.CASCADE)
    IsAccepted = models.BooleanField(default=False)
    DecisionDate = models.DateTimeField(null=True)


class Key(models.Model):
    CertificateID = models.ForeignKey(Certificate, on_delete=models.CASCADE)
    EncPrivateKey = models.CharField(max_length=342)
    PublicKey = models.CharField(max_length=342)
    NotValidBeforePrivateKey = models.DateTimeField()
    NotValidAfterPrivateKey = models.DateTimeField()
    NotValidBeforePublicKey = models.DateTimeField()
    NotValidAfterPublicKey = models.DateTimeField()

class CRL(models.Model):
    CertificateID = models.OneToOneField(Certificate, on_delete=models.CASCADE)
    ReasonID = models.ForeignKey(CancellationReason, on_delete=models.CASCADE)
    CancellationDate = models.DateTimeField(default=timezone.now)


class Message(models.Model):
    SenderID = models.ForeignKey(Employee, on_delete=models.CASCADE, related_name='+')
    RecipientID = models.ForeignKey(Employee, on_delete=models.CASCADE, related_name='+')
    EncTopic = models.TextField()
    EncMessage = models.TextField()
    SendDate = models.DateTimeField(default=timezone.now)

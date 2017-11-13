# -*- coding: utf-8 -*-
from django.contrib import admin
from .models import Certificate, CertificateRequest, CertificateExpirationRequest, CancellationReason, \
    Key, CRL, Employee, Job, Message

admin.site.site_header = 'Panel administracyjny - PKI'
admin.site.site_title = 'PKI'
admin.site.index_title = 'Panel'

@admin.register(Certificate)
class CertificateAdmin(admin.ModelAdmin):
    model = Certificate
    list_display = ('id','EmployeeID','NotValidBefore','NotValidAfter','CreationDate','ExpirationDate')

@admin.register(CertificateRequest)
class CertificateRequestAdmin(admin.ModelAdmin):
    model = CertificateRequest
    list_display = ('id','EmployeeID','RequestDate','EncPrivateKey','PublicKey','IsAccepted','DecisionDate')

@admin.register(CertificateExpirationRequest)
class CertificateExpirationRequestAdmin(admin.ModelAdmin):
    model = CertificateExpirationRequest
    list_display = ('id','EmployeeID','RequestDate','ReasonID','IsAccepted','DecisionDate')

@admin.register(CancellationReason)
class CancellationReasonAdmin(admin.ModelAdmin):
    model = CancellationReason
    list_display = ('id','Descrption')

@admin.register(Key)
class KeyAdmin(admin.ModelAdmin):
    model = Key
    list_display = ('id','CertificateID','EncPrivateKey','PublicKey','NotValidBeforePrivateKey','NotValidAfterPrivateKey',\
                    'NotValidBeforePublicKey','NotValidAfterPublicKey')

@admin.register(CRL)
class CRLAdmin(admin.ModelAdmin):
    model = CRL
    list_display = ('id', 'CertificateID','ReasonID','CancellationDate')

@admin.register(Employee)
class EmployeeAdmin(admin.ModelAdmin):
    model = Employee
    list_display = ('id','Name','Surname','PESEL','Address','BirthDay','JobID','CompanyEmail','Password',\
                    'LogInDate','LogOutDate','CreatedBy','CreationDate','LastEditedBy','LastEditionDate')

@admin.register(Job)
class JobAdmin(admin.ModelAdmin):
    model = Job
    list_display = ('id','Description')

@admin.register(Message)
class MessageAdmin(admin.ModelAdmin):
    model = Message
    list_display = ('id','SenderID','RecipientID','EncTopic','EncMessage','SendDate')

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
    list_display = ('id','employee_id','not_valid_before','not_valid_after','creation_date','expiration_date')

@admin.register(CertificateRequest)
class CertificateRequestAdmin(admin.ModelAdmin):
    model = CertificateRequest
    list_display = ('id','employee_id','request_date','enc_private_key','public_key','is_accepted','decision_date')

@admin.register(CertificateExpirationRequest)
class CertificateExpirationRequestAdmin(admin.ModelAdmin):
    model = CertificateExpirationRequest
    list_display = ('id','employee_id','request_date','reason_id','is_accepted','decision_date')

@admin.register(CancellationReason)
class CancellationReasonAdmin(admin.ModelAdmin):
    model = CancellationReason
    list_display = ('id','descrption')

@admin.register(Key)
class KeyAdmin(admin.ModelAdmin):
    model = Key
    list_display = ('id','certificate_id','enc_private_key','public_key','not_valid_before_private_key',
                    'not_valid_after_private_key', 'not_valid_before_public_key','not_valid_after_public_key')

@admin.register(CRL)
class CRLAdmin(admin.ModelAdmin):
    model = CRL
    list_display = ('id', 'certificate_id','reason_id','cancellation_date')

@admin.register(Employee)
class EmployeeAdmin(admin.ModelAdmin):
    model = Employee
    list_display = ('id','user', 'name','surname','pesel','address','birth_day','job_id','company_email','password',
                    'login_date','logout_date','created_by','creation_date','last_edited_by','last_edition_date')

@admin.register(Job)
class JobAdmin(admin.ModelAdmin):
    model = Job
    list_display = ('id','description')

@admin.register(Message)
class MessageAdmin(admin.ModelAdmin):
    model = Message
    list_display = ('id','sender_id','recipient_id','enc_topic','enc_message','send_date')

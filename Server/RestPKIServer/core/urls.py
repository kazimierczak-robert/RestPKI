from django.conf.urls import url

from rest_framework import routers

from .views import UserViewSet, JobViewSet, EmployeeViewSet, CertificateViewSet, \
    CancellationReasonViewSet,KeyViewSet, CRLViewSet, MessageViewSet
from .views import token_login, token_logout, gen_or_renew_cert, inbox, outbox, datetime_now, change_password, \
    refresh_inbox, get_employee_keys, not_working_emp

router = routers.DefaultRouter()

router.register(r'user', UserViewSet)
router.register(r'job', JobViewSet)
router.register(r'employee', EmployeeViewSet)
router.register(r'certificate', CertificateViewSet)
router.register(r'cancellation_reason', CancellationReasonViewSet)
router.register(r'key', KeyViewSet)
router.register(r'crl', CRLViewSet)
router.register(r'message', MessageViewSet)


urlpatterns = router.urls

urlpatterns += [
    url(r'^login/$', token_login, name='token_login'),
    url(r'^logout/$', token_logout, name='token_logout'),
    url(r'^cert/$', gen_or_renew_cert, name='gen_or_renew_cert'),
    url(r'^inbox/$', inbox, name='inbox'),
    url(r'^refresh_inbox/$', refresh_inbox, name='refresh_inbox'),
    url(r'^outbox/$', outbox, name='outbox'),
    url(r'^now/$', datetime_now, name='datetime_now'),
    url(r'^changepass/$', change_password, name='changepass'),
    url(r'^get_employee_keys/$', get_employee_keys, name='get_employee_keys'),
    url(r'^not_working_emp/$', not_working_emp, name='not_working_emp'),
]

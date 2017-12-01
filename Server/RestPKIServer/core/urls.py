from django.conf.urls import url

from rest_framework import routers

from .views import UserViewSet, JobViewSet, EmployeeViewSet, CertificateViewSet, \
    CancellationReasonViewSet,KeyViewSet, CRLViewSet, MessageViewSet
from .views import token_login, token_logout, gen_or_renew_cert, revoke_cert, inbox, outbox

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
    url(r'^outbox/$', outbox, name='outbox'),
]

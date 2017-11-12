from django.db import models
import django.utils.timezone as timezone	#date and time

class Certificate:
	#CertificateID
	EmployeeID = models.ForeignKey(Employee, on_delete=models.CASCADE)
	NotValidBefore = models.DateTimeField(default = timezone.now)
	NotValidAfter = models.DateTimeField()
	CreationDate = models.DateTimeField(default = timezone.now)
	ExpirationDate = models.DateTimeField(null=True) #it can be earlier than NotValidAfter

class CertificateRequest: #generating certificate equals update certificate
	#CertificateRequestID
	EmployeeID = models.ForeignKey(Employee, on_delete=models.CASCADE)
	RequestDate = models.DateTimeField(default = timezone.now)
	EncPrivateKey = models.CharField(max_length=342) #2048 bit/8 (1 char: 1B) -> 256B * 4/3 (3 chars - 4B)
	PublicKey = models.CharField(max_length=342)
	IsAccepted = models.BooleanField()
	DecisionDate = models.DateTimeField(null=True)

class CertificateExpirationRequest:
    #CertificateRequestID
    EmployeeID = models.ForeignKey(Employee, on_delete=models.CASCADE)
    RequestDate = models.DateTimeField(default = timezone.now)
    ReasonID =  models.ForeignKey(CancellationReason, on_delete=models.CASCADE)
    IsAccepted = IsAccepted = models.BooleanField(default=False)
    DecisionDate = models.DateTimeField(null=True)

class CancellationReason:
    #ReasonID
    Descrption = models.TextField(unique = True)

class Key:
    #KeyRepoID
    CertificateID = models.ForeignKey(Certificate, on_delete=models.CASCADE)
    EncPrivateKey = models.CharField(max_length=342)
    PublicKey = models.CharField(max_length=342)
    NotValidBeforePrivateKey = models.DateTimeField()
    NotValidAfterPrivateKey = models.DateTimeField()
    NotValidBeforePublicKey = models.DateTimeField()
    NotValidAfterPublicKey = models.DateTimeField()

class CRL:
    CertificateID = models.ForeignKey(Certificate, on_delete=models.CASCADE, primary_key = True)
    ReasonID =  models.ForeignKey(CancellationReason, on_delete=models.CASCADE)
    CancellationDate = models.DateTimeField(default = timezone.now)

class Employee:
    #EmployeeID
    Name = models.TextField()
    Surname = models.TextField()
    PESEL = models.CharField(max_length = 13, unique = True)
    Address = models.TextField()
    BirthDay = models.DateField()
    JobID = models.ForeignKey(Job, on_delete=models.CASCADE)
    CompanyEmail = models.EmailField(unique = True)
    Password = models.CharField(64) #hex
    LogInDate = models.DateTimeField(null=True)
    LogOutDate = models.DateTimeField(null=True)
    CreatedBy = models.ForeignKey(Employee, on_delete=models.CASCADE)
    CreationDate = models.DateTimeField(default = timezone.now)
    LastEditedBy = models.ForeignKey(Employee, on_delete=models.CASCADE, null=True)
    LastEditionDate = models.DateTimeField(null=True)


class Job:
    #JobID
    Description = models.TextField(unique = True)

class Message:
    #MessageID
    SenderID = models.ForeignKey(Employee, on_delete=models.CASCADE)
    RecipientID = models.ForeignKey(Employee, on_delete=models.CASCADE)
    EncTopic = models.TextField()
    EncMessage = models.TextField()
    SendDate = models.DateTimeField(default = timezone.now)



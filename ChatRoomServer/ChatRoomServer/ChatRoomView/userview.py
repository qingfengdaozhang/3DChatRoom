import json

from django.http import HttpResponse

from ChatRoomModel.models import User

def hello(request):
    return HttpResponse("hello")

def login(request):
    userName = ""
    userPassword = ""
    if request.POST:
        userName = request.POST['username']
        userPassword = request.POST['userpassword']
        user = User.objects.filter(username=userName, userpassword=userPassword)
        if user.count()<>0:
            return HttpResponse(user[0].nickname)
        return HttpResponse("failed")
def register(request):
    userName = ""
    userPassword = ""
    nickName = ""
    if request.POST:
        userName = request.POST['username']
        userPassword = request.POST['userpassword']
        nickName = request.POST['nickname']
        usersearch = User.objects.filter(username=userName,userpassword=userPassword)
        if usersearch.count()<>0:
            return HttpResponse("error")
        try:
            user = User(username=userName, userpassword=userPassword, nickname=nickName)
            user.save()
            return HttpResponse("success")
        except ZeroDivisionError as e:
            return HttpResponse("failed")

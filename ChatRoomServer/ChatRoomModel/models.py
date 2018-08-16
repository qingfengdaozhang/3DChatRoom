# -*- coding: utf-8 -*-
from __future__ import unicode_literals

from django.db import models

# Create your models here.

class User(models.Model):
    username = models.CharField(max_length=11)
    userpassword = models.CharField(max_length=12)
    nickname = models.CharField(max_length=20)
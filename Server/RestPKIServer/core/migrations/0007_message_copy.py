# -*- coding: utf-8 -*-
# Generated by Django 1.11.6 on 2017-12-07 20:11
from __future__ import unicode_literals

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('core', '0006_auto_20171127_1638'),
    ]

    operations = [
        migrations.AddField(
            model_name='message',
            name='copy',
            field=models.NullBooleanField(default=None),
        ),
    ]

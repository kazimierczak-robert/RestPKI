# -*- coding: utf-8 -*-
# Generated by Django 1.11.6 on 2017-11-27 16:38
from __future__ import unicode_literals

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('core', '0005_certificate_cert'),
    ]

    operations = [
        migrations.AlterField(
            model_name='certificate',
            name='cert',
            field=models.TextField(),
        ),
    ]
# Generated by Django 2.0.1 on 2018-02-20 00:08

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('paginaWeb', '0004_animal_edad'),
    ]

    operations = [
        migrations.AddField(
            model_name='organizacion',
            name='lat',
            field=models.CharField(max_length=50, null=True),
        ),
        migrations.AddField(
            model_name='organizacion',
            name='lng',
            field=models.CharField(max_length=50, null=True),
        ),
    ]

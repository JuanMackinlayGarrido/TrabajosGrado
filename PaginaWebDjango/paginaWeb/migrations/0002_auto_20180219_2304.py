# Generated by Django 2.0.1 on 2018-02-19 22:04

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('paginaWeb', '0001_initial'),
    ]

    operations = [
        migrations.AddField(
            model_name='animal',
            name='imagen',
            field=models.ImageField(blank=True, upload_to='fotosAnimales/'),
        ),
        migrations.AlterField(
            model_name='animal',
            name='descripcion',
            field=models.CharField(max_length=250),
        ),
    ]

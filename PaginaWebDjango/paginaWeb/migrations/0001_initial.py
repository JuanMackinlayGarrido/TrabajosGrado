# Generated by Django 2.0.1 on 2018-02-19 00:18

import ckeditor.fields
from django.conf import settings
from django.db import migrations, models
import django.db.models.deletion


class Migration(migrations.Migration):

    initial = True

    dependencies = [
        migrations.swappable_dependency(settings.AUTH_USER_MODEL),
        ('auth', '0009_alter_user_last_name_max_length'),
    ]

    operations = [
        migrations.CreateModel(
            name='Animal',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('nombre', models.CharField(max_length=25)),
                ('tipo_animal', models.CharField(max_length=25)),
                ('raza', models.CharField(max_length=25)),
                ('descripcion', models.CharField(max_length=50)),
                ('fecha_recogida', models.DateField(auto_now=True)),
            ],
        ),
        migrations.CreateModel(
            name='Anuncio',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('descripcion', ckeditor.fields.RichTextField(default='', max_length=200)),
                ('imagen', models.ImageField(blank=True, upload_to='fotosAnuncios/')),
                ('fecha_anuncio', models.DateField(auto_now=True)),
            ],
        ),
        migrations.CreateModel(
            name='Organizacion',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('nombre', models.CharField(max_length=30)),
                ('direccion', models.CharField(max_length=45)),
                ('ciudad', models.CharField(max_length=30)),
                ('superficie', models.FloatField()),
                ('capacidad', models.PositiveIntegerField()),
                ('ocupacion', models.PositiveIntegerField()),
                ('telefono', models.IntegerField()),
                ('imagen', models.ImageField(blank=True, upload_to='fotosOrganizaciones/')),
            ],
        ),
        migrations.CreateModel(
            name='Trabaja',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('fecha_trabajo', models.DateField(auto_now=True)),
                ('id_organizacion', models.ManyToManyField(to='paginaWeb.Organizacion')),
            ],
        ),
        migrations.CreateModel(
            name='Usuario',
            fields=[
                ('id', models.OneToOneField(on_delete=django.db.models.deletion.CASCADE, primary_key=True, serialize=False, to=settings.AUTH_USER_MODEL)),
                ('nombre', models.CharField(max_length=25)),
                ('telefono', models.IntegerField()),
                ('edad', models.PositiveIntegerField()),
            ],
        ),
        migrations.AddField(
            model_name='trabaja',
            name='id_usuario',
            field=models.ManyToManyField(to=settings.AUTH_USER_MODEL),
        ),
        migrations.AddField(
            model_name='organizacion',
            name='id_usuario',
            field=models.ForeignKey(null=True, on_delete=django.db.models.deletion.CASCADE, to=settings.AUTH_USER_MODEL),
        ),
        migrations.AddField(
            model_name='anuncio',
            name='id_usuario',
            field=models.ForeignKey(on_delete=django.db.models.deletion.CASCADE, to='paginaWeb.Usuario'),
        ),
        migrations.AddField(
            model_name='animal',
            name='id_asoc',
            field=models.ForeignKey(on_delete=django.db.models.deletion.CASCADE, to='paginaWeb.Organizacion'),
        ),
    ]

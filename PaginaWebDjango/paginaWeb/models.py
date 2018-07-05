from django.db import models
from ckeditor import fields
from django.contrib.auth.models import User

class Usuario (models.Model):
    id = models.OneToOneField(User, primary_key=True, on_delete=models.CASCADE)
    nombre = models.CharField(max_length=25, null=False)
    telefono = models.IntegerField(null=False)
    edad = models.PositiveIntegerField(null=False)

    def __str__(self):
        return self.nombre

class Organizacion(models.Model):
    nombre = models.CharField(max_length=30,null=False)
    direccion = models.CharField(max_length=45,null=False)
    ciudad = models.CharField(max_length=30, null=False)
    superficie=models.FloatField(null=False)
    capacidad=models.PositiveIntegerField(null=False)
    ocupacion=models.PositiveIntegerField(null=False)
    telefono = models.IntegerField(null=False)
    imagen=models.ImageField(upload_to="fotosOrganizaciones/",blank=True)
    id_usuario=models.ForeignKey(User, on_delete=models.CASCADE, null=True)
    def __str__(self):
        return self.nombre

class Animal(models.Model):
    nombre = models.CharField(max_length=25,null=False)
    tipo_animal = models.CharField(max_length=25,null=False)
    raza = models.CharField(max_length=25,null=False)
    edad = models.PositiveIntegerField(null=True)
    descripcion = models.CharField(max_length=250)
    imagen=models.ImageField(upload_to="fotosAnimales/", blank=True)
    fecha_recogida=models.DateField(auto_now=True)
    id_asoc=models.ForeignKey(Organizacion, on_delete=models.CASCADE, null=True)
    def __str__(self):
        return self.nombre+" es un "+self.tipo_animal+" de la raza "+self.raza+"."

class Anuncio(models.Model):
    id_usuario=models.ForeignKey(Usuario, on_delete=models.CASCADE)
    descripcion=fields.RichTextField(max_length=200, default="")
    imagen=models.ImageField(upload_to="fotosAnuncios/",blank=True)
    fecha_anuncio = models.DateField(auto_now=True)

class Trabaja(models.Model):
    id_usuario=models.ManyToManyField(User)
    id_organizacion=models.ManyToManyField(Organizacion)
    fecha_trabajo=models.DateField(auto_now=True)
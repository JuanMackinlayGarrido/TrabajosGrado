from django.contrib import admin
from django.urls import path
from paginaWeb import views
from paginaWeb.views import BusquedaAsociacion, AnimalesAdopcion
from django.contrib.auth.views import login,logout

urlpatterns = [
    path('', views.index, name='index'),
    path('Anuncios/', views.Anuncios, name='Anuncios'),
    path('Anuncios/AddAnuncio/', views.AddAnuncio, name='AddAnuncio'),
    path('Organizaciones/', views.Organizaciones, name='Organizaciones'),
    path('Registro/', views.RegistroDeUsuario, name='Registro'),
    path('Login/', login,{'template_name':'login.html',}, name='Login'),
    path('Logout/', logout,{'template_name':'index.html',}, name='Logout'),
    path('Organizaciones/BusquedaOrg/',BusquedaAsociacion.as_view(), name='Busqueda'),
    path('DondeAdoptar/', AnimalesAdopcion.as_view(), name='DondeAdoptar'),
    path('DondeAdoptar/AddAnimal/', views.AddAnimal, name="AddAnimal"),
    path('Contactanos/', views.enviarEmail, name='Contacto'),
]

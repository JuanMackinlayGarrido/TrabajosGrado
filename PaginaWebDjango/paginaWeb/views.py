from django.shortcuts import render
from django.forms import ModelForm
from paginaWeb.models import Anuncio, Usuario, Organizacion, Animal
from paginaWeb.forms import RegistroUsuario, AnuncioForm, ContactoForm, AnimalForm
from django.contrib.auth.models import User
from django.http import HttpResponseRedirect, HttpResponse
from django.views.generic import TemplateView, ListView, View
from django.contrib.auth.decorators import login_required
from django.core.mail import send_mail

# Create your views here.
def index(request):
    return render(request, 'index.html')

def Anuncios(request):
    anuncios=Anuncio.objects.all()
    context={'anuncios':anuncios}
    return render(request, 'anuncios.html', context)

def Organizaciones(request):
    organizaciones=Organizacion.objects.all()
    context={'organizaciones':organizaciones}
    return render(request, 'organizaciones.html', context)

def RegistroDeUsuario(request):
    if request.method =='POST':
        form=RegistroUsuario(request.POST)
        if form.is_valid():
            cd=form.cleaned_data
            Usu_username=cd['username']
            Usu_email=cd['email']
            Usu_password=cd['password']
            Usu_nombre=cd['nombre']
            Usu_telefono=cd['telefono']
            Usu_edad=cd['edad']
            user=User.objects.create_user(Usu_username, Usu_email, Usu_password)
            user.save()
            nuevoUsuario=Usuario(id=user, nombre=Usu_nombre, telefono=Usu_telefono, edad=Usu_edad)
            nuevoUsuario.save()
        return HttpResponseRedirect('..')
    else:
        form = RegistroUsuario()
    return render(request, 'registro.html', {'form': form})

class AnimalesAdopcion(ListView):
    model = Animal
    template_name = 'DondeAdoptar.html'

    def get_context_data(self, **kwargs):
        context = super().get_context_data()
        context['organizaciones']=Organizacion.objects.all()
        return context

@login_required()
def AddAnimal(request):
    if request.method == 'POST':
        form=AnimalForm(request.POST, request.FILES)
        if form.is_valid():
            cd = form.cleaned_data
            nombre=cd['nombre']
            tipoAnimal=cd['tipo_animal']
            raza=cd['raza']
            edad=cd['edad']
            descripcion=cd['descripcion']
            imagen=cd['imagen']
            id_asoc=cd['id_asoc']
            animal=Animal(nombre=nombre, tipo_animal=tipoAnimal, raza=raza, edad=edad, descripcion=descripcion, imagen=imagen, id_asoc=id_asoc)
            animal.save()
        return HttpResponseRedirect('..')
    else:
        form=AnimalForm()
    organizaciones=Organizacion.objects.all()
    context={'form':form,'organizaciones':organizaciones}
    return render(request, 'AddAnimal.html', context)

@login_required()
def AddAnuncio(request):
   if request.method == 'POST' :
        form=AnuncioForm(request.POST, request.FILES)
        if form.is_valid():
            cd = form.cleaned_data
            a_usuario=cd['id_usuario']
            a_descripcion=cd['descripcion']
            a_imagen=cd['imagen']
            anuncio=Anuncio(id_usuario=a_usuario, descripcion=a_descripcion, imagen=a_imagen)
            anuncio.save()
   else:
        form= AnuncioForm()
   return render(request, 'AddAnuncio.html',{'form':form})

#Busqueda en Web
class BusquedaAsociacion(TemplateView):
    template_name = 'Organizaciones_busqueda.html'
    def post(self, request, *args, **kwargs):
        buscar = request.POST['buscalo']
        organizaciones = Organizacion.objects.filter(ciudad__contains=buscar)
        return render(request,'Organizaciones_busqueda.html', {'orgs':organizaciones})

#Envio de Emails
def enviarEmail(request):
    if request.method=='POST':
        form =  ContactoForm(request.POST)
        if form.is_valid():
            data = form.cleaned_data
            asunto = data['asunto']
            mensaje = data['mensaje']
            nombre = data['nombre']
            send_mail(asunto, mensaje, nombre, ['djangoanimalsafe@gmail.com'], fail_silently=False)
        return HttpResponseRedirect('/PaginaWeb')
    else:
        form=ContactoForm()
    return render(request, 'Contactanos.html', {'form':form})

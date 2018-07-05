from django import forms
from paginaWeb.models import Usuario, Anuncio, Organizacion, Animal


class RegistroUsuario(forms.Form):
    username=forms.CharField(max_length=25, label="Nombre de Usuario:")
    email=forms.EmailField(max_length=50, label="E-mail:")
    password=forms.CharField(min_length=6, widget=forms.PasswordInput)
    nombre=forms.CharField(max_length= 35, label= "Nombre y Apellidos:")
    telefono=forms.CharField(min_length=9, max_length=9, label='Telefono:')
    edad=forms.CharField(min_length=2, label='Edad:')

    def clean(self):
        cleaned_data=self.cleaned_data
        return cleaned_data

class AnuncioForm(forms.ModelForm):
    class Meta:
        model= Anuncio
        fields = '__all__'
        widgets = {
            'id_usuario': forms.HiddenInput()
        }

class ContactoForm(forms.Form):
    asunto = forms.CharField(max_length=50)
    nombre = forms.CharField(max_length=50, required=False)
    mensaje = forms.CharField(widget=forms.Textarea)

    def clean(self):
        cleanead_data=self.cleaned_data
        return cleanead_data

class AnimalForm(forms.ModelForm):
    class Meta:
        model= Animal
        fields ='__all__'
        widgets = {
            'id_asoc':forms.HiddenInput(),
            'descripcion':forms.Textarea(attrs={'cols':3, 'rows':2})
        }
        labels = {
            'nombre': 'Nombre del Animal:'
        }
        help_texts = {
            'descripcion': 'Una breve descripcion del Animal'
        }
        error_messages = {
            'nombre': {
                'max_length': "El nombre solo puede tener 25 caracteres de maximo."
            }
        }
from django.contrib import admin
from paginaWeb.models import Anuncio, Organizacion, Usuario, Animal

# Register your models here.

class OrganizacionAdmin(admin.ModelAdmin):
    list_per_page = 10
    search_fields = ['ciudad', 'nombre']
    show_full_result_count = True
    actions_on_bottom = True
    actions_on_top = False

class AnimalAdmin(admin.ModelAdmin):
    list_per_page = 20
    ordering = ['tipo_animal']
    list_filter=['tipo_animal', 'raza']

class AnuncioAdmin(admin.ModelAdmin):
    list_per_page = 20

class AnuncioInline(admin.StackedInline):
    model = Anuncio
class UsuarioAdmin(admin.ModelAdmin):
    list_per_page = 15
    show_full_result_count = True
    inlines = [AnuncioInline, ]



admin.site.register(Organizacion, OrganizacionAdmin)
admin.site.register(Animal, AnimalAdmin)
admin.site.register(Anuncio,AnuncioAdmin)
admin.site.register(Usuario, UsuarioAdmin)


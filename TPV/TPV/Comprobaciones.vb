Public Class Comprobaciones
    Public Function comprobarNombre(ByVal nombre)
        Dim l As Integer = nombre.Length
        'If l <= 50 Then
        For x = 1 To l
            If IsNumeric(Mid(nombre, x, 1)) = False Then
                Return True
            Else
                Exit For
            End If
        Next
        'End If
        Return False
    End Function

    Public Function comprobarTelefono(ByVal telefono)
        If telefono.Length = 9 Then
            If IsNumeric(telefono) Then
                Return True
            End If
        End If
        Return False
    End Function

    Public Function comprobarDireccion(ByVal direccion)
        If direccion.Length <= 50 Or direccion.Length > 5 Then
            Return True
        End If
        Return False
    End Function

    Public Function comprobarComillas(ByVal cadena)
        Dim array As Array
        Dim cad As String = cadena
        array = cad.ToCharArray
        For Each i As String In array
            If (i = "'" Or i = """") Then
                Return False
            End If
        Next
        Return True
    End Function
End Class

Public Class AgregarAsociacion

    Dim cmp As New Comprobaciones

    Private Sub AgregarAsociacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim nombre As String
        Dim direccion As String
        Dim telefono As String
        Dim cont As Integer = 0

        nombre = txtNombre.Text
        If cmp.comprobarComillas(nombre) = True Then
            If cmp.comprobarNombre(nombre) = False Then
                My.Forms.MsgboxPersonalizado.mensajeAdvertencia("Nombre incorrecto,no puede estar en blanco o contener numeros")
                My.Forms.MsgboxPersonalizado.ShowDialog()
                cont += 1
                Exit Sub
            End If
        Else
            My.Forms.MsgboxPersonalizado.mensajeAdvertencia("Nombre incorrecto, solo letras")
            My.Forms.MsgboxPersonalizado.ShowDialog()
            cont += 1
            Exit Sub
        End If


        direccion = txtDireccion.Text
        If cmp.comprobarComillas(direccion) = True Then
            If cmp.comprobarDireccion(direccion) = False Then
                My.Forms.MsgboxPersonalizado.mensajeAdvertencia("Direccion incorrecta, longitud entre 5 y 50")
                My.Forms.MsgboxPersonalizado.ShowDialog()
                cont += 1
                Exit Sub
            End If
        Else
            My.Forms.MsgboxPersonalizado.mensajeAdvertencia("Direccion incorrecta, no puede contener caracteres especiales")
            My.Forms.MsgboxPersonalizado.ShowDialog()
            cont += 1
            Exit Sub
        End If

        telefono = txtTelefono.Text
        If cmp.comprobarComillas(telefono) = True Then
            If cmp.comprobarTelefono(telefono) = False Then
                My.Forms.MsgboxPersonalizado.mensajeAdvertencia("Telefono incorrecto, debe contener 9 numeros")
                My.Forms.MsgboxPersonalizado.ShowDialog()
                cont += 1
                Exit Sub
            End If
        Else
            My.Forms.MsgboxPersonalizado.mensajeAdvertencia("Telefono incorrecto, no puede contener caracteres especiales.")
            My.Forms.MsgboxPersonalizado.ShowDialog()
            cont += 1
            Exit Sub
        End If

        If cont = 0 Then
            Try
                Dim Consulta As String = "INSERT INTO asociaciones (nombre, direccion,telefono) VALUES ('" & nombre & "', '" & direccion & "', '" & telefono & "')"
                Dim conn As New Conexion
                conn.Insertar(Consulta)
                My.Forms.MsgboxPersonalizado.mensajeConfirmacion("Asociacion agregada correctamente.")
                My.Forms.MsgboxPersonalizado.ShowDialog()
                txtNombre.Clear()
                txtDireccion.Clear()
                txtTelefono.Clear()
            Catch ex As Exception
                MsgBox(ex.Data.Values)
            End Try
        End If

    End Sub

    Public Sub limpiar()
        txtDireccion.Text = ""
        txtNombre.Text = ""
        txtTelefono.Text = ""
    End Sub
End Class
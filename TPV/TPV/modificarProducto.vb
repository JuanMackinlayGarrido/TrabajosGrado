Imports MySql.Data.MySqlClient
Public Class modificarProducto
    Dim buscar As New Buscar
    Dim consulta As String
    Dim rellenarProductos As String

    Private Sub modificarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        consulta = "SELECT nombre FROM productos WHERE nombre LIKE '%" & txtBuscar.Text & "%'"
        buscar.buscarBuscar(cbProductos, consulta, txtBuscar)
    End Sub

    Private Sub cbProductos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbProductos.SelectedIndexChanged
        txtBuscar.Text = ""
        txtNombreNuevo.Text = cbProductos.Text
        consulta = "SELECT nombre FROM categorias"
        buscar.buscarBuscar(cbCategoria, consulta, txtNombreNuevo)

        Dim conexion As New Conexion
        Dim consulta2 As String = "SELECT categoria FROM productos WHERE nombre='" & cbProductos.Text & "'"
        Dim dr As MySqlDataReader
        Dim categoria As String
        dr = conexion.buscar2(consulta2)

        If dr.HasRows Then
            While dr.Read()
                categoria = dr.Item(0).ToString
                cbCategoria.Text = categoria
            End While
        End If


    End Sub
    Private Sub txtBuscar_GotFocus(sender As Object, e As EventArgs) Handles txtBuscar.GotFocus
        limpiar()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If cbProductos.Text = "" Then
            My.Forms.MsgboxPersonalizado.mensajeAdvertencia("Debes seleccionar el producto a modificar")
            My.Forms.MsgboxPersonalizado.ShowDialog()
            Exit Sub
        End If
        If txtNombreNuevo.Text = "" Then
            My.Forms.MsgboxPersonalizado.mensajeAdvertencia("Introduce el nuevo nombre del producto")
            My.Forms.MsgboxPersonalizado.ShowDialog()
            Exit Sub
        End If
        If cbCategoria.Text = "" Then
            My.Forms.MsgboxPersonalizado.mensajeAdvertencia("Debes seleccionar una categoria para el producto")
            My.Forms.MsgboxPersonalizado.ShowDialog()
            Exit Sub
        End If

        Dim conexion As New Conexion
        Dim consulta2 As String = "UPDATE productos SET nombre='" & txtNombreNuevo.Text & "', categoria='" & cbCategoria.Text & "' WHERE nombre='" & cbProductos.Text & "'"
        'extraemos el nombre de todos los productos ya que al ser unique no puede repetirlo en el nuevo nombre
        If comprobarNombre(txtNombreNuevo.Text) = True Then
            conexion.Modificar(consulta2)
            consulta = "SELECT nombre FROM productos"
            buscar.buscarLoad(cbProductos, consulta, txtBuscar)
            limpiar()
        Else
            My.Forms.MsgboxPersonalizado.mensajeError("El producto ya existe en la base de datos")
            My.Forms.MsgboxPersonalizado.ShowDialog()
        End If

    End Sub
    Public Function comprobarNombre(ByVal nuevoNombre As String)
        Dim conn As New Conexion
        consulta = "SELECT nombre FROM productos WHERE nombre<>'" & cbProductos.Text & "'"
        Dim dr As MySqlDataReader
        dr = conn.buscar2(consulta)
        If dr.HasRows Then
            While dr.Read
                If dr.Item(0).ToString = nuevoNombre Then
                    Return False
                End If
            End While
        End If
        Return True
    End Function
    Public Sub limpiar()
        txtBuscar.Text = ""
        txtNombreNuevo.Text = ""
        cbCategoria.Items.Clear()
        rellenarProductos = "SELECT nombre FROM productos"
        buscar.buscarLoad(cbProductos, rellenarProductos, txtBuscar)
    End Sub
End Class
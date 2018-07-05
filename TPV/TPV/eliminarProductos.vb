Public Class eliminarProductos

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim con As New Conexion
        If cbProductos.Text = "" Then
            Dim mes As New MsgboxPersonalizado
            mes.mensajeAdvertencia("Debes seleccionar un producto para poder eliminarlo")
            mes.ShowDialog()
        Else
            Dim prod As String = cbProductos.Text
            'Dim con As New Conexion
            Dim c As New DataSet
            Dim cant As String

            Dim cantidad As String = "SELECT cantidad FROM stockalmacenes WHERE idProducto=(SELECT id FROM productos WHERE nombre='" & prod & "')"
            c = con.buscar(cantidad)
            cant = c.Tables(0).Rows(0).Item(0).ToString

            If cant = "0" Then
                Dim consultaStock As String = "DELETE FROM stockalmacenes WHERE idProducto=(SELECT id FROM productos WHERE nombre='" & prod & "')"
                con.Eliminar(consultaStock)
                Dim consulta As String = "DELETE FROM productos WHERE nombre='" & prod & "'"
                con.Eliminar(consulta)
                Dim mes As New MsgboxPersonalizado
                mes.mensajeConfirmacion(prod & " ha sido eliminado de la lista de productos")
                mes.ShowDialog()
            Else
                Dim mes As New MsgboxPersonalizado
                mes.mensajeError("No se puede eliminar un producto que tienes en el almacen")
                mes.ShowDialog()
            End If
        End If
        limpiar()
        Me.Refresh()
    End Sub

    Private Sub cbProductos_GotFocus(sender As Object, e As EventArgs) Handles cbProductos.GotFocus
        limpiar()
    End Sub

    Private Sub eliminarProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim buscar As New Buscar
        Dim consulta As String = "SELECT nombre FROM productos WHERE nombre LIKE '%" & txtBuscar.Text & "%'"
        buscar.buscarBuscar(cbProductos, consulta, txtBuscar)
    End Sub

    Private Sub txtBuscar_GotFocus(sender As Object, e As EventArgs) Handles txtBuscar.GotFocus
        limpiar()
    End Sub
    Private Sub cbProductos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbProductos.SelectedIndexChanged
        txtBuscar.Text = ""
    End Sub

    Public Sub limpiar()
        txtBuscar.Text = ""
        cbProductos.Text = ""
        Dim buscar As New Buscar
        Dim consulta As String = "SELECT nombre FROM productos"
        buscar.buscarLoad(cbProductos, consulta, txtBuscar)
    End Sub
End Class
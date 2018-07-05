Public Class listaProducto
    Dim NombreProducto As String
    Dim categoria As String
    Dim ds As New DataSet
    Public Sub establecerProducto(ByVal e As String)
        categoria = e
    End Sub

    Public Sub rellenar()
        Dim con As New Conexion
        Dim cons As String = "SELECT p.nombre, s.cantidad 'Cantidad Almacen' FROM productos p, stockalmacenes s WHERE s.idProducto=p.id AND p.categoria='" & categoria & "'"

        ds = con.buscar(cons)
        DataGridProductos.DataSource = ds.Tables(0).DefaultView
        DataGridProductos.Show()
    End Sub

    Private Sub DataGridProductos_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridProductos.CellMouseDoubleClick
        Try
            NombreProducto = ds.Tables(0).Rows(e.RowIndex).Item(e.ColumnIndex).ToString
            If e.ColumnIndex = 0 And NombreProducto <> "" Then
                My.Forms.VentanaEmergenteCantidad.recibirVariables(NombreProducto)
                My.Forms.VentanaEmergenteCantidad.ShowDialog()

            Else
                My.Forms.MsgboxPersonalizado.mensajeAdvertencia("Seleccione un producto, no categoria.")
                My.Forms.MsgboxPersonalizado.ShowDialog()
            End If
        Catch outRange As System.IndexOutOfRangeException
            My.Forms.MsgboxPersonalizado.mensajeAdvertencia("Seleccione un cuadro relleno, por favor")
            My.Forms.MsgboxPersonalizado.ShowDialog()
        End Try
    End Sub

End Class



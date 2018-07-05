Public Class almacenes
    Dim id As String
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If cbAlmacenes.Text = "" Then
            Dim msg As New MsgboxPersonalizado
            msg.mensajeError("Tienes que seleccionar un almacen!")
            msg.Show()
        Else
            Dim con As New Conexion
            Dim ds As New DataSet
            'Dim id As String
            Dim consulta As String = "SELECT id FROM almacenes WHERE nombre='" & cbAlmacenes.Text & "'"
            ds = con.buscar(consulta)
            id = ds.Tables(0).Rows(0).Item(0).ToString
            My.Forms.VentanaEmergenteCantidad.recibirIdAlmacen(id)
            My.Forms.agregarProductos.recibirIdAlmacen(id)
            My.Forms.Carrito.recibirIdAlmacen(id)
            Form1.almacen(id)
            Form1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub almacenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim b As New Buscar
        Dim consulta As String = "SELECT nombre FROM almacenes"
        b.buscarRellenarCombobox(cbAlmacenes, consulta)
    End Sub
End Class
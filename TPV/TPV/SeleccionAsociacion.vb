Public Class SeleccionAsociacion
    Dim id As String
    Private Sub SeleccionAsociacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim b As New Buscar
        Dim consulta As String = "SELECT nombre FROM asociaciones"
        b.buscarRellenarCombobox(cbAsociaciones, consulta)
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If cbAsociaciones.Text = "" Then
            Dim msg As New MsgboxPersonalizado
            msg.mensajeError("¡Tienes que seleccionar una Asociacion!")
            msg.Show()
        Else
            Dim con As New Conexion
            Dim ds As New DataSet
            Dim consulta As String = "SELECT id FROM asociaciones WHERE nombre='" & cbAsociaciones.Text & "'"
            ds = con.buscar(consulta)
            id = ds.Tables(0).Rows(0).Item(0).ToString
            My.Forms.Carrito.recibirIdAsociacion(id)
            Me.Close()
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class
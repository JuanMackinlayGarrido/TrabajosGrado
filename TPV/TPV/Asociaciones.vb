Public Class Asociaciones
    Private Sub Asociaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New Conexion
        Dim ds As New DataSet
        Dim consulta As String = "SELECT nombre, telefono, direccion FROM asociaciones"

        ds = con.buscar(consulta)
        gridAsociaciones.DataSource = ds.Tables(0).DefaultView
        gridAsociaciones.Show()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        My.Forms.AgregarAsociacion.limpiar()
        principal.añadirPanel(AgregarAsociacion)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim conexion As New Conexion
        Dim ds As New DataSet
        Dim consulta As String = "SELECT nombre,direccion,telefono FROM asociaciones WHERE (nombre LIKE '%" & txtBuscar.Text & "%') OR (direccion LIKE '%" & txtBuscar.Text & "%')"
        ds = conexion.buscar(consulta)
        gridAsociaciones.DataSource = ds.Tables(0).DefaultView
        gridAsociaciones.Show()
    End Sub
End Class
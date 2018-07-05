Public Class InformeEntradaxFecha
    Dim fInicio As String
    Dim fFin As String
    Public Sub agregarFechas(ByVal Ini As String, ByVal fin As String)
        fInicio = Ini
        fFin = fin
    End Sub
    Private Sub InformeEntradaxFecha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsInformeEntradaFecha.informe_entrada_por_fecha' Puede moverla o quitarla según sea necesario.
        Me.Informe_entrada_por_fechaTableAdapter.FillByFecha(Me.DsInformeEntradaFecha.informe_entrada_por_fecha, fInicio, fFin)

        Dim rpt As New CRInformeEntradaFecha
        rpt.SetDataSource(DsInformeEntradaFecha)
        CRWInformeEntradaFecha.ReportSource = rpt
    End Sub
End Class
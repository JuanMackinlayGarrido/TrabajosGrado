Public Class InformeStock
    Private Sub InformeStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSInformeStock.informe_stock' Puede moverla o quitarla según sea necesario.
        Me.Informe_stockTableAdapter.Fill(Me.DSInformeStock.informe_stock)

        Dim rpt As New CRInformeStock
        rpt.SetDataSource(DSInformeStock)
        CRViewerInformeStock.ReportSource = rpt
    End Sub
End Class
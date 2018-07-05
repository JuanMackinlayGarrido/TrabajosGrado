Public Class Albaran
    Private Sub Albaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsAlbaran.albaran' Puede moverla o quitarla según sea necesario.
        Me.AlbaranTableAdapter.Fill(Me.DsAlbaran.albaran)

        Dim rpt As New crAlbaran
        rpt.SetDataSource(DsAlbaran)
        crvAlbaran.ReportSource = rpt
    End Sub

End Class
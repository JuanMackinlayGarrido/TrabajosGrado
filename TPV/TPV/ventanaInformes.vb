Public Class ventanaInformes
    Private Sub Line1_Click(sender As Object, e As EventArgs) Handles Line1.Click

    End Sub

    Private Sub btnInfEntradaFecha_Click(sender As Object, e As EventArgs) Handles btnInfEntradaFecha.Click
        My.Forms.InformeEntradaxFecha.agregarFechas(dtpFechaInicio.Value.ToString, dtpFechaFin.Value.ToString)
        My.Forms.InformeEntradaxFecha.ShowDialog()
    End Sub

    Private Sub btnInformeStock_Click(sender As Object, e As EventArgs) Handles btnInformeStock.Click
        My.Forms.InformeStock.ShowDialog()
    End Sub
End Class
Public Class principal
    Dim tipo As String
    Private Sub btnLegumbres_Click(sender As Object, e As EventArgs) Handles btnLegumbres.Click
        tipo = "Legumbres"
        listaProducto.establecerProducto(tipo)
        listaProducto.rellenar()
        añadirPanel(listaProducto)
    End Sub

    Public Sub añadirPanel(formu As Form)
        If (Form1.panelPrincipal.Controls.Count > 0) Then
            Form1.panelPrincipal.Controls.Clear()
            Form1.panelPrincipal.Dock = DockStyle.Fill
            formu.TopLevel = False
            Form1.panelPrincipal.Controls.Add(formu)
            formu.Show()
        Else
            Form1.panelPrincipal.Dock = DockStyle.Fill
            formu.TopLevel = False
            Form1.panelPrincipal.Controls.Add(formu)
            formu.Show()
        End If
    End Sub

    Private Sub btnCereales_Click(sender As Object, e As EventArgs) Handles btnCereales.Click
        tipo = "Cereales"
        listaProducto.establecerProducto(tipo)
        listaProducto.rellenar()
        añadirPanel(listaProducto)
    End Sub

    Private Sub btnPasta_Click(sender As Object, e As EventArgs) Handles btnPasta.Click
        tipo = "Pasta"
        listaProducto.establecerProducto(tipo)
        listaProducto.rellenar()
        añadirPanel(listaProducto)
    End Sub

    Private Sub btnConservas_Click(sender As Object, e As EventArgs) Handles btnConservas.Click
        tipo = "Conservas"
        listaProducto.establecerProducto(tipo)
        listaProducto.rellenar()
        añadirPanel(listaProducto)
    End Sub

    Private Sub btnLacteos_Click(sender As Object, e As EventArgs) Handles btnLacteos.Click
        tipo = "Lacteos"
        listaProducto.establecerProducto(tipo)
        listaProducto.rellenar()
        añadirPanel(listaProducto)
    End Sub

    Private Sub btnOtros_Click(sender As Object, e As EventArgs) Handles btnOtros.Click
        tipo = "Otros"
        listaProducto.establecerProducto(tipo)
        listaProducto.rellenar()
        añadirPanel(listaProducto)
    End Sub

End Class
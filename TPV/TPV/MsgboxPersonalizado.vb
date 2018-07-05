Public Class MsgboxPersonalizado
    Private Sub MsgboxPersonalizado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(201, 147)
    End Sub
    Public Sub mensajeError(cadena As String)
        pbAdvertencia.Visible = False
        pbCorrecto.Visible = False
        pbError.Visible = True
        lblMensaje.Text = cadena
    End Sub
    Public Sub mensajeConfirmacion(cadena As String)
        pbAdvertencia.Visible = False
        pbError.Visible = False
        pbCorrecto.Visible = True
        lblMensaje.Text = cadena
    End Sub
    Public Sub mensajeAdvertencia(cadena As String)
        pbError.Visible = False
        pbCorrecto.Visible = False
        pbAdvertencia.Visible = True
        lblMensaje.Text = cadena
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Close()
    End Sub

End Class
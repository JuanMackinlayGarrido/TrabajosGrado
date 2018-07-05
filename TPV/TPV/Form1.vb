Public Class Form1
    Dim idalmacen As String
    Public Sub almacen(ByVal id As String)
        idalmacen = id
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        añadirPanel(principal)
        añadirPanelCarrito(Carrito)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        My.Forms.agregarProductos.limpiar()
        añadirPanel(agregarProductos)

    End Sub

    Private Sub añadirPanel(formu As Form)
        If (panelPrincipal.Controls.Count > 0) Then
            panelPrincipal.Controls.Clear()
            formu.TopLevel = False
            panelPrincipal.Controls.Add(formu)
            formu.Show()
        Else
            formu.TopLevel = False
            panelPrincipal.Controls.Add(formu)
            formu.Show()
        End If
    End Sub
    Private Sub añadirPanelCarrito(formu As Form)
        If (panelCarrito.Controls.Count > 0) Then
            panelCarrito.Controls.Clear()
            panelCarrito.Dock = DockStyle.Right
            formu.TopLevel = False
            panelCarrito.Controls.Add(formu)
            formu.Show()
        Else
            formu.TopLevel = False
            panelCarrito.Controls.Add(formu)
            formu.Show()
        End If
    End Sub
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Application.Exit()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        My.Forms.eliminarProductos.limpiar()
        añadirPanel(eliminarProductos)
    End Sub

    Private Sub btnPrincipal_Click(sender As Object, e As EventArgs) Handles btnPrincipal.Click
        añadirPanel(principal)
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        My.Forms.modificarProducto.limpiar()
        añadirPanel(modificarProducto)
    End Sub

    Private Sub btnAsociacion_Click(sender As Object, e As EventArgs) Handles btnAsociacion.Click
        añadirPanel(Asociaciones)
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        añadirPanel(ventanaInformes)
    End Sub
End Class

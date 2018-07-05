Imports MySql.Data.MySqlClient
Public Class VentanaEmergenteCantidad
    Dim producto As String
    Dim idAlmacen As Integer
    Dim conexion As New Conexion
    Dim conexion2 As New Conexion

    Public Sub ventana(Form As Form)

    End Sub

    Public Sub recibirIdAlmacen(idd As String)
        idAlmacen = idd
    End Sub

    Public Sub recibirVariables(nomProducto As String)
        producto = nomProducto
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        'Dim idEntrada As Integer
        Dim idProd As Integer
        Dim ds As New DataSet()
        Dim x As String = txtCantidad.Text

        If Mid(x, 1, 1) = "0" Or x = "" Then
            lblError.Show()
        Else
            Dim cantidad As Integer = txtCantidad.Text
            Dim dr As MySqlDataReader
            Dim conec As New Conexion

            'Coger los productos del carrito y compararlos con el seleccionado por si coincide hacer un update
            If comprobarCarrito(producto) = False Then
                conec.Insertar("INSERT INTO carrito(producto, cantidad) VALUES('" & producto & "', " & cantidad & ")")
            End If

            Dim con As New Conexion
            Dim cons As String = "SELECT producto, cantidad FROM carrito"
            ds = con.buscar(cons)
            Carrito.DataGridCarrito.DataSource = ds.Tables(0).DefaultView
            Carrito.DataGridCarrito.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        My.Forms.VentanaEmergenteCantidad.Close()
    End Sub

    Private Sub txtCantidad_GotFocus(sender As Object, e As EventArgs) Handles txtCantidad.GotFocus
        txtCantidad.Clear()
        lblError.Hide()
    End Sub
    Private Sub txtBuscar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Not ((IsNumeric(e.KeyChar)) Or (e.KeyChar.GetHashCode = 524296)) Then
            e.Handled = True
        End If

    End Sub
    Private Sub VentanaEmergenteCantidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblError.Hide()
        txtCantidad.Text = ""
    End Sub

    Private Function comprobarCarrito(ByVal prod As String)
        Dim con2 As New Conexion
        Dim consulta As String = "SELECT producto FROM carrito"
        Dim ds2 As New DataSet()
        ds2 = con2.buscar(consulta)

        For Each row As DataRow In ds2.Tables(0).Rows
            If row("producto") = prod Then
                Dim actualizar As String = "UPDATE carrito SET cantidad=(cantidad+'" & txtCantidad.Text & "') WHERE producto='" & producto & "'"
                Dim con3 As New Conexion
                con3.Modificar(actualizar)
                Return True
            End If
        Next
        Return False
    End Function
End Class

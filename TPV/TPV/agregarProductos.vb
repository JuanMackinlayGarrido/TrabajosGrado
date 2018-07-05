Imports MySql.Data.MySqlClient
Public Class agregarProductos
    Dim cmp As New Comprobaciones
    Dim buscador As New Buscar
    Dim idAlmacen As Integer
    Public Sub recibirIdAlmacen(id As String)
        idAlmacen = id
    End Sub
    Private Sub agregarProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombre.Text = ""
        Dim consulta As String = "SELECT * FROM categorias"
        buscador.buscarRellenarCombobox(cbCategorias, consulta)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim nombre As String
        Dim categoria As String
        Dim cont As Integer = 0
        Dim conn As New Conexion
        nombre = txtNombre.Text
        If cmp.comprobarComillas(nombre) = True Then
            If cmp.comprobarNombre(nombre) = False Then
                My.Forms.MsgboxPersonalizado.mensajeError("Nombre de producto incorrecto")
                My.Forms.MsgboxPersonalizado.ShowDialog()
                'MsgBox("Nombre Incorrecto")
                cont += 1
                Exit Sub
            End If
        Else
            My.Forms.MsgboxPersonalizado.mensajeError("Caracter Incorrecto, introduzca otro nombre.")
            My.Forms.MsgboxPersonalizado.ShowDialog()
            'MsgBox("Caracter Incorrecto, introduzca otro nombre.")
            cont += 1
            Exit Sub
        End If

        categoria = cbCategorias.Text
        If cmp.comprobarNombre(categoria) = False Then
            My.Forms.MsgboxPersonalizado.mensajeError("Categoria Incorrecta.")
            My.Forms.MsgboxPersonalizado.ShowDialog()
            'MsgBox("Categoria Incorrecta")
            cont += 1
            Exit Sub
        End If

        If cont = 0 Then
            Try
                Dim con As New Conexion
                Dim consulta As String = "INSERT INTO productos(nombre,categoria) VALUES('" & nombre & "', '" & categoria & "')"
                con.Insertar(consulta)

                'MsgBox("Producto agregado correctamente a " & categoria & ".")
                txtNombre.Clear()
                cbCategorias.Text = ""
            Catch ex As Exception
                MsgBox(ex.Data.Values)
            End Try

        End If


        'Lo que hacemos es que cada vez que creemos un producto en la bd se cree en la tabla stockalmacenes con un stock inicial de 0
        Dim dr As MySqlDataReader
        Dim ConIdProducto As String = "SELECT id FROM productos WHERE nombre='" & nombre & "'"
        Dim idProducto As Integer
        dr = conn.buscar2(ConIdProducto)
        If dr.HasRows Then
            While dr.Read
                idProducto = dr.Item(0)
            End While
        End If
        dr.Close()

        Dim conexion As New Conexion
        Dim insertStock As String = "INSERT INTO stockalmacenes VALUES(" & idAlmacen & "," & idProducto & ",0)"
        conexion.Insertar(insertStock)

        txtNombre.Text = ""
        Dim consulta3 As String = "SELECT * FROM categorias"
        buscador.buscarRellenarCombobox(cbCategorias, consulta3)

        My.Forms.MsgboxPersonalizado.mensajeConfirmacion("Producto agregado correctamente a " & categoria & ".")
        My.Forms.MsgboxPersonalizado.ShowDialog()
        Me.Refresh()
    End Sub
    Public Sub limpiar()
        txtNombre.Text = ""
        cbCategorias.Text = ""
        Dim consulta As String = "SELECT nombre FROM categorias"
        buscador.buscarLoad(cbCategorias, consulta, txtNombre)
    End Sub
End Class
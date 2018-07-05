Imports MySql.Data.MySqlClient
Public Class Carrito
    Dim idAlmacen As Integer
    Dim idAsociacion As Integer

    Public Sub recibirIdAlmacen(idd As String)
        idAlmacen = idd
    End Sub

    Public Sub recibirIdAsociacion(id As String)
        idAsociacion = id
    End Sub

    Private Sub btnEntrada_Click(sender As Object, e As EventArgs) Handles btnEntrada.Click
        Dim conexion As New Conexion
        Dim ds As New DataSet
        Dim cons As String = "SELECT producto, cantidad FROM carrito"
        Dim producto As String
        Dim cantidad As Integer
        Dim id_producto As Integer
        Dim idEntrada As Integer

        'Realizamos el primer insert en la tabla entradas ya que es la primera en la que hay que hacerlo para luego usar su id.
        Dim consulta As String = "INSERT INTO entradas(fecha) VALUES('" & DateTime.Now.ToString & "')"
        Dim conexion2 As New Conexion
        conexion2.Insertar(consulta)

        'Dim dr As MySqlDataReader
        ds = conexion.buscar(cons)
        If (ds.Tables(0).Rows.Count > 0) Then
            For Each row As DataRow In ds.Tables(0).Rows
                producto = row("producto").ToString
                cantidad = row("cantidad")
                Dim idProducto As String = "SELECT id FROM productos WHERE nombre='" & producto & "'"
                Dim dr As MySqlDataReader
                dr = conexion.buscar2(idProducto)
                If dr.HasRows Then
                    While dr.Read()
                        id_producto = dr.Item(0)




                        Dim dr2 As MySqlDataReader
                        Dim MaxIdEntrada As String = "SELECT max(id) FROM entradas"
                        Dim conexion3 As New Conexion
                        dr2 = conexion3.buscar2(MaxIdEntrada)
                        If dr2.HasRows Then
                            While dr2.Read()
                                idEntrada = dr2.Item(0)

                                Dim consulta2 As String = "INSERT INTO entradaproducto VALUES(" & idEntrada & "," & idAlmacen & "," & id_producto & "," & cantidad & ")"
                                Dim conexion4 As New Conexion
                                conexion4.Insertar(consulta2)

                                Dim consulta3 As String = "UPDATE stockalmacenes SET cantidad=(cantidad+" & cantidad & ") WHERE idAlmacen=" & idAlmacen & " AND idProducto=" & id_producto
                                Dim conexion5 As New Conexion
                                conexion5.Modificar(consulta3)


                            End While
                        End If
                        dr2.Close()


                    End While
                End If
                dr.Close()
            Next
        End If

        Dim conex7 As New Conexion
        Dim consulta4 As String = "DELETE FROM Carrito"
        conex7.Eliminar(consulta4)
        My.Forms.MsgboxPersonalizado.mensajeConfirmacion("Entrada limpia de productos.")
        My.Forms.MsgboxPersonalizado.ShowDialog()

        Dim con As New Conexion
        Dim consulta5 As String = "SELECT producto, cantidad FROM carrito"
        ds = con.buscar(consulta5)
        DataGridCarrito.DataSource = ds.Tables(0).DefaultView
        DataGridCarrito.Show()
    End Sub

    Private Sub btnSalida_Click(sender As Object, e As EventArgs) Handles btnSalida.Click
        Dim conexion As New Conexion
        Dim ds As New DataSet

        Dim producto As String
        Dim cantidad As Integer
        Dim cantidadActual As Integer
        Dim id_producto As Integer
        Dim idSalida As Integer


        'Primero comprobamos si las cantidades de nuestro carrito son cubridas por el stock del almacen
        Dim cons As String = "SELECT producto, cantidad FROM carrito"
        ds = conexion.buscar(cons)
        If (ds.Tables(0).Rows.Count > 0) Then
            For Each row As DataRow In ds.Tables(0).Rows
                producto = row("producto").ToString
                cantidad = row("cantidad")
                Dim dr3 As MySqlDataReader
                Dim consul As String = "SELECT cantidad FROM stockalmacenes WHERE idProducto = (SELECT id FROM productos WHERE nombre ='" & producto & "') AND idAlmacen = " & idAlmacen
                Dim conexion6 As New Conexion
                dr3 = conexion6.buscar2(consul)
                If dr3.HasRows Then
                    While dr3.Read()
                        cantidadActual = dr3.Item(0)

                        If ((cantidadActual - cantidad) < 0) Then
                            My.Forms.MsgboxPersonalizado.mensajeAdvertencia("No tienes suficiente stock de " & producto & ", por favor cambia la cantidad")
                            My.Forms.MsgboxPersonalizado.ShowDialog()
                            Exit Sub
                        End If
                    End While
                End If
                dr3.Close()
            Next
        End If

        'Mostramos y escogemos la asociacion a la cual donaremos
        My.Forms.SeleccionAsociacion.ShowDialog()

        'Realizamos el primer insert en la tabla salidas ya que es la primera en la que hay que hacerlo para luego usar su id.
        Dim consulta As String = "INSERT INTO salidas(idAsociacion, fecha) VALUES(" & idAsociacion & ", '" & DateTime.Now.ToString & "')"
        Dim conexion2 As New Conexion
        conexion2.Insertar(consulta)

        Dim conexion8 As New Conexion
        ds = conexion8.buscar(cons)
        If (ds.Tables(0).Rows.Count > 0) Then
            For Each row As DataRow In ds.Tables(0).Rows
                producto = row("producto").ToString
                cantidad = row("cantidad")
                Dim idProducto As String = "SELECT id FROM productos WHERE nombre='" & producto & "'"
                Dim dr As MySqlDataReader
                dr = conexion.buscar2(idProducto)
                If dr.HasRows Then
                    While dr.Read()
                        id_producto = dr.Item(0)

                        Dim dr2 As MySqlDataReader
                        Dim MaxIdSalida As String = "SELECT max(id) FROM salidas"
                        Dim conexion3 As New Conexion
                        dr2 = conexion3.buscar2(MaxIdSalida)
                        If dr2.HasRows Then
                            While dr2.Read()
                                idSalida = dr2.Item(0)

                                Dim consulta2 As String = "INSERT INTO salidaproducto VALUES(" & idSalida & "," & idAlmacen & "," & id_producto & "," & cantidad & ")"
                                Dim conexion4 As New Conexion
                                conexion4.Insertar(consulta2)


                                Dim consulta3 As String = "UPDATE stockalmacenes SET cantidad=cantidad-(" & cantidad & ") WHERE idAlmacen=" & idAlmacen & " AND idProducto=" & id_producto
                                Dim conexion5 As New Conexion
                                conexion5.Modificar(consulta3)


                            End While
                        End If
                        dr2.Close()


                    End While
                End If
                dr.Close()
            Next
        End If

        Dim conex7 As New Conexion
        Dim consulta4 As String = "DELETE FROM Carrito"
        conex7.Eliminar(consulta4)
        My.Forms.MsgboxPersonalizado.mensajeConfirmacion("Salida limpia de productos.")
        My.Forms.MsgboxPersonalizado.ShowDialog()
        Albaran.ShowDialog()

        Dim con As New Conexion
        Dim consulta5 As String = "SELECT producto, cantidad FROM carrito"
        ds = con.buscar(consulta5)
        DataGridCarrito.DataSource = ds.Tables(0).DefaultView
        DataGridCarrito.Show()
    End Sub

    Private Sub Carrito_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
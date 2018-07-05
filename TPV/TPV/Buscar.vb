Imports MySql.Data.MySqlClient
Public Class Buscar
    Dim conn As New Conexion
    Dim conexion As New MySqlConnection
    Public Sub buscarLoad(ByVal combobox As ComboBox, consulta As String, txt As TextBox)
        txt.Text = ""
        combobox.Text = ""
        combobox.Items.Clear()
        Try
            If conexion.State = ConnectionState.Closed Then
                conexion = conn.conectar
            End If
            Dim dr As MySqlDataReader

            dr = conn.buscar2(consulta)
            If dr.HasRows Then
                While dr.Read()
                    combobox.Items.Add(dr.Item(0))
                End While
            End If
            dr.Close()
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub buscarBuscar(ByVal combobox As ComboBox, consulta As String, txt As TextBox)
        Dim dr As MySqlDataReader
        Try
            If conexion.State = ConnectionState.Closed Then
                conexion = conn.conectar
            End If
            If txt.Text <> "" Then
                dr = conn.buscarDatosReader(consulta, combobox)
                If dr.HasRows Then
                    combobox.DroppedDown = True
                    While dr.Read()
                        combobox.Items.Add(dr.Item(0))
                    End While
                Else
                    MsgBox("Búsqueda sin resultados")

                End If
                dr.Close()

                conexion.Close()
            Else
                MsgBox("Introduce datos para realizar la busqueda")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub buscarRellenarCombobox(ByVal combobox As ComboBox, consulta As String)
        combobox.Text = ""
        combobox.Items.Clear()
        Try
            If conexion.State = ConnectionState.Closed Then
                conexion = conn.conectar
            End If
            Dim dr As MySqlDataReader

            dr = conn.buscar2(consulta)
            If dr.HasRows Then
                While dr.Read()
                    combobox.Items.Add(dr.Item(0))
                End While
            End If
            dr.Close()
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub buscarLabel(ByVal combobox As ComboBox, consulta As String, lbl As Label)
        Dim dr As MySqlDataReader
        Try
            If conexion.State = ConnectionState.Closed Then
                conexion = conn.conectar
            End If
            If lbl.Text <> "" Then
                dr = conn.buscarDatosReader(consulta, combobox)
                If dr.HasRows Then
                    'combobox.DroppedDown = True
                    While dr.Read()
                        combobox.Items.Add(dr.Item(0))
                    End While
                Else
                    MsgBox("Búsqueda sin resultados")

                End If
                dr.Close()
                conexion.Close()
            Else
                MsgBox("Introduce datos para realizar la busqueda")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class

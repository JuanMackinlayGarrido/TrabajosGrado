Imports MySql.Data.MySqlClient
Public Class Conexion
    Dim txtConnection As String = "Server= 127.0.0.1; Database=tpv; Uid=root; Pwd=;"
    Dim conn As New MySqlConnection(txtConnection)
    Dim ds As New DataSet

    Public Function conectar() As MySqlConnection
        conn.Open()
        Return conn
    End Function

    Public Function Insertar(ByVal cons As String) As Integer
        Dim Res As Integer
        Try
            If (conn.State = ConnectionState.Closed) Then
                conn.Open()
                Dim comm As New MySqlCommand(cons, conn)
                Res = comm.ExecuteNonQuery()
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Res
    End Function

    Public Function Modificar(ByVal cons As String) As Integer
        Dim Res As Integer
        Try
            If (conn.State = ConnectionState.Closed) Then
                conn.Open()
                Dim comm As New MySqlCommand(cons, conn)
                Res = comm.ExecuteNonQuery()
                conn.Close()
            Else
                Dim comm As New MySqlCommand(cons, conn)
                Res = comm.ExecuteNonQuery()
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Res
    End Function

    Public Sub Eliminar(ByVal cons As String)
        Try
            If (conn.State = ConnectionState.Closed) Then
                conn.Open()
                Dim comm As New MySqlCommand(cons, conn)
                comm.ExecuteReader()
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            ex.GetHashCode()
        End Try
    End Sub

    Public Function buscar(ByVal cons As String)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim comm As New MySqlCommand(cons, conn)
        Dim adap As New MySqlDataAdapter(comm)
        adap.Fill(ds)
        conn.Close()
        Return ds
    End Function
    Public Function buscar2(ByVal cons As String)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim comm As New MySqlCommand(cons, conn)
            Dim dr As MySqlDataReader
            dr = comm.ExecuteReader()
            Return dr
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function buscarDatosReader(ByVal cons As String, ByVal combobox As ComboBox)
        combobox.Items.Clear()
        combobox.Text = ""
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim dr As MySqlDataReader
            Dim comm As New MySqlCommand(cons, conn)
            dr = comm.ExecuteReader()
            Return dr

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class

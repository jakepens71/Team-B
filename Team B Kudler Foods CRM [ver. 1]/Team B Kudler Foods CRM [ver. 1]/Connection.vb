Public Class Connection
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../../Database/Customer_Database.accdb")
    Dim newConnection As OleDb.OleDbConnection

    Public Function createConnection() As OleDb.OleDbConnection
        Try

            con.Open()
        Return con
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try


    End Function

    Public Sub closeConnection()
        con.Close()
    End Sub

End Class

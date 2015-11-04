Imports System.Data.OleDb

Public Class SearchCustomer
    'Create new instance of the Connection class to manage the connection to access database'
    Dim myConnection As New Connection

    'Create a new databaseCommand variable'
    Dim databaseCommand As New OleDb.OleDbCommand

    'Initalize variables for query
    Dim firstName As String
    Dim lastName As String

    'Initalize result variables'
    Dim resultFirstName As String
    Dim resultLastName As String

    'Initalize customer object'
    Dim newCustomer = New Customer()


    Private Sub SearchCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load




    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearchFirstName.Text = "" Or txtSearcLastName.Text = "" Then
            MessageBox.Show("First or Last Name Can NOT be blank")

        Else
            'Get the values'
            firstName = txtSearchFirstName.Text
            lastName = txtSearcLastName.Text

            'Specify command for database'
            databaseCommand.CommandType = CommandType.Text
            databaseCommand.CommandText = "SELECT * FROM CUSTOMER where [First_Name] Like :1"
            databaseCommand.Parameters.Add(New OleDbParameter(":1", firstName))
            databaseCommand.Parameters.Add(New OleDbParameter(":2", lastName))
            databaseCommand.Connection = myConnection.createConnection()

            Dim resultReader As OleDbDataReader = databaseCommand.ExecuteReader()


            If resultReader.HasRows Then
                resultFirstName = resultReader.GetValue(0).ToString()
                resultLastName = resultReader.GetValue(1).ToString()
            Else
                MessageBox.Show("No data returned")
            End If







        End If
    End Sub
End Class
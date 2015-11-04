Imports System.Data.OleDb
Imports System.Random

Public Class CustomerForm
    'Create new instance of the Connection class to manage the connection to access database'
    Dim myConnection As New Connection

    'Create a new databaseCommand variable'
    Dim databaseCommand As New OleDb.OleDbCommand

    'Create a new database Command to select the customer that we just created so we can create them a rewards card'
    Dim databaseSelectCustomer As New OleDb.OleDbCommand

    'Create new database Comand to insert and intailize the actual rewards card for that particular customer'
    Dim databaseInsertRewardsCardtoCustomer As New OleDb.OleDbCommand


    'Create local variables for the customer information
    Dim customerFirstName As String
    Dim customerMiddleName As String
    Dim customerLastName As String
    Dim customerAddress As String
    Dim customerPhoneNumber As String
    Dim customerEmail As String

    'Create number card generator for rewards card'
    Dim CustomerRewardsCardNumber As String
    Dim getCustomerRewardsCard As String


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub CustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Check and make sure that the fields are not blank
        If txtFirstName.Text = "" Or txtMiddleName.Text = "" Or txtLastName.Text = "" Or txtAddress.Text = "" Or txtPhoneNumber.Text = "" Then
            MessageBox.Show("Invalid Entry. One or more fields are blank. Please fill out all avaiable fields")

        Else
            customerFirstName = txtFirstName.Text
            customerMiddleName = txtMiddleName.Text
            customerLastName = txtLastName.Text
            customerAddress = txtAddress.Text
            customerPhoneNumber = txtPhoneNumber.Text
            customerEmail = txtEmail.Text

            'Create local variable connection since we are going to be using it more than once'

            Dim connection As OleDb.OleDbConnection
            connection = myConnection.createConnection()

            'Fields are not blank'
            'Create Connection to the Access Database and make sure our database command is going to use that connection'
            databaseCommand.Connection = connection

            'Tell what command type our database command is going to be. In this case its a standard SQL Insert command as Text'
            databaseCommand.CommandType = CommandType.Text

            'Our actual command text or sql insert statement'
            databaseCommand.CommandText = "INSERT INTO Customer ([First_Name], [Middle_Name], [Last_Name], Address, [Phone_Number], Email) Values (:1, :2, :3, :4, :5, :6)"

            'Define parameters
            databaseCommand.Parameters.Add(New OleDbParameter(":1", customerFirstName))
            databaseCommand.Parameters.Add(New OleDbParameter(":2", customerMiddleName))
            databaseCommand.Parameters.Add(New OleDbParameter(":3", customerLastName))
            databaseCommand.Parameters.Add(New OleDbParameter(":4", customerAddress))
            databaseCommand.Parameters.Add(New OleDbParameter(":5", customerPhoneNumber))
            databaseCommand.Parameters.Add(New OleDbParameter(":6", customerEmail))

            'Execute the sql statement'
            databaseCommand.ExecuteNonQuery()

            'Now we want to select this customer so we can generate a new card for them and attach it to their account in the database'
            getCustomerRewardsCard = randomRewardsCardGenerator()

            databaseSelectCustomer.Connection = connection

            databaseCommand.CommandType = CommandType.Text

            databaseSelectCustomer.CommandText = "SELECT C.ID FROM CUSTOMER C where C.First_Name = :1 and C.Middle_Name = :2 and C.Last_Name = :3 and C.Address = :4 and C.Phone_Number = :5 and C.Email = :6"

            databaseSelectCustomer.Parameters.Add(New OleDbParameter(":1", customerFirstName))
            databaseSelectCustomer.Parameters.Add(New OleDbParameter(":2", customerMiddleName))
            databaseSelectCustomer.Parameters.Add(New OleDbParameter(":3", customerLastName))
            databaseSelectCustomer.Parameters.Add(New OleDbParameter(":4", customerAddress))
            databaseSelectCustomer.Parameters.Add(New OleDbParameter(":5", customerPhoneNumber))
            databaseSelectCustomer.Parameters.Add(New OleDbParameter(":6", customerEmail))

            'Create new customerID so we can store the customer ID from the database
            Dim customerID As Integer

            'Get the specific customer ID from the database
            customerID = databaseSelectCustomer.ExecuteNonQuery()

            'Create new databse command to insert this new informtion into the 'RewardsCards' table
            databaseInsertRewardsCardtoCustomer.Connection = connection

            databaseInsertRewardsCardtoCustomer.CommandType = CommandType.Text

            databaseInsertRewardsCardtoCustomer.CommandText = "INSERT INTO RewardsCards (CardNumber, [Customer_ID], RewardsPoints, FuturePoints) VALUES (:1, :2, :3, :4)"

            databaseInsertRewardsCardtoCustomer.Parameters.Add(New OleDbParameter(":1", getCustomerRewardsCard))
            databaseInsertRewardsCardtoCustomer.Parameters.Add(New OleDbParameter(":2", customerID))
            databaseInsertRewardsCardtoCustomer.Parameters.Add(New OleDbParameter(":3", 0))
            databaseInsertRewardsCardtoCustomer.Parameters.Add(New OleDbParameter(":4", 0))

            databaseInsertRewardsCardtoCustomer.ExecuteNonQuery()


            'Close Connection to Access Database'
            connection.Close()

            'Close this form'
            Me.Close()

        End If

    End Sub

    'Private function that generates a series of 9 random numbers for the rewards card program in Kudler Fine Foods
    Private Function randomRewardsCardGenerator() As String
        For i = 1 To 1000 Step 1

            Dim RandomClass As New Random()


            CustomerRewardsCardNumber = RandomClass.Next(1, 999999999).ToString

            If CustomerRewardsCardNumber.Length < 9 Then
                CustomerRewardsCardNumber = CustomerRewardsCardNumber.PadLeft(9, "0")
            End If

        Next
        Return CustomerRewardsCardNumber
    End Function

End Class
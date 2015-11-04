Public Class MainForm
    Dim customerName As String



    Private Sub btnCreateCustomer_Click(sender As Object, e As EventArgs) Handles btnCreateCustomer.Click
        If (radSearchCustomer.Checked = True) Then
            Dim searchCustomer As SearchCustomer

            searchCustomer = New SearchCustomer()
            searchCustomer.Show()


        End If

        If (rdCreateCustomer.Checked = True) Then
            Dim CustForm As CustomerForm
            CustForm = New CustomerForm()
            CustForm.Show()
            'CustForm = Nothing'
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

    End Sub

    Private Sub radViewCustomer_CheckedChanged(sender As Object, e As EventArgs) Handles radSearchCustomer.CheckedChanged

    End Sub
End Class

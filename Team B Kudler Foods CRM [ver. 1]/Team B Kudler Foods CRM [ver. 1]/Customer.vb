Public Class Customer
    Dim customerFirstName As String
    Dim customerLastName As String

    Public Property firstName As String
        Get
            Return customerFirstName
        End Get
        Set(value As String)
            customerFirstName = value
        End Set
    End Property

End Class

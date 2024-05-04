Imports MySql.Data.MySqlClient

Module DatabaseHelper
    Private ReadOnly connectionString As String = "server=localhost;user=root;password=1234;database=schoolMS-db"

    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(connectionString)
    End Function
End Module

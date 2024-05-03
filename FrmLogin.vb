Imports MySql.Data.MySqlClient

Public Class FrmLogin

    Private connectionString As String = "server=localhost;userid=root;password=1234;database=schoolMS-db"
    Private connection As MySqlConnection

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New MySqlConnection(connectionString)
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If AuthenticateUser(username, password) Then
            Dim mainForm As New FrmMain
            mainForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password!")
        End If

    End Sub


    Private Function AuthenticateUser(username As String, password As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM tbl_users WHERE username = @username AND password = @password"
        Dim count As Integer

        Using cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)

            Try
                connection.Open()
                count = Convert.ToInt32(cmd.ExecuteScalar())
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
                Return False
            Finally
                connection.Close()
            End Try
        End Using

        Return count > 0
    End Function

End Class
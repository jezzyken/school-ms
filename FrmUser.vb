Imports MySql.Data.MySqlClient

Public Class FrmUser

    Inherits Form

    Public Event OperationSuccessful()

    Public Property UserId As Integer
    Public Property UserRole As String
    Public Property FirstName As String
    Public Property MiddleName As String
    Public Property LastName As String
    Private _isUpdate As Boolean = False

    Public Sub New()
        InitializeComponent()
        btnSave.Text = "Add"
        _isUpdate = False

    End Sub

    Public Sub New(id As Integer, role As String, fname As String, mname As String, lname As String)
        InitializeComponent()

        UserId = id
        UserRole = role
        FirstName = fname
        MiddleName = mname
        LastName = lname

        cboRole.Text = UserRole
        txtFname.Text = FirstName
        txtMname.Text = MiddleName
        txtLname.Text = LastName

        btnSave.Text = "Update"
        _isUpdate = True

    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If _isUpdate Then
            If UpdateUser() Then
                RaiseEvent OperationSuccessful()
                Me.Close()
            Else
                MessageBox.Show("Failed to update teacher.")
            End If
        Else

            If AddUser() Then
                RaiseEvent OperationSuccessful()
                MessageBox.Show("Teacher added successfully.")
                Me.Close()
            Else
                MessageBox.Show("Failed to add teacher.")
            End If
        End If

    End Sub

    Private Function AddUser() As Boolean

        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Username and password cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim sql As String = "INSERT INTO tbl_users (username, password, role, fname, mname, lname) VALUES (@username, @password, @role, @fname, @mname, @lname)"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@username", txtUsername.Text)
                cmd.Parameters.AddWithValue("@password", txtPassword.Text)
                cmd.Parameters.AddWithValue("@role", cboRole.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@fname", txtFname.Text)
                cmd.Parameters.AddWithValue("@mname", txtMname.Text)
                cmd.Parameters.AddWithValue("@lname", txtLname.Text)

                Dim result As Integer = cmd.ExecuteNonQuery()
                Return result > 0
            End Using
        End Using
    End Function

    Private Function UpdateUser() As Boolean

        Using conn As MySqlConnection = GetConnection()
            Try
                conn.Open()
                Dim sql As String = "UPDATE tbl_users SET role = @role, fname = @fname, mname = @mname, lname = @lname WHERE id = @id"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id", UserId)
                    cmd.Parameters.AddWithValue("@role", cboRole.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@fname", txtFname.Text)
                    cmd.Parameters.AddWithValue("@mname", txtMname.Text)
                    cmd.Parameters.AddWithValue("@lname", txtLname.Text)

                    Dim result As Integer = cmd.ExecuteNonQuery()
                    If result > 0 Then
                        MessageBox.Show("User updated successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return True
                    Else
                        MessageBox.Show("No changes were made to the record.", "Update Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return False
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
    End Function



    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Close()
    End Sub
End Class
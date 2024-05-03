Imports MySql.Data.MySqlClient

Public Class FrmTeacher

    Inherits Form

    Public Event OperationSuccessful()

    Private _userId As Integer
    Private _fname As String
    Private _mname As String
    Private _lname As String
    Private _departmentId As Integer

    Public Sub New()
        InitializeComponent()
        cboDepartments.DataSource = GetDepartmentList()
        cboDepartments.DisplayMember = "department"
        cboDepartments.ValueMember = "id"
    End Sub

    Public Sub New(userId As Integer, fname As String, mname As String, lname As String, departmentId As Integer)
        InitializeComponent()
        _userId = userId
        _fname = fname
        _mname = mname
        _lname = lname
        _departmentId = departmentId

        ' Set control values
        txtFname.Text = _fname
        txtMname.Text = _mname
        txtLname.Text = _lname

        ' Load department details
        cboDepartments.DataSource = GetDepartmentList()
        cboDepartments.DisplayMember = "department"
        cboDepartments.ValueMember = "id"
        cboDepartments.SelectedValue = _departmentId

    End Sub



    Private Function GetDepartmentList() As DataTable
        Using conn As MySqlConnection = GetConnection()
            Dim sql As String = "SELECT id, department FROM tbl_departments"
            Using cmd As New MySqlCommand(sql, conn)
                Using adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function


    Public Function AddUserAndTeacher(username As String, password As String, role As String, fname As String, mname As String, lname As String, departmentId As Integer) As Boolean
        Using conn As MySqlConnection = GetConnection()
            conn.Open()

            Dim transaction As MySqlTransaction = conn.BeginTransaction()
            Try
                ' Insert into tbl_users
                Dim userSql As String = "INSERT INTO tbl_users (username, password, role, fname, mname, lname) VALUES (@username, @password, @role, @fname, @mname, @lname)"
                Using userCmd As New MySqlCommand(userSql, conn)
                    userCmd.Transaction = transaction
                    userCmd.Parameters.AddWithValue("@username", username)
                    userCmd.Parameters.AddWithValue("@password", password)  ' Ensure you hash the password in real scenarios
                    userCmd.Parameters.AddWithValue("@role", role)
                    userCmd.Parameters.AddWithValue("@fname", fname)
                    userCmd.Parameters.AddWithValue("@mname", mname)
                    userCmd.Parameters.AddWithValue("@lname", lname)
                    userCmd.ExecuteNonQuery()
                End Using

                ' Get the last inserted ID
                Dim userId As Integer = Convert.ToInt32(New MySqlCommand("SELECT LAST_INSERT_ID()", conn, transaction).ExecuteScalar())

                ' Insert into tbl_teachers
                Dim teacherSql As String = "INSERT INTO tbl_teachers (userId, departmentId) VALUES (@userId, @departmentId)"
                Using teacherCmd As New MySqlCommand(teacherSql, conn)
                    teacherCmd.Transaction = transaction
                    teacherCmd.Parameters.AddWithValue("@userId", userId)
                    teacherCmd.Parameters.AddWithValue("@departmentId", departmentId)
                    teacherCmd.ExecuteNonQuery()
                End Using

                ' Commit transaction
                transaction.Commit()
                Return True
            Catch ex As Exception
                ' Rollback transaction on error
                transaction.Rollback()
                MessageBox.Show("Failed to add user and teacher: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
    End Function


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Example of how to call this function:
        If AddUserAndTeacher(txtUsername.Text, txtPassword.Text, cboRole.Text, txtFname.Text, txtMname.Text, txtLname.Text, Convert.ToInt32(cboDepartments.SelectedValue)) Then
            MessageBox.Show("Teacher added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            RaiseEvent OperationSuccessful()
        Else
            MessageBox.Show("Failed to add teacher", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If UpdateTeacher() Then
            MessageBox.Show("Teacher updated successfully", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()  ' Optionally close the form or clear fields
            RaiseEvent OperationSuccessful()
        Else
            MessageBox.Show("Failed to update teacher", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function UpdateTeacher() As Boolean
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim transaction As MySqlTransaction = conn.BeginTransaction()
            Try
                ' Update the user details in tbl_users
                Dim userSql As String = "UPDATE tbl_users SET fname = @fname, mname = @mname, lname = @lname WHERE id = @userId"
                Using userCmd As New MySqlCommand(userSql, conn)
                    userCmd.Transaction = transaction
                    userCmd.Parameters.AddWithValue("@userId", _userId)
                    userCmd.Parameters.AddWithValue("@fname", txtFname.Text)
                    userCmd.Parameters.AddWithValue("@mname", txtMname.Text)
                    userCmd.Parameters.AddWithValue("@lname", txtLname.Text)
                    userCmd.ExecuteNonQuery()
                End Using

                ' Update the department in tbl_teachers
                Dim teacherSql As String = "UPDATE tbl_teachers SET departmentId = @departmentId WHERE userId = @userId"
                Using teacherCmd As New MySqlCommand(teacherSql, conn)
                    teacherCmd.Transaction = transaction
                    teacherCmd.Parameters.AddWithValue("@userId", _userId)
                    teacherCmd.Parameters.AddWithValue("@departmentId", cboDepartments.SelectedValue)
                    teacherCmd.ExecuteNonQuery()
                End Using

                ' Commit the transaction
                transaction.Commit()
                RaiseEvent OperationSuccessful()
                Return True
            Catch ex As Exception
                ' Roll back the transaction on error
                transaction.Rollback()
                MessageBox.Show("Failed to update teacher: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
    End Function

End Class
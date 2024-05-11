Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Imports Mysqlx.Notice

Public Class UctrlTeachers
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        OpenForm()
    End Sub

    Private Sub UctrlTeachers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeListView()
    End Sub


    Private Sub OpenForm()
        Dim frmUser As New FrmTeacher()
        AddHandler frmUser.OperationSuccessful, AddressOf reloadList
        frmUser.Show()
    End Sub

    Private Sub reloadList()
        LoadItems()
    End Sub

    Private Sub InitializeListView()
        LsvItems.Columns.Clear()
        LsvItems.Columns.Add("ID", 50)
        LsvItems.Columns.Add("First Name", 200)
        LsvItems.Columns.Add("Middle Name", 200)
        LsvItems.Columns.Add("Last Name", 200)
        LsvItems.Columns.Add("Department", 200)
        LsvItems.FullRowSelect = True
        LsvItems.GridLines = True
        LsvItems.View = View.Details
        LoadItems()
    End Sub

    Private Sub LoadItems()
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim sql As String = "SELECT * FROM teacher_view"
            Using cmd As New MySqlCommand(sql, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    LsvItems.Items.Clear()
                    While reader.Read()
                        With LsvItems.Items.Add(reader("id").ToString())
                            .SubItems.Add(reader("fname").ToString())
                            .SubItems.Add(reader("mname").ToString())
                            .SubItems.Add(reader("lname").ToString())
                            .SubItems.Add(reader("department").ToString())
                        End With
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub OpenFormUpdate()
        Dim selectedItem As ListViewItem = LsvItems.SelectedItems(0)
        Dim userId As Integer = Convert.ToInt32(selectedItem.Text)
        Dim fname As String = selectedItem.SubItems(1).Text
        Dim mname As String = selectedItem.SubItems(2).Text
        Dim lname As String = selectedItem.SubItems(3).Text
        Dim departmentId As Integer = FetchDepartmentIdForUser(userId)

        Dim frmUser As New FrmTeacher(userId, fname, mname, lname, departmentId)
        AddHandler frmUser.OperationSuccessful, AddressOf reloadList
        frmUser.Show()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If LsvItems.SelectedItems.Count > 0 Then
            OpenFormUpdate()
        Else
            MessageBox.Show("Please select a user to edit.")
        End If
    End Sub

    Private Function FetchDepartmentIdForUser(userId As Integer) As Integer
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim sql As String = "SELECT departmentId FROM tbl_teachers WHERE userId = @userId"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@userId", userId)
                Dim result = cmd.ExecuteScalar()
                Return If(IsDBNull(result), 0, Convert.ToInt32(result))
            End Using
        End Using
    End Function

    Private Function DeleteTeacherAndUserData(userId As Integer) As Boolean
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim transaction As MySqlTransaction = conn.BeginTransaction()
            Try
                Dim deleteTeacherSql As String = "DELETE FROM tbl_teachers WHERE userId = @userId"
                Using teacherCmd As New MySqlCommand(deleteTeacherSql, conn)
                    teacherCmd.Transaction = transaction
                    teacherCmd.Parameters.AddWithValue("@userId", userId)
                    teacherCmd.ExecuteNonQuery()
                End Using

                Dim deleteUserSql As String = "DELETE FROM tbl_users WHERE id = @userId"
                Using userCmd As New MySqlCommand(deleteUserSql, conn)
                    userCmd.Transaction = transaction
                    userCmd.Parameters.AddWithValue("@userId", userId)
                    userCmd.ExecuteNonQuery()
                End Using

                transaction.Commit()
                Return True
            Catch ex As Exception
                transaction.Rollback()
                MessageBox.Show("Failed to delete teacher and user data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
    End Function

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If LsvItems.SelectedItems.Count > 0 Then
            Dim userId = Convert.ToInt32(LsvItems.SelectedItems(0).Text)
            If MessageBox.Show("Are you sure you want to delete this teacher and all associated user data?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If DeleteTeacherAndUserData(userId) Then
                    MessageBox.Show("Teacher and user data deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadItems()
                End If
            End If
        Else
            MessageBox.Show("Please select a teacher to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnAssign_Click(sender As Object, e As EventArgs) Handles btnAssign.Click
        Dim frmAssign As New FrmAssignStudent
        frmAssign.Show()
    End Sub
End Class

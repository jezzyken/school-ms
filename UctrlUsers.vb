Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class UctrlUsers
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        OpenForm()
    End Sub

    Private Sub InitializeListView()
        LsvItems.Columns.Clear()
        LsvItems.Columns.Add("ID", 50)
        LsvItems.Columns.Add("Username", 100)
        LsvItems.Columns.Add("Role", 100)
        LsvItems.Columns.Add("First Name", 100)
        LsvItems.Columns.Add("Middle Name", 100)
        LsvItems.Columns.Add("Last Name", 100)
        LsvItems.FullRowSelect = True
        LsvItems.GridLines = True
        LsvItems.View = View.Details
        LoadUsers()
    End Sub


    Private Sub OpenForm()
        Dim _frmUser As New FrmUser()
        AddHandler _frmUser.OperationSuccessful, AddressOf reloadList
        _frmUser.Show()
    End Sub

    Private Sub reloadList()
        LoadUsers()
    End Sub

    Private Sub LoadUsers()
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim sql As String = "SELECT id, username, role, fname, mname, lname FROM tbl_users"
            Using cmd As New MySqlCommand(sql, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    LsvItems.Items.Clear()
                    While reader.Read()
                        With LsvItems.Items.Add(reader("id").ToString())
                            .SubItems.Add(reader("username").ToString())
                            .SubItems.Add(reader("role").ToString())
                            .SubItems.Add(reader("fname").ToString())
                            .SubItems.Add(reader("mname").ToString())
                            .SubItems.Add(reader("lname").ToString())
                        End With
                    End While
                End Using
            End Using
        End Using
    End Sub


    Private Sub OpenFormUpdate()
        Dim selectedItem As ListViewItem = LsvItems.SelectedItems(0)
        Dim userId As Integer = Convert.ToInt32(selectedItem.Text)
        Dim role As String = selectedItem.SubItems(2).Text
        Dim fname As String = selectedItem.SubItems(3).Text
        Dim mname As String = selectedItem.SubItems(4).Text
        Dim lname As String = selectedItem.SubItems(5).Text

        ' Create and show FrmUser for editing
        Dim frmUser As New FrmUser(userId, role, fname, mname, lname)
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

    Private Sub UctrlUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeListView()
    End Sub

    Public Function DeleteUser(id As Integer) As Boolean
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim sql As String = "DELETE FROM tbl_users WHERE id = @id"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", id)
                Dim result As Integer = cmd.ExecuteNonQuery()
                Return result > 0
            End Using
        End Using
    End Function

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If LsvItems.SelectedItems.Count > 0 Then
            Dim selectedId As Integer = Convert.ToInt32(LsvItems.SelectedItems(0).Text)
            If DeleteUser(selectedId) Then
                LoadUsers()
                MessageBox.Show("User deleted successfully.")
            Else
                MessageBox.Show("Failed to delete user.")
            End If
        Else
            MessageBox.Show("Please select a user to delete.")
        End If
    End Sub
End Class

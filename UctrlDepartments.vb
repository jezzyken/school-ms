Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class UctrlDepartments

    Private Sub UctrlDepartments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LsvItems.Columns.Clear()
        LsvItems.Columns.Add("ID", 120, HorizontalAlignment.Left)
        LsvItems.Columns.Add("Name", 200, HorizontalAlignment.Left)
        LoadDepartments()
    End Sub

    Private Sub LoadDepartments()
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim sql As String = "SELECT * from tbl_departments"
            Using cmd As New MySqlCommand(sql, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    LsvItems.Items.Clear()
                    While reader.Read()
                        With LsvItems.Items.Add(Convert.ToInt32(reader("id")))
                            .SubItems.Add(reader("department").ToString())
                        End With
                    End While
                End Using
            End Using
        End Using
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If AddDepartment(txtItem.Text) Then
            LoadDepartments()
            Clear()
        Else
            MessageBox.Show("Failed to add department.")
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If LsvItems.SelectedItems.Count > 0 Then
            Dim selectedId As Integer = Convert.ToInt32(LsvItems.SelectedItems(0).Text)
            If UpdateDepartment(selectedId, txtItem.Text) Then
                LoadDepartments()
                Clear()
            Else
                MessageBox.Show("Failed to update department.")
            End If
        Else
            MessageBox.Show("Please select a department to update.")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If LsvItems.SelectedItems.Count > 0 Then
            Dim selectedId As Integer = Convert.ToInt32(LsvItems.SelectedItems(0).Text)
            If DeleteDepartment(selectedId) Then
                LoadDepartments()
                Clear()
            Else
                MessageBox.Show("Failed to delete department.")
            End If
        Else
            MessageBox.Show("Please select a department to delete.")
        End If
    End Sub

    Private Sub LsvItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LsvItems.SelectedIndexChanged
        If LsvItems.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = LsvItems.SelectedItems(0)
            txtItem.Text = selectedItem.SubItems(1).Text
        Else
            Clear()
        End If
    End Sub

    Public Function AddDepartment(department As String) As Boolean
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim sql As String = "INSERT INTO tbl_departments (department) VALUES (@department)"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@department", department)
                Dim result As Integer = cmd.ExecuteNonQuery()
                Return result > 0
            End Using
        End Using
    End Function

    Public Function UpdateDepartment(id As Integer, department As String) As Boolean
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim sql As String = "UPDATE tbl_departments SET department = @department WHERE id = @id"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@department", department)
                Dim result As Integer = cmd.ExecuteNonQuery()
                Return result > 0
            End Using
        End Using
    End Function

    Public Function DeleteDepartment(id As Integer) As Boolean
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim sql As String = "DELETE FROM tbl_departments WHERE id = @id"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", id)
                Dim result As Integer = cmd.ExecuteNonQuery()
                Return result > 0
            End Using
        End Using
    End Function
    Private Sub Clear()
        txtItem.Text = ""
    End Sub

End Class

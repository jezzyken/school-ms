Imports MySql.Data.MySqlClient

Public Class UctrlSubjects

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        OpenFormAdd()
    End Sub

    Private Sub InitializeListView()
        LsvItems.Columns.Clear()
        LsvItems.Columns.Add("ID", 50)
        LsvItems.Columns.Add("Course Code", 100)
        LsvItems.Columns.Add("Subject", 250)
        LsvItems.Columns.Add("Units", 50)
        LsvItems.Columns.Add("Term", 100)
        LsvItems.Columns.Add("Level", 100)
        LsvItems.Columns.Add("Course", 200)
        LsvItems.Columns.Add("Course ID", 0) ' Hidden column for course ID
        LsvItems.Columns.Add("Department", 200)
        LsvItems.FullRowSelect = True
        LsvItems.GridLines = True
        LsvItems.View = View.Details
        LoadSubjects()
    End Sub

    Private Sub LoadSubjects()
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim sql As String = "SELECT * FROM subject_view" ' Ensure subject_view includes course_id
            Using cmd As New MySqlCommand(sql, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    LsvItems.Items.Clear()
                    While reader.Read()
                        With LsvItems.Items.Add(reader("id").ToString())
                            .SubItems.Add(reader("course_code").ToString())
                            .SubItems.Add(reader("subject_name").ToString())
                            .SubItems.Add(reader("units").ToString())
                            .SubItems.Add(reader("term").ToString())
                            .SubItems.Add(reader("level").ToString())
                            .SubItems.Add(reader("course").ToString())
                            .SubItems.Add(reader("course_id").ToString()) ' Store course ID in a hidden column
                            .SubItems.Add(reader("department").ToString())
                        End With
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub OpenFormAdd()
        Dim frmSubject As New FrmSubject()
        AddHandler frmSubject.OperationSuccessful, AddressOf ReloadList
        frmSubject.Show()
    End Sub

    Private Sub OpenFormUpdate()
        Dim selectedItem As ListViewItem = LsvItems.SelectedItems(0)
        Dim subjectId As Integer = Convert.ToInt32(selectedItem.Text)
        Dim courseCode As String = selectedItem.SubItems(1).Text
        Dim subjectName As String = selectedItem.SubItems(2).Text
        Dim units As String = selectedItem.SubItems(3).Text
        Dim term As String = selectedItem.SubItems(4).Text
        Dim level As String = selectedItem.SubItems(5).Text
        Dim courseId As Integer = Convert.ToInt32(selectedItem.SubItems(7).Text) ' Retrieve the course ID

        Dim frmSubject As New FrmSubject(subjectId, units, term, courseCode, subjectName, level, courseId)
        AddHandler frmSubject.OperationSuccessful, AddressOf ReloadList
        frmSubject.Show()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If LsvItems.SelectedItems.Count > 0 Then
            OpenFormUpdate()
        Else
            MessageBox.Show("Please select a subject to edit.")
        End If
    End Sub

    Private Sub ReloadList()
        LoadSubjects()
    End Sub

    Private Function DeleteSubject(id As Integer) As Boolean
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim sql As String = "DELETE FROM tbl_subjects WHERE id = @id"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", id)
                Dim result As Integer = cmd.ExecuteNonQuery()
                Return result > 0
            End Using
        End Using
    End Function

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If LsvItems.SelectedItems.Count > 0 Then
            Dim selectedId = Convert.ToInt32(LsvItems.SelectedItems(0).Text)
            If DeleteSubject(selectedId) Then
                LoadSubjects()
                MessageBox.Show("Subject deleted successfully.")
            Else
                MessageBox.Show("Failed to delete subject.")
            End If
        Else
            MessageBox.Show("Please select a subject to delete.")
        End If
    End Sub

    Private Sub UctrlSubjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeListView()
    End Sub
End Class

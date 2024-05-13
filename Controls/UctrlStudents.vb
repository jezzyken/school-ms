Imports MySql.Data.MySqlClient

Public Class UctrlStudents
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        OpenForm()
    End Sub

    Private Sub InitializeListView()
        LsvItems.Columns.Clear()
        LsvItems.Columns.Add("ID", 50)
        LsvItems.Columns.Add("LRN", 100)
        LsvItems.Columns.Add("First Name", 200)
        LsvItems.Columns.Add("Middle Name", 200)
        LsvItems.Columns.Add("Last Name", 200)
        LsvItems.Columns.Add("Course", 150)
        LsvItems.Columns.Add("Course ID", 0)  ' Hidden column for course ID
        LsvItems.Columns.Add("Year Level", 100)
        LsvItems.Columns.Add("Term", 100)
        LsvItems.Columns.Add("Status", 100)
        LsvItems.Columns.Add("School Year", 100)
        LsvItems.FullRowSelect = True
        LsvItems.GridLines = True
        LsvItems.View = View.Details
        LoadStudents()
    End Sub

    Private Sub LoadStudents()
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim sql As String = "SELECT * FROM students_view"
            Using cmd As New MySqlCommand(sql, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    LsvItems.Items.Clear()
                    While reader.Read()
                        With LsvItems.Items.Add(reader("id").ToString())
                            .SubItems.Add(reader("lrn").ToString())
                            .SubItems.Add(reader("fname").ToString())
                            .SubItems.Add(reader("mname").ToString())
                            .SubItems.Add(reader("lname").ToString())
                            .SubItems.Add(reader("course").ToString())
                            .SubItems.Add(reader("course_id").ToString())  ' Storing course_id in a hidden column
                            .SubItems.Add(reader("year_level").ToString())
                            .SubItems.Add(reader("term").ToString())
                            .SubItems.Add(reader("status").ToString())
                            .SubItems.Add(reader("school_year").ToString())
                        End With
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub OpenForm()
        Dim frmStudent As New FrmStudent()
        AddHandler frmStudent.OperationSuccessful, AddressOf ReloadList
        frmStudent.Show()
    End Sub

    Private Sub OpenFormUpdate()
        If LsvItems.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select a student to edit.")
            Return
        End If
        Dim selectedItem As ListViewItem = LsvItems.SelectedItems(0)
        Dim studentId As Integer = Convert.ToInt32(selectedItem.Text)
        Dim lrn As String = selectedItem.SubItems(1).Text
        Dim fname As String = selectedItem.SubItems(2).Text
        Dim mname As String = selectedItem.SubItems(3).Text
        Dim lname As String = selectedItem.SubItems(4).Text
        Dim course As String = selectedItem.SubItems(5).Text
        Dim courseId As Integer = Convert.ToInt32(selectedItem.SubItems(6).Text)  ' Retrieve hidden course_id
        Dim yearLevel As String = selectedItem.SubItems(7).Text
        Dim term As String = selectedItem.SubItems(8).Text
        Dim status As String = selectedItem.SubItems(9).Text
        Dim schoolYear As String = selectedItem.SubItems(10).Text

        Dim frmStudent As New FrmStudent(studentId, lrn, fname, mname, lname, courseId, yearLevel, term, status, schoolYear)
        AddHandler frmStudent.OperationSuccessful, AddressOf ReloadList
        frmStudent.Show()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        OpenFormUpdate()
    End Sub

    Private Sub ReloadList()
        LoadStudents()
    End Sub

    Private Function DeleteStudent(id As Integer) As Boolean
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim sql As String = "DELETE FROM tbl_students WHERE id = @id"
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
            If DeleteStudent(selectedId) Then
                LoadStudents()
                MessageBox.Show("Student deleted successfully.")
            Else
                MessageBox.Show("Failed to delete student.")
            End If
        Else
            MessageBox.Show("Please select a student to delete.")
        End If
    End Sub

    Private Sub UctrlStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeListView()
    End Sub
End Class

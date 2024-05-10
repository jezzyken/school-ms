Imports MySql.Data.MySqlClient

Public Class UctrlStudentList

    Public Class Student
        Public Property ID As String
        Public Property LRN As String
        Public Property FirstName As String
        Public Property MiddleName As String
        Public Property LastName As String
        Public Property Course As String
        Public Property CourseID As String
        Public Property YearLevel As String
        Public Property Term As String
        Public Property Status As String
    End Class

    Public Event StudentSelected(student As Student)

    Private Sub UctrlStudentList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeListView()
    End Sub

    Private Sub InitializeListView()
        LsvItems.Columns.Clear()
        LsvItems.Columns.Add("ID", 50)
        LsvItems.Columns.Add("LRN", 100)
        LsvItems.Columns.Add("First Name", 200)
        LsvItems.Columns.Add("Middle Name", 200)
        LsvItems.Columns.Add("Last Name", 200)
        LsvItems.Columns.Add("Course", 150)
        LsvItems.Columns.Add("Course ID", 0)
        LsvItems.Columns.Add("Year Level", 100)
        LsvItems.Columns.Add("Term", 100)
        LsvItems.Columns.Add("Status", 100)
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
                            .SubItems.Add(reader("course_id").ToString())
                            .SubItems.Add(reader("year_level").ToString())
                            .SubItems.Add(reader("term").ToString())
                            .SubItems.Add(reader("status").ToString())
                        End With
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub LsvItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LsvItems.SelectedIndexChanged
        If LsvItems.SelectedItems.Count > 0 Then
            Dim selectedStudent As New Student With {
                .ID = LsvItems.SelectedItems(0).SubItems(0).Text,
                .LRN = LsvItems.SelectedItems(0).SubItems(1).Text,
                .FirstName = LsvItems.SelectedItems(0).SubItems(2).Text,
                .MiddleName = LsvItems.SelectedItems(0).SubItems(3).Text,
                .LastName = LsvItems.SelectedItems(0).SubItems(4).Text,
                .Course = LsvItems.SelectedItems(0).SubItems(5).Text,
                .CourseID = LsvItems.SelectedItems(0).SubItems(6).Text,
                .YearLevel = LsvItems.SelectedItems(0).SubItems(7).Text,
                .Term = LsvItems.SelectedItems(0).SubItems(8).Text,
                .Status = LsvItems.SelectedItems(0).SubItems(9).Text
            }
            RaiseEvent StudentSelected(selectedStudent)
        End If
    End Sub


End Class

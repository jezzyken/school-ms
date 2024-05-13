Imports MySql.Data.MySqlClient
Imports SchoolMS.UctrlStudentList


Public Class UctrlEnrollments

    Private selectedCourseId As String
    Private selectedTerm As String
    Private selectedLevel As String
    Private studentId As String

    Private Sub UctrlEnrollments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboCourses.DataSource = GetCourseList()
        cboCourses.DisplayMember = "course"
        cboCourses.ValueMember = "id"
        AddHandler UctrlStudentList.StudentSelected, AddressOf OnStudentSelected
        InitializeListView()
    End Sub

    Private Function GetCourseList() As DataTable
        Using conn As MySqlConnection = GetConnection()
            Dim sql As String = "SELECT * FROM tbl_courses"
            Using cmd As New MySqlCommand(sql, conn)
                Using adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function

    Private Sub OnStudentSelected(student As Student)
        txtFname.Text = student.FirstName
        txtMname.Text = student.MiddleName
        txtLname.Text = student.LastName
        txtLRN.Text = student.LRN
        studentId = student.ID
        cboCourses.SelectedValue = student.CourseID
    End Sub

    Private Sub InitializeListView()
        LsvSubjectItems.Columns.Clear()
        LsvSubjectItems.Columns.Add("ID", 50)
        LsvSubjectItems.Columns.Add("Course Code", 100)
        LsvSubjectItems.Columns.Add("Subject", 250)
        LsvSubjectItems.Columns.Add("Units", 50)
        LsvSubjectItems.Columns.Add("Term", 100)
        LsvSubjectItems.Columns.Add("Level", 100)
        LsvSubjectItems.Columns.Add("Course ID", 0)
        LsvSubjectItems.FullRowSelect = True
        LsvSubjectItems.GridLines = True
        LsvSubjectItems.View = View.Details


        LsvSelectedSubjects.Columns.Clear()
        LsvSelectedSubjects.Columns.Add("ID", 50)
        LsvSelectedSubjects.Columns.Add("Course Code", 100)
        LsvSelectedSubjects.Columns.Add("Subject", 250)
        LsvSelectedSubjects.Columns.Add("Units", 50)
        LsvSelectedSubjects.Columns.Add("Term", 100)
        LsvSelectedSubjects.Columns.Add("Level", 100)
        LsvSelectedSubjects.Columns.Add("Course ID", 0)
        LsvSelectedSubjects.FullRowSelect = True
        LsvSelectedSubjects.GridLines = True
        LsvSelectedSubjects.View = View.Details

    End Sub


    Private Sub btnQuerySubject_Click(sender As Object, e As EventArgs) Handles btnQuerySubject.Click
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim sql As String = "SELECT * FROM tbl_subjects WHERE course_id = @CourseId AND term = @Term AND level = @Level"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@CourseId", Convert.ToInt32(selectedCourseId))
                cmd.Parameters.AddWithValue("@Term", selectedTerm)
                cmd.Parameters.AddWithValue("@Level", selectedLevel)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    LsvSubjectItems.Items.Clear()
                    While reader.Read()
                        With LsvSubjectItems.Items.Add(reader("id").ToString())
                            .SubItems.Add(reader("course_code").ToString())
                            .SubItems.Add(reader("subject_name").ToString())
                            .SubItems.Add(reader("units").ToString())
                            .SubItems.Add(reader("term").ToString())
                            .SubItems.Add(reader("level").ToString())
                            .SubItems.Add(reader("course_id").ToString())
                        End With
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub cboCourses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCourses.SelectedIndexChanged
        selectedCourseId = cboCourses.SelectedValue.ToString()
    End Sub

    Private Sub cboSemester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSemester.SelectedIndexChanged
        selectedTerm = cboSemester.SelectedItem
    End Sub

    Private Sub cboYearLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboYearLevel.SelectedIndexChanged
        selectedLevel = cboYearLevel.SelectedItem
    End Sub

    Private Sub LsvSubjectItems_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub LsvSubjectItems_MouseClick(sender As Object, e As MouseEventArgs) Handles LsvSubjectItems.MouseClick
        If LsvSubjectItems.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = LsvSubjectItems.SelectedItems(0)
            If Not IsDuplicate(selectedItem) Then
                LsvSelectedSubjects.Items.Add(selectedItem.Clone())
            Else
                MessageBox.Show("This subject is already added.", "Duplicate Item", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

    End Sub

    Private Function IsDuplicate(item As ListViewItem) As Boolean
        For Each listItem As ListViewItem In LsvSelectedSubjects.Items
            If listItem.Text = item.Text Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Using conn As MySqlConnection = GetConnection()
            Try
                conn.Open()
                If cboStatus.SelectedItem.ToString() = "New" Then
                    CreateNewStudent(conn)
                    UpdateStudentSubjects(conn)
                Else
                    UpdateStudentSubjects(conn)
                End If
                MessageBox.Show("Data saved successfully!")
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    Private Sub CreateNewStudent(conn As MySqlConnection)
        Dim sql As String = "INSERT INTO tbl_students (lrn, fname, mname, lname, course_id, year_level, term, status) VALUES (@lrn, @fname, @mname, @lname, @course_id, @year_level, @term, @status)"
        Using cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@fname", txtFname.Text)
            cmd.Parameters.AddWithValue("@mname", txtMname.Text)
            cmd.Parameters.AddWithValue("@lname", txtLname.Text)
            cmd.Parameters.AddWithValue("@lrn", txtLRN.Text)
            cmd.Parameters.AddWithValue("@course_id", cboCourses.SelectedValue)
            cmd.Parameters.AddWithValue("@year_level", cboYearLevel.Text)
            cmd.Parameters.AddWithValue("@term", cboSemester.Text)
            cmd.Parameters.AddWithValue("@school_year", cboSchoolYear.Text)
            cmd.Parameters.AddWithValue("@status", "New")
            cmd.ExecuteNonQuery()

            Dim studentId As Integer = CInt(cmd.LastInsertedId)

            For Each item As ListViewItem In LsvSelectedSubjects.Items
                Dim subjectId As Integer = Convert.ToInt32(item.Text)
                Using cmdInsertSubject As New MySqlCommand("INSERT INTO tbl_student_subjects (student_id, subject_id) VALUES (@studentId, @subjectId)", conn)
                    cmdInsertSubject.Parameters.AddWithValue("@studentId", studentId)
                    cmdInsertSubject.Parameters.AddWithValue("@subjectId", subjectId)
                    cmdInsertSubject.ExecuteNonQuery()
                End Using
            Next
        End Using
    End Sub


    Private Sub UpdateStudentSubjects(conn As MySqlConnection)
        For Each item As ListViewItem In LsvSelectedSubjects.Items
            Dim subjectId As Integer = Convert.ToInt32(item.Text)
            If Not DatabaseHasSubject(studentId, subjectId, conn) Then
                Using cmd As New MySqlCommand("INSERT INTO tbl_student_subjects (student_id, subject_id) VALUES (@studentId, @subjectId)", conn)
                    cmd.Parameters.AddWithValue("@studentId", studentId)
                    cmd.Parameters.AddWithValue("@subjectId", subjectId)
                    cmd.ExecuteNonQuery()
                End Using
            End If
        Next
    End Sub

    Private Function DatabaseHasSubject(studentId As Integer, subjectId As Integer, conn As MySqlConnection) As Boolean
        Using cmd As New MySqlCommand("SELECT COUNT(*) FROM tbl_student_subjects WHERE student_id = @studentId AND subject_id = @subjectId", conn)
            cmd.Parameters.AddWithValue("@studentId", studentId)
            cmd.Parameters.AddWithValue("@subjectId", subjectId)
            Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return result > 0
        End Using
    End Function



    Private Sub cboStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStatus.SelectedIndexChanged
        If cboStatus.SelectedItem.ToString() = "New" Then
            ClearTextFields()
            'EnableFields()
            'Else
            '    DisableFields()
        End If
    End Sub

    Private Sub ClearTextFields()
        txtFname.Text = ""
        txtMname.Text = ""
        txtLname.Text = ""
        txtLRN.Text = ""
    End Sub

    'Private Sub EnableFields()
    '    txtFname.Enabled = True
    '    txtMname.Enabled = True
    '    txtLname.Enabled = True
    '    txtLRN.Enabled = True
    'End Sub

    'Private Sub DisableFields()
    '    txtFname.Enabled = False
    '    txtMname.Enabled = False
    '    txtLname.Enabled = False
    '    txtLRN.Enabled = False
    'End Sub
End Class

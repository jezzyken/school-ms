Imports MySql.Data.MySqlClient

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
        LsvItems.Columns.Add("First Name", 100)
        LsvItems.Columns.Add("Middle Name", 100)
        LsvItems.Columns.Add("Last Name", 100)
        LsvItems.Columns.Add("Department", 100)
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
End Class

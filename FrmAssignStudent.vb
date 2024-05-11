Imports SchoolMS.UctrlStudentList

Public Class FrmAssignStudent
    Private Sub FrmAssignStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LsvAssignItems.Columns.Clear()
        LsvAssignItems.Columns.Add("ID", 50)
        LsvAssignItems.Columns.Add("Course Code", 100)
        LsvAssignItems.Columns.Add("Subject", 250)
        LsvAssignItems.FullRowSelect = True
        LsvAssignItems.GridLines = True
        LsvAssignItems.View = View.Details
    End Sub



    Private Function StudentIdExists(ByVal studentId As String) As Boolean
        ' Check if the student ID exists in LsvAssignItems
        For Each item As ListViewItem In LsvAssignItems.Items
            If item.Text = studentId Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub UctrlStudentList_ListViewItemClicked(ByVal studentId As Integer, ByVal firstName As String, ByVal lastName As String, ByVal middleName As String) Handles UctrlStudentList.ListViewItemClicked
        If Not LsvAssignItems.Items.ContainsKey(studentId.ToString()) Then
            Dim newItem As New ListViewItem(studentId.ToString())
            newItem.Name = studentId.ToString()
            newItem.SubItems.Add(firstName)
            newItem.SubItems.Add(lastName)
            newItem.SubItems.Add(middleName)
            LsvAssignItems.Items.Add(newItem)
        End If
    End Sub

    Private Sub RemoveItemFromAssignItems(ByVal studentId As Integer)
        For Each item As ListViewItem In LsvAssignItems.Items
            If Convert.ToInt32(item.SubItems(0).Text) = studentId Then
                LsvAssignItems.Items.Remove(item)
                Exit For
            End If
        Next
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If LsvAssignItems.SelectedItems.Count > 0 Then
            Dim selectedStudentId As Integer = Convert.ToInt32(LsvAssignItems.SelectedItems(0).SubItems(0).Text)
            RemoveItemFromAssignItems(selectedStudentId)
        End If
    End Sub
End Class
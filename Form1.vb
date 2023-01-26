Public Class TodoList
    Dim addAnItemText As String = "Add an Item...."
    Dim firstName As String = "Fred"
    Dim total As Int32 = 0
    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        If inputField.Text IsNot "" Or inputField.Text IsNot addAnItemText Then
            List.Items.Add(inputField.Text)
            selectInputField()
            inputField.Text = ""
            total += 1
        End If
    End Sub


    Private Sub inputField_TextChanged(sender As Object, e As EventArgs) Handles inputField.TextChanged

    End Sub

    Private Sub inputField_GotFocus(sender As Object, e As EventArgs) Handles inputField.GotFocus
        If inputField.Text = $"{addAnItemText}" Then
            inputField.Text = ""
        End If
    End Sub

    Private Sub inputField_LostFocus(sender As Object, e As EventArgs) Handles inputField.LostFocus
        If inputField.Text = "" Then
            inputField.Text = $"{addAnItemText}"
        End If
    End Sub

    Private Sub List_Click(sender As Object, e As EventArgs) Handles List.Click
        If List.SelectedItems.Count = 1 Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to take this off your list?", "Yes?", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Yes Then
                List.Items.RemoveAt(List.SelectedIndex)
                total -= 1
                MsgBox($"you have selected finished {List.SelectedItem}, you only have {total} left to do! {firstName}")
            End If
        End If
    End Sub

    Private Function selectInputField()
        inputField.Select()
    End Function

End Class

Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() ' Closes form
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clears text
        txtInteger.Clear()
        lblRomanOutput.Text = String.Empty
        lblStatus.Text = "Cleared Message"
        ' Returns focus to TextBox
        txtInteger.Focus()
    End Sub
End Class

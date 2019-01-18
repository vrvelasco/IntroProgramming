Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDisplayMessage.Click
        lblMessage.Text = "Hello World"
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblMessage.Text = String.Empty
    End Sub
End Class

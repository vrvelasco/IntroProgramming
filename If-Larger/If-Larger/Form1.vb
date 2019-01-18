Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear text
        txtValueA.Clear()
        txtValueB.Clear()
        lblResult.Text = String.Empty
        ' Return focus to first TextBox
        txtValueA.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() ' Closes form
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCompare.Click
        Try
            ' Declare Values
            Dim intA As Integer
            Dim intB As Integer
            intA = CInt(txtValueA.Text)
            intB = CInt(txtValueB.Text)
            ' Compares values
            If intA > intB Then
                lblResult.Text = "A is greater than B"
            ElseIf intA < intB Then
                lblResult.Text = "A is less than B"
            ElseIf intA = intB Then
                lblResult.Text = "A is equal to B"
            End If
        Catch ex As Exception
            lblResult.Text = "Invalid value(s)" ' Error message
        End Try
    End Sub
End Class

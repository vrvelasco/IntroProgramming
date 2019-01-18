Public Class Form1

    Private Sub btnClear_Click() Handles btnClear.Click
        ' Clear the TextBoxes and the Label
        txtSalary.Clear()
        txtYearsOnJob.Clear()
        lblMessage.Text = String.Empty
        ' Give the focus to txtSalary
        txtSalary.Focus()
    End Sub

    Private Sub btnExit_Click() Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Private Sub btnCheckQual_Click(sender As Object, e As EventArgs) Handles btnCheckQual.Click
        ' Variables to hold input data
        Dim dblSalary As Double
        Dim intYearsOnJob As Integer
        'Error handling
        Try
            ' Get user's input
            dblSalary = CDbl(txtSalary.Text)
            intYearsOnJob = CInt(txtYearsOnJob.Text)
            ' Determine whether applicant qualifies.
            If dblSalary > 30000 And intYearsOnJob > 2 Or intYearsOnJob > 5 Then
                lblMessage.Text = "The applicant qualifies."
            Else
                lblMessage.Text = "The applicant does not qualify."
            End If
        Catch ex As Exception
            ' Display and error message.
            lblMessage.Text = "Please enter numeric values."
        End Try
    End Sub
End Class

Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() ' Closes form
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Try
            ' Declare variable
            Dim decWeight As Decimal
            Dim decMass As Decimal
            ' User's input
            decMass = CDec(txtMass.Text)
            decWeight = decMass * 9.8D
            lblWeight.Text = decWeight.ToString
            If decWeight > 1000 Then
                lblMessage.Text = "Too heavy!"
            ElseIf decWeight < 10 Then
                lblMessage.Text = "Too light!"
            ElseIf decWeight > 10 And decweight < 1000 Then
                lblMessage.Text = "Acceptable range."
            End If
            txtMass.Focus()
        Catch ex As Exception
            ' Error message
            lblMessage.Text = "Error!"
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear text
        txtMass.Clear()
        lblWeight.Text = String.Empty
        lblMessage.Text = "Please enter the mass above"
        ' Return focus to TextBox
        txtMass.Focus()
    End Sub
End Class

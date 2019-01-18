Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Declare variables
        Dim intHours As Integer
        Dim decGrossPay As Decimal
        Dim decPayRate As Decimal
        ' Math
        If Integer.TryParse(txtHours.Text, intHours) And intHours >= 0 And intHours <= 100 Then
                    If Decimal.TryParse(txtPayRate.Text, decPayRate) And decPayRate >= 0 And decPayRate <= 100 Then
                        decGrossPay = intHours * decPayRate
                        lblStatus.Text = "Gross Pay: " & decGrossPay.ToString("c")
                    Else
                        lblStatus.Text = "Invalid pay rate."
                    End If
                Else
                    lblStatus.Text = "Invalid number of hours."
                End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() 'Closes form
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clears text
        txtHours.Clear()
        txtPayRate.Clear()
        lblStatus.Text = "← Please enter numerical values"
        ' Returns focus to txtHours
        txtHours.Focus()
    End Sub
End Class

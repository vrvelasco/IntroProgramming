Public Class Form1
    Private Sub btnCalculate_Click() Handles btnCalculate.Click
        ' Declare variables
        Dim intHours As Integer
        Dim decPayRate As Decimal
        Dim decGrossPay As Decimal
        ' input and validate the Hours and Pay Rate
        If Integer.TryParse(txtHours.Text, intHours) Then
            If Decimal.TryParse(txtPayRate.Text, decPayRate) Then
                ' Check range of Hours
                If intHours >= 0 And intHours <= 168 Then
                    ' Check range of Pay Rate
                    If decPayRate >= 0D And decPayRate <= 45D Then
                        ' Calculate Gross Pay
                        decGrossPay = intHours * decPayRate
                        lblGrossPay.Text = decGrossPay.ToString("c")
                    Else
                        lblStatus.Text = "Please enter rate from $0.00 to $45.00."
                    End If
                Else
                    lblStatus.Text = "Please enter hours from 0 to 168."
                End If

            Else
                    lblStatus.Text = "Please enter valid decimal rate."
            End If
        Else
                lblStatus.Text = "Please enter valid integer hours."
        End If
    End Sub

    Private Sub btnExit_Click() Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class

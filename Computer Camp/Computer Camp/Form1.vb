Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() ' Closes form
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear input
        radBasic.Checked = True
        chkMeals.Checked = False
        chkCabin.Checked = False
        txtMoney.Clear()
        ' Clear labels
        lblLanguageFee.Text = "Language Fee:"
        lblOptionsSubtotal.Text = "Options Subtotal:"
        lblMoney.Text = "E-Spending Money:"
        lblTotalCost.Text = "Total Cost:"
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Declare variables
        Dim decLanguage As Decimal
        Dim decOptions As Decimal
        Dim decMoney As Decimal
        Dim decTotal As Decimal
        ' Set Language cost
        If radBasic.Checked = True Then
            decLanguage += 1000D
        ElseIf radJava.Checked = True Then
            decLanguage += 2000D
        End If
        ' Set Options
        If chkMeals.Checked = True Then
            decOptions += 100D
        End If
        If chkCabin.Checked = True Then
            decOptions += 200D
        End If
        ' Start E-Spending Money
        If Decimal.TryParse(txtMoney.Text, decMoney) Then
            If decMoney >= 1 And decMoney <= 20 Then
                decTotal = decLanguage + decOptions + decMoney
                ' Display results
                lblLanguageFee.Text = "Language Fee: " & decLanguage.ToString("c")
                lblOptionsSubtotal.Text = "Options Subtotal: " & decOptions.ToString("c")
                lblMoney.Text = "E-Spending Money: " & decMoney.ToString("c")
                lblTotalCost.Text = "Total Cost: " & decTotal.ToString("c")
            Else
                MessageBox.Show("Please enter an E-Spending Money amount between $1 and $20.")
            End If
        Else
            MessageBox.Show("Please enter a valid amount for the E-Spending Money account.")
        End If
    End Sub
End Class

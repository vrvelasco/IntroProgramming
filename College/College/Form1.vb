Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Declare variables
        Dim decDegreeCost As Decimal
        Dim decOptions As Decimal
        Dim decFinancialAid As Decimal
        Dim decOutOfPocket As Decimal
        Dim decTotal As Decimal
        ' Input Degree Cost
        If radAssociate.Checked = True Then
            decDegreeCost = 10000D
        ElseIf radBachelor.Checked = True Then
            decDegreeCost = 20000D
        ElseIf radMaster.Checked = True Then
            decDegreeCost = 30000D
        End If
        ' Input Options
        If chkDorm.Checked = True Then
            decOptions += 3000D
        End If
        If chkMeal.Checked = True Then
            decOptions += 2000D
        End If
        If chkHealth.Checked = True Then
            decOptions += 1000D
        End If
        ' Input Financial Aid
        If Decimal.TryParse(txtAid.Text, decFinancialAid) Then
            ' Check range of Financial Aid
            If decFinancialAid >= 1000D And decFinancialAid <= 25000D Then
                ' Calculate Total Cost
                decTotal = decDegreeCost + decOptions
                decOutOfPocket = decTotal - decFinancialAid
                ' Display results
                lblTotal.Text = decTotal.ToString("c")
                lblAid.Text = decFinancialAid.ToString("c")
                lblPocket.Text = decOutOfPocket.ToString("c")
            Else
                MessageBox.Show("Please enter financial aid from $1,000 to $25,000.")
            End If
        Else
            MessageBox.Show("Please enter Financial aid amount.")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() ' Close form
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear form
        radAssociate.Checked = True
        chkDorm.Checked = False
        chkMeal.Checked = False
        chkHealth.Checked = False
        txtAid.Clear()
        lblTotal.Text = String.Empty
        lblAid.Text = String.Empty
        lblPocket.Text = String.Empty
    End Sub
End Class

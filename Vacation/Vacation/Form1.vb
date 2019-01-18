Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Declare variables
        Dim decCash As Decimal
        Dim decDestinationCost As Decimal
        Dim decOptionCost As Decimal
        Dim decTotalCost As Decimal
        ' Input Destination Cost
        If radBranson.Checked = True Then
            decDestinationCost = 1000D
        ElseIf radChicago.Checked = True Then
            decDestinationCost = 2000D
        ElseIf radOrlando.Checked = True Then
            decDestinationCost = 3000D
        End If
        ' Input Options
        If chkCar.Checked = True Then
            decOptionCost += 300D
        End If
        If chkSuite.Checked = True Then
            decOptionCost += 200D
        End If
        If chkTickets.Checked = True Then
            decOptionCost += 100D
        End If
        ' Input and validate cash
        If Decimal.TryParse(txtCash.Text, decCash) Then
            If decCash >= 100D And decCash <= 500D Then
                ' Calculate total
                decTotalCost = decDestinationCost + decOptionCost + decCash
                ' Display output in labels
                lblDestination.Text = decDestinationCost.ToString("c")
                lblOption.Text = decOptionCost.ToString("c")
                lblCash.Text = decCash.ToString("c")
                lblTotal.Text = decTotalCost.ToString("c")
            Else
                MessageBox.Show("Please enter cash between $100 and $500.")
            End If
        Else
            MessageBox.Show("Please enter a valid decimal for cash.")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear form
        radBranson.Checked = True
        chkCar.Checked = False
        chkSuite.Checked = False
        chkTickets.Checked = False
        txtCash.Clear()
        lblDestination.Text = String.Empty
        lblOption.Text = String.Empty
        lblCash.Text = String.Empty
        lblTotal.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() ' Closes form
    End Sub
End Class

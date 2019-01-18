Public Class Form1
    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        ' Declare variable
        Dim decTotal As Decimal
        ' Input Dinner Plate
        If radMeatloaf.Checked = True Then
            MessageBox.Show("You ordered meatloaf")
            decTotal = 5
        ElseIf radCatfish.Checked = True Then
            MessageBox.Show("You ordered catfish")
            decTotal = 4
        ElseIf radSalad.Checked = True Then
            MessageBox.Show("You ordered salad")
            decTotal = 3
        End If
        ' Input Side Orders
        If chkFries.Checked = True Then
            MessageBox.Show("You ordered fries")
            decTotal += 1D
        End If
        If chkBeans.Checked = True Then
            MessageBox.Show("You ordered beans")
            decTotal += 0.75D
        End If
        If chkSlaw.Checked = True Then
            MessageBox.Show("You ordered slaw")
            decTotal += 0.5D
        End If
        ' Output total
        lblTotal.Text = decTotal.ToString("c")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear radio buttons
        radMeatloaf.Checked = True
        ' Clear checkboxes
        chkFries.Checked = False
        chkBeans.Checked = False
        chkSlaw.Checked = False
        ' Clear label
        lblTotal.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' End the program
        Me.Close()
    End Sub
End Class

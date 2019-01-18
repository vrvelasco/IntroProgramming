Public Class Form1
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        ' Declare variable
        Dim strName As String
        Dim decPounds As Decimal
        ' Input data from form
        strName = txtName.Text
        If Decimal.TryParse(txtPounds.Text, decPounds) Then
            If decPounds > 0 Then
                ' Add data to ListBoxes
                lstNames.Items.Add(strName)
                lstPounds.Items.Add(decPounds)
            Else
                MessageBox.Show("Pounds need to be greater than zero.")
            End If
        Else
            MessageBox.Show("Please enter a valid decimal.")
        End If
        ' Clear after input
        txtName.Clear()
        txtPounds.Clear()
    End Sub
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Declare variable
        Dim decTotal, decAverage As Decimal
        Dim intLoop As Integer = 0
        ' Make sure data in ListBox
        If lstPounds.Items.Count > 0 Then
            ' Loop all items in ListBox
            Do While intLoop < lstPounds.Items.Count
                ' Calculate running total
                decTotal += lstPounds.Items(intLoop)
                intLoop += 1 ' Increment
            Loop
            ' Calculate average
            decAverage = decTotal / intLoop
            ' Display total
            lblTotal.Text = decTotal.ToString("n1")
            lblAverage.Text = decAverage.ToString("n1")
        Else
            MessageBox.Show("Please enter data.")
        End If
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear form
        txtName.Clear()
        txtPounds.Clear()
        lstNames.Items.Clear()
        lstPounds.Items.Clear()
        lblTotal.Text = String.Empty
        lblAverage.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() ' Close form
    End Sub
End Class

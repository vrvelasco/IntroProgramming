Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() ' Closes the form
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear form
        txtCalories.Clear()
        txtFatGrams.Clear()
        lblFatPercentage.Text = String.Empty
        picStatus.Image = picInfo.Image
        lblMessage.Text = "Please enter values above."
        Me.Width = 465 ' Resize
        txtCalories.Focus() ' Set focus to TextBox
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Declare variables
        Dim intCalories As Integer
        Dim intFatGrams As Integer
        Dim decFatCalories As Decimal
        Dim decFatPercentage As Decimal
        Dim decFatPercentageLabel As Decimal
        ' Get user input and validate the data
        If Integer.TryParse(txtCalories.Text, intCalories) Then
            If Integer.TryParse(txtFatGrams.Text, intFatGrams) Then
                If intCalories > 0 Then
                    If intFatGrams > 0 Then
                        decFatCalories = intFatGrams * 9 ' Calculate fat calories
                        If intCalories > decFatCalories Then
                            decFatPercentage = decFatCalories / intCalories ' Get the percentage
                            lblFatPercentage.Text = decFatPercentage.ToString("p") ' Display in label
                            picStatus.Image = picCheck.Image
                            lblMessage.Text = "Calculation complete!"
                            ' For my label (This is what you would see on the package)
                            decFatPercentageLabel = (intFatGrams / 78D) * 100D ' Daily value from FDA
                            lblFatPercentFacts.Text = decFatPercentageLabel.ToString("n0") & "%"
                            If decFatPercentage < 0.3 Then
                                picStatus.Image = picCheck.Image
                                lblMessage.Text = "Great choice! This is a low-fat food!"
                            End If
                            ' Show label
                            Me.Width = 815
                            lblCalories.Text = intCalories.ToString()
                            lblTotalFat.Text = intFatGrams.ToString() & "g"
                        Else
                            picStatus.Image = picError.Image
                            lblMessage.Text = "Please enter the correct number for calories and fat grams." ' Calories and fat grams error message
                        End If
                    Else
                        picStatus.Image = picAlert.Image
                        lblMessage.Text = "Please enter a positive value for the number of fat grams." ' + Fat grams error message
                    End If
                Else
                    picStatus.Image = picAlert.Image
                    lblMessage.Text = "Please enter a positive value for the number of calories." ' + Calories error message
                End If
            Else
                picStatus.Image = picError.Image
                lblMessage.Text = "Please enter a valid value for the number of fat grams." ' Fat grams error message
            End If
        Else
            picStatus.Image = picError.Image
            lblMessage.Text = "Please enter a valid value for the number of calories." ' Calories error message
        End If
    End Sub
End Class

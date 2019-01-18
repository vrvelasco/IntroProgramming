Public Class Form1
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        ' Declare variable
        Dim intRating As Integer
        Dim strProfessor As String
        ' Get input and validate
        If txtProfessorName.Text = Nothing Then                              ' Empty Name field?
            MessageBox.Show("Please enter the professor's name.", "Missing Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            strProfessor = UCase(txtProfessorName.Text)                      ' From TextBox
        End If
        If Integer.TryParse(txtProfessorRating.Text, intRating) Then         ' Valid integer?
            If intRating >= 0 And intRating <= 4 Then                        ' Between 0 and 4?
                lstProfessorNames.Items.Add(strProfessor)                    ' Add name
                lstProfessorRatings.Items.Add(intRating)                     ' Add Rating
                If intRating = 1 Then                                        ' For the fancy ListBox
                    lstProfessorRatingsFancy.Items.Add(intRating & " Star")
                Else
                    lstProfessorRatingsFancy.Items.Add(intRating & " Stars") ' Plural
                End If
                ' Clear TextBoxes
                txtProfessorName.Clear()
                txtProfessorRating.Clear()
            Else
                MessageBox.Show("Please enter a rating between 0-4.", "Invalid Rating", MessageBoxButtons.OK, MessageBoxIcon.Error)        ' Error message
            End If
        Else
            MessageBox.Show("Please enter a valid integer.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)                  ' Error message
        End If
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim decAverage As Decimal
        Dim intCount, intSum As Integer
        ' Get Number of Professors
        lblNumberProfessors.Text = CStr(lstProfessorNames.Items.Count)
        ' Get average rating (using non-fancy ListBox)
        For intCount = 0 To lstProfessorRatings.Items.Count - 1
            intSum += CInt(lstProfessorRatings.Items(intCount))
        Next
        ' Display in Label
        If lstProfessorRatings.Items.Count = 0 Then
            MessageBox.Show("Please enter at least 1 rating for a professor.", "Missing Rating", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ' Set focus for faster entry
            txtProfessorName.Focus()
        Else
            decAverage = CDec(intSum / intCount) ' Calculate average
        End If
        lblAverageRating.Text = decAverage.ToString("n1") ' Display average
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear form
        txtProfessorName.Clear()
        txtProfessorRating.Clear()
        lstProfessorNames.Items.Clear()
        lstProfessorRatings.Items.Clear()
        lstProfessorRatingsFancy.Items.Clear()
        lblNumberProfessors.Text = "0"
        lblAverageRating.Text = "0.0"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() ' Close program
    End Sub
End Class

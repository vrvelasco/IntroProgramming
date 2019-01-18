Public Class Form1
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        ' Declare variables
        Dim intOscars As Integer
        ' Get Number of Oscars and Validate
        If Integer.TryParse(txtOscars.Text, intOscars) Then ' Valid integer?
            If intOscars >= 0 Then                          ' Greater than or equal to zero?
                ' Get Movie Name
                If txtMovie.Text = Nothing Then
                    MessageBox.Show("Please enter a movie.", "Movie Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    ' Add Name to ListBox
                    lstMovies.Items.Add(UCase(txtMovie.Text))
                    ' Add # of Oscars
                    lstOscars.Items.Add(intOscars)
                    ' Clear TextBoxes for faster entry
                    txtMovie.Clear()
                    txtOscars.Clear()
                    ' Return focus
                    txtMovie.Focus()
                End If
            Else
                MessageBox.Show("Please enter a number greater than or equal to zero for the number of Oscars.", "Number of Oscars", MessageBoxButtons.OK, MessageBoxIcon.Error) ' Error message
            End If
        Else
            MessageBox.Show("Please enter a valid integer.", "Invalid Integer", MessageBoxButtons.OK, MessageBoxIcon.Error)                                                      ' Error message
        End If
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Declare variables
        Dim intLoopCount, intSum As Integer
        ' Get numbers from ListBox
        If lstOscars.Items.Count = 0 Then ' No items in ListBox?
            MessageBox.Show("Please enter at least one movie and the number of Oscars it received.", "Missing Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Do While intLoopCount < lstOscars.Items.Count
                ' Keep running total
                intSum += CInt(lstOscars.Items(intLoopCount))
                intLoopCount += 1 ' Increment
            Loop
        End If
        ' Display result
        lblTotalOscars.Text = intSum.ToString()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear form
        txtMovie.Clear()
        txtOscars.Clear()
        lstMovies.Items.Clear()
        lstOscars.Items.Clear()
        lblTotalOscars.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MessageBox.Show("This class was awesome!" & vbCrLf & "Looking forward to next semester!", "Thanks!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close() ' Closes form
    End Sub
End Class

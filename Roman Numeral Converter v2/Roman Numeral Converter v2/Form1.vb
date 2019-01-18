Public Class Form1
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        ' Declare variables
        Dim intNumber As Integer
        Dim strRoman As String = Nothing
        ' Start of extra credit
        ' **********************************************************************
        ' * The only way I could figure this out was using a Do While loop.    *
        ' * Like in Alice when we had to get something close to another object.*
        ' **********************************************************************
        ' Get user input (Using TryParse to validate the Text)
        If Integer.TryParse(txtInteger.Text, intNumber) And intNumber >= 1 And intNumber <= 20 Then ' Verify that it's an integer and between 1 and 20.
            ' Display "X" for every 10
            Do While intNumber >= 10
                intNumber = intNumber - 10           ' Subtract 10 from the number (Value for "X")
                strRoman = strRoman & "X"            ' Concatenate previous string with an "X"
            Loop
            ' Using Select Case instead of the If Statement 
            Select Case intNumber
            ' Case for when the intNumber is greater than or equal to 9.
                Case >= 9
                    intNumber = intNumber - 9        ' Subtract 9 from the number (Value for "IX")
                    strRoman = strRoman & "IX"       ' Concatenate previous string with an "IX"
            ' Case for when the intNumber is greater than or equal to 5.
                Case >= 5
                    intNumber = intNumber - 5        ' Subtract 5 from the number (Value for "V")
                    strRoman = strRoman & "V"        ' Concatenate previous string with a "V"
            ' Case for when the intNumber is greater than or equal to 4.
                Case >= 4
                    intNumber = intNumber - 4        ' Subtract 4 from the number (Value for "IV")
                    strRoman = strRoman & "IV"       ' Concatenate previous string with an "IV"
            End Select
            ' Display "I" for every 1
            Do While intNumber >= 1
                intNumber = intNumber - 1            ' Subtract 1 from the number (Value for "I")
                strRoman = strRoman & "I"            ' Concatenate previous string with an "I"
            Loop
            ' Output Roman Numeral to Label
            lblRomanOutput.Text = strRoman.ToString
        Else
            ' Display error message (using Roman Output label)
            lblRomanOutput.Text = "ERROR!"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set transparency :)
        picBanner1.Parent = picBackground
        picBanner2.Parent = picBackground
        lblTitle.Parent = picBackground
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() ' Closes form
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear text
        txtInteger.Clear()
        lblRomanOutput.Text = String.Empty
        ' Return focus
        txtInteger.Focus()
    End Sub
End Class

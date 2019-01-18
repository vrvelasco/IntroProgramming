Public Class Form1
    Private Sub btnGuess_Click(sender As Object, e As EventArgs) Handles btnGuess.Click
        ' ******************
        ' Declare variables
        ' ******************
        Dim strSecretWord As String = Nothing                                     ' Stores secret word
        Dim strGuess As String = Nothing                                          ' User's guess
        Dim intTries As Integer = 1                                               ' Initialize
        Dim strQuit As String = "QUIT"                                            ' For quiting the Loop
        Dim strLoop As String = "F"                                               ' To cancel loop in the unlimited attempts once the user gets it right
        ' **********
        ' Get input
        ' **********
        If txtSecretWord.Text = String.Empty Then
            Do While txtSecretWord.Text = Nothing
                txtSecretWord.Text = UCase(InputBox("Please enter the secret word!", "Secret Word"))
            Loop
        End If
        If Not txtSecretWord.Text = String.Empty Then
            strSecretWord = UCase(txtSecretWord.Text)                             ' Store Secret Word
            Me.Height = 313                                                       ' Shows game
            btnGuess.Width = 87                                                   ' Size to other Button sizes
            grpMain.Visible = True                                                ' Show GroupBox (Main game)
            Do While strGuess = Nothing
                strGuess = UCase(InputBox("What is the secret word?", "Try #: " & intTries)) ' Initial try
            Loop
            lstAttempts.Items.Add(strGuess)                                       ' Display in ListBox
        End If
        ' **********************
        ' Check number of tries
        ' **********************
        If chkTries.Checked = True Then                                           ' Is the CheckBox checked?
            Do Until intTries = 3 Or strLoop = "T"
                If strGuess = strSecretWord Or strGuess = strQuit Or intTries < 3 Then ' Loop until 3rd try
                    If strGuess = strSecretWord Then                          ' They guessed correctly
                        strLoop = "T"
                        MessageBox.Show("You won!" & vbCrLf & vbCrLf & "You guessed the secret word!")
                    ElseIf strGuess = strQuit Then                            ' The user decided to give up
                        strLoop = "T"
                        MessageBox.Show("Thanks for playing! The secret word was: " & strSecretWord.ToUpper() & ".")
                    Else
                        strGuess = UCase(InputBox("The was not the secret word. Please try again!" & vbCrLf & vbCrLf & "If you want to give up, enter ""Quit"".", "Try #: " & intTries + 1))
                        lstAttempts.Items.Add(strGuess)                       ' Add guess to ListBox
                        intTries += 1                                         ' Increment
                    End If
                End If
            Loop                                                              ' Continue until condition is met
            strLoop = "F"
            If intTries = 3 Then                                                  ' If we reached the 3rd try then we stop
                MessageBox.Show("Thanks for playing! The secret word was: " & strSecretWord.ToUpper() & ".")
            End If
        Else
            Do Until strLoop = "T"                                                ' Loop until condition is met
                If strGuess = strSecretWord Then                                  ' They guessed correctly
                    strLoop = "T"
                    MessageBox.Show("You won!" & vbCrLf & vbCrLf & "You guessed the secret word!")
                ElseIf strGuess = strQuit Then                                    ' The user decided to give up
                    strLoop = "T"
                    MessageBox.Show("Thanks for playing! The secret word was: " & strSecretWord.ToUpper() & ".")
                Else
                    strGuess = UCase(InputBox("The was not the secret word. Please try again!" & vbCrLf & vbCrLf & "If you want to give up, enter ""Quit"".", "Try #: " & intTries + 1))
                    lstAttempts.Items.Add(strGuess)                               ' Add guess to ListBox
                    intTries += 1                                                 ' Increment
                End If
            Loop                                                                  ' Continue until condition is met
            strLoop = "F"
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()                                                                ' Close form
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        grpMain.Visible = False                                                  ' Hide GroupBox
        btnGuess.Width = 295                                                     ' Resize button
        Me.Height = 305                                                          ' Resize form
        ' Clear text
        txtSecretWord.Clear()
        chkTries.Checked = False
        lstAttempts.Items.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = 305                                                         ' Resize form
    End Sub
End Class

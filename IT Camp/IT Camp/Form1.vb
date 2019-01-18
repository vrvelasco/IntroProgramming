Public Class Form1
    '                                                                                                                           
    '  IIIIIIIIIITTTTTTTTTTTTTTTTTTTTTTT             CCCCCCCCCCCCC                                                              
    '  I::::::::IT:::::::::::::::::::::T          CCC::::::::::::C                                                              
    '  I::::::::IT:::::::::::::::::::::T        CC:::::::::::::::C                                                              
    '  II::::::IIT:::::TT:::::::TT:::::T       C:::::CCCCCCCC::::C                                                              
    '    I::::I  TTTTTT  T:::::T  TTTTTT      C:::::C       CCCCCC  aaaaaaaaaaaaa      mmmmmmm    mmmmmmm   ppppp   ppppppppp   
    '    I::::I          T:::::T             C:::::C                a::::::::::::a   mm:::::::m  m:::::::mm p::::ppp:::::::::p  
    '    I::::I          T:::::T             C:::::C                aaaaaaaaa:::::a m::::::::::mm::::::::::mp:::::::::::::::::p 
    '    I::::I          T:::::T             C:::::C                         a::::a m::::::::::::::::::::::mpp::::::ppppp::::::p
    '    I::::I          T:::::T             C:::::C                  aaaaaaa:::::a m:::::mmm::::::mmm:::::m p:::::p     p:::::p
    '    I::::I          T:::::T             C:::::C                aa::::::::::::a m::::m   m::::m   m::::m p:::::p     p:::::p
    '    I::::I          T:::::T             C:::::C               a::::aaaa::::::a m::::m   m::::m   m::::m p:::::p     p:::::p
    '    I::::I          T:::::T              C:::::C       CCCCCCa::::a    a:::::a m::::m   m::::m   m::::m p:::::p    p::::::p
    '  II::::::II      TT:::::::TT             C:::::CCCCCCCC::::Ca::::a    a:::::a m::::m   m::::m   m::::m p:::::ppppp:::::::p
    '  I::::::::I      T:::::::::T              CC:::::::::::::::Ca:::::aaaa::::::a m::::m   m::::m   m::::m p::::::::::::::::p 
    '  I::::::::I      T:::::::::T                CCC::::::::::::C a::::::::::aa:::am::::m   m::::m   m::::m p::::::::::::::pp  
    '  IIIIIIIIII      TTTTTTTTTTT                   CCCCCCCCCCCCC  aaaaaaaaaa  aaaammmmmm   mmmmmm   mmmmmm p::::::pppppppp    
    '                                                                                                        p:::::p            
    '                                                                                                        p:::::p            
    '                                                                                                       p:::::::p           
    '                                                                                                       p:::::::p           
    '                                                                                                       p:::::::p           
    '                                                                                                       ppppppppp           
    '                                                                                                                           
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Label Transparency
        lblTitle.Parent = picTerminal
        lblSubtitle.Parent = picTerminal
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Declare variables
        Dim strFirstName As String = Nothing
        Dim strLastName As String = Nothing
        Dim decIT As Decimal
        Dim decOptions As Decimal
        Dim decDebit As Decimal
        Dim decTotal As Decimal
        ' ******************
        ' * Get user input *
        ' ******************
        ' Set Variable
        strFirstName = txtFirstName.Text
        strLastName = txtLastName.Text
        ' Set IT Specialization
        If radProgramming.Checked = True Then
            decIT = 4000D
        ElseIf radDatabase.Checked = True Then
            decIT = 3000D
        ElseIf radWebDesign.Checked = True Then
            decIT = 2000D
        ElseIf radHelpDesk.Checked = True Then
            decIT = 1000D
        End If
        ' Set Computer Options
        If chkProcessor.Checked = True Then
            decOptions += 400D
        End If
        If chkMemory.Checked = True Then
            decOptions += 300D
        End If
        If chkHDD.Checked = True Then
            decOptions += 200D
        End If
        If chkGPU.Checked = True Then
            decOptions += 100D
        End If
        ' Validate debit card info
        If Decimal.TryParse(txtDebitCard.Text, decDebit) Then
            If decDebit >= 20 And decDebit <= 100 Then
                If strFirstName = Nothing Then
                    MessageBox.Show("Please enter your first name.")
                Else
                    If strLastName = Nothing Then
                        MessageBox.Show("Please enter your last name.")
                    Else
                        ' Calculate Total
                        decTotal = decIT + decOptions + decDebit
                        ' Output info
                        lblFullName.Text = "Name: " & strFirstName & " " & strLastName
                        lblITCost.Text = decIT.ToString("c")
                        lblOptionsCost.Text = decOptions.ToString("c")
                        lblDebitValue.Text = decDebit.ToString("c")
                        lblTotalCost.Text = "Total: " & decTotal.ToString("c")
                        lblDateTime.Text = "Submitted: " & DateTime.Now
                        Me.Height = 840 ' Show receipt
                    End If
                End If
            Else
                MessageBox.Show("Please enter an amount between $20 and $100 for the debit card value.")
            End If
        Else
            MessageBox.Show("Please enter a valid value for the debit card amount.")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() ' Closes form
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear text
        txtFirstName.Clear()
        txtLastName.Clear()
        txtDebitCard.Clear()
        radProgramming.Checked = True
        chkProcessor.Checked = False
        chkMemory.Checked = False
        chkHDD.Checked = False
        chkGPU.Checked = False
        lblDateTime.Text = String.Empty
        lblFullName.Text = String.Empty
        lblITCost.Text = String.Empty
        lblOptionsCost.Text = String.Empty
        lblDebitValue.Text = String.Empty
        lblTotalCost.Text = String.Empty
        Me.Height = 505 ' Hide receipt
        txtFirstName.Focus() ' Set focus to first TextBox
    End Sub
End Class

Public Class Form1
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear form
        lstSerial.Items.Clear()
        lstNames.Items.Clear()
        lstPhone.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() ' Close form
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        ' Declare variables
        Dim strName As String
        Dim strPhone As String
        Dim intSerial As Integer
        ' Get user input
        strName = InputBox("Please enter a name.", "Enter Name", "Jenny")
        ' Makes sure there is something in the variables
        Do While strName = Nothing
            MessageBox.Show("Please enter a name.")
            strName = InputBox("Please enter a name.", "Enter Name", "Jenny")
        Loop
        strPhone = InputBox("Please enter a phone number.", "Enter Phone Number", "867-5309")
            Do While strPhone = Nothing
            MessageBox.Show("Please enter a phone number.")
            strPhone = InputBox("Please enter a phone number.", "Enter Phone Number", "867-5309")
        Loop
        ' Add items
        lstNames.Items.Add(strName)
        lstPhone.Items.Add(strPhone)
        ' Count items in the lstNames ListBox (This is why I needed to make sure that there is an entry from the user above)
        intSerial = lstNames.Items.Count
        lstSerial.Items.Add(intSerial)
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Declare variable
        Dim strSerial As String
        Dim intSerial As Integer
        Dim strName As String
        Dim strPhone As String
        'Get user input
        strSerial = InputBox("Please enter a serial number. (Starting with 1) ", "Display Name and Phone Number", "1")
        Do While strSerial = Nothing
            MessageBox.Show("Please enter a name.")
            strSerial = InputBox("Please enter a serial number. (Starting with 1) ", "Display Name and Phone Number", "1")
        Loop
        ' Convert String to Integer
        intSerial = CInt(strSerial)
        ' Get info from ListBoxes
        If intSerial > 0 And intSerial < lstSerial.Items.Count + 1 Then
            strName = CStr(lstNames.Items(intSerial - 1))
            strPhone = CStr(lstPhone.Items(intSerial - 1))
            ' Display message
            MessageBox.Show(strName & "'s phone number is " & strPhone)
        Else
            MessageBox.Show("Please enter a serial number within range.")
        End If
    End Sub
End Class

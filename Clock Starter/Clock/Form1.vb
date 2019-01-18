Public Class Form1
    ' ●●●●●●●●●●●●●●●●●●●●●
    ' ● DECLARE VARIABLES ●
    ' ●●●●●●●●●●●●●●●●●●●●●
    Dim intSeconds As Integer            ' Seconds value
    Dim intMinutes As Integer            ' Minutes value
    Dim intHours As Integer              ' Hours value
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        ' ●●●●●●●●●●●●●●●
        ' ● START HOURS ●
        ' ●●●●●●●●●●●●●●●
        For intHours = 0 To 24
            If intHours >= 24 Then         ' Reset for 
                intHours = 0               ' 24 hour clock
            End If
            ' Two digit display
            If intHours < 10 Then
                lblHours.Text = "0" & intHours.ToString()
            Else
                lblHours.Text = intHours.ToString()
            End If
            ' ●●●●●●●●●●●●●●●●●
            ' ● START MINUTES ●
            ' ●●●●●●●●●●●●●●●●●
            For intMinutes = 0 To 59
                If intHours >= 24 Then     ' Reset for
                    intMinutes = 0         ' 24 hour clock
                End If
                ' Two digit display
                If intMinutes < 10 Then
                    lblMinutes.Text = "0" & intMinutes.ToString()
                Else
                    lblMinutes.Text = intMinutes.ToString()
                End If
                ' ●●●●●●●●●●●●●●●●●
                ' ● START SECONDS ●
                ' ●●●●●●●●●●●●●●●●●
                For intSeconds = 0 To 59
                    If intHours >= 24 Then ' Reset for
                        intSeconds = 0     ' 24 hour clock
                    End If
                    ' Two digit display
                    If intSeconds < 10 Then
                        lblSeconds.Text = "0" & intSeconds.ToString()
                    Else
                        lblSeconds.Text = intSeconds.ToString()
                    End If
                    ' Following two lines must be at the end of the inner-most loop.
                    Application.DoEvents() ' Update the label on the form.
                    'System.Threading.Thread.Sleep(1) ' Pause for 1 second.
                    tmrUpdate.Enabled = True
                    ' ●●●●●●●●●●●●●●●●●●●●●●●●
                    ' ● START CUSTOMIZATIONS ●
                    ' ●●●●●●●●●●●●●●●●●●●●●●●●
                    ' Change font color
                    lblHours.ForeColor = btnColor.BackColor
                    lblLeftColon.ForeColor = btnColor.BackColor
                    lblMinutes.ForeColor = btnColor.BackColor
                    lblRightColon.ForeColor = btnColor.BackColor
                    lblSeconds.ForeColor = btnColor.BackColor
                    lblDayNight.ForeColor = btnColor.BackColor
                    lblAlarmIcon.ForeColor = btnColor.BackColor
                    ' Blink colons
                    If chkBlink.Checked = True Then
                        If lblLeftColon.Visible = True Then
                            lblLeftColon.Visible = False
                            lblRightColon.Visible = False
                        Else
                            lblLeftColon.Visible = True
                            lblRightColon.Visible = True
                        End If
                    Else
                        lblLeftColon.Visible = True
                        lblRightColon.Visible = True
                    End If
                    ' Military time?
                    If chkMilitary.Checked = True Then
                        lblDayNight.Visible = False
                        ' Two digit display
                        If intHours < 10 Then
                            lblHours.Text = "0" & intHours.ToString()
                        Else
                            lblHours.Text = intHours.ToString()
                        End If
                    Else
                        If intHours >= 12 Then
                            lblDayNight.Text = "PM"
                        Else
                            lblDayNight.Text = "AM"
                        End If
                        lblDayNight.Visible = True
                        If intHours > 12 Then
                            lblHours.Text = CStr(intHours - 12)
                        End If
                    End If
                Next
                ' ●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●
                ' ● RESET SECONDS, ADD ONE MINUTE, AND DISPLAY ●
                ' ●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●
                intSeconds = 0
                intMinutes += 1
                lblMinutes.Text = intMinutes.ToString()
            Next
            ' ●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●
            ' ● RESET MINUTES, ADD ONE HOUR, AND DISPLAY ●
            ' ●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●●
            intMinutes = 0
            intHours += 1
            lblHours.Text = intHours.ToString()
        Next
    End Sub

    Private Sub btnGreenFont_Click(sender As Object, e As EventArgs) Handles btnGreenFont.Click
        btnColor.BackColor = btnGreenFont.BackColor
    End Sub

    Private Sub btnRedFont_Click(sender As Object, e As EventArgs) Handles btnRedFont.Click
        btnColor.BackColor = btnRedFont.BackColor
    End Sub

    Private Sub btnPurpleFont_Click(sender As Object, e As EventArgs) Handles btnPurpleFont.Click
        btnColor.BackColor = btnPurpleFont.BackColor
    End Sub

    Private Sub btnBlueFont_Click(sender As Object, e As EventArgs) Handles btnBlueFont.Click
        btnColor.BackColor = btnBlueFont.BackColor
    End Sub

    Private Sub btnWhiteFont_Click(sender As Object, e As EventArgs) Handles btnWhiteFont.Click
        btnColor.BackColor = btnWhiteFont.BackColor
    End Sub

    Private Sub chkCustomTime_CheckedChanged(sender As Object, e As EventArgs) Handles chkCustomTime.CheckedChanged
        ' ●●●●●●●●●●●●●●●●●●●●●●●●●●●●●
        ' ● CHECK CUSTOM TIME SETTING ●
        ' ●●●●●●●●●●●●●●●●●●●●●●●●●●●●●
        If chkCustomTime.Checked = True Then
            txtCustomHour.Enabled = True
            txtCustomMinute.Enabled = True
            txtCustomSecond.Enabled = True
            btnSetCustomTime.Enabled = True
        Else
            txtCustomHour.Enabled = False
            txtCustomMinute.Enabled = False
            txtCustomSecond.Enabled = False
            btnSetCustomTime.Enabled = False
            ' GET COMPUTER TIME
            '
            intHours = Now.Hour
            intMinutes = Now.Minute
            intSeconds = Now.Second
        End If
    End Sub

    Private Sub btnSetCustomTime_Click(sender As Object, e As EventArgs) Handles btnSetCustomTime.Click
        ' ●●●●●●●●●●●●●●●●●●●●●
        ' ● DECLARE VARIABLES ●
        ' ●●●●●●●●●●●●●●●●●●●●●
        Dim intCustomHours, intCustomMinutes, intCustomSeconds As Integer
        If Integer.TryParse(txtCustomHour.Text, intCustomHours) Then
            If Integer.TryParse(txtCustomMinute.Text, intCustomMinutes) Then
                If Integer.TryParse(txtCustomSecond.Text, intCustomSeconds) Then
                    If intCustomHours < 0 Or intCustomMinutes < 0 Or intCustomSeconds < 0 Then

                    End If
                    ' ●●●●●●●●●●●●●●●●●●●●●●●●●●
                    ' ● CHANGE VALUES IN CLOCK ●
                    ' ●●●●●●●●●●●●●●●●●●●●●●●●●●
                    intHours = intCustomHours
                    intMinutes = intCustomMinutes
                    intSeconds = intCustomSeconds
                Else
                    MessageBox.Show("Please enter a valid value for the seconds.")
                End If
            Else
                MessageBox.Show("Please enter a valid value for the minutes.")
            End If
        Else
            MessageBox.Show("Please enter a valid value for the hours.")
        End If
    End Sub

    Private Sub chkAlarm_CheckedChanged(sender As Object, e As EventArgs) Handles chkAlarm.CheckedChanged
        ' ●●●●●●●●●●●●●●●●●●●●●●●
        ' ● CHECK ALARM SETTING ●
        ' ●●●●●●●●●●●●●●●●●●●●●●●
        If chkAlarm.Checked = True Then
            txtAlarmHour.Enabled = True
            txtAlarmMinute.Enabled = True
            txtAlarmSecond.Enabled = True
            btnSetAlarm.Enabled = True
            lblAlarmIcon.Visible = True
        Else
            txtAlarmHour.Enabled = False
            txtAlarmMinute.Enabled = False
            txtAlarmSecond.Enabled = False
            btnSetAlarm.Enabled = False
            lblAlarmIcon.Visible = False
        End If
    End Sub

    Private Sub btnSetAlarm_Click(sender As Object, e As EventArgs) Handles btnSetAlarm.Click
        ' ●●●●●●●●●●●●●●●●●●●●●
        ' ● DECLARE VARIABLES ●
        ' ●●●●●●●●●●●●●●●●●●●●●
    End Sub

    Private Sub btnStopWatchLap_Click(sender As Object, e As EventArgs) Handles btnStopWatchLap.Click
        Dim strLap As String      ' Contains current lap
        Dim intLap As Integer = 0 ' Counter
        strLap = lblStopWatchLap.Text
        lstStopWatch.Items.Add("Lap #" & intLap + 1 & vbTab & strLap)
    End Sub

    Private Sub btnStopWatchStart_Click(sender As Object, e As EventArgs) Handles btnStopWatchStart.Click
        tmrSWTime.Enabled = True
        btnStopWatchStart.Enabled = False
        btnStopWatchStop.Enabled = True
    End Sub

    Private Sub tmrSWTime_Tick(sender As Object, e As EventArgs) Handles tmrSWTime.Tick
        Dim intSWHours, intSWMinutes, intSWSeconds As Integer
        Do While tmrSWTime.Enabled = True
            intSWSeconds += 1
            lblStopWatch.Text = intSWSeconds.ToString()
            Application.DoEvents() ' Update the label on the form.
        Loop
    End Sub

    Private Sub tmrUpdate_Tick(sender As Object, e As EventArgs) Handles tmrUpdate.Tick
        Application.DoEvents() ' Update the label on the form.
        tmrUpdate.Enabled = False
    End Sub
End Class
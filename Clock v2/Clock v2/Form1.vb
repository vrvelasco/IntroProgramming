Public Class Form1
    ' ●●●●●●●●●●●●●●●●●●●●●
    ' ● DECLARE VARIABLES ●
    ' ●●●●●●●●●●●●●●●●●●●●●
    Dim intHours, intMinutes, intSeconds As Integer
    Dim intCustomHours, intCustomMinutes, intCustomSeconds As Integer
    Dim intAlarmHour, intAlarmMinute As Integer
    Dim strAlarmHour, strAlarmMinute As String
    Dim intSWHours, intSWMinutes, intSWSeconds As Integer
    Dim strSWHours, strSWMinutes, strSWSeconds As String
    Dim intSWHoursLap, intSWMinutesLap, intSWSecondsLap As Integer
    Dim strSWHoursLap, strSWMinutesLap, strSWSecondsLap As String
    Dim strHours, strMinutes, strSeconds As String
    Dim strCustomHours, strCustomMinutes, strCustomSeconds As String

    Private Sub btnStopWatchLap_Click(sender As Object, e As EventArgs) Handles btnStopWatchLap.Click
        intSWHoursLap = 0
        intSWMinutesLap = 0
        intSWSecondsLap = 0
        lstStopWatch.Items.Add("LAP #" & lstStopWatch.Items.Count + 1 & ":" & vbTab & "[LAP TIME]  " & lblSWValidation.Text & vbTab & "[TOTAL TIME]  " & lblStopWatch.Text)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrUpdate.Enabled = True
        ' ●●●●●●●●●●●●●●●●●●●●
        ' ● GET CURRENT TIME ●
        ' ●●●●●●●●●●●●●●●●●●●●
        intHours = Now.Hour
        intMinutes = Now.Minute
        intSeconds = Now.Second
        ' ●●●●●●●●●●●●●●●●●●●●●●●
        ' ● TWO DIGITS FOR TIME ●
        ' ●●●●●●●●●●●●●●●●●●●●●●●
        If intHours < 10 Then
            strHours = "0" & intHours.ToString()
        Else
            strHours = intHours.ToString()
        End If
        If intMinutes < 10 Then
            strMinutes = "0" & intMinutes.ToString()
        Else
            strMinutes = intMinutes.ToString()
        End If
        If intSeconds < 10 Then
            strSeconds = "0" & intSeconds.ToString()
        Else
            strSeconds = intSeconds.ToString()
        End If
        ' ●●●●●●●●●●●●●●●●
        ' ● DISPLAY TIME ●
        ' ●●●●●●●●●●●●●●●●
        lblClockFace.Text = strHours & "    " & strMinutes & "    " & strSeconds
    End Sub

    Private Sub tmrSWLap_Tick(sender As Object, e As EventArgs) Handles tmrSWLap.Tick
        ' ●●●●●●●●●●●●●●●●●
        ' ● START SECONDS ●
        ' ●●●●●●●●●●●●●●●●●
        If intSWSecondsLap = 59 Then
            intSWSecondsLap = 0
            intSWMinutesLap += 1
        Else
            intSWSecondsLap += 1
        End If
        If intSWHoursLap >= 24 Then ' Reset for
            intSWSecondsLap = 0     ' 24 hour clock
        End If
        ' Two digit display
        If intSWSecondsLap < 10 Then
            strSWSecondsLap = "0" & intSWSecondsLap.ToString()
        Else
            strSWSecondsLap = intSWSecondsLap.ToString()
        End If
        ' ●●●●●●●●●●●●●●●●●
        ' ● START MINUTES ●
        ' ●●●●●●●●●●●●●●●●●
        If intSWMinutesLap > 59 Then
            intSWHoursLap += 1
            intSWMinutesLap = 0
        End If
        ' Two digit display
        If intSWMinutesLap < 10 Then
            strSWMinutesLap = "0" & intSWMinutesLap.ToString()
        Else
            strSWMinutesLap = intSWMinutesLap.ToString()
        End If
        ' ●●●●●●●●●●●●●●●
        ' ● start hours ●
        ' ●●●●●●●●●●●●●●●
        If intSWHoursLap > 23 Then         ' Reset for 
            intSWHoursLap = 0               ' 24 hour clock
        End If
        ' Two digit display
        If intSWHoursLap < 10 Then
            strSWHoursLap = "0" & intSWHoursLap.ToString()
        Else
            strSWHoursLap = intSWHoursLap.ToString()
        End If
        lblSWValidation.Text = strSWHoursLap & "h : " & strSWMinutesLap & "m : " & strSWSecondsLap & "s"

    End Sub

    Private Sub tmrUpdate_Tick(sender As Object, e As EventArgs) Handles tmrUpdate.Tick
        ' ●●●●●●●●●●●●●●●●●●●●
        ' ● GET CURRENT TIME ●
        ' ●●●●●●●●●●●●●●●●●●●●
        intHours = Now.Hour
        intMinutes = Now.Minute
        intSeconds = Now.Second
        ' Custom time
        If chkCustomTime.Checked = True Then
            ' intHours = intCustomHours
            'intMinutes = intCustomMinutes
            'intSeconds = intCustomSeconds
        End If
        ' ●●●●●●●●●●●●●●●●●●●●●●●
        ' ● TWO DIGITS FOR TIME ●
        ' ●●●●●●●●●●●●●●●●●●●●●●●
        If intHours < 10 Then
            strHours = "0" & intHours.ToString()
        Else
            strHours = intHours.ToString()
        End If
        If intMinutes < 10 Then
            strMinutes = "0" & intMinutes.ToString()
        Else
            strMinutes = intMinutes.ToString()
        End If
        If intSeconds < 10 Then
            strSeconds = "0" & intSeconds.ToString()
        Else
            strSeconds = intSeconds.ToString()
        End If
        ' ●●●●●●●●●●●●●●●●●●●●●●●●
        ' ● START CUSTOMIZATIONS ●
        ' ●●●●●●●●●●●●●●●●●●●●●●●●
        ' Change font color
        lblClockFace.ForeColor = btnColor.BackColor
        lblLeftColon.ForeColor = btnColor.BackColor
        lblRightColon.ForeColor = btnColor.BackColor
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
        Else
            If intHours >= 12 Then
                lblDayNight.Text = "PM"
            Else
                lblDayNight.Text = "AM"
            End If
            lblDayNight.Visible = True
            If intHours >= 22 Then
                strHours = CStr(intHours - 12)
            ElseIf intHours >= 13 And intHours < 22 And Not intHours = 0 Then
                strHours = "0" & CStr(intHours - 12)
            ElseIf intHours = 0 Then
                strHours = "12"
            End If
        End If
        ' ●●●●●●●●●●●●●●●●
        ' ● DISPLAY TIME ●
        ' ●●●●●●●●●●●●●●●●
        lblClockFace.Text = strHours & "    " & strMinutes & "    " & strSeconds
        lblAlarmValidation.Text = "[Set for " & strHours & ":" & strMinutes & "]"
        ' ●●●●●●●●●●●●●●
        ' ● ALARM TIME ●
        ' ●●●●●●●●●●●●●●
        If chkAlarm.Checked = True And lblAlarmSummary.Text = lblAlarmValidation.Text And strSeconds = "00" Then
            MessageBox.Show("Time to wake up!")
        End If
        Application.DoEvents()  ' Update form
    End Sub

    Private Sub btnStopWatchStart_Click(sender As Object, e As EventArgs) Handles btnStopWatchStartStop.Click
        If btnStopWatchStartStop.Text = "Start" Then
            btnStopWatchStartStop.Text = "Stop"
            tmrStopWatch.Enabled = True
            tmrSWLap.Enabled = True
        Else
            tmrStopWatch.Enabled = False
            tmrSWLap.Enabled = False
            btnStopWatchStartStop.Text = "Start"
        End If
    End Sub

    Private Sub btnStopWatchReset_Click(sender As Object, e As EventArgs) Handles btnStopWatchReset.Click
        ' Reset main StopWatch
        intSWHours = 0
        intSWMinutes = 0
        intSWSeconds = 0
        lblStopWatch.Text = "00h : 00m : 00s"
        ' Reset StopWatch Laps
        intSWHoursLap = 0
        intSWMinutesLap = 0
        intSWSecondsLap = 0
        lblSWValidation.Text = "00h : 00m : 00s"
        ' Reset ListBox
        lstStopWatch.Items.Clear()
    End Sub

    Private Sub tmrStopWatch_Tick(sender As Object, e As EventArgs) Handles tmrStopWatch.Tick
        ' ●●●●●●●●●●●●●●●●●
        ' ● START SECONDS ●
        ' ●●●●●●●●●●●●●●●●●
        If intSWSeconds = 59 Then
            intSWSeconds = 0
            intSWMinutes += 1
        Else
            intSWSeconds += 1
        End If
        If intSWHours >= 24 Then ' Reset for
            intSWSeconds = 0     ' 24 hour clock
        End If
        ' Two digit display
        If intSWSeconds < 10 Then
            strSWSeconds = "0" & intSWSeconds.ToString()
        Else
            strSWSeconds = intSWSeconds.ToString()
        End If
        ' ●●●●●●●●●●●●●●●●●
        ' ● START MINUTES ●
        ' ●●●●●●●●●●●●●●●●●
        If intSWMinutes > 59 Then
            intSWHours += 1
            intSWMinutes = 0
        End If
        ' Two digit display
        If intSWMinutes < 10 Then
            strSWMinutes = "0" & intSWMinutes.ToString()
        Else
            strSWMinutes = intSWMinutes.ToString()
        End If
        ' ●●●●●●●●●●●●●●●
        ' ● start hours ●
        ' ●●●●●●●●●●●●●●●
        If intSWHours > 23 Then         ' Reset for 
            intSWHours = 0               ' 24 hour clock
        End If
        ' Two digit display
        If intSWHours < 10 Then
            strSWHours = "0" & intSWHours.ToString()
        Else
            strSWHours = intSWHours.ToString()
        End If
        lblStopWatch.Text = strSWHours & "h : " & strSWMinutes & "m : " & strSWSeconds & "s"
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
            '' Set variable
            'intHours = intCustomHours
            'intMinutes = intCustomMinutes
            'intSeconds = intCustomSeconds
        Else
            txtCustomHour.Enabled = False
            txtCustomMinute.Enabled = False
            txtCustomSecond.Enabled = False
            btnSetCustomTime.Enabled = False
            ' ●●●●●●●●●●●●●●●●●●●●●
            ' ● GET COMPUTER TIME ●
            ' ●●●●●●●●●●●●●●●●●●●●●
            intHours = Now.Hour
            intMinutes = Now.Minute
            intSeconds = Now.Second
            tmrCustomClock.Enabled = False
            tmrUpdate.Enabled = True
        End If
    End Sub

    Private Sub btnSetCustomTime_Click(sender As Object, e As EventArgs) Handles btnSetCustomTime.Click
        ' ●●●●●●●●●●●●●●●●●●●●●
        ' ● DECLARE VARIABLES ●
        ' ●●●●●●●●●●●●●●●●●●●●●
        If Integer.TryParse(txtCustomHour.Text, intCustomHours) Then
            If Integer.TryParse(txtCustomMinute.Text, intCustomMinutes) Then
                If Integer.TryParse(txtCustomSecond.Text, intCustomSeconds) Then
                    ' ●●●●●●●●●●●●●●●●●●●●●●●●●●
                    ' ● CHANGE VALUES IN CLOCK ●
                    ' ●●●●●●●●●●●●●●●●●●●●●●●●●●
                    If intCustomHours >= 0 And intCustomHours <= 23 Then
                        ' Custom Hours
                    Else
                        MessageBox.Show("Please enter a valid value for the hours.")
                        intCustomHours = 0
                    End If
                    If intCustomMinutes >= 0 And intCustomMinutes <= 59 Then
                        ' Custom Minutes
                    Else
                        MessageBox.Show("Please enter a valid value for the minutes.")
                        intCustomMinutes = 0
                    End If
                    If intCustomSeconds >= 0 And intCustomSeconds <= 59 Then
                        tmrCustomClock.Enabled = True
                    Else
                        MessageBox.Show("Please enter a valid value for the seconds.")
                        intCustomSeconds = 0
                    End If
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

    Private Sub tmrCustomClock_Tick(sender As Object, e As EventArgs) Handles tmrCustomClock.Tick
        tmrUpdate.Enabled = False
        ' ●●●●●●●●●●●●●●●●●
        ' ● START SECONDS ●
        ' ●●●●●●●●●●●●●●●●●
        If intCustomSeconds = 59 Then
            intCustomSeconds = 0
            intCustomMinutes += 1
        Else
            intCustomSeconds += 1
        End If
        If intCustomHours >= 24 Then ' Reset for
            intCustomSeconds = 0     ' 24 hour clock
        End If
        ' Two digit display
        If intCustomSeconds < 10 Then
            strCustomSeconds = "0" & intCustomSeconds.ToString()
        Else
            strCustomSeconds = intCustomSeconds.ToString()
        End If
        ' ●●●●●●●●●●●●●●●●●
        ' ● START MINUTES ●
        ' ●●●●●●●●●●●●●●●●●
        If intCustomMinutes > 59 Then
            intCustomHours += 1
            intCustomMinutes = 0
        End If
        If intCustomHours >= 24 Then     ' Reset for
            intCustomMinutes = 0         ' 24 hour clock
        End If
        ' Two digit display
        If intCustomMinutes < 10 Then
            strCustomMinutes = "0" & intCustomMinutes.ToString()
        Else
            strCustomMinutes = intCustomMinutes.ToString()
        End If
        ' ●●●●●●●●●●●●●●●
        ' ● start hours ●
        ' ●●●●●●●●●●●●●●●
        If intCustomHours > 23 Then         ' Reset for 
            intCustomHours = 0               ' 24 hour clock
        End If
        ' Two digit display
        If intCustomHours < 10 Then
            strCustomHours = "0" & intCustomHours.ToString()
        Else
            strCustomHours = intCustomHours.ToString()
        End If
        ' ●●●●●●●●●●●●●●●●●●●●●●●●
        ' ● START CUSTOMIZATIONS ●
        ' ●●●●●●●●●●●●●●●●●●●●●●●●
        ' change font color
        lblClockFace.ForeColor = btnColor.BackColor
        lblLeftColon.ForeColor = btnColor.BackColor
        lblRightColon.ForeColor = btnColor.BackColor
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
        Else
            If intCustomHours >= 12 Then
                lblDayNight.Text = "pm"
            Else
                lblDayNight.Text = "am"
            End If
            lblDayNight.Visible = True
            If intCustomHours >= 22 Then
                strCustomHours = CStr(intCustomHours - 12)
            ElseIf intCustomHours >= 13 And intCustomHours < 22 And Not intCustomHours = 0 Then
                strCustomHours = "0" & CStr(intCustomHours - 12)
            ElseIf intcustomHours = 0 Then
                strCustomHours = "12"
            End If
        End If
        ' ●●●●●●●●●●●●●●●●
        ' ● DISPLAY TIME ●
        ' ●●●●●●●●●●●●●●●●
        lblClockFace.Text = strCustomHours & "    " & strCustomMinutes & "    " & strCustomSeconds
        lblCustomAlarmValidation.Text = "[Set for " & intCustomHours.ToString() & ":" & intCustomMinutes.ToString() & "]"
        ' ●●●●●●●●●●●●●●
        ' ● ALARM TIME ●
        ' ●●●●●●●●●●●●●●
        If chkAlarm.Checked = True And lblAlarmSummary.Text = lblCustomAlarmValidation.Text And strCustomSeconds = "00" Then
            MessageBox.Show("Time to wake up!")
        End If
        Application.DoEvents() ' Update form
    End Sub

    Private Sub chkAlarm_CheckedChanged(sender As Object, e As EventArgs) Handles chkAlarm.CheckedChanged
        ' ●●●●●●●●●●●●●●●●●●●●●●●
        ' ● CHECK ALARM SETTING ●
        ' ●●●●●●●●●●●●●●●●●●●●●●●
        If chkAlarm.Checked = True Then
            txtAlarmHour.Enabled = True
            txtAlarmMinute.Enabled = True
            btnSetAlarm.Enabled = True
            lblAlarmIcon.Visible = True
        Else
            txtAlarmHour.Enabled = False
            txtAlarmMinute.Enabled = False
            btnSetAlarm.Enabled = False
            lblAlarmIcon.Visible = False
            lblAlarmSummary.Visible = False
        End If
    End Sub

    Private Sub btnSetAlarm_Click(sender As Object, e As EventArgs) Handles btnSetAlarm.Click
        If Integer.TryParse(txtAlarmHour.Text, intAlarmHour) And intAlarmHour >= 0 And intAlarmHour <= 23 Then
            If Integer.TryParse(txtAlarmMinute.Text, intAlarmMinute) And intAlarmMinute >= 0 And intAlarmMinute <= 59 Then
                If intAlarmHour < 10 Then
                    strAlarmHour = "0" & intAlarmHour.ToString()
                Else
                    strAlarmHour = intAlarmHour.ToString()
                End If
                If intAlarmMinute < 10 Then
                    strAlarmMinute = "0" & intAlarmMinute.ToString()
                Else
                    strAlarmMinute = intAlarmMinute.ToString()
                End If
                lblAlarmSummary.Text = "[Set for " & strAlarmHour & ":" & strAlarmMinute & "]"
                lblAlarmSummary.Visible = True
            Else
                MessageBox.Show("Please enter a valid value for the mintues.")
            End If
        Else
            MessageBox.Show("Please enter a valid value for the hours.")
        End If
    End Sub
End Class

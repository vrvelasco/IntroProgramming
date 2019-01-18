<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblSeconds = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblMinutes = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.picClockBackground = New System.Windows.Forms.PictureBox()
        Me.lblLeftColon = New System.Windows.Forms.Label()
        Me.lblRightColon = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnSetAlarm = New System.Windows.Forms.Button()
        Me.btnSetCustomTime = New System.Windows.Forms.Button()
        Me.chkAlarm = New System.Windows.Forms.CheckBox()
        Me.chkCustomTime = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAlarmMinute = New System.Windows.Forms.TextBox()
        Me.txtAlarmSecond = New System.Windows.Forms.TextBox()
        Me.txtCustomMinute = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCustomSecond = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAlarmHour = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCustomHour = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkMilitary = New System.Windows.Forms.CheckBox()
        Me.chkBlink = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnWhiteFont = New System.Windows.Forms.Button()
        Me.btnBlueFont = New System.Windows.Forms.Button()
        Me.btnPurpleFont = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGreenFont = New System.Windows.Forms.Button()
        Me.btnRedFont = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnStopWatchReset = New System.Windows.Forms.Button()
        Me.lblStopWatch = New System.Windows.Forms.Label()
        Me.lstStopWatch = New System.Windows.Forms.ListBox()
        Me.btnStopWatchLap = New System.Windows.Forms.Button()
        Me.btnStopWatchStop = New System.Windows.Forms.Button()
        Me.btnStopWatchStart = New System.Windows.Forms.Button()
        Me.btnColor = New System.Windows.Forms.Button()
        Me.lblAlarmIcon = New System.Windows.Forms.Label()
        Me.lblDayNight = New System.Windows.Forms.Label()
        Me.lblStopWatchLap = New System.Windows.Forms.Label()
        Me.tmrSWTime = New System.Windows.Forms.Timer(Me.components)
        Me.tmrUpdate = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picClockBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSeconds
        '
        Me.lblSeconds.BackColor = System.Drawing.Color.Black
        Me.lblSeconds.Font = New System.Drawing.Font("Impact", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeconds.ForeColor = System.Drawing.Color.Green
        Me.lblSeconds.Location = New System.Drawing.Point(312, 9)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.Size = New System.Drawing.Size(105, 80)
        Me.lblSeconds.TabIndex = 0
        Me.lblSeconds.Text = "00"
        Me.lblSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(394, 95)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(78, 23)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lblMinutes
        '
        Me.lblMinutes.BackColor = System.Drawing.Color.Black
        Me.lblMinutes.Font = New System.Drawing.Font("Impact", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinutes.ForeColor = System.Drawing.Color.Green
        Me.lblMinutes.Location = New System.Drawing.Point(162, 9)
        Me.lblMinutes.Name = "lblMinutes"
        Me.lblMinutes.Size = New System.Drawing.Size(105, 80)
        Me.lblMinutes.TabIndex = 2
        Me.lblMinutes.Text = "00"
        Me.lblMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHours
        '
        Me.lblHours.BackColor = System.Drawing.Color.Black
        Me.lblHours.Font = New System.Drawing.Font("Impact", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHours.ForeColor = System.Drawing.Color.Green
        Me.lblHours.Location = New System.Drawing.Point(12, 9)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(105, 80)
        Me.lblHours.TabIndex = 3
        Me.lblHours.Text = "00"
        Me.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picClockBackground
        '
        Me.picClockBackground.BackColor = System.Drawing.Color.Black
        Me.picClockBackground.Location = New System.Drawing.Point(12, 9)
        Me.picClockBackground.Name = "picClockBackground"
        Me.picClockBackground.Size = New System.Drawing.Size(470, 80)
        Me.picClockBackground.TabIndex = 4
        Me.picClockBackground.TabStop = False
        '
        'lblLeftColon
        '
        Me.lblLeftColon.BackColor = System.Drawing.Color.Black
        Me.lblLeftColon.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeftColon.ForeColor = System.Drawing.Color.Green
        Me.lblLeftColon.Location = New System.Drawing.Point(123, 9)
        Me.lblLeftColon.Name = "lblLeftColon"
        Me.lblLeftColon.Size = New System.Drawing.Size(33, 65)
        Me.lblLeftColon.TabIndex = 5
        Me.lblLeftColon.Text = ":"
        Me.lblLeftColon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRightColon
        '
        Me.lblRightColon.BackColor = System.Drawing.Color.Black
        Me.lblRightColon.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRightColon.ForeColor = System.Drawing.Color.Green
        Me.lblRightColon.Location = New System.Drawing.Point(273, 9)
        Me.lblRightColon.Name = "lblRightColon"
        Me.lblRightColon.Size = New System.Drawing.Size(33, 65)
        Me.lblRightColon.TabIndex = 6
        Me.lblRightColon.Text = ":"
        Me.lblRightColon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 138)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(474, 227)
        Me.TabControl1.TabIndex = 8
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(466, 198)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Customizations"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnSetAlarm)
        Me.GroupBox3.Controls.Add(Me.btnSetCustomTime)
        Me.GroupBox3.Controls.Add(Me.chkAlarm)
        Me.GroupBox3.Controls.Add(Me.chkCustomTime)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtAlarmMinute)
        Me.GroupBox3.Controls.Add(Me.txtAlarmSecond)
        Me.GroupBox3.Controls.Add(Me.txtCustomMinute)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtCustomSecond)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtAlarmHour)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtCustomHour)
        Me.GroupBox3.Controls.Add(Me.PictureBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(216, 11)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(235, 176)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Time"
        '
        'btnSetAlarm
        '
        Me.btnSetAlarm.Enabled = False
        Me.btnSetAlarm.Location = New System.Drawing.Point(150, 128)
        Me.btnSetAlarm.Name = "btnSetAlarm"
        Me.btnSetAlarm.Size = New System.Drawing.Size(75, 22)
        Me.btnSetAlarm.TabIndex = 14
        Me.btnSetAlarm.Text = "Set Alarm"
        Me.btnSetAlarm.UseVisualStyleBackColor = True
        '
        'btnSetCustomTime
        '
        Me.btnSetCustomTime.Enabled = False
        Me.btnSetCustomTime.Location = New System.Drawing.Point(150, 44)
        Me.btnSetCustomTime.Name = "btnSetCustomTime"
        Me.btnSetCustomTime.Size = New System.Drawing.Size(75, 22)
        Me.btnSetCustomTime.TabIndex = 13
        Me.btnSetCustomTime.Text = "Set Time"
        Me.btnSetCustomTime.UseVisualStyleBackColor = True
        '
        'chkAlarm
        '
        Me.chkAlarm.AutoSize = True
        Me.chkAlarm.Location = New System.Drawing.Point(13, 102)
        Me.chkAlarm.Name = "chkAlarm"
        Me.chkAlarm.Size = New System.Drawing.Size(85, 20)
        Me.chkAlarm.TabIndex = 12
        Me.chkAlarm.Text = "Set Alarm"
        Me.chkAlarm.UseVisualStyleBackColor = True
        '
        'chkCustomTime
        '
        Me.chkCustomTime.AutoSize = True
        Me.chkCustomTime.Location = New System.Drawing.Point(13, 18)
        Me.chkCustomTime.Name = "chkCustomTime"
        Me.chkCustomTime.Size = New System.Drawing.Size(106, 20)
        Me.chkCustomTime.TabIndex = 12
        Me.chkCustomTime.Text = "Custom Time"
        Me.chkCustomTime.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(58, 153)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 16)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "MM"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(58, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "MM"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(91, 128)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 20)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(91, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = ":"
        '
        'txtAlarmMinute
        '
        Me.txtAlarmMinute.Enabled = False
        Me.txtAlarmMinute.Location = New System.Drawing.Point(60, 128)
        Me.txtAlarmMinute.Name = "txtAlarmMinute"
        Me.txtAlarmMinute.Size = New System.Drawing.Size(25, 22)
        Me.txtAlarmMinute.TabIndex = 7
        Me.txtAlarmMinute.Text = "00"
        Me.txtAlarmMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAlarmSecond
        '
        Me.txtAlarmSecond.Enabled = False
        Me.txtAlarmSecond.Location = New System.Drawing.Point(110, 128)
        Me.txtAlarmSecond.Name = "txtAlarmSecond"
        Me.txtAlarmSecond.Size = New System.Drawing.Size(25, 22)
        Me.txtAlarmSecond.TabIndex = 8
        Me.txtAlarmSecond.Text = "00"
        Me.txtAlarmSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCustomMinute
        '
        Me.txtCustomMinute.Enabled = False
        Me.txtCustomMinute.Location = New System.Drawing.Point(60, 44)
        Me.txtCustomMinute.Name = "txtCustomMinute"
        Me.txtCustomMinute.Size = New System.Drawing.Size(25, 22)
        Me.txtCustomMinute.TabIndex = 7
        Me.txtCustomMinute.Text = "00"
        Me.txtCustomMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(41, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 20)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = ":"
        '
        'txtCustomSecond
        '
        Me.txtCustomSecond.Enabled = False
        Me.txtCustomSecond.Location = New System.Drawing.Point(110, 44)
        Me.txtCustomSecond.Name = "txtCustomSecond"
        Me.txtCustomSecond.Size = New System.Drawing.Size(25, 22)
        Me.txtCustomSecond.TabIndex = 8
        Me.txtCustomSecond.Text = "00"
        Me.txtCustomSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(109, 153)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "SS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(41, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "HH"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(109, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "SS"
        '
        'txtAlarmHour
        '
        Me.txtAlarmHour.Enabled = False
        Me.txtAlarmHour.Location = New System.Drawing.Point(10, 128)
        Me.txtAlarmHour.Name = "txtAlarmHour"
        Me.txtAlarmHour.Size = New System.Drawing.Size(25, 22)
        Me.txtAlarmHour.TabIndex = 2
        Me.txtAlarmHour.Text = "00"
        Me.txtAlarmHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "HH"
        '
        'txtCustomHour
        '
        Me.txtCustomHour.Enabled = False
        Me.txtCustomHour.Location = New System.Drawing.Point(10, 44)
        Me.txtCustomHour.Name = "txtCustomHour"
        Me.txtCustomHour.Size = New System.Drawing.Size(25, 22)
        Me.txtCustomHour.TabIndex = 2
        Me.txtCustomHour.Text = "00"
        Me.txtCustomHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.PictureBox1.Location = New System.Drawing.Point(8, 95)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(215, 1)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkMilitary)
        Me.GroupBox2.Controls.Add(Me.chkBlink)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 113)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(194, 74)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Features"
        '
        'chkMilitary
        '
        Me.chkMilitary.AutoSize = True
        Me.chkMilitary.Location = New System.Drawing.Point(6, 47)
        Me.chkMilitary.Name = "chkMilitary"
        Me.chkMilitary.Size = New System.Drawing.Size(105, 20)
        Me.chkMilitary.TabIndex = 4
        Me.chkMilitary.Text = "24 hour clock"
        Me.chkMilitary.UseVisualStyleBackColor = True
        '
        'chkBlink
        '
        Me.chkBlink.AutoSize = True
        Me.chkBlink.Location = New System.Drawing.Point(6, 21)
        Me.chkBlink.Name = "chkBlink"
        Me.chkBlink.Size = New System.Drawing.Size(130, 20)
        Me.chkBlink.TabIndex = 3
        Me.chkBlink.Text = "Flash Seperators"
        Me.chkBlink.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnWhiteFont)
        Me.GroupBox1.Controls.Add(Me.btnBlueFont)
        Me.GroupBox1.Controls.Add(Me.btnPurpleFont)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnGreenFont)
        Me.GroupBox1.Controls.Add(Me.btnRedFont)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(194, 93)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Color"
        '
        'btnWhiteFont
        '
        Me.btnWhiteFont.BackColor = System.Drawing.Color.White
        Me.btnWhiteFont.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWhiteFont.ForeColor = System.Drawing.Color.White
        Me.btnWhiteFont.Location = New System.Drawing.Point(153, 53)
        Me.btnWhiteFont.Name = "btnWhiteFont"
        Me.btnWhiteFont.Size = New System.Drawing.Size(30, 30)
        Me.btnWhiteFont.TabIndex = 5
        Me.btnWhiteFont.UseVisualStyleBackColor = False
        '
        'btnBlueFont
        '
        Me.btnBlueFont.BackColor = System.Drawing.Color.Blue
        Me.btnBlueFont.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBlueFont.ForeColor = System.Drawing.Color.White
        Me.btnBlueFont.Location = New System.Drawing.Point(117, 53)
        Me.btnBlueFont.Name = "btnBlueFont"
        Me.btnBlueFont.Size = New System.Drawing.Size(30, 30)
        Me.btnBlueFont.TabIndex = 4
        Me.btnBlueFont.UseVisualStyleBackColor = False
        '
        'btnPurpleFont
        '
        Me.btnPurpleFont.BackColor = System.Drawing.Color.Purple
        Me.btnPurpleFont.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPurpleFont.ForeColor = System.Drawing.Color.White
        Me.btnPurpleFont.Location = New System.Drawing.Point(81, 53)
        Me.btnPurpleFont.Name = "btnPurpleFont"
        Me.btnPurpleFont.Size = New System.Drawing.Size(30, 30)
        Me.btnPurpleFont.TabIndex = 3
        Me.btnPurpleFont.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select the font color below:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGreenFont
        '
        Me.btnGreenFont.BackColor = System.Drawing.Color.Green
        Me.btnGreenFont.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGreenFont.ForeColor = System.Drawing.Color.White
        Me.btnGreenFont.Location = New System.Drawing.Point(9, 53)
        Me.btnGreenFont.Name = "btnGreenFont"
        Me.btnGreenFont.Size = New System.Drawing.Size(30, 30)
        Me.btnGreenFont.TabIndex = 1
        Me.btnGreenFont.UseVisualStyleBackColor = False
        '
        'btnRedFont
        '
        Me.btnRedFont.BackColor = System.Drawing.Color.Red
        Me.btnRedFont.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRedFont.ForeColor = System.Drawing.Color.White
        Me.btnRedFont.Location = New System.Drawing.Point(45, 53)
        Me.btnRedFont.Name = "btnRedFont"
        Me.btnRedFont.Size = New System.Drawing.Size(30, 30)
        Me.btnRedFont.TabIndex = 0
        Me.btnRedFont.UseVisualStyleBackColor = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnStopWatchReset)
        Me.TabPage1.Controls.Add(Me.lblStopWatch)
        Me.TabPage1.Controls.Add(Me.lstStopWatch)
        Me.TabPage1.Controls.Add(Me.btnStopWatchLap)
        Me.TabPage1.Controls.Add(Me.btnStopWatchStop)
        Me.TabPage1.Controls.Add(Me.btnStopWatchStart)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(466, 198)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Stop Watch"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnStopWatchReset
        '
        Me.btnStopWatchReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStopWatchReset.Location = New System.Drawing.Point(408, 13)
        Me.btnStopWatchReset.Name = "btnStopWatchReset"
        Me.btnStopWatchReset.Size = New System.Drawing.Size(50, 30)
        Me.btnStopWatchReset.TabIndex = 5
        Me.btnStopWatchReset.Text = "Reset"
        Me.btnStopWatchReset.UseVisualStyleBackColor = True
        '
        'lblStopWatch
        '
        Me.lblStopWatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStopWatch.Location = New System.Drawing.Point(10, 13)
        Me.lblStopWatch.Name = "lblStopWatch"
        Me.lblStopWatch.Size = New System.Drawing.Size(224, 30)
        Me.lblStopWatch.TabIndex = 4
        Me.lblStopWatch.Text = "00h : 00m : 00s"
        Me.lblStopWatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstStopWatch
        '
        Me.lstStopWatch.FormattingEnabled = True
        Me.lstStopWatch.ItemHeight = 16
        Me.lstStopWatch.Location = New System.Drawing.Point(10, 55)
        Me.lstStopWatch.Name = "lstStopWatch"
        Me.lstStopWatch.Size = New System.Drawing.Size(446, 132)
        Me.lstStopWatch.TabIndex = 3
        '
        'btnStopWatchLap
        '
        Me.btnStopWatchLap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStopWatchLap.Location = New System.Drawing.Point(352, 13)
        Me.btnStopWatchLap.Name = "btnStopWatchLap"
        Me.btnStopWatchLap.Size = New System.Drawing.Size(50, 30)
        Me.btnStopWatchLap.TabIndex = 2
        Me.btnStopWatchLap.Text = "Lap"
        Me.btnStopWatchLap.UseVisualStyleBackColor = True
        '
        'btnStopWatchStop
        '
        Me.btnStopWatchStop.Enabled = False
        Me.btnStopWatchStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStopWatchStop.Location = New System.Drawing.Point(296, 13)
        Me.btnStopWatchStop.Name = "btnStopWatchStop"
        Me.btnStopWatchStop.Size = New System.Drawing.Size(50, 30)
        Me.btnStopWatchStop.TabIndex = 1
        Me.btnStopWatchStop.Text = "Stop"
        Me.btnStopWatchStop.UseVisualStyleBackColor = True
        '
        'btnStopWatchStart
        '
        Me.btnStopWatchStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStopWatchStart.Location = New System.Drawing.Point(240, 13)
        Me.btnStopWatchStart.Name = "btnStopWatchStart"
        Me.btnStopWatchStart.Size = New System.Drawing.Size(50, 30)
        Me.btnStopWatchStart.TabIndex = 0
        Me.btnStopWatchStart.Text = "Start"
        Me.btnStopWatchStart.UseVisualStyleBackColor = True
        '
        'btnColor
        '
        Me.btnColor.BackColor = System.Drawing.Color.Green
        Me.btnColor.ForeColor = System.Drawing.Color.White
        Me.btnColor.Location = New System.Drawing.Point(751, 530)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(80, 23)
        Me.btnColor.TabIndex = 9
        Me.btnColor.Text = "(HIDDEN)"
        Me.btnColor.UseVisualStyleBackColor = False
        '
        'lblAlarmIcon
        '
        Me.lblAlarmIcon.AutoSize = True
        Me.lblAlarmIcon.BackColor = System.Drawing.Color.Black
        Me.lblAlarmIcon.Font = New System.Drawing.Font("Wingdings", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lblAlarmIcon.ForeColor = System.Drawing.Color.Green
        Me.lblAlarmIcon.Location = New System.Drawing.Point(423, 46)
        Me.lblAlarmIcon.Name = "lblAlarmIcon"
        Me.lblAlarmIcon.Size = New System.Drawing.Size(49, 38)
        Me.lblAlarmIcon.TabIndex = 10
        Me.lblAlarmIcon.Text = "¸"
        Me.lblAlarmIcon.Visible = False
        '
        'lblDayNight
        '
        Me.lblDayNight.BackColor = System.Drawing.Color.Black
        Me.lblDayNight.Font = New System.Drawing.Font("Impact", 15.0!)
        Me.lblDayNight.ForeColor = System.Drawing.Color.Green
        Me.lblDayNight.Location = New System.Drawing.Point(423, 9)
        Me.lblDayNight.Name = "lblDayNight"
        Me.lblDayNight.Size = New System.Drawing.Size(44, 35)
        Me.lblDayNight.TabIndex = 11
        Me.lblDayNight.Text = "AM"
        Me.lblDayNight.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblStopWatchLap
        '
        Me.lblStopWatchLap.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStopWatchLap.Location = New System.Drawing.Point(751, 556)
        Me.lblStopWatchLap.Name = "lblStopWatchLap"
        Me.lblStopWatchLap.Size = New System.Drawing.Size(80, 30)
        Me.lblStopWatchLap.TabIndex = 12
        Me.lblStopWatchLap.Text = "00h : 00m : 00s"
        Me.lblStopWatchLap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrSWTime
        '
        Me.tmrSWTime.Interval = 1000
        '
        'tmrUpdate
        '
        Me.tmrUpdate.Enabled = True
        Me.tmrUpdate.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 434)
        Me.Controls.Add(Me.lblStopWatchLap)
        Me.Controls.Add(Me.lblDayNight)
        Me.Controls.Add(Me.lblAlarmIcon)
        Me.Controls.Add(Me.btnColor)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lblRightColon)
        Me.Controls.Add(Me.lblLeftColon)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.lblMinutes)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblSeconds)
        Me.Controls.Add(Me.picClockBackground)
        Me.Name = "Form1"
        Me.Text = "Clock"
        CType(Me.picClockBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSeconds As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents lblMinutes As Label
    Friend WithEvents lblHours As Label
    Friend WithEvents picClockBackground As PictureBox
    Friend WithEvents lblLeftColon As Label
    Friend WithEvents lblRightColon As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents chkBlink As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnWhiteFont As Button
    Friend WithEvents btnBlueFont As Button
    Friend WithEvents btnPurpleFont As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGreenFont As Button
    Friend WithEvents btnRedFont As Button
    Friend WithEvents btnColor As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnSetAlarm As Button
    Friend WithEvents btnSetCustomTime As Button
    Friend WithEvents chkAlarm As CheckBox
    Friend WithEvents chkCustomTime As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAlarmMinute As TextBox
    Friend WithEvents txtAlarmSecond As TextBox
    Friend WithEvents txtCustomMinute As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCustomSecond As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAlarmHour As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCustomHour As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkMilitary As CheckBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents lblAlarmIcon As Label
    Friend WithEvents lblDayNight As Label
    Friend WithEvents lblStopWatch As Label
    Friend WithEvents lstStopWatch As ListBox
    Friend WithEvents btnStopWatchLap As Button
    Friend WithEvents btnStopWatchStop As Button
    Friend WithEvents btnStopWatchStart As Button
    Friend WithEvents btnStopWatchReset As Button
    Friend WithEvents lblStopWatchLap As Label
    Friend WithEvents tmrSWTime As Timer
    Friend WithEvents tmrUpdate As Timer
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTemp1 = New System.Windows.Forms.TextBox()
        Me.txtTemp2 = New System.Windows.Forms.TextBox()
        Me.txtTemp3 = New System.Windows.Forms.TextBox()
        Me.txtTemp4 = New System.Windows.Forms.TextBox()
        Me.txtTemp5 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblCityState = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblAvgTemp = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(169, 12)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(100, 20)
        Me.txtCity.TabIndex = 0
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(316, 12)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(100, 20)
        Me.txtState.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(136, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "City:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(275, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "State:"
        '
        'txtTemp1
        '
        Me.txtTemp1.Location = New System.Drawing.Point(12, 66)
        Me.txtTemp1.Name = "txtTemp1"
        Me.txtTemp1.Size = New System.Drawing.Size(100, 20)
        Me.txtTemp1.TabIndex = 4
        '
        'txtTemp2
        '
        Me.txtTemp2.Location = New System.Drawing.Point(118, 66)
        Me.txtTemp2.Name = "txtTemp2"
        Me.txtTemp2.Size = New System.Drawing.Size(100, 20)
        Me.txtTemp2.TabIndex = 5
        '
        'txtTemp3
        '
        Me.txtTemp3.Location = New System.Drawing.Point(224, 66)
        Me.txtTemp3.Name = "txtTemp3"
        Me.txtTemp3.Size = New System.Drawing.Size(100, 20)
        Me.txtTemp3.TabIndex = 6
        '
        'txtTemp4
        '
        Me.txtTemp4.Location = New System.Drawing.Point(330, 66)
        Me.txtTemp4.Name = "txtTemp4"
        Me.txtTemp4.Size = New System.Drawing.Size(100, 20)
        Me.txtTemp4.TabIndex = 7
        '
        'txtTemp5
        '
        Me.txtTemp5.Location = New System.Drawing.Point(436, 66)
        Me.txtTemp5.Name = "txtTemp5"
        Me.txtTemp5.Size = New System.Drawing.Size(100, 20)
        Me.txtTemp5.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Temp 1"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(118, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Temp 2"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(224, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Temp 3"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(330, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Temp 4"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(436, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Temp 5"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCalc
        '
        Me.txtCalc.Location = New System.Drawing.Point(143, 147)
        Me.txtCalc.Name = "txtCalc"
        Me.txtCalc.Size = New System.Drawing.Size(75, 23)
        Me.txtCalc.TabIndex = 14
        Me.txtCalc.Text = "Calculate"
        Me.txtCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(249, 147)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(355, 147)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblCityState
        '
        Me.lblCityState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCityState.Location = New System.Drawing.Point(86, 108)
        Me.lblCityState.Name = "lblCityState"
        Me.lblCityState.Size = New System.Drawing.Size(183, 23)
        Me.lblCityState.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(284, 109)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 17)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Average Temperature:"
        '
        'lblAvgTemp
        '
        Me.lblAvgTemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAvgTemp.Location = New System.Drawing.Point(404, 108)
        Me.lblAvgTemp.Name = "lblAvgTemp"
        Me.lblAvgTemp.Size = New System.Drawing.Size(100, 23)
        Me.lblAvgTemp.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, 109)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Location:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 184)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblAvgTemp)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblCityState)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtCalc)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTemp5)
        Me.Controls.Add(Me.txtTemp4)
        Me.Controls.Add(Me.txtTemp3)
        Me.Controls.Add(Me.txtTemp2)
        Me.Controls.Add(Me.txtTemp1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtCity)
        Me.Name = "Form1"
        Me.Text = "Temp 1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTemp1 As TextBox
    Friend WithEvents txtTemp2 As TextBox
    Friend WithEvents txtTemp3 As TextBox
    Friend WithEvents txtTemp4 As TextBox
    Friend WithEvents txtTemp5 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblCityState As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblAvgTemp As Label
    Friend WithEvents Label8 As Label
End Class

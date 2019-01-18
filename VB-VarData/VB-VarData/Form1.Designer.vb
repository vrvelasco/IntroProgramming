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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCityName = New System.Windows.Forms.TextBox()
        Me.txtStateName = New System.Windows.Forms.TextBox()
        Me.txtDays = New System.Windows.Forms.TextBox()
        Me.txtTemp = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnShowData = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.lblTemp = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(4, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "City Name:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(4, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "State Name:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(4, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Days in the month:"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 41)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Average Temperature (in Fahrenheit):"
        '
        'txtCityName
        '
        Me.txtCityName.Location = New System.Drawing.Point(128, 6)
        Me.txtCityName.Name = "txtCityName"
        Me.txtCityName.Size = New System.Drawing.Size(116, 20)
        Me.txtCityName.TabIndex = 4
        '
        'txtStateName
        '
        Me.txtStateName.Location = New System.Drawing.Point(128, 29)
        Me.txtStateName.Name = "txtStateName"
        Me.txtStateName.Size = New System.Drawing.Size(116, 20)
        Me.txtStateName.TabIndex = 5
        '
        'txtDays
        '
        Me.txtDays.Location = New System.Drawing.Point(128, 52)
        Me.txtDays.Name = "txtDays"
        Me.txtDays.Size = New System.Drawing.Size(116, 20)
        Me.txtDays.TabIndex = 6
        '
        'txtTemp
        '
        Me.txtTemp.Location = New System.Drawing.Point(128, 75)
        Me.txtTemp.Name = "txtTemp"
        Me.txtTemp.Size = New System.Drawing.Size(116, 20)
        Me.txtTemp.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Gray
        Me.PictureBox1.Location = New System.Drawing.Point(250, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(298, 155)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'btnShowData
        '
        Me.btnShowData.Location = New System.Drawing.Point(7, 104)
        Me.btnShowData.Name = "btnShowData"
        Me.btnShowData.Size = New System.Drawing.Size(75, 23)
        Me.btnShowData.TabIndex = 9
        Me.btnShowData.Text = "Show Data"
        Me.btnShowData.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(88, 104)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(169, 104)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Gray
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(253, 1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Results"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Gray
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(256, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Full Name:"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Gray
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(256, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 23)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Days in month:"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Gray
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(256, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 23)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Average Temperature:"
        '
        'lblFullName
        '
        Me.lblFullName.BackColor = System.Drawing.Color.Gray
        Me.lblFullName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblFullName.Location = New System.Drawing.Point(362, 26)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(124, 23)
        Me.lblFullName.TabIndex = 16
        '
        'lblDays
        '
        Me.lblDays.BackColor = System.Drawing.Color.Gray
        Me.lblDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDays.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblDays.Location = New System.Drawing.Point(362, 60)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(124, 23)
        Me.lblDays.TabIndex = 17
        '
        'lblTemp
        '
        Me.lblTemp.BackColor = System.Drawing.Color.Gray
        Me.lblTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTemp.Location = New System.Drawing.Point(362, 103)
        Me.lblTemp.Name = "lblTemp"
        Me.lblTemp.Size = New System.Drawing.Size(124, 23)
        Me.lblTemp.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 136)
        Me.Controls.Add(Me.lblTemp)
        Me.Controls.Add(Me.lblDays)
        Me.Controls.Add(Me.lblFullName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnShowData)
        Me.Controls.Add(Me.txtTemp)
        Me.Controls.Add(Me.txtDays)
        Me.Controls.Add(Me.txtStateName)
        Me.Controls.Add(Me.txtCityName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Temperature Data"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCityName As TextBox
    Friend WithEvents txtStateName As TextBox
    Friend WithEvents txtDays As TextBox
    Friend WithEvents txtTemp As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnShowData As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents lblDays As Label
    Friend WithEvents lblTemp As Label
End Class

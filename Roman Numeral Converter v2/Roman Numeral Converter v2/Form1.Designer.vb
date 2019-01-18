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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtInteger = New System.Windows.Forms.TextBox()
        Me.lblRomanOutput = New System.Windows.Forms.Label()
        Me.lblRomanInfo = New System.Windows.Forms.Label()
        Me.lblIntegerInfo = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.picBackground = New System.Windows.Forms.PictureBox()
        Me.picBanner1 = New System.Windows.Forms.PictureBox()
        Me.picBanner2 = New System.Windows.Forms.PictureBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBanner1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBanner2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtInteger
        '
        Me.txtInteger.BackColor = System.Drawing.Color.White
        Me.txtInteger.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInteger.ForeColor = System.Drawing.Color.Black
        Me.txtInteger.Location = New System.Drawing.Point(534, 171)
        Me.txtInteger.Name = "txtInteger"
        Me.txtInteger.Size = New System.Drawing.Size(100, 32)
        Me.txtInteger.TabIndex = 7
        Me.txtInteger.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblRomanOutput
        '
        Me.lblRomanOutput.BackColor = System.Drawing.SystemColors.Control
        Me.lblRomanOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRomanOutput.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRomanOutput.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblRomanOutput.Location = New System.Drawing.Point(534, 289)
        Me.lblRomanOutput.Name = "lblRomanOutput"
        Me.lblRomanOutput.Size = New System.Drawing.Size(100, 32)
        Me.lblRomanOutput.TabIndex = 6
        Me.lblRomanOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRomanInfo
        '
        Me.lblRomanInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.lblRomanInfo.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRomanInfo.ForeColor = System.Drawing.Color.White
        Me.lblRomanInfo.Location = New System.Drawing.Point(217, 282)
        Me.lblRomanInfo.Name = "lblRomanInfo"
        Me.lblRomanInfo.Size = New System.Drawing.Size(295, 44)
        Me.lblRomanInfo.TabIndex = 5
        Me.lblRomanInfo.Text = "Equivalent Roman Numeral:"
        Me.lblRomanInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIntegerInfo
        '
        Me.lblIntegerInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.lblIntegerInfo.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntegerInfo.ForeColor = System.Drawing.Color.White
        Me.lblIntegerInfo.Location = New System.Drawing.Point(217, 164)
        Me.lblIntegerInfo.Name = "lblIntegerInfo"
        Me.lblIntegerInfo.Size = New System.Drawing.Size(341, 45)
        Me.lblIntegerInfo.TabIndex = 4
        Me.lblIntegerInfo.Text = "Enter an integer in the range of 1-20:"
        Me.lblIntegerInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnConvert
        '
        Me.btnConvert.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConvert.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.ForeColor = System.Drawing.Color.White
        Me.btnConvert.Location = New System.Drawing.Point(171, 396)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(130, 35)
        Me.btnConvert.TabIndex = 10
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = False
        '
        'picBackground
        '
        Me.picBackground.Image = CType(resources.GetObject("picBackground.Image"), System.Drawing.Image)
        Me.picBackground.Location = New System.Drawing.Point(0, 0)
        Me.picBackground.Name = "picBackground"
        Me.picBackground.Size = New System.Drawing.Size(860, 520)
        Me.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBackground.TabIndex = 0
        Me.picBackground.TabStop = False
        '
        'picBanner1
        '
        Me.picBanner1.BackColor = System.Drawing.Color.Transparent
        Me.picBanner1.Image = CType(resources.GetObject("picBanner1.Image"), System.Drawing.Image)
        Me.picBanner1.Location = New System.Drawing.Point(169, 164)
        Me.picBanner1.Name = "picBanner1"
        Me.picBanner1.Size = New System.Drawing.Size(511, 79)
        Me.picBanner1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBanner1.TabIndex = 11
        Me.picBanner1.TabStop = False
        '
        'picBanner2
        '
        Me.picBanner2.BackColor = System.Drawing.Color.Transparent
        Me.picBanner2.Image = CType(resources.GetObject("picBanner2.Image"), System.Drawing.Image)
        Me.picBanner2.Location = New System.Drawing.Point(169, 282)
        Me.picBanner2.Name = "picBanner2"
        Me.picBanner2.Size = New System.Drawing.Size(511, 79)
        Me.picBanner2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBanner2.TabIndex = 12
        Me.picBanner2.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(368, 396)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(130, 35)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(550, 396)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(130, 35)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Times New Roman", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(163, 81)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(517, 46)
        Me.lblTitle.TabIndex = 15
        Me.lblTitle.Text = "Roman Numeral Converter"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 516)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.txtInteger)
        Me.Controls.Add(Me.lblRomanOutput)
        Me.Controls.Add(Me.lblRomanInfo)
        Me.Controls.Add(Me.lblIntegerInfo)
        Me.Controls.Add(Me.picBanner1)
        Me.Controls.Add(Me.picBanner2)
        Me.Controls.Add(Me.picBackground)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Roman Numeral Converter"
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBanner1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBanner2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInteger As TextBox
    Friend WithEvents lblRomanOutput As Label
    Friend WithEvents lblRomanInfo As Label
    Friend WithEvents lblIntegerInfo As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents picBackground As PictureBox
    Friend WithEvents picBanner1 As PictureBox
    Friend WithEvents picBanner2 As PictureBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTitle As Label
End Class

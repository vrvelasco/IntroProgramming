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
        Me.txtSecretWord = New System.Windows.Forms.TextBox()
        Me.lstAttempts = New System.Windows.Forms.ListBox()
        Me.grpMain = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnGuess = New System.Windows.Forms.Button()
        Me.chkTries = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.grpMain.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Secret Word:"
        '
        'txtSecretWord
        '
        Me.txtSecretWord.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecretWord.Location = New System.Drawing.Point(157, 6)
        Me.txtSecretWord.Name = "txtSecretWord"
        Me.txtSecretWord.Size = New System.Drawing.Size(157, 22)
        Me.txtSecretWord.TabIndex = 1
        '
        'lstAttempts
        '
        Me.lstAttempts.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstAttempts.FormattingEnabled = True
        Me.lstAttempts.ItemHeight = 17
        Me.lstAttempts.Location = New System.Drawing.Point(101, 19)
        Me.lstAttempts.Name = "lstAttempts"
        Me.lstAttempts.Size = New System.Drawing.Size(203, 225)
        Me.lstAttempts.TabIndex = 2
        '
        'grpMain
        '
        Me.grpMain.Controls.Add(Me.Label2)
        Me.grpMain.Controls.Add(Me.btnClear)
        Me.grpMain.Controls.Add(Me.btnExit)
        Me.grpMain.Controls.Add(Me.lstAttempts)
        Me.grpMain.Location = New System.Drawing.Point(12, 6)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(310, 258)
        Me.grpMain.TabIndex = 3
        Me.grpMain.TabStop = False
        Me.grpMain.Visible = False
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(7, 125)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(87, 55)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(7, 189)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 55)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnGuess
        '
        Me.btnGuess.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuess.Location = New System.Drawing.Point(19, 62)
        Me.btnGuess.Name = "btnGuess"
        Me.btnGuess.Size = New System.Drawing.Size(295, 60)
        Me.btnGuess.TabIndex = 4
        Me.btnGuess.Text = "Guess Secret Word"
        Me.btnGuess.UseVisualStyleBackColor = True
        '
        'chkTries
        '
        Me.chkTries.AutoSize = True
        Me.chkTries.BackColor = System.Drawing.Color.DimGray
        Me.chkTries.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTries.ForeColor = System.Drawing.Color.White
        Me.chkTries.Location = New System.Drawing.Point(24, 37)
        Me.chkTries.Name = "chkTries"
        Me.chkTries.Size = New System.Drawing.Size(138, 17)
        Me.chkTries.TabIndex = 5
        Me.chkTries.Text = "Limit to three (3) tries"
        Me.chkTries.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DimGray
        Me.PictureBox1.Location = New System.Drawing.Point(19, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(295, 26)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 35)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Good" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Luck!"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(303, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "How To Play:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.Location = New System.Drawing.Point(14, 129)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(303, 3)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Black
        Me.PictureBox3.Location = New System.Drawing.Point(14, 158)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(303, 1)
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Black
        Me.PictureBox4.Location = New System.Drawing.Point(14, 254)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(303, 3)
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "1) Enter a Secret Word above."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(278, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "2) Check the box above to limit the tries to three (3)."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 208)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(238, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Hint: Leave the box unchecked for unlimited tries."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 228)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(202, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "3) Press the button to start the game!"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 274)
        Me.Controls.Add(Me.btnGuess)
        Me.Controls.Add(Me.grpMain)
        Me.Controls.Add(Me.chkTries)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSecretWord)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Password"
        Me.grpMain.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtSecretWord As TextBox
    Friend WithEvents lstAttempts As ListBox
    Friend WithEvents grpMain As GroupBox
    Friend WithEvents btnGuess As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents chkTries As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class

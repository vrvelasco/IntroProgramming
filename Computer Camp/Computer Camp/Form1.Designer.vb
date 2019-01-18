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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radBasic = New System.Windows.Forms.RadioButton()
        Me.radJava = New System.Windows.Forms.RadioButton()
        Me.chkMeals = New System.Windows.Forms.CheckBox()
        Me.chkCabin = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMoney = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblLanguageFee = New System.Windows.Forms.Label()
        Me.lblOptionsSubtotal = New System.Windows.Forms.Label()
        Me.lblMoney = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 80)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Computer Camp"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radJava)
        Me.GroupBox1.Controls.Add(Me.radBasic)
        Me.GroupBox1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(121, 79)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Language Fee"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkMeals)
        Me.GroupBox2.Controls.Add(Me.chkCabin)
        Me.GroupBox2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(139, 92)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(122, 79)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Options Fees"
        '
        'radBasic
        '
        Me.radBasic.AutoSize = True
        Me.radBasic.Checked = True
        Me.radBasic.Location = New System.Drawing.Point(6, 22)
        Me.radBasic.Name = "radBasic"
        Me.radBasic.Size = New System.Drawing.Size(110, 22)
        Me.radBasic.TabIndex = 0
        Me.radBasic.TabStop = True
        Me.radBasic.Text = "Basic   $1000"
        Me.radBasic.UseVisualStyleBackColor = True
        '
        'radJava
        '
        Me.radJava.AutoSize = True
        Me.radJava.Location = New System.Drawing.Point(6, 50)
        Me.radJava.Name = "radJava"
        Me.radJava.Size = New System.Drawing.Size(110, 22)
        Me.radJava.TabIndex = 1
        Me.radJava.Text = "Java    $2000"
        Me.radJava.UseVisualStyleBackColor = True
        '
        'chkMeals
        '
        Me.chkMeals.AutoSize = True
        Me.chkMeals.Location = New System.Drawing.Point(6, 22)
        Me.chkMeals.Name = "chkMeals"
        Me.chkMeals.Size = New System.Drawing.Size(109, 22)
        Me.chkMeals.TabIndex = 2
        Me.chkMeals.Text = "Meals    $100"
        Me.chkMeals.UseVisualStyleBackColor = True
        '
        'chkCabin
        '
        Me.chkCabin.AutoSize = True
        Me.chkCabin.Location = New System.Drawing.Point(6, 50)
        Me.chkCabin.Name = "chkCabin"
        Me.chkCabin.Size = New System.Drawing.Size(110, 22)
        Me.chkCabin.TabIndex = 3
        Me.chkCabin.Text = "Cabin    $200"
        Me.chkCabin.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtMoney)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 177)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(249, 100)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "E-Spending Money"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 50)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Spending money used at camp." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You can load a value between $1 and $20."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Amount: $"
        '
        'txtMoney
        '
        Me.txtMoney.Location = New System.Drawing.Point(84, 66)
        Me.txtMoney.Name = "txtMoney"
        Me.txtMoney.Size = New System.Drawing.Size(158, 23)
        Me.txtMoney.TabIndex = 2
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.PictureBox1)
        Me.GroupBox4.Controls.Add(Me.lblTotalCost)
        Me.GroupBox4.Controls.Add(Me.lblMoney)
        Me.GroupBox4.Controls.Add(Me.lblOptionsSubtotal)
        Me.GroupBox4.Controls.Add(Me.lblLanguageFee)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 312)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(249, 115)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'lblLanguageFee
        '
        Me.lblLanguageFee.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLanguageFee.Location = New System.Drawing.Point(6, 16)
        Me.lblLanguageFee.Name = "lblLanguageFee"
        Me.lblLanguageFee.Size = New System.Drawing.Size(235, 23)
        Me.lblLanguageFee.TabIndex = 0
        Me.lblLanguageFee.Text = "Language Fee:"
        '
        'lblOptionsSubtotal
        '
        Me.lblOptionsSubtotal.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOptionsSubtotal.Location = New System.Drawing.Point(6, 39)
        Me.lblOptionsSubtotal.Name = "lblOptionsSubtotal"
        Me.lblOptionsSubtotal.Size = New System.Drawing.Size(235, 23)
        Me.lblOptionsSubtotal.TabIndex = 1
        Me.lblOptionsSubtotal.Text = "Options Subtotal:"
        '
        'lblMoney
        '
        Me.lblMoney.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoney.Location = New System.Drawing.Point(6, 62)
        Me.lblMoney.Name = "lblMoney"
        Me.lblMoney.Size = New System.Drawing.Size(235, 23)
        Me.lblMoney.TabIndex = 2
        Me.lblMoney.Text = "E-Spending Money:"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(6, 88)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(235, 23)
        Me.lblTotalCost.TabIndex = 3
        Me.lblTotalCost.Text = "Total Cost:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Location = New System.Drawing.Point(6, 83)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(235, 2)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(12, 283)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 4
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(100, 283)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(186, 283)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 435)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Computer Camp"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radJava As RadioButton
    Friend WithEvents radBasic As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkMeals As CheckBox
    Friend WithEvents chkCabin As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtMoney As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents lblMoney As Label
    Friend WithEvents lblOptionsSubtotal As Label
    Friend WithEvents lblLanguageFee As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class

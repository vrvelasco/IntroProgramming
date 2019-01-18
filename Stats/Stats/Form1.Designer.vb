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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radEnglish = New System.Windows.Forms.RadioButton()
        Me.radEspanol = New System.Windows.Forms.RadioButton()
        Me.grpStarPlayer = New System.Windows.Forms.GroupBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.grpScores = New System.Windows.Forms.GroupBox()
        Me.lblGame1 = New System.Windows.Forms.Label()
        Me.lblGame2 = New System.Windows.Forms.Label()
        Me.lblGame3 = New System.Windows.Forms.Label()
        Me.txtGame1 = New System.Windows.Forms.TextBox()
        Me.txtGame2 = New System.Windows.Forms.TextBox()
        Me.txtGame3 = New System.Windows.Forms.TextBox()
        Me.btnStats = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblStarPlayer = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblCalcPlayer = New System.Windows.Forms.Label()
        Me.lblCalcAverage = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.grpStarPlayer.SuspendLayout()
        Me.grpScores.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(301, 302)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radEnglish)
        Me.GroupBox1.Controls.Add(Me.radEspanol)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 320)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(301, 56)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Language (Idioma)"
        '
        'radEnglish
        '
        Me.radEnglish.AutoSize = True
        Me.radEnglish.Checked = True
        Me.radEnglish.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radEnglish.Location = New System.Drawing.Point(11, 24)
        Me.radEnglish.Name = "radEnglish"
        Me.radEnglish.Size = New System.Drawing.Size(117, 20)
        Me.radEnglish.TabIndex = 2
        Me.radEnglish.TabStop = True
        Me.radEnglish.Text = "English (Inglés)"
        Me.radEnglish.UseVisualStyleBackColor = True
        '
        'radEspanol
        '
        Me.radEspanol.AutoSize = True
        Me.radEspanol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radEspanol.Location = New System.Drawing.Point(154, 24)
        Me.radEspanol.Name = "radEspanol"
        Me.radEspanol.Size = New System.Drawing.Size(136, 20)
        Me.radEspanol.TabIndex = 3
        Me.radEspanol.Text = "Spanish (Español)"
        Me.radEspanol.UseVisualStyleBackColor = True
        '
        'grpStarPlayer
        '
        Me.grpStarPlayer.Controls.Add(Me.lblNumber)
        Me.grpStarPlayer.Controls.Add(Me.txtNumber)
        Me.grpStarPlayer.Controls.Add(Me.lblName)
        Me.grpStarPlayer.Controls.Add(Me.txtName)
        Me.grpStarPlayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpStarPlayer.Location = New System.Drawing.Point(12, 385)
        Me.grpStarPlayer.Name = "grpStarPlayer"
        Me.grpStarPlayer.Size = New System.Drawing.Size(301, 85)
        Me.grpStarPlayer.TabIndex = 2
        Me.grpStarPlayer.TabStop = False
        Me.grpStarPlayer.Text = "Star Player"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(8, 24)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(53, 16)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Name:"
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber.Location = New System.Drawing.Point(8, 52)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(66, 16)
        Me.lblNumber.TabIndex = 4
        Me.lblNumber.Text = "Number:"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(80, 21)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(210, 22)
        Me.txtName.TabIndex = 5
        '
        'txtNumber
        '
        Me.txtNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber.Location = New System.Drawing.Point(80, 49)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(210, 22)
        Me.txtNumber.TabIndex = 6
        '
        'grpScores
        '
        Me.grpScores.Controls.Add(Me.txtGame3)
        Me.grpScores.Controls.Add(Me.lblGame3)
        Me.grpScores.Controls.Add(Me.txtGame2)
        Me.grpScores.Controls.Add(Me.lblGame1)
        Me.grpScores.Controls.Add(Me.txtGame1)
        Me.grpScores.Controls.Add(Me.lblGame2)
        Me.grpScores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpScores.Location = New System.Drawing.Point(12, 478)
        Me.grpScores.Name = "grpScores"
        Me.grpScores.Size = New System.Drawing.Size(301, 111)
        Me.grpScores.TabIndex = 3
        Me.grpScores.TabStop = False
        Me.grpScores.Text = "Scores"
        '
        'lblGame1
        '
        Me.lblGame1.AutoSize = True
        Me.lblGame1.Location = New System.Drawing.Point(6, 24)
        Me.lblGame1.Name = "lblGame1"
        Me.lblGame1.Size = New System.Drawing.Size(65, 16)
        Me.lblGame1.TabIndex = 4
        Me.lblGame1.Text = "Game 1:"
        '
        'lblGame2
        '
        Me.lblGame2.AutoSize = True
        Me.lblGame2.Location = New System.Drawing.Point(6, 52)
        Me.lblGame2.Name = "lblGame2"
        Me.lblGame2.Size = New System.Drawing.Size(65, 16)
        Me.lblGame2.TabIndex = 5
        Me.lblGame2.Text = "Game 2:"
        '
        'lblGame3
        '
        Me.lblGame3.AutoSize = True
        Me.lblGame3.Location = New System.Drawing.Point(6, 80)
        Me.lblGame3.Name = "lblGame3"
        Me.lblGame3.Size = New System.Drawing.Size(65, 16)
        Me.lblGame3.TabIndex = 6
        Me.lblGame3.Text = "Game 3:"
        '
        'txtGame1
        '
        Me.txtGame1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGame1.Location = New System.Drawing.Point(80, 21)
        Me.txtGame1.Name = "txtGame1"
        Me.txtGame1.Size = New System.Drawing.Size(210, 22)
        Me.txtGame1.TabIndex = 4
        '
        'txtGame2
        '
        Me.txtGame2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGame2.Location = New System.Drawing.Point(80, 49)
        Me.txtGame2.Name = "txtGame2"
        Me.txtGame2.Size = New System.Drawing.Size(210, 22)
        Me.txtGame2.TabIndex = 5
        '
        'txtGame3
        '
        Me.txtGame3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGame3.Location = New System.Drawing.Point(80, 77)
        Me.txtGame3.Name = "txtGame3"
        Me.txtGame3.Size = New System.Drawing.Size(210, 22)
        Me.txtGame3.TabIndex = 6
        '
        'btnStats
        '
        Me.btnStats.Location = New System.Drawing.Point(12, 602)
        Me.btnStats.Name = "btnStats"
        Me.btnStats.Size = New System.Drawing.Size(95, 23)
        Me.btnStats.TabIndex = 4
        Me.btnStats.Text = "Stats"
        Me.btnStats.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(115, 602)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(95, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(218, 602)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(95, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblStarPlayer
        '
        Me.lblStarPlayer.Location = New System.Drawing.Point(6, 18)
        Me.lblStarPlayer.Name = "lblStarPlayer"
        Me.lblStarPlayer.Size = New System.Drawing.Size(289, 23)
        Me.lblStarPlayer.TabIndex = 7
        Me.lblStarPlayer.Text = "Star Player"
        Me.lblStarPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAverage
        '
        Me.lblAverage.Location = New System.Drawing.Point(3, 74)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(287, 28)
        Me.lblAverage.TabIndex = 8
        Me.lblAverage.Text = "Average Score"
        Me.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblCalcAverage)
        Me.GroupBox2.Controls.Add(Me.lblCalcPlayer)
        Me.GroupBox2.Controls.Add(Me.lblAverage)
        Me.GroupBox2.Controls.Add(Me.lblStarPlayer)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 635)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(301, 144)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'lblCalcPlayer
        '
        Me.lblCalcPlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCalcPlayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalcPlayer.Location = New System.Drawing.Point(11, 41)
        Me.lblCalcPlayer.Name = "lblCalcPlayer"
        Me.lblCalcPlayer.Size = New System.Drawing.Size(279, 22)
        Me.lblCalcPlayer.TabIndex = 9
        Me.lblCalcPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCalcAverage
        '
        Me.lblCalcAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCalcAverage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalcAverage.Location = New System.Drawing.Point(11, 102)
        Me.lblCalcAverage.Name = "lblCalcAverage"
        Me.lblCalcAverage.Size = New System.Drawing.Size(279, 22)
        Me.lblCalcAverage.TabIndex = 10
        Me.lblCalcAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 791)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnStats)
        Me.Controls.Add(Me.grpScores)
        Me.Controls.Add(Me.grpStarPlayer)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "2018 FIFA World Cup Russia™"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpStarPlayer.ResumeLayout(False)
        Me.grpStarPlayer.PerformLayout()
        Me.grpScores.ResumeLayout(False)
        Me.grpScores.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radEnglish As RadioButton
    Friend WithEvents radEspanol As RadioButton
    Friend WithEvents grpStarPlayer As GroupBox
    Friend WithEvents lblNumber As Label
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents grpScores As GroupBox
    Friend WithEvents lblGame3 As Label
    Friend WithEvents lblGame1 As Label
    Friend WithEvents lblGame2 As Label
    Friend WithEvents txtGame3 As TextBox
    Friend WithEvents txtGame2 As TextBox
    Friend WithEvents txtGame1 As TextBox
    Friend WithEvents btnStats As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblStarPlayer As Label
    Friend WithEvents lblAverage As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblCalcAverage As Label
    Friend WithEvents lblCalcPlayer As Label
End Class

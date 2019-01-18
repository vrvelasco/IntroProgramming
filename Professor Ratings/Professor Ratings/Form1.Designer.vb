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
        Me.txtProfessorName = New System.Windows.Forms.TextBox()
        Me.txtProfessorRating = New System.Windows.Forms.TextBox()
        Me.lstProfessorNames = New System.Windows.Forms.ListBox()
        Me.lstProfessorRatingsFancy = New System.Windows.Forms.ListBox()
        Me.lblNumberProfessors = New System.Windows.Forms.Label()
        Me.lblAverageRating = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lstProfessorRatings = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtProfessorName
        '
        Me.txtProfessorName.Location = New System.Drawing.Point(54, 20)
        Me.txtProfessorName.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtProfessorName.Name = "txtProfessorName"
        Me.txtProfessorName.Size = New System.Drawing.Size(116, 21)
        Me.txtProfessorName.TabIndex = 0
        '
        'txtProfessorRating
        '
        Me.txtProfessorRating.Location = New System.Drawing.Point(252, 20)
        Me.txtProfessorRating.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtProfessorRating.MaxLength = 1
        Me.txtProfessorRating.Name = "txtProfessorRating"
        Me.txtProfessorRating.Size = New System.Drawing.Size(49, 21)
        Me.txtProfessorRating.TabIndex = 1
        '
        'lstProfessorNames
        '
        Me.lstProfessorNames.FormattingEnabled = True
        Me.lstProfessorNames.ItemHeight = 15
        Me.lstProfessorNames.Location = New System.Drawing.Point(5, 29)
        Me.lstProfessorNames.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.lstProfessorNames.Name = "lstProfessorNames"
        Me.lstProfessorNames.Size = New System.Drawing.Size(139, 139)
        Me.lstProfessorNames.TabIndex = 233
        '
        'lstProfessorRatingsFancy
        '
        Me.lstProfessorRatingsFancy.FormattingEnabled = True
        Me.lstProfessorRatingsFancy.ItemHeight = 15
        Me.lstProfessorRatingsFancy.Location = New System.Drawing.Point(5, 29)
        Me.lstProfessorRatingsFancy.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.lstProfessorRatingsFancy.Name = "lstProfessorRatingsFancy"
        Me.lstProfessorRatingsFancy.Size = New System.Drawing.Size(139, 139)
        Me.lstProfessorRatingsFancy.TabIndex = 3
        '
        'lblNumberProfessors
        '
        Me.lblNumberProfessors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNumberProfessors.Location = New System.Drawing.Point(141, 113)
        Me.lblNumberProfessors.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNumberProfessors.Name = "lblNumberProfessors"
        Me.lblNumberProfessors.Size = New System.Drawing.Size(160, 28)
        Me.lblNumberProfessors.TabIndex = 4
        Me.lblNumberProfessors.Text = "0"
        Me.lblNumberProfessors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAverageRating
        '
        Me.lblAverageRating.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageRating.Location = New System.Drawing.Point(141, 148)
        Me.lblAverageRating.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAverageRating.Name = "lblAverageRating"
        Me.lblAverageRating.Size = New System.Drawing.Size(160, 28)
        Me.lblAverageRating.TabIndex = 5
        Me.lblAverageRating.Text = "0.0"
        Me.lblAverageRating.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnEnter
        '
        Me.btnEnter.Image = CType(resources.GetObject("btnEnter.Image"), System.Drawing.Image)
        Me.btnEnter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnter.Location = New System.Drawing.Point(5, 20)
        Me.btnEnter.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(196, 40)
        Me.btnEnter.TabIndex = 0
        Me.btnEnter.Text = "Enter Professor and Rating"
        Me.btnEnter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Image = CType(resources.GetObject("btnDisplay.Image"), System.Drawing.Image)
        Me.btnDisplay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDisplay.Location = New System.Drawing.Point(5, 66)
        Me.btnDisplay.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(196, 40)
        Me.btnDisplay.TabIndex = 7
        Me.btnDisplay.Text = "           Display Results"
        Me.btnDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.Location = New System.Drawing.Point(205, 20)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(96, 40)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "     Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(205, 66)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(96, 40)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "  Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 21)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Name:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(174, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 21)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Rating:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(6, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 30)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Number of Professors:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(6, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 30)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Average Rating:"
        '
        'lstProfessorRatings
        '
        Me.lstProfessorRatings.FormattingEnabled = True
        Me.lstProfessorRatings.ItemHeight = 15
        Me.lstProfessorRatings.Location = New System.Drawing.Point(592, 87)
        Me.lstProfessorRatings.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.lstProfessorRatings.Name = "lstProfessorRatings"
        Me.lstProfessorRatings.Size = New System.Drawing.Size(139, 109)
        Me.lstProfessorRatings.TabIndex = 118
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstProfessorNames)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(151, 177)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "          Professor's Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstProfessorRatingsFancy)
        Me.GroupBox2.Location = New System.Drawing.Point(169, 78)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(152, 177)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "          Professor's Rating"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(175, 69)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(18, 69)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtProfessorName)
        Me.GroupBox3.Controls.Add(Me.txtProfessorRating)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(309, 49)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Professor's Details"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.btnDisplay)
        Me.GroupBox7.Controls.Add(Me.btnEnter)
        Me.GroupBox7.Controls.Add(Me.btnClear)
        Me.GroupBox7.Controls.Add(Me.btnExit)
        Me.GroupBox7.Controls.Add(Me.Label5)
        Me.GroupBox7.Controls.Add(Me.lblNumberProfessors)
        Me.GroupBox7.Controls.Add(Me.Label6)
        Me.GroupBox7.Controls.Add(Me.lblAverageRating)
        Me.GroupBox7.Location = New System.Drawing.Point(12, 261)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(309, 186)
        Me.GroupBox7.TabIndex = 3
        Me.GroupBox7.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 457)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lstProfessorRatings)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Professor Ratings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtProfessorName As TextBox
    Friend WithEvents txtProfessorRating As TextBox
    Friend WithEvents lstProfessorNames As ListBox
    Friend WithEvents lstProfessorRatingsFancy As ListBox
    Friend WithEvents lblNumberProfessors As Label
    Friend WithEvents lblAverageRating As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lstProfessorRatings As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
End Class

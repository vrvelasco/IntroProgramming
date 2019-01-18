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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotalOscars = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtMovie = New System.Windows.Forms.TextBox()
        Me.txtOscars = New System.Windows.Forms.TextBox()
        Me.lstMovies = New System.Windows.Forms.ListBox()
        Me.lstOscars = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Movie:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Oscars:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Movies"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(132, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 12)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Oscars"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total Oscars:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalOscars
        '
        Me.lblTotalOscars.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalOscars.Location = New System.Drawing.Point(82, 16)
        Me.lblTotalOscars.Name = "lblTotalOscars"
        Me.lblTotalOscars.Size = New System.Drawing.Size(173, 23)
        Me.lblTotalOscars.TabIndex = 5
        Me.lblTotalOscars.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(6, 76)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(246, 23)
        Me.btnEnter.TabIndex = 3
        Me.btnEnter.Text = "Enter Movie and Oscars"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(6, 132)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(246, 23)
        Me.btnDisplay.TabIndex = 7
        Me.btnDisplay.Text = "Display Total Oscars"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(9, 47)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(180, 47)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtMovie
        '
        Me.txtMovie.Location = New System.Drawing.Point(60, 16)
        Me.txtMovie.Name = "txtMovie"
        Me.txtMovie.Size = New System.Drawing.Size(192, 20)
        Me.txtMovie.TabIndex = 1
        '
        'txtOscars
        '
        Me.txtOscars.Location = New System.Drawing.Point(60, 42)
        Me.txtOscars.Name = "txtOscars"
        Me.txtOscars.Size = New System.Drawing.Size(192, 20)
        Me.txtOscars.TabIndex = 2
        '
        'lstMovies
        '
        Me.lstMovies.FormattingEnabled = True
        Me.lstMovies.Location = New System.Drawing.Point(6, 31)
        Me.lstMovies.Name = "lstMovies"
        Me.lstMovies.Size = New System.Drawing.Size(120, 95)
        Me.lstMovies.TabIndex = 12
        '
        'lstOscars
        '
        Me.lstOscars.FormattingEnabled = True
        Me.lstOscars.Location = New System.Drawing.Point(132, 31)
        Me.lstOscars.Name = "lstOscars"
        Me.lstOscars.Size = New System.Drawing.Size(120, 95)
        Me.lstOscars.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtOscars)
        Me.GroupBox1.Controls.Add(Me.btnEnter)
        Me.GroupBox1.Controls.Add(Me.txtMovie)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 109)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstOscars)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lstMovies)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.btnDisplay)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 127)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(259, 164)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnExit)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.btnClear)
        Me.GroupBox3.Controls.Add(Me.lblTotalOscars)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 297)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(259, 79)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 385)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Movie Oscars"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotalOscars As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtMovie As TextBox
    Friend WithEvents txtOscars As TextBox
    Friend WithEvents lstMovies As ListBox
    Friend WithEvents lstOscars As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
End Class

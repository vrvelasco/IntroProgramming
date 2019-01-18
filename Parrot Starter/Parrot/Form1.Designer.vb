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
        Me.lstPhrases = New System.Windows.Forms.ListBox()
        Me.lstParrots = New System.Windows.Forms.ListBox()
        Me.btnBegin = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstPhrases
        '
        Me.lstPhrases.FormattingEnabled = True
        Me.lstPhrases.Location = New System.Drawing.Point(12, 12)
        Me.lstPhrases.Name = "lstPhrases"
        Me.lstPhrases.Size = New System.Drawing.Size(120, 199)
        Me.lstPhrases.TabIndex = 0
        '
        'lstParrots
        '
        Me.lstParrots.FormattingEnabled = True
        Me.lstParrots.Location = New System.Drawing.Point(152, 12)
        Me.lstParrots.Name = "lstParrots"
        Me.lstParrots.Size = New System.Drawing.Size(120, 199)
        Me.lstParrots.TabIndex = 1
        '
        'btnBegin
        '
        Me.btnBegin.Location = New System.Drawing.Point(12, 227)
        Me.btnBegin.Name = "btnBegin"
        Me.btnBegin.Size = New System.Drawing.Size(75, 23)
        Me.btnBegin.TabIndex = 2
        Me.btnBegin.Text = "Begin"
        Me.btnBegin.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(104, 227)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(197, 227)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnBegin)
        Me.Controls.Add(Me.lstParrots)
        Me.Controls.Add(Me.lstPhrases)
        Me.Name = "Form1"
        Me.Text = "Parrot"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstPhrases As System.Windows.Forms.ListBox
    Friend WithEvents lstParrots As System.Windows.Forms.ListBox
    Friend WithEvents btnBegin As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class

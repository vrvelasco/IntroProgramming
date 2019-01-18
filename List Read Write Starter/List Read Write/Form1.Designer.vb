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
        Me.btnRead = New System.Windows.Forms.Button()
        Me.btnWrite = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lstList = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(147, 12)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(75, 23)
        Me.btnRead.TabIndex = 0
        Me.btnRead.Text = "Read"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'btnWrite
        '
        Me.btnWrite.Location = New System.Drawing.Point(147, 41)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(75, 23)
        Me.btnWrite.TabIndex = 1
        Me.btnWrite.Text = "Write"
        Me.btnWrite.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(147, 70)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(147, 99)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lstList
        '
        Me.lstList.FormattingEnabled = True
        Me.lstList.Location = New System.Drawing.Point(12, 12)
        Me.lstList.Name = "lstList"
        Me.lstList.Size = New System.Drawing.Size(120, 238)
        Me.lstList.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 262)
        Me.Controls.Add(Me.lstList)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnWrite)
        Me.Controls.Add(Me.btnRead)
        Me.Name = "Form1"
        Me.Text = "List Read/Write"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRead As System.Windows.Forms.Button
    Friend WithEvents btnWrite As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lstList As System.Windows.Forms.ListBox

End Class

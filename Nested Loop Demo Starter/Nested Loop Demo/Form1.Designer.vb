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
        Me.btnMult = New System.Windows.Forms.Button()
        Me.lstMult = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnMult
        '
        Me.btnMult.Location = New System.Drawing.Point(98, 226)
        Me.btnMult.Name = "btnMult"
        Me.btnMult.Size = New System.Drawing.Size(75, 23)
        Me.btnMult.TabIndex = 0
        Me.btnMult.Text = "Multiply"
        Me.btnMult.UseVisualStyleBackColor = True
        '
        'lstMult
        '
        Me.lstMult.FormattingEnabled = True
        Me.lstMult.Location = New System.Drawing.Point(12, 12)
        Me.lstMult.Name = "lstMult"
        Me.lstMult.Size = New System.Drawing.Size(260, 199)
        Me.lstMult.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lstMult)
        Me.Controls.Add(Me.btnMult)
        Me.Name = "Form1"
        Me.Text = "Nested Loop Demo"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMult As Button
    Friend WithEvents lstMult As ListBox
End Class

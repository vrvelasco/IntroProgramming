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
        Me.btnDisplayMessage = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDisplayMessage
        '
        Me.btnDisplayMessage.Location = New System.Drawing.Point(244, 9)
        Me.btnDisplayMessage.Name = "btnDisplayMessage"
        Me.btnDisplayMessage.Size = New System.Drawing.Size(60, 46)
        Me.btnDisplayMessage.TabIndex = 0
        Me.btnDisplayMessage.Text = "Display Message"
        Me.btnDisplayMessage.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.BackColor = System.Drawing.Color.Olive
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMessage.Font = New System.Drawing.Font("Algerian", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMessage.Location = New System.Drawing.Point(12, 9)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(226, 46)
        Me.lblMessage.TabIndex = 1
        Me.lblMessage.Text = "Click The Button"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(309, 9)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(60, 46)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 66)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnDisplayMessage)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDisplayMessage As Button
    Friend WithEvents lblMessage As Label
    Friend WithEvents btnClear As Button
End Class

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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnEmpty = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstFood = New System.Windows.Forms.ListBox()
        Me.lstPrice = New System.Windows.Forms.ListBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(12, 204)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(120, 23)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start Shopping"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnEmpty
        '
        Me.btnEmpty.Location = New System.Drawing.Point(143, 204)
        Me.btnEmpty.Name = "btnEmpty"
        Me.btnEmpty.Size = New System.Drawing.Size(120, 23)
        Me.btnEmpty.TabIndex = 1
        Me.btnEmpty.Text = "Empty Cart"
        Me.btnEmpty.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(95, 235)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Total: "
        '
        'lstFood
        '
        Me.lstFood.FormattingEnabled = True
        Me.lstFood.Location = New System.Drawing.Point(12, 12)
        Me.lstFood.Name = "lstFood"
        Me.lstFood.Size = New System.Drawing.Size(120, 186)
        Me.lstFood.TabIndex = 3
        '
        'lstPrice
        '
        Me.lstPrice.FormattingEnabled = True
        Me.lstPrice.Location = New System.Drawing.Point(143, 12)
        Me.lstPrice.Name = "lstPrice"
        Me.lstPrice.Size = New System.Drawing.Size(120, 186)
        Me.lstPrice.TabIndex = 4
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(143, 230)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(120, 23)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 264)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lstPrice)
        Me.Controls.Add(Me.lstFood)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEmpty)
        Me.Controls.Add(Me.btnStart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Shopping"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents btnEmpty As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lstFood As ListBox
    Friend WithEvents lstPrice As ListBox
    Friend WithEvents lblTotal As Label
End Class

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
        Me.lstMonths = New System.Windows.Forms.ListBox()
        Me.lstYears = New System.Windows.Forms.ListBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstMonths
        '
        Me.lstMonths.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMonths.FormattingEnabled = True
        Me.lstMonths.ItemHeight = 22
        Me.lstMonths.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.lstMonths.Location = New System.Drawing.Point(12, 12)
        Me.lstMonths.Name = "lstMonths"
        Me.lstMonths.Size = New System.Drawing.Size(110, 268)
        Me.lstMonths.TabIndex = 0
        '
        'lstYears
        '
        Me.lstYears.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstYears.FormattingEnabled = True
        Me.lstYears.ItemHeight = 22
        Me.lstYears.Items.AddRange(New Object() {"2016", "2017", "2018", "2019", "2020"})
        Me.lstYears.Location = New System.Drawing.Point(128, 12)
        Me.lstYears.Name = "lstYears"
        Me.lstYears.Size = New System.Drawing.Size(110, 268)
        Me.lstYears.TabIndex = 1
        '
        'btnOK
        '
        Me.btnOK.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(12, 286)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(110, 38)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(128, 286)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(110, 38)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(250, 334)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lstYears)
        Me.Controls.Add(Me.lstMonths)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "List Box Demo"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstMonths As ListBox
    Friend WithEvents lstYears As ListBox
    Friend WithEvents btnOK As Button
    Friend WithEvents btnReset As Button
End Class

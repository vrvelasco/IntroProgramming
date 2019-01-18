<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lstGrades = New System.Windows.Forms.ListBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstGrades
        '
        Me.lstGrades.FormattingEnabled = True
        Me.lstGrades.ItemHeight = 17
        Me.lstGrades.Location = New System.Drawing.Point(14, 16)
        Me.lstGrades.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstGrades.Name = "lstGrades"
        Me.lstGrades.Size = New System.Drawing.Size(250, 72)
        Me.lstGrades.TabIndex = 3
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(14, 100)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(80, 30)
        Me.btnEnter.TabIndex = 0
        Me.btnEnter.Text = "Enter Data"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(99, 100)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(80, 30)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(184, 100)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 30)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 141)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lstGrades)
        Me.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Grade Report"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstGrades As ListBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class

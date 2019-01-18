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
        Me.lstNumbers = New System.Windows.Forms.ListBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnCalcAvg = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstNumbers
        '
        Me.lstNumbers.FormattingEnabled = True
        Me.lstNumbers.ItemHeight = 17
        Me.lstNumbers.Location = New System.Drawing.Point(12, 114)
        Me.lstNumbers.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstNumbers.Name = "lstNumbers"
        Me.lstNumbers.Size = New System.Drawing.Size(430, 123)
        Me.lstNumbers.TabIndex = 0
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(12, 24)
        Me.btnEnter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(128, 39)
        Me.btnEnter.TabIndex = 1
        Me.btnEnter.Text = "Enter &Numbers"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnCalcAvg
        '
        Me.btnCalcAvg.Location = New System.Drawing.Point(147, 24)
        Me.btnCalcAvg.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCalcAvg.Name = "btnCalcAvg"
        Me.btnCalcAvg.Size = New System.Drawing.Size(128, 39)
        Me.btnCalcAvg.TabIndex = 2
        Me.btnCalcAvg.Text = "Calculate &Average"
        Me.btnCalcAvg.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(283, 24)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(64, 39)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(354, 24)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(64, 39)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.btnEnter)
        Me.GroupBox1.Controls.Add(Me.btnCalcAvg)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 245)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(430, 80)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(433, 101)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = resources.GetString("Label1.Text")
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 335)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstNumbers)
        Me.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Number List"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstNumbers As ListBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnCalcAvg As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
End Class

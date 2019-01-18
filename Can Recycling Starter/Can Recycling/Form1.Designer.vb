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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPounds = New System.Windows.Forms.TextBox()
        Me.lstNames = New System.Windows.Forms.ListBox()
        Me.lstPounds = New System.Windows.Forms.ListBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(93, 12)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(75, 20)
        Me.txtName.TabIndex = 0
        '
        'txtPounds
        '
        Me.txtPounds.Location = New System.Drawing.Point(93, 52)
        Me.txtPounds.Name = "txtPounds"
        Me.txtPounds.Size = New System.Drawing.Size(75, 20)
        Me.txtPounds.TabIndex = 1
        '
        'lstNames
        '
        Me.lstNames.FormattingEnabled = True
        Me.lstNames.Location = New System.Drawing.Point(12, 95)
        Me.lstNames.Name = "lstNames"
        Me.lstNames.Size = New System.Drawing.Size(120, 95)
        Me.lstNames.TabIndex = 2
        '
        'lstPounds
        '
        Me.lstPounds.FormattingEnabled = True
        Me.lstPounds.Location = New System.Drawing.Point(152, 95)
        Me.lstPounds.Name = "lstPounds"
        Me.lstPounds.Size = New System.Drawing.Size(120, 95)
        Me.lstPounds.TabIndex = 3
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(197, 213)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(75, 23)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAverage
        '
        Me.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverage.Location = New System.Drawing.Point(197, 259)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(75, 23)
        Me.lblAverage.TabIndex = 5
        Me.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(194, 12)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 60)
        Me.btnEnter.TabIndex = 6
        Me.btnEnter.Text = "Enter Name and Pounds"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(12, 213)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 69)
        Me.btnDisplay.TabIndex = 7
        Me.btnDisplay.Text = "Display Total and Average"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(37, 308)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(171, 308)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Pounds:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(120, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Total:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(120, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Average:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 344)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lstPounds)
        Me.Controls.Add(Me.lstNames)
        Me.Controls.Add(Me.txtPounds)
        Me.Controls.Add(Me.txtName)
        Me.Name = "Form1"
        Me.Text = "Aluminum Can Recycling"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPounds As TextBox
    Friend WithEvents lstNames As ListBox
    Friend WithEvents lstPounds As ListBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblAverage As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class

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
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtGallons = New System.Windows.Forms.TextBox()
        Me.txtMiles = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMPG = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(15, 75)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 40)
        Me.btnCalc.TabIndex = 0
        Me.btnCalc.Text = "Calculate MPG"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(96, 75)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 40)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(177, 75)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 40)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtGallons
        '
        Me.txtGallons.Location = New System.Drawing.Point(83, 3)
        Me.txtGallons.Name = "txtGallons"
        Me.txtGallons.Size = New System.Drawing.Size(169, 20)
        Me.txtGallons.TabIndex = 3
        '
        'txtMiles
        '
        Me.txtMiles.Location = New System.Drawing.Point(83, 26)
        Me.txtMiles.Name = "txtMiles"
        Me.txtMiles.Size = New System.Drawing.Size(169, 20)
        Me.txtMiles.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Gallons:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Miles:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "MPG:"
        '
        'lblMPG
        '
        Me.lblMPG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMPG.Location = New System.Drawing.Point(83, 49)
        Me.lblMPG.Name = "lblMPG"
        Me.lblMPG.Size = New System.Drawing.Size(169, 23)
        Me.lblMPG.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(266, 123)
        Me.Controls.Add(Me.lblMPG)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMiles)
        Me.Controls.Add(Me.txtGallons)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Name = "Form1"
        Me.Text = "Miles per Gallon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtGallons As TextBox
    Friend WithEvents txtMiles As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblMPG As Label
End Class

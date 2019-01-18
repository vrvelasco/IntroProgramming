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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radBranson = New System.Windows.Forms.RadioButton()
        Me.radChicago = New System.Windows.Forms.RadioButton()
        Me.radOrlando = New System.Windows.Forms.RadioButton()
        Me.chkCar = New System.Windows.Forms.CheckBox()
        Me.chkSuite = New System.Windows.Forms.CheckBox()
        Me.chkTickets = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDestination = New System.Windows.Forms.Label()
        Me.lblOption = New System.Windows.Forms.Label()
        Me.lblCash = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radBranson)
        Me.GroupBox1.Controls.Add(Me.radChicago)
        Me.GroupBox1.Controls.Add(Me.radOrlando)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(112, 94)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Destination"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkCar)
        Me.GroupBox2.Controls.Add(Me.chkSuite)
        Me.GroupBox2.Controls.Add(Me.chkTickets)
        Me.GroupBox2.Location = New System.Drawing.Point(130, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(145, 94)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Options"
        '
        'radBranson
        '
        Me.radBranson.AutoSize = True
        Me.radBranson.Checked = True
        Me.radBranson.Location = New System.Drawing.Point(6, 19)
        Me.radBranson.Name = "radBranson"
        Me.radBranson.Size = New System.Drawing.Size(103, 17)
        Me.radBranson.TabIndex = 1
        Me.radBranson.TabStop = True
        Me.radBranson.Text = "Branson ($1000)"
        Me.radBranson.UseVisualStyleBackColor = True
        '
        'radChicago
        '
        Me.radChicago.AutoSize = True
        Me.radChicago.Location = New System.Drawing.Point(6, 42)
        Me.radChicago.Name = "radChicago"
        Me.radChicago.Size = New System.Drawing.Size(103, 17)
        Me.radChicago.TabIndex = 2
        Me.radChicago.Text = "Chicago ($2000)"
        Me.radChicago.UseVisualStyleBackColor = True
        '
        'radOrlando
        '
        Me.radOrlando.AutoSize = True
        Me.radOrlando.Location = New System.Drawing.Point(6, 65)
        Me.radOrlando.Name = "radOrlando"
        Me.radOrlando.Size = New System.Drawing.Size(101, 17)
        Me.radOrlando.TabIndex = 3
        Me.radOrlando.Text = "Orlando ($3000)"
        Me.radOrlando.UseVisualStyleBackColor = True
        '
        'chkCar
        '
        Me.chkCar.AutoSize = True
        Me.chkCar.Location = New System.Drawing.Point(6, 19)
        Me.chkCar.Name = "chkCar"
        Me.chkCar.Size = New System.Drawing.Size(109, 17)
        Me.chkCar.TabIndex = 1
        Me.chkCar.Text = "Rental Car ($300)"
        Me.chkCar.UseVisualStyleBackColor = True
        '
        'chkSuite
        '
        Me.chkSuite.AutoSize = True
        Me.chkSuite.Location = New System.Drawing.Point(6, 42)
        Me.chkSuite.Name = "chkSuite"
        Me.chkSuite.Size = New System.Drawing.Size(117, 17)
        Me.chkSuite.TabIndex = 2
        Me.chkSuite.Text = "Luxury Suite ($200)"
        Me.chkSuite.UseVisualStyleBackColor = True
        '
        'chkTickets
        '
        Me.chkTickets.AutoSize = True
        Me.chkTickets.Location = New System.Drawing.Point(6, 65)
        Me.chkTickets.Name = "chkTickets"
        Me.chkTickets.Size = New System.Drawing.Size(134, 17)
        Me.chkTickets.TabIndex = 3
        Me.chkTickets.Text = "Theatre Tickets ($100)"
        Me.chkTickets.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Destination Cost:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Option Cost:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(211, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cash Amount:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(226, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Total Cost:"
        '
        'lblDestination
        '
        Me.lblDestination.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDestination.Location = New System.Drawing.Point(102, 121)
        Me.lblDestination.Name = "lblDestination"
        Me.lblDestination.Size = New System.Drawing.Size(100, 23)
        Me.lblDestination.TabIndex = 5
        '
        'lblOption
        '
        Me.lblOption.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOption.Location = New System.Drawing.Point(102, 150)
        Me.lblOption.Name = "lblOption"
        Me.lblOption.Size = New System.Drawing.Size(100, 23)
        Me.lblOption.TabIndex = 6
        '
        'lblCash
        '
        Me.lblCash.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCash.Location = New System.Drawing.Point(290, 121)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(100, 23)
        Me.lblCash.TabIndex = 7
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(290, 150)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 8
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(89, 190)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 9
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(170, 190)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(251, 190)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtCash
        '
        Me.txtCash.Location = New System.Drawing.Point(25, 68)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(78, 20)
        Me.txtCash.TabIndex = 12
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtCash)
        Me.GroupBox3.Location = New System.Drawing.Point(281, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(109, 94)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cash"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 43)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Enter an amount between $100 and $500."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "$"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 223)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblCash)
        Me.Controls.Add(Me.lblOption)
        Me.Controls.Add(Me.lblDestination)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Vacation Planner"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radBranson As RadioButton
    Friend WithEvents radChicago As RadioButton
    Friend WithEvents radOrlando As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkCar As CheckBox
    Friend WithEvents chkSuite As CheckBox
    Friend WithEvents chkTickets As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblDestination As Label
    Friend WithEvents lblOption As Label
    Friend WithEvents lblCash As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtCash As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class

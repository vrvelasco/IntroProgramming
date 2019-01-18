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
        Me.radMeatloaf = New System.Windows.Forms.RadioButton()
        Me.radCatfish = New System.Windows.Forms.RadioButton()
        Me.radSalad = New System.Windows.Forms.RadioButton()
        Me.chkFries = New System.Windows.Forms.CheckBox()
        Me.chkBeans = New System.Windows.Forms.CheckBox()
        Me.chkSlaw = New System.Windows.Forms.CheckBox()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radMeatloaf)
        Me.GroupBox1.Controls.Add(Me.radCatfish)
        Me.GroupBox1.Controls.Add(Me.radSalad)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(105, 88)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dinner Plate"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkFries)
        Me.GroupBox2.Controls.Add(Me.chkBeans)
        Me.GroupBox2.Controls.Add(Me.chkSlaw)
        Me.GroupBox2.Location = New System.Drawing.Point(131, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(129, 88)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Side Order"
        '
        'radMeatloaf
        '
        Me.radMeatloaf.AutoSize = True
        Me.radMeatloaf.Checked = True
        Me.radMeatloaf.Location = New System.Drawing.Point(6, 19)
        Me.radMeatloaf.Name = "radMeatloaf"
        Me.radMeatloaf.Size = New System.Drawing.Size(96, 17)
        Me.radMeatloaf.TabIndex = 1
        Me.radMeatloaf.TabStop = True
        Me.radMeatloaf.Text = "Meatloaf $5.00"
        Me.radMeatloaf.UseVisualStyleBackColor = True
        '
        'radCatfish
        '
        Me.radCatfish.AutoSize = True
        Me.radCatfish.Location = New System.Drawing.Point(6, 42)
        Me.radCatfish.Name = "radCatfish"
        Me.radCatfish.Size = New System.Drawing.Size(87, 17)
        Me.radCatfish.TabIndex = 2
        Me.radCatfish.Text = "Catfish $4.00"
        Me.radCatfish.UseVisualStyleBackColor = True
        '
        'radSalad
        '
        Me.radSalad.AutoSize = True
        Me.radSalad.Location = New System.Drawing.Point(6, 65)
        Me.radSalad.Name = "radSalad"
        Me.radSalad.Size = New System.Drawing.Size(82, 17)
        Me.radSalad.TabIndex = 3
        Me.radSalad.Text = "Salad $3.00"
        Me.radSalad.UseVisualStyleBackColor = True
        '
        'chkFries
        '
        Me.chkFries.AutoSize = True
        Me.chkFries.Location = New System.Drawing.Point(6, 19)
        Me.chkFries.Name = "chkFries"
        Me.chkFries.Size = New System.Drawing.Size(114, 17)
        Me.chkFries.TabIndex = 1
        Me.chkFries.Text = "French Fries $1.00"
        Me.chkFries.UseVisualStyleBackColor = True
        '
        'chkBeans
        '
        Me.chkBeans.AutoSize = True
        Me.chkBeans.Location = New System.Drawing.Point(6, 42)
        Me.chkBeans.Name = "chkBeans"
        Me.chkBeans.Size = New System.Drawing.Size(120, 17)
        Me.chkBeans.TabIndex = 2
        Me.chkBeans.Text = "Baked Beans $0.75"
        Me.chkBeans.UseVisualStyleBackColor = True
        '
        'chkSlaw
        '
        Me.chkSlaw.AutoSize = True
        Me.chkSlaw.Location = New System.Drawing.Point(6, 65)
        Me.chkSlaw.Name = "chkSlaw"
        Me.chkSlaw.Size = New System.Drawing.Size(98, 17)
        Me.chkSlaw.TabIndex = 3
        Me.chkSlaw.Text = "Coleslaw $0.50"
        Me.chkSlaw.UseVisualStyleBackColor = True
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(12, 106)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(75, 23)
        Me.btnOrder.TabIndex = 1
        Me.btnOrder.Text = "Place Order"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(99, 106)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(185, 106)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(96, 146)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(129, 23)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Total:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 176)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Radio Check Diner"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radMeatloaf As RadioButton
    Friend WithEvents radCatfish As RadioButton
    Friend WithEvents radSalad As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkFries As CheckBox
    Friend WithEvents chkBeans As CheckBox
    Friend WithEvents chkSlaw As CheckBox
    Friend WithEvents btnOrder As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label1 As Label
End Class

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
        Me.radAssociate = New System.Windows.Forms.RadioButton()
        Me.radBachelor = New System.Windows.Forms.RadioButton()
        Me.radMaster = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkDorm = New System.Windows.Forms.CheckBox()
        Me.chkMeal = New System.Windows.Forms.CheckBox()
        Me.chkHealth = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblAid = New System.Windows.Forms.Label()
        Me.lblPocket = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radMaster)
        Me.GroupBox1.Controls.Add(Me.radBachelor)
        Me.GroupBox1.Controls.Add(Me.radAssociate)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(177, 94)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Degree Program"
        '
        'radAssociate
        '
        Me.radAssociate.AutoSize = True
        Me.radAssociate.Checked = True
        Me.radAssociate.Location = New System.Drawing.Point(6, 19)
        Me.radAssociate.Name = "radAssociate"
        Me.radAssociate.Size = New System.Drawing.Size(165, 17)
        Me.radAssociate.TabIndex = 0
        Me.radAssociate.TabStop = True
        Me.radAssociate.Text = "Associate’s Degree ($10,000)"
        Me.radAssociate.UseVisualStyleBackColor = True
        '
        'radBachelor
        '
        Me.radBachelor.AutoSize = True
        Me.radBachelor.Location = New System.Drawing.Point(6, 42)
        Me.radBachelor.Name = "radBachelor"
        Me.radBachelor.Size = New System.Drawing.Size(161, 17)
        Me.radBachelor.TabIndex = 1
        Me.radBachelor.Text = "Bachelor’s Degree ($20,000)"
        Me.radBachelor.UseVisualStyleBackColor = True
        '
        'radMaster
        '
        Me.radMaster.AutoSize = True
        Me.radMaster.Location = New System.Drawing.Point(6, 65)
        Me.radMaster.Name = "radMaster"
        Me.radMaster.Size = New System.Drawing.Size(151, 17)
        Me.radMaster.TabIndex = 2
        Me.radMaster.Text = "Master’s Degree ($30,000)"
        Me.radMaster.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkDorm)
        Me.GroupBox2.Controls.Add(Me.chkMeal)
        Me.GroupBox2.Controls.Add(Me.chkHealth)
        Me.GroupBox2.Location = New System.Drawing.Point(195, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(156, 94)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Options"
        '
        'chkDorm
        '
        Me.chkDorm.AutoSize = True
        Me.chkDorm.Location = New System.Drawing.Point(6, 20)
        Me.chkDorm.Name = "chkDorm"
        Me.chkDorm.Size = New System.Drawing.Size(124, 17)
        Me.chkDorm.TabIndex = 2
        Me.chkDorm.Text = "Dorm Room ($3,000)"
        Me.chkDorm.UseVisualStyleBackColor = True
        '
        'chkMeal
        '
        Me.chkMeal.AutoSize = True
        Me.chkMeal.Location = New System.Drawing.Point(6, 43)
        Me.chkMeal.Name = "chkMeal"
        Me.chkMeal.Size = New System.Drawing.Size(115, 17)
        Me.chkMeal.TabIndex = 3
        Me.chkMeal.Text = "Meal Plan ($2,000)"
        Me.chkMeal.UseVisualStyleBackColor = True
        '
        'chkHealth
        '
        Me.chkHealth.AutoSize = True
        Me.chkHealth.Location = New System.Drawing.Point(6, 66)
        Me.chkHealth.Name = "chkHealth"
        Me.chkHealth.Size = New System.Drawing.Size(149, 17)
        Me.chkHealth.TabIndex = 4
        Me.chkHealth.Text = "Health Insurance ($1,000)"
        Me.chkHealth.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtAid)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(357, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(140, 94)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Financial Aid"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 43)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter the amount of financial aid between $1,000 and $25,000."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAid
        '
        Me.txtAid.Location = New System.Drawing.Point(25, 64)
        Me.txtAid.Name = "txtAid"
        Me.txtAid.Size = New System.Drawing.Size(100, 20)
        Me.txtAid.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "$"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(319, 118)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(319, 144)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(319, 174)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(163, 122)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 6
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAid
        '
        Me.lblAid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAid.Location = New System.Drawing.Point(163, 148)
        Me.lblAid.Name = "lblAid"
        Me.lblAid.Size = New System.Drawing.Size(100, 23)
        Me.lblAid.TabIndex = 7
        Me.lblAid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPocket
        '
        Me.lblPocket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPocket.Location = New System.Drawing.Point(163, 174)
        Me.lblPocket.Name = "lblPocket"
        Me.lblPocket.Size = New System.Drawing.Size(100, 23)
        Me.lblPocket.TabIndex = 8
        Me.lblPocket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(78, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 23)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Total Cost:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(81, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 23)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Financial Aid:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(78, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 23)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Out-of-Pocket:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 211)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblPocket)
        Me.Controls.Add(Me.lblAid)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "College Cost Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radMaster As RadioButton
    Friend WithEvents radBachelor As RadioButton
    Friend WithEvents radAssociate As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkDorm As CheckBox
    Friend WithEvents chkMeal As CheckBox
    Friend WithEvents chkHealth As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblAid As Label
    Friend WithEvents lblPocket As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class

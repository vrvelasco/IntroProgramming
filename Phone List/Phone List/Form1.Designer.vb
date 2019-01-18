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
        Me.lstSerial = New System.Windows.Forms.ListBox()
        Me.lstNames = New System.Windows.Forms.ListBox()
        Me.lstPhone = New System.Windows.Forms.ListBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstSerial
        '
        Me.lstSerial.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSerial.FormattingEnabled = True
        Me.lstSerial.ItemHeight = 18
        Me.lstSerial.Location = New System.Drawing.Point(12, 23)
        Me.lstSerial.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstSerial.Name = "lstSerial"
        Me.lstSerial.Size = New System.Drawing.Size(45, 130)
        Me.lstSerial.TabIndex = 111
        '
        'lstNames
        '
        Me.lstNames.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstNames.FormattingEnabled = True
        Me.lstNames.ItemHeight = 18
        Me.lstNames.Location = New System.Drawing.Point(63, 23)
        Me.lstNames.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstNames.Name = "lstNames"
        Me.lstNames.Size = New System.Drawing.Size(135, 130)
        Me.lstNames.TabIndex = 111
        '
        'lstPhone
        '
        Me.lstPhone.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPhone.FormattingEnabled = True
        Me.lstPhone.ItemHeight = 18
        Me.lstPhone.Location = New System.Drawing.Point(204, 23)
        Me.lstPhone.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstPhone.Name = "lstPhone"
        Me.lstPhone.Size = New System.Drawing.Size(135, 130)
        Me.lstPhone.TabIndex = 211
        '
        'btnEnter
        '
        Me.btnEnter.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Image = CType(resources.GetObject("btnEnter.Image"), System.Drawing.Image)
        Me.btnEnter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnter.Location = New System.Drawing.Point(345, 22)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(230, 40)
        Me.btnEnter.TabIndex = 0
        Me.btnEnter.Text = "Enter Name and Phone Number"
        Me.btnEnter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.Image = CType(resources.GetObject("btnDisplay.Image"), System.Drawing.Image)
        Me.btnDisplay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDisplay.Location = New System.Drawing.Point(345, 67)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(230, 40)
        Me.btnDisplay.TabIndex = 4
        Me.btnDisplay.Text = "Display Name and Phone Number"
        Me.btnDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.Location = New System.Drawing.Point(345, 113)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(110, 40)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "      Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(465, 113)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(110, 40)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "      Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 15)
        Me.Label1.TabIndex = 212
        Me.Label1.Text = "S/N"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(63, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 15)
        Me.Label2.TabIndex = 213
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(204, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 15)
        Me.Label3.TabIndex = 214
        Me.Label3.Text = "Phone Number"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 164)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lstPhone)
        Me.Controls.Add(Me.lstNames)
        Me.Controls.Add(Me.lstSerial)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Phone List"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstSerial As ListBox
    Friend WithEvents lstNames As ListBox
    Friend WithEvents lstPhone As ListBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class

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
        Me.picCalifornia = New System.Windows.Forms.PictureBox()
        Me.picIllinois = New System.Windows.Forms.PictureBox()
        Me.picMissouri = New System.Windows.Forms.PictureBox()
        Me.btnCalifornia = New System.Windows.Forms.Button()
        Me.btnIllinois = New System.Windows.Forms.Button()
        Me.btnMissouri = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.picCalifornia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picIllinois, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMissouri, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picCalifornia
        '
        Me.picCalifornia.Image = CType(resources.GetObject("picCalifornia.Image"), System.Drawing.Image)
        Me.picCalifornia.Location = New System.Drawing.Point(12, 12)
        Me.picCalifornia.Name = "picCalifornia"
        Me.picCalifornia.Size = New System.Drawing.Size(235, 105)
        Me.picCalifornia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCalifornia.TabIndex = 0
        Me.picCalifornia.TabStop = False
        Me.picCalifornia.Visible = False
        '
        'picIllinois
        '
        Me.picIllinois.Image = CType(resources.GetObject("picIllinois.Image"), System.Drawing.Image)
        Me.picIllinois.Location = New System.Drawing.Point(12, 12)
        Me.picIllinois.Name = "picIllinois"
        Me.picIllinois.Size = New System.Drawing.Size(235, 105)
        Me.picIllinois.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picIllinois.TabIndex = 1
        Me.picIllinois.TabStop = False
        Me.picIllinois.Visible = False
        '
        'picMissouri
        '
        Me.picMissouri.Image = CType(resources.GetObject("picMissouri.Image"), System.Drawing.Image)
        Me.picMissouri.Location = New System.Drawing.Point(12, 12)
        Me.picMissouri.Name = "picMissouri"
        Me.picMissouri.Size = New System.Drawing.Size(235, 105)
        Me.picMissouri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMissouri.TabIndex = 2
        Me.picMissouri.TabStop = False
        Me.picMissouri.Visible = False
        '
        'btnCalifornia
        '
        Me.btnCalifornia.Location = New System.Drawing.Point(12, 124)
        Me.btnCalifornia.Name = "btnCalifornia"
        Me.btnCalifornia.Size = New System.Drawing.Size(55, 25)
        Me.btnCalifornia.TabIndex = 3
        Me.btnCalifornia.Text = "CA"
        Me.btnCalifornia.UseVisualStyleBackColor = True
        '
        'btnIllinois
        '
        Me.btnIllinois.Location = New System.Drawing.Point(72, 124)
        Me.btnIllinois.Name = "btnIllinois"
        Me.btnIllinois.Size = New System.Drawing.Size(55, 25)
        Me.btnIllinois.TabIndex = 4
        Me.btnIllinois.Text = "IL"
        Me.btnIllinois.UseVisualStyleBackColor = True
        '
        'btnMissouri
        '
        Me.btnMissouri.Location = New System.Drawing.Point(133, 124)
        Me.btnMissouri.Name = "btnMissouri"
        Me.btnMissouri.Size = New System.Drawing.Size(55, 25)
        Me.btnMissouri.TabIndex = 5
        Me.btnMissouri.Text = "MO"
        Me.btnMissouri.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(192, 124)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(55, 25)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 158)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(259, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(259, 180)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnMissouri)
        Me.Controls.Add(Me.btnIllinois)
        Me.Controls.Add(Me.btnCalifornia)
        Me.Controls.Add(Me.picMissouri)
        Me.Controls.Add(Me.picIllinois)
        Me.Controls.Add(Me.picCalifornia)
        Me.Name = "Form1"
        Me.Text = "Three Pictures"
        CType(Me.picCalifornia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picIllinois, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMissouri, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picCalifornia As PictureBox
    Friend WithEvents picIllinois As PictureBox
    Friend WithEvents picMissouri As PictureBox
    Friend WithEvents btnCalifornia As Button
    Friend WithEvents btnIllinois As Button
    Friend WithEvents btnMissouri As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
End Class

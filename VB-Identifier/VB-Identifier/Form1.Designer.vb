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
        Me.picLion = New System.Windows.Forms.PictureBox()
        Me.picSnowLeopard = New System.Windows.Forms.PictureBox()
        Me.picTiger = New System.Windows.Forms.PictureBox()
        Me.lblGenre = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblSubject = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picLionSelected = New System.Windows.Forms.PictureBox()
        Me.picLeopardSelected = New System.Windows.Forms.PictureBox()
        Me.picTigerSelected = New System.Windows.Forms.PictureBox()
        CType(Me.picLion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSnowLeopard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTiger, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.picLionSelected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLeopardSelected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTigerSelected, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picLion
        '
        Me.picLion.Image = CType(resources.GetObject("picLion.Image"), System.Drawing.Image)
        Me.picLion.Location = New System.Drawing.Point(12, 12)
        Me.picLion.Name = "picLion"
        Me.picLion.Size = New System.Drawing.Size(315, 180)
        Me.picLion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLion.TabIndex = 0
        Me.picLion.TabStop = False
        '
        'picSnowLeopard
        '
        Me.picSnowLeopard.Image = CType(resources.GetObject("picSnowLeopard.Image"), System.Drawing.Image)
        Me.picSnowLeopard.Location = New System.Drawing.Point(333, 12)
        Me.picSnowLeopard.Name = "picSnowLeopard"
        Me.picSnowLeopard.Size = New System.Drawing.Size(315, 180)
        Me.picSnowLeopard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSnowLeopard.TabIndex = 1
        Me.picSnowLeopard.TabStop = False
        '
        'picTiger
        '
        Me.picTiger.Image = CType(resources.GetObject("picTiger.Image"), System.Drawing.Image)
        Me.picTiger.Location = New System.Drawing.Point(654, 12)
        Me.picTiger.Name = "picTiger"
        Me.picTiger.Size = New System.Drawing.Size(315, 180)
        Me.picTiger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTiger.TabIndex = 2
        Me.picTiger.TabStop = False
        '
        'lblGenre
        '
        Me.lblGenre.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGenre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenre.ForeColor = System.Drawing.Color.White
        Me.lblGenre.Location = New System.Drawing.Point(12, 198)
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(636, 23)
        Me.lblGenre.TabIndex = 3
        Me.lblGenre.Text = "Click on the images above"
        Me.lblGenre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblSubject})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 228)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(980, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblSubject
        '
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(0, 17)
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(654, 198)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(315, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picLionSelected
        '
        Me.picLionSelected.BackColor = System.Drawing.Color.Red
        Me.picLionSelected.Location = New System.Drawing.Point(9, 9)
        Me.picLionSelected.Name = "picLionSelected"
        Me.picLionSelected.Size = New System.Drawing.Size(321, 186)
        Me.picLionSelected.TabIndex = 6
        Me.picLionSelected.TabStop = False
        Me.picLionSelected.Visible = False
        '
        'picLeopardSelected
        '
        Me.picLeopardSelected.BackColor = System.Drawing.Color.Red
        Me.picLeopardSelected.Location = New System.Drawing.Point(330, 9)
        Me.picLeopardSelected.Name = "picLeopardSelected"
        Me.picLeopardSelected.Size = New System.Drawing.Size(321, 186)
        Me.picLeopardSelected.TabIndex = 7
        Me.picLeopardSelected.TabStop = False
        Me.picLeopardSelected.Visible = False
        '
        'picTigerSelected
        '
        Me.picTigerSelected.BackColor = System.Drawing.Color.Red
        Me.picTigerSelected.Location = New System.Drawing.Point(651, 9)
        Me.picTigerSelected.Name = "picTigerSelected"
        Me.picTigerSelected.Size = New System.Drawing.Size(321, 186)
        Me.picTigerSelected.TabIndex = 8
        Me.picTigerSelected.TabStop = False
        Me.picTigerSelected.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 250)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lblGenre)
        Me.Controls.Add(Me.picTiger)
        Me.Controls.Add(Me.picSnowLeopard)
        Me.Controls.Add(Me.picLion)
        Me.Controls.Add(Me.picLionSelected)
        Me.Controls.Add(Me.picLeopardSelected)
        Me.Controls.Add(Me.picTigerSelected)
        Me.Name = "Form1"
        Me.Text = "Identifier"
        CType(Me.picLion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSnowLeopard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTiger, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.picLionSelected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLeopardSelected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTigerSelected, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picLion As PictureBox
    Friend WithEvents picSnowLeopard As PictureBox
    Friend WithEvents picTiger As PictureBox
    Friend WithEvents lblGenre As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblSubject As ToolStripStatusLabel
    Friend WithEvents btnExit As Button
    Friend WithEvents picLionSelected As PictureBox
    Friend WithEvents picLeopardSelected As PictureBox
    Friend WithEvents picTigerSelected As PictureBox
End Class

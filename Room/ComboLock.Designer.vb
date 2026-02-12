<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComboLock
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
        pbBack = New PictureBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        lblNum1 = New Label()
        lblNum2 = New Label()
        lblNum3 = New Label()
        pbNum1Up = New PictureBox()
        pbNum2Up = New PictureBox()
        pbNum3Up = New PictureBox()
        pbNum1Down = New PictureBox()
        pbNum2Down = New PictureBox()
        pbNum3Down = New PictureBox()
        CType(pbBack, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbNum1Up, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbNum2Up, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbNum3Up, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbNum1Down, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbNum2Down, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbNum3Down, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbBack
        ' 
        pbBack.BackColor = Color.Transparent
        pbBack.Image = My.Resources.Resources.backwardarrow2
        pbBack.Location = New Point(21, 247)
        pbBack.Name = "pbBack"
        pbBack.Size = New Size(91, 116)
        pbBack.SizeMode = PictureBoxSizeMode.StretchImage
        pbBack.TabIndex = 0
        pbBack.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.squarelock
        PictureBox1.Location = New Point(178, 159)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(103, 106)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.squarelock
        PictureBox2.Location = New Point(341, 159)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(103, 106)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.squarelock
        PictureBox3.Location = New Point(509, 159)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(103, 106)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 3
        PictureBox3.TabStop = False
        ' 
        ' lblNum1
        ' 
        lblNum1.AutoSize = True
        lblNum1.BackColor = Color.DarkSalmon
        lblNum1.Font = New Font("SimSun-ExtB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNum1.Location = New Point(219, 202)
        lblNum1.Name = "lblNum1"
        lblNum1.Size = New Size(19, 19)
        lblNum1.TabIndex = 4
        lblNum1.Text = "0"
        ' 
        ' lblNum2
        ' 
        lblNum2.AutoSize = True
        lblNum2.BackColor = Color.DarkSalmon
        lblNum2.Font = New Font("SimSun-ExtB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNum2.Location = New Point(381, 202)
        lblNum2.Name = "lblNum2"
        lblNum2.Size = New Size(19, 19)
        lblNum2.TabIndex = 5
        lblNum2.Text = "0"
        ' 
        ' lblNum3
        ' 
        lblNum3.AutoSize = True
        lblNum3.BackColor = Color.DarkSalmon
        lblNum3.Font = New Font("SimSun-ExtB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNum3.Location = New Point(551, 202)
        lblNum3.Name = "lblNum3"
        lblNum3.Size = New Size(19, 19)
        lblNum3.TabIndex = 6
        lblNum3.Text = "0"
        ' 
        ' pbNum1Up
        ' 
        pbNum1Up.BackColor = Color.Transparent
        pbNum1Up.Image = My.Resources.Resources.comboarrowup
        pbNum1Up.Location = New Point(178, 52)
        pbNum1Up.Name = "pbNum1Up"
        pbNum1Up.Size = New Size(103, 101)
        pbNum1Up.SizeMode = PictureBoxSizeMode.StretchImage
        pbNum1Up.TabIndex = 7
        pbNum1Up.TabStop = False
        ' 
        ' pbNum2Up
        ' 
        pbNum2Up.BackColor = Color.Transparent
        pbNum2Up.Image = My.Resources.Resources.comboarrowup
        pbNum2Up.Location = New Point(341, 52)
        pbNum2Up.Name = "pbNum2Up"
        pbNum2Up.Size = New Size(103, 101)
        pbNum2Up.SizeMode = PictureBoxSizeMode.StretchImage
        pbNum2Up.TabIndex = 8
        pbNum2Up.TabStop = False
        ' 
        ' pbNum3Up
        ' 
        pbNum3Up.BackColor = Color.Transparent
        pbNum3Up.Image = My.Resources.Resources.comboarrowup
        pbNum3Up.Location = New Point(509, 52)
        pbNum3Up.Name = "pbNum3Up"
        pbNum3Up.Size = New Size(103, 101)
        pbNum3Up.SizeMode = PictureBoxSizeMode.StretchImage
        pbNum3Up.TabIndex = 9
        pbNum3Up.TabStop = False
        ' 
        ' pbNum1Down
        ' 
        pbNum1Down.BackColor = Color.Transparent
        pbNum1Down.Image = My.Resources.Resources.comboarrowdown
        pbNum1Down.Location = New Point(178, 271)
        pbNum1Down.Name = "pbNum1Down"
        pbNum1Down.Size = New Size(103, 101)
        pbNum1Down.SizeMode = PictureBoxSizeMode.StretchImage
        pbNum1Down.TabIndex = 10
        pbNum1Down.TabStop = False
        ' 
        ' pbNum2Down
        ' 
        pbNum2Down.BackColor = Color.Transparent
        pbNum2Down.Image = My.Resources.Resources.comboarrowdown
        pbNum2Down.Location = New Point(341, 271)
        pbNum2Down.Name = "pbNum2Down"
        pbNum2Down.Size = New Size(103, 101)
        pbNum2Down.SizeMode = PictureBoxSizeMode.StretchImage
        pbNum2Down.TabIndex = 11
        pbNum2Down.TabStop = False
        ' 
        ' pbNum3Down
        ' 
        pbNum3Down.BackColor = Color.Transparent
        pbNum3Down.Image = My.Resources.Resources.comboarrowdown
        pbNum3Down.Location = New Point(509, 271)
        pbNum3Down.Name = "pbNum3Down"
        pbNum3Down.Size = New Size(103, 101)
        pbNum3Down.SizeMode = PictureBoxSizeMode.StretchImage
        pbNum3Down.TabIndex = 12
        pbNum3Down.TabStop = False
        ' 
        ' frmComboLock
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDarkDark
        BackgroundImage = My.Resources.Resources.LockedClosetCloseUp
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(738, 438)
        Controls.Add(pbNum3Down)
        Controls.Add(pbNum2Down)
        Controls.Add(pbNum1Down)
        Controls.Add(pbNum3Up)
        Controls.Add(pbNum2Up)
        Controls.Add(pbNum1Up)
        Controls.Add(lblNum3)
        Controls.Add(lblNum2)
        Controls.Add(lblNum1)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(pbBack)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "frmComboLock"
        CType(pbBack, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(pbNum1Up, ComponentModel.ISupportInitialize).EndInit()
        CType(pbNum2Up, ComponentModel.ISupportInitialize).EndInit()
        CType(pbNum3Up, ComponentModel.ISupportInitialize).EndInit()
        CType(pbNum1Down, ComponentModel.ISupportInitialize).EndInit()
        CType(pbNum2Down, ComponentModel.ISupportInitialize).EndInit()
        CType(pbNum3Down, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbBack As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblNum1 As Label
    Friend WithEvents lblNum2 As Label
    Friend WithEvents lblNum3 As Label
    Friend WithEvents pbNum1Up As PictureBox
    Friend WithEvents pbNum2Up As PictureBox
    Friend WithEvents pbNum3Up As PictureBox
    Friend WithEvents pbNum1Down As PictureBox
    Friend WithEvents pbNum2Down As PictureBox
    Friend WithEvents pbNum3Down As PictureBox
End Class

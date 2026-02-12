<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoom
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
        components = New ComponentModel.Container()
        pbLeftArrow = New PictureBox()
        pbRightArrow = New PictureBox()
        lblVase = New Label()
        lblCloset = New Label()
        lblComputer = New Label()
        lblBook = New Label()
        pbBackArrow = New PictureBox()
        Timer1 = New Timer(components)
        lblTip = New Label()
        timerTip = New Timer(components)
        CType(pbLeftArrow, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbRightArrow, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbBackArrow, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbLeftArrow
        ' 
        pbLeftArrow.BackColor = Color.Transparent
        pbLeftArrow.Image = My.Resources.Resources.leftarrow2
        pbLeftArrow.Location = New Point(12, 113)
        pbLeftArrow.Name = "pbLeftArrow"
        pbLeftArrow.Size = New Size(133, 97)
        pbLeftArrow.SizeMode = PictureBoxSizeMode.StretchImage
        pbLeftArrow.TabIndex = 0
        pbLeftArrow.TabStop = False
        ' 
        ' pbRightArrow
        ' 
        pbRightArrow.BackColor = Color.Transparent
        pbRightArrow.Image = My.Resources.Resources.rightarrow2
        pbRightArrow.Location = New Point(655, 113)
        pbRightArrow.Name = "pbRightArrow"
        pbRightArrow.Size = New Size(133, 97)
        pbRightArrow.SizeMode = PictureBoxSizeMode.StretchImage
        pbRightArrow.TabIndex = 1
        pbRightArrow.TabStop = False
        ' 
        ' lblVase
        ' 
        lblVase.BackColor = Color.Transparent
        lblVase.Cursor = Cursors.Help
        lblVase.Location = New Point(26, 271)
        lblVase.Name = "lblVase"
        lblVase.Size = New Size(207, 170)
        lblVase.TabIndex = 2
        ' 
        ' lblCloset
        ' 
        lblCloset.BackColor = Color.Transparent
        lblCloset.Cursor = Cursors.Help
        lblCloset.Location = New Point(321, 124)
        lblCloset.Name = "lblCloset"
        lblCloset.Size = New Size(162, 169)
        lblCloset.TabIndex = 3
        ' 
        ' lblComputer
        ' 
        lblComputer.BackColor = Color.Transparent
        lblComputer.Cursor = Cursors.Help
        lblComputer.Location = New Point(272, 9)
        lblComputer.Name = "lblComputer"
        lblComputer.Size = New Size(157, 227)
        lblComputer.TabIndex = 4
        ' 
        ' lblBook
        ' 
        lblBook.BackColor = Color.Transparent
        lblBook.Cursor = Cursors.Help
        lblBook.Location = New Point(542, 178)
        lblBook.Name = "lblBook"
        lblBook.Size = New Size(107, 58)
        lblBook.TabIndex = 5
        ' 
        ' pbBackArrow
        ' 
        pbBackArrow.BackColor = Color.Transparent
        pbBackArrow.Image = My.Resources.Resources.backwardarrow2
        pbBackArrow.Location = New Point(359, 327)
        pbBackArrow.Name = "pbBackArrow"
        pbBackArrow.Size = New Size(70, 111)
        pbBackArrow.SizeMode = PictureBoxSizeMode.StretchImage
        pbBackArrow.TabIndex = 6
        pbBackArrow.TabStop = False
        pbBackArrow.Visible = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' lblTip
        ' 
        lblTip.BackColor = Color.Transparent
        lblTip.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTip.ForeColor = Color.Red
        lblTip.Location = New Point(655, 7)
        lblTip.Name = "lblTip"
        lblTip.Size = New Size(126, 73)
        lblTip.TabIndex = 7
        lblTip.Text = "You can press Q to quit the game (while inside this room)."
        ' 
        ' timerTip
        ' 
        timerTip.Enabled = True
        timerTip.Interval = 1000
        ' 
        ' frmRoom
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDarkDark
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(lblTip)
        Controls.Add(pbBackArrow)
        Controls.Add(lblBook)
        Controls.Add(lblComputer)
        Controls.Add(lblCloset)
        Controls.Add(lblVase)
        Controls.Add(pbRightArrow)
        Controls.Add(pbLeftArrow)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmRoom"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Room"
        CType(pbLeftArrow, ComponentModel.ISupportInitialize).EndInit()
        CType(pbRightArrow, ComponentModel.ISupportInitialize).EndInit()
        CType(pbBackArrow, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pbLeftArrow As PictureBox
    Friend WithEvents pbRightArrow As PictureBox
    Friend WithEvents lblVase As Label
    Friend WithEvents lblCloset As Label
    Friend WithEvents lblComputer As Label
    Friend WithEvents lblBook As Label
    Friend WithEvents pbBackArrow As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblTip As Label
    Friend WithEvents timerTip As Timer
End Class

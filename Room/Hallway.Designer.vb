<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHallway
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
        pbForwardArrow = New PictureBox()
        pbRightArrow = New PictureBox()
        pbBackArrow = New PictureBox()
        pbLeftArrow = New PictureBox()
        timerSecret = New Timer(components)
        lblClosetSecret = New Label()
        CType(pbForwardArrow, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbRightArrow, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbBackArrow, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbLeftArrow, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbForwardArrow
        ' 
        pbForwardArrow.BackColor = Color.Transparent
        pbForwardArrow.Image = My.Resources.Resources.uparrow2
        pbForwardArrow.Location = New Point(347, 12)
        pbForwardArrow.Name = "pbForwardArrow"
        pbForwardArrow.Size = New Size(86, 131)
        pbForwardArrow.SizeMode = PictureBoxSizeMode.StretchImage
        pbForwardArrow.TabIndex = 0
        pbForwardArrow.TabStop = False
        ' 
        ' pbRightArrow
        ' 
        pbRightArrow.BackColor = Color.Transparent
        pbRightArrow.Image = My.Resources.Resources.rightarrow21
        pbRightArrow.Location = New Point(657, 183)
        pbRightArrow.Name = "pbRightArrow"
        pbRightArrow.Size = New Size(131, 76)
        pbRightArrow.SizeMode = PictureBoxSizeMode.StretchImage
        pbRightArrow.TabIndex = 1
        pbRightArrow.TabStop = False
        ' 
        ' pbBackArrow
        ' 
        pbBackArrow.BackColor = Color.Transparent
        pbBackArrow.Image = My.Resources.Resources.backwardarrow2
        pbBackArrow.Location = New Point(347, 307)
        pbBackArrow.Name = "pbBackArrow"
        pbBackArrow.Size = New Size(86, 131)
        pbBackArrow.SizeMode = PictureBoxSizeMode.StretchImage
        pbBackArrow.TabIndex = 2
        pbBackArrow.TabStop = False
        ' 
        ' pbLeftArrow
        ' 
        pbLeftArrow.BackColor = Color.Transparent
        pbLeftArrow.Image = My.Resources.Resources.leftarrow2
        pbLeftArrow.Location = New Point(12, 183)
        pbLeftArrow.Name = "pbLeftArrow"
        pbLeftArrow.Size = New Size(131, 76)
        pbLeftArrow.SizeMode = PictureBoxSizeMode.StretchImage
        pbLeftArrow.TabIndex = 3
        pbLeftArrow.TabStop = False
        ' 
        ' timerSecret
        ' 
        timerSecret.Interval = 1000
        ' 
        ' lblClosetSecret
        ' 
        lblClosetSecret.BackColor = Color.Transparent
        lblClosetSecret.Location = New Point(253, 156)
        lblClosetSecret.Name = "lblClosetSecret"
        lblClosetSecret.Size = New Size(65, 115)
        lblClosetSecret.TabIndex = 4
        ' 
        ' frmHallway
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDarkDark
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(lblClosetSecret)
        Controls.Add(pbLeftArrow)
        Controls.Add(pbBackArrow)
        Controls.Add(pbRightArrow)
        Controls.Add(pbForwardArrow)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmHallway"
        Text = "Hallway"
        CType(pbForwardArrow, ComponentModel.ISupportInitialize).EndInit()
        CType(pbRightArrow, ComponentModel.ISupportInitialize).EndInit()
        CType(pbBackArrow, ComponentModel.ISupportInitialize).EndInit()
        CType(pbLeftArrow, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pbForwardArrow As PictureBox
    Friend WithEvents pbRightArrow As PictureBox
    Friend WithEvents pbBackArrow As PictureBox
    Friend WithEvents pbLeftArrow As PictureBox
    Friend WithEvents timerSecret As Timer
    Friend WithEvents lblClosetSecret As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEscape
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
        pbLeft = New PictureBox()
        pbForward = New PictureBox()
        pbRight = New PictureBox()
        pbBackward = New PictureBox()
        Timer = New Timer(components)
        pbHide = New PictureBox()
        timerRegret = New Timer(components)
        timerEnd = New Timer(components)
        CType(pbLeft, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbForward, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbRight, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbBackward, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbHide, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbLeft
        ' 
        pbLeft.BackColor = Color.Transparent
        pbLeft.Image = My.Resources.Resources.leftarrow2
        pbLeft.Location = New Point(12, 248)
        pbLeft.Name = "pbLeft"
        pbLeft.Size = New Size(143, 77)
        pbLeft.SizeMode = PictureBoxSizeMode.StretchImage
        pbLeft.TabIndex = 0
        pbLeft.TabStop = False
        ' 
        ' pbForward
        ' 
        pbForward.BackColor = Color.Transparent
        pbForward.Image = My.Resources.Resources.uparrow2
        pbForward.Location = New Point(352, 12)
        pbForward.Name = "pbForward"
        pbForward.Size = New Size(95, 128)
        pbForward.SizeMode = PictureBoxSizeMode.StretchImage
        pbForward.TabIndex = 1
        pbForward.TabStop = False
        ' 
        ' pbRight
        ' 
        pbRight.BackColor = Color.Transparent
        pbRight.Image = My.Resources.Resources.rightarrow2
        pbRight.Location = New Point(649, 248)
        pbRight.Name = "pbRight"
        pbRight.Size = New Size(139, 77)
        pbRight.SizeMode = PictureBoxSizeMode.StretchImage
        pbRight.TabIndex = 2
        pbRight.TabStop = False
        ' 
        ' pbBackward
        ' 
        pbBackward.BackColor = Color.Transparent
        pbBackward.Image = My.Resources.Resources.backwardarrow2
        pbBackward.Location = New Point(352, 317)
        pbBackward.Name = "pbBackward"
        pbBackward.Size = New Size(95, 121)
        pbBackward.SizeMode = PictureBoxSizeMode.StretchImage
        pbBackward.TabIndex = 3
        pbBackward.TabStop = False
        ' 
        ' Timer
        ' 
        Timer.Enabled = True
        Timer.Interval = 1000
        ' 
        ' pbHide
        ' 
        pbHide.BackColor = Color.Transparent
        pbHide.Image = My.Resources.Resources.hide_arrow
        pbHide.Location = New Point(649, 148)
        pbHide.Name = "pbHide"
        pbHide.Size = New Size(139, 94)
        pbHide.SizeMode = PictureBoxSizeMode.StretchImage
        pbHide.TabIndex = 4
        pbHide.TabStop = False
        ' 
        ' timerRegret
        ' 
        timerRegret.Interval = 1000
        ' 
        ' timerEnd
        ' 
        timerEnd.Interval = 1000
        ' 
        ' frmEscape
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(pbHide)
        Controls.Add(pbBackward)
        Controls.Add(pbRight)
        Controls.Add(pbForward)
        Controls.Add(pbLeft)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmEscape"
        Text = "Escape"
        CType(pbLeft, ComponentModel.ISupportInitialize).EndInit()
        CType(pbForward, ComponentModel.ISupportInitialize).EndInit()
        CType(pbRight, ComponentModel.ISupportInitialize).EndInit()
        CType(pbBackward, ComponentModel.ISupportInitialize).EndInit()
        CType(pbHide, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pbLeft As PictureBox
    Friend WithEvents pbForward As PictureBox
    Friend WithEvents pbRight As PictureBox
    Friend WithEvents pbBackward As PictureBox
    Friend WithEvents Timer As Timer
    Friend WithEvents pbHide As PictureBox
    Friend WithEvents timerRegret As Timer
    Friend WithEvents timerEnd As Timer
End Class

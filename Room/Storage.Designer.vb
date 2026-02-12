<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStorage
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
        pbForward = New PictureBox()
        pbBack = New PictureBox()
        timerEncounter = New Timer(components)
        CType(pbForward, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbBack, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbForward
        ' 
        pbForward.BackColor = Color.Transparent
        pbForward.Image = My.Resources.Resources.uparrow2
        pbForward.Location = New Point(347, 12)
        pbForward.Name = "pbForward"
        pbForward.Size = New Size(82, 137)
        pbForward.SizeMode = PictureBoxSizeMode.StretchImage
        pbForward.TabIndex = 0
        pbForward.TabStop = False
        ' 
        ' pbBack
        ' 
        pbBack.BackColor = Color.Transparent
        pbBack.Image = My.Resources.Resources.backwardarrow2
        pbBack.Location = New Point(347, 301)
        pbBack.Name = "pbBack"
        pbBack.Size = New Size(82, 137)
        pbBack.SizeMode = PictureBoxSizeMode.StretchImage
        pbBack.TabIndex = 1
        pbBack.TabStop = False
        pbBack.Visible = False
        ' 
        ' timerEncounter
        ' 
        timerEncounter.Interval = 1000
        ' 
        ' frmStorage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDarkDark
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(pbBack)
        Controls.Add(pbForward)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmStorage"
        Text = "Storage"
        CType(pbForward, ComponentModel.ISupportInitialize).EndInit()
        CType(pbBack, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pbForward As PictureBox
    Friend WithEvents pbBack As PictureBox
    Friend WithEvents timerEncounter As Timer
End Class

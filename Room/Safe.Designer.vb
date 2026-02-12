<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSafe
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
        pbUp = New PictureBox()
        pbDown = New PictureBox()
        pbSafeBox = New PictureBox()
        lblNum = New Label()
        pbBack = New PictureBox()
        timerUnlock = New Timer(components)
        CType(pbUp, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbDown, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbSafeBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbBack, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbUp
        ' 
        pbUp.BackColor = Color.Transparent
        pbUp.Image = My.Resources.Resources.arrowlockup
        pbUp.Location = New Point(334, 12)
        pbUp.Name = "pbUp"
        pbUp.Size = New Size(108, 129)
        pbUp.SizeMode = PictureBoxSizeMode.StretchImage
        pbUp.TabIndex = 0
        pbUp.TabStop = False
        ' 
        ' pbDown
        ' 
        pbDown.BackColor = Color.Transparent
        pbDown.Image = My.Resources.Resources.arrowlockdown
        pbDown.Location = New Point(334, 309)
        pbDown.Name = "pbDown"
        pbDown.Size = New Size(108, 129)
        pbDown.SizeMode = PictureBoxSizeMode.StretchImage
        pbDown.TabIndex = 1
        pbDown.TabStop = False
        ' 
        ' pbSafeBox
        ' 
        pbSafeBox.BackColor = Color.Transparent
        pbSafeBox.Image = My.Resources.Resources.squarelock
        pbSafeBox.Location = New Point(334, 176)
        pbSafeBox.Name = "pbSafeBox"
        pbSafeBox.Size = New Size(108, 98)
        pbSafeBox.SizeMode = PictureBoxSizeMode.StretchImage
        pbSafeBox.TabIndex = 2
        pbSafeBox.TabStop = False
        ' 
        ' lblNum
        ' 
        lblNum.AutoSize = True
        lblNum.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        lblNum.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNum.Location = New Point(380, 213)
        lblNum.Name = "lblNum"
        lblNum.Size = New Size(0, 19)
        lblNum.TabIndex = 3
        ' 
        ' pbBack
        ' 
        pbBack.BackColor = Color.Transparent
        pbBack.Image = My.Resources.Resources.backwardarrow2
        pbBack.Location = New Point(12, 324)
        pbBack.Name = "pbBack"
        pbBack.Size = New Size(80, 114)
        pbBack.SizeMode = PictureBoxSizeMode.StretchImage
        pbBack.TabIndex = 4
        pbBack.TabStop = False
        ' 
        ' timerUnlock
        ' 
        timerUnlock.Interval = 1000
        ' 
        ' frmSafe
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(pbBack)
        Controls.Add(lblNum)
        Controls.Add(pbSafeBox)
        Controls.Add(pbDown)
        Controls.Add(pbUp)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmSafe"
        Text = "Safe"
        CType(pbUp, ComponentModel.ISupportInitialize).EndInit()
        CType(pbDown, ComponentModel.ISupportInitialize).EndInit()
        CType(pbSafeBox, ComponentModel.ISupportInitialize).EndInit()
        CType(pbBack, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbUp As PictureBox
    Friend WithEvents pbDown As PictureBox
    Friend WithEvents pbSafeBox As PictureBox
    Friend WithEvents lblNum As Label
    Friend WithEvents pbBack As PictureBox
    Friend WithEvents timerUnlock As Timer
End Class

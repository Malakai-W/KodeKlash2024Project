<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStart
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        lblStart = New Label()
        lblQuit = New Label()
        pbManInBackground = New PictureBox()
        CType(pbManInBackground, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Label1.Location = New Point(345, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 36)
        Label1.TabIndex = 0
        Label1.Text = "Rooms"
        ' 
        ' lblStart
        ' 
        lblStart.AutoSize = True
        lblStart.BackColor = Color.Transparent
        lblStart.BorderStyle = BorderStyle.FixedSingle
        lblStart.Font = New Font("Tempus Sans ITC", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStart.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        lblStart.Location = New Point(359, 315)
        lblStart.Name = "lblStart"
        lblStart.Size = New Size(72, 37)
        lblStart.TabIndex = 1
        lblStart.Text = "Start"
        ' 
        ' lblQuit
        ' 
        lblQuit.AutoSize = True
        lblQuit.BackColor = Color.Transparent
        lblQuit.BorderStyle = BorderStyle.FixedSingle
        lblQuit.Font = New Font("Tempus Sans ITC", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblQuit.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        lblQuit.Location = New Point(358, 389)
        lblQuit.Name = "lblQuit"
        lblQuit.Size = New Size(73, 37)
        lblQuit.TabIndex = 2
        lblQuit.Text = "Quit"
        ' 
        ' pbManInBackground
        ' 
        pbManInBackground.BackColor = Color.Transparent
        pbManInBackground.Image = My.Resources.Resources.shadow2
        pbManInBackground.Location = New Point(739, 294)
        pbManInBackground.Name = "pbManInBackground"
        pbManInBackground.Size = New Size(49, 90)
        pbManInBackground.SizeMode = PictureBoxSizeMode.StretchImage
        pbManInBackground.TabIndex = 3
        pbManInBackground.TabStop = False
        pbManInBackground.Visible = False
        ' 
        ' frmStart
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.menubackground
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(pbManInBackground)
        Controls.Add(lblQuit)
        Controls.Add(lblStart)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmStart"
        Text = "Start"
        CType(pbManInBackground, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblStart As Label
    Friend WithEvents lblQuit As Label
    Friend WithEvents pbManInBackground As PictureBox

End Class

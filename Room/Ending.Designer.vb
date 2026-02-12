<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnding
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
        lblRestart = New Label()
        lblQuit = New Label()
        SuspendLayout()
        ' 
        ' lblRestart
        ' 
        lblRestart.AutoSize = True
        lblRestart.BackColor = Color.Transparent
        lblRestart.BorderStyle = BorderStyle.FixedSingle
        lblRestart.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRestart.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        lblRestart.Location = New Point(253, 407)
        lblRestart.Name = "lblRestart"
        lblRestart.Size = New Size(73, 24)
        lblRestart.TabIndex = 0
        lblRestart.Text = "Restart"
        ' 
        ' lblQuit
        ' 
        lblQuit.AutoSize = True
        lblQuit.BackColor = Color.Transparent
        lblQuit.BorderStyle = BorderStyle.FixedSingle
        lblQuit.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblQuit.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        lblQuit.Location = New Point(461, 407)
        lblQuit.Name = "lblQuit"
        lblQuit.Size = New Size(48, 24)
        lblQuit.TabIndex = 1
        lblQuit.Text = "Quit"
        ' 
        ' frmEnding
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        BackgroundImage = My.Resources.Resources.ending2
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(lblQuit)
        Controls.Add(lblRestart)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmEnding"
        Text = "Ending"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblRestart As Label
    Friend WithEvents lblQuit As Label
End Class

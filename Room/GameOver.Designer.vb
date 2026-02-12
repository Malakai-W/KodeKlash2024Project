<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGameOver
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
        Label1 = New Label()
        lblYes = New Label()
        lblNo = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Tempus Sans ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Label1.Location = New Point(440, 237)
        Label1.Name = "Label1"
        Label1.Size = New Size(131, 31)
        Label1.TabIndex = 0
        Label1.Text = "Try Again?"
        ' 
        ' lblYes
        ' 
        lblYes.AutoSize = True
        lblYes.BackColor = Color.Transparent
        lblYes.BorderStyle = BorderStyle.FixedSingle
        lblYes.Font = New Font("Tempus Sans ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblYes.ForeColor = Color.Maroon
        lblYes.Location = New Point(482, 289)
        lblYes.Name = "lblYes"
        lblYes.Size = New Size(46, 29)
        lblYes.TabIndex = 1
        lblYes.Text = "Yes"
        ' 
        ' lblNo
        ' 
        lblNo.AutoSize = True
        lblNo.BackColor = Color.Transparent
        lblNo.BorderStyle = BorderStyle.FixedSingle
        lblNo.Font = New Font("Tempus Sans ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNo.ForeColor = Color.Maroon
        lblNo.Location = New Point(483, 372)
        lblNo.Name = "lblNo"
        lblNo.Size = New Size(45, 29)
        lblNo.TabIndex = 2
        lblNo.Text = "No"
        ' 
        ' frmGameOver
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.youtried
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1215, 702)
        Controls.Add(lblNo)
        Controls.Add(lblYes)
        Controls.Add(Label1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "frmGameOver"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblYes As Label
    Friend WithEvents lblNo As Label
End Class

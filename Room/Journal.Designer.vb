<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJournal
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
        pbArrow = New PictureBox()
        pbArrowExit = New PictureBox()
        lblJournal = New Label()
        CType(pbArrow, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbArrowExit, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbArrow
        ' 
        pbArrow.BackColor = Color.Transparent
        pbArrow.Image = My.Resources.Resources.bookarrow
        pbArrow.Location = New Point(269, 380)
        pbArrow.Name = "pbArrow"
        pbArrow.Size = New Size(117, 113)
        pbArrow.SizeMode = PictureBoxSizeMode.StretchImage
        pbArrow.TabIndex = 0
        pbArrow.TabStop = False
        ' 
        ' pbArrowExit
        ' 
        pbArrowExit.BackColor = Color.Transparent
        pbArrowExit.Image = My.Resources.Resources.comboarrowdown
        pbArrowExit.Location = New Point(12, 373)
        pbArrowExit.Name = "pbArrowExit"
        pbArrowExit.Size = New Size(100, 120)
        pbArrowExit.SizeMode = PictureBoxSizeMode.StretchImage
        pbArrowExit.TabIndex = 1
        pbArrowExit.TabStop = False
        ' 
        ' lblJournal
        ' 
        lblJournal.BackColor = Color.Transparent
        lblJournal.Font = New Font("Ink Free", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJournal.Location = New Point(24, 23)
        lblJournal.Name = "lblJournal"
        lblJournal.Size = New Size(327, 347)
        lblJournal.TabIndex = 2
        ' 
        ' frmJournal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.paper
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(374, 488)
        Controls.Add(lblJournal)
        Controls.Add(pbArrowExit)
        Controls.Add(pbArrow)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmJournal"
        CType(pbArrow, ComponentModel.ISupportInitialize).EndInit()
        CType(pbArrowExit, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pbArrow As PictureBox
    Friend WithEvents pbArrowExit As PictureBox
    Friend WithEvents lblJournal As Label
End Class

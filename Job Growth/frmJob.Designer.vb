<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmJob
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        pnlDetails = New Panel()
        lblDisplayChanges = New Label()
        lblDisplay2022 = New Label()
        lblDisplay2018 = New Label()
        lblChanges = New Label()
        lbl2022 = New Label()
        lbl2018 = New Label()
        lstJobTitles = New ListBox()
        lblJobTitle = New Label()
        lblHeading = New Label()
        mnuAction = New MenuStrip()
        ActionToolStripMenuItem = New ToolStripMenuItem()
        mnuDisplay = New ToolStripMenuItem()
        mnuClear = New ToolStripMenuItem()
        mnuExit = New ToolStripMenuItem()
        pnlDetails.SuspendLayout()
        mnuAction.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlDetails
        ' 
        pnlDetails.BackColor = Color.Transparent
        pnlDetails.Controls.Add(lblDisplayChanges)
        pnlDetails.Controls.Add(lblDisplay2022)
        pnlDetails.Controls.Add(lblDisplay2018)
        pnlDetails.Controls.Add(lblChanges)
        pnlDetails.Controls.Add(lbl2022)
        pnlDetails.Controls.Add(lbl2018)
        pnlDetails.Controls.Add(lstJobTitles)
        pnlDetails.Controls.Add(lblJobTitle)
        pnlDetails.Controls.Add(lblHeading)
        pnlDetails.Dock = DockStyle.Left
        pnlDetails.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        pnlDetails.Location = New Point(0, 26)
        pnlDetails.Name = "pnlDetails"
        pnlDetails.Size = New Size(441, 424)
        pnlDetails.TabIndex = 0
        ' 
        ' lblDisplayChanges
        ' 
        lblDisplayChanges.AutoSize = True
        lblDisplayChanges.Font = New Font("Verdana", 15.75F, FontStyle.Bold)
        lblDisplayChanges.ForeColor = Color.Gray
        lblDisplayChanges.Location = New Point(328, 402)
        lblDisplayChanges.Name = "lblDisplayChanges"
        lblDisplayChanges.Size = New Size(92, 25)
        lblDisplayChanges.TabIndex = 9
        lblDisplayChanges.Text = "XXXXX"
        ' 
        ' lblDisplay2022
        ' 
        lblDisplay2022.AutoSize = True
        lblDisplay2022.Font = New Font("Verdana", 15.75F, FontStyle.Bold)
        lblDisplay2022.ForeColor = Color.Gray
        lblDisplay2022.Location = New Point(328, 347)
        lblDisplay2022.Name = "lblDisplay2022"
        lblDisplay2022.Size = New Size(92, 25)
        lblDisplay2022.TabIndex = 8
        lblDisplay2022.Text = "XXXXX"
        ' 
        ' lblDisplay2018
        ' 
        lblDisplay2018.AutoSize = True
        lblDisplay2018.Font = New Font("Verdana", 15.75F, FontStyle.Bold)
        lblDisplay2018.ForeColor = Color.Gray
        lblDisplay2018.Location = New Point(328, 287)
        lblDisplay2018.Name = "lblDisplay2018"
        lblDisplay2018.Size = New Size(92, 25)
        lblDisplay2018.TabIndex = 7
        lblDisplay2018.Text = "XXXXX"
        ' 
        ' lblChanges
        ' 
        lblChanges.AutoSize = True
        lblChanges.Font = New Font("Verdana", 15.75F, FontStyle.Bold)
        lblChanges.ForeColor = Color.AliceBlue
        lblChanges.Location = New Point(12, 402)
        lblChanges.Name = "lblChanges"
        lblChanges.Size = New Size(310, 25)
        lblChanges.TabIndex = 6
        lblChanges.Text = "Changes in Job Numbers:"
        ' 
        ' lbl2022
        ' 
        lbl2022.AutoSize = True
        lbl2022.Font = New Font("Verdana", 15.75F, FontStyle.Bold)
        lbl2022.ForeColor = Color.AliceBlue
        lbl2022.Location = New Point(12, 347)
        lbl2022.Name = "lbl2022"
        lbl2022.Size = New Size(288, 25)
        lbl2022.TabIndex = 5
        lbl2022.Text = "Jobs Projected in 2022:"
        ' 
        ' lbl2018
        ' 
        lbl2018.AutoSize = True
        lbl2018.Font = New Font("Verdana", 15.75F, FontStyle.Bold)
        lbl2018.ForeColor = Color.AliceBlue
        lbl2018.Location = New Point(12, 287)
        lbl2018.Name = "lbl2018"
        lbl2018.Size = New Size(169, 25)
        lbl2018.TabIndex = 4
        lbl2018.Text = "Jobs in 2018:"
        ' 
        ' lstJobTitles
        ' 
        lstJobTitles.Font = New Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lstJobTitles.ForeColor = Color.SkyBlue
        lstJobTitles.FormattingEnabled = True
        lstJobTitles.ItemHeight = 23
        lstJobTitles.Location = New Point(39, 91)
        lstJobTitles.Name = "lstJobTitles"
        lstJobTitles.Size = New Size(363, 142)
        lstJobTitles.TabIndex = 2
        ' 
        ' lblJobTitle
        ' 
        lblJobTitle.AutoSize = True
        lblJobTitle.Font = New Font("Verdana", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblJobTitle.ForeColor = Color.White
        lblJobTitle.Location = New Point(154, 63)
        lblJobTitle.Name = "lblJobTitle"
        lblJobTitle.Size = New Size(132, 25)
        lblJobTitle.TabIndex = 1
        lblJobTitle.Text = "Job Titles:"
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.ForeColor = Color.White
        lblHeading.Location = New Point(31, 9)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(378, 29)
        lblHeading.TabIndex = 0
        lblHeading.Text = "Job Growth in the I.T Field "
        ' 
        ' mnuAction
        ' 
        mnuAction.BackColor = Color.Transparent
        mnuAction.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        mnuAction.Items.AddRange(New ToolStripItem() {ActionToolStripMenuItem})
        mnuAction.Location = New Point(0, 0)
        mnuAction.Name = "mnuAction"
        mnuAction.Size = New Size(800, 26)
        mnuAction.TabIndex = 1
        mnuAction.Text = "MenuStrip1"
        ' 
        ' ActionToolStripMenuItem
        ' 
        ActionToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuDisplay, mnuClear, mnuExit})
        ActionToolStripMenuItem.Font = New Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ActionToolStripMenuItem.ForeColor = Color.SkyBlue
        ActionToolStripMenuItem.Name = "ActionToolStripMenuItem"
        ActionToolStripMenuItem.Size = New Size(74, 22)
        ActionToolStripMenuItem.Text = "&Action"
        ' 
        ' mnuDisplay
        ' 
        mnuDisplay.Name = "mnuDisplay"
        mnuDisplay.Size = New Size(183, 22)
        mnuDisplay.Text = "Display Jobs"
        ' 
        ' mnuClear
        ' 
        mnuClear.Name = "mnuClear"
        mnuClear.Size = New Size(183, 22)
        mnuClear.Text = "&Clear"
        ' 
        ' mnuExit
        ' 
        mnuExit.Name = "mnuExit"
        mnuExit.Size = New Size(183, 22)
        mnuExit.Text = "E&xit"
        ' 
        ' frmJob
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.job
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(pnlDetails)
        Controls.Add(mnuAction)
        MainMenuStrip = mnuAction
        Name = "frmJob"
        Text = "Job Growth in the Information Technology Field"
        pnlDetails.ResumeLayout(False)
        pnlDetails.PerformLayout()
        mnuAction.ResumeLayout(False)
        mnuAction.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlDetails As Panel
    Friend WithEvents lblHeading As Label
    Friend WithEvents lstJobTitles As ListBox
    Friend WithEvents lblJobTitle As Label
    Friend WithEvents lblDisplayChanges As Label
    Friend WithEvents lblDisplay2022 As Label
    Friend WithEvents lblDisplay2018 As Label
    Friend WithEvents lblChanges As Label
    Friend WithEvents lbl2022 As Label
    Friend WithEvents lbl2018 As Label
    Friend WithEvents mnuAction As MenuStrip
    Friend WithEvents ActionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuDisplay As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem

End Class

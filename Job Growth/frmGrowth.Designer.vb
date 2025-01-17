<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrowth
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
        lblHeading = New Label()
        lstJob = New ListBox()
        lst2018 = New ListBox()
        lst2022 = New ListBox()
        btnBack = New Button()
        lblJob = New Label()
        lbl2018 = New Label()
        lbl2022 = New Label()
        SuspendLayout()
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.BackColor = Color.Transparent
        lblHeading.Font = New Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.ForeColor = Color.White
        lblHeading.Location = New Point(192, 17)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(187, 32)
        lblHeading.TabIndex = 0
        lblHeading.Text = "Job Growth"
        ' 
        ' lstJob
        ' 
        lstJob.BorderStyle = BorderStyle.None
        lstJob.Font = New Font("Verdana", 15.75F)
        lstJob.FormattingEnabled = True
        lstJob.ItemHeight = 25
        lstJob.Location = New Point(22, 113)
        lstJob.Name = "lstJob"
        lstJob.Size = New Size(296, 150)
        lstJob.TabIndex = 1
        ' 
        ' lst2018
        ' 
        lst2018.BorderStyle = BorderStyle.None
        lst2018.Font = New Font("Verdana", 15.75F)
        lst2018.FormattingEnabled = True
        lst2018.ItemHeight = 25
        lst2018.Location = New Point(314, 113)
        lst2018.Name = "lst2018"
        lst2018.Size = New Size(119, 150)
        lst2018.TabIndex = 2
        ' 
        ' lst2022
        ' 
        lst2022.BorderStyle = BorderStyle.None
        lst2022.Font = New Font("Verdana", 15.75F)
        lst2022.FormattingEnabled = True
        lst2022.ItemHeight = 25
        lst2022.Location = New Point(430, 113)
        lst2022.Name = "lst2022"
        lst2022.Size = New Size(119, 150)
        lst2022.TabIndex = 3
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.SkyBlue
        btnBack.Font = New Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(243, 307)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(75, 39)
        btnBack.TabIndex = 4
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' lblJob
        ' 
        lblJob.AutoSize = True
        lblJob.BackColor = Color.Transparent
        lblJob.Font = New Font("Verdana", 15.75F, FontStyle.Bold)
        lblJob.ForeColor = Color.White
        lblJob.Location = New Point(22, 60)
        lblJob.Name = "lblJob"
        lblJob.Size = New Size(84, 50)
        lblJob.TabIndex = 5
        lblJob.Text = "Job " & vbCrLf & "Titles:"
        ' 
        ' lbl2018
        ' 
        lbl2018.AutoSize = True
        lbl2018.BackColor = Color.Transparent
        lbl2018.Font = New Font("Verdana", 15.75F, FontStyle.Bold)
        lbl2018.ForeColor = Color.White
        lbl2018.Location = New Point(314, 60)
        lbl2018.Name = "lbl2018"
        lbl2018.Size = New Size(109, 50)
        lbl2018.TabIndex = 6
        lbl2018.Text = "Present " & vbCrLf & "Job:"
        ' 
        ' lbl2022
        ' 
        lbl2022.AutoSize = True
        lbl2022.BackColor = Color.Transparent
        lbl2022.Font = New Font("Verdana", 15.75F, FontStyle.Bold)
        lbl2022.ForeColor = Color.White
        lbl2022.Location = New Point(430, 60)
        lbl2022.Name = "lbl2022"
        lbl2022.Size = New Size(97, 50)
        lbl2022.TabIndex = 7
        lbl2022.Text = "Future " & vbCrLf & "Job:"
        ' 
        ' frmGrowth
        ' 
        AutoScaleDimensions = New SizeF(8F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.job
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(570, 400)
        Controls.Add(lbl2022)
        Controls.Add(lbl2018)
        Controls.Add(lblJob)
        Controls.Add(btnBack)
        Controls.Add(lst2022)
        Controls.Add(lst2018)
        Controls.Add(lstJob)
        Controls.Add(lblHeading)
        Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "frmGrowth"
        Text = "Display the Job Growth in the I.T Field"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lstJob As ListBox
    Friend WithEvents lst2018 As ListBox
    Friend WithEvents lst2022 As ListBox
    Friend WithEvents btnBack As Button
    Friend WithEvents lblJob As Label
    Friend WithEvents lbl2018 As Label
    Friend WithEvents lbl2022 As Label
End Class

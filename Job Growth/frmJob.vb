' Program Name: Job Growth in the Information Technology field
' Date: January 17, 2025
' Author: K Bola
' Purpose: This application displays job titles from a text file with the number of present and future jobs
Option Strict On
Public Class frmJob
    Public Shared _intSizeOfArray As Integer = 5
    Public Shared _strJobTitle(_intSizeOfArray) As String
    Public Shared _intPresentJob(_intSizeOfArray) As Integer
    Public Shared _intFutureJob(_intSizeOfArray) As Integer
    Private Sub frmJob_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objReader As IO.StreamReader
        Dim strFileLocation As String = "C:\Users\HELLO\Source\Repos\Job Growth\job.txt"
        Dim strFileError As String = "File not found"
        Dim intCount As Integer = 0
        Dim intFill As Integer
        ' Verify if file exists
        If IO.File.Exists(strFileLocation) Then
            ' Open it
            objReader = IO.File.OpenText(strFileLocation)
            ' Read it
            Do While objReader.Peek <> -1
                _strJobTitle(intCount) = objReader.ReadLine()
                _intPresentJob(intCount) = Convert.ToInt32(objReader.ReadLine())
                _intFutureJob(intCount) = Convert.ToInt32(objReader.ReadLine())
                intCount += 1
            Loop
            objReader.Close()
            For intFill = 0 To _strJobTitle.Length - 1
                If _strJobTitle(intFill) IsNot Nothing Then
                    lstJobTitles.Items.Add(_strJobTitle(intFill))
                End If
            Next
        Else
            MsgBox(strFileError, MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Error")
        End If
        lblDisplay2018.Text = ""
        lblDisplay2022.Text = ""
        lblDisplayChanges.Text = ""
    End Sub
    Private Sub lstJobTitles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstJobTitles.SelectedIndexChanged
        Dim intSelectedJob As Integer = lstJobTitles.SelectedIndex
        If intSelectedJob >= 0 And intSelectedJob < _intPresentJob.Length Then
            lblDisplay2018.Text = CStr(_intPresentJob(intSelectedJob).ToString())
            lblDisplay2022.Text = CStr(_intFutureJob(intSelectedJob).ToString())
            Dim dblDifference As Double = _intFutureJob(intSelectedJob) - _intPresentJob(intSelectedJob)
            lblDisplayChanges.Text = CStr(dblDifference.ToString())
        End If
    End Sub

    Private Sub mnuDisplay_Click(sender As Object, e As EventArgs) Handles mnuDisplay.Click
        Dim openGrowthFrm As New frmGrowth()
        Hide()
        openGrowthFrm.ShowDialog()
    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        lblDisplay2018.Text = ""
        lblDisplay2022.Text = ""
        lblDisplayChanges.Text = ""
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Close()
    End Sub
End Class

Public Class frmGrowth
    Private Sub frmGrowth_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strJobTitle As String
        Dim intPresentJob As Integer
        Dim intFutureJob As Integer
        For Each strJobTitle In frmJob._strJobTitle
            If strJobTitle IsNot Nothing Then
                lstJob.Items.Add(strJobTitle)
            End If
        Next
        For Each intPresentJob In frmJob._intPresentJob
            lst2018.Items.Add(intPresentJob)
        Next
        For Each intFutureJob In frmJob._intFutureJob
            lst2022.Items.Add(intFutureJob)
        Next
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim back As New frmJob()
        Close()
        back.Show()
    End Sub
End Class
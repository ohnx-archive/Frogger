Imports System.Windows.Forms

Public Class DieForm
    Public continueFlag As Boolean = False
    Public quitFlag As Boolean = False
  

    Private Sub Retry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Retry.Click
        continueFlag = True
        Close()
    End Sub

    Private Sub QuitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitButton.Click
        quitFlag = True
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim aboutForm As New About
        aboutForm.Show()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class

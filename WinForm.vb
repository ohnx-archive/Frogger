Imports System.Windows.Forms
Public Class WinForm
    Public continueFlag As Boolean = False
    Public quitFlag As Boolean = False
    Dim songnumber As Integer

    Private Sub Retry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Retry.Click
        continueFlag = True
        Me.Hide()
    End Sub

    Private Sub QuitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitButton.Click
        Form1.Close()
        Me.Close()
    End Sub
    Private Sub TextChange_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextChange.Tick
        If Label1.Text = "Congratulations!" Then
            Label1.Text = "You Win!!!"
        Else
            Label1.Text = "Congratulations!"
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim About As New FroggerBrowser
        About.Show()
    End Sub

    Private Sub WinForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        musicTimer.Start()
    End Sub

    Private Sub musicTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles musicTimer.Tick
        If songnumber = 1 Then
            My.Computer.Audio.Play(My.Resources.Win, AudioPlayMode.Background)
            songnumber = 2
        Else
            songnumber = 1
            My.Computer.Audio.Play(My.Resources.Win2, AudioPlayMode.Background)
        End If

    End Sub
End Class
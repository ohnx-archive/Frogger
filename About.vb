Public NotInheritable Class About
    Private Sub OKButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub visitWebsite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles visitWebsite.Click
        Dim FroggerBrowserOpener As New FroggerBrowser

        FroggerBrowserOpener.Show()
    End Sub
End Class

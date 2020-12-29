Public Class YouWon
    Private Sub PlayAgain_Click(sender As Object, e As EventArgs) Handles PlayAgain.Click
        Me.Hide()
    End Sub

    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Me.Hide()
        quit = True
    End Sub
End Class
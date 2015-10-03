Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.BackColor = Color.DarkBlue Then
            Me.BackColor = Color.Brown
        Else
            Me.BackColor = Color.DarkBlue
        End If
    End Sub
End Class

Public Class Form11
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form8 As New Form8()
        form8.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Form10 As New Form10()
        Form10.Show()
        Me.Hide()
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form12.Show()
        Me.Close()
    End Sub
End Class
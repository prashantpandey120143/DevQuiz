Imports System.Data
Imports System.Data.SqlClient
Imports System.Security.Cryptography

Public Class Form10

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connectionString As String = "Data Source=DESKTOP-6MRVU7D;Initial Catalog=db111;Integrated Security=True;Encrypt=False"
        Using connection As New SqlConnection(connectionString)
            Dim commandText As String = "INSERT INTO admin (username, password) VALUES (@Value1, @Value2)"
            Dim command As New SqlCommand(commandText, connection)
            command.Parameters.AddWithValue("@Value1", txtValue1.Text)
            command.Parameters.AddWithValue("@Value2", txtValue2.Text)
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
        End Using
        MessageBox.Show("You are an Admin Now")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form9.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form11.Show()
        Me.Close()
    End Sub
End Class
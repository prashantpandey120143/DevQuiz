Imports System.Data
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form9
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text

        ' Validate the user credentials against the database
        Dim connectionString As String = "Data Source=DESKTOP-6MRVU7D;Initial Catalog=db111;Integrated Security=True;Encrypt=False"
        Dim query As String = "SELECT COUNT(*) FROM admin WHERE username = @username AND password = @password"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@password", password)
                connection.Open()
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                If count > 0 Then
                    Dim form11 As New Form11()
                    form11.Show()
                    Me.Close()
                Else
                    MessageBox.Show("Authentication failed")
                End If
            End Using
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class
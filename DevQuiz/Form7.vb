Imports System.Data.SqlClient
Imports System.Reflection.Emit

Public Class Form7
    Dim connectionString As String = "Data Source=DESKTOP-6MRVU7D;Initial Catalog=db111;Integrated Security=True;Encrypt=False"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text
        Dim query As String = "SELECT COUNT(*) FROM t1 WHERE username = @username"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@username", username)
                connection.Open()
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                If count > 0 Then
                    Dim updateQuery As String = "UPDATE t1 SET timeleft = @timeleft WHERE username = @username"
                    Using updateCommand1 As New SqlCommand(updateQuery, connection)
                        updateCommand1.Parameters.AddWithValue("@timeleft", TextBox5.Text)
                        updateCommand1.Parameters.AddWithValue("@Username", username)
                        updateCommand1.ExecuteNonQuery()
                    End Using
                    Dim updateQuery1 As String = "UPDATE t1 SET pscore = @pscore WHERE username = @username"
                    Using updateCommand11 As New SqlCommand(updateQuery1, connection)
                        updateCommand11.Parameters.AddWithValue("@pscore", TextBox6.Text)
                        updateCommand11.Parameters.AddWithValue("@Username", username)
                        updateCommand11.ExecuteNonQuery()
                    End Using
                Else
                    Dim commandText As String = "INSERT INTO t1 (username, password, pname, planguage, timeleft, pscore) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6)"
                    Dim command111 As New SqlCommand(commandText, connection)
                    command111.Parameters.AddWithValue("@Value1", TextBox1.Text)
                    command111.Parameters.AddWithValue("@Value2", TextBox2.Text)
                    command111.Parameters.AddWithValue("@Value3", TextBox3.Text)
                    command111.Parameters.AddWithValue("@Value4", TextBox4.Text)
                    command111.Parameters.AddWithValue("@Value5", TextBox5.Text)
                    command111.Parameters.AddWithValue("@Value6", TextBox6.Text)
                    command111.ExecuteNonQuery()
                End If
                connection.Close()
            End Using
        End Using
        MessageBox.Show("CONGRATULATIONS !")
        Button2.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
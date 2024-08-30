Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form8

    Dim connectionString As String = "Data Source=DESKTOP-6MRVU7D;Initial Catalog=db111;Integrated Security=True;Encrypt=False"
    Dim connection As New SqlConnection(connectionString)
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim command As New SqlCommand("SELECT username FROM t1", connection)
        Dim adapter As New SqlDataAdapter(command)

        Dim dataTable1 As New DataTable()
        adapter.Fill(dataTable1)
        Dim dataTable11 As New DataTable()
        adapter.Fill(dataTable11)

        ComboBox1.DisplayMember = "username"
        ComboBox1.DataSource = dataTable1
        ComboBox2.DisplayMember = "username"
        ComboBox2.DataSource = dataTable11
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim selectedName As String = ComboBox1.Text
        Dim command1 As New SqlCommand("SELECT pname FROM t1 WHERE username = @username", connection)
        command1.Parameters.AddWithValue("@username", selectedName)
        Dim command11 As New SqlCommand("SELECT planguage FROM t1 WHERE username = @username", connection)
        command11.Parameters.AddWithValue("@username", selectedName)
        Dim command111 As New SqlCommand("SELECT timeleft FROM t1 WHERE username = @username", connection)
        command111.Parameters.AddWithValue("@username", selectedName)
        Dim command1111 As New SqlCommand("SELECT pscore FROM t1 WHERE username = @username", connection)
        command1111.Parameters.AddWithValue("@username", selectedName)
        connection.Open()
        Dim pname As Object = command1.ExecuteScalar()
        Dim planguage As Object = command11.ExecuteScalar()
        Dim timeleft As Object = command111.ExecuteScalar()
        Dim pscore As Object = command1111.ExecuteScalar()
        connection.Close()

        If planguage IsNot Nothing Then
            TextBox1.Text = pname.ToString()
            TextBox2.Text = planguage.ToString()
            TextBox3.Text = timeleft.ToString()
            TextBox4.Text = pscore.ToString()
        Else
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
        End If
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim selectedName As String = ComboBox2.Text
        Dim command2 As New SqlCommand("SELECT pname FROM t1 WHERE username = @username", connection)
        command2.Parameters.AddWithValue("@username", selectedName)
        Dim command22 As New SqlCommand("SELECT planguage FROM t1 WHERE username = @username", connection)
        command22.Parameters.AddWithValue("@username", selectedName)
        Dim command222 As New SqlCommand("SELECT timeleft FROM t1 WHERE username = @username", connection)
        command222.Parameters.AddWithValue("@username", selectedName)
        Dim command2222 As New SqlCommand("SELECT pscore FROM t1 WHERE username = @username", connection)
        command2222.Parameters.AddWithValue("@username", selectedName)
        connection.Open()
        Dim pname As Object = command2.ExecuteScalar()
        Dim planguage As Object = command22.ExecuteScalar()
        Dim timeleft As Object = command222.ExecuteScalar()
        Dim pscore As Object = command2222.ExecuteScalar()
        connection.Close()

        If planguage IsNot Nothing Then
            TextBox5.Text = pname.ToString()
            TextBox6.Text = planguage.ToString()
            TextBox7.Text = timeleft.ToString()
            TextBox8.Text = pscore.ToString()
        Else
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form11.Show()
        Me.Close()
    End Sub
End Class
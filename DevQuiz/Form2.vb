Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq.Expressions
Imports System.Reflection
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2
    ' Validate the user credentials against the database
    Dim connectionString As String = "Data Source=DESKTOP-6MRVU7D;Initial Catalog=db111;Integrated Security=True;Encrypt=False"
    Dim connection As New SqlConnection(connectionString)

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim command As New SqlCommand("SELECT username FROM t1", connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim dataTable As New DataTable()
        adapter.Fill(dataTable)

        ComboBox1.DisplayMember = "Username"
        ComboBox1.DataSource = dataTable
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim selectedName As String = ComboBox1.Text
        Dim command1 As New SqlCommand("SELECT planguage FROM t1 WHERE username = @username", connection)
        command1.Parameters.AddWithValue("@username", selectedName)
        Dim command11 As New SqlCommand("SELECT pname FROM t1 WHERE username = @username", connection)
        command11.Parameters.AddWithValue("@username", selectedName)
        connection.Open()
        Dim planguage As Object = command1.ExecuteScalar()
        Dim pname As Object = command11.ExecuteScalar()
        connection.Close()
        If planguage IsNot Nothing Then
            TextBox2.Text = planguage.ToString()
            TextBox3.Text = pname.ToString()
        Else
            TextBox2.Text = ""
            TextBox3.Text = ""
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim username As String = ComboBox1.Text
        Dim password As String = TextBox1.Text
        Dim command As New SqlCommand("SELECT COUNT(*) FROM t1 WHERE Username = @Username AND Password = @Password", connection)
        command.Parameters.AddWithValue("@Username", username)
        command.Parameters.AddWithValue("@Password", password)
        connection.Open()
        Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())
        connection.Close()
        If result > 0 Then
            Select Case TextBox2.Text
                Case "C++"
                    Dim form4 As New Form4()
                    form4.ValueFromForm1 = ComboBox1.Text
                    form4.ValueFromForm11 = TextBox1.Text
                    form4.ValueFromForm111 = TextBox3.Text
                    form4.ValueFromForm1111 = TextBox2.Text
                    form4.Show()
                    Me.Hide()
                Case "Java"
                    Dim form5 As New Form5()
                    form5.ValueFromForm1 = ComboBox1.Text
                    form5.ValueFromForm11 = TextBox1.Text
                    form5.ValueFromForm111 = TextBox3.Text
                    form5.ValueFromForm1111 = TextBox2.Text
                    form5.Show()
                    Me.Hide()
                Case "Python"
                    Dim form6 As New Form6()
                    form6.ValueFromForm1 = ComboBox1.Text
                    form6.ValueFromForm11 = TextBox1.Text
                    form6.ValueFromForm111 = TextBox3.Text
                    form6.ValueFromForm1111 = TextBox2.Text
                    form6.Show()
                    Me.Hide()
                Case Else
                    MessageBox.Show("Invalid language selection")
            End Select
        Else
            MessageBox.Show("Invalid username or password")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form3 As New Form3()
        form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class
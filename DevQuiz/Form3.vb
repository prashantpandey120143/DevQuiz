Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq.Expressions
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form3
    Dim connectionString As String = "Data Source=DESKTOP-6MRVU7D;Initial Catalog=db111;Integrated Security=True;Encrypt=False"
    Dim connection As New SqlConnection(connectionString)

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            txtValue4.Text = ("C++")
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            txtValue4.Text = ("Java")
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            txtValue4.Text = ("Python")
        End If
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click


        Dim form4 As New Form4()
        form4.ValueFromForm1 = txtValue1.Text
        form4.ValueFromForm11 = txtValue2.Text
        form4.ValueFromForm111 = txtValue3.Text
        form4.ValueFromForm1111 = txtValue4.Text
        Dim form5 As New Form5()
        form5.ValueFromForm1 = txtValue1.Text
        form5.ValueFromForm11 = txtValue2.Text
        form5.ValueFromForm111 = txtValue3.Text
        form5.ValueFromForm1111 = txtValue4.Text
        Dim form6 As New Form6()
        form6.ValueFromForm1 = txtValue1.Text
        form6.ValueFromForm11 = txtValue2.Text
        form6.ValueFromForm111 = txtValue3.Text
        form6.ValueFromForm1111 = txtValue4.Text



        If RadioButton1.Checked = True Then
            Form4.Show()
            Me.Hide()
        End If
        If RadioButton2.Checked = True Then
            Form5.Show()
            Me.Hide()
        End If
        If RadioButton3.Checked = True Then
            Form6.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub


End Class

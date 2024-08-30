Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq.Expressions
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form6
    Public Property ValueFromForm1 As String
    Public Property ValueFromForm11 As String
    Public Property ValueFromForm111 As String
    Public Property ValueFromForm1111 As String

    Private counter As Integer = 180

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        counter -= 1
        Dim remainingTime As TimeSpan = TimeSpan.FromSeconds(counter)
        Label1.Text = remainingTime.ToString("mm\:ss")

        If counter <= 0 Then
            Timer1.Stop()
            Label1.Text = "Time's up!"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        counter = 180
        Label1.Text = "03:00"
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
        Dim form7 As New Form7()
        Dim num1 As Integer = Integer.Parse(0)
        Dim num2 As Integer = Integer.Parse(0)
        Dim num3 As Integer = Integer.Parse(0)
        Dim num4 As Integer = Integer.Parse(0)
        Dim num5 As Integer = Integer.Parse(0)
        Dim num6 As Integer = Integer.Parse(0)
        Dim num7 As Integer = Integer.Parse(0)
        Dim num8 As Integer = Integer.Parse(0)


        If RadioButton2.Checked = True Then
            num1 = Integer.Parse(6)
        End If
        If RadioButton5.Checked = True Then
            num2 = Integer.Parse(6)
        End If
        If RadioButton9.Checked = True Then
            num3 = Integer.Parse(6)
        End If
        If RadioButton16.Checked = True Then
            num4 = Integer.Parse(6)
        End If
        If RadioButton19.Checked = True Then
            num5 = Integer.Parse(6)
        End If
        If RadioButton23.Checked = True Then
            num6 = Integer.Parse(9)
        End If
        If RadioButton25.Checked = True Then
            num7 = Integer.Parse(9)
        End If
        If RadioButton31.Checked = True Then
            num8 = Integer.Parse(12)
        End If

        Dim score As Integer = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8


        form7.TextBox1.Text = ValueFromForm1
        form7.TextBox2.Text = ValueFromForm11
        form7.TextBox3.Text = ValueFromForm111
        form7.TextBox4.Text = ValueFromForm1111
        form7.TextBox5.Text = Label1.Text
        form7.TextBox6.Text = score.ToString()
        form7.Show()
        Me.Hide()
    End Sub
End Class


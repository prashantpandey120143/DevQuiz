Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form2 As New Form2()
        form2.Show()
        Me.Hide()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form9 As New Form9()
        form9.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Application.Exit()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MessageBox.Show("Crafted by PRASHANT PANDEY,
This game showcases mastery in VB.NET, SQL Server Management Studio, and fundamental programming skills in C++, Java, and Python.")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("1. New Game

Click on 'New Game' to start a new game.

2. Existing Player Login
If you are an existing player, select your username from the dropdown menu on the left side of the screen.
Enter the correct password for the chosen username.
Click 'Login'.
If the details entered are correct, you will be taken to the quiz of the preferred programming language you chose last time when you joined.

3. New User Sign-Up
If you are new, click on 'New User Sign-Up'.
Enter the necessary details asked and click 'Register'.
You will be taken to the quiz of the preferred programming language you chose.

4. Start the Quiz
When you reach the quiz, click 'Start' to begin the multiple-choice questions.
5. 
Answer the Questions
Work on the multiple-choice questions provided.

6. Submit Answers
When you are done, click 'Submit'.

7.Result Page
You will be taken to the result page.
Click on 'Submit'.
You can then return to the main menu.")


    End Sub
End Class

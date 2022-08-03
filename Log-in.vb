Public Class Log_in

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim t1, t2 As String
        t1 = TextBox1.Text 'Enter emai and password
        t2 = TextBox2.Text

        MsgBox("User Name:" + t1 + vbCrLf + "Password:" + t2 + vbCrLf + "LogIn Successfully")
        Form2.Show() 'Show login form
        Me.Hide()



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show() 'Show Registration
        Me.Hide()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
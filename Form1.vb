Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim t1, t2, t3, t4, t5, t6 As String 'Variable name
        t1 = TextBox1.Text
        t2 = TextBox2.Text
        t3 = ""

        If RadioButton1.Checked Then
            t3 &= RadioButton1.Text
        Else
            t3 &= RadioButton2.Text

        End If
        t4 = TextBox3.Text
        t5 = " "
        If RadioButton3.Checked Then
            t5 &= RadioButton3.Text
        Else
            t5 &= RadioButton4.Text
        End If

        t6 = TextBox4.Text
        'Enter Registration info
        MsgBox("Name:" + t1 + vbCrLf + "Email:" + t2 + vbCrLf + "Gender:" + t3 + vbCrLf + "Address:" + t4 + vbCrLf + "Status:" + t5 + vbCrLf + "Tel. Number:" + t6 + vbCrLf + "SignIn Successfull")


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Log_in.Show()
    End Sub


End Class

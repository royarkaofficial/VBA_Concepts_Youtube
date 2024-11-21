Public Class Form1
    Dim Message As String = "This is a message string"
    Dim intvar As Integer = 25
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(Message)
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)
        BackColor = Color.Blue
        MessageBox.Show(intvar)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "1" Then
            Label1.Text = "message 1"
        End If
        If TextBox1.Text = "2" Then
            Label1.Text = "message 2"
        End If
        If TextBox1.Text = "3" Then
            Label1.Text = "message 3"
        End If
    End Sub
End Class

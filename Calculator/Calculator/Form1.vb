Public Class Form1
    Dim Number1 As Integer
    Dim Number2 As Integer
    Dim Answer As Integer
    Dim q As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Number1 = TextBox1.Text
        Number2 = TextBox2.Text
        Answer = Number1 + Number2
        q = "This is my Calculator"
        MessageBox.Show(Answer + q)
    End Sub
End Class

Public Class Sign_In

    Dim imageList As New List(Of Image)
    Dim currentIndex As Integer = 0
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblforgotpass.Click
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblSIgnUp.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSign1.Click

    End Sub

    Private Sub Sign_In_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub picSlider_Click(sender As Object, e As EventArgs)

    End Sub
End Class
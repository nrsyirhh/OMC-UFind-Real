Public Class ProfileForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Make the PicProfile circular
        Dim circle As New Drawing2D.GraphicsPath()
        circle.AddEllipse(0, 0, picProfile.Width, picProfile.Height)
        picProfile.Region = New Region(circle)

        ' Optional: Add a border effect
        picProfile.BackColor = Color.White
        picProfile.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub picProfile_Click(sender As Object, e As EventArgs) Handles picProfile.Click
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub
End Class
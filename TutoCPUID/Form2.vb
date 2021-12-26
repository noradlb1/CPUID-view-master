Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label1.Parent = PictureBox1
        Label2.Parent = PictureBox1
        Label3.Parent = PictureBox1
        Label4.Parent = PictureBox1
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Label1.BackColor = Color.FromArgb(0, 255, 255, 255)
        Label1.Parent = PictureBox1
        Process.Start("https://www.youtube.com/channel/UCLF-eRNc52VslhdctpHaAzg/videos")
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Label2.BackColor = Color.FromArgb(0, 255, 255, 255)
        Label2.Parent = PictureBox1
        Process.Start("https://discord.gg/z6nftWURjy")
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Label3.BackColor = Color.FromArgb(0, 255, 255, 255)
        Label3.Parent = PictureBox1
        Process.Start("https://www.facebook.com/MONSTERMCSY")
        Process.Start("https://www.facebook.com/OfficialInternationalHacker/")
    End Sub
End Class
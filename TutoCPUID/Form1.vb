Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AevionLabel1.Text = CpuId()
    End Sub
    Private Function CpuId() As String
        Dim computer As String = "."
        Dim wmi As Object = GetObject("winmgmts:" &
            "{impersonationLevel=impersonate}!\\" &
            computer & "\root\cimv2")
        Dim processors As Object = wmi.ExecQuery("Select * from " &
            "Win32_Processor")

        Dim cpu_ids As String = ""
        For Each cpu As Object In processors
            cpu_ids = cpu_ids & ", " & cpu.ProcessorId
        Next cpu
        If cpu_ids.Length > 0 Then cpu_ids =
            cpu_ids.Substring(2)

        Return cpu_ids
    End Function
    Private Sub AevionButton1_Click(sender As Object, e As EventArgs) Handles AevionButton1.Click
        End
    End Sub
    Private Sub AevionLabel2_Click(sender As Object, e As EventArgs) Handles AevionLabel2.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class

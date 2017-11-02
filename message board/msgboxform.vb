Public Class msgboxform
    Dim s As String
    Public i As Integer

    Private Sub msgboxform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        s = "Message Has Been Sent Successfully"
        i = 0
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        i = i + 1
        If i = s.Length + 1 Then
            Timer1.Enabled = False
            Me.Hide()
            account.Show()
        Else
            Label1.Text = s.Substring(0, i)
        End If
    End Sub
End Class
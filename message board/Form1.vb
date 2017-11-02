Public Class Form1

    Private Sub butcreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butcreate.Click
        Me.Hide()
        createac.Show()

    End Sub

    Private Sub butsin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lblacc1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblacc1.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim ds As New Data.DataSet
        s = "select * from register where lid='" & TextBox1.Text & "' and pwd='" & TextBox2.Text & "'"
        ds = getdata(s)
        If ds.Tables(0).Rows.Count = 0 Then
            MsgBox("Invalid LOGIN ID Or Password", MsgBoxStyle.Exclamation)
        Else
            s = "insert into user1 values('" & TextBox1.Text & "')"
            putdata(s)
            MsgBox("Successful LOGIN", MsgBoxStyle.Information)
            MsgBox("Welcome : " & ds.Tables(0).Rows.Item(0).Item(0) & " to my Connecting Zone")
            user = TextBox1.Text
            Me.Hide()
            'frmdraft.Show()

            account.Show()
        End If
    End Sub
End Class

Public Class frmchat

    Private Sub frmchat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim s As String

        Dim ds As New Data.DataSet
        lsbonuser.Items.Clear()
        s = "select * from user1"
        ds = getdata(s)

        For i = 0 To ds.Tables(0).Rows.Count - 1
            lsbonuser.Items.Add(ds.Tables(0).Rows.Item(i).Item(0))
        Next
        TextBox1.Focus()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

        If Asc(e.KeyChar) = 13 Then
            If lsbonuser.SelectedIndex = -1 Then
                MsgBox("First Select Any Online User For CHATTING", MsgBoxStyle.Information, "Message")
            Else
                s = "insert into chat values('" & user & "','" & lsbonuser.SelectedItem & "','" & rtc.Text & "')"
                putdata(s)
                'rtc.Text = rtc.Text & "Test" & "   :   " & TextBox1.Text & vbCrLf & vbCrLf
                TextBox1.Clear()
                TextBox1.Focus()
            End If
        End If

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        s = "insert into chat values('" & user & "','" & lsbonuser.SelectedItem & "','" & rtc.Text & "')"
        putdata(s)
        rtc.Text = rtc.Text & "test" & "   :   " & TextBox1.Text & vbCrLf & vbCrLf
        TextBox1.Clear()
        TextBox1.Focus()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim ds As New Data.DataSet
        s = "select * from chat where rcr='" & user & "'"
        ds = getdata(s)
        For i = 0 To ds.Tables(0).Rows.Count - 1
            rtc.Text = rtc.Text & ds.Tables(0).Rows.Item(i).Item(0) & "   :   " & ds.Tables(0).Rows.Item(i).Item(2) & vbCrLf & vbCrLf
        Next
        s = "delete from chat where rcr='" & user & "'"
        putdata(s)
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim ds As New Data.DataSet
        lsbonuser.Items.Clear()
        s = "select * from user1"
        ds = getdata(s)

        For i = 0 To ds.Tables(0).Rows.Count - 1
            lsbonuser.Items.Add(ds.Tables(0).Rows.Item(i).Item(0))
        Next
    End Sub
End Class
Public Class frmdraft
    Dim m() As String
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Hide()
        account.Show()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        s = "delete from draft where msg='" & Label1.Text & "' and saver='" & user & "'"
        putdata(s)
        loaddetail(0)
    End Sub

    Private Sub frmdraft_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddetail(1)
    End Sub

    Public Sub loaddetail(ByVal n As Integer)

        Dim ds As New Data.DataSet
        Dim st As String, t As Integer
        st = ""
        s = "select * from draft where saver='" & user & "'"
        ds = getdata(s)
        ReDim m(ds.Tables(0).Rows.Count)

        For t = ds.Tables(0).Rows.Count - 1 To 0 Step -1
            st = ds.Tables(0).Rows.Item(t).Item(0)
            If (n = 0) Then
                ListBox1.Items.Add(ds.Tables(0).Rows.Item(0).Item(t))
            Else
                ListBox1.Items.Add(st.Substring(0, 2))
            End If
            m(t) = ds.Tables(0).Rows.Item(t).Item(1)
            MsgBox(m(t))
        Next

        If ds.Tables(0).Rows.Count <> 0 Then
            ListBox1.SelectedIndex = 0
        End If

    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        account.rtb.Text = Label1.Text
        Me.Hide()
        account.Show()
    End Sub


    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Label1.Text = m(ListBox1.SelectedIndex)
    End Sub
End Class
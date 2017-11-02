Public Class frnsent
    Dim ds As New Data.DataSet
    Dim m() As String

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Hide()
        account.Show()
    End Sub

    Private Sub frnsent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        Dim t As Integer
        s = "Select * from message where sender='" & user & "'"
        ds = getdata(s)

        ReDim m(ds.Tables(0).Rows.Count)

        For t = ds.Tables(0).Rows.Count - 1 To 0 Step -1
            ListBox1.Items.Add(ds.Tables(0).Rows.Item(t).Item(0))
            m(i) = ds.Tables(0).Rows.Item(t).Item(3)

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

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Label1.Text = m(ListBox1.SelectedIndex)
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Dim s As String
        s = "delete from message where sender='" & user & "' and msg='" & Label1.Text & "'"
        putdata(s)
        MsgBox("Message Deleted Successfully")
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        Label1.Text = ""
        ListBox1.SelectedIndex = 0

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
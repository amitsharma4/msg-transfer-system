Public Class frmtrash
    Dim ds As Data.DataSet
    Dim i As Integer

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Dim s As String
        s = "delete from deleted where sender='" & ds.Tables(0).Rows.Item((ListBox1.Items.Count - 1) - ListBox1.SelectedIndex).Item(0) & "' and msg='" & Label1.Text & "'"
        putdata(s)
        loaddetail()
        Label1.Text = ""
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Hide()
        account.Show()
    End Sub
    Public Sub loaddetail()
        Dim st As String
        s = "select * from deleted where rcr='" & user & "'"
        ds = getdata(s)
        ListBox1.Items.Clear()

        For i = ds.Tables(0).Rows.Count - 1 To 0 Step -1
            st = ds.Tables(0).Rows.Item(i).Item(3)
            ListBox1.Items.Add(ds.Tables(0).Rows.Item(i).Item(0) & " : " & st.Substring(0, 10))
        Next

        If ds.Tables(0).Rows.Count <> 0 Then
            ListBox1.SelectedIndex = 0
        End If
    End Sub

    Private Sub frmtrash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddetail()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Label1.Text = ds.Tables(0).Rows.Item((ListBox1.Items.Count - 1) - ListBox1.SelectedIndex).Item(3).ToString
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Dim sen, rcr, subj, msg, dot As String

        s = "delete from deleted where sender='" & ds.Tables(0).Rows.Item(ListBox1.SelectedIndex).Item(0) & "' and msg='" & Label1.Text & "' and rcr='" & user & "'"
        putdata(s)
        Label1.Text = ""

        sen = ds.Tables(0).Rows.Item(ListBox1.SelectedIndex).Item(0).ToString
        rcr = ds.Tables(0).Rows.Item(ListBox1.SelectedIndex).Item(1).ToString
        subj = ds.Tables(0).Rows.Item(ListBox1.SelectedIndex).Item(2).ToString
        msg = ds.Tables(0).Rows.Item(ListBox1.SelectedIndex).Item(3).ToString
        dot = ds.Tables(0).Rows.Item(ListBox1.SelectedIndex).Item(4).ToString

        s = "insert into message values('" & sen & "','" & rcr & "','" & subj & "','" & msg & "','" & dot & "','Y')"
        putdata(s)
        loaddetail()
        frminbox.loaddetail()
    End Sub
End Class
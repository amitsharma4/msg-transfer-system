Public Class frminbox
    Dim ds As New Data.DataSet, loc As Integer
    Dim m() As String
    Private Sub frminbox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddetail()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Label1.Text = m(ListBox1.SelectedIndex)

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Hide()
        account.Show()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        account.rtb.Text = Label1.Text
        Me.Hide()
        account.Show()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        account.txtrcr.Text = ds.Tables(0).Rows.Item(ListBox1.SelectedIndex).Item(0).ToString
        Me.Hide()
        account.Show()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Dim s As String
        Dim sen, rcr, subj, msg, dot As String
        sen = ds.Tables(0).Rows.Item((ListBox1.Items.Count - 1) - ListBox1.SelectedIndex).Item(0).ToString
        rcr = ds.Tables(0).Rows.Item((ListBox1.Items.Count - 1) - ListBox1.SelectedIndex).Item(1).ToString
        subj = ds.Tables(0).Rows.Item((ListBox1.Items.Count - 1) - ListBox1.SelectedIndex).Item(2).ToString
        msg = ds.Tables(0).Rows.Item((ListBox1.Items.Count - 1) - ListBox1.SelectedIndex).Item(3).ToString
        dot = ds.Tables(0).Rows.Item((ListBox1.Items.Count - 1) - ListBox1.SelectedIndex).Item(4).ToString

        s = "delete from message where sender='" & sen & "' and msg='" & Label1.Text & "' and rcr='" & user & "'"
        putdata(s)
        s = "insert into deleted values('" & sen & "','" & rcr & "','" & subj & "','" & msg & "','" & dot & "','Y')"
        putdata(s)
        'ListBox1.Items.Clear()
        loaddetail()
        Label1.Text = ""
        frmtrash.loaddetail()
    End Sub
    Public Sub loaddetail()
        Dim st As String

        s = "select location from register where lid='" & user & "'"
        Dim dst As New DataSet
        dst = getdata(s)
        Dim location As String
        location = dst.Tables(0).Rows.Item(i).Item(0)

        s = "select * from message where rcr='" & user & "' or rcr='" & location & "'"
        ds = getdata(s)
        ListBox1.Items.Clear()

        For i = ds.Tables(0).Rows.Count - 1 To 0 Step -1
            st = ds.Tables(0).Rows.Item(i).Item(3)
            ListBox1.Items.Add(ds.Tables(0).Rows.Item(i).Item(0) & " : " & st.Substring(0, 10))
        Next
        
        s = "Select * from message where rcr='" & user & "' "
        If ds.Tables(0).Rows.Count <> 0 Then
            ListBox1.SelectedIndex = 0
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
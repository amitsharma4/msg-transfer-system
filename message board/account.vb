Public Class account

    Private Sub ComboBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs)


    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        Dim i As Integer, s As String
        Dim ds As Data.DataSet
        s = "select lid from register where lid like '" & TextBox3.Text & "%'"
        ds = getdata(s)
        lsboffuser.Items.Clear()
        For i = 0 To ds.Tables(0).Rows.Count - 1
            lsboffuser.Items.Add(ds.Tables(0).Rows.Item(i).Item(0))
        Next
    End Sub

    Private Sub Panel1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.Click
        Me.Hide()
        frmdraft.Show()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub lsboffuser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsboffuser.SelectedIndexChanged
        txtrcr.Text = txtrcr.Text & lsboffuser.SelectedItem & ";"
    End Sub

    Private Sub account_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ds As New Data.DataSet
        Dim i As Integer
        Label7.Text = Now
        lsbonuser.Items.Clear()
        s = "select * from user1  where curuser<>'" & user & "'"
        ds = getdata(s)
        For i = 0 To ds.Tables(0).Rows.Count - 1
            lsbonuser.Items.Add(ds.Tables(0).Rows.Item(i).Item(0))
        Next
        Dim dst As New DataSet

        s = "select lid from register where lid<>'" & user & "'"
        dst = getdata(s)
        For i = 0 To dst.Tables(0).Rows.Count - 1
            lsboffuser.Items.Add(dst.Tables(0).Rows.Item(i).Item(0))
        Next
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label7.Text = Now.Date
        Label8.Text = Now.Hour & ":" & Now.Minute & ":" & Now.Second
    End Sub

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click
        Dim st As String, rc() As String

        st = txtrcr.Text
        st.Substring(0, st.Length - 1)

        If cmbloc.SelectedText = "One" Then
            rc = st.Split(";")
            If UBound(rc) = 1 Then
                s = "insert into message values('" & user & "','" & st & "','" & txtsub.Text & "','" & rtb.Text & "','" & Label7.Text & "','N')"
                putdata(s)
            Else
                For i = 0 To UBound(rc) - 1
                    s = "insert into message values('" & user & "','" & rc(i) & "','" & txtsub.Text & "','" & rtb.Text & "','" & Label7.Text & "','N')"
                    putdata(s)
                Next
            End If
        Else
            s = "insert into message values('" & user & "','" & cmbloc.SelectedItem & "','" & txtsub.Text & "','" & rtb.Text & "','" & Label7.Text & "','N')"
            putdata(s)
        End If


            msgboxform.Show()
            txtrcr.Clear()
            txtsub.Clear()
            rtb.Clear()
            txtrcr.Focus()
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        txtrcr.Clear()
        txtsub.Clear()
        rtb.Clear()
        txtrcr.Focus()
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        Dim ds As New Data.DataSet
        Dim ld() As String, i As Integer
        s = "select lid from register where lid <>'" & user & "'"
        ds = getdata(s)
        ReDim ld(ds.Tables(0).Rows.Count - 1)

        For i = 0 To ds.Tables(0).Rows.Count - 1
            ' If Not (ld(i) = user) Then
            ld(i) = ds.Tables(0).Rows.Item(i).Item(0)
            MsgBox(ld(i))
            'End If
        Next

        For i = 0 To UBound(ld) - 1
            s = "insert into message values('" & user & "','" & ld(i) & "','" & txtsub.Text & "','" & rtb.Text & "','" & Label7.Text & "','N')"
            putdata(s)
        Next
        msgboxform.i = 0
        msgboxform.Timer1.Enabled = True
        msgboxform.Show()
    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click
        s = "delete from user1 where curuser='" & user & "'"
        putdata(s)
        user = ""
        Form1.TextBox1.Text = ""
        Form1.TextBox2.Text = ""
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        frminbox.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox14.Click
        If Len(Trim(rtb.Text)) <> 0 Then
            s = "insert into draft values('" & user & "','" & rtb.Text & "')"
            putdata(s)
            MsgBox("Your Current Message Has Been Saved to Draft", MsgBoxStyle.Information, "Mesanges")
            frmdraft.Show()
            Me.Hide()
        Else
            frmdraft.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub lbldraft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbldraft.Click

    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Me.Hide()
        frnsent.Show()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Me.Hide()
        frmtrash.Show()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rtb.TextChanged

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        Me.Hide()
        frmchat.Show()
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

    Private Sub txtrcr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtrcr.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    
    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub
End Class
Public Class createac

    Private Sub lblback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtfname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfname.TextChanged

    End Sub

    Private Sub butcreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butcreate.Click
        Dim ds As New Data.DataSet

        s = "Select lid from register where lid='" & txtlogin.Text & "'"
        ds = getdata(s)
        If ds.Tables(0).Rows.Count = 0 Then
            s = "insert into register values('" & txtfname.Text & "','" & txtlname.Text & "','" & txtlogin.Text & "','" & txtpwd.Text & "','" & txtrepwd.Text & "','" & cmbque.Text & "','" & txtans.Text & "','" & cmbloc.Text & "')"
            putdata(s)
            Label1.Text = "Congratulations! Your ID Has Been Created Successfully "
            pb1.Visible = True
            pb22.Visible = False
            txtfname.Clear()
            txtlname.Clear()
            txtlogin.Clear()
            txtpwd.Clear()
            txtrepwd.Clear()
            cmbque.SelectedIndex = 0
            txtans.Clear()
            cmbloc.SelectedIndex = 0
            txtfname.Focus()
        Else
            Label1.Text = "Oh! It is Already Enrolled ID Try With another ID"
            pb22.Visible = True
            pb1.Visible = False
        End If
        
    End Sub

    Private Sub cmbque_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbque.SelectedIndexChanged

    End Sub

    Private Sub createac_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbque.SelectedIndex = 0
        cmbloc.SelectedIndex = 0
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb1.Click

    End Sub

    Private Sub Panel5_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Panel1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    
End Class
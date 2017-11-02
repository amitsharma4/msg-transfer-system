Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a(), a1 As String
        Dim temp As String

        Dim i As Integer
        a1 = TextBox1.Text
        ' a1.Insert(TextBox1.Text.Length, ",")
        For i = 0 To a1.Length - 1
            If a1(i).ToString() = "," Then
                ListBox1.Items.Add(i)
            End If

        Next




    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim u, l, i As Integer
        l = 0
        Dim str, st As String
        str = TextBox1.Text
        For i = 0 To ListBox1.Items.Count - 1
            u = Val(ListBox1.Items(i).ToString()) - l
            st = str.Substring(l, u)
            ListBox2.Items.Add(st)
            ' st = ""11`1
            l = Val(ListBox1.Items(i).ToString()) + 1
        Next
        st = str.Substring(l, str.Length - l)
        ListBox2.Items.Add(st)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Label1.Text = TextBox2.Text.Substring(2, 8)
    End Sub
End Class
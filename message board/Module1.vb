Module Module1
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim da As New OleDb.OleDbDataAdapter
    Public s As String, user As String
    Public i As Integer

    Public Sub connect()
        If con.State = 1 Then con.Close()
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\msg.mdb"
        con.Open()
    End Sub

    Public Function getdata(ByVal s As String) As Data.DataSet
        Dim ds As New Data.DataSet
        connect()
        da = New OleDb.OleDbDataAdapter(s, con)
        da.Fill(ds)
        Return ds
    End Function

    Public Sub putdata(ByVal s As String)
        connect()
        cmd = New OleDb.OleDbCommand(s, con)
        cmd.ExecuteNonQuery()
    End Sub

End Module

Imports System.Data.SqlClient

Public Class Form3
    Dim cmd As New SqlCommand
    Dim connection As New SqlConnection("Data Source=Anjulap;Initial Catalog=carinsurance;Integrated Security=True")
    Private da As SqlDataAdapter
    Private ds As Object
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String = ""
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        str = "select * from  Ver_sion where Ver_sion = '" & TextBox2.Text & "'"
        da = New SqlDataAdapter(str, connection)
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            TextBox1.Text = ds.Tables(0).Rows(0).Item("Ver_sion")
            TextBox2.Text = ds.Tables(0).Rows(0).Item("Ver_sionid")
        End If
        connection.Open()
        With cmd
            .CommandType = CommandType.Text
            .Connection = connection
            .CommandText = "insert into Ver_sion(Ver_sionid,Ver_sion)values('" & TextBox2.Text & "','" & TextBox1.Text & "')"
            .ExecuteNonQuery()
            connection.Close()
            MsgBox("Created")
        End With
    End Sub
End Class
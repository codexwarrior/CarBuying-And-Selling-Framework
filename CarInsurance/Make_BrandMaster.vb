﻿Imports System.Data.SqlClient

Public Class Make_BrandMaster

    Dim cmd As New SqlCommand
    Dim connection As New SqlConnection("Data Source=Anjulap;Initial Catalog=carinsurance;Integrated Security=True")
    Private da As SqlDataAdapter
    Private ds As Object
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String = ""
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        str = "select * from  Make_Brand where Make_Brand = '" & TextBox2.Text & "'"
        da = New SqlDataAdapter(str, connection)
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            TextBox1.Text = ds.Tables(0).Rows(0).Item("Make_Brand")
            TextBox2.Text = ds.Tables(0).Rows(0).Item("Make_Brandid")
        End If
        connection.Open()
        With cmd
            .CommandType = CommandType.Text
            .Connection = connection
            .CommandText = "insert into Make_Brand(Make_Brandid,Make_Brand)values('" & TextBox2.Text & "','" & TextBox1.Text & "')"
            .ExecuteNonQuery()
            connection.Close()
            MsgBox("Created")
        End With
    End Sub
End Class
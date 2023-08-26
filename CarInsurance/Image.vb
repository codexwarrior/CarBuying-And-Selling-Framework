Imports C1.Data.SchemaObjects
Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Drawing2D
Imports System.Text.RegularExpressions
Imports C1.Win.C1FlexGrid
Imports System.Windows
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Image
    Dim cmd As New SqlCommand
    Dim rdr As SqlDataReader

    Dim connection As New SqlConnection("Data Source=Anjulap;Initial Catalog=carinsurance;Integrated Security=True")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim K As New OpenFileDialog

        K.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

        If K.ShowDialog = DialogResult.OK Then

            PictureBox1.Image = Drawing.Image.FromFile(K.FileName)

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        connection.Open()
        'Dim imageData As Byte() = CType(PictureBox1.Image, Bitmap).ToArray()
        'Dim command As New SqlCommand("INSERT INTO Images (ImageColumn) VALUES (@imageData)", connection)
        'command.Parameters.AddWithValue("@imageData", imageData)
        Dim id As Integer
        Dim str As String = ""
        Dim da As New SqlDataAdapter
        'Dim lblpath As String
        Dim ds As New DataSet
        str = "select (isnull(MAX(Invoiceid),0)+1) aa from Grid_image "
        da = New SqlDataAdapter(str, connection)
        da.Fill(ds)
        'lblpath = "select (isnull(max(regid),0)+1)aa from registration"

        If ds.Tables(0).Rows.Count > 0 Then
            id = ds.Tables(0).Rows(0).Item("aa")
        End If


        Dim cmd As New SqlCommand("insert into Grid_image(Invoiceid,Grid_image1)values (" & id & ",@2)", connection)
        Dim ms As New MemoryStream
        Dim image As New Bitmap(PictureBox1.Image)
        image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim data As Byte() = ms.GetBuffer
        Dim p As New SqlParameter("@2", SqlDbType.Image)
        p.Value = data
        cmd.Parameters.Add(p)
        cmd.ExecuteNonQuery()

        MsgBox("image save successfully")

        Me.Hide()
        gridshow()
        Form1.Show()

        save_update()
        gridshow()

    End Sub
    Public Sub save_update()
        If invoiceid.Text = "" Then
            Dim cmd1 As New SqlCommand("insert into Car_insurance(image)values (@2)", connection)
            Dim ms1 As New MemoryStream
            Dim image2 As New Bitmap(PictureBox1.Image)
            image2.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim data1 As Byte() = ms1.GetBuffer
            Dim n As New SqlParameter("@2", SqlDbType.Image)
            n.Value = data1
            cmd1.Parameters.Add(n)

            cmd1.ExecuteNonQuery()
        Else
            Dim cmd As New SqlCommand("update  Car_insurance set image =(@img) where Invoiceid='" & invoiceid.Text & "'", connection)

            Dim ms As New MemoryStream
            Dim image As New Bitmap(PictureBox1.Image)
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim data As Byte() = ms.GetBuffer
            Dim p As New SqlParameter("@img", SqlDbType.Image)
            p.Value = data
            cmd.Parameters.Add(p)
            cmd.ExecuteNonQuery()
            connection.Close()
            MsgBox("image save successfully")
            PictureBox1.Image = Nothing
        End If

        connection.Close()

    End Sub

    Public Sub gridshow()
        'connection.Open()
        Dim str As New SqlCommand(" select * from  Grid_image  where Invoiceid='" & invoiceid.Text & "'", connection)
        Dim da As New SqlDataAdapter(str)
        Dim ds As New DataTable()
        'Dim arrImage() As Byte
        da.Fill(ds)

        With Form1


            '.DataGridimage.AllowUserToAddRows = False
            '.DataGridimage.RowTemplate.Height = 90
            Dim picture As New DataGridViewImageColumn
            '.DataGridimage.DataSource = ds
            'picture = Form1.DataGridimage.Columns(1)
            'picture.ImageLayout = DataGridViewImageCellLayout.Zoom




        End With
    End Sub

    Private Sub textboxsno_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

        invoiceid.Visible = False
    End Sub
End Class
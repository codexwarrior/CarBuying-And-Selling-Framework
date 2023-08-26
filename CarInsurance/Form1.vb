Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Windows.Forms.VisualStyles
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports C1.Data.SchemaObjects

Public Class Form1
    Dim cmd As New SqlCommand
    Dim connection As New SqlConnection("Data Source=Anjulap;Initial Catalog=carinsurance;Integrated Security=True")
    'Dim localpath As String = " "
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Buttonexit.Click
        If MsgBox("Do You Want To Exit", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            exitkeyshortcut()
        End If

    End Sub
    Public Sub exitkeyshortcut()
        Me.Close()
    End Sub
    Public Sub clearkeyshortcut()
        If MsgBox("Do You Want To Clear", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            textboxinvoice.Clear()
            RadioButton10.Checked = False
            RadioButton11.Checked = False
            Textboxaddress.Clear()
            TextBoxcarrun.Clear()
            TextBoxassociates.Clear()
            TextBoxbloodgroup.Clear()
            TextBoxRTO.Clear()
            TextBoxyear.Clear()
            TextBoxbrand.Clear()
            TextBoxchallanamount.Clear()
            TextBoxChallanno.Clear()
            TextBoxcity.Clear()
            TextBoxcolor.Clear()
            TextBoxcontactno.Clear()
            TextBoxpermanentaddress.Clear()
            TextBoxfuel.Clear()
            TextBoxIDVvalue.Clear()
            TextBoxlastservice.Clear()
            TextBoxmodel.Clear()
            TextBoxoccupation.Clear()
            TextBoxRTO.Clear()
            TextBoxregistration.Clear()
            TextBoxRTOname.Clear()
            TextBoxversion.Clear()
            TextBox19.Clear()
            TextBoxoccupation.Clear()
        End If

    End Sub

    Private Sub Buttonclear_Click(sender As Object, e As EventArgs) Handles Buttonclear.Click
        If MsgBox("Do You Want To Clear", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            clearkeyshortcut()
        End If
    End Sub
    Private Sub textboxinvoice_KeyDown(sender As Object, e As KeyEventArgs) Handles textboxinvoice.KeyDown
        If e.KeyCode = Keys.Enter Then
            textboxinvoice.Show()
            TextBoxbrand.Focus()
        End If
    End Sub

    Private Sub TextBoxbrand_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxbrand.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBoxbrand.Show()
            TextBoxversion.Focus()
        End If
    End Sub

    Private Sub TextBoxversion_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxversion.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBoxversion.Show()
            TextBoxregistration.Focus()
        End If
    End Sub

    Private Sub TextBoxregistration_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxregistration.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBoxregistration.Show()
            TextBoxcarrun.Focus()
        End If
    End Sub

    Private Sub TextBoxage_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxcarrun.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBoxcarrun.Show()
            TextBoxyear.Focus()
        End If
    End Sub

    Private Sub TextBoxyear_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxyear.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBoxyear.Show()
            TextBoxfuel.Focus()
        End If
    End Sub

    Private Sub TextBoxfuel_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxfuel.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBoxfuel.Show()
            REGDate.Focus()
        End If
    End Sub

    Private Sub REGDate_KeyDown(sender As Object, e As KeyEventArgs) Handles REGDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            REGDate.Show()
            ServiceDate.Focus()
        End If
    End Sub

    Private Sub ServiceDate_KeyDown(sender As Object, e As KeyEventArgs) Handles ServiceDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            ServiceDate.Show()
            TextBoxmodel.Focus()
        End If
    End Sub

    Private Sub TextBoxmodel_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxmodel.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBoxmodel.Show()
            TextBoxcolor.Focus()
        End If
    End Sub

    Private Sub TextBoxcolor_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxcolor.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBoxcolor.Show()
            TextBoxRTO.Focus()
        End If
    End Sub

    Private Sub TextBoxRTO_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxRTO.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBoxRTO.Show()
            TextBoxlastservice.Focus()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        KeyPreview = True
        Me.WindowState = FormWindowState.Maximized
        textboxinvoice.Focus()


    End Sub

    Public Sub save()
        connection.Open()
        Dim CNG_LPG As String = String.Empty
        Dim Ownership As String = String.Empty
        Dim Get_Duplicate_key As String = String.Empty
        Dim Purchase_Invoice As String = String.Empty
        Dim Meter_Tempered As String = String.Empty
        Dim Extra_Tool1 As String = String.Empty
        Dim Extra_Tool2 As String = String.Empty
        Dim Extra_Tool3 As String = String.Empty
        Dim RC_Availbility As String = String.Empty
        Dim Chasis_no_Embossing As String = String.Empty
        Dim RTO_NOC As String = String.Empty
        Dim NOC_issued As String = String.Empty
        Dim Issue_in_chasis_no As String = String.Empty
        Dim Issue_in_engine As String = String.Empty
        Dim MisMatch_Color As String = String.Empty
        Dim Mismatch_cc As String = String.Empty
        Dim IS_Hypothication As String = String.Empty
        Dim have_no28 As String = String.Empty
        Dim have_no29_30 As String = String.Empty
        Dim have_no33 As String = String.Empty
        Dim have_no35 As String = String.Empty
        Dim Covering_letter As String = String.Empty
        Dim Miss_mail As String = String.Empty
        Dim Have_Challan As String = String.Empty
        Dim Paid_To As String = String.Empty
        Dim Have_Insurance As String = String.Empty
        Dim Select_image As String = String.Empty
        If RadioButton2.Checked = True Then
            CNG_LPG = "Yes"

        Else
            CNG_LPG = "no"
        End If
        If RadioButton4.Checked = True Then
            Get_Duplicate_key = "Yes"
        ElseIf RadioButton5.Checked = True Then
            Get_Duplicate_key = "No"
        Else
            Get_Duplicate_key = "Pending"
        End If
        If RadioButton13.Checked = True Then
            Purchase_Invoice = "Yes"

        Else
            Purchase_Invoice = "No"
        End If
        If RadioButton7.Checked = True Then
            Ownership = "1"
        ElseIf RadioButton8.Checked = True Then
            Ownership = "2"
        ElseIf RadioButton9.Checked = True Then
            Ownership = "3"
        ElseIf RadioButton8.Checked = True Then
            Ownership = "4"
        Else
            Ownership = "5"
        End If
        If RadioButton14.Checked = True Then
            Meter_Tempered = "Yes"
        ElseIf RadioButton16.Checked = True Then
            Meter_Tempered = "No"
        Else
            Meter_Tempered = "Pending"
        End If

        If CheckBox1.Checked = True Then
            Extra_Tool1 = "jack"
        End If
        If CheckBox2.Checked = True Then
            Extra_Tool2 = "Wrench"
        End If

        If CheckBox3.Checked = True Then
            Extra_Tool3 = "Stepney"
        End If
        If RadioButton29.Checked = True Then
            RC_Availbility = "Yes"

        Else
            RC_Availbility = "no"
        End If
        If RadioButton31.Checked = True Then
            Chasis_no_Embossing = "Yes"

        Else
            Chasis_no_Embossing = "no"
        End If
        If RadioButton21.Checked = True Then
            RTO_NOC = "Yes"

        Else
            RTO_NOC = "no"
        End If
        If RadioButton25.Checked = True Then
            NOC_issued = "Yes"

        Else
            NOC_issued = "no"
        End If
        If RadioButton34.Checked = True Then
            Issue_in_engine = "Yes"

        Else
            Issue_in_engine = "no"
        End If

        If RadioButton34.Checked = True Then
            Issue_in_chasis_no = "Yes"

        Else
            Issue_in_chasis_no = "no"
        End If
        If RadioButton26.Checked = True Then
            MisMatch_Color = "Yes"

        Else
            MisMatch_Color = "no"
        End If
        If RadioButton24.Checked = True Then
            Mismatch_cc = "Yes"

        Else
            Mismatch_cc = "no"
        End If
        If RadioButton18.Checked = True Then
            IS_Hypothication = "Yes"

        Else
            IS_Hypothication = "no"
        End If
        If RadioButton40.Checked = True Then
            have_no28 = "Yes"
        ElseIf RadioButton39.Checked = True Then
            have_no28 = "No"
        Else
            have_no28 = "Not Required"
        End If
        If RadioButton42.Checked = True Then
            have_no29_30 = "Yes"

        Else
            have_no29_30 = "no"
        End If
        If RadioButton38.Checked = True Then
            have_no33 = "Yes"

        ElseIf RadioButton39.Checked = True Then
            have_no33 = "No"
        Else
            have_no33 = "Not Required"
        End If
        If RadioButton49.Checked = True Then
            have_no35 = "Yes"

        Else
            have_no35 = "no"
        End If
        If RadioButton51.Checked = True Then
            Covering_letter = "Yes"

        Else
            Covering_letter = "no"
        End If
        If RadioButton47.Checked = True Then
            Miss_mail = "Yes"

        Else
            Miss_mail = "no"
        End If
        If RadioButton36.Checked = True Then
            Have_Challan = "Yes"

        Else
            Have_Challan = "no"
        End If

        If RadioButton53.Checked = True Then
            Paid_To = "RTO Office"

        Else
            Paid_To = "Court Pay"
        End If
        If RadioButton54.Checked = True Then
            Have_Insurance = "Comprehensive"

        ElseIf RadioButton55.Checked = True Then
            Have_Insurance = "3rd Party"
        Else
            Have_Insurance = "No"
        End If
        If RadioButton53.Checked = True Then
            Select_image = "Single"

        Else
            Select_image = "Multiple"
        End If


        Dim id As Integer
        Dim str1 As String = ""
        Dim da1 As New SqlDataAdapter
        Dim ds1 As New DataSet
        str1 = "select (isnull(MAX(Invoiceid),0)+1) ss from Car_insurance "
        da1 = New SqlDataAdapter(str1, connection)
        da1.Fill(ds1)
        If ds1.Tables(0).Rows.Count > 0 Then
            id = ds1.Tables(0).Rows(0).Item("ss")
        End If
        With cmd
            .CommandType = CommandType.Text
            .Connection = connection
            If invoiceid.Text = "" Then
                .CommandText = "insert into Car_insurance( Invoiceid,Invoice ,purchase_date ,Make_Brand ,Make_Year ,Ver_sion ,Registration  ,Car_run ,Fuel_Varient ,Reg_Date ,Last_Service_date ,model ,
                Color ,RTO_district ,Run_After_Service ,CNG_LPG ,GET_Duplicate_key ,ownership ,Purchase_Invoice ,Meter_Tempered ,Extra_Tool ,Extratool2,Extratool3,
                RC_Availbility ,Chasis_No ,RTO_NOC ,NOC_to_RTO ,Name_RTO_Office ,Issue_Chasis_No ,Issue_Engine_No ,MisMatch_Color ,
                MisMatch_CC ,Is_Hypothication ,Have_from_No28 ,Have_from_No29_30 ,Have_from_No33 ,Have_from_No35 ,covering_letter ,Miss_mail ,Have_RTD_copy ,Mail_Date ,
                Have_challan ,Challan_No ,Challan_Date ,Challan_Amount ,Paid_to  ,Have_Insurance ,IDV_Value ,Till_Date ,Name ,Address ,Permanent_Address ,
                City ,Contact_No ,Occupation  ,SNo ,Document ,Document_No ,Expiry_on,Select_image1  ,Select_Associates1  ) values ( '" & id & "','" & textboxinvoice.Text & "','" & DateTimePicker1.Text & "','" & TextBoxbrand.Text & "','" & TextBoxyear.Text & "',
                 '" & TextBoxversion.Text & "','" & TextBoxregistration.Text & "','" & TextBoxcarrun.Text & "','" & TextBoxfuel.Text & "',
                 '" & REGDate.Text & "','" & ServiceDate.Text & "' ,'" & TextBoxmodel.Text & "','" & TextBoxcolor.Text & "','" & TextBoxRTO.Text & "','" & TextBoxlastservice.Text & "',
                 '" & CNG_LPG & "','" & Get_Duplicate_key & "','" & Ownership & "','" & Purchase_Invoice & "','" & Meter_Tempered & "','" & Extra_Tool1 & "','" & Extra_Tool2 & "','" & Extra_Tool3 & "','" & RC_Availbility & "','" & Chasis_no_Embossing & "','" & RTO_NOC & "','" & NOC_issued & "',
                 '" & TextBoxRTOname.Text & "','" & Issue_in_chasis_no & "','" & Issue_in_engine & "','" & MisMatch_Color & "', '" & Mismatch_cc & "','" & IS_Hypothication & "' ,'" & have_no28 & "','" & have_no29_30 & "','" & have_no33 & "','" & have_no35 & "',
                '" & Covering_letter & "','" & Miss_mail & "','" & TextBoxRTDCopy.Text & "','" & DateTimePicker3.Text & "','" & Have_Challan & "','" & TextBoxChallanno.Text & "','" & DateTimePicker4.Text & "','" & TextBoxchallanamount.Text & "','" & Paid_To & "','" & Have_Insurance & "',
                '" & TextBoxIDVvalue.Text & "','" & DateTimePicker5.Text & "','" & TextBoxName.Text & "','" & Textboxaddress.Text & "','" & TextBoxpermanentaddress.Text & "','" & TextBoxcity.Text & "','" & TextBoxcontactno.Text & "','" & TextBoxoccupation.Text & "',
                '" & Gridkycdetails.GetData(1, 0) & "','" & Gridkycdetails.GetData(1, 1) & "', '" & Gridkycdetails.GetData(1, 2) & "', '" & Gridkycdetails.GetData(1, 3) & "','" & Select_image & "','" & TextBoxassociates.Text & "')"
                For i As Integer = 1 To DataGridimage.Rows.Count - 1
                    .CommandText = "insert into Grid_image(Invoiceid,Sno,Grid_image_path)values ('" & id & "','" & DataGridimage.GetData(i, 0) & "', (SELECT * FROM OPENROWSET(BULK  '" & DataGridimage.GetData(i, 2) & "', SINGLE_BLOB) As ImageFile))"
                Next
                .ExecuteNonQuery()
                'imagesave()
                MsgBox("created")
            Else
                .CommandType = CommandType.Text
                .Connection = connection
                .CommandText = "Update  Car_insurance  Set  purchase_date='" & DateTimePicker1.Text & "',Make_Brand='" & TextBoxbrand.Text & "',
             Make_Year='" & TextBoxyear.Text & "',Ver_sion= '" & TextBoxversion.Text & "',Registration='" & TextBoxregistration.Text & "',Car_run='" & TextBoxcarrun.Text & "',
             Fuel_Varient='" & TextBoxfuel.Text & "',Reg_Date='" & REGDate.Text & "', Last_Service_date='" & TextBoxlastservice.Text & "',
             model='" & TextBoxmodel.Text & "',Color='" & TextBoxcolor.Text & "',RTO_district='" & TextBoxRTO.Text & "',Run_After_Service='" & TextBoxlastservice.Text & "',
             CNG_LPG='" & CNG_LPG & "',GET_Duplicate_key='" & Get_Duplicate_key & "',ownership='" & Ownership & "',Purchase_Invoice='" & Purchase_Invoice & "',Meter_Tempered ='" & Meter_Tempered & "',Extra_Tool='" & Extra_Tool1 & "',Extratool2='" & Extra_Tool2 & "',Extratool3='" & Extra_Tool3 & "',
             RC_Availbility='" & RC_Availbility & "',Chasis_No='" & Chasis_no_Embossing & "',RTO_NOC='" & RTO_NOC & "',NOC_to_RTO='" & NOC_issued & "',
             Name_RTO_Office='" & TextBoxRTOname.Text & "',Issue_Chasis_No='" & Issue_in_chasis_no & "',Issue_Engine_No='" & Issue_in_engine & "',MisMatch_Color='" & MisMatch_Color & "',MisMatch_CC= '" & Mismatch_cc & "',Is_Hypothication='" & IS_Hypothication & "' ,Have_from_No28='" & have_no28 & "',Have_from_No29_30='" & have_no29_30 & "',
             Have_from_No33='" & have_no33 & "',Have_from_No35='" & have_no35 & "',covering_letter=
            '" & Covering_letter & "',Miss_mail='" & Miss_mail & "',Have_RTD_copy='" & TextBoxRTDCopy.Text & "',Mail_Date='" & DateTimePicker3.Text & "',Have_challan='" & Have_Challan & "',Challan_No='" & TextBoxChallanno.Text & "',
            Challan_Date='" & DateTimePicker4.Text & "',Challan_Amount='" & TextBoxchallanamount.Text & "',Paid_to='" & Paid_To & "',Have_Insurance='" & Have_Insurance & "',IDV_Value='" & TextBoxIDVvalue.Text & "',
            Till_Date='" & DateTimePicker5.Text & "',Name='" & TextBoxName.Text & "',Address='" & Textboxaddress.Text & "',Permanent_Address='" & TextBoxpermanentaddress.Text & "',City='" & TextBoxcity.Text & "',Contact_No='" & TextBoxcontactno.Text & "',Occupation='" & TextBoxoccupation.Text & "',
            SNo='" & Gridkycdetails.GetData(1, 0) & "',Document='" & Gridkycdetails.GetData(1, 1) & "', Document_No='" & Gridkycdetails.GetData(1, 2) & "',Expiry_on= '" & Gridkycdetails.GetData(1, 3) & "',Select_image1='" & Select_image & "',Select_Associates1='" & TextBoxassociates.Text & "' where Invoice  ='" & textboxinvoice.Text & "'"
                For i As Integer = 1 To DataGridimage.Rows.Count - 1

                    .CommandText = "update  Grid_image set Grid_image_path=(SELECT * FROM OPENROWSET(BULK '" & DataGridimage.GetData(i, 2) & "', SINGLE_BLOB) As ImageFile)   where Invoice  ='" & textboxinvoice.Text & "'"
                Next
                .ExecuteNonQuery()
                MsgBox("Modify")


            End If







        End With
    End Sub
    'Public Sub imagesave()
    '    Dim cmd1 As New SqlCommand("insert into Car_insurance(image)values (@2)", connection)
    '    Dim ms1 As New MemoryStream
    '    Dim image2 As New Bitmap(Image.PictureBox1.Image)
    '    image2.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg)
    '    Dim data1 As Byte() = ms1.GetBuffer
    '    Dim n As New SqlParameter("@2", SqlDbType.Image)
    '    n.Value = data1
    '    cmd1.Parameters.Add(n)

    '    cmd1.ExecuteNonQuery()
    'End Sub



    Private Sub Buttonsave_Click(sender As Object, e As EventArgs) Handles Buttonsave.Click
        save()
        'imagesave()
    End Sub
    Public Sub keyEditshortcut()
        Panel1.Enabled = True
        Panel3.Enabled = True
        Panel4.Enabled = True
        Panel5.Enabled = True

    End Sub



    Private Sub Buttonedit_Click(sender As Object, e As EventArgs) Handles Buttonedit.Click
        keyEditshortcut()

    End Sub

    Private Sub Buttonsearch_Click(sender As Object, e As EventArgs) Handles Buttonsearch.Click
        carsearching.Show()
    End Sub

    Private Sub Buttonbrand_Click(sender As Object, e As EventArgs) Handles Buttonbrand.Click
        Make_BrandMaster.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles ButtonVersion.Click
        Form3.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Make_yearMaster.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Fuel_VarientMaster.Show()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        ModelMaster.Show()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Color.Show()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        RTOMaster.Show()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            save()
        ElseIf e.KeyCode = Keys.F2 Then
            If MsgBox("Do You Want To Search", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                carsearching.Show()
            End If
        ElseIf e.KeyCode = Keys.F3 Then
            clearkeyshortcut()
        ElseIf e.KeyCode = Keys.F4 Then
            keyEditshortcut()
        ElseIf e.KeyCode = Keys.Escape Then

            exitkeyshortcut()

        End If
    End Sub

    Private Sub Gridkycdetails_AfterEdit(sender As Object, e As C1.Win.C1FlexGrid.RowColEventArgs) Handles Gridkycdetails.AfterEdit
        If Gridkycdetails.Col() = 0 Then
            Gridkycdetails.Col() = 1
        ElseIf Gridkycdetails.Col() = 1 Then
            Gridkycdetails.Col() = 2
        ElseIf Gridkycdetails.Col() = 2 Then
            Gridkycdetails.Col() = 3
        ElseIf Gridkycdetails.Col() = 3 Then

        End If
    End Sub

    Private Sub DataGridimage_Click(sender As Object, e As EventArgs) Handles DataGridimage.Click
        Dim K As New OpenFileDialog
        K.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"
        If K.ShowDialog = DialogResult.OK Then
            DataGridimage.Rows.Add()
            DataGridimage.SetData(DataGridimage.Rows.Count - 1, 0, DataGridimage.Rows.Count - 1)
            DataGridimage.SetCellImage(DataGridimage.Rows.Count - 1, 1, System.Drawing.Image.FromFile(K.FileName))
            DataGridimage.SetData(DataGridimage.Rows.Count - 1, 2, (K.FileName))
        End If
    End Sub

    Private Sub Buttonimage_Click(sender As Object, e As EventArgs) Handles Buttonimage.Click
        Dim count As Integer = 0
        'Dim path_image As String
        'Dim Serverpath As String = ""
        With cmd
            .CommandType = CommandType.Text
            .Connection = connection
            ' Retrieve the image data from the DataGrid and convert it to a byte array.
            ' Replace "DataGridView1" with the name of your DataGrid.
            '    Dim cell As DataGridViewImageCell = CType(DataGridimage.Rows(0).cell(2), DataGridViewImageCell)
            '    If cell.Value IsNot Nothing Then
            '    Dim image As Image = CType(cell.Value, Image)
            '    Using ms As New System.IO.MemoryStream
            '        image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            '        imageData = ms.ToArray()
            '    End Using
            'End If
            '    Dim sql As String = "INSERT INTO table (column) VALUES (@imageData)"
            '    Using command As New SqlCommand(sql, connection)
            '        command.Parameters.AddWithValue("@imageData", imageData)

            '        ' Execute the INSERT statement using the SqlCommand class.
            '        command.ExecuteNonQuery()

            '    End Using

            If invoiceid.Text = " " Then
                For i As Integer = 1 To DataGridimage.Rows.Count - 1
                    connection.Open()

                    .CommandText = "insert into Grid_image(Sno,Grid_image_path)values ('" & DataGridimage.GetData(i, 0) & "', (SELECT * FROM OPENROWSET(BULK  '" & DataGridimage.GetData(i, 2) & "', SINGLE_BLOB) As ImageFile))"

                    .ExecuteNonQuery()
                    .Parameters.Clear()
                    count = count + 1
                    MsgBox("created")


                    'Else

                    .CommandText = "update  Grid_image set Grid_image_path=(SELECT * FROM OPENROWSET(BULK '" & DataGridimage.GetData(i, 2) & "', SINGLE_BLOB) As ImageFile) where Sno='" & DataGridimage.GetData(i, 0) & "'"

                    'cmd.ExecuteNonQuery()
                    'MsgBox("created")
                    'connection.Close()


                Next

            End If


        End With

    End Sub
End Class

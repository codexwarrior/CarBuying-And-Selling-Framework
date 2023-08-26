Imports System.Data.SqlClient
Imports System.Windows
Imports System.Windows.Forms.VisualStyles
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports C1.Data.SchemaObjects

Public Class carsearching
    Dim cmd As New SqlCommand
    Dim connection As New SqlConnection("Data Source=Anjulap;Initial Catalog=carinsurance;Integrated Security=True")

    Private Sub Buttonshow_Click(sender As Object, e As EventArgs) Handles Buttonshow.Click
        Dim str As String = ""
        Dim k As String = " "
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        If textboxRegistration.Text <> "" Then
            k = "and Registration='" & textboxRegistration.Text & "'"
        End If
        If textboxinvoice.Text <> "" Then
            k = k & "and Invoice='" & textboxinvoice.Text & "'"
        End If
        If TextBoxbrand.Text <> "" Then
            k = k & "and Make_Brand ='" & TextBoxbrand.Text & "'"
        End If
        If TextBoxversion.Text <> "" Then
            k = k & "and Ver_sion='" & TextBoxversion.Text & "'"
        End If
        If TextBoxmodel.Text <> "" Then
            k = k & "and model='" & TextBoxmodel.Text & "'"
        End If
        If TextBoxcolor.Text <> "" Then
            k = k & "and Color='" & TextBoxcolor.Text & "'"
        End If
        If TextBoxRTO.Text <> "" Then
            k = k & "and RTO_district='" & TextBoxRTO.Text & "'"
        End If
        If TextBoxlastservice.Text <> "" Then
            k = k & "and Run_After_Service='" & TextBoxlastservice.Text & "'"
        End If
        str = "select * from Car_insurance where 1=1 " & k & ""
        da = New SqlDataAdapter(str, connection)
        da.Fill(ds)

        With Griddetails
            If ds.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    .Rows.Add()
                    .SetData(.Rows.Count - 1, 0, ds.Tables(0).Rows(i).Item("Registration"))
                    .SetData(.Rows.Count - 1, 1, ds.Tables(0).Rows(i).Item("Name"))
                    .SetData(.Rows.Count - 1, 2, ds.Tables(0).Rows(i).Item("Address"))
                    .SetData(.Rows.Count - 1, 3, ds.Tables(0).Rows(i).Item("Permanent_Address"))
                    .SetData(.Rows.Count - 1, 4, ds.Tables(0).Rows(i).Item("City"))
                    .SetData(.Rows.Count - 1, 5, ds.Tables(0).Rows(i).Item("Contact_No"))
                    .SetData(.Rows.Count - 1, 6, ds.Tables(0).Rows(i).Item("Occupation"))
                    .SetData(.Rows.Count - 1, 7, ds.Tables(0).Rows(i).Item("model"))
                    .SetData(.Rows.Count - 1, 8, ds.Tables(0).Rows(i).Item("Invoiceid"))

                Next
            End If
        End With
    End Sub

    Private Sub Griddetails_DoubleClick(sender As Object, e As EventArgs) Handles Griddetails.DoubleClick
        Dim str As String = ""
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        str = "select * from  Car_insurance where Registration = '" & Griddetails.GetData(Griddetails.Row, 0) & "'"
        da = New SqlDataAdapter(str, connection)
        'Dim no As Integer
        'Dim str1 As String = ""
        'Dim da1 As New SqlDataAdapter
        'Dim ds1 As New DataSet
        'str1 = "select (isnull(MAX(Invoiceid),0)+1) ss from Car_insurance "
        'da1 = New SqlDataAdapter(str1, connection)
        'da1.Fill(ds1)
        'If ds1.Tables(0).Rows.Count > 0 Then
        '    no = ds1.Tables(0).Rows(0).Item("ss")
        'End If
        da.Fill(ds)
        Dim str1 As String = ""
        Dim da1 As New SqlDataAdapter
        Dim ds1 As New DataSet
        str1 = "select * from  Grid_image where Invoiceid = '" & Griddetails.GetData(Griddetails.Row, 8) & "'"
        da1 = New SqlDataAdapter(str, connection)
        da1.Fill(ds1)

        With Form1
            If ds.Tables(0).Rows.Count > 0 Then
                .invoiceid.Text = ds.Tables(0).Rows(0).Item("Invoiceid")
                .textboxinvoice.Text = ds.Tables(0).Rows(0).Item("Invoice")
                If ds.Tables(0).Rows(0).Item("CNG_LPG") = "yes" Then
                    .RadioButton2.Checked = True
                Else
                    .RadioButton3.Checked = True
                End If
                If ds.Tables(0).Rows(0).Item("Get_Duplicate_Key") = "YES" Then
                    .RadioButton4.Checked = True
                ElseIf ds.Tables(0).Rows(0).Item("Get_Duplicate_Key") = "no" Then
                    .RadioButton5.Checked = True
                Else
                    .RadioButton1.Checked = True
                End If
                .DateTimePicker1.Text = ds.Tables(0).Rows(0).Item("purchase_date")


                .TextBoxbrand.Text = ds.Tables(0).Rows(0).Item("Make_Brand")
                .TextBoxyear.Text = ds.Tables(0).Rows(0).Item("Make_Year")
                .TextBoxversion.Text = ds.Tables(0).Rows(0).Item("Ver_sion")
                .TextBoxregistration.Text = ds.Tables(0).Rows(0).Item("Registration")
                .TextBoxcarrun.Text = ds.Tables(0).Rows(0).Item("Car_run")
                .TextBoxfuel.Text = ds.Tables(0).Rows(0).Item("Fuel_Varient")
                .DateTimePicker3.Text = ds.Tables(0).Rows(0).Item("Reg_Date")
                .TextBoxlastservice.Text = ds.Tables(0).Rows(0).Item("Last_Service_date")
                .TextBoxmodel.Text = ds.Tables(0).Rows(0).Item("model")
                .TextBoxcolor.Text = ds.Tables(0).Rows(0).Item("Color")
                .TextBoxRTO.Text = ds.Tables(0).Rows(0).Item("RTO_district")
                .TextBoxlastservice.Text = ds.Tables(0).Rows(0).Item("Run_After_Service")
                If ds.Tables(0).Rows(0).Item("ownership") = "1st" Then
                    .RadioButton7.Checked = True
                ElseIf ds.Tables(0).Rows(0).Item("ownership") = "2nd" Then
                    .RadioButton8.Checked = True
                ElseIf ds.Tables(0).Rows(0).Item("ownership") = "3rd" Then
                    .RadioButton9.Checked = True
                ElseIf ds.Tables(0).Rows(0).Item("ownership") = "4th" Then
                    .RadioButton10.Checked = True
                Else
                    .RadioButton11.Checked = True
                End If
                If ds.Tables(0).Rows(0).Item("Purchase_Invoice") = "YES" Then
                    .RadioButton13.Checked = True
                Else
                    .RadioButton15.Checked = True
                End If
                If ds.Tables(0).Rows(0).Item("Meter_Tempered") = "Yes" Then
                    .RadioButton14.Checked = True
                ElseIf ds.Tables(0).Rows(0).Item("Meter_Tempered") = "no" Then
                    .RadioButton16.Checked = True
                Else
                    .RadioButton17.Checked = True
                End If
                If ds.Tables(0).Rows(0).Item("Extra_Tool") = "Jack" Then
                    .CheckBox1.Checked = True
                End If
                If ds.Tables(0).Rows(0).Item("Extratool2") = "Wrench" Then
                    .CheckBox2.Checked = True
                End If

                If ds.Tables(0).Rows(0).Item("Extratool3") = "Stepney" Then
                    .CheckBox3.Checked = True
                End If

                If ds.Tables(0).Rows(0).Item("RC_Availbility") = "YES" Then
                    .RadioButton29.Checked = True
                Else
                    .RadioButton30.Checked = True
                End If
                If ds.Tables(0).Rows(0).Item("Chasis_No") = "YES" Then
                    .RadioButton31.Checked = True
                Else
                    .RadioButton31.Checked = True
                End If
                If ds.Tables(0).Rows(0).Item("RTO_NOC") = "YES" Then
                    .RadioButton21.Checked = True
                Else
                    .RadioButton22.Checked = True

                End If
                If ds.Tables(0).Rows(0).Item("NOC_to_RTO") = "YES" Then
                    .RadioButton23.Checked = True
                Else
                    .RadioButton24.Checked = True
                End If
                .TextBoxRTOname.Text = ds.Tables(0).Rows(0).Item("Name_RTO_Office")
                If ds.Tables(0).Rows(0).Item("Issue_Chasis_No") = "YES" Then
                    .RadioButton34.Checked = True
                Else
                    .RadioButton35.Checked = True
                End If
                If ds.Tables(0).Rows(0).Item("Issue_Engine_No") = "YES" Then
                    .RadioButton26.Checked = True
                Else
                    .RadioButton27.Checked = True
                End If
                If ds.Tables(0).Rows(0).Item("MisMatch_Color") = "YES" Then
                    .RadioButton32.Checked = True
                Else
                    .RadioButton33.Checked = True
                End If

                If ds.Tables(0).Rows(0).Item("MisMatch_CC") = "YES" Then
                    .RadioButton24.Checked = True
                Else
                    .RadioButton20.Checked = True
                End If
                If ds.Tables(0).Rows(0).Item("Is_Hypothication") = "YES" Then
                    .RadioButton18.Checked = True
                Else
                    .RadioButton12.Checked = True

                End If
                If ds.Tables(0).Rows(0).Item("Have_from_No28") = "YES" Then
                    .RadioButton40.Checked = True
                ElseIf ds.Tables(0).Rows(0).Item("Have_from_No28") = "no" Then
                    .RadioButton39.Checked = True
                Else
                    .RadioButton38.Checked = True
                End If
                If ds.Tables(0).Rows(0).Item("Have_from_No29_30") = "YES" Then
                    .RadioButton49.Checked = True
                Else
                    .RadioButton41.Checked = True

                End If
                If ds.Tables(0).Rows(0).Item("Have_from_No33") = "YES" Then
                    .RadioButton38.Checked = True
                ElseIf ds.Tables(0).Rows(0).Item("Have_from_No28") = "no" Then
                    .RadioButton37.Checked = True
                Else
                    .RadioButton43.Checked = True
                End If
                If ds.Tables(0).Rows(0).Item("Have_from_No35") = "YES" Then
                    .RadioButton49.Checked = True
                Else
                    .RadioButton48.Checked = True
                End If
                If ds.Tables(0).Rows(0).Item("covering_letter") = "YES" Then
                    .RadioButton51.Checked = True
                Else
                    .RadioButton50.Checked = True
                End If
                If ds.Tables(0).Rows(0).Item("Miss_mail") = "yes" Then
                    .RadioButton47.Checked = True
                Else
                    .RadioButton46.Checked = True
                End If
                .TextBoxRTDCopy.Text = ds.Tables(0).Rows(0).Item("Have_RTD_copy")
                .DateTimePicker3.Text = ds.Tables(0).Rows(0).Item("Mail_Date")
                If ds.Tables(0).Rows(0).Item("Have_challan") = "yes" Then
                    .RadioButton36.Checked = True
                Else
                    .RadioButton35.Checked = True
                End If
                .TextBoxChallanno.Text = ds.Tables(0).Rows(0).Item("Challan_No")
                .DateTimePicker4.Text = ds.Tables(0).Rows(0).Item("Challan_Date")
                .TextBoxchallanamount.Text = ds.Tables(0).Rows(0).Item("Challan_Amount")
                If ds.Tables(0).Rows(0).Item("Paid_to") = "RTO Office" Then
                    .RadioButton53.Checked = True
                Else
                    .RadioButton52.Checked = True
                End If
                If ds.Tables(0).Rows(0).Item("Have_Insurance") = "comprehensive" Then
                    .RadioButton54.Checked = True
                ElseIf ds.Tables(0).Rows(0).Item("Have_Insurance") = "3rd party" Then
                    .RadioButton53.Checked = True
                Else
                    .RadioButton52.Checked = True
                End If
                .TextBoxIDVvalue.Text = ds.Tables(0).Rows(0).Item("IDV_Value")
                .DateTimePicker5.Text = ds.Tables(0).Rows(0).Item("Till_Date")
                .TextBoxName.Text = ds.Tables(0).Rows(0).Item("Name")
                .Textboxaddress.Text = ds.Tables(0).Rows(0).Item("Address")
                .TextBoxpermanentaddress.Text = ds.Tables(0).Rows(0).Item("Permanent_Address")
                .TextBoxcity.Text = ds.Tables(0).Rows(0).Item("City")
                .TextBoxcontactno.Text = ds.Tables(0).Rows(0).Item("Contact_No")
                .TextBoxoccupation.Text = ds.Tables(0).Rows(0).Item("Occupation")
                .Gridkycdetails(1, 0) = ds.Tables(0).Rows(0).Item("SNo")
                .Gridkycdetails(1, 1) = ds.Tables(0).Rows(0).Item("Document")
                .Gridkycdetails(1, 2) = ds.Tables(0).Rows(0).Item("Document_No")
                .Gridkycdetails(1, 3) = ds.Tables(0).Rows(0).Item("Expiry_on")

                .TextBoxassociates.Text = ds.Tables(0).Rows(0).Item("Select_Associates1")
                For i As Integer = 1 To .DataGridimage.Rows.Count - 1
                    .DataGridimage.Rows.Add()
                    .DataGridimage(i, 0) = ds1.Tables(0).Rows(i - 1).Item("Sno")
                    Dim picture As New DataGridViewImageColumn
                    .DataGridimage.DataSource = ds1
                    .DataGridimage(i, 1) = ds1.Tables(0).Rows(0).Item("Grid_image_path")
                    picture = Form1.DataGridimage(i - 1, 1)
                    picture.ImageLayout = DataGridViewImageCellLayout.Zoom

                    'Dim str2 As New SqlCommand(" select image from Car_insurance where Registration = '" & Griddetails.GetData(Griddetails.Row, 0) & "'", connection)
                    'Dim da2 As New SqlDataAdapter(str2)
                    'Dim ds2 As New DataTable()
                    'da2.Fill(ds2)
                    'With Form1
                    '    .DataGridimage.AllowUserToAddRows = False
                    '    .DataGridimage5.RowTemplate.Height = 90
                    '    Dim picture As New DataGridViewImageColumn
                    '    .DataGridimage5.DataSource = ds2
                    '    picture = Form1.DataGridimage5.Columns(0)
                    '    picture.ImageLayout = DataGridViewImageCellLayout.Zoom
                    'End With
                    .DataGridimage(i, 2) = ds1.Tables(0).Rows(i - 1).Item("Grid_image_path")
                Next

            End If
        End With
        Me.Hide()
        Form1.Show()
        Form1.Focus()
        Form1.Panel1.Enabled = False
        Form1.Panel3.Enabled = False
        Form1.Panel4.Enabled = False
        Form1.Panel5.Enabled = False

    End Sub

    Private Sub carsearching_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        textboxinvoice.Clear()
        TextBoxbrand.Clear()
        TextBoxcolor.Clear()
        TextBoxmodel.Clear()
        TextBoxversion.Clear()
        TextBoxRTO.Clear()
        TextBoxlastservice.Clear()
    End Sub


End Class
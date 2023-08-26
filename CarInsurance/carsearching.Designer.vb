<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class carsearching
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(carsearching))
        Me.TextBoxipdsearching = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Buttonshow = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.textboxRegistration = New System.Windows.Forms.MaskedTextBox()
        Me.textboxinvoice = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxlastservice = New System.Windows.Forms.TextBox()
        Me.TextBoxRTO = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxcolor = New System.Windows.Forms.TextBox()
        Me.TextBoxmodel = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.TextBoxbrand = New System.Windows.Forms.TextBox()
        Me.TextBoxversion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Griddetails = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Griddetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxipdsearching
        '
        Me.TextBoxipdsearching.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBoxipdsearching.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxipdsearching.Location = New System.Drawing.Point(0, 12)
        Me.TextBoxipdsearching.Multiline = True
        Me.TextBoxipdsearching.Name = "TextBoxipdsearching"
        Me.TextBoxipdsearching.Size = New System.Drawing.Size(1739, 37)
        Me.TextBoxipdsearching.TabIndex = 25
        Me.TextBoxipdsearching.Text = "CAR SEARCHING"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Buttonshow)
        Me.Panel3.Location = New System.Drawing.Point(-2, 593)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1741, 72)
        Me.Panel3.TabIndex = 24
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(228, 1)
        Me.Button3.Name = "Button3"
        Me.Button3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button3.Size = New System.Drawing.Size(94, 46)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Clear"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(118, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 47)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Buttonshow
        '
        Me.Buttonshow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Buttonshow.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonshow.Location = New System.Drawing.Point(0, 0)
        Me.Buttonshow.Name = "Buttonshow"
        Me.Buttonshow.Size = New System.Drawing.Size(120, 47)
        Me.Buttonshow.TabIndex = 1
        Me.Buttonshow.Text = "SHOW"
        Me.Buttonshow.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.textboxRegistration)
        Me.Panel1.Controls.Add(Me.textboxinvoice)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TextBoxlastservice)
        Me.Panel1.Controls.Add(Me.TextBoxRTO)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.TextBoxcolor)
        Me.Panel1.Controls.Add(Me.TextBoxmodel)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label38)
        Me.Panel1.Controls.Add(Me.TextBoxbrand)
        Me.Panel1.Controls.Add(Me.TextBoxversion)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-2, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1739, 358)
        Me.Panel1.TabIndex = 22
        '
        'textboxRegistration
        '
        Me.textboxRegistration.Location = New System.Drawing.Point(203, 24)
        Me.textboxRegistration.Name = "textboxRegistration"
        Me.textboxRegistration.Size = New System.Drawing.Size(200, 22)
        Me.textboxRegistration.TabIndex = 54
        '
        'textboxinvoice
        '
        Me.textboxinvoice.Location = New System.Drawing.Point(203, 101)
        Me.textboxinvoice.Name = "textboxinvoice"
        Me.textboxinvoice.Size = New System.Drawing.Size(200, 22)
        Me.textboxinvoice.TabIndex = 53
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Invoice"
        '
        'TextBoxlastservice
        '
        Me.TextBoxlastservice.Location = New System.Drawing.Point(1062, 251)
        Me.TextBoxlastservice.Name = "TextBoxlastservice"
        Me.TextBoxlastservice.Size = New System.Drawing.Size(195, 22)
        Me.TextBoxlastservice.TabIndex = 51
        '
        'TextBoxRTO
        '
        Me.TextBoxRTO.Location = New System.Drawing.Point(1062, 179)
        Me.TextBoxRTO.Name = "TextBoxRTO"
        Me.TextBoxRTO.Size = New System.Drawing.Size(195, 22)
        Me.TextBoxRTO.TabIndex = 50
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Silver
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(790, 252)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(186, 18)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Run After Last Service :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Silver
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(790, 183)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 18)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "RTO District :"
        '
        'TextBoxcolor
        '
        Me.TextBoxcolor.Location = New System.Drawing.Point(1062, 118)
        Me.TextBoxcolor.Name = "TextBoxcolor"
        Me.TextBoxcolor.Size = New System.Drawing.Size(195, 22)
        Me.TextBoxcolor.TabIndex = 47
        '
        'TextBoxmodel
        '
        Me.TextBoxmodel.Location = New System.Drawing.Point(1062, 42)
        Me.TextBoxmodel.Name = "TextBoxmodel"
        Me.TextBoxmodel.Size = New System.Drawing.Size(195, 22)
        Me.TextBoxmodel.TabIndex = 46
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Silver
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(791, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 18)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Color  :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Silver
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(792, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 18)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Model :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 18)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Make/Brand"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.BackColor = System.Drawing.Color.Silver
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label38.Location = New System.Drawing.Point(14, 270)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(75, 18)
        Me.Label38.TabIndex = 31
        Me.Label38.Text = "Version :"
        '
        'TextBoxbrand
        '
        Me.TextBoxbrand.Location = New System.Drawing.Point(203, 175)
        Me.TextBoxbrand.Name = "TextBoxbrand"
        Me.TextBoxbrand.Size = New System.Drawing.Size(200, 22)
        Me.TextBoxbrand.TabIndex = 33
        '
        'TextBoxversion
        '
        Me.TextBoxversion.Location = New System.Drawing.Point(203, 269)
        Me.TextBoxversion.Name = "TextBoxversion"
        Me.TextBoxversion.Size = New System.Drawing.Size(200, 22)
        Me.TextBoxversion.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registration"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Griddetails)
        Me.Panel2.Location = New System.Drawing.Point(0, 417)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1737, 170)
        Me.Panel2.TabIndex = 23
        '
        'Griddetails
        '
        Me.Griddetails.BackColor = System.Drawing.Color.SkyBlue
        Me.Griddetails.ColumnInfo = resources.GetString("Griddetails.ColumnInfo")
        Me.Griddetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Griddetails.ForeColor = System.Drawing.Color.Black
        Me.Griddetails.Location = New System.Drawing.Point(4, -1)
        Me.Griddetails.Margin = New System.Windows.Forms.Padding(4)
        Me.Griddetails.Name = "Griddetails"
        Me.Griddetails.Rows.Count = 1
        Me.Griddetails.Rows.DefaultSize = 20
        Me.Griddetails.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.Griddetails.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.Griddetails.Size = New System.Drawing.Size(1727, 176)
        Me.Griddetails.StyleInfo = resources.GetString("Griddetails.StyleInfo")
        Me.Griddetails.TabIndex = 21
        '
        'carsearching
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1751, 749)
        Me.Controls.Add(Me.TextBoxipdsearching)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "carsearching"
        Me.Text = "Carsearching"
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Griddetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxipdsearching As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Buttonshow As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents TextBoxbrand As TextBox
    Friend WithEvents TextBoxversion As TextBox
    Friend WithEvents TextBoxlastservice As TextBox
    Friend WithEvents TextBoxRTO As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBoxcolor As TextBox
    Friend WithEvents TextBoxmodel As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents textboxinvoice As MaskedTextBox
    Friend WithEvents Griddetails As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents textboxRegistration As MaskedTextBox
End Class

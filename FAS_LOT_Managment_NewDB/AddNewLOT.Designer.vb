<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewLOT
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CB_CERT = New System.Windows.Forms.CheckBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CB_CheckModel = New System.Windows.Forms.CheckBox()
        Me.CB_SWGS1Version = New System.Windows.Forms.CheckBox()
        Me.CB_SWVersion = New System.Windows.Forms.CheckBox()
        Me.BT_AddCert = New System.Windows.Forms.Button()
        Me.BT_AddHDCP = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.CB_MAC = New System.Windows.Forms.CheckBox()
        Me.LB_HDCPCont = New System.Windows.Forms.Label()
        Me.CB_HDCP = New System.Windows.Forms.CheckBox()
        Me.LB_CertCont = New System.Windows.Forms.Label()
        Me.TB_SNinLot = New System.Windows.Forms.TextBox()
        Me.LB_MACCont = New System.Windows.Forms.Label()
        Me.BT_RegisterNewLOT = New System.Windows.Forms.Button()
        Me.DG_Model = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MyGrid_HDCP = New System.Windows.Forms.DataGridView()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.MyGrid_Cert = New System.Windows.Forms.DataGridView()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxModel = New System.Windows.Forms.ComboBox()
        Me.TB_Manuf = New System.Windows.Forms.TextBox()
        Me.TB_PTID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TB_Operatop = New System.Windows.Forms.TextBox()
        Me.TB_Spec = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TB_LotCode = New System.Windows.Forms.TextBox()
        Me.TB_FullLotCode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TB_Market = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DG_Model, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.MyGrid_HDCP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyGrid_Cert, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Upload Module:"
        '
        'CB_CERT
        '
        Me.CB_CERT.AutoSize = True
        Me.CB_CERT.Location = New System.Drawing.Point(96, 41)
        Me.CB_CERT.Name = "CB_CERT"
        Me.CB_CERT.Size = New System.Drawing.Size(55, 17)
        Me.CB_CERT.TabIndex = 5
        Me.CB_CERT.Text = "CERT"
        Me.CB_CERT.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CB_CheckModel)
        Me.GroupBox3.Controls.Add(Me.CB_SWGS1Version)
        Me.GroupBox3.Controls.Add(Me.CB_SWVersion)
        Me.GroupBox3.Controls.Add(Me.BT_AddCert)
        Me.GroupBox3.Controls.Add(Me.BT_AddHDCP)
        Me.GroupBox3.Controls.Add(Me.CB_MAC)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.CB_CERT)
        Me.GroupBox3.Controls.Add(Me.LB_HDCPCont)
        Me.GroupBox3.Controls.Add(Me.CB_HDCP)
        Me.GroupBox3.Controls.Add(Me.LB_CertCont)
        Me.GroupBox3.Controls.Add(Me.LB_MACCont)
        Me.GroupBox3.Location = New System.Drawing.Point(484, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(364, 177)
        Me.GroupBox3.TabIndex = 41
        Me.GroupBox3.TabStop = False
        '
        'CB_CheckModel
        '
        Me.CB_CheckModel.AutoSize = True
        Me.CB_CheckModel.Location = New System.Drawing.Point(96, 87)
        Me.CB_CheckModel.Name = "CB_CheckModel"
        Me.CB_CheckModel.Size = New System.Drawing.Size(168, 17)
        Me.CB_CheckModel.TabIndex = 24
        Me.CB_CheckModel.Text = "Проверка названия модели"
        Me.CB_CheckModel.UseVisualStyleBackColor = True
        '
        'CB_SWGS1Version
        '
        Me.CB_SWGS1Version.AutoSize = True
        Me.CB_SWGS1Version.Location = New System.Drawing.Point(96, 134)
        Me.CB_SWGS1Version.Name = "CB_SWGS1Version"
        Me.CB_SWGS1Version.Size = New System.Drawing.Size(158, 17)
        Me.CB_SWGS1Version.TabIndex = 22
        Me.CB_SWGS1Version.Text = "Проверка версии ПО GS1"
        Me.CB_SWGS1Version.UseVisualStyleBackColor = True
        '
        'CB_SWVersion
        '
        Me.CB_SWVersion.AutoSize = True
        Me.CB_SWVersion.Location = New System.Drawing.Point(96, 111)
        Me.CB_SWVersion.Name = "CB_SWVersion"
        Me.CB_SWVersion.Size = New System.Drawing.Size(134, 17)
        Me.CB_SWVersion.TabIndex = 23
        Me.CB_SWVersion.Text = "Проверка версии ПО"
        Me.CB_SWVersion.UseVisualStyleBackColor = True
        '
        'BT_AddCert
        '
        Me.BT_AddCert.Location = New System.Drawing.Point(228, 38)
        Me.BT_AddCert.Name = "BT_AddCert"
        Me.BT_AddCert.Size = New System.Drawing.Size(70, 20)
        Me.BT_AddCert.TabIndex = 6
        Me.BT_AddCert.Text = "Add Cert"
        Me.BT_AddCert.UseVisualStyleBackColor = True
        Me.BT_AddCert.Visible = False
        '
        'BT_AddHDCP
        '
        Me.BT_AddHDCP.Location = New System.Drawing.Point(228, 15)
        Me.BT_AddHDCP.Name = "BT_AddHDCP"
        Me.BT_AddHDCP.Size = New System.Drawing.Size(70, 20)
        Me.BT_AddHDCP.TabIndex = 6
        Me.BT_AddHDCP.Text = "Add HDCP"
        Me.BT_AddHDCP.UseVisualStyleBackColor = True
        Me.BT_AddHDCP.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(26, 119)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(60, 13)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "SN in LOT:"
        '
        'CB_MAC
        '
        Me.CB_MAC.AutoSize = True
        Me.CB_MAC.Location = New System.Drawing.Point(96, 64)
        Me.CB_MAC.Name = "CB_MAC"
        Me.CB_MAC.Size = New System.Drawing.Size(49, 17)
        Me.CB_MAC.TabIndex = 5
        Me.CB_MAC.Text = "MAC"
        Me.CB_MAC.UseVisualStyleBackColor = True
        '
        'LB_HDCPCont
        '
        Me.LB_HDCPCont.AutoSize = True
        Me.LB_HDCPCont.Location = New System.Drawing.Point(151, 19)
        Me.LB_HDCPCont.Name = "LB_HDCPCont"
        Me.LB_HDCPCont.Size = New System.Drawing.Size(71, 13)
        Me.LB_HDCPCont.TabIndex = 1
        Me.LB_HDCPCont.Text = "(количество)"
        '
        'CB_HDCP
        '
        Me.CB_HDCP.AutoSize = True
        Me.CB_HDCP.Location = New System.Drawing.Point(96, 19)
        Me.CB_HDCP.Name = "CB_HDCP"
        Me.CB_HDCP.Size = New System.Drawing.Size(56, 17)
        Me.CB_HDCP.TabIndex = 5
        Me.CB_HDCP.Text = "HDCP"
        Me.CB_HDCP.UseVisualStyleBackColor = True
        '
        'LB_CertCont
        '
        Me.LB_CertCont.AutoSize = True
        Me.LB_CertCont.Location = New System.Drawing.Point(151, 42)
        Me.LB_CertCont.Name = "LB_CertCont"
        Me.LB_CertCont.Size = New System.Drawing.Size(71, 13)
        Me.LB_CertCont.TabIndex = 1
        Me.LB_CertCont.Text = "(количество)"
        '
        'TB_SNinLot
        '
        Me.TB_SNinLot.Location = New System.Drawing.Point(92, 115)
        Me.TB_SNinLot.Name = "TB_SNinLot"
        Me.TB_SNinLot.Size = New System.Drawing.Size(121, 20)
        Me.TB_SNinLot.TabIndex = 0
        Me.TB_SNinLot.Text = "0"
        '
        'LB_MACCont
        '
        Me.LB_MACCont.AutoSize = True
        Me.LB_MACCont.Location = New System.Drawing.Point(151, 63)
        Me.LB_MACCont.Name = "LB_MACCont"
        Me.LB_MACCont.Size = New System.Drawing.Size(71, 13)
        Me.LB_MACCont.TabIndex = 1
        Me.LB_MACCont.Text = "(количество)"
        '
        'BT_RegisterNewLOT
        '
        Me.BT_RegisterNewLOT.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.BT_RegisterNewLOT.Location = New System.Drawing.Point(12, 510)
        Me.BT_RegisterNewLOT.Name = "BT_RegisterNewLOT"
        Me.BT_RegisterNewLOT.Size = New System.Drawing.Size(226, 73)
        Me.BT_RegisterNewLOT.TabIndex = 42
        Me.BT_RegisterNewLOT.Text = "Зарегистрировать ЛОТ"
        Me.BT_RegisterNewLOT.UseVisualStyleBackColor = True
        '
        'DG_Model
        '
        Me.DG_Model.AllowUserToAddRows = False
        Me.DG_Model.AllowUserToDeleteRows = False
        Me.DG_Model.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Model.Location = New System.Drawing.Point(113, 19)
        Me.DG_Model.Name = "DG_Model"
        Me.DG_Model.ReadOnly = True
        Me.DG_Model.Size = New System.Drawing.Size(120, 60)
        Me.DG_Model.TabIndex = 8
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DG_Model)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Location = New System.Drawing.Point(13, 214)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(335, 278)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(68, 37)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 13)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Model:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(19, 523)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(113, 118)
        Me.TextBox1.TabIndex = 10
        '
        'MyGrid_HDCP
        '
        Me.MyGrid_HDCP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MyGrid_HDCP.Location = New System.Drawing.Point(6, 30)
        Me.MyGrid_HDCP.Name = "MyGrid_HDCP"
        Me.MyGrid_HDCP.Size = New System.Drawing.Size(495, 133)
        Me.MyGrid_HDCP.TabIndex = 35
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 14)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(37, 13)
        Me.Label20.TabIndex = 36
        Me.Label20.Text = "HDCP"
        '
        'MyGrid_Cert
        '
        Me.MyGrid_Cert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MyGrid_Cert.Location = New System.Drawing.Point(6, 181)
        Me.MyGrid_Cert.Name = "MyGrid_Cert"
        Me.MyGrid_Cert.Size = New System.Drawing.Size(495, 122)
        Me.MyGrid_Cert.TabIndex = 34
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 166)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(59, 13)
        Me.Label19.TabIndex = 36
        Me.Label19.Text = "Certificates"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.MyGrid_HDCP)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.MyGrid_Cert)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Location = New System.Drawing.Point(341, 274)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(507, 309)
        Me.GroupBox5.TabIndex = 43
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Certificates & HDCP"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(151, 523)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(532, 118)
        Me.TextBox2.TabIndex = 10
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TextBox8)
        Me.GroupBox6.Controls.Add(Me.TextBox2)
        Me.GroupBox6.Controls.Add(Me.TextBox1)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.GroupBox4)
        Me.GroupBox6.Location = New System.Drawing.Point(987, 12)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(709, 724)
        Me.GroupBox6.TabIndex = 44
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "GroupBox6"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(13, 38)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(299, 156)
        Me.TextBox8.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Description:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Model:"
        '
        'ComboBoxModel
        '
        Me.ComboBoxModel.FormattingEnabled = True
        Me.ComboBoxModel.Location = New System.Drawing.Point(92, 89)
        Me.ComboBoxModel.Name = "ComboBoxModel"
        Me.ComboBoxModel.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxModel.TabIndex = 2
        '
        'TB_Manuf
        '
        Me.TB_Manuf.Location = New System.Drawing.Point(97, 15)
        Me.TB_Manuf.Name = "TB_Manuf"
        Me.TB_Manuf.Size = New System.Drawing.Size(121, 20)
        Me.TB_Manuf.TabIndex = 0
        Me.TB_Manuf.Text = "DTVS"
        '
        'TB_PTID
        '
        Me.TB_PTID.Location = New System.Drawing.Point(97, 95)
        Me.TB_PTID.Name = "TB_PTID"
        Me.TB_PTID.Size = New System.Drawing.Size(121, 20)
        Me.TB_PTID.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Manufacturer:"
        '
        'TB_Operatop
        '
        Me.TB_Operatop.Location = New System.Drawing.Point(97, 42)
        Me.TB_Operatop.Name = "TB_Operatop"
        Me.TB_Operatop.Size = New System.Drawing.Size(121, 20)
        Me.TB_Operatop.TabIndex = 0
        Me.TB_Operatop.Text = "TRICOLOR"
        '
        'TB_Spec
        '
        Me.TB_Spec.Location = New System.Drawing.Point(92, 64)
        Me.TB_Spec.Name = "TB_Spec"
        Me.TB_Spec.Size = New System.Drawing.Size(121, 20)
        Me.TB_Spec.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CODE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Full CODE:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(40, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Operator:"
        '
        'TB_LotCode
        '
        Me.TB_LotCode.Location = New System.Drawing.Point(92, 14)
        Me.TB_LotCode.Name = "TB_LotCode"
        Me.TB_LotCode.Size = New System.Drawing.Size(121, 20)
        Me.TB_LotCode.TabIndex = 0
        '
        'TB_FullLotCode
        '
        Me.TB_FullLotCode.Location = New System.Drawing.Point(92, 39)
        Me.TB_FullLotCode.Name = "TB_FullLotCode"
        Me.TB_FullLotCode.Size = New System.Drawing.Size(121, 20)
        Me.TB_FullLotCode.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Specification:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(48, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Market:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(56, 98)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "PTID:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TB_Manuf)
        Me.GroupBox2.Controls.Add(Me.TB_PTID)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TB_Market)
        Me.GroupBox2.Controls.Add(Me.TB_Operatop)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(244, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(234, 177)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        '
        'TB_Market
        '
        Me.TB_Market.Location = New System.Drawing.Point(97, 68)
        Me.TB_Market.Name = "TB_Market"
        Me.TB_Market.Size = New System.Drawing.Size(121, 20)
        Me.TB_Market.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TB_Spec)
        Me.GroupBox1.Controls.Add(Me.TB_LotCode)
        Me.GroupBox1.Controls.Add(Me.TB_FullLotCode)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.ComboBoxModel)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TB_SNinLot)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(226, 175)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        '
        'AddNewLOT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1736, 801)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BT_RegisterNewLOT)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "AddNewLOT"
        Me.Text = "AddNewLOT"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DG_Model, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.MyGrid_HDCP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyGrid_Cert, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label12 As Label
    Friend WithEvents CB_CERT As CheckBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CB_CheckModel As CheckBox
    Friend WithEvents CB_SWGS1Version As CheckBox
    Friend WithEvents CB_SWVersion As CheckBox
    Friend WithEvents BT_AddCert As Button
    Friend WithEvents BT_AddHDCP As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents CB_MAC As CheckBox
    Friend WithEvents LB_HDCPCont As Label
    Friend WithEvents CB_HDCP As CheckBox
    Friend WithEvents LB_CertCont As Label
    Friend WithEvents TB_SNinLot As TextBox
    Friend WithEvents LB_MACCont As Label
    Friend WithEvents BT_RegisterNewLOT As Button
    Friend WithEvents DG_Model As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MyGrid_HDCP As DataGridView
    Friend WithEvents Label20 As Label
    Friend WithEvents MyGrid_Cert As DataGridView
    Friend WithEvents Label19 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBoxModel As ComboBox
    Friend WithEvents TB_Manuf As TextBox
    Friend WithEvents TB_PTID As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TB_Operatop As TextBox
    Friend WithEvents TB_Spec As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TB_LotCode As TextBox
    Friend WithEvents TB_FullLotCode As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TB_Market As TextBox
End Class

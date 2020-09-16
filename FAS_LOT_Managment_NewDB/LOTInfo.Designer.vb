<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOTInfo
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
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BT_AddCert = New System.Windows.Forms.Button()
        Me.BT_AddHDCP = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TB_SNinLot = New System.Windows.Forms.TextBox()
        Me.L_LabScenario = New System.Windows.Forms.Label()
        Me.L_LOTCreateDate = New System.Windows.Forms.Label()
        Me.L_UserName = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.MyGrid_HDCP = New System.Windows.Forms.DataGridView()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.MyGrid_Cert = New System.Windows.Forms.DataGridView()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.BT_AddSNToLOT = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DG_LotInfo = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.L_ModelCheck = New System.Windows.Forms.Label()
        Me.L_SWCheck = New System.Windows.Forms.Label()
        Me.L_SWGS1Check = New System.Windows.Forms.Label()
        Me.L_IsMACUpload = New System.Windows.Forms.Label()
        Me.L_IsCertUpload = New System.Windows.Forms.Label()
        Me.L_IsHDCPUpload = New System.Windows.Forms.Label()
        Me.L_LiterIndex = New System.Windows.Forms.Label()
        Me.L_LOTCode = New System.Windows.Forms.Label()
        Me.L_FullLOTCode = New System.Windows.Forms.Label()
        Me.L_ModelName = New System.Windows.Forms.Label()
        Me.L_Specification = New System.Windows.Forms.Label()
        Me.L_Manufacturer = New System.Windows.Forms.Label()
        Me.L_Operator = New System.Windows.Forms.Label()
        Me.L_MarketID = New System.Windows.Forms.Label()
        Me.L_PTID = New System.Windows.Forms.Label()
        Me.L_BoxCapacity = New System.Windows.Forms.Label()
        Me.L_PalletCapacity = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.MyGrid_HDCP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyGrid_Cert, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_LotInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(118, 16)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Прошивка HDCP:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label14.Location = New System.Drawing.Point(17, 64)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(117, 16)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Прошивка CERT:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BT_AddCert)
        Me.GroupBox3.Controls.Add(Me.BT_AddHDCP)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.TB_SNinLot)
        Me.GroupBox3.Location = New System.Drawing.Point(466, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(364, 108)
        Me.GroupBox3.TabIndex = 68
        Me.GroupBox3.TabStop = False
        '
        'BT_AddCert
        '
        Me.BT_AddCert.Location = New System.Drawing.Point(169, 45)
        Me.BT_AddCert.Name = "BT_AddCert"
        Me.BT_AddCert.Size = New System.Drawing.Size(70, 20)
        Me.BT_AddCert.TabIndex = 6
        Me.BT_AddCert.Text = "Add Cert"
        Me.BT_AddCert.UseVisualStyleBackColor = True
        Me.BT_AddCert.Visible = False
        '
        'BT_AddHDCP
        '
        Me.BT_AddHDCP.Location = New System.Drawing.Point(93, 45)
        Me.BT_AddHDCP.Name = "BT_AddHDCP"
        Me.BT_AddHDCP.Size = New System.Drawing.Size(70, 20)
        Me.BT_AddHDCP.TabIndex = 6
        Me.BT_AddHDCP.Text = "Add HDCP"
        Me.BT_AddHDCP.UseVisualStyleBackColor = True
        Me.BT_AddHDCP.Visible = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(27, 14)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(60, 13)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "SN in LOT:"
        '
        'TB_SNinLot
        '
        Me.TB_SNinLot.Location = New System.Drawing.Point(93, 10)
        Me.TB_SNinLot.Name = "TB_SNinLot"
        Me.TB_SNinLot.Size = New System.Drawing.Size(121, 20)
        Me.TB_SNinLot.TabIndex = 0
        Me.TB_SNinLot.Text = "0"
        '
        'L_LabScenario
        '
        Me.L_LabScenario.AutoSize = True
        Me.L_LabScenario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.L_LabScenario.Location = New System.Drawing.Point(181, 420)
        Me.L_LabScenario.Name = "L_LabScenario"
        Me.L_LabScenario.Size = New System.Drawing.Size(139, 16)
        Me.L_LabScenario.TabIndex = 66
        Me.L_LabScenario.Text = "Сценарий этикетки:"
        '
        'L_LOTCreateDate
        '
        Me.L_LOTCreateDate.AutoSize = True
        Me.L_LOTCreateDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.L_LOTCreateDate.Location = New System.Drawing.Point(181, 444)
        Me.L_LOTCreateDate.Name = "L_LOTCreateDate"
        Me.L_LOTCreateDate.Size = New System.Drawing.Size(142, 16)
        Me.L_LOTCreateDate.TabIndex = 65
        Me.L_LOTCreateDate.Text = "Дата создания лота:"
        '
        'L_UserName
        '
        Me.L_UserName.AutoSize = True
        Me.L_UserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.L_UserName.Location = New System.Drawing.Point(181, 468)
        Me.L_UserName.Name = "L_UserName"
        Me.L_UserName.Size = New System.Drawing.Size(116, 16)
        Me.L_UserName.TabIndex = 64
        Me.L_UserName.Text = "Создатель лота:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label19.Location = New System.Drawing.Point(59, 468)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(116, 16)
        Me.Label19.TabIndex = 63
        Me.Label19.Text = "Создатель лота:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label18.Location = New System.Drawing.Point(33, 444)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(142, 16)
        Me.Label18.TabIndex = 62
        Me.Label18.Text = "Дата создания лота:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label17.Location = New System.Drawing.Point(36, 420)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(139, 16)
        Me.Label17.TabIndex = 61
        Me.Label17.Text = "Сценарий этикетки:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.MyGrid_HDCP)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.MyGrid_Cert)
        Me.GroupBox5.Controls.Add(Me.Label22)
        Me.GroupBox5.Location = New System.Drawing.Point(466, 231)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(507, 309)
        Me.GroupBox5.TabIndex = 69
        Me.GroupBox5.TabStop = False
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
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 166)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(59, 13)
        Me.Label22.TabIndex = 36
        Me.Label22.Text = "Certificates"
        '
        'BT_AddSNToLOT
        '
        Me.BT_AddSNToLOT.Location = New System.Drawing.Point(466, 176)
        Me.BT_AddSNToLOT.Name = "BT_AddSNToLOT"
        Me.BT_AddSNToLOT.Size = New System.Drawing.Size(364, 23)
        Me.BT_AddSNToLOT.TabIndex = 70
        Me.BT_AddSNToLOT.Text = "Увеличить ЛОТ"
        Me.BT_AddSNToLOT.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DG_LotInfo)
        Me.GroupBox1.Location = New System.Drawing.Point(1006, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(398, 358)
        Me.GroupBox1.TabIndex = 71
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        Me.GroupBox1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(101, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Lot Info"
        '
        'DG_LotInfo
        '
        Me.DG_LotInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_LotInfo.Location = New System.Drawing.Point(101, 65)
        Me.DG_LotInfo.Name = "DG_LotInfo"
        Me.DG_LotInfo.Size = New System.Drawing.Size(291, 150)
        Me.DG_LotInfo.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label12.Location = New System.Drawing.Point(34, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 16)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Литер индекс:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.L_ModelCheck)
        Me.GroupBox2.Controls.Add(Me.L_SWCheck)
        Me.GroupBox2.Controls.Add(Me.L_SWGS1Check)
        Me.GroupBox2.Controls.Add(Me.L_IsMACUpload)
        Me.GroupBox2.Controls.Add(Me.L_IsCertUpload)
        Me.GroupBox2.Controls.Add(Me.L_IsHDCPUpload)
        Me.GroupBox2.Controls.Add(Me.L_LiterIndex)
        Me.GroupBox2.Location = New System.Drawing.Point(39, 234)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(272, 184)
        Me.GroupBox2.TabIndex = 72
        Me.GroupBox2.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label15.Location = New System.Drawing.Point(25, 88)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(109, 16)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Прошивка MAC:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label16.Location = New System.Drawing.Point(6, 112)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(128, 16)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Проверка модели:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label23.Location = New System.Drawing.Point(33, 136)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(101, 16)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "Проверка SW:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label25.Location = New System.Drawing.Point(7, 160)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(127, 16)
        Me.Label25.TabIndex = 2
        Me.Label25.Text = "Проверка SWGS1:"
        '
        'L_ModelCheck
        '
        Me.L_ModelCheck.AutoSize = True
        Me.L_ModelCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.L_ModelCheck.Location = New System.Drawing.Point(142, 112)
        Me.L_ModelCheck.Name = "L_ModelCheck"
        Me.L_ModelCheck.Size = New System.Drawing.Size(125, 16)
        Me.L_ModelCheck.TabIndex = 2
        Me.L_ModelCheck.Text = "Проверка модели"
        '
        'L_SWCheck
        '
        Me.L_SWCheck.AutoSize = True
        Me.L_SWCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.L_SWCheck.Location = New System.Drawing.Point(142, 136)
        Me.L_SWCheck.Name = "L_SWCheck"
        Me.L_SWCheck.Size = New System.Drawing.Size(101, 16)
        Me.L_SWCheck.TabIndex = 2
        Me.L_SWCheck.Text = "Проверка SW:"
        '
        'L_SWGS1Check
        '
        Me.L_SWGS1Check.AutoSize = True
        Me.L_SWGS1Check.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.L_SWGS1Check.Location = New System.Drawing.Point(142, 160)
        Me.L_SWGS1Check.Name = "L_SWGS1Check"
        Me.L_SWGS1Check.Size = New System.Drawing.Size(127, 16)
        Me.L_SWGS1Check.TabIndex = 2
        Me.L_SWGS1Check.Text = "Проверка SWGS1:"
        '
        'L_IsMACUpload
        '
        Me.L_IsMACUpload.AutoSize = True
        Me.L_IsMACUpload.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.L_IsMACUpload.Location = New System.Drawing.Point(142, 88)
        Me.L_IsMACUpload.Name = "L_IsMACUpload"
        Me.L_IsMACUpload.Size = New System.Drawing.Size(109, 16)
        Me.L_IsMACUpload.TabIndex = 2
        Me.L_IsMACUpload.Text = "Прошивка MAC:"
        '
        'L_IsCertUpload
        '
        Me.L_IsCertUpload.AutoSize = True
        Me.L_IsCertUpload.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.L_IsCertUpload.Location = New System.Drawing.Point(142, 64)
        Me.L_IsCertUpload.Name = "L_IsCertUpload"
        Me.L_IsCertUpload.Size = New System.Drawing.Size(117, 16)
        Me.L_IsCertUpload.TabIndex = 2
        Me.L_IsCertUpload.Text = "Прошивка CERT:"
        '
        'L_IsHDCPUpload
        '
        Me.L_IsHDCPUpload.AutoSize = True
        Me.L_IsHDCPUpload.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.L_IsHDCPUpload.Location = New System.Drawing.Point(142, 40)
        Me.L_IsHDCPUpload.Name = "L_IsHDCPUpload"
        Me.L_IsHDCPUpload.Size = New System.Drawing.Size(118, 16)
        Me.L_IsHDCPUpload.TabIndex = 2
        Me.L_IsHDCPUpload.Text = "Прошивка HDCP:"
        '
        'L_LiterIndex
        '
        Me.L_LiterIndex.AutoSize = True
        Me.L_LiterIndex.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.L_LiterIndex.Location = New System.Drawing.Point(142, 16)
        Me.L_LiterIndex.Name = "L_LiterIndex"
        Me.L_LiterIndex.Size = New System.Drawing.Size(100, 16)
        Me.L_LiterIndex.TabIndex = 2
        Me.L_LiterIndex.Text = "Литер индекс:"
        '
        'L_LOTCode
        '
        Me.L_LOTCode.AutoSize = True
        Me.L_LOTCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.L_LOTCode.Location = New System.Drawing.Point(183, 1)
        Me.L_LOTCode.Name = "L_LOTCode"
        Me.L_LOTCode.Size = New System.Drawing.Size(93, 16)
        Me.L_LOTCode.TabIndex = 60
        Me.L_LOTCode.Text = "Номер ЛОТа:"
        '
        'L_FullLOTCode
        '
        Me.L_FullLOTCode.AutoSize = True
        Me.L_FullLOTCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.L_FullLOTCode.Location = New System.Drawing.Point(183, 25)
        Me.L_FullLOTCode.Name = "L_FullLOTCode"
        Me.L_FullLOTCode.Size = New System.Drawing.Size(167, 16)
        Me.L_FullLOTCode.TabIndex = 59
        Me.L_FullLOTCode.Text = "Полное название ЛОТа:"
        '
        'L_ModelName
        '
        Me.L_ModelName.AutoSize = True
        Me.L_ModelName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.L_ModelName.Location = New System.Drawing.Point(183, 49)
        Me.L_ModelName.Name = "L_ModelName"
        Me.L_ModelName.Size = New System.Drawing.Size(61, 16)
        Me.L_ModelName.TabIndex = 58
        Me.L_ModelName.Text = "Модель:"
        '
        'L_Specification
        '
        Me.L_Specification.AutoSize = True
        Me.L_Specification.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.L_Specification.Location = New System.Drawing.Point(183, 73)
        Me.L_Specification.Name = "L_Specification"
        Me.L_Specification.Size = New System.Drawing.Size(109, 16)
        Me.L_Specification.TabIndex = 42
        Me.L_Specification.Text = "Спецификация:"
        '
        'L_Manufacturer
        '
        Me.L_Manufacturer.AutoSize = True
        Me.L_Manufacturer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.L_Manufacturer.Location = New System.Drawing.Point(183, 97)
        Me.L_Manufacturer.Name = "L_Manufacturer"
        Me.L_Manufacturer.Size = New System.Drawing.Size(115, 16)
        Me.L_Manufacturer.TabIndex = 56
        Me.L_Manufacturer.Text = "Производитель:"
        '
        'L_Operator
        '
        Me.L_Operator.AutoSize = True
        Me.L_Operator.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.L_Operator.Location = New System.Drawing.Point(183, 121)
        Me.L_Operator.Name = "L_Operator"
        Me.L_Operator.Size = New System.Drawing.Size(76, 16)
        Me.L_Operator.TabIndex = 47
        Me.L_Operator.Text = "Оператор:"
        '
        'L_MarketID
        '
        Me.L_MarketID.AutoSize = True
        Me.L_MarketID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.L_MarketID.Location = New System.Drawing.Point(183, 145)
        Me.L_MarketID.Name = "L_MarketID"
        Me.L_MarketID.Size = New System.Drawing.Size(82, 16)
        Me.L_MarketID.TabIndex = 43
        Me.L_MarketID.Text = "Маркет ИД:"
        '
        'L_PTID
        '
        Me.L_PTID.AutoSize = True
        Me.L_PTID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.L_PTID.Location = New System.Drawing.Point(183, 169)
        Me.L_PTID.Name = "L_PTID"
        Me.L_PTID.Size = New System.Drawing.Size(42, 16)
        Me.L_PTID.TabIndex = 44
        Me.L_PTID.Text = "PTID:"
        '
        'L_BoxCapacity
        '
        Me.L_BoxCapacity.AutoSize = True
        Me.L_BoxCapacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.L_BoxCapacity.Location = New System.Drawing.Point(183, 193)
        Me.L_BoxCapacity.Name = "L_BoxCapacity"
        Me.L_BoxCapacity.Size = New System.Drawing.Size(139, 16)
        Me.L_BoxCapacity.TabIndex = 45
        Me.L_BoxCapacity.Text = "Кол-во в групповой:"
        '
        'L_PalletCapacity
        '
        Me.L_PalletCapacity.AutoSize = True
        Me.L_PalletCapacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.L_PalletCapacity.Location = New System.Drawing.Point(183, 217)
        Me.L_PalletCapacity.Name = "L_PalletCapacity"
        Me.L_PalletCapacity.Size = New System.Drawing.Size(124, 16)
        Me.L_PalletCapacity.TabIndex = 46
        Me.L_PalletCapacity.Text = "Кол-во в паллете:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label11.Location = New System.Drawing.Point(51, 217)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(124, 16)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Кол-во в паллете:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label10.Location = New System.Drawing.Point(36, 193)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(139, 16)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Кол-во в групповой:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label8.Location = New System.Drawing.Point(93, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 16)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Маркет ИД:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label9.Location = New System.Drawing.Point(133, 169)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 16)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "PTID:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label7.Location = New System.Drawing.Point(99, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 16)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Оператор:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.Location = New System.Drawing.Point(60, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 16)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Производитель:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(114, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 16)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Модель:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 16)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Полное название ЛОТа:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(82, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Номер ЛОТа:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(66, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 16)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Спецификация:"
        '
        'LOTInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1422, 604)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.L_LabScenario)
        Me.Controls.Add(Me.L_LOTCreateDate)
        Me.Controls.Add(Me.L_UserName)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.BT_AddSNToLOT)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.L_LOTCode)
        Me.Controls.Add(Me.L_FullLOTCode)
        Me.Controls.Add(Me.L_ModelName)
        Me.Controls.Add(Me.L_Specification)
        Me.Controls.Add(Me.L_Manufacturer)
        Me.Controls.Add(Me.L_Operator)
        Me.Controls.Add(Me.L_MarketID)
        Me.Controls.Add(Me.L_PTID)
        Me.Controls.Add(Me.L_BoxCapacity)
        Me.Controls.Add(Me.L_PalletCapacity)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Name = "LOTInfo"
        Me.Text = "LOTInfo"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.MyGrid_HDCP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyGrid_Cert, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DG_LotInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BT_AddCert As Button
    Friend WithEvents BT_AddHDCP As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents TB_SNinLot As TextBox
    Friend WithEvents L_LabScenario As Label
    Friend WithEvents L_LOTCreateDate As Label
    Friend WithEvents L_UserName As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents MyGrid_HDCP As DataGridView
    Friend WithEvents Label20 As Label
    Friend WithEvents MyGrid_Cert As DataGridView
    Friend WithEvents Label22 As Label
    Friend WithEvents BT_AddSNToLOT As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DG_LotInfo As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents L_ModelCheck As Label
    Friend WithEvents L_SWCheck As Label
    Friend WithEvents L_SWGS1Check As Label
    Friend WithEvents L_IsMACUpload As Label
    Friend WithEvents L_IsCertUpload As Label
    Friend WithEvents L_IsHDCPUpload As Label
    Friend WithEvents L_LiterIndex As Label
    Friend WithEvents L_LOTCode As Label
    Friend WithEvents L_FullLOTCode As Label
    Friend WithEvents L_ModelName As Label
    Friend WithEvents L_Specification As Label
    Friend WithEvents L_Manufacturer As Label
    Friend WithEvents L_Operator As Label
    Friend WithEvents L_MarketID As Label
    Friend WithEvents L_PTID As Label
    Friend WithEvents L_BoxCapacity As Label
    Friend WithEvents L_PalletCapacity As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
End Class

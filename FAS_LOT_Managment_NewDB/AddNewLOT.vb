Imports Library3

Public Class AddNewLOT
    Dim SQL As String
    'загрузка формы, получение значений Модель, рабочий сценарий и сценарий печати
    Private Sub AddNewLOT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGridFromDB(DG_Model, "use FAS Select * From [FAS].[dbo].[FAS_Models] where ModelTypeID = 1")
        'заполнение комбобокса для Модели, рабочего сценария и печати
        addToList(ComboBoxModel, DG_Model, 1)
    End Sub

    'отработка кнопки "зарегистрировать ЛОТ"
    Dim HDCPPath, HDCPName, CertPath, CertName, FullLotCode As String
    Private Sub BT_RegisterNewLOT_Click(sender As Object, e As EventArgs) Handles BT_RegisterNewLOT.Click
        If TB_LotCode.Text = "" Or TB_FullLotCode.Text = "" Or TB_Spec.Text = "" Or ComboBoxModel.Text = "" Or TB_PTID.Text = "" Or
            TB_SNinLot.Text = "" Then
            MsgBox("Заполнены не все поля")
        Else
            FullLotCode = TB_FullLotCode.Text
            SeveLot() ' SUB для регистрации нового ЛОТа
        End If
    End Sub

    Dim LOTID As Integer
    Private Sub SeveLot() ' SUB для регистрации нового ЛОТа
        'Поиск ModelID, WorkingScenarioID, LabelScenarioID 
        Dim ModelID, WorkingScenarioID, LabelScenarioID As Integer
        ModelID = SearchInList(ComboBoxModel, DG_Model, 1, 0)
        'запрос на добавление нового лота в базу данных в таблицу FAS_GS_LOTs и запрос на определение последнего зарегистрированного лота 
        SQL = "use FAS
        insert into [FAS].[dbo].[SDTV_LOT] ([LOT],[Full_LOT_Name],[Specification],[ModelID],[IsActive],[IsHDCPUpload],[IsCertUpload],
        [IsMACUpload],[ModelCheck],[SWRead],[SWGS1Read],[Manufacture],[Operator],[MarketID],[PTID]) 
        values (" & TB_LotCode.Text & ",'" & FullLotCode & "','" & TB_Spec.Text & "'," & ModelID & ",1,'" & CB_HDCP.Checked & "','" & CB_CERT.Checked & "','" & CB_MAC.Checked & "'
        ,'" & CB_CheckModel.Checked & "','" & CB_SWVersion.Checked & "' ,'" & CB_SWGS1Version.Checked & "','" & TB_Manuf.Text & "','" & TB_Operatop.Text & "','" & TB_Market.Text & "','" & TB_PTID.Text & "')
        SELECT TOP (1) LOTID FROM [FAS].[dbo].[SDTV_LOT] order by lotid desc"
        LOTID = SelectString(SQL)

        Dim LotSize As Integer = TB_SNinLot.Text
        For i = 1 To LotSize
            'берем HDCP  из грида 
            HDCPName = ""
            HDCPPath = ""
            If MyGrid_HDCP.Rows.Count <> 0 And CB_HDCP.Checked = True Then
                HDCPName = GetColumnValue(MyGrid_HDCP, i, 0)
                HDCPPath = GetColumnValue(MyGrid_HDCP, i, 1)
            End If
            'берем Cert  из грида 
            CertName = ""
            CERTPath = ""
            If MyGrid_Cert.Rows.Count <> 0 And CB_CERT.Checked = True Then
                CertName = GetColumnValue(MyGrid_Cert, i, 0)
                CERTPath = GetColumnValue(MyGrid_Cert, i, 1)
            End If

            'запрос на добавление связок для серийного номера в таблицу FAS_SerialNumbers, FAS_HDCP, FAS_CERT
            SQL = "use FAS
                    declare @SN as int
                    insert into [FAS].[dbo].[SDTV_Upload] ([LOTID]) values (" & LOTID & ")
                    select @SN = (select top 1 SN from [FAS].[dbo].[SDTV_Upload] order by SN desc)                    
                    insert into [FAS].[dbo].[FAS_HDCP] ([SerialNumber],[HDCPName],[HDCPContent]) values (@SN,'" & HDCPName & "', 0x" & FileToArray(HDCPPath) & ")
                    insert into [FAS].[dbo].[FAS_CERT] ([SerialNumber],[CERTName],[CertContent]) values (@SN,'" & CertName & "', 0x" & FileToArray(CertPath) & ")
                    select @SN"
            GenerateFullSTBSN_SDTV(SelectString(SQL), TB_LotCode.Text, LOTID)
        Next
        LOT_List.Show()
        Me.Close()
        'обновление таблицы лотов во вкладке LOTList
        GetLotList_SDTV(LOT_List.DG_LotList)
        LOT_List.DG_LotList.Sort(LOT_List.DG_LotList.Columns(3), System.ComponentModel.ListSortDirection.Descending) ' сортировка

    End Sub

    Private Sub BT_AddHDCP_Click(sender As Object, e As EventArgs) Handles BT_AddHDCP.Click
        FolderBrowserDialog1.ShowDialog() ' открыть браузер диалог
        Dim folderPath As String = FolderBrowserDialog1.SelectedPath ' запомнить путь
        ListFiles(folderPath, MyGrid_HDCP) ' прочитать имена файлов в указанной дериктории
    End Sub

    Private Sub BT_AddCert_Click(sender As Object, e As EventArgs) Handles BT_AddCert.Click
        FolderBrowserDialog1.ShowDialog() ' открыть браузер диалог
        Dim folderPath As String = FolderBrowserDialog1.SelectedPath ' запомнить путь
        ListFiles(folderPath, MyGrid_Cert) ' прочитать имена файлов в указанной дериктории
    End Sub

    'добавить HDCP в лот 
    Private Sub CB_HDCP_CheckedChanged(sender As Object, e As EventArgs) Handles CB_HDCP.CheckedChanged
        If CB_HDCP.Checked = True Then
            BT_AddHDCP.Visible = True
        Else
            BT_AddHDCP.Visible = False
            MyGrid_HDCP.Rows.Clear()
        End If
    End Sub
    'добавить Cert в лот 
    Private Sub CB_CERT_CheckedChanged(sender As Object, e As EventArgs) Handles CB_CERT.CheckedChanged
        If CB_CERT.Checked = True Then
            BT_AddCert.Visible = True
        Else
            BT_AddCert.Visible = False
            MyGrid_Cert.Rows.Clear()
        End If
    End Sub

    'не позволяет писать буквы в текстбокс
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TB_LotCode.TextChanged 'Устанавливается правило, при котором в TextBox нельзя писать буквы, только цифры от 0 до 9
        TB_LotCode.MaxLength = 3
        If TB_LotCode.Text Like "*[!0-9]*" Then _
     TB_LotCode.Text = TB_LotCode.Tag _
     Else : TB_LotCode.Tag = TB_LotCode.Text
    End Sub
End Class
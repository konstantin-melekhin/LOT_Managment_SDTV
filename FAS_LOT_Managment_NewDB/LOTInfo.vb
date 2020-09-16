Imports Library_2

Public Class LOTInfo

    Dim SQL, NewHDCPPath, NewCertPath, FullLotCode As String
    Dim LOTID As Integer
    Private Sub LOTInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOTID = LOT_List.LOTID
        'загружаем список лотов в грид SQL запрос "LotList" расположен в File_Procedures
        LoadGridFromDB(DG_LotInfo, GetLotInfo & LOTID)
        L_LOTCode.Text = DG_LotInfo.Rows(0).Cells(1).Value
        L_FullLOTCode.Text = DG_LotInfo.Rows(0).Cells(2).Value
        FullLotCode = L_FullLOTCode.Text
        L_ModelName.Text = DG_LotInfo.Rows(0).Cells(3).Value
        L_Specification.Text = DG_LotInfo.Rows(0).Cells(4).Value
        L_Manufacturer.Text = DG_LotInfo.Rows(0).Cells(5).Value
        L_Operator.Text = DG_LotInfo.Rows(0).Cells(6).Value
        L_MarketID.Text = DG_LotInfo.Rows(0).Cells(7).Value
        L_PTID.Text = DG_LotInfo.Rows(0).Cells(8).Value
        L_BoxCapacity.Text = DG_LotInfo.Rows(0).Cells(9).Value
        L_PalletCapacity.Text = DG_LotInfo.Rows(0).Cells(10).Value
        L_LiterIndex.Text = DG_LotInfo.Rows(0).Cells(11).Value
        L_IsHDCPUpload.Text = DG_LotInfo.Rows(0).Cells(12).Value
        If DG_LotInfo.Rows(0).Cells(12).Value = True Then
            BT_AddHDCP.Visible = True
        End If
        L_IsCertUpload.Text = DG_LotInfo.Rows(0).Cells(13).Value
        If DG_LotInfo.Rows(0).Cells(13).Value = True Then
            BT_AddCert.Visible = True
        End If
        L_IsMACUpload.Text = DG_LotInfo.Rows(0).Cells(14).Value
        L_ModelCheck.Text = DG_LotInfo.Rows(0).Cells(19).Value
        L_SWCheck.Text = DG_LotInfo.Rows(0).Cells(20).Value
        L_SWGS1Check.Text = DG_LotInfo.Rows(0).Cells(21).Value
        L_LabScenario.Text = DG_LotInfo.Rows(0).Cells(16).Value
        L_LOTCreateDate.Text = DG_LotInfo.Rows(0).Cells(17).Value
        L_UserName.Text = DG_LotInfo.Rows(0).Cells(18).Value
    End Sub
    'загрузка HDCP и CERT в гриды
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

    Private Sub BT_AddSNToLOT_Click(sender As Object, e As EventArgs) Handles BT_AddSNToLOT.Click
        Dim HDCPName, HDCPPath, CertName, CertPath As String 'MACHex, MAC
        Dim LotSize As Integer = TB_SNinLot.Text
        For i = 1 To LotSize
            If L_IsHDCPUpload.Text = True Then
                HDCPName = ""
                HDCPPath = ""
                HDCPName = MyGrid_HDCP.Rows(i - 1).Cells(0).Value
                HDCPPath = MyGrid_HDCP.Rows(i - 1).Cells(1).Value
            End If
            If L_IsCertUpload.Text = True Then
                CertName = ""
                CertPath = ""
                CertName = MyGrid_Cert.Rows(i - 1).Cells(0).Value
                CertPath = MyGrid_Cert.Rows(i - 1).Cells(1).Value
            End If
            'запрос на добавление связок для серийного номера в таблицу FAS_SerialNumbers, FAS_HDCP, FAS_CERT
            SQL = "use FAS
                    declare @SN as int
                    insert into [FAS].[dbo].[FAS_SerialNumbers] ([LOTID],[IsUsed],[IsActive],[IsUploaded],[IsWeighted],[IsPacked]) values (" & LOTID & ",0,1,0,0,0)
                    select @SN = (select top 1 SerialNumber from [FAS].[dbo].[FAS_SerialNumbers] order by SerialNumber desc)
                    insert into [FAS].[dbo].[FAS_HDCP] ([SerialNumber],[HDCPName],[HDCPContent]) values (@SN,'" & HDCPName & "', 0x" & FileToArray(HDCPPath) & ")
                    insert into [FAS].[dbo].[FAS_CERT] ([SerialNumber],[CERTName],[CertContent]) values (@SN,'" & CertName & "', 0x" & FileToArray(CertPath) & ")"
            RunCommand(SQL)
        Next
        Me.Close()
        'обновление таблицы лотов во вкладке LOTList
        GetConnect()
        LoadGridFromDB(LOT_List.DG_LotList, LotList_LOTManagment)
        conn.Close()
        LOT_List.DG_LotList.Sort(LOT_List.DG_LotList.Columns(3), System.ComponentModel.ListSortDirection.Descending) ' сортировка

    End Sub

End Class
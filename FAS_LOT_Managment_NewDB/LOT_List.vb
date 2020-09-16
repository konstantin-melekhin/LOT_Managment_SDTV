Imports Library3

Public Class LOT_List
    Private Sub LOT_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'загружаем список лотов в грид SQL запрос "LotList" расположен в File_Procedures
        GetLotList_SDTV(DG_LotList)
        'сортировка griв по выбранному столбцу (дата)
        DG_LotList.Sort(DG_LotList.Columns(1), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    'добавить новый лот
    Private Sub BT_AddLot_Click(sender As Object, e As EventArgs) Handles BT_AddLot.Click
        AddNewLOT.Show()
    End Sub

    Public selRowNum, LOTID, LOTCode As Integer
    Private Sub DG_LOTListPresent_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_LotList.CellClick
        selRowNum = DG_LotList.CurrentCell.RowIndex
    End Sub
    'запуск лотинфо
    Private Sub BT_LOT_Info_Click(sender As Object, e As EventArgs) Handles BT_LOT_Info.Click
        'определяем LOTCode и LOTID
        If DG_LotList.Rows.Count <> 0 Then
            LOTID = DG_LotList.Rows(selRowNum).Cells(7).Value
            LOTInfo.Show()
        Else
            MsgBox("ЛОТ не выбран!")
        End If
    End Sub
End Class


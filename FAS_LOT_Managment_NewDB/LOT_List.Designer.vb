<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LOT_List
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GB_WorkAria = New System.Windows.Forms.GroupBox()
        Me.DG_LotList = New System.Windows.Forms.DataGridView()
        Me.L_UserName = New System.Windows.Forms.Label()
        Me.BT_AddLot = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BT_LOT_Info = New System.Windows.Forms.Button()
        Me.MLOTsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GB_WorkAria.SuspendLayout()
        CType(Me.DG_LotList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MLOTsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GB_WorkAria
        '
        Me.GB_WorkAria.Controls.Add(Me.DG_LotList)
        Me.GB_WorkAria.Controls.Add(Me.L_UserName)
        Me.GB_WorkAria.Controls.Add(Me.BT_AddLot)
        Me.GB_WorkAria.Controls.Add(Me.Label5)
        Me.GB_WorkAria.Controls.Add(Me.BT_LOT_Info)
        Me.GB_WorkAria.Location = New System.Drawing.Point(7, 6)
        Me.GB_WorkAria.Name = "GB_WorkAria"
        Me.GB_WorkAria.Size = New System.Drawing.Size(1035, 496)
        Me.GB_WorkAria.TabIndex = 44
        Me.GB_WorkAria.TabStop = False
        '
        'DG_LotList
        '
        Me.DG_LotList.AllowUserToAddRows = False
        Me.DG_LotList.AllowUserToDeleteRows = False
        Me.DG_LotList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_LotList.Location = New System.Drawing.Point(31, 25)
        Me.DG_LotList.Name = "DG_LotList"
        Me.DG_LotList.ReadOnly = True
        Me.DG_LotList.Size = New System.Drawing.Size(919, 402)
        Me.DG_LotList.TabIndex = 0
        '
        'L_UserName
        '
        Me.L_UserName.AutoSize = True
        Me.L_UserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.L_UserName.Location = New System.Drawing.Point(219, 25)
        Me.L_UserName.Name = "L_UserName"
        Me.L_UserName.Size = New System.Drawing.Size(174, 20)
        Me.L_UserName.TabIndex = 34
        Me.L_UserName.Text = "Имя пользователя:"
        '
        'BT_AddLot
        '
        Me.BT_AddLot.FlatAppearance.BorderSize = 0
        Me.BT_AddLot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_AddLot.Image = Global.FAS_LOT_Managment_NewDB.My.Resources.Resources.document__1_
        Me.BT_AddLot.Location = New System.Drawing.Point(967, 55)
        Me.BT_AddLot.Name = "BT_AddLot"
        Me.BT_AddLot.Size = New System.Drawing.Size(59, 69)
        Me.BT_AddLot.TabIndex = 1
        Me.BT_AddLot.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(42, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(174, 20)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Имя пользователя:"
        '
        'BT_LOT_Info
        '
        Me.BT_LOT_Info.FlatAppearance.BorderSize = 0
        Me.BT_LOT_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_LOT_Info.Image = Global.FAS_LOT_Managment_NewDB.My.Resources.Resources.info
        Me.BT_LOT_Info.Location = New System.Drawing.Point(967, 130)
        Me.BT_LOT_Info.Name = "BT_LOT_Info"
        Me.BT_LOT_Info.Size = New System.Drawing.Size(62, 61)
        Me.BT_LOT_Info.TabIndex = 2
        Me.BT_LOT_Info.UseVisualStyleBackColor = True
        '
        'MLOTsBindingSource
        '
        Me.MLOTsBindingSource.DataMember = "M_LOTs"
        '
        'LOT_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1474, 571)
        Me.Controls.Add(Me.GB_WorkAria)
        Me.Name = "LOT_List"
        Me.Text = "LOT_List"
        Me.GB_WorkAria.ResumeLayout(False)
        Me.GB_WorkAria.PerformLayout()
        CType(Me.DG_LotList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MLOTsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GB_WorkAria As GroupBox
    Friend WithEvents DG_LotList As DataGridView
    Friend WithEvents L_UserName As Label
    Friend WithEvents BT_AddLot As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents BT_LOT_Info As Button
    Friend WithEvents MLOTsBindingSource As BindingSource
End Class

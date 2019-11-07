<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
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
        Me.components = New System.ComponentModel.Container
        Me.DBxDataSet = New SelfCon.DBxDataSet
        Me.TPINSDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TPINSDataTableAdapter = New SelfCon.DBxDataSetTableAdapters.TPINSDataTableAdapter
        Me.TableAdapterManager = New SelfCon.DBxDataSetTableAdapters.TableAdapterManager
        Me.TPINSDataDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btSearch = New System.Windows.Forms.Button
        Me.tbLot = New System.Windows.Forms.TextBox
        Me.btclose = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button10 = New System.Windows.Forms.Button
        Me.Button11 = New System.Windows.Forms.Button
        Me.Button12 = New System.Windows.Forms.Button
        Me.Button13 = New System.Windows.Forms.Button
        Me.Button14 = New System.Windows.Forms.Button
        Me.Button15 = New System.Windows.Forms.Button
        Me.Button16 = New System.Windows.Forms.Button
        Me.Button17 = New System.Windows.Forms.Button
        Me.Button18 = New System.Windows.Forms.Button
        Me.Button19 = New System.Windows.Forms.Button
        Me.Button20 = New System.Windows.Forms.Button
        Me.Button21 = New System.Windows.Forms.Button
        Me.Button22 = New System.Windows.Forms.Button
        Me.Button23 = New System.Windows.Forms.Button
        Me.Button24 = New System.Windows.Forms.Button
        Me.Button26 = New System.Windows.Forms.Button
        Me.Button27 = New System.Windows.Forms.Button
        Me.Button28 = New System.Windows.Forms.Button
        Me.Button29 = New System.Windows.Forms.Button
        Me.Button30 = New System.Windows.Forms.Button
        Me.Button31 = New System.Windows.Forms.Button
        Me.Button32 = New System.Windows.Forms.Button
        Me.Button33 = New System.Windows.Forms.Button
        Me.Button34 = New System.Windows.Forms.Button
        Me.Button36 = New System.Windows.Forms.Button
        Me.Button37 = New System.Windows.Forms.Button
        Me.Button38 = New System.Windows.Forms.Button
        Me.Button39 = New System.Windows.Forms.Button
        Me.Button40 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.DBxDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TPINSDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TPINSDataDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DBxDataSet
        '
        Me.DBxDataSet.DataSetName = "DBxDataSet"
        Me.DBxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TPINSDataBindingSource
        '
        Me.TPINSDataBindingSource.DataMember = "TPINSData"
        Me.TPINSDataBindingSource.DataSource = Me.DBxDataSet
        '
        'TPINSDataTableAdapter
        '
        Me.TPINSDataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TPINSDataTableAdapter = Me.TPINSDataTableAdapter
        Me.TableAdapterManager.UpdateOrder = SelfCon.DBxDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TPINSDataDataGridView
        '
        Me.TPINSDataDataGridView.AllowUserToAddRows = False
        Me.TPINSDataDataGridView.AllowUserToDeleteRows = False
        Me.TPINSDataDataGridView.AutoGenerateColumns = False
        Me.TPINSDataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TPINSDataDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24})
        Me.TPINSDataDataGridView.DataSource = Me.TPINSDataBindingSource
        Me.TPINSDataDataGridView.Location = New System.Drawing.Point(12, 59)
        Me.TPINSDataDataGridView.Name = "TPINSDataDataGridView"
        Me.TPINSDataDataGridView.ReadOnly = True
        Me.TPINSDataDataGridView.Size = New System.Drawing.Size(622, 86)
        Me.TPINSDataDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "LotNo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "LotNo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "StartTime"
        Me.DataGridViewTextBoxColumn2.HeaderText = "StartTime"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "EndTime"
        Me.DataGridViewTextBoxColumn3.HeaderText = "EndTime"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ReqDate"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ReqDate"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ReqMode1"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ReqMode1"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ReqMode2"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ReqMode2"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ReqMode3"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ReqMode3"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ReqMode4"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ReqMode4"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "MCNo"
        Me.DataGridViewTextBoxColumn9.HeaderText = "MCNo"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "OPNo"
        Me.DataGridViewTextBoxColumn10.HeaderText = "OPNo"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "InspQty"
        Me.DataGridViewTextBoxColumn11.HeaderText = "InspQty"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "GoodQty"
        Me.DataGridViewTextBoxColumn12.HeaderText = "GoodQty"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "NGQty"
        Me.DataGridViewTextBoxColumn13.HeaderText = "NGQty"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "NGMode1"
        Me.DataGridViewTextBoxColumn14.HeaderText = "NGMode1"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "NGMode2"
        Me.DataGridViewTextBoxColumn15.HeaderText = "NGMode2"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "NGMode3"
        Me.DataGridViewTextBoxColumn16.HeaderText = "NGMode3"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "NGMode4"
        Me.DataGridViewTextBoxColumn17.HeaderText = "NGMode4"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "NGMode5"
        Me.DataGridViewTextBoxColumn18.HeaderText = "NGMode5"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "InspectorNo"
        Me.DataGridViewTextBoxColumn19.HeaderText = "InspectorNo"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "UrgentLot"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "UrgentLot"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "LotJudg"
        Me.DataGridViewTextBoxColumn20.HeaderText = "LotJudg"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "FinalYield"
        Me.DataGridViewTextBoxColumn21.HeaderText = "FinalYield"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "GLCheck"
        Me.DataGridViewTextBoxColumn22.HeaderText = "GLCheck"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "ComName"
        Me.DataGridViewTextBoxColumn23.HeaderText = "ComName"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Remark"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Remark"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        '
        'btSearch
        '
        Me.btSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btSearch.Location = New System.Drawing.Point(415, 161)
        Me.btSearch.Name = "btSearch"
        Me.btSearch.Size = New System.Drawing.Size(138, 38)
        Me.btSearch.TabIndex = 1
        Me.btSearch.Text = "Search"
        Me.btSearch.UseVisualStyleBackColor = False
        '
        'tbLot
        '
        Me.tbLot.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.tbLot.Location = New System.Drawing.Point(161, 161)
        Me.tbLot.Name = "tbLot"
        Me.tbLot.Size = New System.Drawing.Size(232, 38)
        Me.tbLot.TabIndex = 2
        '
        'btclose
        '
        Me.btclose.BackColor = System.Drawing.Color.Red
        Me.btclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btclose.Location = New System.Drawing.Point(474, 397)
        Me.btclose.Name = "btclose"
        Me.btclose.Size = New System.Drawing.Size(160, 54)
        Me.btclose.TabIndex = 1
        Me.btclose.Text = "Close"
        Me.btclose.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 31)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Lot No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(223, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 31)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Search LotNo."
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Location = New System.Drawing.Point(12, 225)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(57, 44)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "1"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Location = New System.Drawing.Point(75, 225)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(57, 44)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "2"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Location = New System.Drawing.Point(138, 225)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(57, 44)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "3"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.Location = New System.Drawing.Point(202, 225)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(57, 44)
        Me.Button6.TabIndex = 4
        Me.Button6.Text = "4"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.Location = New System.Drawing.Point(265, 225)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(57, 44)
        Me.Button7.TabIndex = 4
        Me.Button7.Text = "5"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.Location = New System.Drawing.Point(328, 225)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(57, 44)
        Me.Button8.TabIndex = 4
        Me.Button8.Text = "6"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button9.Location = New System.Drawing.Point(391, 225)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(57, 44)
        Me.Button9.TabIndex = 4
        Me.Button9.Text = "7"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button10.Location = New System.Drawing.Point(454, 225)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(57, 44)
        Me.Button10.TabIndex = 4
        Me.Button10.Text = "8"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button11.Location = New System.Drawing.Point(517, 225)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(57, 44)
        Me.Button11.TabIndex = 4
        Me.Button11.Text = "9"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button12.Location = New System.Drawing.Point(580, 225)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(57, 44)
        Me.Button12.TabIndex = 4
        Me.Button12.Text = "0"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button13.Location = New System.Drawing.Point(12, 275)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(57, 44)
        Me.Button13.TabIndex = 4
        Me.Button13.Text = "Q"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button14.Location = New System.Drawing.Point(75, 275)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(57, 44)
        Me.Button14.TabIndex = 4
        Me.Button14.Text = "W"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.Pink
        Me.Button15.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button15.Location = New System.Drawing.Point(580, 325)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(57, 44)
        Me.Button15.TabIndex = 4
        Me.Button15.Text = "BS"
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Button16
        '
        Me.Button16.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button16.Location = New System.Drawing.Point(138, 275)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(57, 44)
        Me.Button16.TabIndex = 4
        Me.Button16.Text = "E"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button17.Location = New System.Drawing.Point(202, 275)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(57, 44)
        Me.Button17.TabIndex = 4
        Me.Button17.Text = "R"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.Button18.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button18.Location = New System.Drawing.Point(265, 275)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(57, 44)
        Me.Button18.TabIndex = 4
        Me.Button18.Text = "T"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button19
        '
        Me.Button19.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button19.Location = New System.Drawing.Point(328, 275)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(57, 44)
        Me.Button19.TabIndex = 4
        Me.Button19.Text = "Y"
        Me.Button19.UseVisualStyleBackColor = True
        '
        'Button20
        '
        Me.Button20.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button20.Location = New System.Drawing.Point(391, 275)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(57, 44)
        Me.Button20.TabIndex = 4
        Me.Button20.Text = "U"
        Me.Button20.UseVisualStyleBackColor = True
        '
        'Button21
        '
        Me.Button21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button21.Location = New System.Drawing.Point(517, 275)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(57, 44)
        Me.Button21.TabIndex = 4
        Me.Button21.Text = "O"
        Me.Button21.UseVisualStyleBackColor = True
        '
        'Button22
        '
        Me.Button22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button22.Location = New System.Drawing.Point(580, 275)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(57, 44)
        Me.Button22.TabIndex = 4
        Me.Button22.Text = "P"
        Me.Button22.UseVisualStyleBackColor = True
        '
        'Button23
        '
        Me.Button23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button23.Location = New System.Drawing.Point(12, 325)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(57, 44)
        Me.Button23.TabIndex = 4
        Me.Button23.Text = "A"
        Me.Button23.UseVisualStyleBackColor = True
        '
        'Button24
        '
        Me.Button24.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button24.Location = New System.Drawing.Point(75, 325)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(57, 44)
        Me.Button24.TabIndex = 4
        Me.Button24.Text = "S"
        Me.Button24.UseVisualStyleBackColor = True
        '
        'Button26
        '
        Me.Button26.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button26.Location = New System.Drawing.Point(138, 325)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(57, 44)
        Me.Button26.TabIndex = 4
        Me.Button26.Text = "D"
        Me.Button26.UseVisualStyleBackColor = True
        '
        'Button27
        '
        Me.Button27.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button27.Location = New System.Drawing.Point(202, 325)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(57, 44)
        Me.Button27.TabIndex = 4
        Me.Button27.Text = "F"
        Me.Button27.UseVisualStyleBackColor = True
        '
        'Button28
        '
        Me.Button28.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button28.Location = New System.Drawing.Point(265, 325)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(57, 44)
        Me.Button28.TabIndex = 4
        Me.Button28.Text = "G"
        Me.Button28.UseVisualStyleBackColor = True
        '
        'Button29
        '
        Me.Button29.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button29.Location = New System.Drawing.Point(328, 325)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(57, 44)
        Me.Button29.TabIndex = 4
        Me.Button29.Text = "H"
        Me.Button29.UseVisualStyleBackColor = True
        '
        'Button30
        '
        Me.Button30.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button30.Location = New System.Drawing.Point(391, 325)
        Me.Button30.Name = "Button30"
        Me.Button30.Size = New System.Drawing.Size(57, 44)
        Me.Button30.TabIndex = 4
        Me.Button30.Text = "J"
        Me.Button30.UseVisualStyleBackColor = True
        '
        'Button31
        '
        Me.Button31.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button31.Location = New System.Drawing.Point(454, 325)
        Me.Button31.Name = "Button31"
        Me.Button31.Size = New System.Drawing.Size(57, 44)
        Me.Button31.TabIndex = 4
        Me.Button31.Text = "K"
        Me.Button31.UseVisualStyleBackColor = True
        '
        'Button32
        '
        Me.Button32.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button32.Location = New System.Drawing.Point(517, 325)
        Me.Button32.Name = "Button32"
        Me.Button32.Size = New System.Drawing.Size(57, 44)
        Me.Button32.TabIndex = 4
        Me.Button32.Text = "L"
        Me.Button32.UseVisualStyleBackColor = True
        '
        'Button33
        '
        Me.Button33.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button33.Location = New System.Drawing.Point(12, 375)
        Me.Button33.Name = "Button33"
        Me.Button33.Size = New System.Drawing.Size(57, 44)
        Me.Button33.TabIndex = 4
        Me.Button33.Text = "Z"
        Me.Button33.UseVisualStyleBackColor = True
        '
        'Button34
        '
        Me.Button34.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button34.Location = New System.Drawing.Point(75, 375)
        Me.Button34.Name = "Button34"
        Me.Button34.Size = New System.Drawing.Size(57, 44)
        Me.Button34.TabIndex = 4
        Me.Button34.Text = "X"
        Me.Button34.UseVisualStyleBackColor = True
        '
        'Button36
        '
        Me.Button36.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button36.Location = New System.Drawing.Point(138, 375)
        Me.Button36.Name = "Button36"
        Me.Button36.Size = New System.Drawing.Size(57, 44)
        Me.Button36.TabIndex = 4
        Me.Button36.Text = "C"
        Me.Button36.UseVisualStyleBackColor = True
        '
        'Button37
        '
        Me.Button37.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button37.Location = New System.Drawing.Point(202, 375)
        Me.Button37.Name = "Button37"
        Me.Button37.Size = New System.Drawing.Size(57, 44)
        Me.Button37.TabIndex = 4
        Me.Button37.Text = "V"
        Me.Button37.UseVisualStyleBackColor = True
        '
        'Button38
        '
        Me.Button38.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button38.Location = New System.Drawing.Point(265, 375)
        Me.Button38.Name = "Button38"
        Me.Button38.Size = New System.Drawing.Size(57, 44)
        Me.Button38.TabIndex = 4
        Me.Button38.Text = "B"
        Me.Button38.UseVisualStyleBackColor = True
        '
        'Button39
        '
        Me.Button39.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button39.Location = New System.Drawing.Point(328, 375)
        Me.Button39.Name = "Button39"
        Me.Button39.Size = New System.Drawing.Size(57, 44)
        Me.Button39.TabIndex = 4
        Me.Button39.Text = "N"
        Me.Button39.UseVisualStyleBackColor = True
        '
        'Button40
        '
        Me.Button40.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button40.Location = New System.Drawing.Point(391, 375)
        Me.Button40.Name = "Button40"
        Me.Button40.Size = New System.Drawing.Size(57, 44)
        Me.Button40.TabIndex = 4
        Me.Button40.Text = "M"
        Me.Button40.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(454, 275)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 44)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "I"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 466)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button32)
        Me.Controls.Add(Me.Button22)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button31)
        Me.Controls.Add(Me.Button40)
        Me.Controls.Add(Me.Button30)
        Me.Controls.Add(Me.Button21)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button20)
        Me.Controls.Add(Me.Button39)
        Me.Controls.Add(Me.Button29)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button19)
        Me.Controls.Add(Me.Button38)
        Me.Controls.Add(Me.Button28)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button18)
        Me.Controls.Add(Me.Button37)
        Me.Controls.Add(Me.Button27)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button17)
        Me.Controls.Add(Me.Button36)
        Me.Controls.Add(Me.Button26)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button16)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button34)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Button24)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button33)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button23)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbLot)
        Me.Controls.Add(Me.btclose)
        Me.Controls.Add(Me.btSearch)
        Me.Controls.Add(Me.TPINSDataDataGridView)
        Me.Name = "frmSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSearch"
        CType(Me.DBxDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TPINSDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TPINSDataDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DBxDataSet As SelfCon.DBxDataSet
    Friend WithEvents TPINSDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TPINSDataTableAdapter As SelfCon.DBxDataSetTableAdapters.TPINSDataTableAdapter
    Friend WithEvents TableAdapterManager As SelfCon.DBxDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TPINSDataDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btSearch As System.Windows.Forms.Button
    Friend WithEvents tbLot As System.Windows.Forms.TextBox
    Friend WithEvents btclose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents Button19 As System.Windows.Forms.Button
    Friend WithEvents Button20 As System.Windows.Forms.Button
    Friend WithEvents Button21 As System.Windows.Forms.Button
    Friend WithEvents Button22 As System.Windows.Forms.Button
    Friend WithEvents Button23 As System.Windows.Forms.Button
    Friend WithEvents Button24 As System.Windows.Forms.Button
    Friend WithEvents Button26 As System.Windows.Forms.Button
    Friend WithEvents Button27 As System.Windows.Forms.Button
    Friend WithEvents Button28 As System.Windows.Forms.Button
    Friend WithEvents Button29 As System.Windows.Forms.Button
    Friend WithEvents Button30 As System.Windows.Forms.Button
    Friend WithEvents Button31 As System.Windows.Forms.Button
    Friend WithEvents Button32 As System.Windows.Forms.Button
    Friend WithEvents Button33 As System.Windows.Forms.Button
    Friend WithEvents Button34 As System.Windows.Forms.Button
    Friend WithEvents Button36 As System.Windows.Forms.Button
    Friend WithEvents Button37 As System.Windows.Forms.Button
    Friend WithEvents Button38 As System.Windows.Forms.Button
    Friend WithEvents Button39 As System.Windows.Forms.Button
    Friend WithEvents Button40 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

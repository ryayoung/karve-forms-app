<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderSearch
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrderSearch))
        Me.RentalHistoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.OrderDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Customer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ski = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Width = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Length = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DaysKept = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Damage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TuneTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DaysLeftUntuned = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RentalHistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KarveDataSet = New PHASE_II.KarveDataSet()
        Me.tbMinLength = New System.Windows.Forms.TrackBar()
        Me.lblMinLength = New System.Windows.Forms.Label()
        Me.tbMaxLength = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblMinLengthValue = New System.Windows.Forms.Label()
        Me.lblMaxLengthValue = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblMaxWidthValue = New System.Windows.Forms.Label()
        Me.lblMinWidthValue = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tbMaxWidth = New System.Windows.Forms.TrackBar()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tbMinWidth = New System.Windows.Forms.TrackBar()
        Me.lblNoListingsFound = New System.Windows.Forms.Label()
        Me.grpOrderStatus = New System.Windows.Forms.GroupBox()
        Me.radOrderStatusActive = New System.Windows.Forms.RadioButton()
        Me.radOrderStatusComplete = New System.Windows.Forms.RadioButton()
        Me.radOrderStatusAny = New System.Windows.Forms.RadioButton()
        Me.grpDamage = New System.Windows.Forms.GroupBox()
        Me.radDamageYes = New System.Windows.Forms.RadioButton()
        Me.radDamageAny = New System.Windows.Forms.RadioButton()
        Me.dpMinDate = New System.Windows.Forms.DateTimePicker()
        Me.dpMaxDate = New System.Windows.Forms.DateTimePicker()
        Me.grpOrderDate = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.RentalHistoryTableAdapter = New PHASE_II.KarveDataSetTableAdapters.RentalHistoryTableAdapter()
        Me.TableAdapterManager = New PHASE_II.KarveDataSetTableAdapters.TableAdapterManager()
        Me.BindingModelTableAdapter1 = New PHASE_II.KarveDataSetTableAdapters.BindingModelTableAdapter()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblAvgWidthLabel = New System.Windows.Forms.Label()
        Me.lblAvgWidth = New System.Windows.Forms.Label()
        Me.lblAvgLengthLabel = New System.Windows.Forms.Label()
        Me.lblAvgLength = New System.Windows.Forms.Label()
        Me.lblNoticeNotTuned = New System.Windows.Forms.Label()
        Me.lblNoticeDamage = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        CType(Me.RentalHistoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RentalHistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KarveDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbMinLength, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbMaxLength, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbMaxWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbMinWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOrderStatus.SuspendLayout()
        Me.grpDamage.SuspendLayout()
        Me.grpOrderDate.SuspendLayout()
        Me.SuspendLayout()
        '
        'RentalHistoryDataGridView
        '
        Me.RentalHistoryDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RentalHistoryDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.RentalHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RentalHistoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderDate, Me.Customer, Me.Ski, Me.Width, Me.Length, Me.OrderStatus, Me.DaysKept, Me.Damage, Me.TuneTime, Me.DaysLeftUntuned})
        Me.RentalHistoryDataGridView.DataSource = Me.RentalHistoryBindingSource
        Me.RentalHistoryDataGridView.Location = New System.Drawing.Point(25, 449)
        Me.RentalHistoryDataGridView.Name = "RentalHistoryDataGridView"
        Me.RentalHistoryDataGridView.Size = New System.Drawing.Size(917, 65)
        Me.RentalHistoryDataGridView.TabIndex = 4
        '
        'OrderDate
        '
        Me.OrderDate.DataPropertyName = "Order Date"
        Me.OrderDate.HeaderText = "Order Date"
        Me.OrderDate.Name = "OrderDate"
        Me.OrderDate.Width = 75
        '
        'Customer
        '
        Me.Customer.DataPropertyName = "Customer"
        Me.Customer.HeaderText = "Customer"
        Me.Customer.Name = "Customer"
        Me.Customer.ReadOnly = True
        Me.Customer.Width = 115
        '
        'Ski
        '
        Me.Ski.DataPropertyName = "Ski"
        Me.Ski.HeaderText = "Ski"
        Me.Ski.Name = "Ski"
        Me.Ski.ReadOnly = True
        Me.Ski.Width = 150
        '
        'Width
        '
        Me.Width.DataPropertyName = "Width"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Width.DefaultCellStyle = DataGridViewCellStyle12
        Me.Width.HeaderText = "Width"
        Me.Width.Name = "Width"
        Me.Width.Width = 60
        '
        'Length
        '
        Me.Length.DataPropertyName = "Length"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Length.DefaultCellStyle = DataGridViewCellStyle13
        Me.Length.HeaderText = "Length"
        Me.Length.Name = "Length"
        Me.Length.Width = 60
        '
        'OrderStatus
        '
        Me.OrderStatus.DataPropertyName = "Order Status"
        Me.OrderStatus.HeaderText = "Order Status"
        Me.OrderStatus.Name = "OrderStatus"
        Me.OrderStatus.ReadOnly = True
        Me.OrderStatus.Width = 75
        '
        'DaysKept
        '
        Me.DaysKept.DataPropertyName = "Days Kept"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DaysKept.DefaultCellStyle = DataGridViewCellStyle14
        Me.DaysKept.HeaderText = "Days Kept"
        Me.DaysKept.Name = "DaysKept"
        Me.DaysKept.Width = 60
        '
        'Damage
        '
        Me.Damage.DataPropertyName = "Damage"
        Me.Damage.HeaderText = "Damage"
        Me.Damage.Name = "Damage"
        Me.Damage.ReadOnly = True
        Me.Damage.Width = 115
        '
        'TuneTime
        '
        Me.TuneTime.DataPropertyName = "Tune Time"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.TuneTime.DefaultCellStyle = DataGridViewCellStyle15
        Me.TuneTime.HeaderText = "Tune Time"
        Me.TuneTime.Name = "TuneTime"
        Me.TuneTime.ReadOnly = True
        Me.TuneTime.Width = 75
        '
        'DaysLeftUntuned
        '
        Me.DaysLeftUntuned.DataPropertyName = "Days Left Untuned"
        Me.DaysLeftUntuned.HeaderText = "Days Left Untuned"
        Me.DaysLeftUntuned.Name = "DaysLeftUntuned"
        Me.DaysLeftUntuned.ReadOnly = True
        Me.DaysLeftUntuned.Width = 70
        '
        'RentalHistoryBindingSource
        '
        Me.RentalHistoryBindingSource.DataMember = "RentalHistory"
        Me.RentalHistoryBindingSource.DataSource = Me.KarveDataSet
        '
        'KarveDataSet
        '
        Me.KarveDataSet.DataSetName = "KarveDataSet"
        Me.KarveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbMinLength
        '
        Me.tbMinLength.Location = New System.Drawing.Point(66, 194)
        Me.tbMinLength.Maximum = 200
        Me.tbMinLength.Minimum = 150
        Me.tbMinLength.Name = "tbMinLength"
        Me.tbMinLength.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbMinLength.Size = New System.Drawing.Size(45, 140)
        Me.tbMinLength.SmallChange = 5
        Me.tbMinLength.TabIndex = 7
        Me.tbMinLength.TickFrequency = 10
        Me.tbMinLength.Value = 152
        '
        'lblMinLength
        '
        Me.lblMinLength.AutoSize = True
        Me.lblMinLength.Location = New System.Drawing.Point(63, 178)
        Me.lblMinLength.Name = "lblMinLength"
        Me.lblMinLength.Size = New System.Drawing.Size(27, 13)
        Me.lblMinLength.TabIndex = 8
        Me.lblMinLength.Text = "MIN"
        '
        'tbMaxLength
        '
        Me.tbMaxLength.BackColor = System.Drawing.SystemColors.Window
        Me.tbMaxLength.Location = New System.Drawing.Point(129, 194)
        Me.tbMaxLength.Maximum = 200
        Me.tbMaxLength.Minimum = 150
        Me.tbMaxLength.Name = "tbMaxLength"
        Me.tbMaxLength.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbMaxLength.Size = New System.Drawing.Size(45, 140)
        Me.tbMaxLength.SmallChange = 5
        Me.tbMaxLength.TabIndex = 9
        Me.tbMaxLength.TickFrequency = 10
        Me.tbMaxLength.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.tbMaxLength.Value = 186
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(135, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "MAX"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(99, 312)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "150"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(99, 290)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "160"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(99, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "190"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(99, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "180"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(99, 268)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "170"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(99, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "200"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(73, 147)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 19)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Ski Length"
        '
        'lblMinLengthValue
        '
        Me.lblMinLengthValue.AutoSize = True
        Me.lblMinLengthValue.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinLengthValue.Location = New System.Drawing.Point(75, 337)
        Me.lblMinLengthValue.Name = "lblMinLengthValue"
        Me.lblMinLengthValue.Size = New System.Drawing.Size(29, 18)
        Me.lblMinLengthValue.TabIndex = 18
        Me.lblMinLengthValue.Text = "152"
        '
        'lblMaxLengthValue
        '
        Me.lblMaxLengthValue.AutoSize = True
        Me.lblMaxLengthValue.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxLengthValue.Location = New System.Drawing.Point(113, 337)
        Me.lblMaxLengthValue.Name = "lblMaxLengthValue"
        Me.lblMaxLengthValue.Size = New System.Drawing.Size(50, 18)
        Me.lblMaxLengthValue.TabIndex = 19
        Me.lblMaxLengthValue.Text = "186 cm"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(103, 337)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 18)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(277, 337)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 18)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "-"
        '
        'lblMaxWidthValue
        '
        Me.lblMaxWidthValue.AutoSize = True
        Me.lblMaxWidthValue.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxWidthValue.Location = New System.Drawing.Point(287, 337)
        Me.lblMaxWidthValue.Name = "lblMaxWidthValue"
        Me.lblMaxWidthValue.Size = New System.Drawing.Size(56, 18)
        Me.lblMaxWidthValue.TabIndex = 33
        Me.lblMaxWidthValue.Text = "118 mm"
        '
        'lblMinWidthValue
        '
        Me.lblMinWidthValue.AutoSize = True
        Me.lblMinWidthValue.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinWidthValue.Location = New System.Drawing.Point(249, 337)
        Me.lblMinWidthValue.Name = "lblMinWidthValue"
        Me.lblMinWidthValue.Size = New System.Drawing.Size(22, 18)
        Me.lblMinWidthValue.TabIndex = 32
        Me.lblMinWidthValue.Text = "95"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(247, 147)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 19)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Ski Width"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(273, 202)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(25, 13)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "120"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(273, 268)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(25, 13)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "105"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(273, 246)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(25, 13)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "110"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(273, 224)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(25, 13)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = "115"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(273, 290)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(25, 13)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "100"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(276, 312)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(19, 13)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "95"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(309, 178)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(30, 13)
        Me.Label20.TabIndex = 24
        Me.Label20.Text = "MAX"
        '
        'tbMaxWidth
        '
        Me.tbMaxWidth.BackColor = System.Drawing.SystemColors.Window
        Me.tbMaxWidth.LargeChange = 2
        Me.tbMaxWidth.Location = New System.Drawing.Point(303, 194)
        Me.tbMaxWidth.Maximum = 120
        Me.tbMaxWidth.Minimum = 95
        Me.tbMaxWidth.Name = "tbMaxWidth"
        Me.tbMaxWidth.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbMaxWidth.Size = New System.Drawing.Size(45, 140)
        Me.tbMaxWidth.SmallChange = 2
        Me.tbMaxWidth.TabIndex = 23
        Me.tbMaxWidth.TickFrequency = 5
        Me.tbMaxWidth.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.tbMaxWidth.Value = 118
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(237, 178)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(27, 13)
        Me.Label21.TabIndex = 22
        Me.Label21.Text = "MIN"
        '
        'tbMinWidth
        '
        Me.tbMinWidth.LargeChange = 2
        Me.tbMinWidth.Location = New System.Drawing.Point(240, 194)
        Me.tbMinWidth.Maximum = 120
        Me.tbMinWidth.Minimum = 95
        Me.tbMinWidth.Name = "tbMinWidth"
        Me.tbMinWidth.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbMinWidth.Size = New System.Drawing.Size(45, 140)
        Me.tbMinWidth.SmallChange = 2
        Me.tbMinWidth.TabIndex = 21
        Me.tbMinWidth.TickFrequency = 5
        Me.tbMinWidth.Value = 95
        '
        'lblNoListingsFound
        '
        Me.lblNoListingsFound.AutoSize = True
        Me.lblNoListingsFound.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoListingsFound.ForeColor = System.Drawing.Color.Red
        Me.lblNoListingsFound.Location = New System.Drawing.Point(447, 573)
        Me.lblNoListingsFound.Name = "lblNoListingsFound"
        Me.lblNoListingsFound.Size = New System.Drawing.Size(185, 29)
        Me.lblNoListingsFound.TabIndex = 35
        Me.lblNoListingsFound.Text = "No listings found!"
        Me.lblNoListingsFound.Visible = False
        '
        'grpOrderStatus
        '
        Me.grpOrderStatus.Controls.Add(Me.radOrderStatusActive)
        Me.grpOrderStatus.Controls.Add(Me.radOrderStatusComplete)
        Me.grpOrderStatus.Controls.Add(Me.radOrderStatusAny)
        Me.grpOrderStatus.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOrderStatus.Location = New System.Drawing.Point(464, 147)
        Me.grpOrderStatus.Name = "grpOrderStatus"
        Me.grpOrderStatus.Size = New System.Drawing.Size(180, 77)
        Me.grpOrderStatus.TabIndex = 37
        Me.grpOrderStatus.TabStop = False
        Me.grpOrderStatus.Text = "Order Status"
        '
        'radOrderStatusActive
        '
        Me.radOrderStatusActive.AutoSize = True
        Me.radOrderStatusActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radOrderStatusActive.Location = New System.Drawing.Point(74, 23)
        Me.radOrderStatusActive.Name = "radOrderStatusActive"
        Me.radOrderStatusActive.Size = New System.Drawing.Size(56, 19)
        Me.radOrderStatusActive.TabIndex = 2
        Me.radOrderStatusActive.Tag = "ACTIVE"
        Me.radOrderStatusActive.Text = "Active"
        Me.radOrderStatusActive.UseVisualStyleBackColor = True
        '
        'radOrderStatusComplete
        '
        Me.radOrderStatusComplete.AutoSize = True
        Me.radOrderStatusComplete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radOrderStatusComplete.Location = New System.Drawing.Point(74, 44)
        Me.radOrderStatusComplete.Name = "radOrderStatusComplete"
        Me.radOrderStatusComplete.Size = New System.Drawing.Size(78, 19)
        Me.radOrderStatusComplete.TabIndex = 1
        Me.radOrderStatusComplete.Tag = "COMPLETE"
        Me.radOrderStatusComplete.Text = "Complete"
        Me.radOrderStatusComplete.UseVisualStyleBackColor = True
        '
        'radOrderStatusAny
        '
        Me.radOrderStatusAny.AutoSize = True
        Me.radOrderStatusAny.Checked = True
        Me.radOrderStatusAny.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radOrderStatusAny.Location = New System.Drawing.Point(17, 32)
        Me.radOrderStatusAny.Name = "radOrderStatusAny"
        Me.radOrderStatusAny.Size = New System.Drawing.Size(36, 17)
        Me.radOrderStatusAny.TabIndex = 0
        Me.radOrderStatusAny.TabStop = True
        Me.radOrderStatusAny.Tag = "%"
        Me.radOrderStatusAny.Text = "All"
        Me.radOrderStatusAny.UseVisualStyleBackColor = True
        '
        'grpDamage
        '
        Me.grpDamage.Controls.Add(Me.radDamageYes)
        Me.grpDamage.Controls.Add(Me.radDamageAny)
        Me.grpDamage.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDamage.Location = New System.Drawing.Point(464, 240)
        Me.grpDamage.Name = "grpDamage"
        Me.grpDamage.Size = New System.Drawing.Size(180, 77)
        Me.grpDamage.TabIndex = 38
        Me.grpDamage.TabStop = False
        Me.grpDamage.Text = "Damage"
        '
        'radDamageYes
        '
        Me.radDamageYes.AutoSize = True
        Me.radDamageYes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDamageYes.Location = New System.Drawing.Point(74, 32)
        Me.radDamageYes.Name = "radDamageYes"
        Me.radDamageYes.Size = New System.Drawing.Size(80, 19)
        Me.radDamageYes.TabIndex = 2
        Me.radDamageYes.Tag = "-"
        Me.radDamageYes.Text = "Damaged"
        Me.radDamageYes.UseVisualStyleBackColor = True
        '
        'radDamageAny
        '
        Me.radDamageAny.AutoSize = True
        Me.radDamageAny.Checked = True
        Me.radDamageAny.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDamageAny.Location = New System.Drawing.Point(17, 32)
        Me.radDamageAny.Name = "radDamageAny"
        Me.radDamageAny.Size = New System.Drawing.Size(38, 19)
        Me.radDamageAny.TabIndex = 0
        Me.radDamageAny.TabStop = True
        Me.radDamageAny.Tag = "xxxxxxxxx"
        Me.radDamageAny.Text = "All"
        Me.radDamageAny.UseVisualStyleBackColor = True
        '
        'dpMinDate
        '
        Me.dpMinDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpMinDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpMinDate.Location = New System.Drawing.Point(71, 29)
        Me.dpMinDate.Name = "dpMinDate"
        Me.dpMinDate.Size = New System.Drawing.Size(90, 20)
        Me.dpMinDate.TabIndex = 39
        Me.dpMinDate.Value = New Date(2020, 9, 1, 0, 0, 0, 0)
        '
        'dpMaxDate
        '
        Me.dpMaxDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpMaxDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpMaxDate.Location = New System.Drawing.Point(71, 60)
        Me.dpMaxDate.Name = "dpMaxDate"
        Me.dpMaxDate.Size = New System.Drawing.Size(90, 20)
        Me.dpMaxDate.TabIndex = 40
        Me.dpMaxDate.Value = New Date(2021, 5, 17, 0, 0, 0, 0)
        '
        'grpOrderDate
        '
        Me.grpOrderDate.Controls.Add(Me.Label12)
        Me.grpOrderDate.Controls.Add(Me.Label11)
        Me.grpOrderDate.Controls.Add(Me.dpMinDate)
        Me.grpOrderDate.Controls.Add(Me.dpMaxDate)
        Me.grpOrderDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOrderDate.Location = New System.Drawing.Point(687, 147)
        Me.grpOrderDate.Name = "grpOrderDate"
        Me.grpOrderDate.Size = New System.Drawing.Size(176, 98)
        Me.grpOrderDate.TabIndex = 41
        Me.grpOrderDate.TabStop = False
        Me.grpOrderDate.Text = "Order Date"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(20, 62)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 15)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "MAX"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(21, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 15)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "MIN"
        '
        'RentalHistoryTableAdapter
        '
        Me.RentalHistoryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BindingModelTableAdapter = Nothing
        Me.TableAdapterManager.BindingTableAdapter = Nothing
        Me.TableAdapterManager.BrandTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.CustomerTableAdapter = Nothing
        Me.TableAdapterManager.RentalTableAdapter = Nothing
        Me.TableAdapterManager.SkiBindingTableAdapter = Nothing
        Me.TableAdapterManager.SkiModelTableAdapter = Nothing
        Me.TableAdapterManager.SkiTableAdapter = Nothing
        Me.TableAdapterManager.StateTableAdapter = Nothing
        Me.TableAdapterManager.TuneLineTableAdapter = Nothing
        Me.TableAdapterManager.TuneTableAdapter = Nothing
        Me.TableAdapterManager.TuneTypeTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PHASE_II.KarveDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BindingModelTableAdapter1
        '
        Me.BindingModelTableAdapter1.ClearBeforeFill = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(61, 65)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(200, 39)
        Me.Label22.TabIndex = 42
        Me.Label22.Text = "Search Orders"
        '
        'lblAvgWidthLabel
        '
        Me.lblAvgWidthLabel.AutoSize = True
        Me.lblAvgWidthLabel.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblAvgWidthLabel.Location = New System.Drawing.Point(461, 392)
        Me.lblAvgWidthLabel.Name = "lblAvgWidthLabel"
        Me.lblAvgWidthLabel.Size = New System.Drawing.Size(60, 13)
        Me.lblAvgWidthLabel.TabIndex = 43
        Me.lblAvgWidthLabel.Text = "Avg. Width"
        '
        'lblAvgWidth
        '
        Me.lblAvgWidth.AutoSize = True
        Me.lblAvgWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgWidth.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblAvgWidth.Location = New System.Drawing.Point(538, 392)
        Me.lblAvgWidth.Name = "lblAvgWidth"
        Me.lblAvgWidth.Size = New System.Drawing.Size(88, 13)
        Me.lblAvgWidth.TabIndex = 44
        Me.lblAvgWidth.Text = "avg goes here"
        '
        'lblAvgLengthLabel
        '
        Me.lblAvgLengthLabel.AutoSize = True
        Me.lblAvgLengthLabel.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblAvgLengthLabel.Location = New System.Drawing.Point(461, 366)
        Me.lblAvgLengthLabel.Name = "lblAvgLengthLabel"
        Me.lblAvgLengthLabel.Size = New System.Drawing.Size(65, 13)
        Me.lblAvgLengthLabel.TabIndex = 45
        Me.lblAvgLengthLabel.Text = "Avg. Length"
        '
        'lblAvgLength
        '
        Me.lblAvgLength.AutoSize = True
        Me.lblAvgLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgLength.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblAvgLength.Location = New System.Drawing.Point(538, 366)
        Me.lblAvgLength.Name = "lblAvgLength"
        Me.lblAvgLength.Size = New System.Drawing.Size(88, 13)
        Me.lblAvgLength.TabIndex = 46
        Me.lblAvgLength.Text = "avg goes here"
        '
        'lblNoticeNotTuned
        '
        Me.lblNoticeNotTuned.AutoSize = True
        Me.lblNoticeNotTuned.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoticeNotTuned.ForeColor = System.Drawing.Color.Red
        Me.lblNoticeNotTuned.Location = New System.Drawing.Point(672, 392)
        Me.lblNoticeNotTuned.Name = "lblNoticeNotTuned"
        Me.lblNoticeNotTuned.Size = New System.Drawing.Size(48, 13)
        Me.lblNoticeNotTuned.TabIndex = 36
        Me.lblNoticeNotTuned.Text = "Notice:"
        '
        'lblNoticeDamage
        '
        Me.lblNoticeDamage.AutoSize = True
        Me.lblNoticeDamage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoticeDamage.ForeColor = System.Drawing.Color.Red
        Me.lblNoticeDamage.Location = New System.Drawing.Point(672, 366)
        Me.lblNoticeDamage.Name = "lblNoticeDamage"
        Me.lblNoticeDamage.Size = New System.Drawing.Size(48, 13)
        Me.lblNoticeDamage.TabIndex = 47
        Me.lblNoticeDamage.Text = "Notice:"
        '
        'btnBack
        '
        Me.btnBack.BackgroundImage = CType(resources.GetObject("btnBack.BackgroundImage"), System.Drawing.Image)
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Location = New System.Drawing.Point(25, 25)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(28, 28)
        Me.btnBack.TabIndex = 52
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.BackgroundImage = Global.PHASE_II.My.Resources.Resources.imgGoNormal
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Location = New System.Drawing.Point(745, 257)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(60, 60)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'OrderSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(988, 811)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblNoticeDamage)
        Me.Controls.Add(Me.lblAvgLength)
        Me.Controls.Add(Me.lblAvgLengthLabel)
        Me.Controls.Add(Me.lblAvgWidth)
        Me.Controls.Add(Me.lblAvgWidthLabel)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.grpOrderDate)
        Me.Controls.Add(Me.grpDamage)
        Me.Controls.Add(Me.grpOrderStatus)
        Me.Controls.Add(Me.lblNoticeNotTuned)
        Me.Controls.Add(Me.lblNoListingsFound)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblMaxWidthValue)
        Me.Controls.Add(Me.lblMinWidthValue)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.tbMaxWidth)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.tbMinWidth)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblMaxLengthValue)
        Me.Controls.Add(Me.lblMinLengthValue)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbMaxLength)
        Me.Controls.Add(Me.lblMinLength)
        Me.Controls.Add(Me.tbMinLength)
        Me.Controls.Add(Me.RentalHistoryDataGridView)
        Me.Controls.Add(Me.btnSearch)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "OrderSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.RentalHistoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RentalHistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KarveDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbMinLength, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbMaxLength, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbMaxWidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbMinWidth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOrderStatus.ResumeLayout(False)
        Me.grpOrderStatus.PerformLayout()
        Me.grpDamage.ResumeLayout(False)
        Me.grpDamage.PerformLayout()
        Me.grpOrderDate.ResumeLayout(False)
        Me.grpOrderDate.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSearch As Button
    Friend WithEvents KarveDataSet As KarveDataSet
    Friend WithEvents RentalHistoryBindingSource As BindingSource
    Friend WithEvents RentalHistoryTableAdapter As KarveDataSetTableAdapters.RentalHistoryTableAdapter
    Friend WithEvents TableAdapterManager As KarveDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RentalHistoryDataGridView As DataGridView
    Friend WithEvents tbMinLength As TrackBar
    Friend WithEvents lblMinLength As Label
    Friend WithEvents tbMaxLength As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblMinLengthValue As Label
    Friend WithEvents lblMaxLengthValue As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BindingModelTableAdapter1 As KarveDataSetTableAdapters.BindingModelTableAdapter
    Friend WithEvents Label10 As Label
    Friend WithEvents lblMaxWidthValue As Label
    Friend WithEvents lblMinWidthValue As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents tbMaxWidth As TrackBar
    Friend WithEvents Label21 As Label
    Friend WithEvents tbMinWidth As TrackBar
    Friend WithEvents lblNoListingsFound As Label
    Friend WithEvents grpOrderStatus As GroupBox
    Friend WithEvents radOrderStatusActive As RadioButton
    Friend WithEvents radOrderStatusComplete As RadioButton
    Friend WithEvents radOrderStatusAny As RadioButton
    Friend WithEvents grpDamage As GroupBox
    Friend WithEvents radDamageYes As RadioButton
    Friend WithEvents radDamageAny As RadioButton
    Friend WithEvents dpMinDate As DateTimePicker
    Friend WithEvents dpMaxDate As DateTimePicker
    Friend WithEvents grpOrderDate As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents OrderDate As DataGridViewTextBoxColumn
    Friend WithEvents Customer As DataGridViewTextBoxColumn
    Friend WithEvents Ski As DataGridViewTextBoxColumn
    Friend WithEvents Width As DataGridViewTextBoxColumn
    Friend WithEvents Length As DataGridViewTextBoxColumn
    Friend WithEvents OrderStatus As DataGridViewTextBoxColumn
    Friend WithEvents DaysKept As DataGridViewTextBoxColumn
    Friend WithEvents Damage As DataGridViewTextBoxColumn
    Friend WithEvents TuneTime As DataGridViewTextBoxColumn
    Friend WithEvents DaysLeftUntuned As DataGridViewTextBoxColumn
    Friend WithEvents lblAvgWidthLabel As Label
    Friend WithEvents lblAvgWidth As Label
    Friend WithEvents lblAvgLengthLabel As Label
    Friend WithEvents lblAvgLength As Label
    Friend WithEvents lblNoticeNotTuned As Label
    Friend WithEvents lblNoticeDamage As Label
    Friend WithEvents btnBack As Button
End Class

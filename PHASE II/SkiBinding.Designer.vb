<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SkiBinding
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
        Dim SkiBindingIDLabel As System.Windows.Forms.Label
        Dim BindingIDLabel As System.Windows.Forms.Label
        Dim SkiIDLabel As System.Windows.Forms.Label
        Dim MountDateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SkiBinding))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.KarveDataSet = New PHASE_II.KarveDataSet()
        Me.SkiBindingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SkiBindingTableAdapter = New PHASE_II.KarveDataSetTableAdapters.SkiBindingTableAdapter()
        Me.TableAdapterManager = New PHASE_II.KarveDataSetTableAdapters.TableAdapterManager()
        Me.RentalTableAdapter = New PHASE_II.KarveDataSetTableAdapters.RentalTableAdapter()
        Me.SkiModelTableAdapter = New PHASE_II.KarveDataSetTableAdapters.SkiModelTableAdapter()
        Me.SkiBindingBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SkiBindingBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SkiBindingIDTextBox = New System.Windows.Forms.TextBox()
        Me.BindingIDTextBox = New System.Windows.Forms.TextBox()
        Me.SkiIDTextBox = New System.Windows.Forms.TextBox()
        Me.dtpMountDate = New System.Windows.Forms.DateTimePicker()
        Me.RentalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RentalDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DaysUsed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SkiModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblDaysUsed = New System.Windows.Forms.Label()
        SkiBindingIDLabel = New System.Windows.Forms.Label()
        BindingIDLabel = New System.Windows.Forms.Label()
        SkiIDLabel = New System.Windows.Forms.Label()
        MountDateLabel = New System.Windows.Forms.Label()
        CType(Me.KarveDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SkiBindingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SkiBindingBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SkiBindingBindingNavigator.SuspendLayout()
        CType(Me.RentalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RentalDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SkiModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SkiBindingIDLabel
        '
        SkiBindingIDLabel.AutoSize = True
        SkiBindingIDLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SkiBindingIDLabel.Location = New System.Drawing.Point(39, 122)
        SkiBindingIDLabel.Name = "SkiBindingIDLabel"
        SkiBindingIDLabel.Size = New System.Drawing.Size(96, 18)
        SkiBindingIDLabel.TabIndex = 1
        SkiBindingIDLabel.Text = "Ski Binding ID:"
        '
        'BindingIDLabel
        '
        BindingIDLabel.AutoSize = True
        BindingIDLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BindingIDLabel.Location = New System.Drawing.Point(39, 152)
        BindingIDLabel.Name = "BindingIDLabel"
        BindingIDLabel.Size = New System.Drawing.Size(75, 18)
        BindingIDLabel.TabIndex = 3
        BindingIDLabel.Text = "Binding ID:"
        '
        'SkiIDLabel
        '
        SkiIDLabel.AutoSize = True
        SkiIDLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SkiIDLabel.Location = New System.Drawing.Point(39, 182)
        SkiIDLabel.Name = "SkiIDLabel"
        SkiIDLabel.Size = New System.Drawing.Size(46, 18)
        SkiIDLabel.TabIndex = 5
        SkiIDLabel.Text = "Ski ID:"
        '
        'MountDateLabel
        '
        MountDateLabel.AutoSize = True
        MountDateLabel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MountDateLabel.Location = New System.Drawing.Point(39, 212)
        MountDateLabel.Name = "MountDateLabel"
        MountDateLabel.Size = New System.Drawing.Size(86, 18)
        MountDateLabel.TabIndex = 7
        MountDateLabel.Text = "Mount Date:"
        '
        'KarveDataSet
        '
        Me.KarveDataSet.DataSetName = "KarveDataSet"
        Me.KarveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SkiBindingBindingSource
        '
        Me.SkiBindingBindingSource.DataMember = "SkiBinding"
        Me.SkiBindingBindingSource.DataSource = Me.KarveDataSet
        '
        'SkiBindingTableAdapter
        '
        Me.SkiBindingTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BindingModelTableAdapter = Nothing
        Me.TableAdapterManager.BindingTableAdapter = Nothing
        Me.TableAdapterManager.BrandTableAdapter = Nothing
        Me.TableAdapterManager.CustomerTableAdapter = Nothing
        Me.TableAdapterManager.RentalTableAdapter = Me.RentalTableAdapter
        Me.TableAdapterManager.SkiBindingTableAdapter = Me.SkiBindingTableAdapter
        Me.TableAdapterManager.SkiModelTableAdapter = Me.SkiModelTableAdapter
        Me.TableAdapterManager.SkiTableAdapter = Nothing
        Me.TableAdapterManager.StateTableAdapter = Nothing
        Me.TableAdapterManager.TuneLineTableAdapter = Nothing
        Me.TableAdapterManager.TuneTableAdapter = Nothing
        Me.TableAdapterManager.TuneTypeTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PHASE_II.KarveDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RentalTableAdapter
        '
        Me.RentalTableAdapter.ClearBeforeFill = True
        '
        'SkiModelTableAdapter
        '
        Me.SkiModelTableAdapter.ClearBeforeFill = True
        '
        'SkiBindingBindingNavigator
        '
        Me.SkiBindingBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SkiBindingBindingNavigator.BindingSource = Me.SkiBindingBindingSource
        Me.SkiBindingBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SkiBindingBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SkiBindingBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.SkiBindingBindingNavigatorSaveItem, Me.BindingNavigatorDeleteItem, Me.BindingNavigatorAddNewItem})
        Me.SkiBindingBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SkiBindingBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SkiBindingBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SkiBindingBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SkiBindingBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SkiBindingBindingNavigator.Name = "SkiBindingBindingNavigator"
        Me.SkiBindingBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SkiBindingBindingNavigator.Size = New System.Drawing.Size(790, 25)
        Me.SkiBindingBindingNavigator.TabIndex = 0
        Me.SkiBindingBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None
        Me.BindingNavigatorAddNewItem.Enabled = False
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None
        Me.BindingNavigatorDeleteItem.Enabled = False
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'SkiBindingBindingNavigatorSaveItem
        '
        Me.SkiBindingBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SkiBindingBindingNavigatorSaveItem.Image = CType(resources.GetObject("SkiBindingBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SkiBindingBindingNavigatorSaveItem.Name = "SkiBindingBindingNavigatorSaveItem"
        Me.SkiBindingBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SkiBindingBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SkiBindingIDTextBox
        '
        Me.SkiBindingIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SkiBindingBindingSource, "SkiBindingID", True))
        Me.SkiBindingIDTextBox.Location = New System.Drawing.Point(141, 122)
        Me.SkiBindingIDTextBox.Name = "SkiBindingIDTextBox"
        Me.SkiBindingIDTextBox.Size = New System.Drawing.Size(51, 20)
        Me.SkiBindingIDTextBox.TabIndex = 2
        '
        'BindingIDTextBox
        '
        Me.BindingIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SkiBindingBindingSource, "BindingID", True))
        Me.BindingIDTextBox.Location = New System.Drawing.Point(141, 152)
        Me.BindingIDTextBox.Name = "BindingIDTextBox"
        Me.BindingIDTextBox.Size = New System.Drawing.Size(51, 20)
        Me.BindingIDTextBox.TabIndex = 4
        '
        'SkiIDTextBox
        '
        Me.SkiIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SkiBindingBindingSource, "SkiID", True))
        Me.SkiIDTextBox.Location = New System.Drawing.Point(141, 182)
        Me.SkiIDTextBox.Name = "SkiIDTextBox"
        Me.SkiIDTextBox.Size = New System.Drawing.Size(51, 20)
        Me.SkiIDTextBox.TabIndex = 6
        '
        'dtpMountDate
        '
        Me.dtpMountDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SkiBindingBindingSource, "MountDate", True))
        Me.dtpMountDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpMountDate.Location = New System.Drawing.Point(141, 212)
        Me.dtpMountDate.Name = "dtpMountDate"
        Me.dtpMountDate.Size = New System.Drawing.Size(84, 20)
        Me.dtpMountDate.TabIndex = 8
        '
        'RentalBindingSource
        '
        Me.RentalBindingSource.DataMember = "fk_rental_ski_binding"
        Me.RentalBindingSource.DataSource = Me.SkiBindingBindingSource
        '
        'RentalDataGridView
        '
        Me.RentalDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RentalDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.RentalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RentalDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DaysUsed, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn7})
        Me.RentalDataGridView.DataSource = Me.RentalBindingSource
        Me.RentalDataGridView.Location = New System.Drawing.Point(42, 268)
        Me.RentalDataGridView.Name = "RentalDataGridView"
        Me.RentalDataGridView.Size = New System.Drawing.Size(663, 800)
        Me.RentalDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "RentalID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Rental ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CustomerID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Customer ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 70
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "OrderDate"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Order Date"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 75
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ReturnDate"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Return Date"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 75
        '
        'DaysUsed
        '
        Me.DaysUsed.DataPropertyName = "DaysUsed"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DaysUsed.DefaultCellStyle = DataGridViewCellStyle2
        Me.DaysUsed.HeaderText = "Days Used"
        Me.DaysUsed.Name = "DaysUsed"
        Me.DaysUsed.Width = 75
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Damage"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Damage"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "DamageDescription"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Damage Description"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 200
        '
        'SkiModelBindingSource
        '
        Me.SkiModelBindingSource.DataMember = "SkiModel"
        Me.SkiModelBindingSource.DataSource = Me.KarveDataSet
        '
        'btnBack
        '
        Me.btnBack.BackgroundImage = CType(resources.GetObject("btnBack.BackgroundImage"), System.Drawing.Image)
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Location = New System.Drawing.Point(23, 51)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(28, 28)
        Me.btnBack.TabIndex = 50
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(92, 51)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(196, 39)
        Me.Label22.TabIndex = 52
        Me.Label22.Text = "Skis Mounted"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label4.Location = New System.Drawing.Point(273, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 21)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Days Used:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblDaysUsed)
        Me.GroupBox1.Location = New System.Drawing.Point(368, 157)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(61, 57)
        Me.GroupBox1.TabIndex = 58
        Me.GroupBox1.TabStop = False
        '
        'lblDaysUsed
        '
        Me.lblDaysUsed.AutoSize = True
        Me.lblDaysUsed.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDaysUsed.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblDaysUsed.Location = New System.Drawing.Point(6, 16)
        Me.lblDaysUsed.Name = "lblDaysUsed"
        Me.lblDaysUsed.Size = New System.Drawing.Size(66, 26)
        Me.lblDaysUsed.TabIndex = 0
        Me.lblDaysUsed.Text = "# days"
        '
        'SkiBinding
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(790, 590)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.RentalDataGridView)
        Me.Controls.Add(SkiBindingIDLabel)
        Me.Controls.Add(Me.SkiBindingIDTextBox)
        Me.Controls.Add(BindingIDLabel)
        Me.Controls.Add(Me.BindingIDTextBox)
        Me.Controls.Add(SkiIDLabel)
        Me.Controls.Add(Me.SkiIDTextBox)
        Me.Controls.Add(MountDateLabel)
        Me.Controls.Add(Me.dtpMountDate)
        Me.Controls.Add(Me.SkiBindingBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(300, 0)
        Me.Name = "SkiBinding"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        CType(Me.KarveDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SkiBindingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SkiBindingBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SkiBindingBindingNavigator.ResumeLayout(False)
        Me.SkiBindingBindingNavigator.PerformLayout()
        CType(Me.RentalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RentalDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SkiModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents KarveDataSet As KarveDataSet
    Friend WithEvents SkiBindingBindingSource As BindingSource
    Friend WithEvents SkiBindingTableAdapter As KarveDataSetTableAdapters.SkiBindingTableAdapter
    Friend WithEvents TableAdapterManager As KarveDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SkiBindingBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents SkiBindingBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents SkiBindingIDTextBox As TextBox
    Friend WithEvents BindingIDTextBox As TextBox
    Friend WithEvents SkiIDTextBox As TextBox
    Friend WithEvents dtpMountDate As DateTimePicker
    Friend WithEvents RentalTableAdapter As KarveDataSetTableAdapters.RentalTableAdapter
    Friend WithEvents RentalBindingSource As BindingSource
    Friend WithEvents RentalDataGridView As DataGridView
    Friend WithEvents SkiModelTableAdapter As KarveDataSetTableAdapters.SkiModelTableAdapter
    Friend WithEvents SkiModelBindingSource As BindingSource
    Friend WithEvents btnBack As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblDaysUsed As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DaysUsed As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
End Class

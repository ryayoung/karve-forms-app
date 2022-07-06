<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Customers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim lblCustomerID As System.Windows.Forms.Label
        Dim lblFirstName As System.Windows.Forms.Label
        Dim lblLastName As System.Windows.Forms.Label
        Dim lblEmail As System.Windows.Forms.Label
        Dim lblStreet As System.Windows.Forms.Label
        Dim lblCity As System.Windows.Forms.Label
        Dim lblState As System.Windows.Forms.Label
        Dim lblZipcode As System.Windows.Forms.Label
        Dim lblSignupDate As System.Windows.Forms.Label
        Dim lblDateOfBirth As System.Windows.Forms.Label
        Dim lblNumRentalsPaid As System.Windows.Forms.Label
        Dim lblHeight As System.Windows.Forms.Label
        Dim lblWeight As System.Windows.Forms.Label
        Dim lblAbilityLevel As System.Windows.Forms.Label
        Dim lblBootSize As System.Windows.Forms.Label
        Dim lblBootSoleLength As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customers))
        Me.CustomerBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KarveDataSet = New PHASE_II.KarveDataSet()
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
        Me.CustomerBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.dpSignupDate = New System.Windows.Forms.DateTimePicker()
        Me.dpDateOfBirth = New System.Windows.Forms.DateTimePicker()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.txtBootSoleLength = New System.Windows.Forms.TextBox()
        Me.CustomerTableAdapter = New PHASE_II.KarveDataSetTableAdapters.CustomerTableAdapter()
        Me.TableAdapterManager = New PHASE_II.KarveDataSetTableAdapters.TableAdapterManager()
        Me.txtZipcode = New System.Windows.Forms.MaskedTextBox()
        Me.cboState = New System.Windows.Forms.ComboBox()
        Me.StateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StateTableAdapter = New PHASE_II.KarveDataSetTableAdapters.StateTableAdapter()
        Me.cboAbilityLevel = New System.Windows.Forms.ComboBox()
        Me.cboBootSize = New System.Windows.Forms.ComboBox()
        Me.cboNumRentalsPaid = New System.Windows.Forms.ComboBox()
        Me.lblNoticeReadOnly = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FillByLastNameToolStrip = New System.Windows.Forms.ToolStrip()
        Me.LastNameToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.txtLastNameToolStrip = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbtnSearch = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnClear = New System.Windows.Forms.ToolStripButton()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblDinRec = New System.Windows.Forms.Label()
        Me.grpDIN = New System.Windows.Forms.GroupBox()
        Me.lblDinValue = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCustomerTitle = New System.Windows.Forms.Label()
        lblCustomerID = New System.Windows.Forms.Label()
        lblFirstName = New System.Windows.Forms.Label()
        lblLastName = New System.Windows.Forms.Label()
        lblEmail = New System.Windows.Forms.Label()
        lblStreet = New System.Windows.Forms.Label()
        lblCity = New System.Windows.Forms.Label()
        lblState = New System.Windows.Forms.Label()
        lblZipcode = New System.Windows.Forms.Label()
        lblSignupDate = New System.Windows.Forms.Label()
        lblDateOfBirth = New System.Windows.Forms.Label()
        lblNumRentalsPaid = New System.Windows.Forms.Label()
        lblHeight = New System.Windows.Forms.Label()
        lblWeight = New System.Windows.Forms.Label()
        lblAbilityLevel = New System.Windows.Forms.Label()
        lblBootSize = New System.Windows.Forms.Label()
        lblBootSoleLength = New System.Windows.Forms.Label()
        CType(Me.CustomerBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomerBindingNavigator.SuspendLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KarveDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByLastNameToolStrip.SuspendLayout()
        Me.grpDIN.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCustomerID
        '
        lblCustomerID.AutoSize = True
        lblCustomerID.Location = New System.Drawing.Point(52, 181)
        lblCustomerID.Name = "lblCustomerID"
        lblCustomerID.Size = New System.Drawing.Size(68, 13)
        lblCustomerID.TabIndex = 1
        lblCustomerID.Text = "Customer ID:"
        '
        'lblFirstName
        '
        lblFirstName.AutoSize = True
        lblFirstName.Location = New System.Drawing.Point(52, 207)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New System.Drawing.Size(60, 13)
        lblFirstName.TabIndex = 3
        lblFirstName.Text = "First Name:"
        '
        'lblLastName
        '
        lblLastName.AutoSize = True
        lblLastName.Location = New System.Drawing.Point(52, 233)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New System.Drawing.Size(61, 13)
        lblLastName.TabIndex = 5
        lblLastName.Text = "Last Name:"
        '
        'lblEmail
        '
        lblEmail.AutoSize = True
        lblEmail.Location = New System.Drawing.Point(52, 259)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New System.Drawing.Size(35, 13)
        lblEmail.TabIndex = 7
        lblEmail.Text = "Email:"
        '
        'lblStreet
        '
        lblStreet.AutoSize = True
        lblStreet.Location = New System.Drawing.Point(52, 606)
        lblStreet.Name = "lblStreet"
        lblStreet.Size = New System.Drawing.Size(38, 13)
        lblStreet.TabIndex = 9
        lblStreet.Text = "Street:"
        AddHandler lblStreet.Click, AddressOf Me.lblStreet_Click
        '
        'lblCity
        '
        lblCity.AutoSize = True
        lblCity.Location = New System.Drawing.Point(52, 632)
        lblCity.Name = "lblCity"
        lblCity.Size = New System.Drawing.Size(27, 13)
        lblCity.TabIndex = 11
        lblCity.Text = "City:"
        AddHandler lblCity.Click, AddressOf Me.lblCity_Click
        '
        'lblState
        '
        lblState.AutoSize = True
        lblState.Location = New System.Drawing.Point(52, 658)
        lblState.Name = "lblState"
        lblState.Size = New System.Drawing.Size(35, 13)
        lblState.TabIndex = 13
        lblState.Text = "State:"
        AddHandler lblState.Click, AddressOf Me.lblState_Click
        '
        'lblZipcode
        '
        lblZipcode.AutoSize = True
        lblZipcode.Location = New System.Drawing.Point(52, 684)
        lblZipcode.Name = "lblZipcode"
        lblZipcode.Size = New System.Drawing.Size(49, 13)
        lblZipcode.TabIndex = 15
        lblZipcode.Text = "Zipcode:"
        AddHandler lblZipcode.Click, AddressOf Me.lblZipcode_Click
        '
        'lblSignupDate
        '
        lblSignupDate.AutoSize = True
        lblSignupDate.Location = New System.Drawing.Point(52, 312)
        lblSignupDate.Name = "lblSignupDate"
        lblSignupDate.Size = New System.Drawing.Size(69, 13)
        lblSignupDate.TabIndex = 17
        lblSignupDate.Text = "Signup Date:"
        AddHandler lblSignupDate.Click, AddressOf Me.lblSignupDate_Click
        '
        'lblDateOfBirth
        '
        lblDateOfBirth.AutoSize = True
        lblDateOfBirth.Location = New System.Drawing.Point(52, 286)
        lblDateOfBirth.Name = "lblDateOfBirth"
        lblDateOfBirth.Size = New System.Drawing.Size(71, 13)
        lblDateOfBirth.TabIndex = 19
        lblDateOfBirth.Text = "Date Of Birth:"
        AddHandler lblDateOfBirth.Click, AddressOf Me.lblDateOfBirth_Click
        '
        'lblNumRentalsPaid
        '
        lblNumRentalsPaid.AutoSize = True
        lblNumRentalsPaid.Location = New System.Drawing.Point(52, 337)
        lblNumRentalsPaid.Name = "lblNumRentalsPaid"
        lblNumRentalsPaid.Size = New System.Drawing.Size(95, 13)
        lblNumRentalsPaid.TabIndex = 21
        lblNumRentalsPaid.Text = "Num Rentals Paid:"
        AddHandler lblNumRentalsPaid.Click, AddressOf Me.lblNumRentalsPaid_Click
        '
        'lblHeight
        '
        lblHeight.AutoSize = True
        lblHeight.Location = New System.Drawing.Point(52, 420)
        lblHeight.Name = "lblHeight"
        lblHeight.Size = New System.Drawing.Size(41, 13)
        lblHeight.TabIndex = 23
        lblHeight.Text = "Height:"
        AddHandler lblHeight.Click, AddressOf Me.lblHeight_Click
        '
        'lblWeight
        '
        lblWeight.AutoSize = True
        lblWeight.Location = New System.Drawing.Point(52, 446)
        lblWeight.Name = "lblWeight"
        lblWeight.Size = New System.Drawing.Size(44, 13)
        lblWeight.TabIndex = 25
        lblWeight.Text = "Weight:"
        AddHandler lblWeight.Click, AddressOf Me.lblWeight_Click
        '
        'lblAbilityLevel
        '
        lblAbilityLevel.AutoSize = True
        lblAbilityLevel.Location = New System.Drawing.Point(52, 472)
        lblAbilityLevel.Name = "lblAbilityLevel"
        lblAbilityLevel.Size = New System.Drawing.Size(66, 13)
        lblAbilityLevel.TabIndex = 27
        lblAbilityLevel.Text = "Ability Level:"
        AddHandler lblAbilityLevel.Click, AddressOf Me.lblAbilityLevel_Click
        '
        'lblBootSize
        '
        lblBootSize.AutoSize = True
        lblBootSize.Location = New System.Drawing.Point(52, 498)
        lblBootSize.Name = "lblBootSize"
        lblBootSize.Size = New System.Drawing.Size(55, 13)
        lblBootSize.TabIndex = 29
        lblBootSize.Text = "Boot Size:"
        AddHandler lblBootSize.Click, AddressOf Me.lblBootSize_Click
        '
        'lblBootSoleLength
        '
        lblBootSoleLength.AutoSize = True
        lblBootSoleLength.Location = New System.Drawing.Point(52, 524)
        lblBootSoleLength.Name = "lblBootSoleLength"
        lblBootSoleLength.Size = New System.Drawing.Size(92, 13)
        lblBootSoleLength.TabIndex = 31
        lblBootSoleLength.Text = "Boot Sole Length:"
        AddHandler lblBootSoleLength.Click, AddressOf Me.lblBootSoleLength_Click
        '
        'CustomerBindingNavigator
        '
        Me.CustomerBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CustomerBindingNavigator.AutoSize = False
        Me.CustomerBindingNavigator.BindingSource = Me.CustomerBindingSource
        Me.CustomerBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CustomerBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CustomerBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.CustomerBindingNavigatorSaveItem, Me.BindingNavigatorDeleteItem})
        Me.CustomerBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CustomerBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CustomerBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CustomerBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CustomerBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CustomerBindingNavigator.Name = "CustomerBindingNavigator"
        Me.CustomerBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CustomerBindingNavigator.Size = New System.Drawing.Size(495, 25)
        Me.CustomerBindingNavigator.TabIndex = 0
        Me.CustomerBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.KarveDataSet
        '
        'KarveDataSet
        '
        Me.KarveDataSet.DataSetName = "KarveDataSet"
        Me.KarveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        'CustomerBindingNavigatorSaveItem
        '
        Me.CustomerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CustomerBindingNavigatorSaveItem.Image = CType(resources.GetObject("CustomerBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CustomerBindingNavigatorSaveItem.Name = "CustomerBindingNavigatorSaveItem"
        Me.CustomerBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CustomerBindingNavigatorSaveItem.Text = "Save Data"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "CustomerID", True))
        Me.txtCustomerID.Location = New System.Drawing.Point(153, 178)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(58, 20)
        Me.txtCustomerID.TabIndex = 2
        '
        'txtFirstName
        '
        Me.txtFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "FirstName", True))
        Me.txtFirstName.Location = New System.Drawing.Point(153, 204)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(102, 20)
        Me.txtFirstName.TabIndex = 4
        '
        'txtLastName
        '
        Me.txtLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "LastName", True))
        Me.txtLastName.Location = New System.Drawing.Point(153, 230)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(102, 20)
        Me.txtLastName.TabIndex = 6
        '
        'txtEmail
        '
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Email", True))
        Me.txtEmail.Location = New System.Drawing.Point(153, 256)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(169, 20)
        Me.txtEmail.TabIndex = 8
        '
        'txtStreet
        '
        Me.txtStreet.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Street", True))
        Me.txtStreet.Location = New System.Drawing.Point(119, 603)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(152, 20)
        Me.txtStreet.TabIndex = 10
        '
        'txtCity
        '
        Me.txtCity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "City", True))
        Me.txtCity.Location = New System.Drawing.Point(119, 629)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(102, 20)
        Me.txtCity.TabIndex = 12
        '
        'dpSignupDate
        '
        Me.dpSignupDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerBindingSource, "SignupDate", True))
        Me.dpSignupDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpSignupDate.Location = New System.Drawing.Point(153, 308)
        Me.dpSignupDate.Name = "dpSignupDate"
        Me.dpSignupDate.Size = New System.Drawing.Size(85, 20)
        Me.dpSignupDate.TabIndex = 18
        '
        'dpDateOfBirth
        '
        Me.dpDateOfBirth.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerBindingSource, "DateOfBirth", True))
        Me.dpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpDateOfBirth.Location = New System.Drawing.Point(153, 282)
        Me.dpDateOfBirth.Name = "dpDateOfBirth"
        Me.dpDateOfBirth.Size = New System.Drawing.Size(85, 20)
        Me.dpDateOfBirth.TabIndex = 20
        '
        'txtHeight
        '
        Me.txtHeight.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Height", True))
        Me.txtHeight.Location = New System.Drawing.Point(153, 417)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(75, 20)
        Me.txtHeight.TabIndex = 24
        '
        'txtWeight
        '
        Me.txtWeight.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Weight", True))
        Me.txtWeight.Location = New System.Drawing.Point(153, 443)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(75, 20)
        Me.txtWeight.TabIndex = 26
        '
        'txtBootSoleLength
        '
        Me.txtBootSoleLength.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "BootSoleLength", True))
        Me.txtBootSoleLength.Location = New System.Drawing.Point(153, 521)
        Me.txtBootSoleLength.Name = "txtBootSoleLength"
        Me.txtBootSoleLength.Size = New System.Drawing.Size(44, 20)
        Me.txtBootSoleLength.TabIndex = 32
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BindingModelTableAdapter = Nothing
        Me.TableAdapterManager.BindingTableAdapter = Nothing
        Me.TableAdapterManager.BrandTableAdapter = Nothing
        Me.TableAdapterManager.CustomerTableAdapter = Me.CustomerTableAdapter
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
        'txtZipcode
        '
        Me.txtZipcode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Zipcode", True))
        Me.txtZipcode.Location = New System.Drawing.Point(119, 681)
        Me.txtZipcode.Mask = "00000-9999"
        Me.txtZipcode.Name = "txtZipcode"
        Me.txtZipcode.Size = New System.Drawing.Size(75, 20)
        Me.txtZipcode.TabIndex = 33
        '
        'cboState
        '
        Me.cboState.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CustomerBindingSource, "State", True))
        Me.cboState.DataSource = Me.StateBindingSource
        Me.cboState.DisplayMember = "StateName"
        Me.cboState.FormattingEnabled = True
        Me.cboState.Location = New System.Drawing.Point(119, 655)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(78, 21)
        Me.cboState.TabIndex = 34
        Me.cboState.ValueMember = "StateID"
        '
        'StateBindingSource
        '
        Me.StateBindingSource.DataMember = "State"
        Me.StateBindingSource.DataSource = Me.KarveDataSet
        '
        'StateTableAdapter
        '
        Me.StateTableAdapter.ClearBeforeFill = True
        '
        'cboAbilityLevel
        '
        Me.cboAbilityLevel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "AbilityLevel", True))
        Me.cboAbilityLevel.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.CustomerBindingSource, "AbilityLevel", True))
        Me.cboAbilityLevel.FormattingEnabled = True
        Me.cboAbilityLevel.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cboAbilityLevel.Location = New System.Drawing.Point(153, 469)
        Me.cboAbilityLevel.Name = "cboAbilityLevel"
        Me.cboAbilityLevel.Size = New System.Drawing.Size(44, 21)
        Me.cboAbilityLevel.TabIndex = 35
        '
        'cboBootSize
        '
        Me.cboBootSize.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.CustomerBindingSource, "BootSize", True))
        Me.cboBootSize.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "BootSize", True))
        Me.cboBootSize.FormattingEnabled = True
        Me.cboBootSize.Items.AddRange(New Object() {"22.5", "23.5", "24.5", "25.5", "26.5", "27.5", "28.5", "29.5", "30.5", "31.5"})
        Me.cboBootSize.Location = New System.Drawing.Point(153, 496)
        Me.cboBootSize.Name = "cboBootSize"
        Me.cboBootSize.Size = New System.Drawing.Size(58, 21)
        Me.cboBootSize.TabIndex = 36
        '
        'cboNumRentalsPaid
        '
        Me.cboNumRentalsPaid.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.CustomerBindingSource, "NumRentalsPaid", True))
        Me.cboNumRentalsPaid.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "NumRentalsPaid", True))
        Me.cboNumRentalsPaid.FormattingEnabled = True
        Me.cboNumRentalsPaid.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cboNumRentalsPaid.Location = New System.Drawing.Point(153, 334)
        Me.cboNumRentalsPaid.Name = "cboNumRentalsPaid"
        Me.cboNumRentalsPaid.Size = New System.Drawing.Size(44, 21)
        Me.cboNumRentalsPaid.TabIndex = 37
        '
        'lblNoticeReadOnly
        '
        Me.lblNoticeReadOnly.AutoSize = True
        Me.lblNoticeReadOnly.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoticeReadOnly.ForeColor = System.Drawing.Color.Maroon
        Me.lblNoticeReadOnly.Location = New System.Drawing.Point(12, 88)
        Me.lblNoticeReadOnly.Name = "lblNoticeReadOnly"
        Me.lblNoticeReadOnly.Size = New System.Drawing.Size(307, 18)
        Me.lblNoticeReadOnly.TabIndex = 38
        Me.lblNoticeReadOnly.Text = "Notice: This form is currently in read-only mode."
        Me.lblNoticeReadOnly.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 19)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Personal Info"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 381)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 19)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Rider Specs"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 569)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 19)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Address"
        '
        'FillByLastNameToolStrip
        '
        Me.FillByLastNameToolStrip.AutoSize = False
        Me.FillByLastNameToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LastNameToolStripLabel, Me.txtLastNameToolStrip, Me.tsbtnSearch, Me.tsbtnClear})
        Me.FillByLastNameToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillByLastNameToolStrip.Name = "FillByLastNameToolStrip"
        Me.FillByLastNameToolStrip.Size = New System.Drawing.Size(495, 25)
        Me.FillByLastNameToolStrip.TabIndex = 42
        Me.FillByLastNameToolStrip.Text = "FillByLastNameToolStrip"
        '
        'LastNameToolStripLabel
        '
        Me.LastNameToolStripLabel.Name = "LastNameToolStripLabel"
        Me.LastNameToolStripLabel.Size = New System.Drawing.Size(66, 22)
        Me.LastNameToolStripLabel.Text = "Last Name:"
        '
        'txtLastNameToolStrip
        '
        Me.txtLastNameToolStrip.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtLastNameToolStrip.Name = "txtLastNameToolStrip"
        Me.txtLastNameToolStrip.Size = New System.Drawing.Size(100, 25)
        '
        'tsbtnSearch
        '
        Me.tsbtnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnSearch.Name = "tsbtnSearch"
        Me.tsbtnSearch.Size = New System.Drawing.Size(46, 22)
        Me.tsbtnSearch.Text = "Search"
        Me.tsbtnSearch.ToolTipText = "FillByLastName"
        '
        'tsbtnClear
        '
        Me.tsbtnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnClear.Image = CType(resources.GetObject("tsbtnClear.Image"), System.Drawing.Image)
        Me.tsbtnClear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnClear.Name = "tsbtnClear"
        Me.tsbtnClear.Size = New System.Drawing.Size(38, 22)
        Me.tsbtnClear.Text = "Clear"
        '
        'btnBack
        '
        Me.btnBack.BackgroundImage = Global.PHASE_II.My.Resources.Resources.imgBack
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Location = New System.Drawing.Point(15, 78)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(28, 28)
        Me.btnBack.TabIndex = 50
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(371, 73)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 51
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        Me.btnClose.Visible = False
        '
        'lblDinRec
        '
        Me.lblDinRec.AutoSize = True
        Me.lblDinRec.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDinRec.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblDinRec.Location = New System.Drawing.Point(317, 463)
        Me.lblDinRec.Name = "lblDinRec"
        Me.lblDinRec.Size = New System.Drawing.Size(42, 21)
        Me.lblDinRec.TabIndex = 53
        Me.lblDinRec.Text = "DIN:"
        '
        'grpDIN
        '
        Me.grpDIN.Controls.Add(Me.lblDinValue)
        Me.grpDIN.Location = New System.Drawing.Point(366, 430)
        Me.grpDIN.Name = "grpDIN"
        Me.grpDIN.Size = New System.Drawing.Size(72, 61)
        Me.grpDIN.TabIndex = 52
        Me.grpDIN.TabStop = False
        '
        'lblDinValue
        '
        Me.lblDinValue.AutoSize = True
        Me.lblDinValue.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDinValue.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblDinValue.Location = New System.Drawing.Point(14, 21)
        Me.lblDinValue.Name = "lblDinValue"
        Me.lblDinValue.Size = New System.Drawing.Size(0, 23)
        Me.lblDinValue.TabIndex = 2
        Me.lblDinValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label4.Location = New System.Drawing.Point(275, 442)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 21)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Calculated"
        '
        'lblCustomerTitle
        '
        Me.lblCustomerTitle.AutoSize = True
        Me.lblCustomerTitle.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerTitle.Location = New System.Drawing.Point(76, 73)
        Me.lblCustomerTitle.Name = "lblCustomerTitle"
        Me.lblCustomerTitle.Size = New System.Drawing.Size(145, 39)
        Me.lblCustomerTitle.TabIndex = 55
        Me.lblCustomerTitle.Text = "Customer"
        '
        'Customers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(495, 695)
        Me.Controls.Add(Me.lblCustomerTitle)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblDinRec)
        Me.Controls.Add(Me.grpDIN)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.FillByLastNameToolStrip)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNoticeReadOnly)
        Me.Controls.Add(Me.cboNumRentalsPaid)
        Me.Controls.Add(Me.cboBootSize)
        Me.Controls.Add(Me.cboAbilityLevel)
        Me.Controls.Add(Me.cboState)
        Me.Controls.Add(Me.txtZipcode)
        Me.Controls.Add(lblCustomerID)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(lblFirstName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(lblLastName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(lblEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(lblStreet)
        Me.Controls.Add(Me.txtStreet)
        Me.Controls.Add(lblCity)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(lblState)
        Me.Controls.Add(lblZipcode)
        Me.Controls.Add(lblSignupDate)
        Me.Controls.Add(Me.dpSignupDate)
        Me.Controls.Add(lblDateOfBirth)
        Me.Controls.Add(Me.dpDateOfBirth)
        Me.Controls.Add(lblNumRentalsPaid)
        Me.Controls.Add(lblHeight)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(lblWeight)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(lblAbilityLevel)
        Me.Controls.Add(lblBootSize)
        Me.Controls.Add(lblBootSoleLength)
        Me.Controls.Add(Me.txtBootSoleLength)
        Me.Controls.Add(Me.CustomerBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(300, 0)
        Me.Name = "Customers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        CType(Me.CustomerBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomerBindingNavigator.ResumeLayout(False)
        Me.CustomerBindingNavigator.PerformLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KarveDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByLastNameToolStrip.ResumeLayout(False)
        Me.FillByLastNameToolStrip.PerformLayout()
        Me.grpDIN.ResumeLayout(False)
        Me.grpDIN.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents KarveDataSet As KarveDataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As KarveDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents TableAdapterManager As KarveDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomerBindingNavigator As BindingNavigator
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
    Friend WithEvents CustomerBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtStreet As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents dpSignupDate As DateTimePicker
    Friend WithEvents dpDateOfBirth As DateTimePicker
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtBootSoleLength As TextBox
    Friend WithEvents txtZipcode As MaskedTextBox
    Friend WithEvents cboState As ComboBox
    Friend WithEvents StateBindingSource As BindingSource
    Friend WithEvents StateTableAdapter As KarveDataSetTableAdapters.StateTableAdapter
    Friend WithEvents cboAbilityLevel As ComboBox
    Friend WithEvents cboBootSize As ComboBox
    Friend WithEvents cboNumRentalsPaid As ComboBox
    Friend WithEvents lblNoticeReadOnly As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents FillByLastNameToolStrip As ToolStrip
    Friend WithEvents LastNameToolStripLabel As ToolStripLabel
    Friend WithEvents txtLastNameToolStrip As ToolStripTextBox
    Friend WithEvents tsbtnSearch As ToolStripButton
    Friend WithEvents tsbtnClear As ToolStripButton
    Friend WithEvents btnBack As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblDinRec As Label
    Friend WithEvents grpDIN As GroupBox
    Friend WithEvents lblDinValue As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblCustomerTitle As Label
End Class

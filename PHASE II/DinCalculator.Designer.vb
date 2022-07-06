<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DinCalculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DinCalculator))
        Me.lblDinValue = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblBSL = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtBSL = New System.Windows.Forms.TextBox()
        Me.grpDIN = New System.Windows.Forms.GroupBox()
        Me.lblTitleDIN = New System.Windows.Forms.Label()
        Me.btnCopyDIN = New System.Windows.Forms.Button()
        Me.grpAbilityLevel = New System.Windows.Forms.GroupBox()
        Me.radAbility3 = New System.Windows.Forms.RadioButton()
        Me.radAbility2 = New System.Windows.Forms.RadioButton()
        Me.radAbility1 = New System.Windows.Forms.RadioButton()
        Me.lblPounds = New System.Windows.Forms.Label()
        Me.lblInches = New System.Windows.Forms.Label()
        Me.lblMillimeters = New System.Windows.Forms.Label()
        Me.btnSeeDINChart = New System.Windows.Forms.Button()
        Me.btnCopyLength = New System.Windows.Forms.Button()
        Me.grpLength = New System.Windows.Forms.GroupBox()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.grpTerrainType = New System.Windows.Forms.GroupBox()
        Me.radTerrain5 = New System.Windows.Forms.RadioButton()
        Me.radTerrain4 = New System.Windows.Forms.RadioButton()
        Me.radTerrain3 = New System.Windows.Forms.RadioButton()
        Me.radTerrain2 = New System.Windows.Forms.RadioButton()
        Me.radTerrain1 = New System.Windows.Forms.RadioButton()
        Me.grpSkierStyle = New System.Windows.Forms.GroupBox()
        Me.radSkierStyle3 = New System.Windows.Forms.RadioButton()
        Me.radSkierStyle2 = New System.Windows.Forms.RadioButton()
        Me.radSkierStyle1 = New System.Windows.Forms.RadioButton()
        Me.grpSkierType = New System.Windows.Forms.GroupBox()
        Me.radSkierType3 = New System.Windows.Forms.RadioButton()
        Me.radSkierType2 = New System.Windows.Forms.RadioButton()
        Me.radSkierType1 = New System.Windows.Forms.RadioButton()
        Me.lblPounds2 = New System.Windows.Forms.Label()
        Me.txtWeight2 = New System.Windows.Forms.TextBox()
        Me.lblWeight2 = New System.Windows.Forms.Label()
        Me.lblTitleLength = New System.Windows.Forms.Label()
        Me.linkLengthChart = New System.Windows.Forms.LinkLabel()
        Me.lblLengthRec1 = New System.Windows.Forms.Label()
        Me.lblDinRec = New System.Windows.Forms.Label()
        Me.lblLengthRec2 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnCalculateLength = New System.Windows.Forms.Button()
        Me.btnCalculateDIN = New System.Windows.Forms.Button()
        Me.grpDIN.SuspendLayout()
        Me.grpAbilityLevel.SuspendLayout()
        Me.grpLength.SuspendLayout()
        Me.grpTerrainType.SuspendLayout()
        Me.grpSkierStyle.SuspendLayout()
        Me.grpSkierType.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDinValue
        '
        Me.lblDinValue.AutoSize = True
        Me.lblDinValue.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDinValue.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblDinValue.Location = New System.Drawing.Point(14, 21)
        Me.lblDinValue.Name = "lblDinValue"
        Me.lblDinValue.Size = New System.Drawing.Size(45, 23)
        Me.lblDinValue.TabIndex = 2
        Me.lblDinValue.Text = "5.25"
        Me.lblDinValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(73, 219)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(41, 13)
        Me.lblWeight.TabIndex = 4
        Me.lblWeight.Text = "Weight"
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Location = New System.Drawing.Point(73, 246)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(38, 13)
        Me.lblHeight.TabIndex = 5
        Me.lblHeight.Text = "Height"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(73, 273)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(26, 13)
        Me.lblAge.TabIndex = 6
        Me.lblAge.Text = "Age"
        '
        'lblBSL
        '
        Me.lblBSL.AutoSize = True
        Me.lblBSL.Location = New System.Drawing.Point(73, 300)
        Me.lblBSL.Name = "lblBSL"
        Me.lblBSL.Size = New System.Drawing.Size(89, 13)
        Me.lblBSL.TabIndex = 7
        Me.lblBSL.Text = "Boot Sole Length"
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(174, 215)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(42, 20)
        Me.txtWeight.TabIndex = 9
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(174, 242)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(42, 20)
        Me.txtHeight.TabIndex = 10
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(174, 269)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(42, 20)
        Me.txtAge.TabIndex = 11
        '
        'txtBSL
        '
        Me.txtBSL.Location = New System.Drawing.Point(174, 296)
        Me.txtBSL.Name = "txtBSL"
        Me.txtBSL.Size = New System.Drawing.Size(42, 20)
        Me.txtBSL.TabIndex = 12
        '
        'grpDIN
        '
        Me.grpDIN.Controls.Add(Me.lblDinValue)
        Me.grpDIN.Location = New System.Drawing.Point(144, 412)
        Me.grpDIN.Name = "grpDIN"
        Me.grpDIN.Size = New System.Drawing.Size(72, 61)
        Me.grpDIN.TabIndex = 13
        Me.grpDIN.TabStop = False
        Me.grpDIN.Visible = False
        '
        'lblTitleDIN
        '
        Me.lblTitleDIN.AutoSize = True
        Me.lblTitleDIN.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleDIN.Location = New System.Drawing.Point(70, 52)
        Me.lblTitleDIN.Name = "lblTitleDIN"
        Me.lblTitleDIN.Size = New System.Drawing.Size(202, 26)
        Me.lblTitleDIN.TabIndex = 14
        Me.lblTitleDIN.Text = "DIN Setting Calculator"
        '
        'btnCopyDIN
        '
        Me.btnCopyDIN.Location = New System.Drawing.Point(74, 489)
        Me.btnCopyDIN.Name = "btnCopyDIN"
        Me.btnCopyDIN.Size = New System.Drawing.Size(127, 23)
        Me.btnCopyDIN.TabIndex = 16
        Me.btnCopyDIN.Text = "Copy to Clipboard"
        Me.btnCopyDIN.UseVisualStyleBackColor = True
        Me.btnCopyDIN.Visible = False
        '
        'grpAbilityLevel
        '
        Me.grpAbilityLevel.Controls.Add(Me.radAbility3)
        Me.grpAbilityLevel.Controls.Add(Me.radAbility2)
        Me.grpAbilityLevel.Controls.Add(Me.radAbility1)
        Me.grpAbilityLevel.Location = New System.Drawing.Point(76, 147)
        Me.grpAbilityLevel.Name = "grpAbilityLevel"
        Me.grpAbilityLevel.Size = New System.Drawing.Size(140, 50)
        Me.grpAbilityLevel.TabIndex = 17
        Me.grpAbilityLevel.TabStop = False
        Me.grpAbilityLevel.Text = "Ability Level"
        '
        'radAbility3
        '
        Me.radAbility3.AutoSize = True
        Me.radAbility3.Location = New System.Drawing.Point(93, 19)
        Me.radAbility3.Name = "radAbility3"
        Me.radAbility3.Size = New System.Drawing.Size(31, 17)
        Me.radAbility3.TabIndex = 18
        Me.radAbility3.TabStop = True
        Me.radAbility3.Tag = "3"
        Me.radAbility3.Text = "3"
        Me.radAbility3.UseVisualStyleBackColor = True
        '
        'radAbility2
        '
        Me.radAbility2.AutoSize = True
        Me.radAbility2.Location = New System.Drawing.Point(56, 19)
        Me.radAbility2.Name = "radAbility2"
        Me.radAbility2.Size = New System.Drawing.Size(31, 17)
        Me.radAbility2.TabIndex = 1
        Me.radAbility2.TabStop = True
        Me.radAbility2.Tag = "2"
        Me.radAbility2.Text = "2"
        Me.radAbility2.UseVisualStyleBackColor = True
        '
        'radAbility1
        '
        Me.radAbility1.AutoSize = True
        Me.radAbility1.Location = New System.Drawing.Point(19, 19)
        Me.radAbility1.Name = "radAbility1"
        Me.radAbility1.Size = New System.Drawing.Size(31, 17)
        Me.radAbility1.TabIndex = 0
        Me.radAbility1.TabStop = True
        Me.radAbility1.Tag = "1"
        Me.radAbility1.Text = "1"
        Me.radAbility1.UseVisualStyleBackColor = True
        '
        'lblPounds
        '
        Me.lblPounds.AutoSize = True
        Me.lblPounds.Location = New System.Drawing.Point(222, 219)
        Me.lblPounds.Name = "lblPounds"
        Me.lblPounds.Size = New System.Drawing.Size(23, 13)
        Me.lblPounds.TabIndex = 18
        Me.lblPounds.Text = "lbs."
        '
        'lblInches
        '
        Me.lblInches.AutoSize = True
        Me.lblInches.Location = New System.Drawing.Point(222, 246)
        Me.lblInches.Name = "lblInches"
        Me.lblInches.Size = New System.Drawing.Size(18, 13)
        Me.lblInches.TabIndex = 19
        Me.lblInches.Text = "in."
        '
        'lblMillimeters
        '
        Me.lblMillimeters.AutoSize = True
        Me.lblMillimeters.Location = New System.Drawing.Point(222, 300)
        Me.lblMillimeters.Name = "lblMillimeters"
        Me.lblMillimeters.Size = New System.Drawing.Size(26, 13)
        Me.lblMillimeters.TabIndex = 20
        Me.lblMillimeters.Text = "mm."
        '
        'btnSeeDINChart
        '
        Me.btnSeeDINChart.Location = New System.Drawing.Point(75, 90)
        Me.btnSeeDINChart.Name = "btnSeeDINChart"
        Me.btnSeeDINChart.Size = New System.Drawing.Size(96, 23)
        Me.btnSeeDINChart.TabIndex = 21
        Me.btnSeeDINChart.Text = "See Chart"
        Me.btnSeeDINChart.UseVisualStyleBackColor = True
        '
        'btnCopyLength
        '
        Me.btnCopyLength.Location = New System.Drawing.Point(490, 489)
        Me.btnCopyLength.Name = "btnCopyLength"
        Me.btnCopyLength.Size = New System.Drawing.Size(128, 23)
        Me.btnCopyLength.TabIndex = 44
        Me.btnCopyLength.Text = "Copy to Clipboard"
        Me.btnCopyLength.UseVisualStyleBackColor = True
        Me.btnCopyLength.Visible = False
        '
        'grpLength
        '
        Me.grpLength.Controls.Add(Me.lblLength)
        Me.grpLength.Location = New System.Drawing.Point(557, 412)
        Me.grpLength.Name = "grpLength"
        Me.grpLength.Size = New System.Drawing.Size(90, 61)
        Me.grpLength.TabIndex = 43
        Me.grpLength.TabStop = False
        Me.grpLength.Visible = False
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLength.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblLength.Location = New System.Drawing.Point(7, 21)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(67, 23)
        Me.lblLength.TabIndex = 0
        Me.lblLength.Text = "157 cm"
        '
        'grpTerrainType
        '
        Me.grpTerrainType.Controls.Add(Me.radTerrain5)
        Me.grpTerrainType.Controls.Add(Me.radTerrain4)
        Me.grpTerrainType.Controls.Add(Me.radTerrain3)
        Me.grpTerrainType.Controls.Add(Me.radTerrain2)
        Me.grpTerrainType.Controls.Add(Me.radTerrain1)
        Me.grpTerrainType.Location = New System.Drawing.Point(557, 188)
        Me.grpTerrainType.Name = "grpTerrainType"
        Me.grpTerrainType.Size = New System.Drawing.Size(140, 206)
        Me.grpTerrainType.TabIndex = 42
        Me.grpTerrainType.TabStop = False
        Me.grpTerrainType.Text = "Terrain Type"
        '
        'radTerrain5
        '
        Me.radTerrain5.AutoSize = True
        Me.radTerrain5.Location = New System.Drawing.Point(17, 113)
        Me.radTerrain5.Name = "radTerrain5"
        Me.radTerrain5.Size = New System.Drawing.Size(67, 17)
        Me.radTerrain5.TabIndex = 7
        Me.radTerrain5.TabStop = True
        Me.radTerrain5.Tag = "6"
        Me.radTerrain5.Text = "Freestyle"
        Me.radTerrain5.UseVisualStyleBackColor = True
        '
        'radTerrain4
        '
        Me.radTerrain4.AutoSize = True
        Me.radTerrain4.Location = New System.Drawing.Point(17, 90)
        Me.radTerrain4.Name = "radTerrain4"
        Me.radTerrain4.Size = New System.Drawing.Size(85, 17)
        Me.radTerrain4.TabIndex = 6
        Me.radTerrain4.TabStop = True
        Me.radTerrain4.Tag = "9"
        Me.radTerrain4.Text = "Backcountry"
        Me.radTerrain4.UseVisualStyleBackColor = True
        '
        'radTerrain3
        '
        Me.radTerrain3.AutoSize = True
        Me.radTerrain3.Location = New System.Drawing.Point(17, 67)
        Me.radTerrain3.Name = "radTerrain3"
        Me.radTerrain3.Size = New System.Drawing.Size(101, 17)
        Me.radTerrain3.TabIndex = 5
        Me.radTerrain3.TabStop = True
        Me.radTerrain3.Tag = "6"
        Me.radTerrain3.Text = "All Mtn./Powder"
        Me.radTerrain3.UseVisualStyleBackColor = True
        '
        'radTerrain2
        '
        Me.radTerrain2.AutoSize = True
        Me.radTerrain2.Location = New System.Drawing.Point(17, 44)
        Me.radTerrain2.Name = "radTerrain2"
        Me.radTerrain2.Size = New System.Drawing.Size(83, 17)
        Me.radTerrain2.TabIndex = 4
        Me.radTerrain2.TabStop = True
        Me.radTerrain2.Tag = "3"
        Me.radTerrain2.Text = "All Mountain"
        Me.radTerrain2.UseVisualStyleBackColor = True
        '
        'radTerrain1
        '
        Me.radTerrain1.AutoSize = True
        Me.radTerrain1.Checked = True
        Me.radTerrain1.Location = New System.Drawing.Point(17, 21)
        Me.radTerrain1.Name = "radTerrain1"
        Me.radTerrain1.Size = New System.Drawing.Size(70, 17)
        Me.radTerrain1.TabIndex = 3
        Me.radTerrain1.TabStop = True
        Me.radTerrain1.Tag = "0"
        Me.radTerrain1.Text = "Groomers"
        Me.radTerrain1.UseVisualStyleBackColor = True
        '
        'grpSkierStyle
        '
        Me.grpSkierStyle.Controls.Add(Me.radSkierStyle3)
        Me.grpSkierStyle.Controls.Add(Me.radSkierStyle2)
        Me.grpSkierStyle.Controls.Add(Me.radSkierStyle1)
        Me.grpSkierStyle.Location = New System.Drawing.Point(411, 295)
        Me.grpSkierStyle.Name = "grpSkierStyle"
        Me.grpSkierStyle.Size = New System.Drawing.Size(124, 99)
        Me.grpSkierStyle.TabIndex = 41
        Me.grpSkierStyle.TabStop = False
        Me.grpSkierStyle.Text = "Skier Style"
        '
        'radSkierStyle3
        '
        Me.radSkierStyle3.AutoSize = True
        Me.radSkierStyle3.Location = New System.Drawing.Point(17, 65)
        Me.radSkierStyle3.Name = "radSkierStyle3"
        Me.radSkierStyle3.Size = New System.Drawing.Size(77, 17)
        Me.radSkierStyle3.TabIndex = 5
        Me.radSkierStyle3.TabStop = True
        Me.radSkierStyle3.Tag = "3"
        Me.radSkierStyle3.Text = "Aggressive"
        Me.radSkierStyle3.UseVisualStyleBackColor = True
        '
        'radSkierStyle2
        '
        Me.radSkierStyle2.AutoSize = True
        Me.radSkierStyle2.Checked = True
        Me.radSkierStyle2.Location = New System.Drawing.Point(17, 42)
        Me.radSkierStyle2.Name = "radSkierStyle2"
        Me.radSkierStyle2.Size = New System.Drawing.Size(65, 17)
        Me.radSkierStyle2.TabIndex = 4
        Me.radSkierStyle2.TabStop = True
        Me.radSkierStyle2.Tag = "0"
        Me.radSkierStyle2.Text = "Average"
        Me.radSkierStyle2.UseVisualStyleBackColor = True
        '
        'radSkierStyle1
        '
        Me.radSkierStyle1.AutoSize = True
        Me.radSkierStyle1.Location = New System.Drawing.Point(17, 19)
        Me.radSkierStyle1.Name = "radSkierStyle1"
        Me.radSkierStyle1.Size = New System.Drawing.Size(66, 17)
        Me.radSkierStyle1.TabIndex = 3
        Me.radSkierStyle1.TabStop = True
        Me.radSkierStyle1.Tag = "-3"
        Me.radSkierStyle1.Text = "Cautious"
        Me.radSkierStyle1.UseVisualStyleBackColor = True
        '
        'grpSkierType
        '
        Me.grpSkierType.Controls.Add(Me.radSkierType3)
        Me.grpSkierType.Controls.Add(Me.radSkierType2)
        Me.grpSkierType.Controls.Add(Me.radSkierType1)
        Me.grpSkierType.Location = New System.Drawing.Point(411, 188)
        Me.grpSkierType.Name = "grpSkierType"
        Me.grpSkierType.Size = New System.Drawing.Size(124, 100)
        Me.grpSkierType.TabIndex = 40
        Me.grpSkierType.TabStop = False
        Me.grpSkierType.Text = "Skier Type"
        '
        'radSkierType3
        '
        Me.radSkierType3.AutoSize = True
        Me.radSkierType3.Location = New System.Drawing.Point(17, 67)
        Me.radSkierType3.Name = "radSkierType3"
        Me.radSkierType3.Size = New System.Drawing.Size(74, 17)
        Me.radSkierType3.TabIndex = 2
        Me.radSkierType3.TabStop = True
        Me.radSkierType3.Tag = "6"
        Me.radSkierType3.Text = "Advanced"
        Me.radSkierType3.UseVisualStyleBackColor = True
        '
        'radSkierType2
        '
        Me.radSkierType2.AutoSize = True
        Me.radSkierType2.Checked = True
        Me.radSkierType2.Location = New System.Drawing.Point(17, 44)
        Me.radSkierType2.Name = "radSkierType2"
        Me.radSkierType2.Size = New System.Drawing.Size(83, 17)
        Me.radSkierType2.TabIndex = 1
        Me.radSkierType2.TabStop = True
        Me.radSkierType2.Tag = "3"
        Me.radSkierType2.Text = "Intermediate"
        Me.radSkierType2.UseVisualStyleBackColor = True
        '
        'radSkierType1
        '
        Me.radSkierType1.AutoSize = True
        Me.radSkierType1.Location = New System.Drawing.Point(17, 21)
        Me.radSkierType1.Name = "radSkierType1"
        Me.radSkierType1.Size = New System.Drawing.Size(67, 17)
        Me.radSkierType1.TabIndex = 0
        Me.radSkierType1.TabStop = True
        Me.radSkierType1.Tag = "-3"
        Me.radSkierType1.Text = "Beginner"
        Me.radSkierType1.UseVisualStyleBackColor = True
        '
        'lblPounds2
        '
        Me.lblPounds2.AutoSize = True
        Me.lblPounds2.Location = New System.Drawing.Point(512, 139)
        Me.lblPounds2.Name = "lblPounds2"
        Me.lblPounds2.Size = New System.Drawing.Size(23, 13)
        Me.lblPounds2.TabIndex = 39
        Me.lblPounds2.Text = "lbs."
        '
        'txtWeight2
        '
        Me.txtWeight2.Location = New System.Drawing.Point(460, 136)
        Me.txtWeight2.Name = "txtWeight2"
        Me.txtWeight2.Size = New System.Drawing.Size(46, 20)
        Me.txtWeight2.TabIndex = 38
        '
        'lblWeight2
        '
        Me.lblWeight2.AutoSize = True
        Me.lblWeight2.Location = New System.Drawing.Point(408, 139)
        Me.lblWeight2.Name = "lblWeight2"
        Me.lblWeight2.Size = New System.Drawing.Size(41, 13)
        Me.lblWeight2.TabIndex = 37
        Me.lblWeight2.Text = "Weight"
        '
        'lblTitleLength
        '
        Me.lblTitleLength.AutoSize = True
        Me.lblTitleLength.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleLength.Location = New System.Drawing.Point(406, 52)
        Me.lblTitleLength.Name = "lblTitleLength"
        Me.lblTitleLength.Size = New System.Drawing.Size(208, 26)
        Me.lblTitleLength.TabIndex = 36
        Me.lblTitleLength.Text = "Recommended Length"
        '
        'linkLengthChart
        '
        Me.linkLengthChart.AutoSize = True
        Me.linkLengthChart.LinkColor = System.Drawing.Color.DodgerBlue
        Me.linkLengthChart.Location = New System.Drawing.Point(408, 90)
        Me.linkLengthChart.Name = "linkLengthChart"
        Me.linkLengthChart.Size = New System.Drawing.Size(87, 13)
        Me.linkLengthChart.TabIndex = 45
        Me.linkLengthChart.TabStop = True
        Me.linkLengthChart.Text = "See Chart Online"
        '
        'lblLengthRec1
        '
        Me.lblLengthRec1.AutoSize = True
        Me.lblLengthRec1.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLengthRec1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblLengthRec1.Location = New System.Drawing.Point(425, 427)
        Me.lblLengthRec1.Name = "lblLengthRec1"
        Me.lblLengthRec1.Size = New System.Drawing.Size(118, 21)
        Me.lblLengthRec1.TabIndex = 46
        Me.lblLengthRec1.Text = "Recommended"
        Me.lblLengthRec1.Visible = False
        '
        'lblDinRec
        '
        Me.lblDinRec.AutoSize = True
        Me.lblDinRec.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDinRec.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblDinRec.Location = New System.Drawing.Point(83, 435)
        Me.lblDinRec.Name = "lblDinRec"
        Me.lblDinRec.Size = New System.Drawing.Size(42, 21)
        Me.lblDinRec.TabIndex = 47
        Me.lblDinRec.Text = "DIN:"
        Me.lblDinRec.Visible = False
        '
        'lblLengthRec2
        '
        Me.lblLengthRec2.AutoSize = True
        Me.lblLengthRec2.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLengthRec2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblLengthRec2.Location = New System.Drawing.Point(480, 446)
        Me.lblLengthRec2.Name = "lblLengthRec2"
        Me.lblLengthRec2.Size = New System.Drawing.Size(63, 21)
        Me.lblLengthRec2.TabIndex = 48
        Me.lblLengthRec2.Text = "Length:"
        Me.lblLengthRec2.Visible = False
        '
        'btnBack
        '
        Me.btnBack.BackgroundImage = Global.PHASE_II.My.Resources.Resources.imgBack
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Location = New System.Drawing.Point(25, 25)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(28, 28)
        Me.btnBack.TabIndex = 49
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnCalculateLength
        '
        Me.btnCalculateLength.BackgroundImage = Global.PHASE_II.My.Resources.Resources.imgGoDisabled
        Me.btnCalculateLength.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCalculateLength.Enabled = False
        Me.btnCalculateLength.FlatAppearance.BorderSize = 0
        Me.btnCalculateLength.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCalculateLength.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCalculateLength.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculateLength.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculateLength.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCalculateLength.Location = New System.Drawing.Point(591, 117)
        Me.btnCalculateLength.Name = "btnCalculateLength"
        Me.btnCalculateLength.Size = New System.Drawing.Size(50, 50)
        Me.btnCalculateLength.TabIndex = 35
        Me.btnCalculateLength.UseVisualStyleBackColor = True
        '
        'btnCalculateDIN
        '
        Me.btnCalculateDIN.BackgroundImage = Global.PHASE_II.My.Resources.Resources.imgGoDisabled
        Me.btnCalculateDIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCalculateDIN.Enabled = False
        Me.btnCalculateDIN.FlatAppearance.BorderSize = 0
        Me.btnCalculateDIN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCalculateDIN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCalculateDIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculateDIN.Location = New System.Drawing.Point(75, 329)
        Me.btnCalculateDIN.Name = "btnCalculateDIN"
        Me.btnCalculateDIN.Size = New System.Drawing.Size(50, 50)
        Me.btnCalculateDIN.TabIndex = 0
        Me.btnCalculateDIN.UseVisualStyleBackColor = True
        '
        'DinCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(753, 638)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblLengthRec2)
        Me.Controls.Add(Me.lblDinRec)
        Me.Controls.Add(Me.lblLengthRec1)
        Me.Controls.Add(Me.linkLengthChart)
        Me.Controls.Add(Me.btnCopyLength)
        Me.Controls.Add(Me.btnCalculateLength)
        Me.Controls.Add(Me.grpLength)
        Me.Controls.Add(Me.grpTerrainType)
        Me.Controls.Add(Me.grpSkierStyle)
        Me.Controls.Add(Me.grpSkierType)
        Me.Controls.Add(Me.lblPounds2)
        Me.Controls.Add(Me.txtWeight2)
        Me.Controls.Add(Me.lblWeight2)
        Me.Controls.Add(Me.lblTitleLength)
        Me.Controls.Add(Me.btnSeeDINChart)
        Me.Controls.Add(Me.lblMillimeters)
        Me.Controls.Add(Me.lblInches)
        Me.Controls.Add(Me.lblPounds)
        Me.Controls.Add(Me.grpAbilityLevel)
        Me.Controls.Add(Me.btnCopyDIN)
        Me.Controls.Add(Me.lblTitleDIN)
        Me.Controls.Add(Me.grpDIN)
        Me.Controls.Add(Me.txtBSL)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.lblBSL)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.btnCalculateDIN)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(300, 0)
        Me.Name = "DinCalculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.grpDIN.ResumeLayout(False)
        Me.grpDIN.PerformLayout()
        Me.grpAbilityLevel.ResumeLayout(False)
        Me.grpAbilityLevel.PerformLayout()
        Me.grpLength.ResumeLayout(False)
        Me.grpLength.PerformLayout()
        Me.grpTerrainType.ResumeLayout(False)
        Me.grpTerrainType.PerformLayout()
        Me.grpSkierStyle.ResumeLayout(False)
        Me.grpSkierStyle.PerformLayout()
        Me.grpSkierType.ResumeLayout(False)
        Me.grpSkierType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculateDIN As Button
    Friend WithEvents lblDinValue As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblHeight As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblBSL As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtBSL As TextBox
    Friend WithEvents grpDIN As GroupBox
    Friend WithEvents lblTitleDIN As Label
    Friend WithEvents btnCopyDIN As Button
    Friend WithEvents grpAbilityLevel As GroupBox
    Friend WithEvents radAbility3 As RadioButton
    Friend WithEvents radAbility2 As RadioButton
    Friend WithEvents radAbility1 As RadioButton
    Friend WithEvents lblPounds As Label
    Friend WithEvents lblInches As Label
    Friend WithEvents lblMillimeters As Label
    Friend WithEvents btnSeeDINChart As Button
    Friend WithEvents btnCopyLength As Button
    Friend WithEvents btnCalculateLength As Button
    Friend WithEvents grpLength As GroupBox
    Friend WithEvents lblLength As Label
    Friend WithEvents grpTerrainType As GroupBox
    Friend WithEvents radTerrain5 As RadioButton
    Friend WithEvents radTerrain4 As RadioButton
    Friend WithEvents radTerrain3 As RadioButton
    Friend WithEvents radTerrain2 As RadioButton
    Friend WithEvents radTerrain1 As RadioButton
    Friend WithEvents grpSkierStyle As GroupBox
    Friend WithEvents radSkierStyle3 As RadioButton
    Friend WithEvents radSkierStyle2 As RadioButton
    Friend WithEvents radSkierStyle1 As RadioButton
    Friend WithEvents grpSkierType As GroupBox
    Friend WithEvents radSkierType3 As RadioButton
    Friend WithEvents radSkierType2 As RadioButton
    Friend WithEvents radSkierType1 As RadioButton
    Friend WithEvents lblPounds2 As Label
    Friend WithEvents txtWeight2 As TextBox
    Friend WithEvents lblWeight2 As Label
    Friend WithEvents lblTitleLength As Label
    Friend WithEvents linkLengthChart As LinkLabel
    Friend WithEvents lblLengthRec1 As Label
    Friend WithEvents lblDinRec As Label
    Friend WithEvents lblLengthRec2 As Label
    Friend WithEvents btnBack As Button
End Class

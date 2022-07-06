<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerSearch
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
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cboName = New System.Windows.Forms.ComboBox()
        Me.KarveDataSet = New Phase_II.KarveDataSet()
        Me.CustomerListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerListTableAdapter = New Phase_II.KarveDataSetTableAdapters.CustomerListTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.KarveDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(141, 133)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'cboName
        '
        Me.cboName.DataSource = Me.CustomerListBindingSource
        Me.cboName.DisplayMember = "FullName"
        Me.cboName.FormattingEnabled = True
        Me.cboName.Location = New System.Drawing.Point(95, 45)
        Me.cboName.Name = "cboName"
        Me.cboName.Size = New System.Drawing.Size(121, 21)
        Me.cboName.TabIndex = 1
        Me.cboName.ValueMember = "CustomerID"
        '
        'KarveDataSet
        '
        Me.KarveDataSet.DataSetName = "KarveDataSet"
        Me.KarveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerListBindingSource
        '
        Me.CustomerListBindingSource.DataMember = "CustomerList"
        Me.CustomerListBindingSource.DataSource = Me.KarveDataSet
        '
        'CustomerListTableAdapter
        '
        Me.CustomerListTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(313, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'CustomerSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboName)
        Me.Controls.Add(Me.btnSearch)
        Me.Name = "CustomerSearch"
        Me.Text = "Customer Search"
        CType(Me.KarveDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSearch As Button
    Friend WithEvents cboName As ComboBox
    Friend WithEvents KarveDataSet As KarveDataSet
    Friend WithEvents CustomerListBindingSource As BindingSource
    Friend WithEvents CustomerListTableAdapter As KarveDataSetTableAdapters.CustomerListTableAdapter
    Friend WithEvents Label1 As Label
End Class

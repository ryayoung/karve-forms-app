<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Startup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Startup))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDinChart = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSkiModel = New System.Windows.Forms.Button()
        Me.btnSkiBinding = New System.Windows.Forms.Button()
        Me.btnCustomers = New System.Windows.Forms.Button()
        Me.btnCalculateDin = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 33)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Karve Ski Demos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "INFORMATION MANAGEMENT"
        '
        'btnExit
        '
        Me.btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), System.Drawing.Image)
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(37, 640)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(200, 52)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "         Leave"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnDinChart
        '
        Me.btnDinChart.BackgroundImage = CType(resources.GetObject("btnDinChart.BackgroundImage"), System.Drawing.Image)
        Me.btnDinChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDinChart.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnDinChart.FlatAppearance.BorderSize = 0
        Me.btnDinChart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDinChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDinChart.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDinChart.Location = New System.Drawing.Point(37, 282)
        Me.btnDinChart.Name = "btnDinChart"
        Me.btnDinChart.Size = New System.Drawing.Size(200, 52)
        Me.btnDinChart.TabIndex = 8
        Me.btnDinChart.Text = "DIN Chart"
        Me.btnDinChart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDinChart.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PHASE_II.My.Resources.Resources.imgLogo
        Me.PictureBox1.Location = New System.Drawing.Point(39, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'btnSkiModel
        '
        Me.btnSkiModel.BackgroundImage = CType(resources.GetObject("btnSkiModel.BackgroundImage"), System.Drawing.Image)
        Me.btnSkiModel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSkiModel.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSkiModel.FlatAppearance.BorderSize = 0
        Me.btnSkiModel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSkiModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSkiModel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSkiModel.Location = New System.Drawing.Point(37, 529)
        Me.btnSkiModel.Name = "btnSkiModel"
        Me.btnSkiModel.Size = New System.Drawing.Size(200, 52)
        Me.btnSkiModel.TabIndex = 4
        Me.btnSkiModel.Text = "Ski Model"
        Me.btnSkiModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSkiModel.UseVisualStyleBackColor = False
        '
        'btnSkiBinding
        '
        Me.btnSkiBinding.BackgroundImage = CType(resources.GetObject("btnSkiBinding.BackgroundImage"), System.Drawing.Image)
        Me.btnSkiBinding.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSkiBinding.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSkiBinding.FlatAppearance.BorderSize = 0
        Me.btnSkiBinding.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSkiBinding.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSkiBinding.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSkiBinding.Location = New System.Drawing.Point(37, 477)
        Me.btnSkiBinding.Name = "btnSkiBinding"
        Me.btnSkiBinding.Size = New System.Drawing.Size(200, 52)
        Me.btnSkiBinding.TabIndex = 3
        Me.btnSkiBinding.Text = "Skis Mounted"
        Me.btnSkiBinding.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSkiBinding.UseVisualStyleBackColor = False
        '
        'btnCustomers
        '
        Me.btnCustomers.BackgroundImage = CType(resources.GetObject("btnCustomers.BackgroundImage"), System.Drawing.Image)
        Me.btnCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCustomers.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCustomers.FlatAppearance.BorderSize = 0
        Me.btnCustomers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomers.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomers.Location = New System.Drawing.Point(37, 425)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Size = New System.Drawing.Size(200, 52)
        Me.btnCustomers.TabIndex = 2
        Me.btnCustomers.Text = "Customers"
        Me.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomers.UseVisualStyleBackColor = False
        '
        'btnCalculateDin
        '
        Me.btnCalculateDin.BackgroundImage = CType(resources.GetObject("btnCalculateDin.BackgroundImage"), System.Drawing.Image)
        Me.btnCalculateDin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCalculateDin.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCalculateDin.FlatAppearance.BorderSize = 0
        Me.btnCalculateDin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCalculateDin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculateDin.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculateDin.Location = New System.Drawing.Point(37, 230)
        Me.btnCalculateDin.Name = "btnCalculateDin"
        Me.btnCalculateDin.Size = New System.Drawing.Size(200, 52)
        Me.btnCalculateDin.TabIndex = 1
        Me.btnCalculateDin.Text = "DIN Calculator"
        Me.btnCalculateDin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCalculateDin.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackgroundImage = CType(resources.GetObject("btnSearch.BackgroundImage"), System.Drawing.Image)
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(37, 373)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(200, 52)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "Search Orders"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'Startup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(800, 739)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDinChart)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSkiModel)
        Me.Controls.Add(Me.btnSkiBinding)
        Me.Controls.Add(Me.btnCustomers)
        Me.Controls.Add(Me.btnCalculateDin)
        Me.Controls.Add(Me.btnSearch)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Startup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Karve"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSearch As Button
    Friend WithEvents btnCalculateDin As Button
    Friend WithEvents btnCustomers As Button
    Friend WithEvents btnSkiBinding As Button
    Friend WithEvents btnSkiModel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDinChart As Button
    Friend WithEvents btnExit As Button
End Class

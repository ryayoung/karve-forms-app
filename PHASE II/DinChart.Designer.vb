<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DinChart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DinChart))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.linkChart = New System.Windows.Forms.LinkLabel()
        Me.picChart = New System.Windows.Forms.PictureBox()
        Me.btnInstructions = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grpInstructions = New System.Windows.Forms.GroupBox()
        CType(Me.picChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInstructions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(32, 29)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(201, 23)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Ski Boot Release Setting"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(548, 29)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'linkChart
        '
        Me.linkChart.AutoSize = True
        Me.linkChart.Location = New System.Drawing.Point(253, 36)
        Me.linkChart.Name = "linkChart"
        Me.linkChart.Size = New System.Drawing.Size(107, 13)
        Me.linkChart.TabIndex = 2
        Me.linkChart.TabStop = True
        Me.linkChart.Tag = "https://www.gearx.com/blog/wp-content/uploads/2017/01/DINDINDIN.png"
        Me.linkChart.Text = "View this chart online"
        '
        'picChart
        '
        Me.picChart.Image = Global.PHASE_II.My.Resources.Resources.DIN_SETTINGS
        Me.picChart.Location = New System.Drawing.Point(36, 220)
        Me.picChart.Name = "picChart"
        Me.picChart.Size = New System.Drawing.Size(569, 695)
        Me.picChart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picChart.TabIndex = 3
        Me.picChart.TabStop = False
        '
        'btnInstructions
        '
        Me.btnInstructions.Location = New System.Drawing.Point(391, 29)
        Me.btnInstructions.Name = "btnInstructions"
        Me.btnInstructions.Size = New System.Drawing.Size(119, 23)
        Me.btnInstructions.TabIndex = 4
        Me.btnInstructions.Text = "See Instructions"
        Me.btnInstructions.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "1. Determine Skier Code (A, B, C...) based on weight"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "2. Determine Skier Code based on height"
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(33, 70)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(104, 18)
        Me.lblInstructions.TabIndex = 7
        Me.lblInstructions.Text = "INSTRUCTIONS:"
        Me.lblInstructions.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(402, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "3. Skier code becomes whichever of these two values that falls highest on the cha" &
    "rt"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(442, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "4. If skier type is 2, move 1 value down the chart. If type is 3, move 2 values d" &
    "own the chart."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(318, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "5. If older than 50 or younger than 9, move one value up the chart"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(287, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "6. Finally, pick column (1, 2, 3...) based on boot sole length."
        '
        'grpInstructions
        '
        Me.grpInstructions.Controls.Add(Me.Label1)
        Me.grpInstructions.Controls.Add(Me.Label7)
        Me.grpInstructions.Controls.Add(Me.Label2)
        Me.grpInstructions.Controls.Add(Me.Label6)
        Me.grpInstructions.Controls.Add(Me.Label4)
        Me.grpInstructions.Controls.Add(Me.Label5)
        Me.grpInstructions.Location = New System.Drawing.Point(36, 91)
        Me.grpInstructions.Name = "grpInstructions"
        Me.grpInstructions.Size = New System.Drawing.Size(569, 123)
        Me.grpInstructions.TabIndex = 12
        Me.grpInstructions.TabStop = False
        Me.grpInstructions.Visible = False
        '
        'DinChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(693, 975)
        Me.Controls.Add(Me.grpInstructions)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnInstructions)
        Me.Controls.Add(Me.picChart)
        Me.Controls.Add(Me.linkChart)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblTitle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DinChart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.picChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInstructions.ResumeLayout(False)
        Me.grpInstructions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents linkChart As LinkLabel
    Friend WithEvents picChart As PictureBox
    Friend WithEvents btnInstructions As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblInstructions As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents grpInstructions As GroupBox
End Class

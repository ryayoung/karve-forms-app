Imports System.Drawing.Drawing2D
Imports System.Drawing
Imports System.ComponentModel

Public Class DinCalculator
    Private Sub DinCalculator_Load(sender As Object, e As EventArgs) Handles Me.Load
        CheckIfValuesFilled()
        Me.Height = My.Computer.Screen.Bounds.Size.Height
    End Sub
    Private Sub DinCalculator_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Globals.DrawGradientLine(e.Graphics, 350, 0, 350, Me.Height / 2, Color.LightGray, Color.White, 2)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Startup.Show()
        Startup.ChangeButtonsToClosed()
        Me.Close()
        Startup.Invalidate()
    End Sub

    Private Sub btnCopyDIN_Click(sender As Object, e As EventArgs) Handles btnCopyDIN.Click
        My.Computer.Clipboard.SetText(Me.lblDinValue.Text)
    End Sub


    Private Sub btnCalculateDIN_Click(sender As Object, e As EventArgs) Handles btnCalculateDIN.Click
        btnCalculateDIN.Enabled = False
        Try
            Me.lblDinValue.Text = Globals.CalculateDin(
                Globals.EvaluateRadioGroupInteger(grpAbilityLevel),
                Convert.ToInt32(Me.txtAge.Text),
                Convert.ToInt32(Me.txtHeight.Text),
                Convert.ToInt32(Me.txtWeight.Text),
                Convert.ToInt32(Me.txtBSL.Text)
            )
            Me.grpDIN.Visible = True
            Me.btnCopyDIN.Visible = True
            Me.lblDinRec.Visible = True

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnCalculateDIN_MouseHover(sender As Object, e As EventArgs) Handles btnCalculateDIN.MouseHover
        If btnCalculateDIN.Enabled = True Then
            btnCalculateDIN.BackgroundImage = My.Resources.imgGoHovered
        Else
            btnCalculateDIN.BackgroundImage = My.Resources.imgGoDisabled
        End If
    End Sub

    Private Sub btnCalculateDIN_MouseLeave(sender As Object, e As EventArgs) Handles btnCalculateDIN.MouseLeave
        If btnCalculateDIN.Enabled = True Then
            btnCalculateDIN.BackgroundImage = My.Resources.imgGoNormal
        Else
            btnCalculateDIN.BackgroundImage = My.Resources.imgGoDisabled
        End If
    End Sub

    Private Sub CheckIfValuesFilled()
        Dim filled As Single
        For Each button In grpAbilityLevel.Controls
            If button.Checked Then filled += 1
        Next
        If txtWeight.Text <> "" Then filled += 1
        If txtHeight.Text <> "" Then filled += 1
        If txtAge.Text <> "" Then filled += 1
        If txtBSL.Text <> "" Then filled += 1

        If filled = 5 Then
            btnCalculateDIN.Enabled = True
        Else
            btnCalculateDIN.Enabled = False
        End If
    End Sub

    Private Sub btnCalculateDIN_EnabledChanged(sender As Object, e As EventArgs) Handles btnCalculateDIN.EnabledChanged
        If btnCalculateDIN.Enabled = True Then
            btnCalculateDIN.BackgroundImage = My.Resources.imgGoNormal
        Else
            btnCalculateDIN.BackgroundImage = My.Resources.imgGoDisabled
        End If
    End Sub

    Private Sub btnSeeDINChart_Click(sender As Object, e As EventArgs) Handles btnSeeDINChart.Click
        'Only open chart if there isn't one already open.
        Dim countChartsOpen = (From g In My.Application.OpenForms Where CType(g, Form).Name = "DinChart").Count
        If countChartsOpen > 0 Then
            MsgBox("Chart is already open!")
            Return
        End If
        DinChart.Show()
    End Sub

    'The following serves 2 purposes:
    '1. GO buttons must only be enabled if ALL required user inputs are filled in
    '2. GO buttons are disabled after each use, and the user must change an input for it to be re-enabled.
    Private Sub radAbility1_CheckedChanged(sender As Object, e As EventArgs) Handles radAbility1.CheckedChanged
        CheckIfValuesFilled()
    End Sub

    Private Sub radAbility2_CheckedChanged(sender As Object, e As EventArgs) Handles radAbility2.CheckedChanged
        CheckIfValuesFilled()
    End Sub

    Private Sub radAbility3_CheckedChanged(sender As Object, e As EventArgs) Handles radAbility3.CheckedChanged
        CheckIfValuesFilled()
    End Sub

    Private Sub txtWeight2_TextChanged(sender As Object, e As EventArgs) Handles txtWeight.TextChanged
        CheckIfValuesFilled()
    End Sub

    Private Sub txtHeight_TextChanged(sender As Object, e As EventArgs) Handles txtHeight.TextChanged
        CheckIfValuesFilled()
    End Sub

    Private Sub txtAge_TextChanged(sender As Object, e As EventArgs) Handles txtAge.TextChanged
        CheckIfValuesFilled()
    End Sub

    Private Sub txtBSL_TextChanged(sender As Object, e As EventArgs) Handles txtBSL.TextChanged
        CheckIfValuesFilled()
    End Sub


    '------------------------------------------------------------------------------------------------------------
    'END DIN CALCULATOR
    'START LENGTH CALCULATOR
    '------------------------------------------------------------------------------------------------------------

    Private Sub LengthCalculator_Load(sender As Object, e As EventArgs) Handles Me.Load
        CheckIfWeightFilled()
    End Sub

    Private Sub btnCopyLength_Click(sender As Object, e As EventArgs) Handles btnCopyLength.Click
        My.Computer.Clipboard.SetText(Me.lblLength.Text)
    End Sub

    'Link shows the source with the chart from which the CalculateLength() sub was written
    Private Sub linkLengthChart_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLengthChart.LinkClicked
        System.Diagnostics.Process.Start("https://www.skis.com/size-chart/skis,default,pg.html")
    End Sub


    Private Sub btnCalculateLength_Click(sender As Object, e As EventArgs) Handles btnCalculateLength.Click
        btnCalculateLength.Enabled = False
        Try
            Me.lblLength.Text = Globals.CalculateLength(Convert.ToInt32(Me.txtWeight2.Text),
                                                        Globals.EvaluateRadioGroupInteger(grpSkierType),
                                                        Globals.EvaluateRadioGroupInteger(grpSkierStyle),
                                                        Globals.EvaluateRadioGroupInteger(grpTerrainType))
            Me.lblLength.Text += " cm"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.grpLength.Visible = True
        Me.btnCopyLength.Visible = True
        Me.lblLengthRec1.Visible = True
        Me.lblLengthRec2.Visible = True
    End Sub

    Private Sub btnCalculateLength_MouseHover(sender As Object, e As EventArgs) Handles btnCalculateLength.MouseHover
        If btnCalculateLength.Enabled = True Then
            btnCalculateLength.BackgroundImage = My.Resources.imgGoHovered
        Else
            btnCalculateLength.BackgroundImage = My.Resources.imgGoDisabled
        End If
    End Sub

    Private Sub btnCalculateLength_MouseLeave(sender As Object, e As EventArgs) Handles btnCalculateLength.MouseLeave
        If btnCalculateLength.Enabled = True Then
            btnCalculateLength.BackgroundImage = My.Resources.imgGoNormal
        Else
            btnCalculateLength.BackgroundImage = My.Resources.imgGoDisabled
        End If
    End Sub

    Private Sub CheckIfWeightFilled()
        If txtWeight2.Text <> "" Then
            btnCalculateLength.Enabled = True
        Else
            btnCalculateLength.Enabled = False
        End If
    End Sub

    Private Sub btnCalculateLength_EnabledChanged(sender As Object, e As EventArgs) Handles btnCalculateLength.EnabledChanged
        If btnCalculateLength.Enabled = True Then
            btnCalculateLength.BackgroundImage = My.Resources.imgGoNormal
        Else
            btnCalculateLength.BackgroundImage = My.Resources.imgGoDisabled
        End If
    End Sub


    'The following serves 2 purposes:
    '1. GO buttons must only be enabled if ALL required user inputs are filled in
    '2. GO buttons are disabled after each use, and the user must change an input for it to be re-enabled.
    Private Sub txtWeight_TextChanged(sender As Object, e As EventArgs) Handles txtWeight2.TextChanged
        CheckIfWeightFilled()
    End Sub
    Private Sub radSkierType1_CheckedChanged(sender As Object, e As EventArgs) Handles radSkierType1.CheckedChanged
        CheckIfWeightFilled()
    End Sub
    Private Sub radSkierType2_CheckedChanged(sender As Object, e As EventArgs) Handles radSkierType2.CheckedChanged
        CheckIfWeightFilled()
    End Sub
    Private Sub radSkierType3_CheckedChanged(sender As Object, e As EventArgs) Handles radSkierType3.CheckedChanged
        CheckIfWeightFilled()
    End Sub
    Private Sub radSkierStyle1_CheckedChanged(sender As Object, e As EventArgs) Handles radSkierStyle1.CheckedChanged
        CheckIfWeightFilled()
    End Sub
    Private Sub radSkierStyle2_CheckedChanged(sender As Object, e As EventArgs) Handles radSkierStyle2.CheckedChanged
        CheckIfWeightFilled()
    End Sub
    Private Sub radSkierStyle3_CheckedChanged(sender As Object, e As EventArgs) Handles radSkierStyle3.CheckedChanged
        CheckIfWeightFilled()
    End Sub
    Private Sub radTerrain1_CheckedChanged(sender As Object, e As EventArgs) Handles radTerrain1.CheckedChanged
        CheckIfWeightFilled()
    End Sub
    Private Sub radTerrain2_CheckedChanged(sender As Object, e As EventArgs) Handles radTerrain2.CheckedChanged
        CheckIfWeightFilled()
    End Sub
    Private Sub radTerrain3_CheckedChanged(sender As Object, e As EventArgs) Handles radTerrain3.CheckedChanged
        CheckIfWeightFilled()
    End Sub
    Private Sub radTerrain4_CheckedChanged(sender As Object, e As EventArgs) Handles radTerrain4.CheckedChanged
        CheckIfWeightFilled()
    End Sub
    Private Sub radTerrain5_CheckedChanged(sender As Object, e As EventArgs) Handles radTerrain5.CheckedChanged
        CheckIfWeightFilled()
    End Sub

    Private Sub txtWeight_Validating(sender As Object, e As CancelEventArgs) Handles txtWeight.Validating
        If Int32.TryParse(txtWeight.Text, 1) = False And txtWeight.Text <> "" Then
            MsgBox("Weight must be an integer.")
            e.Cancel = True
            txtWeight.Text = ""
        End If
    End Sub
    Private Sub txtHeight_Validating(sender As Object, e As CancelEventArgs) Handles txtHeight.Validating
        If Int32.TryParse(txtHeight.Text, 1) = False And txtHeight.Text <> "" Then
            MsgBox("Height must be an integer.")
            e.Cancel = True
            txtHeight.Text = ""
        End If
    End Sub

    Private Sub txtAge_Validating(sender As Object, e As CancelEventArgs) Handles txtAge.Validating
        If Int32.TryParse(txtAge.Text, 1) = False And txtAge.Text <> "" Then
            MsgBox("Age must be an integer.")
            e.Cancel = True
            txtAge.Text = ""
        End If
    End Sub

    Private Sub txtBSL_Validating(sender As Object, e As CancelEventArgs) Handles txtBSL.Validating
        If Int32.TryParse(txtBSL.Text, 1) = False And txtBSL.Text <> "" Then
            MsgBox("BSL must be an integer.")
            e.Cancel = True
            txtBSL.Text = ""
        End If
    End Sub

    Private Sub txtWeight2_Validating(sender As Object, e As CancelEventArgs) Handles txtWeight2.Validating
        If Int32.TryParse(txtWeight2.Text, 1) = False And txtWeight2.Text <> "" Then
            MsgBox("Weight must be an integer.")
            e.Cancel = True
            txtWeight2.Text = ""
        End If
    End Sub


    'TEMPORARY ----------------------------------------------------------------------------------------------
    Private Sub LengthCalculator_Click(sender As Object, e As MouseEventArgs) Handles Me.Click
        'Globals.DrawPointOnScreen(Me, e)
    End Sub
    'END TEMPORARY ----------------------------------------------------------------------------------------------

End Class
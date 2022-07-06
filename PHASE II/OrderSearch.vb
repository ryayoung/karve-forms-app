Imports System.ComponentModel
Imports System.Drawing.Drawing2D

Public Class OrderSearch
    Private Sub OrderSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KarveDataSet.RentalHistory' table. You can move, or remove it, as needed.
        'Me.RentalHistoryTableAdapter.Fill(Me.KarveDataSet.RentalHistory)
        Me.dpMaxDate.Value = Today
        Search()
        Me.lblMinLengthValue.ForeColor = Color.Black
        Me.lblMaxLengthValue.ForeColor = Color.Black
        Me.lblMinWidthValue.ForeColor = Color.Black
        Me.lblMaxWidthValue.ForeColor = Color.Black

        Me.Location = New Point(300, 0)
        Me.Height = Globals.screenHeight

    End Sub
    Private Sub OrderSearch_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Globals.DrawGradientLine(e.Graphics, 464, 350, 864, 350, Color.LightGray, Color.LightGray, 1)
        Globals.DrawGradientLine(e.Graphics, 464, 422, 864, 422, Color.LightGray, Color.LightGray, 1)
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Startup.Show()
        Startup.ChangeButtonsToClosed()
        Me.Close()
        Startup.Invalidate()
    End Sub

    'SEARCH BUTTON CLICK
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Search()
    End Sub
    Private Sub btnSearch_MouseHover(sender As Object, e As EventArgs) Handles btnSearch.MouseHover
        btnSearch.BackgroundImage = My.Resources.imgGoHovered
    End Sub
    Private Sub btnSearch_MouseLeave(sender As Object, e As EventArgs) Handles btnSearch.MouseLeave
        btnSearch.BackgroundImage = My.Resources.imgGoNormal
    End Sub

    'TRACKBAR VALUE CHANGED:
    'Update length & width labels to show precise value
    'Change color of length & width labels to highlight the precise value
    Private Sub tbMinLength_ValueChanged(sender As Object, e As EventArgs) Handles tbMinLength.ValueChanged
        Me.lblMinLengthValue.Text = Me.tbMinLength.Value
        Me.lblMinLengthValue.ForeColor = Color.DodgerBlue
        'VALIDATE POSITION
        If Me.tbMinLength.Value > Me.tbMaxLength.Value Then
            Me.tbMinLength.Value = Me.tbMaxLength.Value
        End If
    End Sub
    Private Sub tbMaxLength_ValueChanged(sender As Object, e As EventArgs) Handles tbMaxLength.ValueChanged
        Me.lblMaxLengthValue.ForeColor = Color.DodgerBlue
        Me.lblMaxLengthValue.Text = Me.tbMaxLength.Value.ToString() + " cm"
        'VALIDATE POSITION
        If Me.tbMaxLength.Value < Me.tbMinLength.Value Then
            Me.tbMaxLength.Value = Me.tbMinLength.Value
        End If
    End Sub
    Private Sub tbMinWidth_ValueChanged(sender As Object, e As EventArgs) Handles tbMinWidth.ValueChanged
        Me.lblMinWidthValue.ForeColor = Color.DodgerBlue
        Me.lblMinWidthValue.Text = Me.tbMinWidth.Value
        'VALIDATE POSITION
        If Me.tbMinWidth.Value > Me.tbMaxWidth.Value Then
            Me.tbMinWidth.Value = Me.tbMaxWidth.Value
        End If
    End Sub
    Private Sub tbMaxWidth_ValueChanged(sender As Object, e As EventArgs) Handles tbMaxWidth.ValueChanged
        Me.lblMaxWidthValue.ForeColor = Color.DodgerBlue
        Me.lblMaxWidthValue.Text = Me.tbMaxWidth.Value.ToString() + " mm"
        'VALIDATE POSITION
        If Me.tbMaxWidth.Value < Me.tbMinWidth.Value Then
            Me.tbMaxWidth.Value = Me.tbMinWidth.Value
        End If
    End Sub

    'ON MOUSE RELEASE OF TRACKBAR:
    'Update search after user drags a slider 
    'Reset color back to black
    Private Sub tbMinLength_MouseUp(sender As Object, e As EventArgs) Handles tbMinLength.MouseUp
        Me.lblMinLengthValue.ForeColor = Color.Black
        Search()
    End Sub
    Private Sub tbMaxLength_MouseUp(sender As Object, e As EventArgs) Handles tbMaxLength.MouseUp
        Me.lblMaxLengthValue.ForeColor = Color.Black
        Search()
    End Sub
    Private Sub tbMinWidth_MouseUp(sender As Object, e As EventArgs) Handles tbMinWidth.MouseUp
        Me.lblMinWidthValue.ForeColor = Color.Black
        Search()
    End Sub
    Private Sub tbMaxWidth_MouseUp(sender As Object, e As EventArgs) Handles tbMaxWidth.MouseUp
        Me.lblMaxWidthValue.ForeColor = Color.Black
        Search()
    End Sub

    'Fills the datagridview and updates values
    Private Sub Search()
        Try
            Me.RentalHistoryTableAdapter.FillBy(
                Me.KarveDataSet.RentalHistory,
                Me.tbMinLength.Value,
                Me.tbMaxLength.Value,
                Me.tbMinWidth.Value,
                Me.tbMaxWidth.Value,
                Globals.EvaluateRadioGroupString(Me.grpOrderStatus),
                Globals.EvaluateRadioGroupString(Me.grpDamage),
                Me.dpMinDate.Value,
                Me.dpMaxDate.Value)

            Dim scrollBarSize As Integer = 17

            'Initialize grid height to zero rows
            Me.RentalHistoryDataGridView.Height = 64
            Me.RentalHistoryDataGridView.Width = 900 + scrollBarSize
            Me.RentalHistoryDataGridView.Left = 43
            'If we're only viewing ACTIVE orders, crop out the last 4 columns because they will be blank
            If Me.radOrderStatusActive.Checked = True Then
                Me.RentalHistoryDataGridView.Width -= 260
                Me.RentalHistoryDataGridView.Height += scrollBarSize 'Make extra room for the horizontal scroll bar
                Me.RentalHistoryDataGridView.Left += 100
            End If

            'Dim sum As Integer
            Dim numNotTuned As Integer
            Dim numDamaged As Integer
            Dim rowCount As Integer = -1
            Dim avgLength As Decimal
            Dim avgWidth As Decimal

            Dim dgvr As System.Windows.Forms.DataGridViewRow
            For Each dgvr In Me.RentalHistoryDataGridView.Rows
                avgLength += dgvr.Cells("Length").Value
                avgWidth += dgvr.Cells("Width").Value
                rowCount += 1
                'Count damaged
                If dgvr.Cells("Damage").Value <> "-" AndAlso dgvr.Cells("Damage").Value <> "" Then
                    numDamaged += 1
                End If
                'Count how many returned orders are not tuned yet
                If dgvr.Cells("TuneTime").Value = -2 Then
                    numNotTuned += 1
                End If
                'Increment grid height for each row
                If rowCount < 20 Then
                    Me.RentalHistoryDataGridView.Height += 22
                End If
                'Adjust formatting
                FormatCells(dgvr)
            Next dgvr

            avgLength = Globals.Divide(avgLength, rowCount)
            avgWidth = Globals.Divide(avgWidth, rowCount)

            'If a vertical scroll bar isn't needed, remove the space it would occupy
            If rowCount < 15 Then
                Me.RentalHistoryDataGridView.Width -= scrollBarSize
            End If

            'Display warning if one or more skis need to be tuned
            If numNotTuned > 0 Then
                Me.lblNoticeNotTuned.Visible = True
                Me.lblNoticeNotTuned.ForeColor = Color.DarkGoldenrod
                Me.lblNoticeNotTuned.Text = "Notice: " + numNotTuned.ToString() + " skis need to be tuned."
            Else
                Me.lblNoticeNotTuned.Visible = False
            End If

            'Display warning if one or more skis are damaged
            If numDamaged > 0 Then
                Me.lblNoticeDamage.Visible = True
                Me.lblNoticeDamage.ForeColor = Color.Tomato
                Me.lblNoticeDamage.Text = "Notice: " + numDamaged.ToString() + " skis were damaged."
            Else
                Me.lblNoticeDamage.Visible = False
            End If

            'Display warning if no listings are found
            If rowCount = 0 Then
                Me.lblNoListingsFound.Visible = True
                Me.lblAvgLengthLabel.Visible = False
                Me.lblAvgWidthLabel.Visible = False
                Me.lblAvgLength.Visible = False
                Me.lblAvgWidth.Visible = False
            Else
                Me.lblAvgLengthLabel.Visible = True
                Me.lblAvgWidthLabel.Visible = True
                Me.lblAvgLength.Visible = True
                Me.lblAvgWidth.Visible = True
                Me.lblAvgLength.Text = avgLength.ToString("###") + " cm"
                Me.lblAvgWidth.Text = avgWidth.ToString("###") + " mm"

                Me.lblNoListingsFound.Visible = False
            End If

        Catch ex As Exception
            Me.lblNoListingsFound.Visible = True
            Me.lblNoListingsFound.Text += " - Error."
            Me.RentalHistoryDataGridView.Visible = False
            MsgBox(ex.Message)
        End Try
    End Sub

    'This function takes a datagridview row object and formats it according to the following criteria
    Private Sub FormatCells(row)
        If row.Cells("Damage").Value <> "-" AndAlso row.Cells("Damage").Value <> "" Then
            row.Cells("Damage").Style.BackColor = Color.LightSalmon
            row.Cells("TuneTime").Style.BackColor = Color.LightSalmon
        End If
        'If a returned ski hasn't been tuned yet
        If row.Cells("TuneTime").Value = "-2" Then
            row.Cells("DaysLeftUntuned").Style.BackColor = Color.PaleGoldenrod
            row.Cells("TuneTime").Style.BackColor = Color.PaleGoldenrod
            row.Cells("TuneTime").Value = "NOT TUNED"
        End If

        'For active orders:
        If row.Cells("OrderStatus").Value = "ACTIVE" Then
            'row.Cells("DaysKept").Value = "-"
            row.Cells("TuneTime").Value = "-"
            row.Cells("DaysLeftUntuned").Value = "-"
        End If

        'For orders whose ski has been tuned
        If row.Cells("DaysLeftUntuned").Value = "-2" Then
            row.Cells("DaysLeftUntuned").Value = "-"
        End If
    End Sub

    'On double click of FullName:
    'SPLIT FullName into First and Last, and pass the two parameters to a LoadCustomer sub in the Customers form
    Private Sub RentalHistoryDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles RentalHistoryDataGridView.CellDoubleClick

        If (e.ColumnIndex <> 1) Then Return
        MyBase.Location = New Point(300, 0)
        Dim frmCustomers As New Customers
        frmCustomers.Show()

        'If My.Application.OpenForms.Count = 3 Then

        Dim newChartX As Single = MyBase.Location.X + MyBase.Width
        Dim newChartY As Single = frmCustomers.Location.Y
        frmCustomers.Location = New Point(newChartX, newChartY)

        Dim CustomerID As Integer
        Dim Names() As String
        Dim FirstName As String
        Dim LastName As String

        Names = Split(Me.RentalHistoryDataGridView.Rows(e.RowIndex).Cells("Customer").Value, " ")
        FirstName = Names(0)
        LastName = Names(1)
        frmCustomers.LoadCustomerFromDataGrid(FirstName, LastName, Me)

    End Sub

    'To be called by the Customer read-only form when the user closes it
    Public Sub MoveToCenter()
        MyBase.CenterToScreen()
    End Sub


    'Takes a groupbox of String radio buttons
    'Returns the tag of whichever rad button is checked.

    'Validate MIN DATE: Date must be today or earlier
    Private Sub dpMinDate_Validating(sender As Object, e As CancelEventArgs) Handles dpMinDate.Validating
        If CType(dpMinDate.Text, DateTime) > Today Then
            MsgBox("Min. date must be today or earlier.")
            e.Cancel = True
        End If
    End Sub

    'Validate MAX DATE: Date must be today or earlier
    Private Sub dpMaxDate_Validating(sender As Object, e As CancelEventArgs) Handles dpMaxDate.Validating
        If CType(dpMaxDate.Text, DateTime) > Today Then
            MsgBox("Max date must be today or earlier.")
            e.Cancel = True
        End If
    End Sub

    'TEMPORARY ----------------------------------------------------------------------------------------------
    Private Sub LengthCalculator_Click(sender As Object, e As MouseEventArgs) Handles Me.Click
        'Globals.DrawPointOnScreen(Me, e)
    End Sub
    'END TEMPORARY ----------------------------------------------------------------------------------------------

End Class

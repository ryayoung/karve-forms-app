Imports System.ComponentModel

Public Class SkiBinding
    Private Sub SkiBindingBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SkiBindingBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SkiBindingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.KarveDataSet)

    End Sub

    Private Sub SkiBinding_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KarveDataSet.SkiModel' table. You can move, or remove it, as needed.
        Me.SkiModelTableAdapter.Fill(Me.KarveDataSet.SkiModel)
        'TODO: This line of code loads data into the 'KarveDataSet.Rental' table. You can move, or remove it, as needed.
        Me.RentalTableAdapter.Fill(Me.KarveDataSet.Rental)
        'TODO: This line of code loads data into the 'KarveDataSet.SkiBinding' table. You can move, or remove it, as needed.
        Me.SkiBindingTableAdapter.Fill(Me.KarveDataSet.SkiBinding)
        Me.Height = My.Computer.Screen.Bounds.Size.Height

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Startup.Show()
        Startup.ChangeButtonsToClosed()
        Me.Close()
        Startup.Invalidate()
    End Sub

    Private Sub dtpMountDate_Validating(sender As Object, e As CancelEventArgs) Handles dtpMountDate.Validating
        If CType(dtpMountDate.Text, DateTime) > Today Then
            MsgBox("Date must be today or earlier.")
            e.Cancel = True
        End If
    End Sub

    Private Sub SkiBindingIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles SkiBindingIDTextBox.TextChanged
        Dim dgvr As System.Windows.Forms.DataGridViewRow

        Dim sumDaysUsed As Single = 0
        For Each dgvr In Me.RentalDataGridView.Rows
            If Not IsDBNull(dgvr.Cells("DaysUsed").Value) Then
                sumDaysUsed += CType(dgvr.Cells("DaysUsed").Value, Int32)
            End If
        Next

        Me.lblDaysUsed.Text = sumDaysUsed

    End Sub
End Class
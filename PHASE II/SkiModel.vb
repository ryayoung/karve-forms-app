Public Class SkiModel
    Private Sub SkiModelBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SkiModelBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SkiModelBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.KarveDataSet)

    End Sub

    Private Sub SkiModel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KarveDataSet.SkiModel' table. You can move, or remove it, as needed.
        Me.SkiModelTableAdapter.Fill(Me.KarveDataSet.SkiModel)
        Me.Height = My.Computer.Screen.Bounds.Size.Height

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Startup.Show()
        Startup.ChangeButtonsToClosed()
        Me.Close()
        Startup.Invalidate()
    End Sub
End Class
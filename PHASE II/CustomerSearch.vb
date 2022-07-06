Public Class CustomerSearch
    Private Sub CustomerSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KarveDataSet.CustomerList' table. You can move, or remove it, as needed.
        Me.CustomerListTableAdapter.Fill(Me.KarveDataSet.CustomerList)

    End Sub
End Class

Public Class DinChart
    Private Sub linkChart_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkChart.LinkClicked
        Me.linkChart.LinkVisited = True
        System.Diagnostics.Process.Start("https://www.gearx.com/blog/wp-content/uploads/2017/01/DINDINDIN.png")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim countDinCalculator = (From g In My.Application.OpenForms Where CType(g, Form).Name = "DinCalculator").Count
        If countDinCalculator = 0 Then
            Startup.Show()
            Startup.ChangeButtonsToClosed()
            Me.Close()
            Startup.Invalidate()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub btnInstructions_Click(sender As Object, e As EventArgs) Handles btnInstructions.Click
        Me.lblInstructions.Visible = True
        Me.grpInstructions.Visible = True
        Me.picChart.Location = New Point(36, 220)
    End Sub

    Private Sub DinChart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.picChart.Location = New Point(36, 80)
        Me.Height = My.Computer.Screen.Bounds.Size.Height
        Dim countDinCalculator = (From g In My.Application.OpenForms Where CType(g, Form).Name = "DinCalculator").Count
        Dim xLocation As Single = 300
        If countDinCalculator > 0 Then
            xLocation += DinCalculator.Width + 40
        End If
        Me.Location = New Point(xLocation, 0)
    End Sub
End Class
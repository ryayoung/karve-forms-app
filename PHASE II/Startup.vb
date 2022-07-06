Imports System.Drawing.Drawing2D
Imports System.Drawing
Imports System.ComponentModel
Public Class Startup
    Private Sub Startup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            OpenForm(OrderSearch, btnSearch)
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnCalculateDin_Click(sender As Object, e As EventArgs) Handles btnCalculateDin.Click
        Try
            OpenForm(DinCalculator, btnCalculateDin)
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        Try
            OpenForm(Customers, btnCustomers)
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnSkiBinding_Click(sender As Object, e As EventArgs) Handles btnSkiBinding.Click
        Try
            OpenForm(SkiBinding, btnSkiBinding)
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnSkiModel_Click(sender As Object, e As EventArgs) Handles btnSkiModel.Click
        Try
            OpenForm(SkiModel, btnSkiModel)
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnDinChart_Click(sender As Object, e As EventArgs) Handles btnDinChart.Click
        Try
            OpenForm(DinChart, btnDinChart)
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Startup_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Globals.DrawGradientLine(e.Graphics, 280, 0, 280, Me.Height, Color.DarkGray, Color.LightGray, 2)
    End Sub

    Private Sub DrawDividerLine(frm As Form)
        Dim g As Graphics = Me.CreateGraphics
        Dim position As Single = frm.Location.X + frm.Width + 20
        Globals.DrawGradientLine(g, position, 0, position, Me.Height, Color.DarkGray, Color.LightGray, 2)
        g.Dispose()
    End Sub

    Private Sub OpenForm(frm As Form, button As Control)
        'Dim countChartsOpen = (From g In My.Application.OpenForms Where CType(g, Form).Name = "DinChart").Count
        Me.Invalidate()

        For Each f In My.Application.OpenForms
            If CType(f, Form).Name = frm.Name Then
                If Not (frm.Name = "Customers" And Globals.customerReadOnlyOpen = True) Then
                    MoveStartupToBack()
                    Return
                End If
            End If
        Next

        For i = (From g In My.Application.OpenForms).Count - 1 To 1 Step -1
            If CType(My.Application.OpenForms(i), Form).Name = "Customers" And Globals.customerReadOnlyOpen = True Then
                Globals.customerReadOnlyOpen = False
            End If
            My.Application.OpenForms(i).Close()
        Next

        frm.Show()

        'Turn off all other buttons
        ChangeButtonsToClosed()

        'Turn on active button
        button.BackgroundImage = My.Resources.imgBtnOpen

        'Since other methods call Me.Invalidate() to remove the second divider, we need to re-draw the main divider every time
        DrawDividerLine(frm)

    End Sub

    'Called externally when another form's close button is hit
    Public Sub ChangeButtonsToClosed()
        btnSearch.BackgroundImage = My.Resources.imgBtnClosed
        btnCalculateDin.BackgroundImage = My.Resources.imgBtnClosed
        btnCustomers.BackgroundImage = My.Resources.imgBtnClosed
        btnSkiBinding.BackgroundImage = My.Resources.imgBtnClosed
        btnSkiModel.BackgroundImage = My.Resources.imgBtnClosed
        btnDinChart.BackgroundImage = My.Resources.imgBtnClosed
    End Sub

    'IMPORTANT: This keeps the startup form in back
    Public Sub MoveStartupToBack()
        For i = 1 To (From f In My.Application.OpenForms).Count - 1
            If CType(My.Application.OpenForms(i), Form).Name <> "Startup" Then
                Dim frm As New Form
                frm = My.Application.OpenForms(i)
                frm.Hide()
                frm.Show()
            End If
        Next
    End Sub

    'These 4 click events ensure you can't accidentally click outside of a form and make it disappear behind the startup form
    Private Sub Startup_Click(sender As Object, e As MouseEventArgs) Handles Me.Click
        'Globals.DrawPointOnScreen(Me, e)
        MoveStartupToBack()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        MoveStartupToBack()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        MoveStartupToBack()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MoveStartupToBack()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
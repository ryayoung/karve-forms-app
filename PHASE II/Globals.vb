Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Data.SqlClient

'Contains variables, functions, subs that are useful in multiple forms
Public Class Globals
    Inherits System.Windows.Forms.Form

    'This variable is used to fix the following bug:
    'The startup form buttons will only work for forms that aren't already open (see OpenForm() sub)
    'The Customers form is a special because it CAN be open in read-only from the search form
    'In that case, the button to open the normal customers form won't work, but it SHOULD! 
    Public Shared customerReadOnlyOpen As Boolean = False

    Public Shared screenHeight As Single = My.Computer.Screen.Bounds.Size.Height
    Public Shared screenWidth As Single = My.Computer.Screen.Bounds.Size.Width

    'This is used to draw lines on the forms
    Public Shared Sub DrawGradientLine(ByVal g As Graphics, ByVal x1 As Single, ByVal y1 As Single,
                                 ByVal x2 As Single, ByVal y2 As Single, ByVal c1 As Color,
                                 ByVal c2 As Color, ByVal thickness As Single)

        Dim p1 As New Point(x1, y1)
        Dim p2 As New Point(x2, y2)

        ' Make brush
        Dim brush As New LinearGradientBrush(p1, p2, c1, c2)
        brush.WrapMode = WrapMode.TileFlipX

        ' Use brush to make pen
        Dim pen As New Pen(brush, thickness)
        pen.StartCap = LineCap.Round
        pen.EndCap = LineCap.Round

        g.DrawLine(pen, p1, p2)

    End Sub

    'Called from a form.Click event
    'Draws a dot on the screen, with coordinates.
    'Useful for development when you need coordinates of where to place a drawing
    Public Shared Sub DrawPointOnScreen(frm As Form, e As MouseEventArgs)
        Dim g As Graphics = frm.CreateGraphics
        Dim pen As Pen = New Pen(Brushes.DarkSalmon, 2)
        g.DrawEllipse(pen, e.X, e.Y, 3, 3)
        g.DrawString(e.X.ToString + ", " + e.Y.ToString, New Font("Calibri", 8), Brushes.DarkSalmon, e.X, e.Y)
    End Sub

    'Returns the DIN setting for a customer
    Public Shared Function CalculateDin(abilityLevel As Integer, age As Integer, height As Integer, weight As Integer, bsl As Integer) As Double
        'IMPORTANT NOTE:
        'In order to understand how this code works, you MUST view a DIN chart. (See DinChart form)
        'This function automates the reading of a DIN chart (Standard: ISO 11088:2018)
        'Created by Ryan Young

        Dim heightCode As Integer = 0
        Dim weightCode As Integer = 0
        Dim skierCode As Integer = 0
        Dim codeOffset As Integer = 0
        Dim bslColumn As Integer = 0

        'Convert height from inches to centimeters for calculations
        height *= 2.54

        'These values are hardcoded from a DIN chart online.
        'To find a chart with these values, google "ski binding din chart" and go to images
        Dim dinValues As Double(,) = {
                {0.75, 0.75, 0.00, 0.00, 0.00, 0.00},
                {1.0, 1.0, 0.75, 0.00, 0.00, 0.00},
                {1.25, 1.25, 1.0, 0.00, 0.00, 0.00},
                {1.75, 1.5, 1.5, 0.00, 0.00, 0.00},
                {2.0, 2.0, 1.75, 0.00, 0.00, 0.00},
                {2.5, 2.5, 2.25, 2.0, 1.75, 1.75},
                {0.00, 3.0, 2.5, 2.5, 2.25, 2.0},
                {0.00, 3.5, 3.0, 3.0, 2.5, 2.5},
                {0.00, 4.25, 4.0, 3.5, 3.25, 3.25},
                {0.00, 5.0, 4.75, 4.5, 4.0, 4.0},
                {0.00, 6.0, 5.5, 5.25, 5.0, 4.75},
                {0.00, 7.0, 6.75, 6.25, 6.0, 5.75},
                {0.00, 8.5, 8.0, 7.5, 7.0, 6.75},
                {0.00, 10.0, 9.5, 9.0, 8.5, 8.25},
                {0.00, 12.0, 11.25, 10.75, 10.25, 10.0}
        }

        'Calculate skier code based on weight
        If weight > 29 Then weightCode += 1
        If weight > 38 Then weightCode += 1
        If weight > 47 Then weightCode += 1
        If weight > 56 Then weightCode += 1
        If weight > 66 Then weightCode += 1
        If weight > 78 Then weightCode += 1
        If weight > 91 Then weightCode += 1
        If weight > 107 Then weightCode += 1
        If weight > 125 Then weightCode += 1
        If weight > 147 Then weightCode += 1
        If weight > 174 Then weightCode += 1
        If weight > 209 Then weightCode += 1

        'Calculate skier code based on height
        'Since height code is only used if height >= 148 cm, we start at height code 7
        heightCode = 7
        If height > 148 Then heightCode += 1
        If height > 157 Then heightCode += 1
        If height > 166 Then heightCode += 1
        If height > 178 Then heightCode += 1
        If height > 194 Then heightCode += 1

        'Given height code and weight code, decide which one to use
        If height >= 148 Then
            skierCode = Math.Min(heightCode, weightCode)
        Else
            skierCode = weightCode
        End If

        'If skier is type 2, increase skier code by 1. If skier is type 3, increase code by 2
        abilityLevel -= 1
        codeOffset += abilityLevel

        'If skier is 50 years or older, OR 9 years or younger, decrease code by 1
        If age >= 50 Or age <= 9 Then codeOffset -= 1

        'Based on skier type and age, offset the skier code
        skierCode += codeOffset

        'Calculate which column to use based on BSL
        If bsl > 251 Then bslColumn += 1
        If bsl > 270 Then bslColumn += 1
        If bsl > 290 Then bslColumn += 1
        If bsl > 310 Then bslColumn += 1
        If bsl > 330 Then bslColumn += 1

        'If no din value exists in the cell, switch to the column with the nearest valid value
        '(Try block is needed to catch an invalid index exception when accessing the dinValues array)
        Try
            If dinValues(skierCode, bslColumn) = 0.0 Then
                If skierCode = 0 Then
                    bslColumn = 1
                ElseIf skierCode > 5 Then
                    bslColumn += 1
                Else bslColumn = 2
                End If
            End If
        Catch ex As Exception
            Return 1
        End Try

        'Accesses array using row and column
        Return dinValues(skierCode, bslColumn)

    End Function

    'Returns the recommended ski length for a customer
    Public Shared Function CalculateLength(weight As Single, skierTypeCorrection As Single, skierStyleCorrection As Single, terrainCorrection As Single) As Single
        Try
            Dim length As Integer = 147

            If weight > 119 Then length += 3
            If weight > 129 Then length += 4
            If weight > 139 Then length += 5
            If weight > 149 Then length += 5
            If weight > 159 Then length += 5
            If weight > 169 Then length += 5
            If weight > 179 Then length += 2
            If weight > 189 Then length += 0
            If weight > 199 Then length += 0
            If weight > 209 Then length += 1
            If weight > 219 Then length += 3

            length = length + skierTypeCorrection + skierStyleCorrection + terrainCorrection
            Return length

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function
    Public Shared Function EvaluateRadioGroupInteger(ByVal grp As GroupBox) As Integer
        Dim rad As RadioButton
        For Each rad In grp.Controls
            If rad.Checked Then
                Return rad.Tag
            End If
        Next rad
        Return 0.0
    End Function
    Public Shared Function EvaluateRadioGroupString(ByVal grp As GroupBox) As String
        Dim rad As RadioButton
        For Each rad In grp.Controls
            If (rad.Checked) Then Return rad.Tag
        Next rad
        Return 0.0
    End Function

    'Divides two numbers.
    'If dividing by 0, return 0
    Public Shared Function Divide(ByVal numerator As Single, ByVal denominator As Single) As Decimal
        If denominator > 0 Then
            Return numerator / denominator
        Else
            Return 0
        End If
    End Function

    'Returns the next ID number for a table
    Public Shared Function AutoNumber(id As String, table As String)
        Dim myConn As SqlConnection
        Dim myCmd As SqlCommand
        'Create connection and command
        myConn = New SqlConnection("Data Source=.;Initial Catalog=Karve;Integrated Security=True;")
        myCmd = myConn.CreateCommand
        'This query finds the highest ID number from a table
        myCmd.CommandText = "SELECT MAX(" + id + ") FROM " + table
        myConn.Open()
        'Return one number higher than the result of the query
        Return myCmd.ExecuteScalar() + 1
    End Function
End Class

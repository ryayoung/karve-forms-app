Imports System.ComponentModel

Public Class Customers

    Private Sub CustomerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.KarveDataSet)
        txtCustomerID.ReadOnly = False
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Startup.Show()
        Startup.ChangeButtonsToClosed()
        Me.Close()
        Startup.Invalidate()
    End Sub

    Private Sub Customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Height = My.Computer.Screen.Bounds.Size.Height

        'TODO: This line of code loads data into the 'KarveDataSet.State' table. You can move, or remove it, as needed.
        Me.StateTableAdapter.Fill(Me.KarveDataSet.State)
        'TODO: This line of code loads data into the 'KarveDataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.KarveDataSet.Customer)
        txtCustomerID.ReadOnly = False
        FillDinValue()
    End Sub

    Dim abilityLevel As Single = 1
    Dim age As Single = 25
    Dim userHeight As Single = 1
    Dim weight As Single = 1
    Dim bsl As Single = 1
    Private Sub FillDinValue()
        lblDinValue.Text = Globals.CalculateDin(abilityLevel, age, userHeight, weight, bsl)
    End Sub

    'When user clicks customer fullname in the Order Search DGV, fill this form but disable EVERYTHING
    Public Sub LoadCustomerFromDataGrid(ByVal FirstName As String, ByVal LastName As String, ByVal callForm As Form)
        'FillBy FirstName, LastName
        Me.CustomerTableAdapter.FillBy(Me.KarveDataSet.Customer, FirstName, LastName)

        Globals.customerReadOnlyOpen = True

        'Move the form to the right side of the search form
        Dim newPosition As Single = callForm.Location.X + callForm.Width + 40
        Me.Location = New Point(newPosition, 0)

        Me.lblCustomerTitle.Visible = False

        'Show close button, hide back button since this is a pop-up form
        Me.btnClose.Visible = True
        Me.btnBack.Visible = False

        'The following code DISABLES EVERY CONTROL on the form
        Me.CustomerBindingNavigator.Enabled = False
        Me.FillByLastNameToolStrip.Enabled = False
        Me.lblNoticeReadOnly.Visible = True

        Me.txtCustomerID.ReadOnly = True
        Me.txtFirstName.ReadOnly = True
        Me.txtLastName.ReadOnly = True
        Me.txtEmail.ReadOnly = True
        Me.txtStreet.ReadOnly = True
        Me.txtCity.ReadOnly = True
        Me.cboState.Enabled = False
        Me.txtZipcode.ReadOnly = True

        Me.dpSignupDate.Enabled = False
        Me.dpDateOfBirth.Enabled = False

        Me.cboNumRentalsPaid.Enabled = False
        Me.txtHeight.ReadOnly = True
        Me.txtWeight.ReadOnly = True
        Me.cboAbilityLevel.Enabled = False
        Me.cboBootSize.Enabled = False
        Me.txtBootSoleLength.ReadOnly = True
    End Sub

    'When SEARCH button is clicked
    Private Sub tsbtnSearch_Click(sender As Object, e As EventArgs) Handles tsbtnSearch.Click
        Try
            'Surround the parameter in % signs so the user can type any substring of the last name and still get a result
            Me.CustomerTableAdapter.FillByLastName(Me.KarveDataSet.Customer, "%" + txtLastNameToolStrip.Text + "%")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    'When the CLEAR button is clicked:
    Private Sub tsbtnClear_Click(sender As Object, e As EventArgs) Handles tsbtnClear.Click
        'Call the normal Fill method for the Customer table
        Me.CustomerTableAdapter.Fill(Me.KarveDataSet.Customer)
        'Empty the search box
        Me.txtLastNameToolStrip.Text = ""
        'Allow the CustomerID value to be edited
        txtCustomerID.ReadOnly = False
    End Sub

    'Validate Date of Birth: Must be earlier than today
    Private Sub dpDateOfBirth_Validating(sender As Object, e As CancelEventArgs) Handles dpDateOfBirth.Validating
        If CType(dpDateOfBirth.Text, DateTime) > Today Then
            MsgBox("DOB must be today or earlier.")
            e.Cancel = True
        End If
    End Sub

    'Validate Signup Date: Must be earlier than today
    Private Sub dpSignupDate_Validating(sender As Object, e As CancelEventArgs) Handles dpSignupDate.Validating
        If CType(dpSignupDate.Text, DateTime) > Today Then
            MsgBox("Signup Date must be today or earlier.")
            e.Cancel = True
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_MouseUp(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.MouseUp
        txtCustomerID.Text = Globals.AutoNumber("CustomerID", "Customer")
        txtCustomerID.ReadOnly = True
        lblDinValue.Text = ""
    End Sub

    'IMPORTANT: Close button can only be accessed when form is in read-only mode
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        Globals.customerReadOnlyOpen = False
    End Sub
    Private Sub cboAbilityLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAbilityLevel.SelectedIndexChanged
        If cboAbilityLevel.SelectedItem <> "" Then
            abilityLevel = Convert.ToInt32(cboAbilityLevel.SelectedItem)
        End If
        FillDinValue()
    End Sub
    Private Sub txtHeight_TextChanged(sender As Object, e As EventArgs) Handles txtHeight.TextChanged
        If txtHeight.Text <> "" Then
            userHeight = Convert.ToInt32(txtHeight.Text)
        End If
        FillDinValue()
    End Sub
    Private Sub txtWeight_TextChanged(sender As Object, e As EventArgs) Handles txtWeight.TextChanged
        If txtWeight.Text <> "" Then
            weight = Convert.ToInt32(txtWeight.Text)
        End If
        FillDinValue()
    End Sub
    Private Sub txtBootSoleLength_TextChanged(sender As Object, e As EventArgs) Handles txtBootSoleLength.TextChanged
        If txtBootSoleLength.Text <> "" Then
            bsl = Convert.ToInt32(txtBootSoleLength.Text)
        End If
        FillDinValue()
    End Sub

    Private Sub lblBootSoleLength_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cboBootSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBootSize.SelectedIndexChanged

    End Sub


    Private Sub cboState_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboState.SelectedIndexChanged

    End Sub

    Private Sub txtZipcode_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtZipcode.MaskInputRejected

    End Sub

    Private Sub lblStreet_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtStreet_TextChanged(sender As Object, e As EventArgs) Handles txtStreet.TextChanged

    End Sub

    Private Sub lblCity_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtCity_TextChanged(sender As Object, e As EventArgs) Handles txtCity.TextChanged

    End Sub

    Private Sub lblState_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblZipcode_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblSignupDate_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dpSignupDate_ValueChanged(sender As Object, e As EventArgs) Handles dpSignupDate.ValueChanged

    End Sub

    Private Sub lblDateOfBirth_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dpDateOfBirth_ValueChanged(sender As Object, e As EventArgs) Handles dpDateOfBirth.ValueChanged

    End Sub

    Private Sub lblNumRentalsPaid_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblHeight_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub lblWeight_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub lblAbilityLevel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblBootSize_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cboNumRentalsPaid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNumRentalsPaid.SelectedIndexChanged

    End Sub


    Private Sub BindingNavigatorAddNewItem_MouseUp(sender As Object, e As MouseEventArgs) Handles BindingNavigatorAddNewItem.MouseUp

    End Sub
End Class

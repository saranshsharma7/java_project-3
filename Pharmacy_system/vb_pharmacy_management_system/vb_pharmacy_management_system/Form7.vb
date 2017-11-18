Public Class Form7
    Private Sub PatientBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PatientBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PatientBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PharmacyDataSet)

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PharmacyDataSet.Patient' table. You can move, or remove it, as needed.
        Me.PatientTableAdapter.Fill(Me.PharmacyDataSet.Patient)

    End Sub

    Private Sub FirstnameTextBox_TextChanged(sender As Object, e As EventArgs) Handles FirstnameTextBox.TextChanged

    End Sub

    Private Sub SurnameTextBox_TextChanged(sender As Object, e As EventArgs) Handles SurnameTextBox.TextChanged

    End Sub

    Private Sub Date_of_birthTextBox_TextChanged(sender As Object, e As EventArgs) Handles Date_of_birthTextBox.TextChanged

    End Sub

    Private Sub Billing_NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles Billing_NameTextBox.TextChanged

    End Sub

    Private Sub AddressTextBox_TextChanged(sender As Object, e As EventArgs) Handles AddressTextBox.TextChanged

    End Sub

    Private Sub Post_CodeTextBox_TextChanged(sender As Object, e As EventArgs) Handles Post_CodeTextBox.TextChanged

    End Sub

    Private Sub CityTextBox_TextChanged(sender As Object, e As EventArgs) Handles CityTextBox.TextChanged

    End Sub

    Private Sub NI_NumberTextBox_TextChanged(sender As Object, e As EventArgs) Handles NI_NumberTextBox.TextChanged

    End Sub

    Private Sub CountryTextBox_TextChanged(sender As Object, e As EventArgs) Handles CountryTextBox.TextChanged

    End Sub

    Private Sub Home_PhoneTextBox_TextChanged(sender As Object, e As EventArgs) Handles Home_PhoneTextBox.TextChanged

    End Sub

    Private Sub Mobile_PhoneTextBox_TextChanged(sender As Object, e As EventArgs) Handles Mobile_PhoneTextBox.TextChanged

    End Sub

    Private Sub Fax_PhoneTextBox_TextChanged(sender As Object, e As EventArgs) Handles Fax_PhoneTextBox.TextChanged

    End Sub

    Private Sub MenoTextBox_TextChanged(sender As Object, e As EventArgs) Handles MenoTextBox.TextChanged

    End Sub

    Private Sub Patient_IDTextBox_TextChanged(sender As Object, e As EventArgs) Handles Patient_IDTextBox.TextChanged

    End Sub

    Private Sub Patient_NHS_NumberLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Patient_NHS_NumberTextBox_TextChanged(sender As Object, e As EventArgs) Handles Patient_NHS_NumberTextBox.TextChanged

    End Sub

    Private Sub EMIS_NumberTextBox_TextChanged(sender As Object, e As EventArgs) Handles EMIS_NumberTextBox.TextChanged

    End Sub

    Private Sub GP_Appointment_RefLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GP_Appointment_RefTextBox_TextChanged(sender As Object, e As EventArgs) Handles GP_Appointment_RefTextBox.TextChanged

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Cexit.Exitsystem()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("confirm if you want to exit", "pharmacy management system", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


        If iExit = DialogResult.Yes Then
            Me.Close()

        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Me.PatientBindingSource.MovePrevious()
    End Sub
End Class
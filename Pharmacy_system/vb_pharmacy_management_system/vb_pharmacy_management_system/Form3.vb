Public Class Form3
    Private Sub GP_AppointmentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles GP_AppointmentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.GP_AppointmentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PharmacyDataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PharmacyDataSet.GP_Appointment' table. You can move, or remove it, as needed.
        Me.GP_AppointmentTableAdapter.Fill(Me.PharmacyDataSet.GP_Appointment)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.GP_AppointmentBindingSource.AddNew()

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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Me.GP_AppointmentBindingSource.RemoveCurrent()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.GP_AppointmentBindingSource.MoveNext()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Me.GP_AppointmentBindingSource.MovePrevious()
    End Sub
End Class
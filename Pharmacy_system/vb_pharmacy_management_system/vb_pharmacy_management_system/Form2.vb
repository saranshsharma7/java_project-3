Public Class Form2
    Private Sub DoctorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DoctorBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DoctorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PharmacyDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PharmacyDataSet.Doctor' table. You can move, or remove it, as needed.
        Me.DoctorTableAdapter.Fill(Me.PharmacyDataSet.Doctor)

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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.DoctorBindingSource.AddNew()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Me.DoctorBindingSource.RemoveCurrent()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.DoctorBindingSource.MoveNext()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Me.DoctorBindingSource.MovePrevious()
    End Sub
End Class
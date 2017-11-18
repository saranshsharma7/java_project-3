Public Class Form4
    Private Sub PharmacyBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PharmacyBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PharmacyBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PharmacyDataSet)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PharmacyDataSet.Patient' table. You can move, or remove it, as needed.
        Me.PatientTableAdapter.Fill(Me.PharmacyDataSet.Patient)
        'TODO: This line of code loads data into the 'PharmacyDataSet.Pharmacy' table. You can move, or remove it, as needed.
        Me.PharmacyTableAdapter.Fill(Me.PharmacyDataSet.Pharmacy)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.PharmacyBindingSource.AddNew()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Me.PharmacyBindingSource.RemoveCurrent()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.PharmacyBindingSource.MoveNext()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Me.PharmacyBindingSource.MovePrevious()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("confirm if you want to exit", "pharmacy management system", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


        If iExit = DialogResult.Yes Then
            Me.Close()

        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Cexit.Exitsystem()
    End Sub
End Class
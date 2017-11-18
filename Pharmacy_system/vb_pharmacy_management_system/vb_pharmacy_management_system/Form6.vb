Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PharmacyDataSet.pharmacy_office' table. You can move, or remove it, as needed.
        Me.Pharmacy_officeTableAdapter.Fill(Me.PharmacyDataSet.pharmacy_office)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.Pharmacy_officeBindingSource.AddNew()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Me.Pharmacy_officeBindingSource.RemoveCurrent()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.Pharmacy_officeBindingSource.MoveNext()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Me.Pharmacy_officeBindingSource.MovePrevious()
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
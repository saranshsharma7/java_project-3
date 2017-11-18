Public Class Form5
    Private Sub PaymentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PaymentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PaymentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PharmacyDataSet)

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PharmacyDataSet.Payment' table. You can move, or remove it, as needed.
        Me.PaymentTableAdapter.Fill(Me.PharmacyDataSet.Payment)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.PaymentBindingSource.AddNew()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Me.PaymentBindingSource.RemoveCurrent()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.PaymentBindingSource.MoveNext()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Me.PaymentBindingSource.MovePrevious()
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

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged, CheckBox10.CheckedChanged

    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged, CheckBox13.CheckedChanged

    End Sub

    Private Sub PaymentDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PaymentDataGridView.CellContentClick

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox6.TextChanged, TextBox5.TextChanged, TextBox4.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged, TextBox9.TextChanged

    End Sub
End Class
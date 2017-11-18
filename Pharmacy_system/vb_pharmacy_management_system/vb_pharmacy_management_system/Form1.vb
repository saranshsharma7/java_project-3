Public Class Form1
    Private txtUsername As Object
    Public Property ButtonDoctor As Object

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click


        Dim Doctorsform As Form2 = New Form2
        Doctorsform.Show()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Doctorsform As Form2 = New Form2
        Doctorsform.Show()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Cexit.Exitsystem()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim GPform As Form3 = New Form3

        GPform.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim patientform As Form7 = New Form7

        patientform.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim Pharmacyform As Form4 = New Form4


        Pharmacyform.Show()

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        Dim Paymentform As Form5 = New Form5
        Paymentform.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim Pharmacy_officeform As Form6 = New Form6

        Pharmacy_officeform.Show()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LoginDataSet.login' table. You can move, or remove it, as needed.
        Me.LoginTableAdapter.Fill(Me.LoginDataSet.login)
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button10.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False




    End Sub

    Private Sub LoginBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles LoginBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.LoginBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LoginDataSet)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim log = Me.LoginTableAdapter.UserDetails(Me.UsernameTextBox.Text, Me.PasswordTextBox.Text)
        If log Then
            UsernameTextBox = Nothing
            PasswordTextBox = Nothing
            MessageBox.Show("Invalid details entered,try again", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Information)

            UsernameTextBox.Focus()
            PasswordTextBox.Focus()
        Else

            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True
            Button10.Enabled = True
            Button4.Enabled = True
            Button5.Enabled = True

            UsernameTextBox.Clear()
            PasswordTextBox.Clear()




        End If

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        UsernameTextBox.Clear()
        PasswordTextBox.Clear()



        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button10.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False


    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        UsernameTextBox.Clear()
        PasswordTextBox.Clear()

        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button10.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False

    End Sub

    Private Sub UsernameLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged

    End Sub
End Class

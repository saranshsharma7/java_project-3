Public Class Cexit

    Public Shared Function Exitsystem()
        Dim iExit As DialogResult
        iExit = MessageBox.Show("confirm if you want to exit", "pharmacy management system", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


        If iExit = DialogResult.Yes Then
            Application.Exit()




        End If
    End Function
End Class

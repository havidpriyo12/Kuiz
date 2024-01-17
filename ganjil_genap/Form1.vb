Public Class MainForm
    Private Sub btnCek_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCek.Click
        ' Mendapatkan input dari pengguna
        Dim inputNumber As Integer

        If Integer.TryParse(txtInputNumber.Text, inputNumber) Then
            ' Menentukan apakah bilangan ganjil atau genap
            If inputNumber Mod 2 = 0 Then
                lblHasil.Text = "bilangan genap."
            Else
                lblHasil.Text = "bilangan ganjil."
            End If
        Else
            lblHasil.Text = "Masukkan angka yang valid."
        End If
    End Sub
End Class
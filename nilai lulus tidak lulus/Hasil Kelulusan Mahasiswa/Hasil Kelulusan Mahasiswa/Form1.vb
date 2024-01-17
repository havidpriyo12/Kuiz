Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Deklarasi variabel
        Dim NIM As String = TxtNIM.Text
        Dim Nama As String = TxtNama.Text
        Dim Kelas As String = TxtKelas.Text
        Dim NilaiUTS As Double
        Dim NilaiUAS As Double
        Dim NilaiTugas As Double
        Dim NilaiAkhir As Double

        ' Validasi input numerik
        If Not Double.TryParse(TxtUTS.Text, NilaiUTS) OrElse
           Not Double.TryParse(TxtUAS.Text, NilaiUAS) OrElse
           Not Double.TryParse(TxtTugas.Text, NilaiTugas) Then
            MessageBox.Show("Input UTS, UAS, dan Tugas harus angka.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Perhitungan nilai akhir
        NilaiUTS = (NilaiUTS * 30) / 100
        NilaiUAS = (NilaiUAS * 50) / 100
        NilaiTugas = (NilaiTugas * 20) / 100
        NilaiAkhir = NilaiUTS + NilaiUAS + NilaiTugas

        ' Menentukan hasil kelulusan
        Dim Hasil As String = If(NilaiAkhir >= 60, "Lulus", "Tidak Lulus")

        ' Menampilkan hasil di ListView
        Dim item As New ListViewItem({NIM, Nama, Kelas, NilaiUTS.ToString(), NilaiUAS.ToString(), NilaiTugas.ToString(), NilaiAkhir.ToString(), Hasil})
        ListView1.Items.Add(item)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Menyiapkan kolom untuk ListView
        ListView1.View = View.Details
        ListView1.Columns.Add("NIM", 100)
        ListView1.Columns.Add("Nama", 150)
        ListView1.Columns.Add("Kelas", 100)
        ListView1.Columns.Add("Nilai UTS", 80)
        ListView1.Columns.Add("Nilai UAS", 80)
        ListView1.Columns.Add("Nilai Tugas", 80)
        ListView1.Columns.Add("Nilai Akhir", 80)
        ListView1.Columns.Add("Hasil", 80)
    End Sub

    Private Sub TxtUAS_TextChanged(sender As Object, e As EventArgs) Handles TxtUAS.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub TxtTugas_TextChanged(sender As Object, e As EventArgs) Handles TxtTugas.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TxtUTS_TextChanged(sender As Object, e As EventArgs) Handles TxtUTS.TextChanged

    End Sub

    Private Sub TxtKelas_TextChanged(sender As Object, e As EventArgs) Handles TxtKelas.TextChanged

    End Sub

    Private Sub TxtNama_TextChanged(sender As Object, e As EventArgs) Handles TxtNama.TextChanged

    End Sub

    Private Sub TxtNIM_TextChanged(sender As Object, e As EventArgs) Handles TxtNIM.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class

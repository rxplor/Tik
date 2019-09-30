Public Class HiSkor
    'alias warna terlebih dahulu
    Dim z As Color
    Dim x As Color

    Private Sub Tutup_Click(sender As Object, e As EventArgs) Handles tutup.Click
        Close()
    End Sub

    Private Sub AturUlang_Click(sender As Object, e As EventArgs) Handles aturUlang.Click
        If MsgBox("Tindakan ini akan berdampak pada data berikut:" & Environment.NewLine & "-   Semua data berkaitan dengan skor tinggi akan dihapus." & Environment.NewLine & "-   Mode Kilat [Mode C] akan terkunci lagi." & Environment.NewLine & "   *mode C bisa dibuka lagi jika kondisi buka terpenuhi." & Environment.NewLine & Environment.NewLine & "Klik [OK] untuk menghapus data skor tinggi dan mengunci mode C" & Environment.NewLine & "Klik [Batal] untuk tetap menyimpan data skor tinggi", MsgBoxStyle.OkCancel, "Konfirmasi Reset") = MsgBoxResult.Ok Then
            My.Settings.Reset()
            My.Settings.lastReset = Date.Now.ToLongDateString & ", " & Date.Now.ToShortTimeString
            My.Settings.Save()
            k1.Checked = False
            k2.Checked = False
            k3.Checked = False
            info.Text = "Pilih salah satu mode untuk dilihat skor tertinggi"
            If My.Settings.lastReset = "-" Then
                info.Text = info.Text & Environment.NewLine & "Terakhir direset pada: " & My.Settings.lastReset
            End If
            Close()
        End If
    End Sub

    Private Sub K1_CheckedChanged(sender As Object, e As EventArgs) Handles k1.CheckedChanged
        info.Text = "Memuat data . . . ; mohon tunggu sejenak"
        info.Text = "[ Mode Klasik ] - skor tinggi:" & Environment.NewLine & Environment.NewLine
        info.Text = info.Text & "Pemain: " & My.Settings.topKlasikNama & Environment.NewLine
        info.Text = info.Text & "Lv: " & My.Settings.topKlasikLv & " | Skor: " & My.Settings.topKlasikSkor & Environment.NewLine
        info.Text = info.Text & "Masa direkam: " & My.Settings.topKlasikDateTime & Environment.NewLine
        info.Text = info.Text & "Karakter per menit: " & My.Settings.klasikKPM & Environment.NewLine
        info.Text = info.Text & "Jumlah karakter benar diketik: " & My.Settings.karakterKlasik & Environment.NewLine
        info.Text = info.Text & "Durasi ketik: " & My.Settings.durasiKlasik & " det"
    End Sub

    Private Sub K2_CheckedChanged(sender As Object, e As EventArgs) Handles k2.CheckedChanged
        info.Text = "Memuat data . . . ; mohon tunggu sejenak"
        info.Text = "[ Mode Sintas ] - skor tinggi:" & Environment.NewLine & Environment.NewLine
        info.Text = info.Text & "Pemain: " & My.Settings.topSintasNama & Environment.NewLine
        info.Text = info.Text & "Lv: " & My.Settings.topSintasLv & " | Skor: " & My.Settings.topSintasSkor & Environment.NewLine
        info.Text = info.Text & "Masa direkam: " & My.Settings.topSintasDateTime & Environment.NewLine
        info.Text = info.Text & "Karakter per menit: " & My.Settings.sintasKPM & Environment.NewLine
        info.Text = info.Text & "Jumlah karakter benar diketik: " & My.Settings.karakterSintas & Environment.NewLine
        info.Text = info.Text & "Durasi ketik: " & My.Settings.durasiSintas & " det"
    End Sub

    Private Sub K3_CheckedChanged(sender As Object, e As EventArgs) Handles k3.CheckedChanged
        info.Text = "Memuat data . . . ; mohon tunggu sejenak"
        info.Text = "[ Mode Kilat ] - skor tinggi:" & Environment.NewLine & Environment.NewLine
        info.Text = info.Text & "Pemain: " & My.Settings.topChalNama & Environment.NewLine
        info.Text = info.Text & "Lv: " & My.Settings.topChalLv & " | Skor: " & My.Settings.topChalSkor & Environment.NewLine
        info.Text = info.Text & "Masa direkam: " & My.Settings.topChalDateTime & Environment.NewLine
        info.Text = info.Text & "Karakter per menit: " & My.Settings.chalKPM & Environment.NewLine
        info.Text = info.Text & "Jumlah karakter benar diketik: " & My.Settings.karakterChal & Environment.NewLine
        info.Text = info.Text & "Durasi ketik: " & My.Settings.durasiChal & " det"
    End Sub

    Private Sub HiSkor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.challenge = True Then
            k3.Visible = True
        Else
            k3.Visible = False
        End If

        info.Text = "Pilih salah satu mode untuk dilihat skor tertinggi"

        'Di bawah untuk definisi warna
        z = Color.Black
        x = Color.White

        If TimeOfDay.Hour >= 17 Or TimeOfDay.Hour <= 7 Then
            BackColor = z
            kotakGrup.BackColor = z
            info.BackColor = z
            aturUlang.BackColor = z
            tutup.BackColor = z
            ForeColor = x
            kotakGrup.ForeColor = x
            info.ForeColor = x
            aturUlang.ForeColor = x
            tutup.ForeColor = x
        End If
    End Sub

    Private Sub HiSkor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        k1.Checked = False
        k2.Checked = False
        k3.Checked = False
    End Sub

    Private Sub HiSkor_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Restart()
    End Sub
End Class
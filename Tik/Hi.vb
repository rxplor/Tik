Public Class Hi
    'skor
    Public skor As Decimal
    'level
    Public lv As Single
    'tanggal dan waktu selesai
    Public tanggal As String
    'karakter per menit
    Public kpm As Decimal
    'jumlah karakter benar diketik
    Public karakter As Integer
    'durasi ketik dalam detik
    Public durasi As Decimal
    'jenis mode dimaikan
    Public jenis As Decimal
    'alias warna terlebih dahulu
    Dim z As Color
    Dim y As Color
    Dim x As Color

    Private Sub Hi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If jenis = 1 Then
            kotak.Text = "Mode Klasik"
        ElseIf jenis = 2 Then
            kotak.Text = "Mode Sintas"
        ElseIf jenis = 3 Then
            kotak.Text = "Mode Tantangan"
        End If

        'Di bawah untuk definisi warna
        z = Color.Black
        y = Color.Red
        x = Color.White

        If TimeOfDay.Hour >= 17 Or TimeOfDay.Hour <= 7 Then
            BackColor = z
            kotak.BackColor = z
            ForeColor = x
            kotak.ForeColor = x
            nama.BackColor = z
            nama.ForeColor = x
        End If
    End Sub

    Private Sub Hi_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If nama.TextLength = 0 Then
            MsgBox("Masukkan nama pemain untuk melanjutkan", MsgBoxStyle.Information, "Pemberitahuan")
            e.Cancel = True
        End If
    End Sub

    Private Sub Nama_TextChanged(sender As Object, e As EventArgs) Handles nama.TextChanged
        panjang.Text = nama.TextLength & "/" & nama.MaxLength

        If jenis = 1 Then
            My.Settings.topKlasikNama = nama.Text
            My.Settings.topKlasikSkor = skor
            My.Settings.topKlasikLv = lv
            My.Settings.topKlasikDateTime = tanggal
            My.Settings.klasikKPM = kpm
            My.Settings.karakterKlasik = karakter
            My.Settings.durasiKlasik = durasi
        ElseIf jenis = 2 Then
            My.Settings.topSintasNama = nama.Text
            My.Settings.topSintasSkor = skor
            My.Settings.topSintasLv = lv
            My.Settings.topSintasDateTime = tanggal
            My.Settings.sintasKPM = kpm
            My.Settings.karakterSintas = karakter
            My.Settings.durasiSintas = durasi
        ElseIf jenis = 3 Then
            My.Settings.topChalNama = nama.Text
            My.Settings.topChalSkor = skor
            My.Settings.topChalLv = lv
            My.Settings.topChalDateTime = tanggal
            My.Settings.chalKPM = kpm
            My.Settings.karakterChal = karakter
            My.Settings.durasiChal = durasi
        End If
        My.Settings.Save()
    End Sub
End Class
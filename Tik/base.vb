Public Class base

    'Di bawah untuk set jam
    Dim jam As Integer
    Dim menit As Integer
    Dim hari As String
    'alias warna terlebih dahulu
    Dim ht As Color
    Dim th As Color
    'Memenuhi syarat untuk meemilih Mode C?
    Public tantangan As Boolean

    Private Sub base_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.challenge = True Then
            tantangan = True
        Else
            tantangan = False
        End If

        Timer1.Start()
        Timer2.Start()
        'definisi warna
        ht = Color.Black
        th = Color.White
        If TimeOfDay.Hour >= 17 Or TimeOfDay.Hour <= 7 Then
            rekor.BackColor = ht
            rekor.ForeColor = th
            help.FlatAppearance.BorderColor = Color.MediumTurquoise
            info.FlatAppearance.BorderColor = Color.MediumTurquoise
            fn.FlatAppearance.BorderColor = Color.MediumTurquoise
            BackColor = ht
            play.BackColor = ht
            play.ForeColor = th
            opsi1.BackColor = ht
            opsi2.BackColor = ht
            opsi3.BackColor = ht
            opsi1.ForeColor = th
            opsi2.ForeColor = th
            opsi3.ForeColor = th
            teks.BackColor = ht
            info.BackColor = ht
            time.BackColor = ht
            help.BackColor = ht
            fn.BackColor = ht
            teks.ForeColor = th
            info.ForeColor = th
            time.ForeColor = th
            help.ForeColor = th
            fn.ForeColor = th

        End If
    End Sub

    Private Sub play_MouseEnter(sender As Object, e As EventArgs) Handles play.MouseEnter
        If opsi1.Checked = True Then
            teks.Text = "Pilihan mode A (klasik) dipilih. Klik untuk memulai permainan" & vbCrLf & vbCrLf
            teks.Text = teks.Text & "*waktu berkurang HANYA jika kamu salah ketik"
        ElseIf opsi2.Checked = True Then
            teks.Text = "Pilihan mode B (sintas) dipilih. Klik untuk memulai permainan"
        ElseIf opsi3.Checked = True Then
            If tantangan = True Then
                teks.Text = "Pilihan mode C (kilat) dipilih. Klik untuk memulai permainan" & vbCrLf & vbCrLf
                teks.Text = teks.Text & "*waktu berkurang lebih cepat jika kamu salah ketik"
            Else
                teks.Text = "Pilihan mode C dipilih. "
            End If
        Else
            teks.Text = "Pilih salah satu mode permainan antara 'A', 'B' atau 'C' sebelum memulai"
        End If
    End Sub

    Private Sub help_MouseEnter(sender As Object, e As EventArgs) Handles help.MouseEnter
        teks.Text = "[ Dasar ]" & Environment.NewLine
        teks.Text = teks.Text & "Ketik ulang teks yang ditampilkan" & Environment.NewLine
        teks.Text = teks.Text & "dalam batasan waktu tertentu" & Environment.NewLine & Environment.NewLine
        teks.Text = teks.Text & "[ Perhitungan skor ]" & Environment.NewLine
        teks.Text = teks.Text & "Skor dihitung dari jumlah karakter" & Environment.NewLine
        teks.Text = teks.Text & "dibagi durasi ketik dalam detik." & Environment.NewLine & Environment.NewLine
        teks.Text = teks.Text & "[ Jeda ]" & Environment.NewLine
        teks.Text = teks.Text & "Gim dapat dijeda dengan klik tanda" & Environment.NewLine
        teks.Text = teks.Text & "silang; bisa juga kombinasi tombol" & Environment.NewLine
        teks.Text = teks.Text & "[Alt] + Tombol fungsi [F4]" & Environment.NewLine & Environment.NewLine
        teks.Text = teks.Text & "[ Perhatian ]" & Environment.NewLine
        teks.Text = teks.Text & "Pastikan tidak ada data di papan" & Environment.NewLine
        teks.Text = teks.Text & "klip sebelum mulai bermain, sebab" & Environment.NewLine
        teks.Text = teks.Text & "data itu akan dihapus saat game" & Environment.NewLine
        teks.Text = teks.Text & "sedang dimainkan. Tindakan ini" & Environment.NewLine
        teks.Text = teks.Text & "dilakukan untuk mencegah upaya" & Environment.NewLine
        teks.Text = teks.Text & "melakukan kecurangan." & Environment.NewLine & Environment.NewLine
        teks.Text = teks.Text & "[ Info ]" & Environment.NewLine
        teks.Text = teks.Text & "Waktu tidak langsung dimulai jika" & Environment.NewLine
        teks.Text = teks.Text & "panjang teks melebihi 24 karakter" & Environment.NewLine
    End Sub

    Private Sub info_MouseEnter(sender As Object, e As EventArgs) Handles info.MouseEnter
        teks.Text = "Tik versi " & My.Application.Info.Version.ToString & Environment.NewLine & Environment.NewLine
        teks.Text = teks.Text & "Direktori program:" & Environment.NewLine
        teks.Text = teks.Text & My.Application.Info.DirectoryPath.ToString & Environment.NewLine & Environment.NewLine
        teks.Text = teks.Text & "Dibuat oleh Al Cholis" & Environment.NewLine & Environment.NewLine
        teks.Text = teks.Text & "Permainan ini dibuat tanpa jaminan" & Environment.NewLine
        teks.Text = teks.Text & "apapun. Pembuat aplikasi tidak" & Environment.NewLine
        teks.Text = teks.Text & "bertanggungjawab atas hilangnya" & Environment.NewLine
        teks.Text = teks.Text & "data pada papan klip akibat anda" & Environment.NewLine
        teks.Text = teks.Text & "bermain permainan ini." & Environment.NewLine & Environment.NewLine
        teks.Text = teks.Text & "Anda bebas melakukan tindakan" & Environment.NewLine
        teks.Text = teks.Text & "apapun berikut, mengenai game ini:" & Environment.NewLine
        teks.Text = teks.Text & "(dengan menyertakan sumbernya)" & Environment.NewLine
        teks.Text = teks.Text & "ubah, edit, salin, duplikasi" & Environment.NewLine
        teks.Text = teks.Text & "distribusi dalam bentuk apapun" & Environment.NewLine & Environment.NewLine
        teks.Text = teks.Text & "[Kritik dan Saran]" & Environment.NewLine
        teks.Text = teks.Text & "Jika kamu ingin megirim kritikan," & Environment.NewLine
        teks.Text = teks.Text & "saran, pelaporan masalah atau" & Environment.NewLine
        teks.Text = teks.Text & "lainnya mengenai aplikasi ini, " & Environment.NewLine
        teks.Text = teks.Text & "sila hubungi saya di pos-el:" & Environment.NewLine
        teks.Text = teks.Text & "alcholis39@gmail.com" & Environment.NewLine
    End Sub

    Private Sub opsi1_MouseEnter(sender As Object, e As EventArgs) Handles opsi1.MouseEnter
        teks.Text = "[Mode klasik]" & Environment.NewLine & "Raih level maksimal (Lv 100) dalam 30 detik atau kurang" & vbCrLf & vbCrLf
        teks.Text = teks.Text & "*waktu berkurang HANYA jika kamu salah ketik"
    End Sub

    Private Sub opsi2_MouseEnter(sender As Object, e As EventArgs) Handles opsi2.MouseEnter
        teks.Text = "[Mode sintas]" & Environment.NewLine & "Ketik teks secepat dan setepat mungkin dalam waktu singkat"
    End Sub

    Private Sub opsi1_CheckedChanged(sender As Object, e As EventArgs) Handles opsi1.CheckedChanged
        teks.Text = "[Mode klasik] dipilih" & vbCrLf & vbCrLf
        teks.Text = teks.Text & "*waktu berkurang HANYA jika kamu salah ketik"
        play.Enabled = True
    End Sub

    Private Sub opsi2_CheckedChanged(sender As Object, e As EventArgs) Handles opsi2.CheckedChanged
        teks.Text = "[Mode sintas] dipilih"
        play.Enabled = True
    End Sub

    Private Sub play_Click(sender As Object, e As EventArgs) Handles play.Click
        If opsi1.Checked = True Then
            A.Show()
            Close()
        ElseIf opsi2.Checked = True Then
            B.Show()
            Close()
        ElseIf opsi3.Checked = True Then
            If tantangan = True Then
                C.Show()
                tantangan = False
                Close()
            Else
                teks.Text = "Syarat tidak memenuhi untuk memilih mode ini"
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        dt.Value = TimeOfDay.Second
        time.Text = TimeOfDay.ToShortTimeString
        If Date.Now.DayOfWeek = 0 Then
            hari = "Minggu"
        ElseIf Date.Now.DayOfWeek = 1 Then
            hari = "Senin"
        ElseIf Date.Now.DayOfWeek = 2 Then
            hari = "Selasa"
        ElseIf Date.Now.DayOfWeek = 3 Then
            hari = "Rabu"
        ElseIf Date.Now.DayOfWeek = 4 Then
            hari = "Kamis"
        ElseIf Date.Now.DayOfWeek = 5 Then
            hari = "Jumat"
        Else
            hari = "Sabtu"
        End If
    End Sub

    Private Sub time_MouseEnter(sender As Object, e As EventArgs) Handles time.MouseEnter
        teks.Text = "Hari dan tanggal saat ini: " & hari & ", " & Date.Now.ToShortDateString
    End Sub

    Private Sub opsiC_CheckedChanged(sender As Object, e As EventArgs) Handles opsi3.CheckedChanged
        play.Enabled = True
        If tantangan = True Then
            teks.Text = "Mode kilat dipilih" & vbCrLf & vbCrLf
            teks.Text = teks.Text & "*waktu berkurang lebih cepat jika kamu salah ketik"

        Else
            teks.Text = "Mode C dipilih"
        End If
    End Sub

    Private Sub opsiC_MouseEnter(sender As Object, e As EventArgs) Handles opsi3.MouseEnter
        If tantangan = True Then
            teks.Text = "[Mode Kilat]" & Environment.NewLine & "Raih level maksimal (Lv 25) dalam 3 menit atau kurang" & vbCrLf & vbCrLf
            teks.Text = teks.Text & "*waktu berkurang lebih cepat jika kamu salah ketik"
        Else
            teks.Text = "Mode ini dapat dimainkan jika anda memenuhi salah satu kondisi berikut: " & Environment.NewLine & Environment.NewLine
            teks.Text = teks.Text & "[1] pada mode klasik:" & Environment.NewLine
            teks.Text = teks.Text & "    selesaikan Lv 100 dalam 12" & Environment.NewLine
            teks.Text = teks.Text & "    menit atau kurang" & Environment.NewLine
            teks.Text = teks.Text & "[2] pada mode sintas:" & Environment.NewLine
            teks.Text = teks.Text & "    selesaikan minimal Lv 30; dan" & Environment.NewLine
            teks.Text = teks.Text & "       capai 60 karakter per menit" & Environment.NewLine
            teks.Text = teks.Text & "       atau skor minimal 60" & Environment.NewLine
        End If

    End Sub

    Private Sub Fn_MouseEnter(sender As Object, e As EventArgs) Handles fn.MouseEnter
        teks.Text = "Font dipakai: Consolas"
        teks.AppendText("" & Environment.NewLine)
        teks.AppendText("0123456789" & Environment.NewLine)
        teks.AppendText("abcdefghijklmnopqrstuvwxyz" & Environment.NewLine)
        teks.AppendText("ABCDEFGHIJKLMNOPQRSTUVWXYZ" & Environment.NewLine)
    End Sub

    Private Sub Help_Click(sender As Object, e As EventArgs) Handles help.Click
        teks.Text = "[ Dasar ]" & Environment.NewLine
        teks.Text = teks.Text & "Ketik ulang teks yang ditampilkan" & Environment.NewLine
        teks.Text = teks.Text & "dalam batasan waktu tertentu" & Environment.NewLine & Environment.NewLine
        teks.Text = teks.Text & "[ Perhitungan skor ]" & Environment.NewLine
        teks.Text = teks.Text & "Skor dihitung dari jumlah karakter" & Environment.NewLine
        teks.Text = teks.Text & "dibagi durasi ketik dalam detik." & Environment.NewLine & Environment.NewLine
        teks.Text = teks.Text & "[ Jeda ]" & Environment.NewLine
        teks.Text = teks.Text & "Gim dapat dijeda dengan klik tanda" & Environment.NewLine
        teks.Text = teks.Text & "silang; bisa juga kombinasi tombol" & Environment.NewLine
        teks.Text = teks.Text & "[Alt] + Tombol fungsi [F4]" & Environment.NewLine & Environment.NewLine
        teks.Text = teks.Text & "[ Perhatian ]" & Environment.NewLine
        teks.Text = teks.Text & "Pastikan tidak ada data di papan" & Environment.NewLine
        teks.Text = teks.Text & "klip sebelum mulai bermain, sebab" & Environment.NewLine
        teks.Text = teks.Text & "data itu akan dihapus saat game" & Environment.NewLine
        teks.Text = teks.Text & "sedang dimainkan. Tindakan ini" & Environment.NewLine
        teks.Text = teks.Text & "dilakukan untuk mencegah upaya" & Environment.NewLine
        teks.Text = teks.Text & "melakukan kecurangan." & Environment.NewLine & Environment.NewLine
        teks.Text = teks.Text & "[ Info ]" & Environment.NewLine
        teks.Text = teks.Text & "Waktu tidak langsung dimulai jika" & Environment.NewLine
        teks.Text = teks.Text & "panjang teks melebihi 24 karakter" & Environment.NewLine
    End Sub

    Private Sub Info_Click(sender As Object, e As EventArgs) Handles info.Click
        teks.Text = "Tik versi " & My.Application.Info.Version.ToString & Environment.NewLine & Environment.NewLine
        teks.Text = teks.Text & "Direktori program:" & Environment.NewLine
        teks.Text = teks.Text & My.Application.Info.DirectoryPath.ToString & Environment.NewLine & Environment.NewLine
        teks.Text = teks.Text & "Dibuat oleh Al Cholis" & Environment.NewLine & Environment.NewLine
        teks.Text = teks.Text & "Permainan ini dibuat tanpa jaminan" & Environment.NewLine
        teks.Text = teks.Text & "apapun. Pembuat aplikasi tidak" & Environment.NewLine
        teks.Text = teks.Text & "bertanggungjawab atas hilangnya" & Environment.NewLine
        teks.Text = teks.Text & "data pada papan klip akibat anda" & Environment.NewLine
        teks.Text = teks.Text & "bermain permainan ini." & Environment.NewLine & Environment.NewLine
        teks.Text = teks.Text & "Anda bebas melakukan tindakan" & Environment.NewLine
        teks.Text = teks.Text & "apapun berikut, mengenai game ini:" & Environment.NewLine
        teks.Text = teks.Text & "(dengan menyertakan sumbernya)" & Environment.NewLine
        teks.Text = teks.Text & "ubah, edit, salin, duplikasi" & Environment.NewLine
        teks.Text = teks.Text & "distribusi dalam bentuk apapun" & Environment.NewLine & Environment.NewLine
        teks.Text = teks.Text & "[Kritik dan Saran]" & Environment.NewLine
        teks.Text = teks.Text & "Jika kamu ingin megirim kritikan," & Environment.NewLine
        teks.Text = teks.Text & "saran, pelaporan masalah atau" & Environment.NewLine
        teks.Text = teks.Text & "lainnya mengenai aplikasi ini, " & Environment.NewLine
        teks.Text = teks.Text & "sila hubungi saya di pos-el:" & Environment.NewLine
        teks.Text = teks.Text & "alcholis39@gmail.com" & Environment.NewLine
    End Sub

    Private Sub Fn_Click(sender As Object, e As EventArgs) Handles fn.Click
        teks.Text = "Font dipakai: Consolas"
        teks.AppendText("" & Environment.NewLine)
        teks.AppendText("0123456789" & Environment.NewLine)
        teks.AppendText("abcdefghijklmnopqrstuvwxyz" & Environment.NewLine)
        teks.AppendText("ABCDEFGHIJKLMNOPQRSTUVWXYZ" & Environment.NewLine)

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Text = "Beranda"
        play.Enabled = True
        Timer2.Stop()
    End Sub

    Private Sub Rekor_Click(sender As Object, e As EventArgs) Handles rekor.Click
        HiSkor.Show()
        Close()
    End Sub

    Private Sub Rekor_MouseHover(sender As Object, e As EventArgs) Handles rekor.MouseHover
        teks.Text = "Lihat rekor yang telah kamu buat"
    End Sub
End Class

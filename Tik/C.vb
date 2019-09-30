Public Class C
    'Di bawah adalah bonus waktu
    Dim apakahnol As Decimal
    'Di bawah adalah level
    Public lv As Integer
    'Di bawah adalah waktu
    Dim menit As Integer
    Dim detik As Integer
    Dim mili As Decimal
    'Di bawah adalah panjang teks
    Dim panjang As Integer
    'Di bawah adalah konfigurasi untuk teks acak
    Dim num_characters As Integer
    Dim i As Integer
    Dim ch As Integer
    'Di bawah adalah waktu jeda
    Dim jeda As Integer
    'Di bawah adalah skor
    Public skor As Decimal
    'Di bawah adalah durasi menjawab soal
    Dim durasi As Integer
    'Di bawah untuk statistik huruf per menit
    Public jhuruf As Integer
    Public jtime As Integer
    'alias warna terlebih dahulu
    Dim z As Color
    Dim y As Color
    Dim x As Color
    'Di bawah untuk mengambil data skor tinggi sebelumnya
    Public chal As Decimal

    Private Sub C_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chal = My.Settings.topChalSkor
        'Di bawah untuk definisi warna
        z = Color.Black
        y = Color.Red
        x = Color.White
        'atur warna kendali
        If TimeOfDay.Hour >= 17 Or TimeOfDay.Hour <= 7 Then
            BackColor = z
            nilai.BackColor = z
            waktu.BackColor = z
            kolom.BackColor = z
            Label1.BackColor = z
            Label2.BackColor = z
            hitung.BackColor = z
            target.BackColor = z
            ForeColor = x
            nilai.ForeColor = x
            waktu.ForeColor = x
            kolom.ForeColor = x
            Label1.ForeColor = x
            Label2.ForeColor = x
            hitung.ForeColor = x
            target.ForeColor = x
            caps.ForeColor = x
            num.ForeColor = x
            scrl.ForeColor = x
        End If

        Timer4.Start()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        'untuk penanda status ==========================================
        'CAPS LOCK
        If IsKeyLocked(Keys.CapsLock) = True Then
            caps.Visible = True
        Else
            caps.Visible = False
        End If
        'NUM LOCK
        If IsKeyLocked(Keys.NumLock) Then
            num.Visible = True
        Else
            num.Visible = False
        End If
        'SCROLL LOCK
        If IsKeyLocked(Keys.Scroll) = True Then
            scrl.Visible = True
        Else
            scrl.Visible = False
        End If

        'Timer 3 bertugas sebagai pengatur waktu =================================
        If menit = 0 And detik = 0 And mili <= 0 Then
            If lv <= 25 Then
                usai.riw.AppendText("" & Environment.NewLine)
                usai.riw.AppendText("" & Environment.NewLine)
                usai.riw.AppendText("" & Environment.NewLine)
                usai.riw.AppendText("Kecepatan mengetik: " & (jhuruf / (jtime / 63)) * 60 & " karakter per menit" & Environment.NewLine)
                usai.riw.AppendText("Total: " & jhuruf & " karakter diketik dalam waktu " & jtime / 63 & " detik" & Environment.NewLine)
                Timer1.Stop()
                Timer2.Stop()
                Timer3.Stop()
                maju.Value = 0
                waktu.Text = "0 detik 0 mdet"
                MsgBox("Permainan saat ini dalam status SELESAI. Tidak dapat melanjutkan permainan kembali.", MsgBoxStyle.OkOnly, "Pemberitahuan")
                'usai.Show()
                Close()
            End If

        Else
            If detik < 0 Then
                detik = detik + 60
                menit = menit - 1
            ElseIf mili < 0 Then
                mili = mili + 63
                detik = detik - 1
            Else
                mili = mili - 1
                If kolom.ForeColor = y Then
                    mili = mili - 1
                    waktu.ForeColor = y
                Else
                    waktu.ForeColor = ForeColor
                End If
                durasi = durasi + 1
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'Timer 2 bertugas mengawasi teks

        'Antisipasi kecurangan
        Clipboard.Clear()

        'Di bawah untuk mengawasi hitungan
        hitung.Text = kolom.TextLength & "/" & kolom.MaxLength
        'Di bawah untuk memperbarui label skor
        nilai.Text = "Skor: " & skor
        'Di bawah untuk validasi kecocokan antara target dan teks yang diketikkan
        If kolom.Text = target.Text And kolom.TextLength = kolom.MaxLength Then
            'Di bawah untuk menambah waktu
            apakahnol = lv
            Do Until apakahnol < 1
                If apakahnol >= 1 Then
                    apakahnol = apakahnol - 10
                Else
                    If apakahnol = 0 Then
                        menit = menit + 1
                    End If
                End If
            Loop
            'Jika panjang teks sama dan teks sesuai
            'Di bawah untuk mencatat log
            usai.riw.AppendText("[Level " & lv & " | Durasi tik: " & Math.Round(durasi / 63, 3) & " detik] " & Environment.NewLine)
            usai.riw.AppendText("[Panjang teks: " & kolom.TextLength & " ] " & kolom.Text & Environment.NewLine)
            usai.riw.AppendText("[Skor didapat: " & ((Math.Sqrt(1)) * ((kolom.TextLength * 63) / durasi)) & "]" & Environment.NewLine)
            usai.riw.AppendText("" & Environment.NewLine)
            'Di bawah untuk mulai pengacakan teks
            Timer1.Start()
            Timer3.Stop()
            'Di bawah untuk menambah skor
            If durasi <= 0 Then
                skor = skor + ((Math.Sqrt(1)) * ((kolom.TextLength * 63) * durasi))
            Else
                skor = skor + ((Math.Sqrt(1)) * ((kolom.TextLength * 63) / durasi))
            End If
            'Di bawah untuk keperluan huruf per menit
            jhuruf = jhuruf + kolom.TextLength
            jtime = jtime + durasi
            'Di bawah untuk menambah level
            lv = lv + 1
            kolom.Clear()


        ElseIf kolom.Text IsNot target.Text And kolom.TextLength = kolom.MaxLength Then
            'Jika panjang teks sama dan teks berbeda
            kolom.ForeColor = y
        ElseIf kolom.TextLength < kolom.MaxLength Then
            'Jika panjang teks kurang
            If kolom.TextLength >= 1 Then
                'Label2.Text = target.Text.Substring(0, kolom.TextLength)
                If kolom.TextLength >= 1 Then
                    'monitor masukan data dari pengguna
                    If target.Text.Substring(0, kolom.TextLength) = kolom.Text Then
                        'jika masukan data pengguna benar
                        If TimeOfDay.Hour >= 17 Or TimeOfDay.Hour <= 5 Then
                            kolom.ForeColor = ForeColor
                        Else
                            kolom.ForeColor = ForeColor
                        End If
                    Else
                        'jika masukan data pengguna salah
                        kolom.ForeColor = y
                    End If
                End If
            Else
                'Jika panjang teks kurang
                If TimeOfDay.Hour >= 17 Or TimeOfDay.Hour <= 5 Then
                    kolom.ForeColor = ForeColor
                Else
                    kolom.ForeColor = ForeColor
                End If
            End If


        End If


        'Di bawah untuk menampilkan teks pada bilah judul
        If lv < 100 Then
            Me.Text = "Level " & lv
        Else
            Me.Text = "Level Maksimal"
        End If
        'Di bawah untuk menampilkan sisa waktu
        If menit = 1 Then
            If detik <= 40 Then
                If detik = 40 Then
                    maju.Maximum = 100 * 63 + 63
                End If
                waktu.Text = (detik + 60) & " detik " & Math.Round((mili / 63) * 100) & " mdet"
            Else
                waktu.Text = menit & " menit " & detik & " detik"
            End If
        ElseIf menit < 1 Then
            waktu.Text = detik & " detik " & Math.Round((mili / 63) * 100) & " mdet"
        Else
            waktu.Text = menit & " menit " & detik & " detik"
        End If


        'Di bawah untuk progressbar
        maju.Value = (menit * 60 * 63) + (detik * 63) + mili

        'Jika LEVEL MAKSIMAL TELAH TERCAPAI
        If lv > 25 Then
            Close()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Timer 1 bertugas untuk interval

        'Di bawah untuk mengatur panjang teks target
        'CharacterCasing untuk format kapitalisasi huruf

        If lv = 25 Then
            panjang = 50
            target.CharacterCasing = CharacterCasing.Normal
        ElseIf lv = 24 Then
            panjang = 35
            target.CharacterCasing = CharacterCasing.Normal
        ElseIf lv = 23 Then
            panjang = 25
            target.CharacterCasing = CharacterCasing.Normal
        ElseIf lv = 22 Then
            panjang = 15
            target.CharacterCasing = CharacterCasing.Normal
        ElseIf lv = 21 Or lv = 16 Or lv = 11 Then
            panjang = 12
            target.CharacterCasing = CharacterCasing.Normal
        ElseIf lv = 6 Then
            panjang = 5
            target.CharacterCasing = CharacterCasing.Normal
        Else
            panjang = 2
            target.CharacterCasing = CharacterCasing.Normal
        End If

        'Di bawah adalah set untuk teks acak
        target.Clear()
        Randomize()
        num_characters = Convert.ToDecimal(panjang)
        For i = 1 To num_characters
            ch = Int((26 + 26 + 10) * Rnd())
            If ch < 26 Then
                target.Text = target.Text & Chr(ch + Asc("A"))
            ElseIf ch < 52 Then
                ch = ch - 26
                target.Text = target.Text & Chr(ch + Asc("a"))
            Else
                ch = ch - 52
                target.Text = target.Text & Chr(ch + Asc("0"))
            End If
        Next i
        kolom.Clear()

        'Di bawah untuk mengatur statistik teks
        kolom.MaxLength = target.TextLength
        'Di bawah untuk mengurangi durasi jeda
        If jeda > 0 Then
            jeda = jeda - 1
            Label1.Text = "Mengacak teks..."
            target.Enabled = False
        Else

            'standar
            target.Enabled = True
            Label1.Text = "Teks yang harus diketik:"
            'reset durasi
            durasi = 0
            'lanjutan saat acak 
            Timer1.Stop()
            jeda = 50
            Timer2.Start()

            'timer dimulai begitu teks yang harus diketik berhenti di acak
            If target.TextLength < 25 Then
                Timer3.Start()
            End If
        End If

    End Sub

    Private Sub C_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()

        If menit = 0 And detik = 0 And mili <= 0 Then
            'Aksi berikut akan ditampilkan jika waktu habis
            If e.CloseReason = CloseReason.UserClosing Then
                e.Cancel = False
                usai.lv.Text = "[HASIL AKHIR]  Level: " & lv - 1 & ". Skor: " & skor
                'usai.Show()
            Else
                e.Cancel = False
                usai.lv.Text = "[HASIL AKHIR]  Level: " & lv - 1 & ". Skor: " & skor
                'usai.Show()
            End If
        Else
            'Aksi berikut akan ditampilkan jika waktu masih tersedia
            If e.CloseReason = CloseReason.UserClosing Then
                If lv > 25 Then
                    'If MsgBox("Permainan saat ini sedang dalam status JEDA. Klik [ YA / YES ] untuk melanjutkan, Klik TIDAK/NO untuk mengakhiri permainan", MsgBoxStyle.YesNo, "Pemberitahuan") = MsgBoxResult.Yes Then
                    If MsgBox("Anda telah mencapai Level 25." & vbCrLf & vbCrLf & "Anda telah menyelesaikan mode kilat" & vbCrLf & "============================" & vbCrLf & "Klik [ OK ] untuk melihat hasil", MsgBoxStyle.OkOnly, "Pemberitahuan") = MsgBoxResult.Ok Then
                        If lv > 25 Then
                            'Di bawah untuk stempel waktu berakhir
                            usai.riw.AppendText("" & Environment.NewLine)
                            usai.riw.AppendText("Kecepatan mengetik: " & (jhuruf / (jtime / 63)) * 60 & " karakter per menit" & Environment.NewLine)
                            usai.riw.AppendText("Total: " & jhuruf & " karakter diketik dalam waktu " & jtime / 63 & " detik" & Environment.NewLine)
                            usai.riw.AppendText("" & Environment.NewLine)
                            usai.riw.AppendText("Permainan mode kilat selesai pada pukul " & TimeOfDay.ToLongTimeString & ", " & Date.Now.ToShortDateString & Environment.NewLine)
                            e.Cancel = False
                            usai.lv.Text = "[HASIL AKHIR]  Level: " & lv - 1 & ". Skor: " & skor

                            'usai.Show()
                        Else
                            usai.riw.AppendText("Mode kilat gagal diselesaikan" & Environment.NewLine)
                            usai.riw.AppendText("" & Environment.NewLine)
                            usai.riw.AppendText("" & Environment.NewLine)
                            usai.riw.AppendText("" & Environment.NewLine)
                            usai.riw.AppendText("Kecepatan mengetik: " & (jhuruf / (jtime / 63)) * 60 & " karakter per menit" & Environment.NewLine)
                            usai.riw.AppendText("Total: " & jhuruf & " karakter diketik dalam waktu " & jtime / 63 & " detik" & Environment.NewLine)
                            e.Cancel = False
                            usai.lv.Text = "[HASIL AKHIR]  Level: " & lv - 1 & ". Skor: " & skor
                            'usai.Show()
                        End If
                    End If
                Else
                    'If MsgBox("Permainan saat ini sedang dalam status JEDA. Klik [ YA / YES ] untuk melanjutkan, Klik TIDAK/NO untuk mengakhiri permainan", MsgBoxStyle.YesNo, "Pemberitahuan") = MsgBoxResult.Yes Then

                    'teks ditampilkan di kotak teks
                    target.TextAlign = HorizontalAlignment.Center
                    kolom.TextAlign = HorizontalAlignment.Center
                    Label1.Text = ""
                    target.Text = "Permainan saat ini"
                    kolom.Text = vbCrLf & vbCrLf & vbCrLf & "dalam status jeda"

                    If MsgBox("Permainan saat ini sedang dalam status JEDA." & vbCrLf & vbCrLf & "Lanjutkan kembali permainan?" & vbCrLf & "============================" & vbCrLf & "Klik [ YA / YES ] untuk melanjutkan permainan" & vbCrLf & "Waktu dilanjutkan pada: " & waktu.Text & vbCrLf & "*teks akan di acak kembali" & vbCrLf & "Klik [ TIDAK / NO ] untuk mengakhiri permainan", MsgBoxStyle.YesNo, "Pemberitahuan") = MsgBoxResult.Yes Then

                        'teks ditampilkan di kotak teks
                        target.TextAlign = HorizontalAlignment.Left
                        kolom.TextAlign = HorizontalAlignment.Left
                        waktu.Text = "Sisa W a k t u"

                        e.Cancel = True
                        Timer1.Start()
                    Else
                        If lv > 25 Then
                            'Di bawah untuk stempel waktu berakhir
                            usai.riw.AppendText("" & Environment.NewLine)
                            usai.riw.AppendText("Kecepatan mengetik: " & (jhuruf / (jtime / 63)) * 60 & " karakter per menit" & Environment.NewLine)
                            usai.riw.AppendText("Total: " & jhuruf & " karakter diketik dalam waktu " & jtime / 63 & " detik" & Environment.NewLine)
                            usai.riw.AppendText("" & Environment.NewLine)
                            usai.riw.AppendText("Permainan mode kilat selesai pada pukul " & TimeOfDay.ToLongTimeString & ", " & Date.Now.ToShortDateString & Environment.NewLine)
                            e.Cancel = False
                            usai.lv.Text = "[HASIL AKHIR]  Level: " & lv - 1 & ". Skor: " & skor
                            'usai.Show()
                        Else
                            usai.riw.AppendText("Mode kilat gagal diselesaikan" & Environment.NewLine)
                            usai.riw.AppendText("" & Environment.NewLine)
                            usai.riw.AppendText("" & Environment.NewLine)
                            usai.riw.AppendText("" & Environment.NewLine)
                            usai.riw.AppendText("Kecepatan mengetik: " & (jhuruf / (jtime / 63)) * 60 & " karakter per menit" & Environment.NewLine)
                            usai.riw.AppendText("Total: " & jhuruf & " karakter diketik dalam waktu " & jtime / 63 & " detik" & Environment.NewLine)
                            e.Cancel = False
                            usai.lv.Text = "[HASIL AKHIR]  Level: " & lv - 1 & ". Skor: " & skor

                            'usai.Show()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        'Di bawah untuk catatan log dalam mode apa dimainkan
        usai.riw.AppendText("Permainan mode kilat dimulai pada pukul " & TimeOfDay.ToLongTimeString & ", " & Date.Now.ToShortDateString & Environment.NewLine)
        usai.riw.AppendText("" & Environment.NewLine)
        'Di bawah untuk mengatur teks yang harus diketik dan mulai interval
        Timer1.Start()
        'Atur nilai ke setelan awal
        'Di bawah adalah skor awal
        skor = 0
        'Di bawah adalah panjang teks target awal
        panjang = 2
        'Di bawah adalah level awal
        lv = 1
        'Di bawah adalah pengaturan waktu awal
        menit = 3
        detik = 0
        mili = 0
        'Di bawah adalah pengaturan waktu jeda
        jeda = 50
        'Nilai awal durasi menjawab soal (dalam milidetik)
        durasi = 0

        target.TextAlign = HorizontalAlignment.Left
        kolom.TextAlign = HorizontalAlignment.Left


        'Di bawah untuk progressbar
        maju.Maximum = 3 * 60 * 63
        maju.Value = (menit * 60 * 63) + (detik * 63) + mili

        Timer4.Stop()
    End Sub

    Private Sub Kolom_KeyDown(sender As Object, e As KeyEventArgs) Handles kolom.KeyDown
        If target.Enabled = True Then
            If target.TextLength >= 25 Then
                If kolom.TextLength = 0 Then
                    Timer3.Start()
                End If
            End If
        End If
    End Sub

    Private Sub C_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If skor > chal Then
            'skor
            Hi.skor = skor
            'jumlah huruf
            Hi.karakter = jhuruf
            'level
            Hi.lv = lv - 1
            'karakter per menit
            Hi.kpm = (jhuruf / (jtime / 63)) * 60
            'tanggal waktu selesai
            Hi.tanggal = Date.Now.ToShortDateString & ", " & TimeOfDay.ToLongTimeString
            'durasi detik dalam ketik
            Hi.durasi = jtime / 63
            'jenis game
            Hi.jenis = 3
            'lihat
            usai.Show()
            Hi.Show()
        Else
            usai.Show()
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        kolom.Text = target.Text
    End Sub
End Class
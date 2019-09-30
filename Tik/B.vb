Public Class B

    'Di bawah adalah angka tydac panting

    'bilangan genap
    Dim ge0 As Integer
    Dim ge2 As Integer
    Dim ge3 As Integer
    Dim ge4 As Integer
    Dim ge5 As Integer
    Dim ge6 As Integer
    Dim ge7 As Integer
    Dim ge8 As Integer
    Dim ge9 As Integer

    Dim ga0 As Integer
    Dim ga1 As Integer
    Dim ga2 As Integer
    Dim ga3 As Integer
    Dim ga4 As Integer
    Dim ga5 As Integer
    Dim ga6 As Integer
    Dim ga7 As Integer
    Dim ga8 As Integer
    Dim ga9 As Integer

    Dim gz0 As Integer
    Dim gz1 As Integer
    Dim gz2 As Integer
    Dim gz3 As Integer
    Dim gz4 As Integer
    Dim gz5 As Integer
    Dim gz6 As Integer
    Dim gz7 As Integer
    Dim gz8 As Integer


    'Di bawah adalah level
    Public lv As Integer
    'Di bawah adalah waktu
    Dim menit As Integer
    Dim detik As Integer
    Dim mili As Integer
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
    Public sintas As Decimal


    Private Sub B_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sintas = My.Settings.topSintasSkor
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

        'Timer 3 bertugas sebagai pengatur waktu
        If menit = 0 And detik = 0 And mili <= 0 Then
            maju.Value = 0
            'Di bawah untuk stempel waktu berakhir
            usai.riw.AppendText("" & Environment.NewLine)
            usai.riw.AppendText("Kecepatan mengetik: " & (jhuruf / (jtime / 63)) * 60 & " karakter per menit" & Environment.NewLine)
            usai.riw.AppendText("Total: " & jhuruf & " karakter diketik dalam waktu " & jtime / 63 & " detik" & Environment.NewLine)
            usai.riw.AppendText("" & Environment.NewLine)
            usai.riw.AppendText("Permainan mode sintas selesai pada pukul " & TimeOfDay.ToLongTimeString & ", " & Date.Now.ToShortDateString & Environment.NewLine)
            usai.riw.AppendText("" & Environment.NewLine)
            If My.Settings.challenge = False Then
                If lv >= 30 Then
                    If (jhuruf / (jtime / 63)) * 60 >= 60 Then
                        usai.riw.AppendText("Anda memenuhi syarat minimal 60 karakter per menit" & Environment.NewLine)
                    Else
                        usai.riw.AppendText("Anda tidak memenuhi syarat minimal 60 karakter per menit" & Environment.NewLine)
                    End If
                    If skor >= 60 Then
                        usai.riw.AppendText("Anda memenuhi syarat minimal skor sebanyak 60 poin" & Environment.NewLine)
                    Else
                        usai.riw.AppendText("Anda tidak memenuhi syarat minimal skor sebanyak 60 poin" & Environment.NewLine)
                    End If
                    If ((jhuruf / (jtime / 63)) * 60 >= 60) Or (skor >= 60) = True Then
                        usai.riw.AppendText("Mode kilat terbuka" & Environment.NewLine)
                    Else
                        usai.riw.AppendText("Mode C tidak terbuka karena tidak memenuhi syarat" & Environment.NewLine)
                    End If
                Else
                    usai.riw.AppendText("Persyaratan level tidak memenuhi untuk membuka mode C" & Environment.NewLine)
                    usai.riw.AppendText(30 - lv & " level lagi untuk memenuhi persyaratan level" & Environment.NewLine)
                End If
            End If
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
            waktu.Text = "0 detik 0 mdet"
            MsgBox("Permainan saat ini dalam status SELESAI. Tidak dapat melanjutkan permainan kembali.", MsgBoxStyle.OkOnly, "Pemberitahuan")
            Close()
        Else
            If detik < 0 Then
                detik = detik + 60
                menit = menit - 1
            ElseIf mili < 0 Then
                mili = mili + 63
                detik = detik - 1
            Else
                mili = mili - 1
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
            'Di bawah untuk menambah waktu
            If lv > 30 Then
                maju.Maximum = (lv * 63) + mili
                detik = lv
                If detik > 99 Then
                    maju.Maximum = (99 * 63) + mili
                    detik = 99
                Else
                    maju.Maximum = (lv * 63) + mili
                    detik = lv
                End If
            ElseIf lv > 15 Then
                maju.Maximum = ((lv + 2) * 63) + mili
                detik = lv + 2
            ElseIf lv > 0 Then
                maju.Maximum = (15 * 63) + mili
                detik = 15
            End If
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
                        If TimeOfDay.Hour >= 19 Or TimeOfDay.Hour <= 5 Then
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
                If TimeOfDay.Hour >= 19 Or TimeOfDay.Hour <= 5 Then
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
        If menit < 1 Then
            waktu.Text = detik & " detik " & Math.Round((mili / 63) * 100) & " mdet"
        Else
            waktu.Text = menit & " menit " & detik & " detik"
        End If

        'Di bawah untuk progressbar
        maju.Value = (detik * 63) + mili
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Timer 1 bertugas untuk interval

        'Di bawah untuk mengatur panjang teks target
        If lv < 7 Then
            panjang = 5
        ElseIf lv >= 100 Then
            panjang = 100
        ElseIf lv >= 7 And lv < 100 Then
            If TimeOfDay.Second > 50 Then
                panjang = lv + 2
            ElseIf TimeOfDay.Second > 40 Then
                panjang = lv - 1
            ElseIf TimeOfDay.Second > 30 Then
                panjang = lv
            ElseIf TimeOfDay.Second > 20 Then
                panjang = lv - 2
            ElseIf TimeOfDay.Second > 10 Then
                panjang = lv
            Else
                panjang = lv + 1
            End If
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
            'atur kapitalisasi huruf
            If lv >= 20 Then
                target.CharacterCasing = CharacterCasing.Normal
            ElseIf lv >= 10 Then
                target.CharacterCasing = CharacterCasing.Upper
            ElseIf lv >= 0 Then
                target.CharacterCasing = CharacterCasing.Lower
            End If
            target.Enabled = True
            Label1.Text = "Teks yang harus diketik:"
            'reset durasi
            durasi = 0
            'lanjutan saat acak 
            Timer1.Stop()
            jeda = 100
            Timer2.Start()

            'timer dimulai begitu teks yang harus diketik berhenti di acak
            If target.TextLength < 25 Then
                Timer3.Start()
            End If
        End If

    End Sub

    Private Sub B_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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
                'If MsgBox("Permainan saat ini sedang dalam status JEDA. Klik YA/YES untuk melanjutkan, Klik TIDAK/NO untuk mengakhiri permainan", MsgBoxStyle.YesNo, "Pemberitahuan") = MsgBoxResult.Yes Then

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
                    'Di bawah untuk stempel waktu berakhir
                    usai.riw.AppendText("" & Environment.NewLine)
                    usai.riw.AppendText("Kecepatan mengetik: " & (jhuruf / (jtime / 63)) * 60 & " karakter per menit" & Environment.NewLine)
                    usai.riw.AppendText("Total: " & jhuruf & " karakter diketik dalam waktu " & jtime / 63 & " detik" & Environment.NewLine)
                    usai.riw.AppendText("" & Environment.NewLine)
                    usai.riw.AppendText("Permainan mode sintas selesai pada pukul " & TimeOfDay.ToLongTimeString & ", " & Date.Now.ToShortDateString & Environment.NewLine)
                    usai.riw.AppendText("" & Environment.NewLine)
                    If My.Settings.challenge = False Then
                        If lv >= 30 + 1 Then
                            If (jhuruf / (jtime / 63)) * 60 >= 60 Then
                                usai.riw.AppendText("Anda memenuhi syarat minimal 60 karakter per menit" & Environment.NewLine)
                            Else
                                usai.riw.AppendText("Anda tidak memenuhi syarat minimal 60 karakter per menit" & Environment.NewLine)
                            End If
                            If skor >= 60 Then
                                usai.riw.AppendText("Anda memenuhi syarat minimal skor sebanyak 60 poin" & Environment.NewLine)
                            Else
                                usai.riw.AppendText("Anda tidak memenuhi syarat minimal skor sebanyak 60 poin" & Environment.NewLine)
                            End If
                            If ((jhuruf / (jtime / 63)) * 60 >= 60) Or (skor >= 60) = True Then
                                My.Settings.challenge = True
                                My.Settings.Save()
                                usai.riw.AppendText("Mode kilat terbuka" & Environment.NewLine)
                            Else
                                usai.riw.AppendText("Mode C tidak terbuka karena tidak memenuhi syarat" & Environment.NewLine)
                            End If
                        Else
                            usai.riw.AppendText("Persyaratan level tidak memenuhi untuk membuka mode C" & Environment.NewLine)
                            usai.riw.AppendText(30 + 1 - lv & " level lagi untuk memenuhi persyaratan level" & Environment.NewLine)
                        End If
                    End If
                    e.Cancel = False
                    usai.lv.Text = "[HASIL AKHIR]  Level: " & lv - 1 & ". Skor: " & skor
                    'usai.Show()
                End If
            End If
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        kolom.Text = target.Text
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        'Di bawah untuk catatan log dalam mode apa dimainkan
        usai.riw.AppendText("Permainan mode sintas dimulai pada pukul " & TimeOfDay.ToLongTimeString & ", " & Date.Now.ToShortDateString & Environment.NewLine)
        usai.riw.AppendText("" & Environment.NewLine)
        'Di bawah untuk mengatur teks yang harus diketik dan mulai interval
        Timer1.Start()
        'Atur nilai ke setelan awal
        'Di bawah adalah skor awal
        skor = 0
        'Di bawah adalah panjang teks target awal
        panjang = 5
        'Di bawah adalah level awal
        lv = 1
        'Di bawah adalah pengaturan waktu awal
        menit = 0
        detik = 15
        mili = 0
        'Di bawah adalah pengaturan waktu jeda
        jeda = 133

        target.TextAlign = HorizontalAlignment.Left
        kolom.TextAlign = HorizontalAlignment.Left
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

    Private Sub B_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If skor > sintas Then
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
            Hi.jenis = 2
            'lihat
            usai.Show()
            Hi.Show()
        Else
            usai.Show()
        End If
    End Sub
End Class

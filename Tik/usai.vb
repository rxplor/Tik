Public Class usai

    Dim kodewarna As Int32
    'karena saya males ngetik kode banyak-banyak, saya menggunakan alias
    'biar hemat tapi sekaligus mengakomodir kemalesan saya

    'Di bawah untuk menggantikan kode warna
    Dim a As Color
    Dim b As Color
    Dim c As Color
    Dim d As Color

    Private Sub usai_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Restart()
    End Sub

    Private Sub usai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TimeOfDay.Hour >= 17 Or TimeOfDay.Hour <= 5 Then
            BackColor = Color.Black
            riw.BackColor = Color.Black
            lv.ForeColor = Color.White
            riw.ForeColor = Color.White
        End If

        If TimeOfDay.Hour >= 17 Or TimeOfDay.Hour <= 5 Then
            kodewarna = 3
            BackColor = Color.Black
            riw.BackColor = Color.Black
            lv.ForeColor = Color.White
            riw.ForeColor = Color.White
        ElseIf TimeOfDay.Hour >= 17 Then
            kodewarna = 2
        ElseIf TimeOfDay.Hour >= 11 Then
            kodewarna = 1
        ElseIf TimeOfDay.Hour >= 6 Then
            kodewarna = 0
        End If
        'Di bawah untuk mendefinisikan kode warna
        a = Color.Orange
        b = Color.Orchid
        c = Color.Brown
        d = Color.Violet
        'Di bawah untuk menentukan warna apa yang akan ditampilkan
        If kodewarna = 0 Then
            warna0.BackColor = a
            warna1.BackColor = a
            warna2.BackColor = a
            warna3.BackColor = a
            warna4.BackColor = a
            warna5.BackColor = a
        ElseIf kodewarna = 1 Then
            warna0.BackColor = b
            warna1.BackColor = b
            warna2.BackColor = b
            warna3.BackColor = b
            warna4.BackColor = b
            warna5.BackColor = b
        ElseIf kodewarna = 2 Then
            warna0.BackColor = c
            warna1.BackColor = c
            warna2.BackColor = c
            warna3.BackColor = c
            warna4.BackColor = c
            warna5.BackColor = c
        ElseIf kodewarna = 3 Then
            warna0.BackColor = d
            warna1.BackColor = d
            warna2.BackColor = d
            warna3.BackColor = d
            warna4.BackColor = d
            warna5.BackColor = d
        Else
            warna0.BackColor = a
            warna1.BackColor = a
            warna2.BackColor = a
            warna3.BackColor = a
            warna4.BackColor = a
            warna5.BackColor = a
        End If
    End Sub

    Private Sub Usai_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Hi.Visible = True Then
            e.Cancel = True
            Hi.Focus()
        End If
    End Sub
End Class

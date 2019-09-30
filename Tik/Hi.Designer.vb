<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.panjang = New System.Windows.Forms.Label()
        Me.note = New System.Windows.Forms.Label()
        Me.kotak = New System.Windows.Forms.GroupBox()
        Me.kotak.SuspendLayout()
        Me.SuspendLayout()
        '
        'nama
        '
        Me.nama.Location = New System.Drawing.Point(9, 43)
        Me.nama.MaxLength = 32
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(296, 26)
        Me.nama.TabIndex = 0
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(6, 22)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(54, 19)
        Me.lblNama.TabIndex = 1
        Me.lblNama.Text = "Nama:"
        '
        'panjang
        '
        Me.panjang.AutoSize = True
        Me.panjang.Location = New System.Drawing.Point(260, 21)
        Me.panjang.Name = "panjang"
        Me.panjang.Size = New System.Drawing.Size(45, 19)
        Me.panjang.TabIndex = 2
        Me.panjang.Text = "0/32"
        '
        'note
        '
        Me.note.AutoSize = True
        Me.note.Font = New System.Drawing.Font("Consolas", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.note.Location = New System.Drawing.Point(59, 76)
        Me.note.Name = "note"
        Me.note.Size = New System.Drawing.Size(199, 13)
        Me.note.TabIndex = 14
        Me.note.Text = "Data disimpan saat kamu mengetik"
        Me.note.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'kotak
        '
        Me.kotak.Controls.Add(Me.lblNama)
        Me.kotak.Controls.Add(Me.note)
        Me.kotak.Controls.Add(Me.nama)
        Me.kotak.Controls.Add(Me.panjang)
        Me.kotak.Location = New System.Drawing.Point(12, 12)
        Me.kotak.Name = "kotak"
        Me.kotak.Size = New System.Drawing.Size(313, 99)
        Me.kotak.TabIndex = 15
        Me.kotak.TabStop = False
        Me.kotak.Text = "Mode"
        '
        'Hi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 123)
        Me.Controls.Add(Me.kotak)
        Me.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Hi"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selamat! Kamu dapat skor tinggi baru!"
        Me.kotak.ResumeLayout(False)
        Me.kotak.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents nama As TextBox
    Friend WithEvents lblNama As Label
    Friend WithEvents panjang As Label
    Friend WithEvents note As Label
    Friend WithEvents kotak As GroupBox
End Class

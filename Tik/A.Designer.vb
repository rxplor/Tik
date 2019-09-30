<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class A
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(A))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.target = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.kolom = New System.Windows.Forms.TextBox()
        Me.waktu = New System.Windows.Forms.Label()
        Me.hitung = New System.Windows.Forms.TextBox()
        Me.nilai = New System.Windows.Forms.Label()
        Me.maju = New System.Windows.Forms.ProgressBar()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.caps = New System.Windows.Forms.Label()
        Me.scrl = New System.Windows.Forms.Label()
        Me.num = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Timer2
        '
        '
        'Timer3
        '
        Me.Timer3.Interval = 1
        '
        'target
        '
        Me.target.Font = New System.Drawing.Font("Consolas", 27.0!)
        Me.target.Location = New System.Drawing.Point(28, 31)
        Me.target.MaxLength = 246
        Me.target.Multiline = True
        Me.target.Name = "target"
        Me.target.ReadOnly = True
        Me.target.Size = New System.Drawing.Size(533, 188)
        Me.target.TabIndex = 0
        Me.target.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Apakah kamu"
        Me.target.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Teks yang harus diketik:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ketik ulang teks di sini:"
        '
        'kolom
        '
        Me.kolom.Font = New System.Drawing.Font("Consolas", 27.0!)
        Me.kolom.Location = New System.Drawing.Point(27, 241)
        Me.kolom.Multiline = True
        Me.kolom.Name = "kolom"
        Me.kolom.Size = New System.Drawing.Size(533, 188)
        Me.kolom.TabIndex = 2
        Me.kolom.Text = "sudah siap?"
        Me.kolom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'waktu
        '
        Me.waktu.AutoSize = True
        Me.waktu.Font = New System.Drawing.Font("Consolas", 14.0!)
        Me.waktu.Location = New System.Drawing.Point(398, 3)
        Me.waktu.Name = "waktu"
        Me.waktu.Size = New System.Drawing.Size(160, 22)
        Me.waktu.TabIndex = 5
        Me.waktu.Text = "Sisa  W a k t u"
        '
        'hitung
        '
        Me.hitung.BackColor = System.Drawing.SystemColors.Control
        Me.hitung.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.hitung.Enabled = False
        Me.hitung.Font = New System.Drawing.Font("Consolas", 13.0!)
        Me.hitung.Location = New System.Drawing.Point(494, 219)
        Me.hitung.Name = "hitung"
        Me.hitung.Size = New System.Drawing.Size(71, 21)
        Me.hitung.TabIndex = 6
        Me.hitung.Text = "000/000"
        Me.hitung.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nilai
        '
        Me.nilai.AutoSize = True
        Me.nilai.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.nilai.Location = New System.Drawing.Point(11, 429)
        Me.nilai.Name = "nilai"
        Me.nilai.Size = New System.Drawing.Size(64, 17)
        Me.nilai.TabIndex = 7
        Me.nilai.Text = "Skor: 0"
        '
        'maju
        '
        Me.maju.Location = New System.Drawing.Point(28, 28)
        Me.maju.Name = "maju"
        Me.maju.Size = New System.Drawing.Size(533, 3)
        Me.maju.TabIndex = 8
        '
        'Timer4
        '
        Me.Timer4.Interval = 1888
        '
        'caps
        '
        Me.caps.AutoSize = True
        Me.caps.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.caps.Location = New System.Drawing.Point(259, 220)
        Me.caps.Name = "caps"
        Me.caps.Size = New System.Drawing.Size(42, 19)
        Me.caps.TabIndex = 9
        Me.caps.Text = "CAPS"
        '
        'scrl
        '
        Me.scrl.AutoSize = True
        Me.scrl.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.scrl.Location = New System.Drawing.Point(355, 220)
        Me.scrl.Name = "scrl"
        Me.scrl.Size = New System.Drawing.Size(41, 19)
        Me.scrl.TabIndex = 10
        Me.scrl.Text = "SCRL"
        '
        'num
        '
        Me.num.AutoSize = True
        Me.num.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.num.Location = New System.Drawing.Point(307, 220)
        Me.num.Name = "num"
        Me.num.Size = New System.Drawing.Size(42, 19)
        Me.num.TabIndex = 11
        Me.num.Text = "NUM"
        '
        'A
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 447)
        Me.Controls.Add(Me.num)
        Me.Controls.Add(Me.scrl)
        Me.Controls.Add(Me.caps)
        Me.Controls.Add(Me.maju)
        Me.Controls.Add(Me.nilai)
        Me.Controls.Add(Me.hitung)
        Me.Controls.Add(Me.waktu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.kolom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.target)
        Me.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "A"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tik mode A"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents target As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents kolom As TextBox
    Friend WithEvents waktu As Label
    Friend WithEvents hitung As TextBox
    Friend WithEvents nilai As Label
    Friend WithEvents maju As ProgressBar
    Friend WithEvents Timer4 As Timer
    Friend WithEvents caps As Label
    Friend WithEvents scrl As Label
    Friend WithEvents num As Label
End Class

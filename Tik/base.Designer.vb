<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class base
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(base))
        Me.play = New System.Windows.Forms.Button()
        Me.opsi1 = New System.Windows.Forms.RadioButton()
        Me.opsi2 = New System.Windows.Forms.RadioButton()
        Me.teks = New System.Windows.Forms.TextBox()
        Me.info = New System.Windows.Forms.Button()
        Me.help = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.time = New System.Windows.Forms.Label()
        Me.opsi3 = New System.Windows.Forms.RadioButton()
        Me.fn = New System.Windows.Forms.Button()
        Me.dt = New System.Windows.Forms.ProgressBar()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.rekor = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'play
        '
        Me.play.Enabled = False
        Me.play.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.play.Font = New System.Drawing.Font("Calibri", 24.0!)
        Me.play.Location = New System.Drawing.Point(31, 54)
        Me.play.Name = "play"
        Me.play.Size = New System.Drawing.Size(131, 122)
        Me.play.TabIndex = 1
        Me.play.Text = "Mulai"
        Me.play.UseVisualStyleBackColor = True
        '
        'opsi1
        '
        Me.opsi1.AutoSize = True
        Me.opsi1.BackColor = System.Drawing.SystemColors.Control
        Me.opsi1.Font = New System.Drawing.Font("Calibri", 18.0!)
        Me.opsi1.ForeColor = System.Drawing.Color.Black
        Me.opsi1.Location = New System.Drawing.Point(26, 15)
        Me.opsi1.Name = "opsi1"
        Me.opsi1.Size = New System.Drawing.Size(45, 33)
        Me.opsi1.TabIndex = 5
        Me.opsi1.Text = "&A"
        Me.opsi1.UseVisualStyleBackColor = False
        '
        'opsi2
        '
        Me.opsi2.AutoSize = True
        Me.opsi2.BackColor = System.Drawing.SystemColors.Control
        Me.opsi2.Font = New System.Drawing.Font("Calibri", 18.0!)
        Me.opsi2.ForeColor = System.Drawing.Color.Black
        Me.opsi2.Location = New System.Drawing.Point(77, 15)
        Me.opsi2.Name = "opsi2"
        Me.opsi2.Size = New System.Drawing.Size(44, 33)
        Me.opsi2.TabIndex = 6
        Me.opsi2.Text = "&B"
        Me.opsi2.UseVisualStyleBackColor = False
        '
        'teks
        '
        Me.teks.BackColor = System.Drawing.SystemColors.Control
        Me.teks.Font = New System.Drawing.Font("Consolas", 14.0!)
        Me.teks.ForeColor = System.Drawing.Color.Black
        Me.teks.Location = New System.Drawing.Point(192, 17)
        Me.teks.Multiline = True
        Me.teks.Name = "teks"
        Me.teks.ReadOnly = True
        Me.teks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.teks.Size = New System.Drawing.Size(376, 167)
        Me.teks.TabIndex = 8
        Me.teks.Text = "Selamat datang di Gim ""Tik"""
        '
        'info
        '
        Me.info.BackColor = System.Drawing.SystemColors.Control
        Me.info.FlatAppearance.BorderColor = System.Drawing.Color.Peru
        Me.info.FlatAppearance.BorderSize = 3
        Me.info.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.info.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.info.ForeColor = System.Drawing.Color.Black
        Me.info.Location = New System.Drawing.Point(286, 166)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(76, 54)
        Me.info.TabIndex = 3
        Me.info.Text = "i"
        Me.info.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.info.UseVisualStyleBackColor = False
        '
        'help
        '
        Me.help.BackColor = System.Drawing.SystemColors.Control
        Me.help.FlatAppearance.BorderColor = System.Drawing.Color.Peru
        Me.help.FlatAppearance.BorderSize = 3
        Me.help.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.help.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.help.ForeColor = System.Drawing.Color.Black
        Me.help.Location = New System.Drawing.Point(206, 166)
        Me.help.Name = "help"
        Me.help.Size = New System.Drawing.Size(74, 54)
        Me.help.TabIndex = 2
        Me.help.Text = "?"
        Me.help.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.help.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'time
        '
        Me.time.AutoSize = True
        Me.time.Font = New System.Drawing.Font("Consolas", 19.0!)
        Me.time.Location = New System.Drawing.Point(475, 191)
        Me.time.Name = "time"
        Me.time.Size = New System.Drawing.Size(84, 31)
        Me.time.TabIndex = 9
        Me.time.Text = "--:--"
        '
        'opsi3
        '
        Me.opsi3.AutoSize = True
        Me.opsi3.BackColor = System.Drawing.SystemColors.Control
        Me.opsi3.Font = New System.Drawing.Font("Calibri", 18.0!)
        Me.opsi3.ForeColor = System.Drawing.Color.Black
        Me.opsi3.Location = New System.Drawing.Point(127, 15)
        Me.opsi3.Name = "opsi3"
        Me.opsi3.Size = New System.Drawing.Size(44, 33)
        Me.opsi3.TabIndex = 7
        Me.opsi3.Text = "&C"
        Me.opsi3.UseVisualStyleBackColor = False
        '
        'fn
        '
        Me.fn.BackColor = System.Drawing.SystemColors.Control
        Me.fn.FlatAppearance.BorderColor = System.Drawing.Color.Peru
        Me.fn.FlatAppearance.BorderSize = 3
        Me.fn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fn.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.fn.ForeColor = System.Drawing.Color.Black
        Me.fn.Location = New System.Drawing.Point(368, 166)
        Me.fn.Name = "fn"
        Me.fn.Size = New System.Drawing.Size(76, 54)
        Me.fn.TabIndex = 4
        Me.fn.Text = "Aa"
        Me.fn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.fn.UseVisualStyleBackColor = False
        '
        'dt
        '
        Me.dt.Dock = System.Windows.Forms.DockStyle.Top
        Me.dt.Location = New System.Drawing.Point(0, 0)
        Me.dt.Maximum = 59
        Me.dt.Name = "dt"
        Me.dt.Size = New System.Drawing.Size(580, 2)
        Me.dt.TabIndex = 13
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'rekor
        '
        Me.rekor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rekor.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.rekor.Location = New System.Drawing.Point(31, 182)
        Me.rekor.Name = "rekor"
        Me.rekor.Size = New System.Drawing.Size(131, 38)
        Me.rekor.TabIndex = 14
        Me.rekor.Text = "Skor tinggi"
        Me.rekor.UseVisualStyleBackColor = True
        '
        'base
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 229)
        Me.Controls.Add(Me.rekor)
        Me.Controls.Add(Me.dt)
        Me.Controls.Add(Me.opsi3)
        Me.Controls.Add(Me.time)
        Me.Controls.Add(Me.opsi2)
        Me.Controls.Add(Me.teks)
        Me.Controls.Add(Me.info)
        Me.Controls.Add(Me.help)
        Me.Controls.Add(Me.opsi1)
        Me.Controls.Add(Me.play)
        Me.Controls.Add(Me.fn)
        Me.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.Name = "base"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Memuat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents play As Button
    Friend WithEvents opsi1 As RadioButton
    Friend WithEvents opsi2 As RadioButton
    Friend WithEvents teks As TextBox
    Friend WithEvents info As Button
    Friend WithEvents help As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents time As Label
    Friend WithEvents opsi3 As RadioButton
    Friend WithEvents fn As Button
    Friend WithEvents dt As ProgressBar
    Friend WithEvents Timer2 As Timer
    Friend WithEvents rekor As Button
End Class

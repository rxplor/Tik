<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HiSkor
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
        Me.info = New System.Windows.Forms.TextBox()
        Me.kotakGrup = New System.Windows.Forms.GroupBox()
        Me.k3 = New System.Windows.Forms.RadioButton()
        Me.k2 = New System.Windows.Forms.RadioButton()
        Me.k1 = New System.Windows.Forms.RadioButton()
        Me.tutup = New System.Windows.Forms.Button()
        Me.aturUlang = New System.Windows.Forms.Button()
        Me.kotakGrup.SuspendLayout()
        Me.SuspendLayout()
        '
        'info
        '
        Me.info.Font = New System.Drawing.Font("Consolas", 14.0!)
        Me.info.ForeColor = System.Drawing.Color.Black
        Me.info.Location = New System.Drawing.Point(145, 12)
        Me.info.MaxLength = 1024
        Me.info.Multiline = True
        Me.info.Name = "info"
        Me.info.ReadOnly = True
        Me.info.Size = New System.Drawing.Size(423, 205)
        Me.info.TabIndex = 0
        '
        'kotakGrup
        '
        Me.kotakGrup.Controls.Add(Me.k3)
        Me.kotakGrup.Controls.Add(Me.k2)
        Me.kotakGrup.Controls.Add(Me.k1)
        Me.kotakGrup.Location = New System.Drawing.Point(18, 7)
        Me.kotakGrup.Name = "kotakGrup"
        Me.kotakGrup.Size = New System.Drawing.Size(110, 137)
        Me.kotakGrup.TabIndex = 1
        Me.kotakGrup.TabStop = False
        Me.kotakGrup.Text = "Pilih mode"
        '
        'k3
        '
        Me.k3.AutoSize = True
        Me.k3.Location = New System.Drawing.Point(10, 95)
        Me.k3.Name = "k3"
        Me.k3.Size = New System.Drawing.Size(61, 27)
        Me.k3.TabIndex = 2
        Me.k3.TabStop = True
        Me.k3.Text = "Kila&t"
        Me.k3.UseVisualStyleBackColor = True
        '
        'k2
        '
        Me.k2.AutoSize = True
        Me.k2.Location = New System.Drawing.Point(10, 62)
        Me.k2.Name = "k2"
        Me.k2.Size = New System.Drawing.Size(74, 27)
        Me.k2.TabIndex = 1
        Me.k2.TabStop = True
        Me.k2.Text = "&Sintas"
        Me.k2.UseVisualStyleBackColor = True
        '
        'k1
        '
        Me.k1.AutoSize = True
        Me.k1.Location = New System.Drawing.Point(10, 29)
        Me.k1.Name = "k1"
        Me.k1.Size = New System.Drawing.Size(72, 27)
        Me.k1.TabIndex = 0
        Me.k1.TabStop = True
        Me.k1.Text = "&Klasik"
        Me.k1.UseVisualStyleBackColor = True
        '
        'tutup
        '
        Me.tutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tutup.Location = New System.Drawing.Point(18, 186)
        Me.tutup.Name = "tutup"
        Me.tutup.Size = New System.Drawing.Size(110, 33)
        Me.tutup.TabIndex = 2
        Me.tutup.Text = "Tutup"
        Me.tutup.UseVisualStyleBackColor = True
        '
        'aturUlang
        '
        Me.aturUlang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aturUlang.Location = New System.Drawing.Point(18, 149)
        Me.aturUlang.Name = "aturUlang"
        Me.aturUlang.Size = New System.Drawing.Size(110, 33)
        Me.aturUlang.TabIndex = 3
        Me.aturUlang.Text = "Reset"
        Me.aturUlang.UseVisualStyleBackColor = True
        '
        'HiSkor
        '
        Me.AcceptButton = Me.tutup
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 229)
        Me.Controls.Add(Me.aturUlang)
        Me.Controls.Add(Me.tutup)
        Me.Controls.Add(Me.kotakGrup)
        Me.Controls.Add(Me.info)
        Me.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "HiSkor"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Skor tinggi"
        Me.kotakGrup.ResumeLayout(False)
        Me.kotakGrup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents info As TextBox
    Friend WithEvents kotakGrup As GroupBox
    Friend WithEvents k3 As RadioButton
    Friend WithEvents k2 As RadioButton
    Friend WithEvents k1 As RadioButton
    Friend WithEvents tutup As Button
    Friend WithEvents aturUlang As Button
End Class

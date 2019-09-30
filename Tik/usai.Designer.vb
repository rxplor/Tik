<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usai
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usai))
        Me.lv = New System.Windows.Forms.Label()
        Me.warna0 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.warna1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.warna2 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.riw = New System.Windows.Forms.TextBox()
        Me.warna5 = New System.Windows.Forms.Panel()
        Me.warna3 = New System.Windows.Forms.Panel()
        Me.warna4 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lv
        '
        Me.lv.AutoSize = True
        Me.lv.Location = New System.Drawing.Point(22, 21)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(249, 23)
        Me.lv.TabIndex = 0
        Me.lv.Text = "[HASIL AKHIR]  Level: 1. Skor: 0"
        '
        'warna0
        '
        Me.warna0.AutoSize = True
        Me.warna0.BackColor = System.Drawing.Color.OrangeRed
        Me.warna0.Font = New System.Drawing.Font("Consolas", 14.0!)
        Me.warna0.Location = New System.Drawing.Point(2, 47)
        Me.warna0.Name = "warna0"
        Me.warna0.Size = New System.Drawing.Size(180, 22)
        Me.warna0.TabIndex = 3
        Me.warna0.Text = "    Statistik:   "
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.warna1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.lv)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(688, 72)
        Me.Panel1.TabIndex = 4
        '
        'warna1
        '
        Me.warna1.BackColor = System.Drawing.Color.Orange
        Me.warna1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.warna1.Location = New System.Drawing.Point(0, 68)
        Me.warna1.Name = "warna1"
        Me.warna1.Size = New System.Drawing.Size(488, 4)
        Me.warna1.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.warna2)
        Me.Panel3.Controls.Add(Me.warna0)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(488, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 72)
        Me.Panel3.TabIndex = 4
        '
        'warna2
        '
        Me.warna2.BackColor = System.Drawing.Color.Orange
        Me.warna2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.warna2.Location = New System.Drawing.Point(0, 68)
        Me.warna2.Name = "warna2"
        Me.warna2.Size = New System.Drawing.Size(200, 4)
        Me.warna2.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.riw)
        Me.Panel2.Controls.Add(Me.warna5)
        Me.Panel2.Controls.Add(Me.warna3)
        Me.Panel2.Controls.Add(Me.warna4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 72)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(688, 179)
        Me.Panel2.TabIndex = 5
        '
        'riw
        '
        Me.riw.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.riw.Dock = System.Windows.Forms.DockStyle.Fill
        Me.riw.Font = New System.Drawing.Font("Consolas", 13.0!)
        Me.riw.Location = New System.Drawing.Point(4, 0)
        Me.riw.Multiline = True
        Me.riw.Name = "riw"
        Me.riw.ReadOnly = True
        Me.riw.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.riw.Size = New System.Drawing.Size(680, 175)
        Me.riw.TabIndex = 10
        '
        'warna5
        '
        Me.warna5.BackColor = System.Drawing.Color.Orange
        Me.warna5.Dock = System.Windows.Forms.DockStyle.Left
        Me.warna5.Location = New System.Drawing.Point(0, 0)
        Me.warna5.Name = "warna5"
        Me.warna5.Size = New System.Drawing.Size(4, 175)
        Me.warna5.TabIndex = 9
        '
        'warna3
        '
        Me.warna3.BackColor = System.Drawing.Color.Orange
        Me.warna3.Dock = System.Windows.Forms.DockStyle.Right
        Me.warna3.Location = New System.Drawing.Point(684, 0)
        Me.warna3.Name = "warna3"
        Me.warna3.Size = New System.Drawing.Size(4, 175)
        Me.warna3.TabIndex = 8
        '
        'warna4
        '
        Me.warna4.BackColor = System.Drawing.Color.Orange
        Me.warna4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.warna4.Location = New System.Drawing.Point(0, 175)
        Me.warna4.Name = "warna4"
        Me.warna4.Size = New System.Drawing.Size(688, 4)
        Me.warna4.TabIndex = 7
        '
        'usai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 251)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MinimizeBox = False
        Me.Name = "usai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Permainan selesai"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lv As Label
    Friend WithEvents warna0 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents warna1 As Panel
    Friend WithEvents warna2 As Panel
    Friend WithEvents warna5 As Panel
    Friend WithEvents warna3 As Panel
    Friend WithEvents warna4 As Panel
    Friend WithEvents riw As TextBox
End Class

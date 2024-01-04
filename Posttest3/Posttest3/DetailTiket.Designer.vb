<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailTiket
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNoKursi = New System.Windows.Forms.TextBox()
        Me.txtJamTayang = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.txtHari = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtStudio = New System.Windows.Forms.TextBox()
        Me.txtJudul = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(149, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Detail Tiket"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtNoKursi)
        Me.GroupBox1.Controls.Add(Me.txtJamTayang)
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.txtJumlah)
        Me.GroupBox1.Controls.Add(Me.txtHari)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtStudio)
        Me.GroupBox1.Controls.Add(Me.txtJudul)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(482, 273)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detail"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Studio"
        '
        'txtNoKursi
        '
        Me.txtNoKursi.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.txtNoKursi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNoKursi.Enabled = False
        Me.txtNoKursi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoKursi.Location = New System.Drawing.Point(333, 163)
        Me.txtNoKursi.Name = "txtNoKursi"
        Me.txtNoKursi.Size = New System.Drawing.Size(124, 20)
        Me.txtNoKursi.TabIndex = 11
        '
        'txtJamTayang
        '
        Me.txtJamTayang.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.txtJamTayang.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtJamTayang.Enabled = False
        Me.txtJamTayang.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJamTayang.Location = New System.Drawing.Point(330, 124)
        Me.txtJamTayang.Name = "txtJamTayang"
        Me.txtJamTayang.Size = New System.Drawing.Size(108, 20)
        Me.txtJamTayang.TabIndex = 10
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(115, 213)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 9
        '
        'txtJumlah
        '
        Me.txtJumlah.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.txtJumlah.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtJumlah.Enabled = False
        Me.txtJumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJumlah.Location = New System.Drawing.Point(114, 160)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(70, 20)
        Me.txtJumlah.TabIndex = 8
        '
        'txtHari
        '
        Me.txtHari.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.txtHari.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHari.Enabled = False
        Me.txtHari.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtHari.Location = New System.Drawing.Point(115, 125)
        Me.txtHari.Name = "txtHari"
        Me.txtHari.Size = New System.Drawing.Size(70, 19)
        Me.txtHari.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Total       :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(204, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Nomor Kursi    :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(204, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Jam Tayang    :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Jumlah     :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hari         :"
        '
        'txtStudio
        '
        Me.txtStudio.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.txtStudio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStudio.Enabled = False
        Me.txtStudio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudio.Location = New System.Drawing.Point(78, 83)
        Me.txtStudio.Name = "txtStudio"
        Me.txtStudio.Size = New System.Drawing.Size(47, 20)
        Me.txtStudio.TabIndex = 1
        '
        'txtJudul
        '
        Me.txtJudul.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.txtJudul.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtJudul.Enabled = False
        Me.txtJudul.Font = New System.Drawing.Font("ROG Fonts", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJudul.ForeColor = System.Drawing.Color.Black
        Me.txtJudul.Location = New System.Drawing.Point(22, 31)
        Me.txtJudul.Name = "txtJudul"
        Me.txtJudul.Size = New System.Drawing.Size(360, 33)
        Me.txtJudul.TabIndex = 0
        '
        'DetailTiket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(509, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DetailTiket"
        Me.Text = "DetailTiket"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtStudio As TextBox
    Friend WithEvents txtJamTayang As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents txtHari As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNoKursi As TextBox
    Friend WithEvents Label7 As Label
End Class

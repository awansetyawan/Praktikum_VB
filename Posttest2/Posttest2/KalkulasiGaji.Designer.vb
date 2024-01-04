<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KalkulasiGaji
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.txtGajiPokok = New System.Windows.Forms.TextBox()
        Me.txtHariKerja = New System.Windows.Forms.TextBox()
        Me.txtSakit = New System.Windows.Forms.TextBox()
        Me.txtTanpaKet = New System.Windows.Forms.TextBox()
        Me.txtIzin = New System.Windows.Forms.TextBox()
        Me.txtTunjangan = New System.Windows.Forms.TextBox()
        Me.txtGajiBersih = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.cbxBulan = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("ROG Fonts", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Sienna
        Me.Label1.Location = New System.Drawing.Point(261, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kalkulasi Gaji"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(73, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Gaji Pokok"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(73, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Bulan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(73, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Hari Kerja"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(73, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Sakit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(412, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tanpa Ket."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(412, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Izin"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(412, 164)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 18)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Tunjangan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(412, 207)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 18)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Gaji Bersih"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.Cornsilk
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(28, 308)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(743, 130)
        Me.ListView1.TabIndex = 9
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'txtGajiPokok
        '
        Me.txtGajiPokok.BackColor = System.Drawing.Color.Cornsilk
        Me.txtGajiPokok.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtGajiPokok.Location = New System.Drawing.Point(177, 68)
        Me.txtGajiPokok.Name = "txtGajiPokok"
        Me.txtGajiPokok.Size = New System.Drawing.Size(189, 22)
        Me.txtGajiPokok.TabIndex = 10
        '
        'txtHariKerja
        '
        Me.txtHariKerja.BackColor = System.Drawing.Color.Cornsilk
        Me.txtHariKerja.Enabled = False
        Me.txtHariKerja.Location = New System.Drawing.Point(177, 162)
        Me.txtHariKerja.Name = "txtHariKerja"
        Me.txtHariKerja.Size = New System.Drawing.Size(189, 22)
        Me.txtHariKerja.TabIndex = 12
        '
        'txtSakit
        '
        Me.txtSakit.BackColor = System.Drawing.Color.Cornsilk
        Me.txtSakit.Location = New System.Drawing.Point(177, 205)
        Me.txtSakit.Name = "txtSakit"
        Me.txtSakit.Size = New System.Drawing.Size(189, 22)
        Me.txtSakit.TabIndex = 13
        '
        'txtTanpaKet
        '
        Me.txtTanpaKet.BackColor = System.Drawing.Color.Cornsilk
        Me.txtTanpaKet.Location = New System.Drawing.Point(516, 70)
        Me.txtTanpaKet.Name = "txtTanpaKet"
        Me.txtTanpaKet.Size = New System.Drawing.Size(189, 22)
        Me.txtTanpaKet.TabIndex = 14
        '
        'txtIzin
        '
        Me.txtIzin.BackColor = System.Drawing.Color.Cornsilk
        Me.txtIzin.Location = New System.Drawing.Point(516, 118)
        Me.txtIzin.Name = "txtIzin"
        Me.txtIzin.Size = New System.Drawing.Size(189, 22)
        Me.txtIzin.TabIndex = 15
        '
        'txtTunjangan
        '
        Me.txtTunjangan.BackColor = System.Drawing.Color.Cornsilk
        Me.txtTunjangan.Enabled = False
        Me.txtTunjangan.Location = New System.Drawing.Point(516, 164)
        Me.txtTunjangan.Name = "txtTunjangan"
        Me.txtTunjangan.Size = New System.Drawing.Size(189, 22)
        Me.txtTunjangan.TabIndex = 16
        '
        'txtGajiBersih
        '
        Me.txtGajiBersih.BackColor = System.Drawing.Color.Cornsilk
        Me.txtGajiBersih.Enabled = False
        Me.txtGajiBersih.Location = New System.Drawing.Point(516, 207)
        Me.txtGajiBersih.Name = "txtGajiBersih"
        Me.txtGajiBersih.Size = New System.Drawing.Size(189, 22)
        Me.txtGajiBersih.TabIndex = 17
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Sienna
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Bauhaus 93", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(227, 255)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 37)
        Me.btnAdd.TabIndex = 18
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Sienna
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Bauhaus 93", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(359, 255)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 37)
        Me.btnDelete.TabIndex = 19
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Sienna
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Bauhaus 93", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(487, 255)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 37)
        Me.btnExit.TabIndex = 20
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'cbxBulan
        '
        Me.cbxBulan.BackColor = System.Drawing.Color.Cornsilk
        Me.cbxBulan.FormattingEnabled = True
        Me.cbxBulan.Items.AddRange(New Object() {"Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember"})
        Me.cbxBulan.Location = New System.Drawing.Point(177, 116)
        Me.cbxBulan.Name = "cbxBulan"
        Me.cbxBulan.Size = New System.Drawing.Size(189, 24)
        Me.cbxBulan.TabIndex = 21
        '
        'KalkulasiGaji
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cbxBulan)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtGajiBersih)
        Me.Controls.Add(Me.txtTunjangan)
        Me.Controls.Add(Me.txtIzin)
        Me.Controls.Add(Me.txtTanpaKet)
        Me.Controls.Add(Me.txtSakit)
        Me.Controls.Add(Me.txtHariKerja)
        Me.Controls.Add(Me.txtGajiPokok)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "KalkulasiGaji"
        Me.Text = "KalkulasiGaji"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents txtGajiPokok As TextBox
    Friend WithEvents txtHariKerja As TextBox
    Friend WithEvents txtSakit As TextBox
    Friend WithEvents txtTanpaKet As TextBox
    Friend WithEvents txtIzin As TextBox
    Friend WithEvents txtTunjangan As TextBox
    Friend WithEvents txtGajiBersih As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents cbxBulan As ComboBox
End Class

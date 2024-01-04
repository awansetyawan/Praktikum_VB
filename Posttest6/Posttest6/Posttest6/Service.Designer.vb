<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Service
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Service))
        Me.txtMerek = New System.Windows.Forms.TextBox()
        Me.txtSeri = New System.Windows.Forms.TextBox()
        Me.txtIdService = New System.Windows.Forms.TextBox()
        Me.txtCustomer = New System.Windows.Forms.TextBox()
        Me.cbxKerusakan = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNoHp = New System.Windows.Forms.TextBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbxTeknisi = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtKeahlian = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtNoHpTeknisi = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtNamaTeknisi = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtMerek
        '
        Me.txtMerek.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtMerek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMerek.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMerek.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtMerek.Location = New System.Drawing.Point(118, 26)
        Me.txtMerek.Name = "txtMerek"
        Me.txtMerek.Size = New System.Drawing.Size(142, 27)
        Me.txtMerek.TabIndex = 0
        '
        'txtSeri
        '
        Me.txtSeri.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtSeri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSeri.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeri.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtSeri.Location = New System.Drawing.Point(396, 25)
        Me.txtSeri.Name = "txtSeri"
        Me.txtSeri.Size = New System.Drawing.Size(142, 27)
        Me.txtSeri.TabIndex = 1
        '
        'txtIdService
        '
        Me.txtIdService.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtIdService.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdService.Enabled = False
        Me.txtIdService.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdService.ForeColor = System.Drawing.Color.Black
        Me.txtIdService.Location = New System.Drawing.Point(136, 130)
        Me.txtIdService.Name = "txtIdService"
        Me.txtIdService.Size = New System.Drawing.Size(59, 30)
        Me.txtIdService.TabIndex = 2
        Me.txtIdService.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCustomer
        '
        Me.txtCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txtCustomer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCustomer.Location = New System.Drawing.Point(115, 23)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(142, 27)
        Me.txtCustomer.TabIndex = 3
        '
        'cbxKerusakan
        '
        Me.cbxKerusakan.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.cbxKerusakan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxKerusakan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbxKerusakan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbxKerusakan.FormattingEnabled = True
        Me.cbxKerusakan.Items.AddRange(New Object() {"Hardware", "Software"})
        Me.cbxKerusakan.Location = New System.Drawing.Point(245, 357)
        Me.cbxKerusakan.Name = "cbxKerusakan"
        Me.cbxKerusakan.Size = New System.Drawing.Size(159, 24)
        Me.cbxKerusakan.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Adobe Gothic Std B", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(28, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ID Service -"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Adobe Gothic Std B", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(11, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Merek        :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Adobe Gothic Std B", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(305, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Seri      :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Adobe Gothic Std B", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(8, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 21)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Customer : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Adobe Gothic Std B", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(28, 358)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(186, 21)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Diagnosis Kerusakan  :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Adobe Gothic Std B", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(302, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 21)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "No HP : "
        '
        'txtNoHp
        '
        Me.txtNoHp.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtNoHp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoHp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txtNoHp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNoHp.Location = New System.Drawing.Point(393, 23)
        Me.txtNoHp.Name = "txtNoHp"
        Me.txtNoHp.Size = New System.Drawing.Size(142, 27)
        Me.txtNoHp.TabIndex = 11
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSimpan.Font = New System.Drawing.Font("Cooper Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSimpan.Location = New System.Drawing.Point(21, 427)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(92, 32)
        Me.btnSimpan.TabIndex = 13
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(884, 138)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(159, 22)
        Me.DateTimePicker1.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Adobe Gothic Std B", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(712, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 21)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Tanggal Service :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Stencil Std", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(373, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(328, 30)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Pengisian Data Service"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Stencil Std", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(483, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 30)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Laptop"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtSeri)
        Me.GroupBox1.Controls.Add(Me.txtMerek)
        Me.GroupBox1.Font = New System.Drawing.Font("Papyrus", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(17, 178)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(569, 70)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Laptop"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtNoHp)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtCustomer)
        Me.GroupBox2.Font = New System.Drawing.Font("Papyrus", 7.8!)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 267)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(565, 69)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Customer"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(-12, 70)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(1145, 38)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "---------------------------------------------------------------------------------" &
    "-------------"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(-8, 384)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(1121, 38)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "---------------------------------------------------------------------------------" &
    "-----------"
        '
        'btnTutup
        '
        Me.btnTutup.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTutup.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.btnTutup.Location = New System.Drawing.Point(978, 427)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(77, 32)
        Me.btnTutup.TabIndex = 23
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-5, -12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(965, -8)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(124, 98)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 26
        Me.PictureBox3.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Adobe Gothic Std B", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(10, 70)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(146, 21)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Teknisi                   :"
        '
        'cbxTeknisi
        '
        Me.cbxTeknisi.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.cbxTeknisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTeknisi.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbxTeknisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.cbxTeknisi.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbxTeknisi.FormattingEnabled = True
        Me.cbxTeknisi.Location = New System.Drawing.Point(121, 29)
        Me.cbxTeknisi.Name = "cbxTeknisi"
        Me.cbxTeknisi.Size = New System.Drawing.Size(159, 24)
        Me.cbxTeknisi.TabIndex = 28
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Adobe Gothic Std B", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(10, 110)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(143, 21)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Keahlian               :"
        '
        'txtKeahlian
        '
        Me.txtKeahlian.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtKeahlian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKeahlian.Enabled = False
        Me.txtKeahlian.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeahlian.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtKeahlian.Location = New System.Drawing.Point(184, 106)
        Me.txtKeahlian.Name = "txtKeahlian"
        Me.txtKeahlian.Size = New System.Drawing.Size(159, 27)
        Me.txtKeahlian.TabIndex = 8
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Adobe Gothic Std B", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(9, 149)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(139, 21)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "No Handphone  :"
        '
        'txtNoHpTeknisi
        '
        Me.txtNoHpTeknisi.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtNoHpTeknisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoHpTeknisi.Enabled = False
        Me.txtNoHpTeknisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoHpTeknisi.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNoHpTeknisi.Location = New System.Drawing.Point(184, 145)
        Me.txtNoHpTeknisi.Name = "txtNoHpTeknisi"
        Me.txtNoHpTeknisi.Size = New System.Drawing.Size(159, 27)
        Me.txtNoHpTeknisi.TabIndex = 31
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Adobe Gothic Std B", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(10, 31)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 21)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "ID Teknisi  -"
        '
        'txtNamaTeknisi
        '
        Me.txtNamaTeknisi.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtNamaTeknisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNamaTeknisi.Enabled = False
        Me.txtNamaTeknisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaTeknisi.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNamaTeknisi.Location = New System.Drawing.Point(184, 69)
        Me.txtNamaTeknisi.Name = "txtNamaTeknisi"
        Me.txtNamaTeknisi.Size = New System.Drawing.Size(159, 27)
        Me.txtNamaTeknisi.TabIndex = 33
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtNamaTeknisi)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txtNoHpTeknisi)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txtKeahlian)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.cbxTeknisi)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Font = New System.Drawing.Font("Papyrus", 7.8!)
        Me.GroupBox3.Location = New System.Drawing.Point(658, 178)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(369, 189)
        Me.GroupBox3.TabIndex = 34
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Data Teknisi"
        '
        'Service
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1087, 471)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxKerusakan)
        Me.Controls.Add(Me.txtIdService)
        Me.Name = "Service"
        Me.Text = "Service"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMerek As TextBox
    Friend WithEvents txtSeri As TextBox
    Friend WithEvents txtIdService As TextBox
    Friend WithEvents txtCustomer As TextBox
    Friend WithEvents cbxKerusakan As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNoHp As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnTutup As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cbxTeknisi As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtKeahlian As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtNoHpTeknisi As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtNamaTeknisi As TextBox
    Friend WithEvents GroupBox3 As GroupBox
End Class

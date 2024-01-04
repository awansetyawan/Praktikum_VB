<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Teknisi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Teknisi))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdTeknisi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNamaTeknisi = New System.Windows.Forms.TextBox()
        Me.cbxKeahlian = New System.Windows.Forms.ComboBox()
        Me.txtNoHpTeknisi = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.dgTeknisi = New System.Windows.Forms.DataGridView()
        Me.btnSimpanTeknisi = New System.Windows.Forms.Button()
        Me.btnUpdateTeknisi = New System.Windows.Forms.Button()
        Me.btnDeleteTeknisi = New System.Windows.Forms.Button()
        Me.btnTutupTeknisi = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgTeknisi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Stencil Std", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(459, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 30)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Laptop"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Stencil Std", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(355, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(326, 30)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Pengisian Data Teknisi"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(-23, 70)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(1145, 38)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "---------------------------------------------------------------------------------" &
    "-------------"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Adobe Gothic Std B", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(13, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 21)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "ID Teknisi -"
        '
        'txtIdTeknisi
        '
        Me.txtIdTeknisi.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtIdTeknisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdTeknisi.Enabled = False
        Me.txtIdTeknisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdTeknisi.ForeColor = System.Drawing.Color.Black
        Me.txtIdTeknisi.Location = New System.Drawing.Point(121, 127)
        Me.txtIdTeknisi.Name = "txtIdTeknisi"
        Me.txtIdTeknisi.Size = New System.Drawing.Size(59, 30)
        Me.txtIdTeknisi.TabIndex = 23
        Me.txtIdTeknisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Adobe Gothic Std B", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(13, 252)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Keahlian   :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Adobe Gothic Std B", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(14, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nama         :"
        '
        'txtNamaTeknisi
        '
        Me.txtNamaTeknisi.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtNamaTeknisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNamaTeknisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaTeknisi.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNamaTeknisi.Location = New System.Drawing.Point(121, 192)
        Me.txtNamaTeknisi.Name = "txtNamaTeknisi"
        Me.txtNamaTeknisi.Size = New System.Drawing.Size(159, 27)
        Me.txtNamaTeknisi.TabIndex = 0
        '
        'cbxKeahlian
        '
        Me.cbxKeahlian.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.cbxKeahlian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxKeahlian.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbxKeahlian.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbxKeahlian.FormattingEnabled = True
        Me.cbxKeahlian.Items.AddRange(New Object() {"Hardware", "Software"})
        Me.cbxKeahlian.Location = New System.Drawing.Point(121, 252)
        Me.cbxKeahlian.Name = "cbxKeahlian"
        Me.cbxKeahlian.Size = New System.Drawing.Size(159, 24)
        Me.cbxKeahlian.TabIndex = 27
        '
        'txtNoHpTeknisi
        '
        Me.txtNoHpTeknisi.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtNoHpTeknisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoHpTeknisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txtNoHpTeknisi.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNoHpTeknisi.Location = New System.Drawing.Point(121, 313)
        Me.txtNoHpTeknisi.Name = "txtNoHpTeknisi"
        Me.txtNoHpTeknisi.Size = New System.Drawing.Size(159, 27)
        Me.txtNoHpTeknisi.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Adobe Gothic Std B", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(13, 315)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 21)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "No HP        : "
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(407, 111)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(666, 288)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'dgTeknisi
        '
        Me.dgTeknisi.AllowUserToAddRows = False
        Me.dgTeknisi.AllowUserToDeleteRows = False
        Me.dgTeknisi.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.dgTeknisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(139, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgTeknisi.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgTeknisi.Location = New System.Drawing.Point(441, 127)
        Me.dgTeknisi.Name = "dgTeknisi"
        Me.dgTeknisi.ReadOnly = True
        Me.dgTeknisi.RowHeadersWidth = 51
        Me.dgTeknisi.RowTemplate.Height = 24
        Me.dgTeknisi.Size = New System.Drawing.Size(599, 255)
        Me.dgTeknisi.TabIndex = 30
        '
        'btnSimpanTeknisi
        '
        Me.btnSimpanTeknisi.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnSimpanTeknisi.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSimpanTeknisi.Font = New System.Drawing.Font("Cooper Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpanTeknisi.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSimpanTeknisi.Location = New System.Drawing.Point(16, 377)
        Me.btnSimpanTeknisi.Name = "btnSimpanTeknisi"
        Me.btnSimpanTeknisi.Size = New System.Drawing.Size(92, 32)
        Me.btnSimpanTeknisi.TabIndex = 31
        Me.btnSimpanTeknisi.Text = "Simpan"
        Me.btnSimpanTeknisi.UseVisualStyleBackColor = False
        '
        'btnUpdateTeknisi
        '
        Me.btnUpdateTeknisi.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnUpdateTeknisi.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdateTeknisi.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.btnUpdateTeknisi.Location = New System.Drawing.Point(441, 414)
        Me.btnUpdateTeknisi.Name = "btnUpdateTeknisi"
        Me.btnUpdateTeknisi.Size = New System.Drawing.Size(84, 34)
        Me.btnUpdateTeknisi.TabIndex = 32
        Me.btnUpdateTeknisi.Text = "Update"
        Me.btnUpdateTeknisi.UseVisualStyleBackColor = False
        '
        'btnDeleteTeknisi
        '
        Me.btnDeleteTeknisi.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnDeleteTeknisi.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeleteTeknisi.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.btnDeleteTeknisi.Location = New System.Drawing.Point(571, 414)
        Me.btnDeleteTeknisi.Name = "btnDeleteTeknisi"
        Me.btnDeleteTeknisi.Size = New System.Drawing.Size(88, 34)
        Me.btnDeleteTeknisi.TabIndex = 33
        Me.btnDeleteTeknisi.Text = "Delete"
        Me.btnDeleteTeknisi.UseVisualStyleBackColor = False
        '
        'btnTutupTeknisi
        '
        Me.btnTutupTeknisi.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnTutupTeknisi.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTutupTeknisi.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.btnTutupTeknisi.Location = New System.Drawing.Point(995, 414)
        Me.btnTutupTeknisi.Name = "btnTutupTeknisi"
        Me.btnTutupTeknisi.Size = New System.Drawing.Size(78, 34)
        Me.btnTutupTeknisi.TabIndex = 34
        Me.btnTutupTeknisi.Text = "Tutup"
        Me.btnTutupTeknisi.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(-5, -10)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(113, 102)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 35
        Me.PictureBox4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(978, -6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 98)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'Teknisi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1087, 471)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.btnTutupTeknisi)
        Me.Controls.Add(Me.btnDeleteTeknisi)
        Me.Controls.Add(Me.btnUpdateTeknisi)
        Me.Controls.Add(Me.btnSimpanTeknisi)
        Me.Controls.Add(Me.dgTeknisi)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.txtNoHpTeknisi)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbxKeahlian)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNamaTeknisi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIdTeknisi)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Name = "Teknisi"
        Me.Text = "Teknisi"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgTeknisi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdTeknisi As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNamaTeknisi As TextBox
    Friend WithEvents cbxKeahlian As ComboBox
    Friend WithEvents txtNoHpTeknisi As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents dgTeknisi As DataGridView
    Friend WithEvents btnSimpanTeknisi As Button
    Friend WithEvents btnUpdateTeknisi As Button
    Friend WithEvents btnDeleteTeknisi As Button
    Friend WithEvents btnTutupTeknisi As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class

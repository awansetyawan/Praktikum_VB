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
        Me.btnLihatData = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.cbxKerusakan.Location = New System.Drawing.Point(895, 207)
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
        Me.Label5.Location = New System.Drawing.Point(678, 208)
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
        Me.btnSimpan.Location = New System.Drawing.Point(21, 415)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(92, 32)
        Me.btnSimpan.TabIndex = 13
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(895, 294)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(123, 22)
        Me.DateTimePicker1.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Adobe Gothic Std B", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(678, 295)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(181, 21)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Tanggal Service           :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Stencil Std", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(395, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(328, 30)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Pengisian Data Service"
        '
        'btnLihatData
        '
        Me.btnLihatData.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnLihatData.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLihatData.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.btnLihatData.Location = New System.Drawing.Point(137, 415)
        Me.btnLihatData.Name = "btnLihatData"
        Me.btnLihatData.Size = New System.Drawing.Size(132, 32)
        Me.btnLihatData.TabIndex = 17
        Me.btnLihatData.Text = "Lihat Data"
        Me.btnLihatData.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Stencil Std", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(505, 40)
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
        Me.Label11.Location = New System.Drawing.Point(-8, 357)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(1121, 38)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "---------------------------------------------------------------------------------" &
    "-----------"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.btnExit.Location = New System.Drawing.Point(978, 415)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 32)
        Me.btnExit.TabIndex = 23
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Service
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1087, 471)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnLihatData)
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
    Friend WithEvents btnLihatData As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnExit As Button
End Class

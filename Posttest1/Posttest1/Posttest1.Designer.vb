<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Posttest1
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
        Me.TextBox_SP = New System.Windows.Forms.TextBox()
        Me.TextBox_Hasil = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox_Dari = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox_Ke = New System.Windows.Forms.ComboBox()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.BtnKonversi = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox_SP
        '
        Me.TextBox_SP.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_SP.Location = New System.Drawing.Point(387, 127)
        Me.TextBox_SP.Name = "TextBox_SP"
        Me.TextBox_SP.Size = New System.Drawing.Size(147, 34)
        Me.TextBox_SP.TabIndex = 0
        '
        'TextBox_Hasil
        '
        Me.TextBox_Hasil.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Hasil.Location = New System.Drawing.Point(212, 372)
        Me.TextBox_Hasil.Name = "TextBox_Hasil"
        Me.TextBox_Hasil.Size = New System.Drawing.Size(147, 34)
        Me.TextBox_Hasil.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Masukkan Satuan Panjang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 373)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hasil Konversi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Silver
        Me.Label3.Font = New System.Drawing.Font("Snap ITC", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(204, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(397, 43)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Kalkulator Panjang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(124, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Dari"
        '
        'ComboBox_Dari
        '
        Me.ComboBox_Dari.FormattingEnabled = True
        Me.ComboBox_Dari.Items.AddRange(New Object() {"Km", "Hm", "Dam", "M", "Dm", "Cm", "Mm"})
        Me.ComboBox_Dari.Location = New System.Drawing.Point(235, 241)
        Me.ComboBox_Dari.Name = "ComboBox_Dari"
        Me.ComboBox_Dari.Size = New System.Drawing.Size(68, 24)
        Me.ComboBox_Dari.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(355, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Ke"
        '
        'ComboBox_Ke
        '
        Me.ComboBox_Ke.FormattingEnabled = True
        Me.ComboBox_Ke.Items.AddRange(New Object() {"Km", "Hm", "Dam", "M", "Dm", "Cm", "Mm"})
        Me.ComboBox_Ke.Location = New System.Drawing.Point(437, 240)
        Me.ComboBox_Ke.Name = "ComboBox_Ke"
        Me.ComboBox_Ke.Size = New System.Drawing.Size(68, 24)
        Me.ComboBox_Ke.TabIndex = 8
        '
        'BtnReset
        '
        Me.BtnReset.Font = New System.Drawing.Font("ROG Fonts", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.Location = New System.Drawing.Point(405, 372)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(113, 35)
        Me.BtnReset.TabIndex = 9
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'BtnKonversi
        '
        Me.BtnKonversi.Font = New System.Drawing.Font("ROG Fonts", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKonversi.Location = New System.Drawing.Point(564, 240)
        Me.BtnKonversi.Name = "BtnKonversi"
        Me.BtnKonversi.Size = New System.Drawing.Size(142, 25)
        Me.BtnKonversi.TabIndex = 10
        Me.BtnKonversi.Text = "Konversi"
        Me.BtnKonversi.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Papyrus", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(277, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(241, 28)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Dibuat Oleh : Awan - 002"
        '
        'Posttest1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnKonversi)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.ComboBox_Ke)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBox_Dari)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_Hasil)
        Me.Controls.Add(Me.TextBox_SP)
        Me.Name = "Posttest1"
        Me.Text = "Posttest1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_SP As TextBox
    Friend WithEvents TextBox_Hasil As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox_Dari As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox_Ke As ComboBox
    Friend WithEvents BtnReset As Button
    Friend WithEvents BtnKonversi As Button
    Friend WithEvents Label6 As Label
End Class

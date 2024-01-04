<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUtama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuUtama))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DataServiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuatDataServiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LihatDataServiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataTeknisiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManajemenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AkunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HapusAkunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Label1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataServiceToolStripMenuItem, Me.DataTeknisiToolStripMenuItem, Me.AkunToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1087, 26)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DataServiceToolStripMenuItem
        '
        Me.DataServiceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuatDataServiceToolStripMenuItem, Me.LihatDataServiceToolStripMenuItem})
        Me.DataServiceToolStripMenuItem.Enabled = False
        Me.DataServiceToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataServiceToolStripMenuItem.Name = "DataServiceToolStripMenuItem"
        Me.DataServiceToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.DataServiceToolStripMenuItem.Text = "Data Service"
        '
        'BuatDataServiceToolStripMenuItem
        '
        Me.BuatDataServiceToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BuatDataServiceToolStripMenuItem.Name = "BuatDataServiceToolStripMenuItem"
        Me.BuatDataServiceToolStripMenuItem.Size = New System.Drawing.Size(228, 26)
        Me.BuatDataServiceToolStripMenuItem.Text = "Buat Data Service"
        '
        'LihatDataServiceToolStripMenuItem
        '
        Me.LihatDataServiceToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.LihatDataServiceToolStripMenuItem.Name = "LihatDataServiceToolStripMenuItem"
        Me.LihatDataServiceToolStripMenuItem.Size = New System.Drawing.Size(228, 26)
        Me.LihatDataServiceToolStripMenuItem.Text = "Lihat Data Service"
        '
        'DataTeknisiToolStripMenuItem
        '
        Me.DataTeknisiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManajemenToolStripMenuItem})
        Me.DataTeknisiToolStripMenuItem.Enabled = False
        Me.DataTeknisiToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.DataTeknisiToolStripMenuItem.Name = "DataTeknisiToolStripMenuItem"
        Me.DataTeknisiToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.DataTeknisiToolStripMenuItem.Text = "Data Teknisi"
        '
        'ManajemenToolStripMenuItem
        '
        Me.ManajemenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.ManajemenToolStripMenuItem.Name = "ManajemenToolStripMenuItem"
        Me.ManajemenToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ManajemenToolStripMenuItem.Text = "Manajemen"
        '
        'AkunToolStripMenuItem
        '
        Me.AkunToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HapusAkunToolStripMenuItem})
        Me.AkunToolStripMenuItem.Enabled = False
        Me.AkunToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.AkunToolStripMenuItem.Name = "AkunToolStripMenuItem"
        Me.AkunToolStripMenuItem.Size = New System.Drawing.Size(59, 22)
        Me.AkunToolStripMenuItem.Text = "Akun"
        '
        'HapusAkunToolStripMenuItem
        '
        Me.HapusAkunToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.HapusAkunToolStripMenuItem.Name = "HapusAkunToolStripMenuItem"
        Me.HapusAkunToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.HapusAkunToolStripMenuItem.Text = "Hapus Akun"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Enabled = False
        Me.LogoutToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(73, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Label1, Me.Label2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 445)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1087, 26)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Label1
        '
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.Text = "Label2"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(361, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(294, 250)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Stencil Std", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(389, 296)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(229, 30)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "SELAMAT DATANG"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Stencil Std", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(347, 328)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(304, 30)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "DI PENDATAAN SERVICE"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-26, 282)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(187, 162)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(905, 31)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(187, 162)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 23
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(242, 304)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(75, 54)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 24
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(711, 304)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(75, 54)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 25
        Me.PictureBox5.TabStop = False
        '
        'MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1087, 471)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuUtama"
        Me.Text = "MenuUtama"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DataServiceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuatDataServiceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatDataServiceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AkunToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Label1 As ToolStripStatusLabel
    Friend WithEvents Label2 As ToolStripStatusLabel
    Friend WithEvents HapusAkunToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataTeknisiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManajemenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
End Class

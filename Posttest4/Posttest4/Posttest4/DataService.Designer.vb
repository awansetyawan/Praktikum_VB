<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DataService
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgService = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnTutup = New System.Windows.Forms.Button()
        CType(Me.dgService, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgService
        '
        Me.dgService.AllowUserToAddRows = False
        Me.dgService.AllowUserToDeleteRows = False
        Me.dgService.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.dgService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(139, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgService.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgService.Location = New System.Drawing.Point(12, 100)
        Me.dgService.Name = "dgService"
        Me.dgService.ReadOnly = True
        Me.dgService.RowHeadersWidth = 51
        Me.dgService.RowTemplate.Height = 24
        Me.dgService.Size = New System.Drawing.Size(1063, 276)
        Me.dgService.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Stencil Std", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(375, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data Service Laptop"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(-9, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(1109, 38)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "---------------------------------------------------------------------------------" &
    "----------"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-9, 379)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1109, 38)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "---------------------------------------------------------------------------------" &
    "----------"
        '
        'btnTutup
        '
        Me.btnTutup.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTutup.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.btnTutup.Location = New System.Drawing.Point(12, 420)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(78, 34)
        Me.btnTutup.TabIndex = 24
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = False
        '
        'DataService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1087, 471)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgService)
        Me.Name = "DataService"
        Me.Text = "DataService"
        CType(Me.dgService, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgService As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnTutup As Button
End Class

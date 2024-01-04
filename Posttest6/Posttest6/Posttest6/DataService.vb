Imports MySql.Data.MySqlClient

Public Class DataService
    Sub DesainGrid()
        dgService.Columns(0).Width = 80
        dgService.Columns(1).Width = 100
        dgService.Columns(2).Width = 100
        dgService.Columns(3).Width = 100
        dgService.Columns(4).Width = 100
        dgService.Columns(5).Width = 100
        dgService.Columns(6).Width = 100
        dgService.Columns(7).Width = 80

        dgService.Columns(0).HeaderText = "Id Service"
        dgService.Columns(1).HeaderText = "Merek Laptop"
        dgService.Columns(2).HeaderText = "Seri Laptop"
        dgService.Columns(3).HeaderText = "Customer"
        dgService.Columns(4).HeaderText = "Nomor Handphone"
        dgService.Columns(5).HeaderText = "Diagnosa Kerusakan"
        dgService.Columns(6).HeaderText = "Tanggal"
        dgService.Columns(7).HeaderText = "Id Teknisi"

        dgService.Columns(6).DefaultCellStyle.Format = "dd/MM/yyyy"
        dgService.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgService.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    End Sub

    Sub TampilData()
        DA = New MySqlDataAdapter("Select * From dataservice", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "dataservice")
        dgService.DataSource = DS.Tables("dataservice")
        dgService.Refresh()
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
        MenuUtama.Show()
    End Sub

    Private Sub txtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If

        If e.KeyChar = Chr(13) Then
            CMD = New MySqlCommand("Select * From dataservice where id like '%" & txtCari.Text & "%'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows Then

                DA = New MySqlDataAdapter("Select * From dataservice where id like '%" & txtCari.Text & "%'", CONN)
                DS = New DataSet
                RD.Close()
                DA.Fill(DS, "Ada")
                dgService.DataSource = DS.Tables("Ada")
                dgService.ReadOnly = True
            Else
                RD.Close()
                MessageBox.Show("Data Service Tidak Ditemukan")
            End If
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim NoID As String
        Dim RowIdx As Integer = -1

        NoID = InputBox("Pilih Nomor ID", "Pilih", 101)
        If NoID = "" Then
            MessageBox.Show("Data Batal Di Update")
        ElseIf Not IsNumeric(NoID) Then
            MessageBox.Show("Data Batal Di Update, Hanya Dapat Dimasukkan Angka")
        Else
            CMD = New MySqlCommand("Select * From dataservice where id like '%" & NoID & "%'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows = NoID Then
                RD.Close()

                For Each row As DataGridViewRow In dgService.Rows
                    If row.Cells(0).Value.ToString().Equals(NoID) Then
                        RowIdx = row.Index
                        UpdateForm.txtUpdateIdService.Text = dgService.Rows(RowIdx).Cells(0).Value
                        UpdateForm.txtUpdateMerek.Text = dgService.Rows(RowIdx).Cells(1).Value
                        UpdateForm.txtUpdateSeri.Text = dgService.Rows(RowIdx).Cells(2).Value
                        UpdateForm.txtUpdateCustomer.Text = dgService.Rows(RowIdx).Cells(3).Value
                        UpdateForm.txtUpdateNoHp.Text = dgService.Rows(RowIdx).Cells(4).Value
                        UpdateForm.cbxUpdateKerusakan.Text = dgService.Rows(RowIdx).Cells(5).Value
                        UpdateForm.DateTimePickerUpdate.Text = dgService.Rows(RowIdx).Cells(6).Value
                        UpdateForm.TambahTeknisi()
                        UpdateForm.cbxUpdateTeknisi.Text = dgService.Rows(RowIdx).Cells(7).Value
                        UpdateForm.txtUpdateMerek.Select()
                        Me.Hide()
                        UpdateForm.Show()
                    End If
                Next

            Else
                RD.Close()
                MessageBox.Show("ID Tidak Ditemukan")
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim NoID As String

        NoID = InputBox("Pilih Nomor ID", "Pilih", 101)

        If NoID = "" Then
            MessageBox.Show("Data Batal Di Hapus")
        ElseIf Not IsNumeric(NoID) Then
            MessageBox.Show("Data Batal Di Hapus, Hanya Dapat Dimasukkan Angka")
        Else
            CMD = New MySqlCommand("Select * From dataservice where id like '%" & NoID & "%'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows = NoID Then
                RD.Close()
                If MessageBox.Show("Yakin akan menghapus Data Service ? " & NoID & " ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    CMD = New MySqlCommand("Delete From dataservice Where id = '" & NoID & "'", CONN)
                    CMD.ExecuteNonQuery()
                    Call TampilData()
                    Call DesainGrid()
                Else
                    MessageBox.Show("Data Batal Di Hapus")
                End If
            Else
                RD.Close()
                MessageBox.Show("ID Tidak Ditemukan")
            End If
        End If
    End Sub

End Class
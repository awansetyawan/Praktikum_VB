Public Class KalkulasiGaji
    Private Sub KalkulasiGaji_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnDelete.Enabled = False

        Call Clear()

        ListView1.GridLines = True
        ListView1.View = View.Details
        ListView1.Columns.Add("No")
        ListView1.Columns.Add("Gaji Pokok")
        ListView1.Columns.Add("Bulan")
        ListView1.Columns.Add("Hari Kerja")
        ListView1.Columns.Add("Sakit")
        ListView1.Columns.Add("Tanpa Keterangan")
        ListView1.Columns.Add("Izin")
        ListView1.Columns.Add("Tunjangan")
        ListView1.Columns.Add("Gaji Bersih")
    End Sub

    Private Sub cbxBulan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxBulan.SelectedIndexChanged
        Call Bulan()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Call CekData()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ListView1.Items.Clear()

        txtGajiPokok.Focus()

        btnDelete.Enabled = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim Tutup As String

        Tutup = MessageBox.Show("Tutup form ini ?", "Konfirmasi",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Tutup = MsgBoxResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub

    Private Function Bulan()
        Dim HariKerja As Integer
        Bulan = cbxBulan.Text
        HariKerja = Val(txtHariKerja.Text)

        If Bulan = "Januari" Then
            HariKerja = 31 - 4
        ElseIf Bulan = "Februari" Then
            HariKerja = 28 - 4
        ElseIf Bulan = "Maret" Then
            HariKerja = 31 - 4
        ElseIf Bulan = "April" Then
            HariKerja = 30 - 4
        ElseIf Bulan = "Mei" Then
            HariKerja = 31 - 4
        ElseIf Bulan = "Juni" Then
            HariKerja = 30 - 4
        ElseIf Bulan = "Juli" Then
            HariKerja = 31 - 4
        ElseIf Bulan = "Agustus" Then
            HariKerja = 31 - 4
        ElseIf Bulan = "September" Then
            HariKerja = 30 - 4
        ElseIf Bulan = "Oktober" Then
            HariKerja = 31 - 4
        ElseIf Bulan = "November" Then
            HariKerja = 30 - 4
        ElseIf Bulan = "Desember" Then
            HariKerja = 31 - 4
        End If

        txtHariKerja.Text = HariKerja

        Return HariKerja

    End Function

    Private Function HitungTunjangan()
        Dim HariKerja, Sakit, Ijin, TanpaKet, Tunjangan As Integer
        HariKerja = Bulan()
        Sakit = Val(txtSakit.Text)
        Ijin = Val(txtIzin.Text)
        TanpaKet = Val(txtTanpaKet.Text)

        Tunjangan = ((HariKerja * 50000) - (Sakit * 20000) - (Ijin * 5000) - (TanpaKet * 30000))

        txtTunjangan.Text = Tunjangan

        Return Tunjangan
    End Function

    Private Function GajiPokok()
        Dim Gaji, Tunjangan, Hasil As Integer

        Gaji = Val(txtGajiPokok.Text)
        Tunjangan = HitungTunjangan()

        Hasil = Gaji + Tunjangan

        txtGajiBersih.Text = Hasil

        Return Hasil
    End Function

    Sub CekData()
        Dim Arr(9) As String
        Dim listitem As ListViewItem
        Dim Index As Integer

        Index = 0

        If txtGajiPokok.Text = "" Then
            MessageBox.Show("Gaji Pokok Harus Diisi!", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtGajiPokok.Focus()
        ElseIf cbxBulan.Text = "" Then
            MessageBox.Show("Masukkan Salah Satu Bulan!", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbxBulan.Focus()
        ElseIf txtSakit.Text = "" Then
            MessageBox.Show("Masukkan Jumlah Sakit (Jika tidak ada isi 0)!", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSakit.Focus()
        ElseIf txtTanpaKet.Text = "" Then
            MessageBox.Show("Masukkan Jumlah Tanpa Keterangan (Jika tidak ada isi 0)!", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTanpaKet.Focus()
        ElseIf txtIzin.Text = "" Then
            MessageBox.Show("Masukkan Jumlah Izin (Jika tidak ada isi 0)!", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtIzin.Focus()
        Else
            Call HitungTunjangan()
            Call GajiPokok()

            Index = ListView1.Items.Count + 1

            Arr(0) = Val(Index)
            Arr(1) = txtGajiPokok.Text
            Arr(2) = cbxBulan.Text
            Arr(3) = txtHariKerja.Text
            Arr(4) = txtSakit.Text
            Arr(5) = txtTanpaKet.Text
            Arr(6) = txtIzin.Text
            Arr(7) = txtTunjangan.Text
            Arr(8) = txtGajiBersih.Text

            listitem = New ListViewItem

            listitem = ListView1.Items.Add(Arr(0))
            listitem.SubItems.Add(Arr(1))
            listitem.SubItems.Add(Arr(2))
            listitem.SubItems.Add(Arr(3))
            listitem.SubItems.Add(Arr(4))
            listitem.SubItems.Add(Arr(5))
            listitem.SubItems.Add(Arr(6))
            listitem.SubItems.Add(Arr(7))
            listitem.SubItems.Add(Arr(8))
            Index = Val(Index + 1)

            If ListView1.Items.Count > 0 Then
                btnDelete.Enabled = True
            End If
        End If
    End Sub

    Sub Clear()
        txtGajiPokok.Select()
        txtGajiPokok.Text = ""
        cbxBulan.Text = ""
        txtHariKerja.Text = Val(0)
        txtSakit.Text = ""
        txtTanpaKet.Text = ""
        txtIzin.Text = ""
        txtTunjangan.Text = Val(0)
        txtGajiBersih.Text = Val(0)
    End Sub

    Private Sub txtGajiPokok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGajiPokok.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cbxBulan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxBulan.KeyPress
        If Not ((e.KeyChar >= "A" And e.KeyChar <= "Z") Or (e.KeyChar >= "a" And e.KeyChar <= "z") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSakit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSakit.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTanpaKet_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTanpaKet.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtIzin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIzin.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub
End Class

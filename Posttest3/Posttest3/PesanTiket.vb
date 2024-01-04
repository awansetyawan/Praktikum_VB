Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ListView

Public Class PesanTiket

    Sub PesanTiket()
        Dim Detail As New DetailTiket
        Dim Total = NilaiTotal()

        'Judul'
        If cbxJudulFilm.SelectedItem = "Venom" Then
            Detail.txtJudul.Text = cbxJudulFilm.Text
        ElseIf cbxJudulFilm.SelectedItem = "Mortal Kombat" Then
            Detail.txtJudul.Text = cbxJudulFilm.Text
        ElseIf cbxJudulFilm.SelectedItem = "Ghost Rider" Then
            Detail.txtJudul.Text = cbxJudulFilm.Text
        ElseIf cbxJudulFilm.SelectedItem = "Bloodshot" Then
            Detail.txtJudul.Text = cbxJudulFilm.Text
        End If

        'Studio' 
        If txtStudio.Text = "1" Then
            Detail.txtStudio.Text = txtStudio.Text
        ElseIf txtStudio.Text = "2" Then
            Detail.txtStudio.Text = txtStudio.Text
        ElseIf txtStudio.Text = "3" Then
            Detail.txtStudio.Text = txtStudio.Text
        ElseIf txtStudio.Text = "4" Then
            Detail.txtStudio.Text = txtStudio.Text
        End If

        'Hari'
        If cbxHari.SelectedItem = "Senin" Then
            Detail.txtHari.Text = cbxHari.Text
        ElseIf cbxHari.SelectedItem = "Selasa" Then
            Detail.txtHari.Text = cbxHari.Text
        ElseIf cbxHari.SelectedItem = "Rabu" Then
            Detail.txtHari.Text = cbxHari.Text
        ElseIf cbxHari.SelectedItem = "Kamis" Then
            Detail.txtHari.Text = cbxHari.Text
        ElseIf cbxHari.SelectedItem = "Jumat" Then
            Detail.txtHari.Text = cbxHari.Text
        ElseIf cbxHari.SelectedItem = "Sabtu" Then
            Detail.txtHari.Text = cbxHari.Text
        ElseIf cbxHari.SelectedItem = "Minggu" Then
            Detail.txtHari.Text = cbxHari.Text
        End If

        'Jam Tayang'
        If rbJamPertama.Checked = True Then
            Detail.txtJamTayang.Text = rbJamPertama.Text
        ElseIf rbJamKedua.Checked = True Then
            Detail.txtJamTayang.Text = rbJamKedua.Text
        ElseIf rbJamKetiga.Checked = True Then
            Detail.txtJamTayang.Text = rbJamKetiga.Text
        End If

        'Jumlah'
        Detail.txtJumlah.Text = txtJumlah.Text

        'Nomor Kursi'
        For Each CheckBox In GroupBox2.Controls
            If CheckBox.Checked = True Then
                Detail.txtNoKursi.Text = CheckBox.Text + " " + Detail.txtNoKursi.Text
            End If
        Next

        'Total'
        Detail.txtTotal.Text = Total

        Detail.Show()
    End Sub

    Sub CekData()
        Dim Hitung = 0

        For Each CheckBox In GroupBox2.Controls
            If CheckBox.Checked = True Then
                Hitung += 1
            End If
        Next

        If cbxJudulFilm.Text = "" Then
            MessageBox.Show("Judul Film Harus Dipilih!", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbxJudulFilm.DroppedDown = True
        ElseIf cbxHari.Text = "" Then
            MessageBox.Show("Hari harus Dipilih!", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbxHari.DroppedDown = True
        ElseIf rbJamPertama.Checked = False And rbJamKedua.Checked = False And rbJamKetiga.Checked = False Then
            MessageBox.Show("Pilih Salah Satu Jam!", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtJumlah.Text = "" Then
            MessageBox.Show("Masukkan Jumlah Tiket!", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtJumlah.Focus()
        ElseIf Hitung <= 0 Then
            MessageBox.Show("Pilih Kursi!", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf Hitung < Val(txtJumlah.Text) Or Hitung > Val(txtJumlah.Text) Then
            MessageBox.Show("Sesuaikan Jumlah Kursi Dengan Tiket!", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            btnClear.Enabled = True
            Call PesanTiket()
        End If
    End Sub

    Sub Clear()
        cbxJudulFilm.SelectedIndex = -1
        txtStudio.Text = ""
        cbxHari.SelectedIndex = -1
        rbJamPertama.Checked = False
        rbJamKedua.Checked = False
        rbJamKetiga.Checked = False
        txtJumlah.Text = ""

        For Each CheckBox In GroupBox2.Controls
            CheckBox.Checked = False
        Next
    End Sub

    Private Function Studio()
        Dim LokasiStudio As Integer
        LokasiStudio = Val(txtStudio.Text)

        If cbxJudulFilm.Text = "Venom" Then
            LokasiStudio = 1
        ElseIf cbxJudulFilm.Text = "Mortal Kombat" Then
            LokasiStudio = 2
        ElseIf cbxJudulFilm.Text = "Ghost Rider" Then
            LokasiStudio = 3
        ElseIf cbxJudulFilm.Text = "Bloodshot" Then
            LokasiStudio = 4
        End If

        txtStudio.Text = LokasiStudio

        Return LokasiStudio
    End Function

    Private Function HargaTiket()
        Dim Harga As Integer

        If cbxHari.SelectedItem = "Senin" Then
            Harga = 35000
        ElseIf cbxHari.SelectedItem = "Selasa" Then
            Harga = 35000
        ElseIf cbxHari.SelectedItem = "Rabu" Then
            Harga = 35000
        ElseIf cbxHari.SelectedItem = "Kamis" Then
            Harga = 35000
        ElseIf cbxHari.SelectedItem = "Jumat" Then
            Harga = 45000
        ElseIf cbxHari.SelectedItem = "Sabtu" Then
            Harga = 55000
        ElseIf cbxHari.SelectedItem = "Minggu" Then
            Harga = 55000
        End If

        Return Harga
    End Function

    Private Function NilaiTotal()
        Dim Harga, Total, Jumlah As Integer

        Jumlah = Val(txtJumlah.Text)

        Harga = HargaTiket()
        Total = Harga * Jumlah

        Return Total
    End Function

    Private Sub PesanTiket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxJudulFilm.DroppedDown = True
        btnClear.Enabled = False
    End Sub

    Private Sub cbxJudulFilm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxJudulFilm.SelectedIndexChanged
        Call Studio()
    End Sub

    Private Sub btnPesan_Click(sender As Object, e As EventArgs) Handles btnPesan.Click
        Call CekData()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Call Clear()
        cbxJudulFilm.DroppedDown = True
        btnClear.Enabled = False
        btnPesan.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim Tutup As String
        Tutup = MessageBox.Show("Keluar dari Aplikasi ini ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Tutup = MsgBoxResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub

    Private Sub txtJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlah.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub
End Class

Imports MySql.Data.MySqlClient

Public Class Teknisi

    Sub Clear()
        txtNamaTeknisi.Clear()
        cbxKeahlian.SelectedIndex = -1
        txtNoHpTeknisi.Clear()
        txtNamaTeknisi.Select()
    End Sub

    Private Function CekData()
        Dim Cek = False
        If txtNamaTeknisi.Text = "" Then
            Cek = True
        ElseIf cbxKeahlian.Text = "" Then
            Cek = True
        ElseIf txtNoHpTeknisi.Text = "" Then
            Cek = True
        Else
            Cek = False
        End If

        Return Cek
    End Function

    Sub FocusText()
        If txtNamaTeknisi.Text = "" Then
            txtNamaTeknisi.Focus()
        ElseIf cbxKeahlian.Text = "" Then
            cbxKeahlian.DroppedDown = True
        ElseIf txtNoHpTeknisi.Text = "" Then
            txtNoHpTeknisi.Focus()
        End If
    End Sub

    Sub DesainGrid()
        dgTeknisi.Columns(0).Width = 80
        dgTeknisi.Columns(1).Width = 100
        dgTeknisi.Columns(2).Width = 100
        dgTeknisi.Columns(3).Width = 100

        dgTeknisi.Columns(0).HeaderText = "Id Teknisi"
        dgTeknisi.Columns(1).HeaderText = "Nama"
        dgTeknisi.Columns(2).HeaderText = "Keahlian"
        dgTeknisi.Columns(3).HeaderText = "Nomor Handphone"

        dgTeknisi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgTeknisi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    End Sub

    Sub TampilData()
        DA = New MySqlDataAdapter("Select * From datateknisi", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "datateknisi")
        dgTeknisi.DataSource = DS.Tables("datateknisi")
        dgTeknisi.Refresh()
    End Sub

    Private Function NoOtomatis() As Integer
        Dim IDTerakhir As Integer = 0
        Dim Query As String = "SELECT MAX(IdTeknisi) FROM datateknisi"
        Dim Command As MySqlCommand = New MySqlCommand(Query, CONN)

        Dim result As Object = Command.ExecuteScalar()
        If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
            IDTerakhir = Convert.ToInt32(result)
        End If

        Return IDTerakhir
    End Function

    Sub NoID()
        Dim ID As Integer

        Dim NewID As Integer = NoOtomatis()
        If NewID = 0 Then
            ID = 101
        Else
            ID = NewID + 1
        End If
        txtIdTeknisi.Text = ID
    End Sub

    Private Sub Teknisi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call NoID()
        Call TampilData()
        Call DesainGrid()
    End Sub

    Private Sub btnSimpanTeknisi_Click(sender As Object, e As EventArgs) Handles btnSimpanTeknisi.Click
        Dim Kosong As Boolean = CekData()

        If Kosong = True Then
            MessageBox.Show("Lengkapi Data Dahulu")
            Call FocusText()
            Exit Sub
        Else
            CMD = New MySqlCommand("Select * From datateknisi where IdTeknisi ='" & txtIdTeknisi.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            RD.Close()

            If Not RD.HasRows Then
                Dim Simpan As String = "insert into datateknisi(IdTeknisi, NamaTeknisi, Keahlian, NoHp) values (' " & txtIdTeknisi.Text & "','" & txtNamaTeknisi.Text & "','" & cbxKeahlian.Text & "','" & txtNoHpTeknisi.Text & "')"

                CMD = New MySqlCommand(Simpan, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data Teknisi Ditambahkan", MsgBoxStyle.Information, "Perhatian")
            End If
            Call TampilData()
            Call Clear()

            Call NoID()

            txtNamaTeknisi.Focus()
        End If
    End Sub

    Private Sub txtNoHpTeknisi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoHpTeknisi.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private ButtonUpdateIsClick As Boolean = False
    Private Sub btnUpdateTeknisi_Click(sender As Object, e As EventArgs) Handles btnUpdateTeknisi.Click

        If (ButtonUpdateIsClick = False) Then

            Dim NoID As String
            Dim RowIdx As Integer = -1

            NoID = InputBox("Pilih Nomor ID", "Pilih", 101)
            If NoID = "" Then
                MessageBox.Show("Data Batal Di Update")
            ElseIf Not IsNumeric(NoID) Then
                MessageBox.Show("Data Batal Di Update, Hanya Dapat Dimasukkan Angka")
            Else
                CMD = New MySqlCommand("Select * From datateknisi where IdTeknisi like '%" & NoID & "%'", CONN)
                RD = CMD.ExecuteReader
                RD.Read()

                If RD.HasRows = NoID Then
                    RD.Close()

                    For Each row As DataGridViewRow In dgTeknisi.Rows
                        If row.Cells(0).Value.ToString().Equals(NoID) Then
                            RowIdx = row.Index
                            txtIdTeknisi.Text = dgTeknisi.Rows(RowIdx).Cells(0).Value
                            txtNamaTeknisi.Text = dgTeknisi.Rows(RowIdx).Cells(1).Value
                            cbxKeahlian.Text = dgTeknisi.Rows(RowIdx).Cells(2).Value
                            txtNoHpTeknisi.Text = dgTeknisi.Rows(RowIdx).Cells(3).Value
                            txtIdTeknisi.Select()
                        End If
                    Next

                    btnUpdateTeknisi.Text = "Ok"
                    btnDeleteTeknisi.Enabled = False
                    ButtonUpdateIsClick = True
                Else
                    RD.Close()
                    MessageBox.Show("ID Tidak Ditemukan")
                End If
            End If
        Else
            Dim Kosong As Boolean = CekData()

            If Kosong = True Then
                MessageBox.Show("Lengkapi Data Dahulu")
                Call FocusText()
                Exit Sub
            Else
                Dim Update As String = "Update datateknisi set IdTeknisi = '" & txtIdTeknisi.Text & "', NamaTeknisi = '" & txtNamaTeknisi.Text & "', Keahlian = '" & cbxKeahlian.Text & "', NoHp = '" & txtNoHpTeknisi.Text & "' where IdTeknisi = '" & txtIdTeknisi.Text & "'"
                CMD = New MySqlCommand(Update, CONN)
                CMD.ExecuteNonQuery()
                MessageBox.Show("Data Telah Di Update", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Call TampilData()
                Call DesainGrid()

                btnUpdateTeknisi.Text = "Update"
                ButtonUpdateIsClick = False
                btnDeleteTeknisi.Enabled = True

                Call TampilData()
                Call Clear()

                Call NoID()

                txtNamaTeknisi.Focus()
            End If
        End If
    End Sub

    Private Sub btnDeleteTeknisi_Click(sender As Object, e As EventArgs) Handles btnDeleteTeknisi.Click
        Dim NoIDHapus As String

        NoIDHapus = InputBox("Pilih Nomor ID", "Pilih", 101)

        If NoIDHapus = "" Then
            MessageBox.Show("Data Batal Di Hapus")
        ElseIf Not IsNumeric(NoIDHapus) Then
            MessageBox.Show("Data Batal Di Hapus, Hanya Dapat Dimasukkan Angka")
        Else
            CMD = New MySqlCommand("Select * From datateknisi where IdTeknisi like '%" & NoIDHapus & "%'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows = NoIDHapus Then
                RD.Close()
                If MessageBox.Show("Yakin akan menghapus Data Teknisi ? " & NoIDHapus & " ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    CMD = New MySqlCommand("Delete From datateknisi Where IdTeknisi = '" & NoIDHapus & "'", CONN)
                    CMD.ExecuteNonQuery()
                    Call TampilData()
                    Call DesainGrid()
                    Call NoID()
                Else
                    MessageBox.Show("Data Batal Di Hapus")
                End If
            Else
                RD.Close()
                MessageBox.Show("ID Tidak Ditemukan")
            End If
        End If
    End Sub

    Private Sub btnTutupTeknisi_Click(sender As Object, e As EventArgs) Handles btnTutupTeknisi.Click
        Me.Close()
        MenuUtama.Show()
    End Sub
End Class
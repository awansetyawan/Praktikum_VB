Imports MySql.Data.MySqlClient

Public Class Service
    Sub Clear()
        txtMerek.Clear()
        txtSeri.Clear()
        txtCustomer.Clear()
        txtNoHp.Clear()
        cbxKerusakan.SelectedIndex = -1
        cbxTeknisi.SelectedIndex = -1
        txtNamaTeknisi.Clear()
        txtKeahlian.Clear()
        txtNoHpTeknisi.Clear()
        DateTimePicker1.CustomFormat = "dd-MM-yyyy"
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Value = DateTime.Today
        txtMerek.Select()
    End Sub

    Sub TambahTeknisi()
        CMD = New MySqlCommand("Select IdTeknisi From datateknisi", CONN)
        RD = CMD.ExecuteReader
        Do While RD.Read
            cbxTeknisi.Items.Add(RD.Item(0))
        Loop
        RD.Close()
    End Sub

    Private Function CekData()
        Dim Cek = False
        If txtMerek.Text = "" Then
            Cek = True
        ElseIf txtSeri.Text = "" Then
            Cek = True
        ElseIf txtCustomer.Text = "" Then
            Cek = True
        ElseIf txtNoHp.Text = "" Then
            Cek = True
        ElseIf cbxKerusakan.Text = "" Then
            Cek = True
        ElseIf cbxTeknisi.Text = "" Then
            Cek = True
        Else
            Cek = False
        End If

        Return Cek
    End Function

    Sub FocusText()
        If txtMerek.Text = "" Then
            txtMerek.Focus()
        ElseIf txtSeri.Text = "" Then
            txtSeri.Focus()
        ElseIf txtCustomer.Text = "" Then
            txtCustomer.Focus()
        ElseIf txtNoHp.Text = "" Then
            txtNoHp.Focus()
        ElseIf cbxKerusakan.Text = "" Then
            cbxKerusakan.DroppedDown = True
        ElseIf cbxTeknisi.Text = "" Then
            cbxTeknisi.DroppedDown = True
        End If
    End Sub

    Private Function NoOtomatis() As Integer
        Dim IDTerakhir As Integer = 0
        Dim Query As String = "SELECT MAX(id) FROM dataservice"
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
        txtIdService.Text = ID
    End Sub

    Private Sub Service_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call NoID()
        Call TambahTeknisi()
        Call Clear()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim Kosong As Boolean = CekData()

        If Kosong = True Then
            MessageBox.Show("Lengkapi Data Dahulu")
            Call FocusText()
            Exit Sub
        Else
            CMD = New MySqlCommand("Select * From dataservice where id ='" & txtIdService.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            RD.Close()

            If Not RD.HasRows Then
                Dim Simpan As String = "insert into dataservice(id, merek, seri, customer, nohp, kerusakan, tanggal, IdTeknisi) values (' " & txtIdService.Text & "','" & txtMerek.Text & "','" & txtSeri.Text & "','" & txtCustomer.Text & "','" & txtNoHp.Text & "','" & cbxKerusakan.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & cbxTeknisi.Text & "')"

                CMD = New MySqlCommand(Simpan, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data Service Ditambahkan", MsgBoxStyle.Information, "Perhatian")
            End If
            Call DataService.TampilData()
            Call Clear()

            Call NoID()

            txtMerek.Focus()
        End If
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
        MenuUtama.Show()
    End Sub

    Private Sub txtNoHp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoHp.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cbxTeknisi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTeknisi.SelectedIndexChanged
        CMD = New MySqlCommand("Select * From datateknisi where IdTeknisi ='" & cbxTeknisi.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()

        If RD.HasRows = True Then
            txtNamaTeknisi.Text = RD.Item(1)
            txtKeahlian.Text = RD.Item(2)
            txtNoHpTeknisi.Text = RD.Item(3)
        End If
        RD.Close()
    End Sub
End Class

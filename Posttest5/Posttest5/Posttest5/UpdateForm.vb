Imports MySql.Data.MySqlClient

Public Class UpdateForm
    Private Function CekDataUpdate()
        Dim Cek = False

        If txtUpdateMerek.Text = "" Then
            Cek = True
        ElseIf txtUpdateSeri.Text = "" Then
            Cek = True
        ElseIf txtUpdateCustomer.Text = "" Then
            Cek = True
        ElseIf txtUpdateNoHp.Text = "" Then
            Cek = True
        ElseIf cbxUpdateKerusakan.Text = "" Then
            Cek = True
        Else
            Cek = False
        End If

        Return Cek
    End Function

    Sub FocusTextUpdate()
        If txtUpdateMerek.Text = "" Then
            txtUpdateMerek.Focus()
        ElseIf txtUpdateSeri.Text = "" Then
            txtUpdateSeri.Focus()
        ElseIf txtUpdateCustomer.Text = "" Then
            txtUpdateCustomer.Focus()
        ElseIf txtUpdateNoHp.Text = "" Then
            txtUpdateNoHp.Focus()
        ElseIf cbxUpdateKerusakan.Text = "" Then
            cbxUpdateKerusakan.DroppedDown = True
        End If
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim Kosong As Boolean = CekDataUpdate()

        If Kosong = True Then
            MessageBox.Show("Lengkapi Data Dahulu")
            Call FocusTextUpdate()
            Exit Sub
        Else
            Dim Update As String = "Update dataservice set id = '" & txtUpdateIdService.Text & "', merek = '" & txtUpdateMerek.Text & "', seri = '" & txtUpdateSeri.Text & "', customer = '" & txtUpdateCustomer.Text & "', nohp = '" & txtUpdateNoHp.Text & "', kerusakan = '" & cbxUpdateKerusakan.Text & "', tanggal = '" & Format(DateTimePickerUpdate.Value, "yyyy-MM-dd") & "' where id = '" & txtUpdateIdService.Text & "'"
            CMD = New MySqlCommand(Update, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data Telah Di Update", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()
            Call DataService.TampilData()
            Call DataService.DesainGrid()
            DataService.Show()
        End If

    End Sub

    Private Sub txtUpdateNoHp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUpdateNoHp.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
        Call DataService.TampilData()
        Call DataService.DesainGrid()
        DataService.Show()
    End Sub

    Private Sub UpdateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePickerUpdate.CustomFormat = "dd-MM-yyyy"
        DateTimePickerUpdate.Format = DateTimePickerFormat.Custom
    End Sub
End Class
Imports MySql.Data.MySqlClient

Public Class MenuUtama
    Private Sub BuatDataServiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuatDataServiceToolStripMenuItem.Click
        Me.Hide()
        Service.Show()
    End Sub

    Private Sub LihatDataServiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatDataServiceToolStripMenuItem.Click
        Me.Hide()
        Call Koneksi()
        Call DataService.TampilData()
        Call DataService.DesainGrid()
        DataService.Show()
    End Sub

    Private Sub ManajemenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManajemenToolStripMenuItem.Click
        Me.Hide()
        Teknisi.Show()
    End Sub

    Private Sub HapusAkunToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HapusAkunToolStripMenuItem.Click
        Call Koneksi()
        CMD = New MySqlCommand("Select * From dataakun where Username='" & Login.txtUserLogin.Text & "' and Password='" & Login.txtPassLogin.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()

        Dim ID As String = RD.GetString(0)
        RD.Close()
        If MessageBox.Show("Yakin akan menghapus Akun ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            CMD = New MySqlCommand("Delete From dataakun Where KodeUser = '" & ID & "'", CONN)
            CMD.ExecuteNonQuery()

            Me.Close()
            Login.txtUserLogin.Text = ""
            Login.txtPassLogin.Text = ""
            Login.Show()
        Else
            MessageBox.Show("Akun Batal Di Hapus")
        End If
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        Login.txtUserLogin.Text = ""
        Login.txtPassLogin.Text = ""
        Login.txtUserLogin.Select()
        Login.Show()
    End Sub
End Class
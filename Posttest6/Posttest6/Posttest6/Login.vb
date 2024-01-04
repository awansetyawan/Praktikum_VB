Imports MySql.Data.MySqlClient

Public Class Login

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
    End Sub

    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnDaftar.Click
        Me.Hide()
        Registrasi.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Call Koneksi()
        CMD = New MySqlCommand("Select * From dataakun where Username='" & txtUserLogin.Text & "' and Password='" & txtPassLogin.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()

        If RD.HasRows Then
            Me.Visible = False
            MenuUtama.Label1.Text = RD.GetString(3)
            MenuUtama.Label2.Text = RD.GetString(1)
            RD.Close()
            If MenuUtama.Label1.Text = "ADMIN" Then
                MenuUtama.DataServiceToolStripMenuItem.Enabled = True
                MenuUtama.DataTeknisiToolStripMenuItem.Enabled = True
                MenuUtama.LogoutToolStripMenuItem.Enabled = True
            ElseIf MenuUtama.Label1.Text = "KARYAWAN" Then
                MenuUtama.DataServiceToolStripMenuItem.Enabled = True
                MenuUtama.AkunToolStripMenuItem.Enabled = True
                MenuUtama.LogoutToolStripMenuItem.Enabled = True
            End If
            MenuUtama.Show()
        ElseIf Not RD.HasRows Then
            RD.Close()
            MessageBox.Show("Username atau Password Salah", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUserLogin.Focus()
            txtUserLogin.Text = ""
            txtPassLogin.Text = ""
        End If

    End Sub
End Class
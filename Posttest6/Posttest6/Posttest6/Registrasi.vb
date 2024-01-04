Imports MySql.Data.MySqlClient

Public Class Registrasi

    Private Function CekData()
        Dim Cek = False
        If txtDaftarUsername.Text = "" Then
            Cek = True
        ElseIf txtDaftarPassword.Text = "" Then
            Cek = True
        Else
            Cek = False
        End If

        Return Cek
    End Function

    Sub FocusText()
        If txtDaftarUsername.Text = "" Then
            txtDaftarUsername.Focus()
        ElseIf txtDaftarPassword.Text = "" Then
            txtDaftarPassword.Focus()
        End If
    End Sub
    Private Function NoOtomatis() As Integer
        Dim IDTerakhir As Integer = 0
        Dim Query As String = "SELECT MAX(KodeUser) FROM dataakun"
        Dim Command As MySqlCommand = New MySqlCommand(Query, CONN)

        Dim result As Object = Command.ExecuteScalar()
        If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
            IDTerakhir = Convert.ToInt32(result)
        End If

        Return IDTerakhir
    End Function

    Private Function NoID() As Integer
        Dim ID As Integer

        Dim NewID As Integer = NoOtomatis()
        If NewID = 0 Then
            ID = 1
        Else
            ID = NewID + 1
        End If

        Return ID
    End Function

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim Kosong As Boolean = CekData()
        Dim Nomor As Integer = NoID()
        Dim Status As String = "KARYAWAN"

        If Kosong = True Then
            MessageBox.Show("Lengkapi Data Dahulu")
            Call FocusText()
            Exit Sub
        Else
            CMD = New MySqlCommand("Select * From dataakun where KodeUser ='" & Nomor & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            RD.Close()

            If Not RD.HasRows Then
                Dim Simpan As String = "insert into dataakun(KodeUser, Username, Password, StatusUser) values (' " & Nomor & "','" & txtDaftarUsername.Text & "','" & txtDaftarPassword.Text & "', '" & Status & "')"

                CMD = New MySqlCommand(Simpan, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Akun Telah Didaftarkan", MsgBoxStyle.Information, "Perhatian")
            End If

            Me.Close()
            Login.Show()
        End If
    End Sub

    Private Sub Registrasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDaftarUsername.Select()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
        Login.Show()
    End Sub
End Class
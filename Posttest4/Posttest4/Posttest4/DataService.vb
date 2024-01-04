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

        dgService.Columns(0).HeaderText = "Id Service"
        dgService.Columns(1).HeaderText = "Merek Laptop"
        dgService.Columns(2).HeaderText = "Seri Laptop"
        dgService.Columns(3).HeaderText = "Customer"
        dgService.Columns(4).HeaderText = "Nomor Handphone"
        dgService.Columns(5).HeaderText = "Diagnosa Kerusakan"
        dgService.Columns(6).HeaderText = "Tanggal"

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
        Service.Show()
    End Sub
End Class
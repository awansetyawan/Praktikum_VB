Public Class Posttest1

    Private Sub BtnKonversi_Click(sender As Object, e As EventArgs) Handles BtnKonversi.Click
        Dim Masukkan As Double
        Dim nilai1 As Int64
        Dim nilai2 As Int64

        If ComboBox_Dari.Text = "Km" Then
            nilai1 = 1 * 10 ^ 6
        ElseIf ComboBox_Dari.Text = "Hm" Then
            nilai1 = 1 * 10 ^ 5
        ElseIf ComboBox_Dari.Text = "Dam" Then
            nilai1 = 1 * 10 ^ 4
        ElseIf ComboBox_Dari.Text = "M" Then
            nilai1 = 1 * 10 ^ 3
        ElseIf ComboBox_Dari.Text = "Dm" Then
            nilai1 = 1 * 10 ^ 2
        ElseIf ComboBox_Dari.Text = "Cm" Then
            nilai1 = 1 * 10
        ElseIf ComboBox_Dari.Text = "Mm" Then
            nilai1 = 1
        ElseIf ComboBox_Dari.Text = Nothing Then
            nilai1 = 0
        End If

        If ComboBox_Ke.Text = "Km" Then
            nilai2 = 1 * 10 ^ 6
        ElseIf ComboBox_Ke.Text = "Hm" Then
            nilai2 = 1 * 10 ^ 5
        ElseIf ComboBox_Ke.Text = "Dam" Then
            nilai2 = 1 * 10 ^ 4
        ElseIf ComboBox_Ke.Text = "M" Then
            nilai2 = 1 * 10 ^ 3
        ElseIf ComboBox_Ke.Text = "Dm" Then
            nilai2 = 1 * 10 ^ 2
        ElseIf ComboBox_Ke.Text = "Cm" Then
            nilai2 = 1 * 10
        ElseIf ComboBox_Ke.Text = "Mm" Then
            nilai2 = 1
        ElseIf ComboBox_Ke.Text = Nothing Then
            nilai2 = 0
        End If

        Masukkan = Val(TextBox_SP.Text)

        If Masukkan = Nothing Then
            TextBox_Hasil.Text = 0
        Else
            TextBox_Hasil.Text = (Masukkan * nilai1) / nilai2
        End If
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        TextBox_SP.Focus()

        TextBox_SP.Text = " "
        TextBox_Hasil.Text = " "
        ComboBox_Dari.Text = "Km"
        ComboBox_Ke.Text = "Km"
    End Sub

    Private Sub TextBox_SP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_SP.KeyPress

        'Fungsi Agar Hanya Dapat Memasukkan Angka Pada TextBox'
        If Not (((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Or e.KeyChar = ".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub Posttest1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ComboBox_Dari.Text = "Km"
        ComboBox_Ke.Text = "Km"
    End Sub
End Class

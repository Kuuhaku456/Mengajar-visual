Public Class Form_pertemuan_1
    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click

        Dim angka1 As Integer
        Dim angka2 As Integer
        Dim hasil As Integer

        angka1 = txt_angka1.Text
        angka2 = txt_angka2.Text

        hasil = angka1 + angka2

        txt_hasil.Text = hasil

        If hasil > 80 Then
            txt_ket.Text = "bagus"
        ElseIf hasil > 70 Then
            txt_ket.Text = "baik"
        ElseIf hasil > 50 Then
            txt_ket.Text = "so so"
        Else
            txt_ket.Text = "buruk"
        End If

    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_angka1.Clear()
        txt_angka2.Clear()
        txt_hasil.Clear()
        txt_ket.Clear()
    End Sub

    Private Sub Btn_tmbhs_Click(sender As Object, e As EventArgs) Handles Btn_tmbhs.Click
        Dim i As Integer
        i = 1
        For i = 1 To 10
            ListBox1.Items.Add(i)
        Next
    End Sub
End Class

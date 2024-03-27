Public Class form_lihat
    Private Sub BTN_KEMBALI_Click(sender As Object, e As EventArgs) Handles BTN_KEMBALI.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub form_lihat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txt_lihat.Text = Form1.txt_nama.Text
    End Sub
End Class
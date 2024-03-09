Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class form_crud
    Private Sub btn_lihat_Click(sender As Object, e As EventArgs) Handles btn_lihat.Click
        Dim displayForm As New form_lihat()
        displayForm.Show()
        Me.Hide()
    End Sub
    Private Sub cls()
        txt_genre.Clear()
        txt_judul_buku.Clear()
    End Sub
    Private Function cekDataKosong()
        If txt_judul_buku.Text = "" Then
            MessageBox.Show("Judul Buku kosong, wajib diisi!!!", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_judul_buku.Focus()
        ElseIf txt_genre.Text = "" Then
            MessageBox.Show("Genre Kosong, wajib diisi!!!", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_genre.Focus()
        Else
            Return True
        End If
        Return False
    End Function
    Private Function cekinputanhapusKosong()
        If txt_cari.Text = "" Then
            MessageBox.Show("Judul Buku kosong, wajib diisi!!!", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_cari.Focus()
        Else
            Return True
        End If
        Return False
    End Function

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        If cekDataKosong() = True Then
            If Index < 100 Then
                Dim Judul As String = txt_judul_buku.Text
                Dim Genre As String = txt_genre.Text
                bebas(1, Index) = Judul
                bebas(2, Index) = Genre
                Index += 1
                cls()
                MessageBox.Show("Data telah ditambah", "Info!!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Index Kelebihan, Kurangi!!!", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        Dim judul_hapus As String = txt_cari.Text
        Dim found As Boolean = False
        If cekinputanhapusKosong() = True Then
            For i As Integer = 0 To Index - 1
                If bebas(1, i) = judul_hapus Then
                    found = True
                    For j As Integer = i To Index - 2
                        bebas(1, j) = bebas(1, j + 1)
                        bebas(2, j) = bebas(2, j + 1)
                    Next
                    Index -= 1
                    MessageBox.Show("Data telah dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txt_cari.Clear()
                End If
            Next
            If Not found Then
                MessageBox.Show("Data tidak ditemukan. Silahkan masukkan Judul Buku yang benar.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txt_cari.Clear()
                txt_cari.Focus()
            End If
        End If
    End Sub
End Class

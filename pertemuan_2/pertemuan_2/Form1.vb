Public Class Form1
    Dim bebas(2, 100) As String
    Dim cek As Integer
    Dim var As Integer
    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        Dim nama As String
        Dim No_telepon As String

        nama = txt_nama.Text
        No_telepon = txt_no_telepon.Text

        bebas(0, cek) = nama
        bebas(1, cek) = No_telepon

        cek += 1

        For i = 0 To cek - 1
            DataGridView1.Rows.Add(bebas(0, i), bebas(1, i))
        Next
        cls()
    End Sub

    Private Sub cls()
        txt_nama.Clear()
        txt_no_telepon.Clear()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        bebas(0, var) = txt_nama.Text
        bebas(1, var) = txt_no_telepon.Text
        DataGridView1.Rows.Clear()
        For i = 0 To cek - 1
            DataGridView1.Rows.Add(bebas(0, i), bebas(1, i))
        Next
        cls()
    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        var = DataGridView1.CurrentCell.RowIndex
        txt_nama.Text = bebas(0, var)
        txt_no_telepon.Text = bebas(1, var)
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        If var >= 0 AndAlso var < cek Then
            For i As Integer = var To cek - 2
                For j As Integer = 0 To 1
                    bebas(j, i) = bebas(j, i + 1)
                Next
            Next

            cek -= 1

            DataGridView1.Rows.RemoveAt(var)
            cls()
        End If
    End Sub
End Class

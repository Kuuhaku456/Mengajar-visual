Public Class Form1



    Private Function cekDataKosong()
        If txt_nim.Text = "" Then
            MessageBox.Show("NIM kosong, wajib diisi!!!", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_nim.Focus()
        ElseIf TextBox2.Text = "" Then
            MessageBox.Show("Nama kosong, wajib diisi!!!", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox2.Focus()
        ElseIf TextBox3.Text = "" Then
            MessageBox.Show("Prodi kosong, wajib diisi!!!", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox3.Focus()
        Else
            Return True
        End If

        Return False
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Pertemuan 2"
        MyListView.View = View.Details
        MyListView.Columns.Add("No", 50, HorizontalAlignment.Center)
        MyListView.Columns.Add("NIM", 100, HorizontalAlignment.Center)
        MyListView.Columns.Add("Nama", 200, HorizontalAlignment.Center)
        MyListView.Columns.Add("Prodi", 200, HorizontalAlignment.Center)
        txt_nim.Focus()
    End Sub

    Private Sub nambah_data()
        MyListView.Items.Clear()
        For i As Integer = 0 To Index - 1
            Dim Item As New ListViewItem((i + 1).ToString())
            Item.SubItems.Add(bebas(1, i))
            Item.SubItems.Add(bebas(2, i))
            Item.SubItems.Add(bebas(3, i))
            MyListView.Items.Add(Item)
        Next
    End Sub
    Private Sub btn_add_MouseClick(sender As Object, e As MouseEventArgs) Handles btn_add.MouseClick
        If cekDataKosong() = True Then
            If Index < 100 Then
                Dim NIM As String = txt_nim.Text
                Dim Nama As String = TextBox2.Text
                Dim Prodi As String = TextBox3.Text

                bebas(1, Index) = NIM
                bebas(2, Index) = Nama
                bebas(3, Index) = Prodi

                Index += 1

                nambah_data()

                cls()
                MessageBox.Show("Data telah ditambah", "Info!!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Index Kelebihan, Kurangi!!!", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub MyListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MyListView.SelectedIndexChanged
        If MyListView.SelectedItems.Count > 0 Then
            txt_nim.Text = MyListView.SelectedItems(0).SubItems(1).Text
            TextBox2.Text = MyListView.SelectedItems(0).SubItems(2).Text
            TextBox3.Text = MyListView.SelectedItems(0).SubItems(3).Text
        End If
    End Sub

    Private Sub btn_update_MouseClick(sender As Object, e As MouseEventArgs) Handles btn_update.MouseClick
        If MyListView.SelectedItems.Count > 0 Then
            If cekDataKosong() = True Then
                Dim SelectedIndex As Integer = MyListView.SelectedIndices(0)
                Dim Nim_baru As String = txt_nim.Text
                Dim Nama_baru As String = TextBox2.Text
                Dim Prodi_baru As String = TextBox3.Text

                bebas(1, SelectedIndex) = Nim_baru
                bebas(2, SelectedIndex) = Nama_baru
                bebas(3, SelectedIndex) = Prodi_baru

                nambah_data()

                cls()
                MessageBox.Show("Data telah diupdate", "Info!!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Pilih data yang akan diedit, wajib!!!", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btn_delete_MouseClick(sender As Object, e As MouseEventArgs) Handles btn_delete.MouseClick
        If MyListView.SelectedItems.Count > 0 Then
            Dim ok As String
            ok = MessageBox.Show("Yakin mau hapus ???", "Info!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If ok = MsgBoxResult.Yes Then
                Dim SelectedIndex As Integer = MyListView.SelectedIndices(0)
                For i As Integer = SelectedIndex To Index - 2
                    bebas(1, i) = bebas(1, i + 1)
                    bebas(2, i) = bebas(2, i + 1)
                    bebas(3, i) = bebas(3, i + 1)
                Next
                Index -= 1
                nambah_data()
                MessageBox.Show("Data telah dihapus!!!", "Info!!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Pilih data yang akan dihapus!!!, wajib!!!", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Dim Keluar As String
        Keluar = MessageBox.Show("Yakin mau keluar ???", "Info!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Keluar = MsgBoxResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub


End Class

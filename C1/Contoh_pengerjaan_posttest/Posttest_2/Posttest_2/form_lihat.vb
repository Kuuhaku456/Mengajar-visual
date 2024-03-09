Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class form_lihat
    Private Sub form_lihat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyListView.Columns.Add("No", 50)
        MyListView.Columns.Add("JUDUL BUKU", 200)
        MyListView.Columns.Add("GENRE BUKU", 300)
        RefreshListView()
    End Sub
    Private Sub RefreshListView()
        MyListView.Items.Clear()
        For i As Integer = 0 To Index - 1
            Dim item As New ListViewItem((i + 1).ToString())
            item.SubItems.Add(bebas(1, i))
            item.SubItems.Add(bebas(2, i))
            MyListView.Items.Add(item)
        Next
    End Sub

    Private Sub btn_kembali_Click(sender As Object, e As EventArgs) Handles btn_kembali.Click
        Dim displayForm As New form_crud()
        displayForm.Show()
        Me.Hide()
    End Sub
End Class
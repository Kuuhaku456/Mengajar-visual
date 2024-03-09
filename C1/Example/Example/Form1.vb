Imports System.Runtime.ConstrainedExecution
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim bebas(3, 100) As String
    Dim index As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyListView.Columns.Add("No", 50, HorizontalAlignment.Center)
        MyListView.Columns.Add("Nim", 150, HorizontalAlignment.Center)
        MyListView.Columns.Add("Nama", 200, HorizontalAlignment.Center)
        MyListView.Columns.Add("Kelas", 200, HorizontalAlignment.Center)
    End Sub
    Private Sub RefreshListView()
        MyListView.Items.Clear()
        For i As Integer = 0 To index - 1
            Dim item As New ListViewItem((i + 1).ToString())
            item.SubItems.Add(bebas(1, i))
            item.SubItems.Add(bebas(2, i))
            item.SubItems.Add(bebas(3, i))
            MyListView.Items.Add(item)
        Next
    End Sub
    Private Sub cls()
        TXT_Kelas.Clear()
        TXT_Nama.Clear()
        TXT_NIM.Clear()
    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        If index < 100 Then
            Dim NIM As String = TXT_NIM.Text
            Dim nama As String = TXT_Nama.Text
            Dim Kelas As String = TXT_Kelas.Text
            bebas(1, index) = NIM
            bebas(2, index) = nama
            bebas(3, index) = Kelas
            index += 1
            RefreshListView()
            cls()
            MessageBox.Show("Data telah ditambahkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class

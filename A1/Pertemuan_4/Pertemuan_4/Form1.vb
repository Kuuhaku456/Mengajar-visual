Imports MySql.Data.MySqlClient

Public Class Form1
    Sub Kosong()
        txt_jenis.Clear()
        txt_kode.Clear()
        txt_jenis.Focus()
    End Sub
    Sub isi()
        txt_jenis.Clear()
        txt_jenis.Focus()
    End Sub
    Sub tampilJenis()
        DA = New MySqlDataAdapter("select * from tbjenis", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "jenis")
        DataGridView1.DataSource = DS.Tables("jenis")
        DataGridView1.Refresh()
    End Sub

    Sub aturGrid()
        DataGridView1.Columns(0).Width = 60
        DataGridView1.Columns(1).Width = 200
        DataGridView1.Columns(0).HeaderText = "Kode Jenis"
        DataGridView1.Columns(1).HeaderText = "Nama Jenis"
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampilJenis()
        Kosong()
        aturGrid()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txt_jenis.Text = Nothing And txt_kode.Text = Nothing Then
            MsgBox("Data Belum Lengkap")
            txt_kode.Focus()
        Else
            CMD = New MySqlCommand("Select * from tbjenis where kodeJenis ='" & txt_kode.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                RD.Close()
                CMD = New MySqlCommand("insert into tbjenis values('" & txt_kode.Text & "', '" & txt_jenis.Text & "')", CONN)
                CMD.ExecuteNonQuery()
                tampilJenis()
                Kosong()
                MsgBox("Simpan Data Sukses!")
                txt_kode.Focus()
            Else
                RD.Close()
                MsgBox("Data Tersebut Sudah Ada")
            End If
        End If
    End Sub
End Class

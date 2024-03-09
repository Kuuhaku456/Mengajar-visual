<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_crud
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        btn_tambah = New Button()
        Label2 = New Label()
        txt_genre = New TextBox()
        Label1 = New Label()
        txt_judul_buku = New TextBox()
        GroupBox2 = New GroupBox()
        btn_hapus = New Button()
        Label4 = New Label()
        txt_cari = New TextBox()
        btn_lihat = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.MenuHighlight
        GroupBox1.Controls.Add(btn_tambah)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txt_genre)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txt_judul_buku)
        GroupBox1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.AliceBlue
        GroupBox1.Location = New Point(41, 29)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(438, 237)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Nambah Buku"
        ' 
        ' btn_tambah
        ' 
        btn_tambah.ForeColor = Color.CadetBlue
        btn_tambah.Location = New Point(136, 155)
        btn_tambah.Name = "btn_tambah"
        btn_tambah.Size = New Size(121, 42)
        btn_tambah.TabIndex = 4
        btn_tambah.Text = "TAMBAH"
        btn_tambah.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(37, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 28)
        Label2.TabIndex = 3
        Label2.Text = "Genre"
        ' 
        ' txt_genre
        ' 
        txt_genre.Location = New Point(168, 96)
        txt_genre.Name = "txt_genre"
        txt_genre.Size = New Size(238, 34)
        txt_genre.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(28, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 28)
        Label1.TabIndex = 1
        Label1.Text = "Judul Buku"
        ' 
        ' txt_judul_buku
        ' 
        txt_judul_buku.Location = New Point(168, 33)
        txt_judul_buku.Name = "txt_judul_buku"
        txt_judul_buku.Size = New Size(238, 34)
        txt_judul_buku.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.MenuHighlight
        GroupBox2.Controls.Add(btn_hapus)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(txt_cari)
        GroupBox2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = Color.AliceBlue
        GroupBox2.Location = New Point(524, 29)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(438, 237)
        GroupBox2.TabIndex = 5
        GroupBox2.TabStop = False
        GroupBox2.Text = "Nambah Buku"
        ' 
        ' btn_hapus
        ' 
        btn_hapus.ForeColor = Color.CadetBlue
        btn_hapus.Location = New Point(168, 92)
        btn_hapus.Name = "btn_hapus"
        btn_hapus.Size = New Size(121, 42)
        btn_hapus.TabIndex = 4
        btn_hapus.Text = "HAPUS"
        btn_hapus.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(28, 36)
        Label4.Name = "Label4"
        Label4.Size = New Size(117, 28)
        Label4.TabIndex = 1
        Label4.Text = "Judul Buku"
        ' 
        ' txt_cari
        ' 
        txt_cari.Location = New Point(168, 33)
        txt_cari.Name = "txt_cari"
        txt_cari.Size = New Size(238, 34)
        txt_cari.TabIndex = 0
        ' 
        ' btn_lihat
        ' 
        btn_lihat.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_lihat.ForeColor = Color.CadetBlue
        btn_lihat.Location = New Point(427, 317)
        btn_lihat.Name = "btn_lihat"
        btn_lihat.Size = New Size(152, 43)
        btn_lihat.TabIndex = 5
        btn_lihat.Text = "LIHAT BUKU"
        btn_lihat.UseVisualStyleBackColor = True
        ' 
        ' form_crud
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1001, 405)
        Controls.Add(btn_lihat)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "form_crud"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CRUD BUKU"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_judul_buku As TextBox
    Friend WithEvents btn_tambah As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_genre As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_hapus As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_cari As TextBox
    Friend WithEvents btn_lihat As Button

End Class

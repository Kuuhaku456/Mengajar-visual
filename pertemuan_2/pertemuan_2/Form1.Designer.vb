<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        txt_nama = New TextBox()
        txt_no_telepon = New TextBox()
        btn_tambah = New Button()
        Label1 = New Label()
        Label2 = New Label()
        DataGridView1 = New DataGridView()
        col_nama = New DataGridViewTextBoxColumn()
        col_telepon = New DataGridViewTextBoxColumn()
        btn_edit = New Button()
        btn_hapus = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txt_nama
        ' 
        txt_nama.Location = New Point(165, 64)
        txt_nama.Name = "txt_nama"
        txt_nama.Size = New Size(188, 27)
        txt_nama.TabIndex = 0
        ' 
        ' txt_no_telepon
        ' 
        txt_no_telepon.Location = New Point(165, 150)
        txt_no_telepon.Name = "txt_no_telepon"
        txt_no_telepon.Size = New Size(187, 27)
        txt_no_telepon.TabIndex = 1
        ' 
        ' btn_tambah
        ' 
        btn_tambah.Font = New Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_tambah.Location = New Point(234, 210)
        btn_tambah.Name = "btn_tambah"
        btn_tambah.Size = New Size(118, 42)
        btn_tambah.TabIndex = 2
        btn_tambah.Text = "Tambah"
        btn_tambah.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(30, 71)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 4
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(30, 157)
        Label2.Name = "Label2"
        Label2.Size = New Size(111, 20)
        Label2.TabIndex = 5
        Label2.Text = "Nomor telepon"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {col_nama, col_telepon})
        DataGridView1.Location = New Point(421, 64)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(403, 217)
        DataGridView1.TabIndex = 6
        ' 
        ' col_nama
        ' 
        col_nama.Frozen = True
        col_nama.HeaderText = "Nama"
        col_nama.MinimumWidth = 6
        col_nama.Name = "col_nama"
        col_nama.ReadOnly = True
        col_nama.Resizable = DataGridViewTriState.False
        col_nama.Width = 200
        ' 
        ' col_telepon
        ' 
        col_telepon.HeaderText = "Nomor telepon"
        col_telepon.MinimumWidth = 6
        col_telepon.Name = "col_telepon"
        col_telepon.ReadOnly = True
        col_telepon.Resizable = DataGridViewTriState.False
        col_telepon.Width = 150
        ' 
        ' btn_edit
        ' 
        btn_edit.Font = New Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_edit.Location = New Point(45, 210)
        btn_edit.Name = "btn_edit"
        btn_edit.Size = New Size(118, 42)
        btn_edit.TabIndex = 7
        btn_edit.Text = "EDIT"
        btn_edit.UseVisualStyleBackColor = True
        ' 
        ' btn_hapus
        ' 
        btn_hapus.Font = New Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_hapus.Location = New Point(144, 287)
        btn_hapus.Name = "btn_hapus"
        btn_hapus.Size = New Size(118, 42)
        btn_hapus.TabIndex = 8
        btn_hapus.Text = "HAPUS"
        btn_hapus.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(918, 522)
        Controls.Add(btn_hapus)
        Controls.Add(btn_edit)
        Controls.Add(DataGridView1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btn_tambah)
        Controls.Add(txt_no_telepon)
        Controls.Add(txt_nama)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_nama As TextBox
    Friend WithEvents txt_no_telepon As TextBox
    Friend WithEvents btn_tambah As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents col_nama As DataGridViewTextBoxColumn
    Friend WithEvents col_telepon As DataGridViewTextBoxColumn
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_hapus As Button

End Class

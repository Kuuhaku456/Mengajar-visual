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
        TXT_NIM = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        TXT_Nama = New TextBox()
        Label3 = New Label()
        TXT_Kelas = New TextBox()
        btn_tambah = New Button()
        btn_Update = New Button()
        btn_hapus = New Button()
        MyListView = New ListView()
        SuspendLayout()
        ' 
        ' TXT_NIM
        ' 
        TXT_NIM.Location = New Point(125, 45)
        TXT_NIM.Name = "TXT_NIM"
        TXT_NIM.Size = New Size(175, 27)
        TXT_NIM.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(27, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 31)
        Label1.TabIndex = 2
        Label1.Text = "NIM"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(27, 102)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 31)
        Label2.TabIndex = 3
        Label2.Text = "NAMA"
        ' 
        ' TXT_Nama
        ' 
        TXT_Nama.Location = New Point(125, 106)
        TXT_Nama.Name = "TXT_Nama"
        TXT_Nama.Size = New Size(175, 27)
        TXT_Nama.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(27, 168)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 31)
        Label3.TabIndex = 5
        Label3.Text = "KELAS"
        ' 
        ' TXT_Kelas
        ' 
        TXT_Kelas.Location = New Point(125, 174)
        TXT_Kelas.Name = "TXT_Kelas"
        TXT_Kelas.Size = New Size(175, 27)
        TXT_Kelas.TabIndex = 6
        ' 
        ' btn_tambah
        ' 
        btn_tambah.BackColor = SystemColors.ActiveCaption
        btn_tambah.FlatStyle = FlatStyle.Popup
        btn_tambah.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_tambah.Location = New Point(27, 275)
        btn_tambah.Name = "btn_tambah"
        btn_tambah.Size = New Size(106, 42)
        btn_tambah.TabIndex = 7
        btn_tambah.Text = "Add"
        btn_tambah.UseVisualStyleBackColor = False
        ' 
        ' btn_Update
        ' 
        btn_Update.BackColor = SystemColors.ActiveCaption
        btn_Update.FlatStyle = FlatStyle.Popup
        btn_Update.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_Update.Location = New Point(194, 275)
        btn_Update.Name = "btn_Update"
        btn_Update.Size = New Size(119, 42)
        btn_Update.TabIndex = 8
        btn_Update.Text = "UPDATE"
        btn_Update.UseVisualStyleBackColor = False
        ' 
        ' btn_hapus
        ' 
        btn_hapus.BackColor = SystemColors.ActiveCaption
        btn_hapus.FlatStyle = FlatStyle.Popup
        btn_hapus.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_hapus.Location = New Point(372, 275)
        btn_hapus.Name = "btn_hapus"
        btn_hapus.Size = New Size(119, 42)
        btn_hapus.TabIndex = 9
        btn_hapus.Text = "REMOVE"
        btn_hapus.UseVisualStyleBackColor = False
        ' 
        ' MyListView
        ' 
        MyListView.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MyListView.GridLines = True
        MyListView.Location = New Point(331, 26)
        MyListView.Name = "MyListView"
        MyListView.Size = New Size(604, 212)
        MyListView.TabIndex = 10
        MyListView.UseCompatibleStateImageBehavior = False
        MyListView.View = View.Details
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(956, 505)
        Controls.Add(MyListView)
        Controls.Add(btn_hapus)
        Controls.Add(btn_Update)
        Controls.Add(btn_tambah)
        Controls.Add(TXT_Kelas)
        Controls.Add(Label3)
        Controls.Add(TXT_Nama)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TXT_NIM)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TXT_NIM As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_Nama As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_Kelas As TextBox
    Friend WithEvents btn_tambah As Button
    Friend WithEvents btn_Update As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents MyListView As ListView

End Class

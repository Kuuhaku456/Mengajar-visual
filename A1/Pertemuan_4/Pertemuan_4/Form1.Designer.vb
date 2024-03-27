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
        Label1 = New Label()
        txt_kode = New TextBox()
        Label2 = New Label()
        txt_jenis = New TextBox()
        TextBox3 = New TextBox()
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(23, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 25)
        Label1.TabIndex = 0
        Label1.Text = "Kode Jenis"
        ' 
        ' txt_kode
        ' 
        txt_kode.Location = New Point(144, 44)
        txt_kode.Name = "txt_kode"
        txt_kode.Size = New Size(187, 27)
        txt_kode.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(23, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 25)
        Label2.TabIndex = 2
        Label2.Text = "Jenis"
        ' 
        ' txt_jenis
        ' 
        txt_jenis.Location = New Point(144, 96)
        txt_jenis.Name = "txt_jenis"
        txt_jenis.Size = New Size(307, 27)
        txt_jenis.TabIndex = 3
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(24, 146)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(427, 27)
        TextBox3.TabIndex = 4
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(23, 230)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(427, 246)
        DataGridView1.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(23, 184)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 6
        Button1.Text = "Simpan"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(144, 184)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 7
        Button2.Text = "Ubah"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(252, 184)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 8
        Button3.Text = "Hapus"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(358, 184)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 9
        Button4.Text = "Batal"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(478, 499)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(TextBox3)
        Controls.Add(txt_jenis)
        Controls.Add(Label2)
        Controls.Add(txt_kode)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_kode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_jenis As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button

End Class

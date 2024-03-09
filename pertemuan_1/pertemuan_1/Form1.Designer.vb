<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_pertemuan_1
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
        btn_tambah = New Button()
        txt_angka1 = New TextBox()
        txt_angka2 = New TextBox()
        txt_hasil = New TextBox()
        btn_clear = New Button()
        txt_ket = New TextBox()
        ListBox1 = New ListBox()
        Btn_tmbhs = New Button()
        SuspendLayout()
        ' 
        ' btn_tambah
        ' 
        btn_tambah.Location = New Point(251, 222)
        btn_tambah.Name = "btn_tambah"
        btn_tambah.Size = New Size(94, 29)
        btn_tambah.TabIndex = 0
        btn_tambah.Text = "+"
        btn_tambah.UseVisualStyleBackColor = True
        ' 
        ' txt_angka1
        ' 
        txt_angka1.Location = New Point(313, 107)
        txt_angka1.Name = "txt_angka1"
        txt_angka1.Size = New Size(125, 27)
        txt_angka1.TabIndex = 1
        ' 
        ' txt_angka2
        ' 
        txt_angka2.Location = New Point(313, 165)
        txt_angka2.Name = "txt_angka2"
        txt_angka2.Size = New Size(125, 27)
        txt_angka2.TabIndex = 2
        ' 
        ' txt_hasil
        ' 
        txt_hasil.Location = New Point(313, 277)
        txt_hasil.Name = "txt_hasil"
        txt_hasil.Size = New Size(125, 27)
        txt_hasil.TabIndex = 3
        ' 
        ' btn_clear
        ' 
        btn_clear.Location = New Point(401, 222)
        btn_clear.Name = "btn_clear"
        btn_clear.Size = New Size(94, 29)
        btn_clear.TabIndex = 4
        btn_clear.Text = "Clear"
        btn_clear.UseVisualStyleBackColor = True
        ' 
        ' txt_ket
        ' 
        txt_ket.Location = New Point(544, 277)
        txt_ket.Name = "txt_ket"
        txt_ket.Size = New Size(184, 27)
        txt_ket.TabIndex = 5
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(561, 30)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(182, 164)
        ListBox1.TabIndex = 6
        ' 
        ' Btn_tmbhs
        ' 
        Btn_tmbhs.Location = New Point(601, 209)
        Btn_tmbhs.Name = "Btn_tmbhs"
        Btn_tmbhs.Size = New Size(94, 29)
        Btn_tmbhs.TabIndex = 7
        Btn_tmbhs.Text = "+"
        Btn_tmbhs.UseVisualStyleBackColor = True
        ' 
        ' Form_pertemuan_1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Btn_tmbhs)
        Controls.Add(ListBox1)
        Controls.Add(txt_ket)
        Controls.Add(btn_clear)
        Controls.Add(txt_hasil)
        Controls.Add(txt_angka2)
        Controls.Add(txt_angka1)
        Controls.Add(btn_tambah)
        Name = "Form_pertemuan_1"
        Text = "Form_pertemuan_1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_tambah As Button
    Friend WithEvents txt_angka1 As TextBox
    Friend WithEvents txt_angka2 As TextBox
    Friend WithEvents txt_hasil As TextBox
    Friend WithEvents btn_clear As Button
    Friend WithEvents txt_ket As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Btn_tmbhs As Button

End Class

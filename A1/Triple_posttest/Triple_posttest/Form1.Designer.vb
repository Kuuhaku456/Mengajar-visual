<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_kalkulator
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
        MyGroupBox = New GroupBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        btn_tambah = New Button()
        btn_kurang = New Button()
        btn_kali = New Button()
        btn_bagi = New Button()
        btn_modulus = New Button()
        btn_pangkat = New Button()
        Button1 = New Button()
        Button2 = New Button()
        MyGroupBox.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(26, 44)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 25)
        Label1.TabIndex = 0
        ' 
        ' MyGroupBox
        ' 
        MyGroupBox.Controls.Add(TextBox3)
        MyGroupBox.Controls.Add(TextBox2)
        MyGroupBox.Controls.Add(TextBox1)
        MyGroupBox.Controls.Add(Label1)
        MyGroupBox.Location = New Point(114, 24)
        MyGroupBox.Name = "MyGroupBox"
        MyGroupBox.Size = New Size(398, 230)
        MyGroupBox.TabIndex = 1
        MyGroupBox.TabStop = False
        MyGroupBox.Text = "KALKULATOR"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(61, 44)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(275, 31)
        TextBox1.TabIndex = 1
        TextBox1.Text = "Masukkan Angka disini. . ."
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(61, 98)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(275, 31)
        TextBox2.TabIndex = 2
        TextBox2.Text = "Masukkan Angka disini. . ."
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(61, 157)
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(275, 31)
        TextBox3.TabIndex = 3
        TextBox3.Text = "Hasilnya disini. . ."
        ' 
        ' btn_tambah
        ' 
        btn_tambah.BackColor = Color.LightSeaGreen
        btn_tambah.FlatStyle = FlatStyle.Popup
        btn_tambah.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_tambah.Location = New Point(27, 269)
        btn_tambah.Name = "btn_tambah"
        btn_tambah.Size = New Size(67, 54)
        btn_tambah.TabIndex = 2
        btn_tambah.Text = "+"
        btn_tambah.TextAlign = ContentAlignment.TopCenter
        btn_tambah.UseVisualStyleBackColor = False
        ' 
        ' btn_kurang
        ' 
        btn_kurang.BackColor = Color.LightSeaGreen
        btn_kurang.FlatStyle = FlatStyle.Popup
        btn_kurang.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_kurang.Location = New Point(175, 269)
        btn_kurang.Name = "btn_kurang"
        btn_kurang.Size = New Size(67, 54)
        btn_kurang.TabIndex = 3
        btn_kurang.Text = "-"
        btn_kurang.TextAlign = ContentAlignment.TopCenter
        btn_kurang.UseVisualStyleBackColor = False
        ' 
        ' btn_kali
        ' 
        btn_kali.BackColor = Color.LightSeaGreen
        btn_kali.FlatStyle = FlatStyle.Popup
        btn_kali.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_kali.Location = New Point(383, 269)
        btn_kali.Name = "btn_kali"
        btn_kali.Size = New Size(67, 54)
        btn_kali.TabIndex = 4
        btn_kali.Text = "x"
        btn_kali.TextAlign = ContentAlignment.TopCenter
        btn_kali.UseVisualStyleBackColor = False
        ' 
        ' btn_bagi
        ' 
        btn_bagi.BackColor = Color.LightSeaGreen
        btn_bagi.FlatStyle = FlatStyle.Popup
        btn_bagi.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_bagi.Location = New Point(546, 269)
        btn_bagi.Name = "btn_bagi"
        btn_bagi.Size = New Size(67, 54)
        btn_bagi.TabIndex = 5
        btn_bagi.Text = "/"
        btn_bagi.TextAlign = ContentAlignment.TopCenter
        btn_bagi.UseVisualStyleBackColor = False
        ' 
        ' btn_modulus
        ' 
        btn_modulus.BackColor = Color.LightSeaGreen
        btn_modulus.FlatStyle = FlatStyle.Popup
        btn_modulus.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_modulus.Location = New Point(27, 340)
        btn_modulus.Name = "btn_modulus"
        btn_modulus.Size = New Size(67, 54)
        btn_modulus.TabIndex = 6
        btn_modulus.Text = "%"
        btn_modulus.TextAlign = ContentAlignment.TopCenter
        btn_modulus.UseVisualStyleBackColor = False
        ' 
        ' btn_pangkat
        ' 
        btn_pangkat.BackColor = Color.LightSeaGreen
        btn_pangkat.FlatStyle = FlatStyle.Popup
        btn_pangkat.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_pangkat.Location = New Point(175, 340)
        btn_pangkat.Name = "btn_pangkat"
        btn_pangkat.Size = New Size(83, 54)
        btn_pangkat.TabIndex = 7
        btn_pangkat.Text = "x^y"
        btn_pangkat.TextAlign = ContentAlignment.TopCenter
        btn_pangkat.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LightSeaGreen
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(383, 340)
        Button1.Name = "Button1"
        Button1.Size = New Size(83, 54)
        Button1.TabIndex = 8
        Button1.Text = "y√x"
        Button1.TextAlign = ContentAlignment.TopCenter
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.LightSeaGreen
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(546, 340)
        Button2.Name = "Button2"
        Button2.Size = New Size(67, 54)
        Button2.TabIndex = 9
        Button2.Text = "!"
        Button2.TextAlign = ContentAlignment.TopCenter
        Button2.UseVisualStyleBackColor = False
        ' 
        ' form_kalkulator
        ' 
        AutoScaleDimensions = New SizeF(11F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(638, 406)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(btn_pangkat)
        Controls.Add(btn_modulus)
        Controls.Add(btn_bagi)
        Controls.Add(btn_kali)
        Controls.Add(btn_kurang)
        Controls.Add(btn_tambah)
        Controls.Add(MyGroupBox)
        Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 4, 4, 4)
        Name = "form_kalkulator"
        StartPosition = FormStartPosition.CenterScreen
        Text = "KALKULATOR"
        MyGroupBox.ResumeLayout(False)
        MyGroupBox.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MyGroupBox As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btn_tambah As Button
    Friend WithEvents btn_kurang As Button
    Friend WithEvents btn_kali As Button
    Friend WithEvents btn_bagi As Button
    Friend WithEvents btn_modulus As Button
    Friend WithEvents btn_pangkat As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

End Class

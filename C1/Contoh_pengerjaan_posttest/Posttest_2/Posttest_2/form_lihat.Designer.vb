<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_lihat
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        MyListView = New ListView()
        btn_kembali = New Button()
        SuspendLayout()
        ' 
        ' MyListView
        ' 
        MyListView.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MyListView.FullRowSelect = True
        MyListView.GridLines = True
        MyListView.Location = New Point(116, 42)
        MyListView.Name = "MyListView"
        MyListView.Size = New Size(498, 209)
        MyListView.TabIndex = 0
        MyListView.UseCompatibleStateImageBehavior = False
        MyListView.View = View.Details
        ' 
        ' btn_kembali
        ' 
        btn_kembali.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_kembali.ForeColor = Color.CadetBlue
        btn_kembali.Location = New Point(276, 278)
        btn_kembali.Name = "btn_kembali"
        btn_kembali.Size = New Size(152, 43)
        btn_kembali.TabIndex = 6
        btn_kembali.Text = "KEMBALI"
        btn_kembali.UseVisualStyleBackColor = True
        ' 
        ' form_lihat
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(745, 448)
        Controls.Add(btn_kembali)
        Controls.Add(MyListView)
        Name = "form_lihat"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LIHAT DAFTAR BUKU"
        ResumeLayout(False)
    End Sub

    Friend WithEvents MyListView As ListView
    Friend WithEvents btn_kembali As Button
End Class

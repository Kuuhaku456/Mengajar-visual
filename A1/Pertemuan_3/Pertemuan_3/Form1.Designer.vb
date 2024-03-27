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
        btn_lihat = New Button()
        txt_nama = New TextBox()
        SuspendLayout()
        ' 
        ' btn_lihat
        ' 
        btn_lihat.Location = New Point(290, 195)
        btn_lihat.Name = "btn_lihat"
        btn_lihat.Size = New Size(94, 29)
        btn_lihat.TabIndex = 0
        btn_lihat.Text = "LIHAT"
        btn_lihat.UseVisualStyleBackColor = True
        ' 
        ' txt_nama
        ' 
        txt_nama.Location = New Point(242, 115)
        txt_nama.Name = "txt_nama"
        txt_nama.Size = New Size(188, 27)
        txt_nama.TabIndex = 1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(744, 371)
        Controls.Add(txt_nama)
        Controls.Add(btn_lihat)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_lihat As Button
    Friend WithEvents txt_nama As TextBox

End Class

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
        BTN_KEMBALI = New Button()
        txt_lihat = New TextBox()
        SuspendLayout()
        ' 
        ' BTN_KEMBALI
        ' 
        BTN_KEMBALI.Location = New Point(326, 226)
        BTN_KEMBALI.Name = "BTN_KEMBALI"
        BTN_KEMBALI.Size = New Size(94, 29)
        BTN_KEMBALI.TabIndex = 0
        BTN_KEMBALI.Text = "KEMBALI"
        BTN_KEMBALI.UseVisualStyleBackColor = True
        ' 
        ' txt_lihat
        ' 
        txt_lihat.Location = New Point(312, 158)
        txt_lihat.Name = "txt_lihat"
        txt_lihat.Size = New Size(125, 27)
        txt_lihat.TabIndex = 1
        ' 
        ' form_lihat
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txt_lihat)
        Controls.Add(BTN_KEMBALI)
        Name = "form_lihat"
        StartPosition = FormStartPosition.CenterScreen
        Text = "form_lihat"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BTN_KEMBALI As Button
    Friend WithEvents txt_lihat As TextBox
End Class

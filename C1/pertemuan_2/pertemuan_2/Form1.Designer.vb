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
        MyListView = New ListView()
        Label1 = New Label()
        txt_nim = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        btn_add = New Button()
        btn_update = New Button()
        btn_delete = New Button()
        btn_exit = New Button()
        SuspendLayout()
        ' 
        ' MyListView
        ' 
        MyListView.FullRowSelect = True
        MyListView.GridLines = True
        MyListView.Location = New Point(319, 17)
        MyListView.Margin = New Padding(2)
        MyListView.Name = "MyListView"
        MyListView.Size = New Size(543, 222)
        MyListView.TabIndex = 0
        MyListView.UseCompatibleStateImageBehavior = False
        MyListView.View = View.Details
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(36, 54)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 28)
        Label1.TabIndex = 1
        Label1.Text = "NIM"
        ' 
        ' txt_nim
        ' 
        txt_nim.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txt_nim.Location = New Point(130, 52)
        txt_nim.Margin = New Padding(2)
        txt_nim.Name = "txt_nim"
        txt_nim.Size = New Size(157, 34)
        txt_nim.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(36, 114)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 28)
        Label2.TabIndex = 3
        Label2.Text = "Nama"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(36, 186)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 28)
        Label3.TabIndex = 4
        Label3.Text = "Prodi"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(130, 114)
        TextBox2.Margin = New Padding(2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(157, 34)
        TextBox2.TabIndex = 5
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(130, 183)
        TextBox3.Margin = New Padding(2)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(157, 34)
        TextBox3.TabIndex = 6
        ' 
        ' btn_add
        ' 
        btn_add.BackColor = SystemColors.ActiveCaption
        btn_add.FlatStyle = FlatStyle.Popup
        btn_add.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_add.Location = New Point(24, 270)
        btn_add.Margin = New Padding(2)
        btn_add.Name = "btn_add"
        btn_add.Size = New Size(102, 36)
        btn_add.TabIndex = 7
        btn_add.Text = "Add"
        btn_add.UseVisualStyleBackColor = False
        ' 
        ' btn_update
        ' 
        btn_update.BackColor = SystemColors.ActiveCaption
        btn_update.FlatStyle = FlatStyle.Popup
        btn_update.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_update.Location = New Point(404, 268)
        btn_update.Margin = New Padding(2)
        btn_update.Name = "btn_update"
        btn_update.Size = New Size(97, 40)
        btn_update.TabIndex = 8
        btn_update.Text = "Update"
        btn_update.UseVisualStyleBackColor = False
        ' 
        ' btn_delete
        ' 
        btn_delete.BackColor = SystemColors.ActiveCaption
        btn_delete.FlatStyle = FlatStyle.Popup
        btn_delete.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_delete.Location = New Point(765, 267)
        btn_delete.Margin = New Padding(2)
        btn_delete.Name = "btn_delete"
        btn_delete.Size = New Size(97, 40)
        btn_delete.TabIndex = 10
        btn_delete.Text = "Delete"
        btn_delete.UseVisualStyleBackColor = False
        ' 
        ' btn_exit
        ' 
        btn_exit.BackColor = SystemColors.ActiveCaption
        btn_exit.FlatStyle = FlatStyle.Popup
        btn_exit.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_exit.Location = New Point(404, 343)
        btn_exit.Margin = New Padding(2)
        btn_exit.Name = "btn_exit"
        btn_exit.Size = New Size(97, 40)
        btn_exit.TabIndex = 11
        btn_exit.Text = "Exit"
        btn_exit.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1004, 408)
        Controls.Add(btn_exit)
        Controls.Add(btn_delete)
        Controls.Add(btn_update)
        Controls.Add(btn_add)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txt_nim)
        Controls.Add(Label1)
        Controls.Add(MyListView)
        Margin = New Padding(2)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MyListView As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nim As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_exit As Button

End Class

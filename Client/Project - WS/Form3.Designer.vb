<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBoxPlaylistName = New System.Windows.Forms.TextBox()
        Me.ListBox = New System.Windows.Forms.ListBox()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonCreate = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxPlaylistName
        '
        Me.TextBoxPlaylistName.Location = New System.Drawing.Point(12, 12)
        Me.TextBoxPlaylistName.Name = "TextBoxPlaylistName"
        Me.TextBoxPlaylistName.Size = New System.Drawing.Size(288, 20)
        Me.TextBoxPlaylistName.TabIndex = 1
        '
        'ListBox
        '
        Me.ListBox.FormattingEnabled = True
        Me.ListBox.Location = New System.Drawing.Point(98, 154)
        Me.ListBox.Name = "ListBox"
        Me.ListBox.Size = New System.Drawing.Size(202, 43)
        Me.ListBox.TabIndex = 5
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.ComboBox1)
        Me.GroupBox.Controls.Add(Me.ButtonAdd)
        Me.GroupBox.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(360, 46)
        Me.GroupBox.TabIndex = 6
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "Add a track"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(7, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(281, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(294, 19)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(60, 20)
        Me.ButtonAdd.TabIndex = 5
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonCreate
        '
        Me.ButtonCreate.Location = New System.Drawing.Point(12, 220)
        Me.ButtonCreate.Name = "ButtonCreate"
        Me.ButtonCreate.Size = New System.Drawing.Size(288, 30)
        Me.ButtonCreate.TabIndex = 7
        Me.ButtonCreate.Text = "Create this Playlist"
        Me.ButtonCreate.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(302, 220)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(70, 30)
        Me.ButtonCancel.TabIndex = 8
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 262)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonCreate)
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.ListBox)
        Me.Controls.Add(Me.TextBoxPlaylistName)
        Me.Name = "Form3"
        Me.Text = "Create a Playlist"
        Me.GroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxPlaylistName As TextBox
    Friend WithEvents ListBox As ListBox
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents ButtonCreate As Button
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Image = Global.Project___WS.My.Resources.Resources.Create_Playlist_Add_Tracks
        Me.ButtonAdd.Location = New System.Drawing.Point(12, 172)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(260, 70)
        Me.ButtonAdd.TabIndex = 2
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Image = Global.Project___WS.My.Resources.Resources.Search_a_Playlist
        Me.ButtonSearch.Location = New System.Drawing.Point(12, 96)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(260, 71)
        Me.ButtonSearch.TabIndex = 0
        Me.ButtonSearch.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project___WS.My.Resources.Resources.MP3_playlist
        Me.ClientSize = New System.Drawing.Size(284, 250)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.ButtonSearch)
        Me.MaximumSize = New System.Drawing.Size(300, 288)
        Me.MinimumSize = New System.Drawing.Size(300, 288)
        Me.Name = "Form1"
        Me.Text = "Home"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonSearch As Button
    Friend WithEvents ButtonAdd As Button
End Class

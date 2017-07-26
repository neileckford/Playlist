<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.ButtonHome = New System.Windows.Forms.Button()
        Me.ButtonCreate = New System.Windows.Forms.Button()
        Me.TextBoxPlaylist = New System.Windows.Forms.TextBox()
        Me.TextBoxGenre = New System.Windows.Forms.TextBox()
        Me.TextBoxArtist = New System.Windows.Forms.TextBox()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ButtonHome
        '
        Me.ButtonHome.Image = Global.Project___WS.My.Resources.Resources.Home
        Me.ButtonHome.Location = New System.Drawing.Point(155, 222)
        Me.ButtonHome.Name = "ButtonHome"
        Me.ButtonHome.Size = New System.Drawing.Size(90, 40)
        Me.ButtonHome.TabIndex = 9
        Me.ButtonHome.UseVisualStyleBackColor = True
        '
        'ButtonCreate
        '
        Me.ButtonCreate.BackgroundImage = Global.Project___WS.My.Resources.Resources.__
        Me.ButtonCreate.Location = New System.Drawing.Point(250, 30)
        Me.ButtonCreate.Name = "ButtonCreate"
        Me.ButtonCreate.Size = New System.Drawing.Size(117, 25)
        Me.ButtonCreate.TabIndex = 1
        Me.ButtonCreate.UseVisualStyleBackColor = True
        '
        'TextBoxPlaylist
        '
        Me.TextBoxPlaylist.Location = New System.Drawing.Point(20, 32)
        Me.TextBoxPlaylist.Name = "TextBoxPlaylist"
        Me.TextBoxPlaylist.Size = New System.Drawing.Size(206, 20)
        Me.TextBoxPlaylist.TabIndex = 0
        '
        'TextBoxGenre
        '
        Me.TextBoxGenre.Location = New System.Drawing.Point(210, 121)
        Me.TextBoxGenre.Name = "TextBoxGenre"
        Me.TextBoxGenre.Size = New System.Drawing.Size(90, 20)
        Me.TextBoxGenre.TabIndex = 13
        '
        'TextBoxArtist
        '
        Me.TextBoxArtist.Location = New System.Drawing.Point(114, 121)
        Me.TextBoxArtist.Name = "TextBoxArtist"
        Me.TextBoxArtist.Size = New System.Drawing.Size(90, 20)
        Me.TextBoxArtist.TabIndex = 12
        '
        'ButtonAdd
        '
        Me.ButtonAdd.BackgroundImage = Global.Project___WS.My.Resources.Resources._2
        Me.ButtonAdd.Location = New System.Drawing.Point(326, 119)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(41, 23)
        Me.ButtonAdd.TabIndex = 14
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(18, 121)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(90, 20)
        Me.TextBoxName.TabIndex = 11
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(18, 96)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(206, 21)
        Me.ComboBox1.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(17, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Add Track"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(18, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Create Playlist"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(18, 147)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(445, 69)
        Me.ListBox1.TabIndex = 20
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project___WS.My.Resources.Resources.Fond4a
        Me.ClientSize = New System.Drawing.Size(484, 262)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxPlaylist)
        Me.Controls.Add(Me.ButtonCreate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.TextBoxGenre)
        Me.Controls.Add(Me.TextBoxArtist)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ButtonHome)
        Me.MaximumSize = New System.Drawing.Size(500, 300)
        Me.MinimumSize = New System.Drawing.Size(400, 300)
        Me.Name = "Form5"
        Me.Text = "Add Track to a Playlist"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonHome As Button
    Friend WithEvents ButtonCreate As Button
    Friend WithEvents TextBoxPlaylist As TextBox
    Friend WithEvents TextBoxGenre As TextBox
    Friend WithEvents TextBoxArtist As TextBox
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBox1 As ListBox
End Class

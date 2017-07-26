<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.GroupBoxRank = New System.Windows.Forms.GroupBox()
        Me.StarJ5 = New System.Windows.Forms.Label()
        Me.StarJ1 = New System.Windows.Forms.Label()
        Me.StarJ4 = New System.Windows.Forms.Label()
        Me.StarG1 = New System.Windows.Forms.Label()
        Me.StarJ2 = New System.Windows.Forms.Label()
        Me.StarG2 = New System.Windows.Forms.Label()
        Me.StarJ3 = New System.Windows.Forms.Label()
        Me.StarG3 = New System.Windows.Forms.Label()
        Me.StarG4 = New System.Windows.Forms.Label()
        Me.StarG5 = New System.Windows.Forms.Label()
        Me.ButtonRank = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBoxRank.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackgroundImage = Global.Project___WS.My.Resources.Resources.Home
        Me.ButtonCancel.Location = New System.Drawing.Point(282, 207)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(90, 40)
        Me.ButtonCancel.TabIndex = 5
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'GroupBoxRank
        '
        Me.GroupBoxRank.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxRank.Controls.Add(Me.StarJ5)
        Me.GroupBoxRank.Controls.Add(Me.StarJ1)
        Me.GroupBoxRank.Controls.Add(Me.StarJ4)
        Me.GroupBoxRank.Controls.Add(Me.StarG1)
        Me.GroupBoxRank.Controls.Add(Me.StarJ2)
        Me.GroupBoxRank.Controls.Add(Me.StarG2)
        Me.GroupBoxRank.Controls.Add(Me.StarJ3)
        Me.GroupBoxRank.Controls.Add(Me.StarG3)
        Me.GroupBoxRank.Controls.Add(Me.StarG4)
        Me.GroupBoxRank.Controls.Add(Me.StarG5)
        Me.GroupBoxRank.Location = New System.Drawing.Point(12, 199)
        Me.GroupBoxRank.Name = "GroupBoxRank"
        Me.GroupBoxRank.Size = New System.Drawing.Size(162, 51)
        Me.GroupBoxRank.TabIndex = 16
        Me.GroupBoxRank.TabStop = False
        Me.GroupBoxRank.Text = "Rank of the Playlist"
        '
        'StarJ5
        '
        Me.StarJ5.AutoSize = True
        Me.StarJ5.Image = Global.Project___WS.My.Resources.Resources._1star
        Me.StarJ5.Location = New System.Drawing.Point(126, 16)
        Me.StarJ5.MinimumSize = New System.Drawing.Size(30, 28)
        Me.StarJ5.Name = "StarJ5"
        Me.StarJ5.Size = New System.Drawing.Size(30, 28)
        Me.StarJ5.TabIndex = 15
        '
        'StarJ1
        '
        Me.StarJ1.AutoSize = True
        Me.StarJ1.Image = Global.Project___WS.My.Resources.Resources._1star
        Me.StarJ1.Location = New System.Drawing.Point(6, 16)
        Me.StarJ1.MinimumSize = New System.Drawing.Size(30, 28)
        Me.StarJ1.Name = "StarJ1"
        Me.StarJ1.Size = New System.Drawing.Size(30, 28)
        Me.StarJ1.TabIndex = 11
        '
        'StarJ4
        '
        Me.StarJ4.AutoSize = True
        Me.StarJ4.Image = Global.Project___WS.My.Resources.Resources._1star
        Me.StarJ4.Location = New System.Drawing.Point(96, 16)
        Me.StarJ4.MinimumSize = New System.Drawing.Size(30, 28)
        Me.StarJ4.Name = "StarJ4"
        Me.StarJ4.Size = New System.Drawing.Size(30, 28)
        Me.StarJ4.TabIndex = 14
        '
        'StarG1
        '
        Me.StarG1.AutoSize = True
        Me.StarG1.Image = Global.Project___WS.My.Resources.Resources._0star
        Me.StarG1.Location = New System.Drawing.Point(6, 16)
        Me.StarG1.MinimumSize = New System.Drawing.Size(30, 28)
        Me.StarG1.Name = "StarG1"
        Me.StarG1.Size = New System.Drawing.Size(30, 28)
        Me.StarG1.TabIndex = 6
        '
        'StarJ2
        '
        Me.StarJ2.AutoSize = True
        Me.StarJ2.Image = Global.Project___WS.My.Resources.Resources._1star
        Me.StarJ2.Location = New System.Drawing.Point(36, 16)
        Me.StarJ2.MinimumSize = New System.Drawing.Size(30, 28)
        Me.StarJ2.Name = "StarJ2"
        Me.StarJ2.Size = New System.Drawing.Size(30, 28)
        Me.StarJ2.TabIndex = 12
        '
        'StarG2
        '
        Me.StarG2.AutoSize = True
        Me.StarG2.Image = Global.Project___WS.My.Resources.Resources._0star
        Me.StarG2.Location = New System.Drawing.Point(36, 16)
        Me.StarG2.MinimumSize = New System.Drawing.Size(30, 28)
        Me.StarG2.Name = "StarG2"
        Me.StarG2.Size = New System.Drawing.Size(30, 28)
        Me.StarG2.TabIndex = 7
        '
        'StarJ3
        '
        Me.StarJ3.AutoSize = True
        Me.StarJ3.Image = Global.Project___WS.My.Resources.Resources._1star
        Me.StarJ3.Location = New System.Drawing.Point(66, 16)
        Me.StarJ3.MinimumSize = New System.Drawing.Size(30, 28)
        Me.StarJ3.Name = "StarJ3"
        Me.StarJ3.Size = New System.Drawing.Size(30, 28)
        Me.StarJ3.TabIndex = 13
        '
        'StarG3
        '
        Me.StarG3.AutoSize = True
        Me.StarG3.Image = Global.Project___WS.My.Resources.Resources._0star
        Me.StarG3.Location = New System.Drawing.Point(66, 16)
        Me.StarG3.MinimumSize = New System.Drawing.Size(30, 28)
        Me.StarG3.Name = "StarG3"
        Me.StarG3.Size = New System.Drawing.Size(30, 28)
        Me.StarG3.TabIndex = 8
        '
        'StarG4
        '
        Me.StarG4.AutoSize = True
        Me.StarG4.Image = Global.Project___WS.My.Resources.Resources._0star
        Me.StarG4.Location = New System.Drawing.Point(96, 16)
        Me.StarG4.MinimumSize = New System.Drawing.Size(30, 28)
        Me.StarG4.Name = "StarG4"
        Me.StarG4.Size = New System.Drawing.Size(30, 28)
        Me.StarG4.TabIndex = 9
        '
        'StarG5
        '
        Me.StarG5.AutoSize = True
        Me.StarG5.Image = Global.Project___WS.My.Resources.Resources._0star
        Me.StarG5.Location = New System.Drawing.Point(126, 16)
        Me.StarG5.MinimumSize = New System.Drawing.Size(30, 28)
        Me.StarG5.Name = "StarG5"
        Me.StarG5.Size = New System.Drawing.Size(30, 28)
        Me.StarG5.TabIndex = 10
        '
        'ButtonRank
        '
        Me.ButtonRank.Image = Global.Project___WS.My.Resources.Resources.Rank
        Me.ButtonRank.Location = New System.Drawing.Point(186, 207)
        Me.ButtonRank.Name = "ButtonRank"
        Me.ButtonRank.Size = New System.Drawing.Size(90, 40)
        Me.ButtonRank.TabIndex = 17
        Me.ButtonRank.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(13, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(263, 21)
        Me.ComboBox1.TabIndex = 20
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 46)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(434, 147)
        Me.ListBox1.TabIndex = 21
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project___WS.My.Resources.Resources.Fond1
        Me.ClientSize = New System.Drawing.Size(458, 262)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ButtonRank)
        Me.Controls.Add(Me.GroupBoxRank)
        Me.Controls.Add(Me.ButtonCancel)
        Me.MaximumSize = New System.Drawing.Size(500, 300)
        Me.MinimumSize = New System.Drawing.Size(400, 300)
        Me.Name = "Form2"
        Me.Text = "Search a Playlist"
        Me.GroupBoxRank.ResumeLayout(False)
        Me.GroupBoxRank.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents StarG1 As Label
    Friend WithEvents StarG2 As Label
    Friend WithEvents StarG3 As Label
    Friend WithEvents StarG4 As Label
    Friend WithEvents StarG5 As Label
    Friend WithEvents StarJ1 As Label
    Friend WithEvents StarJ2 As Label
    Friend WithEvents StarJ3 As Label
    Friend WithEvents StarJ4 As Label
    Friend WithEvents StarJ5 As Label
    Friend WithEvents GroupBoxRank As GroupBox
    Friend WithEvents ButtonRank As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ListBox1 As ListBox
End Class

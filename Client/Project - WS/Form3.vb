Public Class Form3
    Dim FlagCancel As Boolean

    Private Sub TextBoxPlaylistName_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxPlaylistName.GotFocus
        If TextBoxPlaylistName.Text = "Playlist name" Then
            TextBoxPlaylistName.Text = ""
        End If
    End Sub
    Private Sub TextBoxPlaylistName_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxPlaylistName.LostFocus
        If TextBoxPlaylistName.Text = "" Then
            TextBoxPlaylistName.Text = "Playlist name"
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxPlaylistName.Text = "Playlist name"
        Me.ActiveControl = ListBox
        FlagCancel = False
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        If ComboBox1.SelectedValue = "" Then
            MsgBox("You have to select a track", MsgBoxStyle.DefaultButton1)
        Else
            ListBox.Items.Add(ComboBox1.SelectedValue)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        FlagCancel = True
        Me.Close()
    End Sub

    Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If FlagCancel = False Then
            Form1.Close()
        Else
            Form1.Visible = True
        End If
    End Sub
End Class
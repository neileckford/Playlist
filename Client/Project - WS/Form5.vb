

Public Class Form5

    Dim p As New PlaylistService.ServiceSoapClient
    Dim FlagCancel As Boolean
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FlagCancel = False
        Me.ActiveControl = ListBox1
        TextBoxName.Text = "Name"
        TextBoxArtist.Text = "Artist"
        TextBoxGenre.Text = "Genre"
        TextBoxPlaylist.Text = "Choose a Playlist name"
        Dim tab() As String
        tab = Split(p.GetPlaylistNames(), "*")
        For i = 0 To UBound(tab)
            ComboBox1.DataSource = tab
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonHome.Click
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

    Private Sub TextBoxName_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxName.GotFocus
        If TextBoxName.Text = "Name" Then
            TextBoxName.Text = ""
        End If
    End Sub
    Private Sub TextBoxName_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxName.LostFocus
        If TextBoxName.Text = "" Then
            TextBoxName.Text = "Name"
        End If
    End Sub

    Private Sub TextBoxArtist_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxArtist.GotFocus
        If TextBoxArtist.Text = "Artist" Then
            TextBoxArtist.Text = ""
        End If
    End Sub
    Private Sub TextBoxArtist_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxArtist.LostFocus
        If TextBoxArtist.Text = "" Then
            TextBoxArtist.Text = "Artist"
        End If
    End Sub

    Private Sub TextBoxGenre_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxGenre.GotFocus
        If TextBoxGenre.Text = "Genre" Then
            TextBoxGenre.Text = ""
        End If
    End Sub
    Private Sub TextBoxGenre_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxGenre.LostFocus
        If TextBoxGenre.Text = "" Then
            TextBoxGenre.Text = "Genre"
        End If
    End Sub

    Private Sub TextBoxPlaylist_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxPlaylist.GotFocus
        If TextBoxPlaylist.Text = "Choose a Playlist name" Then
            TextBoxPlaylist.Text = ""
        End If
    End Sub
    Private Sub TextBoxPlaylist_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxPlaylist.LostFocus
        If TextBoxPlaylist.Text = "" Then
            TextBoxPlaylist.Text = "Choose a Playlist name"
        End If
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        p.AddTrack(ComboBox1.Text, TextBoxName.Text, TextBoxArtist.Text, TextBoxGenre.Text)
        Dim tab() As String
        ListBox1.Items.Clear()
        tab = Split(p.GetPlaylistDetails(ComboBox1.SelectedItem.ToString), "*")
        For i = 0 To UBound(tab)
            ListBox1.Items.Add(tab(i))
        Next
    End Sub

    Private Sub ButtonCreate_Click(sender As Object, e As EventArgs) Handles ButtonCreate.Click
        p.AddPlaylist(TextBoxPlaylist.Text)
        Dim tab() As String
        tab = Split(p.GetPlaylistNames(), "*")
        For i = 0 To UBound(tab)
            ComboBox1.DataSource = tab
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim tab() As String
        ListBox1.Items.Clear()
        tab = Split(p.GetPlaylistDetails(ComboBox1.SelectedItem.ToString), "*")
        For i = 0 To UBound(tab)
            ListBox1.Items.Add(tab(i))
        Next
    End Sub

    Private Sub TextBoxName_TextChanged(sender As Object, e As EventArgs) Handles TextBoxName.TextChanged

    End Sub

    Private Sub TextBoxArtist_TextChanged(sender As Object, e As EventArgs) Handles TextBoxArtist.TextChanged

    End Sub
End Class
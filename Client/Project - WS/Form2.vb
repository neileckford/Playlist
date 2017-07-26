Public Class Form2
    Dim FlagCancel As Boolean
    Dim p As New PlaylistService.ServiceSoapClient
    Public Pl As String

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
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

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ActiveControl = ListBox1
        FlagCancel = False
        Dim tab() As String
        tab = Split(p.GetPlaylistNames(), "*")
        For i = 0 To UBound(tab)
            ComboBox1.DataSource = tab
        Next

    End Sub

    Private Sub ButtonRank_Click(sender As Object, e As EventArgs) Handles ButtonRank.Click
        Form4.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim tab() As String
        ListBox1.Items.Clear()
        tab = Split(p.GetPlaylistDetails(ComboBox1.SelectedItem.ToString), "*")
        For i = 0 To UBound(tab)
            ListBox1.Items.Add(tab(i))
        Next

        Me.Pl = ComboBox1.SelectedValue

        Dim Rank As Integer
        Dim DoubleRank As Double
        DoubleRank = p.ShowRating(ComboBox1.SelectedValue)
        Rank = Math.Floor(DoubleRank)
        If Rank = "0" Then
            StarJ1.Visible = False
            StarJ2.Visible = False
            StarJ3.Visible = False
            StarJ4.Visible = False
            StarJ5.Visible = False
        ElseIf Rank = "1" Then
            StarJ1.Visible = True
            StarJ2.Visible = False
            StarJ3.Visible = False
            StarJ4.Visible = False
            StarJ5.Visible = False
        ElseIf Rank = "2" Then
            StarJ1.Visible = True
            StarJ2.Visible = True
            StarJ3.Visible = False
            StarJ4.Visible = False
            StarJ5.Visible = False
        ElseIf Rank = "3" Then
            StarJ1.Visible = True
            StarJ2.Visible = True
            StarJ3.Visible = True
            StarJ4.Visible = False
            StarJ5.Visible = False
        ElseIf Rank = "4" Then
            StarJ1.Visible = True
            StarJ2.Visible = True
            StarJ3.Visible = True
            StarJ4.Visible = True
            StarJ5.Visible = False
        ElseIf Rank = "5" Then
            StarJ1.Visible = True
            StarJ2.Visible = True
            StarJ3.Visible = True
            StarJ4.Visible = True
            StarJ5.Visible = True
        End If



    End Sub
End Class

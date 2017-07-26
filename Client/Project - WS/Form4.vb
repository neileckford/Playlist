Public Class Form4

    Dim p As New PlaylistService.ServiceSoapClient

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Button1.Text = "Rank this Playlist : " + CStr(TrackBar1.Value) + "/5"
        If TrackBar1.Value = "0" Then
            StarG1.Visible = True
            StarG2.Visible = True
            StarG3.Visible = True
            StarG4.Visible = True
            StarG5.Visible = True
        ElseIf TrackBar1.Value = "1" Then
            StarG1.Visible = False
            StarG2.Visible = True
            StarG3.Visible = True
            StarG4.Visible = True
            StarG5.Visible = True
        ElseIf TrackBar1.Value = "2" Then
            StarG1.Visible = False
            StarG2.Visible = False
            StarG3.Visible = True
            StarG4.Visible = True
            StarG5.Visible = True
        ElseIf TrackBar1.Value = "3" Then
            StarG1.Visible = False
            StarG2.Visible = False
            StarG3.Visible = False
            StarG4.Visible = True
            StarG5.Visible = True
        ElseIf TrackBar1.Value = "4" Then
            StarG1.Visible = False
            StarG2.Visible = False
            StarG3.Visible = False
            StarG4.Visible = False
            StarG5.Visible = True
        ElseIf TrackBar1.Value = "5" Then
            StarG1.Visible = False
            StarG2.Visible = False
            StarG3.Visible = False
            StarG4.Visible = False
            StarG5.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        p.RateList(Form2.Pl, TrackBar1.Value)
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
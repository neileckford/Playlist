Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml

<WebService(Namespace:="http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class Service
    Inherits System.Web.Services.WebService

    Private theXML As XmlDocument

    Private Function fileName() As String
        Return Server.MapPath("App_Data/Playlist.xml")
    End Function

    Private Function xmlData() As XmlDocument
        If theXML Is Nothing Then
            getDataFile()
        End If
        Return theXML
    End Function

    Private Function getDataFile() As Boolean
        If IO.File.Exists(fileName()) Then
            theXML = New XmlDocument
            theXML.Load(fileName)
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub saveDataFile()
        If theXML IsNot Nothing Then
            theXML.Save(fileName())
        End If
    End Sub

    Private Function getPlayList(ByVal listName As String) As XmlElement
        Try
            Dim xmlItems As XmlElement
            Dim xPath As String = "//Playlist[@name='" & listName & "']"
            xmlItems = xmlData.DocumentElement.SelectSingleNode(xPath)

            Return xmlItems
        Catch e As Exception
        End Try
    End Function

    Private Function getListDetails(ByVal listName As String) As String
        Try
            Dim listTitles As XmlNodeList = xmlData.DocumentElement.SelectNodes("//Playlist[@name='" & listName & "']/Track")
            Dim details As String = ""
            For Each n As System.Xml.XmlNode In listTitles
                details += "Title: " & n("Title").InnerText & " - " & "Artist: " & n("Artist").InnerText & " - " & "Genre :  " & n("Genre").InnerText & "*"
            Next
            Return details
        Catch e As Exception
            Return "Not found"
        End Try
    End Function

    Private Function getListNames() As String
        Dim listTitles As XmlNodeList = xmlData.DocumentElement.SelectNodes("//Playlist")
        Dim names As String = ""
        For Each n As System.Xml.XmlNode In listTitles
            names += n.Attributes("name").InnerText & "*"
        Next
        names = names.Remove(names.Length - 1)
        Return names
    End Function

    Private Function TrackDetails(ByVal listName As String) As XmlElement
        Dim xmlItems As XmlElement
        Dim xPath As String = "//Playlist[@name='" & listName & "']" & "*"
        xmlItems = xmlData.DocumentElement.SelectSingleNode(xPath)
        Return xmlItems
    End Function

    Private Function AddNewPlayList(ByVal listName As String) As Boolean
        If getPlayList(listName) IsNot Nothing Or listName = "" Then
            Return False
        Else
            Dim newList As XmlElement = xmlData.CreateElement("Playlist")
            Dim newAttr As XmlAttribute = xmlData.CreateAttribute("name")
            Dim rateNode As XmlElement
            Dim numberOfRatings As XmlElement
            newAttr.Value = listName
            newList.Attributes.Append(newAttr)
            xmlData.DocumentElement.FirstChild.AppendChild(newList)
            rateNode = newElement("Rating", "0")
            newList.AppendChild(rateNode)
            numberOfRatings = newElement("NumberOfRatings", "0")
            newList.AppendChild(numberOfRatings)
            Return True
        End If
    End Function

    Private Function newElement(ByVal name As String, ByVal value As String) As XmlElement
        Dim el As XmlElement = xmlData.CreateElement(name)
        el.InnerText = value
        Return el
    End Function

    Private Function AddNewTrack(ByVal listName As String, ByVal trackTitle As String, ByVal trackArtist As String, ByVal trackGenre As String) As Boolean
        Try
            If trackTitle = "" Or trackArtist = "" Or trackGenre = "" Or trackTitle = "Name" Or trackArtist = "Artist" Or trackGenre = "Genre" Then
                Return False
            End If
            Dim title As XmlElement
            Dim artist As XmlElement
            Dim genre As XmlElement
            Dim playlist As XmlElement = getPlayList(listName)
            Dim newItem As XmlElement = xmlData.CreateElement("Track")
            Dim newAttr As XmlAttribute = xmlData.CreateAttribute("name")
            newAttr.Value = trackTitle
            newItem.Attributes.Append(newAttr)
            title = newElement("Title", trackTitle)
            newItem.AppendChild(title)
            artist = newElement("Artist", trackArtist)
            newItem.AppendChild(artist)
            genre = newElement("Genre", trackGenre)
            newItem.AppendChild(genre)
            playlist.AppendChild(newItem)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    <WebMethod()> _
    Public Function GetPlaylistNames() As String
        Return getListNames()
    End Function

    <WebMethod()> _
    Public Function GetPlaylistDetails(ByVal listName As String) As String
        Try
            Return getListDetails(listName)
        Catch e As Exception
            Return "No list found"
        End Try
    End Function

    <WebMethod()> _
    Public Function AddPlaylist(ByVal listname As String) As Boolean
        If AddNewPlayList(listname) Then
            saveDataFile()
            Return True
        Else
            Return False
        End If
    End Function

    <WebMethod()> _
    Public Function AddTrack(ByVal listname As String, tracktitle As String, artist As String, genre As String) As Boolean
        Dim userList As XmlElement = getPlayList(listname)
        If userList IsNot Nothing Then
            If AddNewTrack(listname, tracktitle, artist, genre) Then
                saveDataFile()
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    <WebMethod()> _
    Public Function RateList(ByVal listName As String, ByVal rating As String) As Boolean
        Try
            Dim items As XmlElement = getPlayList(listName)
            Dim item As XmlElement = items.SelectSingleNode("//Playlist[@name='" & listName & "']")

            item("Rating").InnerText = (item("Rating").InnerText * item("NumberOfRatings").InnerText + rating) / (item("NumberOfRatings").InnerText + 1)
            item("NumberOfRatings").InnerText += 1
            saveDataFile()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    <WebMethod()> _
    Public Function ShowRating(ByVal listname As String) As String
        Try
            Dim items As XmlElement = getPlayList(listname)
            Dim item As XmlElement = items.SelectSingleNode("//Playlist[@name='" & listname & "']")
            Return item("Rating").InnerText
        Catch e As Exception
            Return "0"
        End Try
    End Function

End Class

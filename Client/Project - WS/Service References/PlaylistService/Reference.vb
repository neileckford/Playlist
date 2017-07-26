﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace PlaylistService
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="PlaylistService.ServiceSoap")>  _
    Public Interface ServiceSoap
        
        'CODEGEN: Generating message contract since element name GetPlaylistNamesResult from namespace http://tempuri.org/ is not marked nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/GetPlaylistNames", ReplyAction:="*")>  _
        Function GetPlaylistNames(ByVal request As PlaylistService.GetPlaylistNamesRequest) As PlaylistService.GetPlaylistNamesResponse
        
        'CODEGEN: Generating message contract since element name listName from namespace http://tempuri.org/ is not marked nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/GetPlaylistDetails", ReplyAction:="*")>  _
        Function GetPlaylistDetails(ByVal request As PlaylistService.GetPlaylistDetailsRequest) As PlaylistService.GetPlaylistDetailsResponse
        
        'CODEGEN: Generating message contract since element name listname from namespace http://tempuri.org/ is not marked nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/AddPlaylist", ReplyAction:="*")>  _
        Function AddPlaylist(ByVal request As PlaylistService.AddPlaylistRequest) As PlaylistService.AddPlaylistResponse
        
        'CODEGEN: Generating message contract since element name listname from namespace http://tempuri.org/ is not marked nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/AddTrack", ReplyAction:="*")>  _
        Function AddTrack(ByVal request As PlaylistService.AddTrackRequest) As PlaylistService.AddTrackResponse
        
        'CODEGEN: Generating message contract since element name listName from namespace http://tempuri.org/ is not marked nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/RateList", ReplyAction:="*")>  _
        Function RateList(ByVal request As PlaylistService.RateListRequest) As PlaylistService.RateListResponse
        
        'CODEGEN: Generating message contract since element name listname from namespace http://tempuri.org/ is not marked nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ShowRating", ReplyAction:="*")>  _
        Function ShowRating(ByVal request As PlaylistService.ShowRatingRequest) As PlaylistService.ShowRatingResponse
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class GetPlaylistNamesRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="GetPlaylistNames", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As PlaylistService.GetPlaylistNamesRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As PlaylistService.GetPlaylistNamesRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute()>  _
    Partial Public Class GetPlaylistNamesRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class GetPlaylistNamesResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="GetPlaylistNamesResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As PlaylistService.GetPlaylistNamesResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As PlaylistService.GetPlaylistNamesResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class GetPlaylistNamesResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public GetPlaylistNamesResult As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal GetPlaylistNamesResult As String)
            MyBase.New
            Me.GetPlaylistNamesResult = GetPlaylistNamesResult
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class GetPlaylistDetailsRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="GetPlaylistDetails", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As PlaylistService.GetPlaylistDetailsRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As PlaylistService.GetPlaylistDetailsRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class GetPlaylistDetailsRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public listName As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal listName As String)
            MyBase.New
            Me.listName = listName
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class GetPlaylistDetailsResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="GetPlaylistDetailsResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As PlaylistService.GetPlaylistDetailsResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As PlaylistService.GetPlaylistDetailsResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class GetPlaylistDetailsResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public GetPlaylistDetailsResult As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal GetPlaylistDetailsResult As String)
            MyBase.New
            Me.GetPlaylistDetailsResult = GetPlaylistDetailsResult
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class AddPlaylistRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="AddPlaylist", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As PlaylistService.AddPlaylistRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As PlaylistService.AddPlaylistRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class AddPlaylistRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public listname As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal listname As String)
            MyBase.New
            Me.listname = listname
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class AddPlaylistResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="AddPlaylistResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As PlaylistService.AddPlaylistResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As PlaylistService.AddPlaylistResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class AddPlaylistResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=0)>  _
        Public AddPlaylistResult As Boolean
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal AddPlaylistResult As Boolean)
            MyBase.New
            Me.AddPlaylistResult = AddPlaylistResult
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class AddTrackRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="AddTrack", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As PlaylistService.AddTrackRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As PlaylistService.AddTrackRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class AddTrackRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public listname As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=1)>  _
        Public tracktitle As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=2)>  _
        Public artist As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=3)>  _
        Public genre As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal listname As String, ByVal tracktitle As String, ByVal artist As String, ByVal genre As String)
            MyBase.New
            Me.listname = listname
            Me.tracktitle = tracktitle
            Me.artist = artist
            Me.genre = genre
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class AddTrackResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="AddTrackResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As PlaylistService.AddTrackResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As PlaylistService.AddTrackResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class AddTrackResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=0)>  _
        Public AddTrackResult As Boolean
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal AddTrackResult As Boolean)
            MyBase.New
            Me.AddTrackResult = AddTrackResult
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class RateListRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="RateList", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As PlaylistService.RateListRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As PlaylistService.RateListRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class RateListRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public listName As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=1)>  _
        Public rating As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal listName As String, ByVal rating As String)
            MyBase.New
            Me.listName = listName
            Me.rating = rating
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class RateListResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="RateListResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As PlaylistService.RateListResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As PlaylistService.RateListResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class RateListResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=0)>  _
        Public RateListResult As Boolean
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal RateListResult As Boolean)
            MyBase.New
            Me.RateListResult = RateListResult
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class ShowRatingRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="ShowRating", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As PlaylistService.ShowRatingRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As PlaylistService.ShowRatingRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class ShowRatingRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public listname As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal listname As String)
            MyBase.New
            Me.listname = listname
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class ShowRatingResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="ShowRatingResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As PlaylistService.ShowRatingResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As PlaylistService.ShowRatingResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class ShowRatingResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public ShowRatingResult As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal ShowRatingResult As String)
            MyBase.New
            Me.ShowRatingResult = ShowRatingResult
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface ServiceSoapChannel
        Inherits PlaylistService.ServiceSoap, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class ServiceSoapClient
        Inherits System.ServiceModel.ClientBase(Of PlaylistService.ServiceSoap)
        Implements PlaylistService.ServiceSoap
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function PlaylistService_ServiceSoap_GetPlaylistNames(ByVal request As PlaylistService.GetPlaylistNamesRequest) As PlaylistService.GetPlaylistNamesResponse Implements PlaylistService.ServiceSoap.GetPlaylistNames
            Return MyBase.Channel.GetPlaylistNames(request)
        End Function
        
        Public Function GetPlaylistNames() As String
            Dim inValue As PlaylistService.GetPlaylistNamesRequest = New PlaylistService.GetPlaylistNamesRequest()
            inValue.Body = New PlaylistService.GetPlaylistNamesRequestBody()
            Dim retVal As PlaylistService.GetPlaylistNamesResponse = CType(Me,PlaylistService.ServiceSoap).GetPlaylistNames(inValue)
            Return retVal.Body.GetPlaylistNamesResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function PlaylistService_ServiceSoap_GetPlaylistDetails(ByVal request As PlaylistService.GetPlaylistDetailsRequest) As PlaylistService.GetPlaylistDetailsResponse Implements PlaylistService.ServiceSoap.GetPlaylistDetails
            Return MyBase.Channel.GetPlaylistDetails(request)
        End Function
        
        Public Function GetPlaylistDetails(ByVal listName As String) As String
            Dim inValue As PlaylistService.GetPlaylistDetailsRequest = New PlaylistService.GetPlaylistDetailsRequest()
            inValue.Body = New PlaylistService.GetPlaylistDetailsRequestBody()
            inValue.Body.listName = listName
            Dim retVal As PlaylistService.GetPlaylistDetailsResponse = CType(Me,PlaylistService.ServiceSoap).GetPlaylistDetails(inValue)
            Return retVal.Body.GetPlaylistDetailsResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function PlaylistService_ServiceSoap_AddPlaylist(ByVal request As PlaylistService.AddPlaylistRequest) As PlaylistService.AddPlaylistResponse Implements PlaylistService.ServiceSoap.AddPlaylist
            Return MyBase.Channel.AddPlaylist(request)
        End Function
        
        Public Function AddPlaylist(ByVal listname As String) As Boolean
            Dim inValue As PlaylistService.AddPlaylistRequest = New PlaylistService.AddPlaylistRequest()
            inValue.Body = New PlaylistService.AddPlaylistRequestBody()
            inValue.Body.listname = listname
            Dim retVal As PlaylistService.AddPlaylistResponse = CType(Me,PlaylistService.ServiceSoap).AddPlaylist(inValue)
            Return retVal.Body.AddPlaylistResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function PlaylistService_ServiceSoap_AddTrack(ByVal request As PlaylistService.AddTrackRequest) As PlaylistService.AddTrackResponse Implements PlaylistService.ServiceSoap.AddTrack
            Return MyBase.Channel.AddTrack(request)
        End Function
        
        Public Function AddTrack(ByVal listname As String, ByVal tracktitle As String, ByVal artist As String, ByVal genre As String) As Boolean
            Dim inValue As PlaylistService.AddTrackRequest = New PlaylistService.AddTrackRequest()
            inValue.Body = New PlaylistService.AddTrackRequestBody()
            inValue.Body.listname = listname
            inValue.Body.tracktitle = tracktitle
            inValue.Body.artist = artist
            inValue.Body.genre = genre
            Dim retVal As PlaylistService.AddTrackResponse = CType(Me,PlaylistService.ServiceSoap).AddTrack(inValue)
            Return retVal.Body.AddTrackResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function PlaylistService_ServiceSoap_RateList(ByVal request As PlaylistService.RateListRequest) As PlaylistService.RateListResponse Implements PlaylistService.ServiceSoap.RateList
            Return MyBase.Channel.RateList(request)
        End Function
        
        Public Function RateList(ByVal listName As String, ByVal rating As String) As Boolean
            Dim inValue As PlaylistService.RateListRequest = New PlaylistService.RateListRequest()
            inValue.Body = New PlaylistService.RateListRequestBody()
            inValue.Body.listName = listName
            inValue.Body.rating = rating
            Dim retVal As PlaylistService.RateListResponse = CType(Me,PlaylistService.ServiceSoap).RateList(inValue)
            Return retVal.Body.RateListResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function PlaylistService_ServiceSoap_ShowRating(ByVal request As PlaylistService.ShowRatingRequest) As PlaylistService.ShowRatingResponse Implements PlaylistService.ServiceSoap.ShowRating
            Return MyBase.Channel.ShowRating(request)
        End Function
        
        Public Function ShowRating(ByVal listname As String) As String
            Dim inValue As PlaylistService.ShowRatingRequest = New PlaylistService.ShowRatingRequest()
            inValue.Body = New PlaylistService.ShowRatingRequestBody()
            inValue.Body.listname = listname
            Dim retVal As PlaylistService.ShowRatingResponse = CType(Me,PlaylistService.ServiceSoap).ShowRating(inValue)
            Return retVal.Body.ShowRatingResult
        End Function
    End Class
End Namespace
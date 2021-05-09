Imports MQTTnet
Imports MQTTnet.Client.Options
Imports MQTTnet.Server
Imports MQTTnet.Client.Receiving
Imports MQTTnet.Client

Public Class CommandCenter
  Implements IMqttApplicationMessageReceivedHandler
  Private ReadOnly Factory As New MqttFactory
  Private WithEvents MqttClient As MqttClient

  Public lbl_Nomi_Points = New List(Of Point) From {
    New Point(33, 332),
    New Point(33, 351),
    New Point(33, 369),
    New Point(33, 388),
    New Point(33, 407),
    New Point(33, 426),
    New Point(33, 445),
    New Point(33, 464),
    New Point(33, 483),
    New Point(33, 502),
    New Point(33, 521),
    New Point(33, 540),
    New Point(33, 559),
    New Point(33, 578),
    New Point(163, 332),
    New Point(163, 351),
    New Point(163, 369),
    New Point(163, 388),
    New Point(163, 407),
    New Point(163, 426),
    New Point(163, 445),
    New Point(163, 464),
    New Point(163, 483),
    New Point(163, 502),
    New Point(163, 521),
    New Point(163, 540),
    New Point(163, 559),
    New Point(163, 578),
    New Point(295, 332),
    New Point(295, 351),
    New Point(295, 369),
    New Point(295, 388),
    New Point(295, 407),
    New Point(295, 426),
    New Point(295, 445),
    New Point(295, 464),
    New Point(295, 483),
    New Point(295, 502),
    New Point(295, 521),
    New Point(295, 540),
    New Point(295, 559),
    New Point(295, 578)
  }
  Public lbl_Qnt_Points = New List(Of Point) From {
    New Point(101, 332),
    New Point(101, 351),
    New Point(101, 369),
    New Point(101, 388),
    New Point(101, 407),
    New Point(101, 426),
    New Point(101, 445),
    New Point(101, 464),
    New Point(101, 483),
    New Point(101, 502),
    New Point(101, 521),
    New Point(101, 540),
    New Point(101, 559),
    New Point(101, 578),
    New Point(231, 332),
    New Point(231, 351),
    New Point(231, 369),
    New Point(231, 388),
    New Point(231, 407),
    New Point(231, 426),
    New Point(231, 445),
    New Point(231, 464),
    New Point(231, 483),
    New Point(231, 502),
    New Point(231, 521),
    New Point(231, 540),
    New Point(231, 559),
    New Point(231, 578),
    New Point(363, 332),
    New Point(363, 351),
    New Point(363, 369),
    New Point(363, 388),
    New Point(363, 407),
    New Point(363, 426),
    New Point(363, 445),
    New Point(363, 464),
    New Point(363, 483),
    New Point(363, 502),
    New Point(363, 521),
    New Point(363, 540),
    New Point(363, 559),
    New Point(363, 578)
  }


  '--- T O K I D R I F T | Constants -------------------------------------------------------------------------------------'
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Const MQTTROOT As String = "kronelab/tokidrift/"
  Private Const MQTTHOST As String = "broker.hivemq.com"
  Private Const MQTTUSER As String = ""
  Private Const MQTTPASS As String = ""
  Private Const MQTTPORT As UShort = 1883
  Private Const MQTTQOFS As Protocol.MqttQualityOfServiceLevel = Protocol.MqttQualityOfServiceLevel.AtMostOnce
  Private Const SEPTCHAR As String = "♥"


  '--- T O K I D R I F T | Structures ------------------------------------------------------------------------------------'
  '-----------------------------------------------------------------------------------------------------------------------'
  Structure OrdineStruct
    Dim Nome As String
    Dim Ordine As String
  End Structure


  '--- T O K I D R I F T | Variables -------------------------------------------------------------------------------------'
  '-----------------------------------------------------------------------------------------------------------------------'
  ReadOnly Ordini As New List(Of OrdineStruct)


  '--- T O K I D R I F T | Private functions -----------------------------------------------------------------------------'
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Function SearchNameInList(ByVal name As String) As Short
    Dim ret As Short = -1
    Dim idx As UShort = 0
    For Each ordine In Ordini
      If ordine.Nome = name Then
        ret = idx
        Exit For
      End If
      idx += 1
    Next
    Return ret
  End Function


  '--- T O K I D R I F T | MQTT Service Functions ------------------------------------------------------------------------'
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Function HandleApplicationMessageReceivedAsync(eventArgs As MqttApplicationMessageReceivedEventArgs) As Task Implements IMqttApplicationMessageReceivedHandler.HandleApplicationMessageReceivedAsync
    Dim payload As String()
    Dim trusted_payload As String
    Dim trusted_topic As String = Decrypt(eventArgs.ApplicationMessage.Topic, True)
    Select Case trusted_topic
      Case MQTTROOT
        Dim recv As OrdineStruct
        Dim idxv As Short
        trusted_payload = Decrypt(System.Text.Encoding.UTF8.GetString(eventArgs.ApplicationMessage.Payload), False)
        payload = trusted_payload.Split(SEPTCHAR)
        recv.Nome = payload(0)
        recv.Ordine = payload(1)
        idxv = SearchNameInList(recv.Nome)
        If idxv >= 0 Then
          Ordini.RemoveAt(idxv)
        End If
        Ordini.Add(recv)
        LblNumOrdini.Text = Ordini.Count
        LstUsers.Clear()
        For Each ordine As OrdineStruct In Ordini
          Dim user As New ListViewItem(New String() {ordine.Nome})
          LstUsers.Items.Add(user)
        Next
    End Select
    Return Nothing
  End Function
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Async Sub MQTTConnectToServer(id As String, uri As String, user As String, pwd As String, port As String)
    Dim messageBuilder As New MqttClientOptionsBuilder
    Dim options As New MqttClientOptions
    Dim cancellationToken As Threading.CancellationToken
    MqttClient = Factory.CreateMqttClient()
    messageBuilder.WithClientId(id)
    messageBuilder.WithCredentials(user, pwd)
    messageBuilder.WithTcpServer(uri, CInt(port))
    messageBuilder.WithCleanSession(True)
    messageBuilder.Build()
    messageBuilder.WithKeepAlivePeriod(TimeSpan.FromSeconds(60))
    Try
      Await MqttClient.ConnectAsync(messageBuilder.Build(), cancellationToken)
    Catch ex As Exception
      LblStatusOrdini.Text = "Chiusi"
    Finally
    End Try
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Async Sub MQTTDisconnectFromServer()
    Await MqttClient.DisconnectAsync()
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Async Sub MQTTSubscribe(ByVal topic As String, qos As Protocol.MqttQualityOfServiceLevel)
    Dim mqttTopicFilterBuilder As New TopicFilterBuilder
    mqttTopicFilterBuilder.WithTopic(topic)
    mqttTopicFilterBuilder.WithQualityOfServiceLevel(qos)
    mqttTopicFilterBuilder.Build()
    Try
      Await MqttClient.SubscribeAsync(mqttTopicFilterBuilder.Build())
    Catch ex As Exception
      LblStatusOrdini.Text = "Chiusi"
    Finally
      LblStatusOrdini.Text = "Aperti"
      BtnAvviaOrdini.Enabled = False
      BtnFermaOrdini.Enabled = True
    End Try
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Function Connect(ByVal user As String) As Boolean
    Dim timeout As Date = Date.Now
    timeout = timeout.AddSeconds(10)
    MQTTConnectToServer(user, MQTTHOST, MQTTUSER, MQTTPASS, MQTTPORT)
    MqttClient.ApplicationMessageReceivedHandler = Me
    While Not MqttClient.IsConnected
      If Date.Now >= timeout Then
        LblStatusOrdini.Text = "Chiusi"
        Return False
      End If
    End While
    Return True
  End Function
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub Disconnect()
    MQTTDisconnectFromServer()
    While MqttClient.IsConnected

    End While
  End Sub


  '--- T O K I D R I F T | Decryption ------------------------------------------------------------------------------------'
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Function Encrypt(ByVal encodedata As String, ByVal optopic As Boolean) As String
    Dim wrapper As New Simple3Des("Sashimi69")
    Dim cipherText As String = wrapper.EncryptData(encodedata)
    If optopic Then
      Dim strdebug As String = cipherText.Replace("+", "!").Replace("/", "?")
      Return strdebug
    Else
      Return cipherText
    End If
  End Function
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Function Decrypt(ByVal decodedata As String, ByVal optopic As Boolean) As String
    Dim wrapper As New Simple3Des("Sashimi69")
    Try
      If optopic Then
        Return wrapper.DecryptData(decodedata.Replace("!", "+").Replace("?", "/"))
      Else
        Return wrapper.DecryptData(decodedata)
      End If
    Catch ex As Security.Cryptography.CryptographicException
      Return "crypt err"
    End Try
  End Function


  '--- T O K I D R I F T | User Interface --------------------------------------------------------------------------------'
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub CommandCenter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    CheckForIllegalCrossThreadCalls = False
    Ordini.Clear()
    LstUsers.Clear()
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnAvviaOrdini_Click(sender As Object, e As EventArgs) Handles BtnAvviaOrdini.Click
    If Connect("MasterSashimi") Then
      MQTTSubscribe(Encrypt(MQTTROOT, True), MQTTQOFS)
    End If
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnFermaOrdini_Click(sender As Object, e As EventArgs) Handles BtnFermaOrdini.Click
    Disconnect()
    BtnFermaOrdini.Enabled = False
    BtnAvviaOrdini.Enabled = True
    LblStatusOrdini.Text = "Chiusi"
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnEsportaOrdini_Click(sender As Object, e As EventArgs) Handles BtnEsportaOrdini.Click
    Dim ListaUtenti As New List(Of String)
    Dim ListaPiatti As New List(Of String)
    Dim ListaPortate As New List(Of String)
    Dim piatto As String()
    Dim tstr As String()
    Dim DT As String = Date.Now().ToString
    Dim file As IO.StreamWriter

    file = My.Computer.FileSystem.OpenTextFileWriter("Ordine.txt", True)
    file.WriteLine(DT)
    file.WriteLine("O R D I N I   S I N G O L I")

    If Ordini.Count > 0 Then
      tstr = Ordini(0).Ordine.Split(";")
      For i = 0 To tstr.Count - 2
        piatto = tstr(i).Split(".")
        ListaPiatti.Add(piatto(0))
        ListaPortate.Add("0")
      Next
      For Each ordine In Ordini
        file.WriteLine("> " & ordine.Nome)
        tstr = ordine.Ordine.Split(";")                 ' separazione coppie piatto.portata
        For i = 0 To tstr.Count - 2
          Dim tempint As UInt16
          piatto = tstr(i).Split(".")                   ' separazione piatto (piatto(0)) e portate (piatto(1))
          tempint = Convert.ToUInt16(ListaPortate(i))   ' leggo il numero attuale di portate
          tempint += Convert.ToUInt16(piatto(1))        ' aggiungo il numero di portate alla somma
          ListaPortate(i) = tempint.ToString            ' converto la nuova somma portate in stringa
          If piatto(1) <> 0 Then
            file.WriteLine("  " & piatto(0) & " " & piatto(1))
          End If
        Next
      Next
      file.WriteLine("O R D I N E   F I N A L E")
      Dim index As UShort = 0
      For Each lst In ListaPiatti
        If ListaPortate(index) <> 0 Then
          file.WriteLine(ListaPiatti(index) & " " & ListaPortate(index))
        End If
        index += 1
      Next
      MsgBox("Ordine esportato")
      file.Close()
    End If
  End Sub
End Class
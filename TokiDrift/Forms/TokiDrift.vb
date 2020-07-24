Imports MQTTnet
Imports MQTTnet.Client.Options
Imports MQTTnet.Client

Public Class TokiDrift
  Private ReadOnly Factory As New MqttFactory
  Private WithEvents MqttClient As MqttClient


  '--- T O K I D R I F T | Constants -------------------------------------------------------------------------------------'
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Const MQTTROOT As String = "kronelab/tokidrift/"
  Private Const MQTTHOST As String = "broker.hivemq.com"
  Private Const MQTTUSER As String = ""
  Private Const MQTTPASS As String = ""
  Private Const MQTTPORT As UShort = 1883
  Private Const MQTTQOFS As Protocol.MqttQualityOfServiceLevel = Protocol.MqttQualityOfServiceLevel.AtMostOnce
  Private Const SEPTCHAR As String = "♥"


  '--- T O K I D R I F T | ReadOnly --------------------------------------------------------------------------------------'
  '-----------------------------------------------------------------------------------------------------------------------'
  ReadOnly SfondiMenu() = {
    My.Resources.TokiDrift01, My.Resources.TokiDrift02, My.Resources.TokiDrift03, My.Resources.TokiDrift04, My.Resources.TokiDrift05, My.Resources.TokiDrift06,
    My.Resources.TokiDrift07, My.Resources.TokiDrift08, My.Resources.TokiDrift09, My.Resources.TokiDrift10, My.Resources.TokiDrift11, My.Resources.TokiDrift12,
    My.Resources.TokiDrift13, My.Resources.TokiDrift14, My.Resources.TokiDrift15, My.Resources.TokiDrift16, My.Resources.TokiDrift17, My.Resources.TokiDrift18,
    My.Resources.TokiDrift19, My.Resources.TokiDrift20, My.Resources.TokiDrift21, My.Resources.TokiDrift22, My.Resources.TokiDrift23, My.Resources.TokiDrift24,
    My.Resources.TokiDrift25, My.Resources.TokiDrift26, My.Resources.TokiDrift27, My.Resources.TokiDrift28, My.Resources.TokiDrift29, My.Resources.TokiDrift30,
    My.Resources.TokiDrift31, My.Resources.TokiDrift32, My.Resources.TokiDrift33, My.Resources.TokiDrift34, My.Resources.TokiDrift35, My.Resources.TokiDrift36,
    My.Resources.TokiDrift37, My.Resources.TokiDrift38, My.Resources.TokiDrift39, My.Resources.TokiDrift40
  }
  '-----------------------------------------------------------------------------------------------------------------------'
  ReadOnly ID_PiattiTot() = {
    1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 18, 19, 17, 16, 20, 21, 30, 31, 32, 33, 40, 46, 41, 48, 42, 43, 45, 44, 47, 60, 61, 62, 63, 64, 65, 66, 67, 68, 80, 81, 82,
    83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 101, 102, 100, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 123, 122, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134,
    135, 136, 137, 138, 150, 151, 152, 153, 154, 155, 156, 157, 170, 171, 172, 173, 174, 175, 176, 177, 178, 179, 180, 181, 182, 183, 184, 185, 186, 187, 188, 183, 190, 191, 192, 193
  }
  '-----------------------------------------------------------------------------------------------------------------------'
  ReadOnly ArrayPagePointer() = {
    0, 4, 7, 10, 13, 17, 19, 21, 25, 27, 30, 32, 34, 37, 40, 43, 47, 51, 53, 56, 59, 62, 66, 69, 73, 76, 80, 83, 86, 88, 91, 94, 96, 99, 102, 105, 109, 112, 116, 118
  }
  '-----------------------------------------------------------------------------------------------------------------------'
  ReadOnly NofPiattiPerPagePRANZO() = {
    4, 3, 3, 3, 4, 2, 2, 4, 2, 3, 2, 2, 3, 3, 3, 4, 4, 2, 3, 3, 3, 4, 3, 4, 3, 4, 3, 3, 2, 3, 3, 2, 3, 3, 3, 4, 3, 4, 2, 2
  }
  '-----------------------------------------------------------------------------------------------------------------------'
  ReadOnly CoordinateXP1() = {
    3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318
  }
  '-----------------------------------------------------------------------------------------------------------------------'
  ReadOnly CoordinateYP1() = {
    80, 118, 110, 93, 67, 176, 163, 76, 162, 34, 118, 92, 93, 113, 100, 57, 57, 129, 85, 99, 97, 44, 102, 46, 92, 39, 87, 69, 133, 99, 75, 141, 107, 96, 100,
    59, 112, 56, 118, 83
  }
  '-----------------------------------------------------------------------------------------------------------------------'
  ReadOnly CoordinateXP2() = {
    3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318
  }
  '-----------------------------------------------------------------------------------------------------------------------'
  ReadOnly CoordinateYP2() = {
    204, 269, 251, 249, 185, 346, 339, 202, 332, 193, 434, 366, 247, 259, 266, 180, 181, 412, 259, 264, 258, 183, 252, 188, 256, 183, 252, 244, 351, 258, 245,
    433, 265, 265, 262, 190, 296, 188, 372, 304
  }
  '-----------------------------------------------------------------------------------------------------------------------'
  ReadOnly CoordinateXP3() = {
    3, 318, 3, 318, 3, 0, 0, 318, 0, 318, 0, 0, 3, 318, 3, 318, 3, 0, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 0, 318, 3, 0, 3, 318, 3, 318, 3, 318, 0, 0
  }
  '-----------------------------------------------------------------------------------------------------------------------'
  ReadOnly CoordinateYP3() = {
    327, 424, 434, 423, 311, 0, 0, 316, 0, 422, 0, 0, 400, 422, 402, 312, 309, 0, 446, 430, 415, 291, 415, 311, 415, 305, 428, 428, 0, 428, 428, 0, 429, 426, 429,
    294, 437, 299, 0, 0
  }
  '-----------------------------------------------------------------------------------------------------------------------'
  ReadOnly CoordinateXP4() = {
    3, 0, 0, 0, 3, 0, 0, 318, 0, 0, 0, 0, 0, 0, 0, 318, 3, 0, 0, 0, 0, 318, 0, 318, 0, 318, 0, 0, 0, 0, 0, 0, 0, 0, 0, 318, 0, 318, 0, 0
  }
  '-----------------------------------------------------------------------------------------------------------------------'
  ReadOnly CoordinateYP4() = {
    444, 0, 0, 0, 434, 0, 0, 437, 0, 0, 0, 0, 0, 0, 0, 411, 439, 0, 0, 0, 0, 435, 0, 441, 0, 437, 0, 0, 0, 0, 0, 0, 0, 0, 0, 444, 0, 442, 0, 0
  }
  '-----------------------------------------------------------------------------------------------------------------------'
  ReadOnly GruppoPannelli As New List(Of Panel)
  ReadOnly SelezioneTotale(ID_PiattiTot.Length - 1)
  ReadOnly PagineLaunch As Integer = 40
  ReadOnly PagAntipasti As Integer = 0
  ReadOnly PagChirashi As Integer = 7
  ReadOnly PagGunkan As Integer = 8
  ReadOnly PagHosomaki As Integer = 12
  ReadOnly PagNigiri As Integer = 15
  ReadOnly PagSashimi As Integer = 19
  ReadOnly PagUramaki As Integer = 20
  ReadOnly PagTemaki As Integer = 29
  ReadOnly PagPiattiCaldi As Integer = 32


  '--- T O K I D R I F T | Variables -------------------------------------------------------------------------------------'
  '-----------------------------------------------------------------------------------------------------------------------'
  Dim PageIndex As Integer = 0
  Dim indexchanged As Boolean = False


  '--- T O K I D R I F T | Private Functions -----------------------------------------------------------------------------'
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub TokiDrift_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    For i As Integer = 0 To SelezioneTotale.Length - 1
      SelezioneTotale(i) = 0
    Next
    GruppoPannelli.Add(Pnl1)
    GruppoPannelli.Add(Pnl2)
    GruppoPannelli.Add(Pnl3)
    GruppoPannelli.Add(Pnl4)
    TrvBookMark.SelectedNode = Nothing
    PnlPages.BackgroundImage = My.Resources.TokiDrift01
    Pnl1.Location = New Point(CoordinateXP1(0), CoordinateYP1(0))
    Pnl2.Location = New Point(CoordinateXP2(0), CoordinateYP2(0))
    Pnl3.Location = New Point(CoordinateXP3(0), CoordinateYP3(0))
    Pnl4.Location = New Point(CoordinateXP4(0), CoordinateYP4(0))
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnInc01_Click(sender As Object, e As EventArgs) Handles BtnInc1.Click
    If (ArrayPagePointer(PageIndex) <> 17) And (ArrayPagePointer(PageIndex) <> 56) Then
      TxtQnt1.Text += 1
      SelezioneTotale(ArrayPagePointer(PageIndex)) = Convert.ToInt32(TxtQnt1.Text)
    Else
      If TxtQnt1.Text = 0 Then
        TxtQnt1.Text += 1
        SelezioneTotale(ArrayPagePointer(PageIndex)) = Convert.ToInt32(TxtQnt1.Text)
      Else
        MessageBox.Show(My.Settings.Str_NmaxTxt, My.Settings.Str_NmaxTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
    End If
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnDec01_Click(sender As Object, e As EventArgs) Handles BtnDec1.Click
    If TxtQnt1.Text > 0 Then
      TxtQnt1.Text -= 1
      SelezioneTotale(ArrayPagePointer(PageIndex)) = Convert.ToInt32(TxtQnt1.Text)
    End If
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnInc02_Click(sender As Object, e As EventArgs) Handles BtnInc2.Click
    If (ArrayPagePointer(PageIndex) <> 17) And (ArrayPagePointer(PageIndex) <> 56) Then
      TxtQnt2.Text += 1
      SelezioneTotale(ArrayPagePointer(PageIndex) + 1) = Convert.ToInt32(TxtQnt2.Text)
    Else
      If TxtQnt2.Text = 0 Then
        TxtQnt2.Text += 1
        SelezioneTotale(ArrayPagePointer(PageIndex) + 1) = Convert.ToInt32(TxtQnt2.Text)
      Else
        MessageBox.Show(My.Settings.Str_NmaxTxt, My.Settings.Str_NmaxTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
    End If

  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnDec02_Click(sender As Object, e As EventArgs) Handles BtnDec2.Click
    If TxtQnt2.Text > 0 Then
      TxtQnt2.Text -= 1
      SelezioneTotale(ArrayPagePointer(PageIndex) + 1) = Convert.ToInt32(TxtQnt2.Text)
    End If
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnInc03_Click(sender As Object, e As EventArgs) Handles BtnInc3.Click
    If (ArrayPagePointer(PageIndex) <> 56) Then
      TxtQnt3.Text += 1
      SelezioneTotale(ArrayPagePointer(PageIndex) + 2) = Convert.ToInt32(TxtQnt3.Text)
    Else
      If TxtQnt3.Text = 0 Then
        TxtQnt3.Text += 1
        SelezioneTotale(ArrayPagePointer(PageIndex) + 2) = Convert.ToInt32(TxtQnt3.Text)
      Else
        MessageBox.Show(My.Settings.Str_NmaxTxt, My.Settings.Str_NmaxTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
    End If

  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnDec03_Click(sender As Object, e As EventArgs) Handles BtnDec3.Click
    If TxtQnt3.Text > 0 Then
      TxtQnt3.Text -= 1
      SelezioneTotale(ArrayPagePointer(PageIndex) + 2) = Convert.ToInt32(TxtQnt3.Text)
    End If
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnInc04_Click(sender As Object, e As EventArgs) Handles BtnInc4.Click
    TxtQnt4.Text += 1
    SelezioneTotale(ArrayPagePointer(PageIndex) + 3) = Convert.ToInt32(TxtQnt4.Text)
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnDec04_Click(sender As Object, e As EventArgs) Handles BtnDec4.Click
    If TxtQnt4.Text > 0 Then
      TxtQnt4.Text -= 1
      SelezioneTotale(ArrayPagePointer(PageIndex) + 3) = Convert.ToInt32(TxtQnt4.Text)
    End If
  End Sub
  Private Sub RelocateButtons()
    Select Case NofPiattiPerPagePRANZO(PageIndex)
      Case 2
        Pnl3.Visible = False
        Pnl4.Visible = False
      Case 3
        Pnl3.Visible = True
        Pnl4.Visible = False
      Case 4
        Pnl3.Visible = True
        Pnl4.Visible = True
    End Select
    For i As Integer = 0 To NofPiattiPerPagePRANZO(PageIndex) - 1
      Select Case i
        Case 0
          GruppoPannelli(i).Location = New Point(CoordinateXP1(PageIndex), CoordinateYP1(PageIndex))
        Case 1
          GruppoPannelli(i).Location = New Point(CoordinateXP2(PageIndex), CoordinateYP2(PageIndex))
        Case 2
          GruppoPannelli(i).Location = New Point(CoordinateXP3(PageIndex), CoordinateYP3(PageIndex))
        Case 3
          GruppoPannelli(i).Location = New Point(CoordinateXP4(PageIndex), CoordinateYP4(PageIndex))
      End Select
    Next
    TxtQnt1.Text = SelezioneTotale(ArrayPagePointer(PageIndex))
    TxtQnt2.Text = SelezioneTotale(ArrayPagePointer(PageIndex) + 1)
    If PageIndex < ArrayPagePointer.Length - 1 Then
      TxtQnt3.Text = SelezioneTotale(ArrayPagePointer(PageIndex) + 2)
      TxtQnt4.Text = SelezioneTotale(ArrayPagePointer(PageIndex) + 3)
    End If
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnNext01_Click_1(sender As Object, e As EventArgs) Handles BtnNext01.Click
    If PictureBox1.Image IsNot My.Resources.TokiDriftFoodBkg Then
      PictureBox1.Image = My.Resources.TokiDriftFoodBkg
    End If
    If PageIndex < PagineLaunch - 1 Then
      indexchanged = True
      PageIndex += 1
      RelocateButtons()
    End If
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnPrev01_Click_1(sender As Object, e As EventArgs) Handles BtnPrev01.Click
    If PictureBox1.Image IsNot My.Resources.TokiDriftFoodBkg Then
      PictureBox1.Image = My.Resources.TokiDriftFoodBkg
    End If
    If PageIndex > 0 Then
      indexchanged = True
      PageIndex -= 1
      RelocateButtons()
    End If
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub RefreshTimer_Tick(sender As Object, e As EventArgs) Handles RefreshTimer.Tick
    If indexchanged = True Then
      indexchanged = False
      PnlPages.BackgroundImage = SfondiMenu(PageIndex)
    End If
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnCancellaOrdine_Click(sender As Object, e As EventArgs) Handles BtnCancellaOrdine.Click
    For i As Integer = 0 To SelezioneTotale.Length - 1
      SelezioneTotale(i) = 0
    Next
    TxtQnt1.Text = "0"
    TxtQnt2.Text = "0"
    TxtQnt3.Text = "0"
    TxtQnt4.Text = "0"
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnStartOrdine_Click(sender As Object, e As EventArgs) Handles BtnStartOrdine.Click
    If TxtUser.Text <> "inserisci utente" And TxtUser.Text <> "" Then
      Dim str_Order As String = ""
      For i As Integer = 0 To ID_PiattiTot.Length - 1
        str_Order = str_Order & ID_PiattiTot(i) & "." & SelezioneTotale(i) & ";"
      Next
      If Connect(TxtUser.Text) Then
        SendMessage(TxtUser.Text, str_Order)
      End If
      MsgBox(str_Order)
    Else
      MsgBox("Insert thy name")
      TxtUser.Focus()
    End If
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnResoconto_Click(sender As Object, e As EventArgs) Handles BtnResoconto.Click
    For i As Integer = 0 To SelezioneTotale.Length - 1
      Resoconto.dgv_Resoconto.Rows.Add()
    Next
    For i As Integer = 0 To SelezioneTotale.Length - 1
      Resoconto.dgv_Resoconto.Item(Resoconto.clm_IdPiatto.Index, i).Value = ID_PiattiTot(i)
    Next
    For i As Integer = 0 To SelezioneTotale.Length - 1
      Resoconto.dgv_Resoconto.Item(Resoconto.clm_Qnt.Index, i).Value = SelezioneTotale(i)
    Next
    Resoconto.ShowDialog()
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub TxtUser_Click(sender As Object, e As EventArgs) Handles TxtUser.Click
    If TxtUser.Text = "inserisci utente" Then
      TxtUser.Text = ""
    End If
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub TrvBookMark_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TrvBookMark.AfterSelect
    Static PrimoClick As String = ""
    Select Case e.Node.Name
      Case "nd_Antipasti"
        If PrimoClick <> "Antipasti" Then
          PrimoClick = "Antipasti"
          PictureBox1.Image = My.Resources.Antipasti
        Else
          PageIndex = PagAntipasti
          indexchanged = True
        End If
      Case "nd_Chirashi"
        If PrimoClick <> "Chirashi" Then
          PrimoClick = "Chirashi"
          PictureBox1.Image = My.Resources.Chirashi
        Else
          PageIndex = PagChirashi
          indexchanged = True
        End If
      Case "nd_Gunkan"
        If PrimoClick <> "Gunkan" Then
          PrimoClick = "Gunkan"
          PictureBox1.Image = My.Resources.Gunkan
        Else
          PageIndex = PagGunkan
          indexchanged = True
        End If
      Case "nd_Hosomaki"
        If PrimoClick <> "Hosomaki" Then
          PrimoClick = "Hosomaki"
          PictureBox1.Image = My.Resources.Hosomaki
        Else
          PageIndex = PagHosomaki
          indexchanged = True
        End If
      Case "nd_Nigiri"
        If PrimoClick <> "Nigiri" Then
          PrimoClick = "Nigiri"
          PictureBox1.Image = My.Resources.Nigiri
        Else
          PageIndex = PagNigiri
          indexchanged = True
        End If
      Case "nd_Sashimi"
        If PrimoClick <> "Sashimi" Then
          PrimoClick = "Sashimi"
          PictureBox1.Image = My.Resources.Sashimi
        Else
          PageIndex = PagSashimi
          indexchanged = True
        End If
      Case "nd_Uramaki"
        If PrimoClick <> "Uramaki" Then
          PrimoClick = "Uramaki"
          PictureBox1.Image = My.Resources.Uramaki
        Else
          PageIndex = PagUramaki
          indexchanged = True
        End If
      Case "nd_Temaki"
        If PrimoClick <> "Temaki" Then
          PrimoClick = "Temaki"
          PictureBox1.Image = My.Resources.Temaki
        Else
          PageIndex = PagTemaki
          indexchanged = True
        End If
      Case "nd_PiattiCaldi"
        If PrimoClick <> "Caldo" Then
          PrimoClick = "Caldo"
          PictureBox1.Image = My.Resources.PiattiCaldi
        Else
          PageIndex = PagPiattiCaldi
          indexchanged = True
        End If
    End Select
    If indexchanged = True Then
      RelocateButtons()
    End If
    TrvBookMark.SelectedNode = Nothing
  End Sub


  '--- T O K I D R I F T | MQTT management -------------------------------------------------------------------------------'
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
    Finally
    End Try
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Async Sub MQTTDisconnectFromServer()
    Await MqttClient.DisconnectAsync()
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Async Sub MQTTPublish(topic As String, payload As String, retainFlag As Boolean, qos As Protocol.MqttQualityOfServiceLevel)
    Dim mqttMessageBulder As New MqttApplicationMessageBuilder
    Dim mqttMessage As MqttApplicationMessage
    Dim cancellationToken As Threading.CancellationToken
    mqttMessageBulder.WithTopic(topic)
    mqttMessageBulder.WithPayload(payload)
    mqttMessageBulder.WithQualityOfServiceLevel(qos)
    mqttMessageBulder.WithRetainFlag(retainFlag)
    mqttMessage = mqttMessageBulder.Build()
    Try
      Await MqttClient.PublishAsync(mqttMessage, cancellationToken)
    Catch ex As Exception
      MsgBox("Order in void")
    Finally
      MsgBox("Order in space")
    End Try
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Function Connect(ByVal user As String) As Boolean
    Dim timeout As Date = Date.Now
    timeout = timeout.AddSeconds(10)
    MQTTConnectToServer(user, MQTTHOST, MQTTUSER, MQTTPASS, MQTTPORT)
    While Not MqttClient.IsConnected
      If Date.Now >= timeout Then
        Return False
      End If
    End While
    Return True
  End Function
  '-----------------------------------------------------------------------------------------------------------------------'
  Public Function SendMessage(ByVal user As String, ByVal text As String) As Boolean
    MQTTPublish(Encrypt(MQTTROOT, True), Encrypt(user & SEPTCHAR & text, False), False, MQTTQOFS)
    Return True
  End Function


  '--- T O K I D R I F T | Encryption ------------------------------------------------------------------------------------'
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Function Encrypt(ByVal encodedata As String, ByVal optopic As Boolean) As String
    Dim wrapper As New Simple3Des("Sashimi69")
    Dim cipherText As String = wrapper.EncryptData(encodedata)
    If optopic Then
      Return cipherText.Replace("+", "!").Replace("/", "?")
    Else
      Return cipherText
    End If
  End Function
End Class

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
  Public ReadOnly SfondiMenu() = {
    My.Resources.TokiDrift01, My.Resources.TokiDrift02, My.Resources.TokiDrift03, My.Resources.TokiDrift04, My.Resources.TokiDrift05, My.Resources.TokiDrift07,
    My.Resources.TokiDrift08, My.Resources.TokiDrift09, My.Resources.TokiDrift10, My.Resources.TokiDrift11, My.Resources.TokiDrift12, My.Resources.TokiDrift13,
    My.Resources.TokiDrift14, My.Resources.TokiDrift15, My.Resources.TokiDrift16, My.Resources.TokiDrift17, My.Resources.TokiDrift18, My.Resources.TokiDrift19,
    My.Resources.TokiDrift20, My.Resources.TokiDrift21, My.Resources.TokiDrift22, My.Resources.TokiDrift23, My.Resources.TokiDrift24, My.Resources.TokiDrift25,
    My.Resources.TokiDrift26, My.Resources.TokiDrift27, My.Resources.TokiDrift28, My.Resources.TokiDrift29, My.Resources.TokiDrift30, My.Resources.TokiDrift31,
    My.Resources.TokiDrift32, My.Resources.TokiDrift33, My.Resources.TokiDrift34, My.Resources.TokiDrift35, My.Resources.TokiDrift36, My.Resources.TokiDrift37,
    My.Resources.TokiDrift38, My.Resources.TokiDrift39, My.Resources.TokiDrift40
  }

  Public ReadOnly RectList = New List(Of Rectangle) From {
    New Rectangle(780, 191, 671, 548),
    New Rectangle(189, 725, 674, 572),
    New Rectangle(855, 1262, 536, 536),
    New Rectangle(320, 1830, 547, 545),
    New Rectangle(151, 256, 640, 638),
    New Rectangle(83, 954, 623, 586),
    New Rectangle(482, 1658, 651, 597),
    New Rectangle(282, 355, 563, 459),
    New Rectangle(641, 1113, 607, 608),
    New Rectangle(796, 1868, 371, 371),
    New Rectangle(189, 252, 537, 537),
    New Rectangle(557, 940, 477, 477),
    New Rectangle(280, 1631, 905, 543),
    New Rectangle(338, 262, 594, 366),
    New Rectangle(819, 693, 559, 559),
    New Rectangle(411, 1316, 503, 503),
    New Rectangle(874, 1835, 462, 462),
    New Rectangle(490, 276, 597, 302),
    New Rectangle(308, 613, 743, 423),
    New Rectangle(350, 1063, 584, 573),
    New Rectangle(356, 1676, 550, 527),
    New Rectangle(132, 249, 457, 358),
    New Rectangle(669, 769, 490, 389),
    New Rectangle(150, 1282, 520, 519),
    New Rectangle(711, 1833, 497, 384),
    New Rectangle(747, 383, 706, 706),
    New Rectangle(395, 1395, 755, 755),
    New Rectangle(674, 52, 613, 481),
    New Rectangle(548, 705, 820, 784),
    New Rectangle(80, 1604, 661, 666),
    New Rectangle(524, 408, 746, 746),
    New Rectangle(238, 1158, 783, 709),
    New Rectangle(4, 435, 847, 887),
    New Rectangle(520, 1397, 859, 825),
    New Rectangle(465, 355, 383, 383),
    New Rectangle(952, 1080, 343, 343),
    New Rectangle(281, 1686, 403, 403),
    New Rectangle(181, 341, 403, 351),
    New Rectangle(703, 1099, 340, 340),
    New Rectangle(227, 1778, 337, 337),
    New Rectangle(381, 424, 340, 340),
    New Rectangle(982, 1171, 270, 270),
    New Rectangle(355, 1681, 343, 343),
    New Rectangle(203, 183, 544, 544),
    New Rectangle(708, 689, 517, 517),
    New Rectangle(699, 1222, 444, 444),
    New Rectangle(270, 1880, 388, 388),
    New Rectangle(667, 118, 556, 556),
    New Rectangle(735, 740, 461, 461),
    New Rectangle(364, 1365, 423, 423),
    New Rectangle(686, 1830, 440, 440),
    New Rectangle(496, 592, 515, 515),
    New Rectangle(253, 1366, 434, 434),
    New Rectangle(893, 345, 460, 443),
    New Rectangle(309, 1052, 583, 417),
    New Rectangle(810, 1788, 450, 446),
    New Rectangle(62, 221, 811, 585),
    New Rectangle(483, 957, 850, 661),
    New Rectangle(36, 1628, 952, 642),
    New Rectangle(378, 421, 703, 448),
    New Rectangle(680, 1011, 765, 543),
    New Rectangle(348, 1625, 581, 581),
    New Rectangle(500, 112, 531, 531),
    New Rectangle(405, 717, 515, 404),
    New Rectangle(709, 1249, 431, 362),
    New Rectangle(207, 1781, 595, 507),
    New Rectangle(626, 321, 821, 524),
    New Rectangle(212, 860, 854, 698),
    New Rectangle(687, 1631, 755, 587),
    New Rectangle(504, 255, 603, 465),
    New Rectangle(349, 753, 476, 476),
    New Rectangle(559, 1259, 708, 513),
    New Rectangle(251, 1802, 584, 517),
    New Rectangle(330, 222, 683, 583),
    New Rectangle(854, 956, 599, 593),
    New Rectangle(261, 1723, 672, 577),
    New Rectangle(610, 22, 704, 588),
    New Rectangle(165, 598, 711, 568),
    New Rectangle(559, 1262, 505, 505),
    New Rectangle(150, 1819, 522, 441),
    New Rectangle(420, 257, 602, 526),
    New Rectangle(704, 962, 753, 557),
    New Rectangle(271, 1639, 711, 616),
    New Rectangle(467, 69, 819, 654),
    New Rectangle(358, 979, 599, 402),
    New Rectangle(106, 1539, 738, 716),
    New Rectangle(746, 517, 633, 502),
    New Rectangle(386, 1393, 441, 421),
    New Rectangle(126, 225, 729, 675),
    New Rectangle(553, 988, 803, 580),
    New Rectangle(73, 1669, 770, 592),
    New Rectangle(766, 120, 729, 524),
    New Rectangle(257, 788, 786, 580),
    New Rectangle(608, 1433, 851, 570),
    New Rectangle(109, 413, 778, 645),
    New Rectangle(599, 1279, 741, 569),
    New Rectangle(243, 315, 645, 532),
    New Rectangle(964, 943, 541, 455),
    New Rectangle(289, 1614, 648, 573),
    New Rectangle(85, 297, 622, 475),
    New Rectangle(593, 968, 652, 520),
    New Rectangle(62, 1661, 638, 529),
    New Rectangle(771, 279, 651, 501),
    New Rectangle(229, 928, 698, 634),
    New Rectangle(728, 1724, 760, 610),
    New Rectangle(62, 138, 759, 586),
    New Rectangle(630, 672, 701, 545),
    New Rectangle(46, 1160, 609, 479),
    New Rectangle(629, 1735, 657, 595),
    New Rectangle(689, 236, 797, 589),
    New Rectangle(410, 1030, 540, 498),
    New Rectangle(648, 1648, 794, 662),
    New Rectangle(71, 66, 748, 655),
    New Rectangle(596, 689, 693, 529),
    New Rectangle(59, 1181, 745, 614),
    New Rectangle(590, 1759, 703, 580),
    New Rectangle(708, 394, 738, 689),
    New Rectangle(667, 1682, 691, 591),
    New Rectangle(120, 411, 633, 552),
    New Rectangle(109, 1528, 1197, 833)
  }

  ReadOnly ListaNomi = New List(Of String) From {
    My.Resources.str_Plate_1, My.Resources.str_Plate_2, My.Resources.str_Plate_3, My.Resources.str_Plate_4,
    My.Resources.str_Plate_5, My.Resources.str_Plate_6, My.Resources.str_Plate_7,
    My.Resources.str_Plate_8, My.Resources.str_Plate_9, My.Resources.str_Plate_10,
    My.Resources.str_Plate_11, My.Resources.str_Plate_12, My.Resources.str_Plate_13,
    My.Resources.str_Plate_14, My.Resources.str_Plate_15, My.Resources.str_Plate_18, My.Resources.str_Plate_19,
    My.Resources.str_Plate_21B, My.Resources.str_Plate_258, My.Resources.str_Plate_20, My.Resources.str_Plate_21,
    My.Resources.str_Plate_30, My.Resources.str_Plate_31, My.Resources.str_Plate_32, My.Resources.str_Plate_33,
    My.Resources.str_Plate_40, My.Resources.str_Plate_46,
    My.Resources.str_Plate_41, My.Resources.str_Plate_48, My.Resources.str_Plate_42,
    My.Resources.str_Plate_43, My.Resources.str_Plate_45,
    My.Resources.str_Plate_44, My.Resources.str_Plate_47,
    My.Resources.str_Plate_60, My.Resources.str_Plate_61, My.Resources.str_Plate_62,
    My.Resources.str_Plate_63, My.Resources.str_Plate_64, My.Resources.str_Plate_65,
    My.Resources.str_Plate_66, My.Resources.str_Plate_67, My.Resources.str_Plate_68,
    My.Resources.str_Plate_80, My.Resources.str_Plate_81, My.Resources.str_Plate_82, My.Resources.str_Plate_83,
    My.Resources.str_Plate_84, My.Resources.str_Plate_85, My.Resources.str_Plate_86, My.Resources.str_Plate_87,
    My.Resources.str_Plate_88, My.Resources.str_Plate_89,
    My.Resources.str_Plate_90, My.Resources.str_Plate_91, My.Resources.str_Plate_92,
    My.Resources.str_Plate_101, My.Resources.str_Plate_102, My.Resources.str_Plate_100,
    My.Resources.str_Plate_110, My.Resources.str_Plate_111, My.Resources.str_Plate_112,
    My.Resources.str_Plate_113, My.Resources.str_Plate_114, My.Resources.str_Plate_115, My.Resources.str_Plate_116,
    My.Resources.str_Plate_117, My.Resources.str_Plate_118, My.Resources.str_Plate_119,
    My.Resources.str_Plate_120, My.Resources.str_Plate_121, My.Resources.str_Plate_123, My.Resources.str_Plate_122,
    My.Resources.str_Plate_124, My.Resources.str_Plate_125, My.Resources.str_Plate_126,
    My.Resources.str_Plate_127, My.Resources.str_Plate_128, My.Resources.str_Plate_129, My.Resources.str_Plate_130,
    My.Resources.str_Plate_131, My.Resources.str_Plate_132, My.Resources.str_Plate_133,
    My.Resources.str_Plate_134, My.Resources.str_Plate_135, My.Resources.str_Plate_136,
    My.Resources.str_Plate_137, My.Resources.str_Plate_138,
    My.Resources.str_Plate_150, My.Resources.str_Plate_151, My.Resources.str_Plate_152,
    My.Resources.str_Plate_153, My.Resources.str_Plate_154, My.Resources.str_Plate_155,
    My.Resources.str_Plate_156, My.Resources.str_Plate_157,
    My.Resources.str_Plate_170, My.Resources.str_Plate_171, My.Resources.str_Plate_172,
    My.Resources.str_Plate_173, My.Resources.str_Plate_174, My.Resources.str_Plate_175,
    My.Resources.str_Plate_176, My.Resources.str_Plate_177, My.Resources.str_Plate_178,
    My.Resources.str_Plate_179, My.Resources.str_Plate_180, My.Resources.str_Plate_181, My.Resources.str_Plate_182,
    My.Resources.str_Plate_183, My.Resources.str_Plate_184, My.Resources.str_Plate_185,
    My.Resources.str_Plate_186, My.Resources.str_Plate_187, My.Resources.str_Plate_188, My.Resources.str_Plate_189,
    My.Resources.str_Plate_190, My.Resources.str_Plate_191,
    My.Resources.str_Plate_192, My.Resources.str_Plate_193
  }
  '-----------------------------------------------------------------------------------------------------------------------'
  Public ReadOnly ID_PiattiTot() As String = {
    1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 18, 19, "21/B", 258, 20, 21, 30, 31, 32, 33, 40, 46, 41, 48, 42, 43, 45, 44, 47, 60, 61, 62, 63, 64, 65, 66, 67, 68, 80, 81, 82,
    83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 101, 102, 100, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 123, 122, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134,
    135, 136, 137, 138, 150, 151, 152, 153, 154, 155, 156, 157, 170, 171, 172, 173, 174, 175, 176, 177, 178, 179, 180, 181, 182, 183, 184, 185, 186, 187, 188, 189, 190, 191, 192, 193
  }
  '-----------------------------------------------------------------------------------------------------------------------'
  ReadOnly ArrayPagePointer() = {
    0, 4, 7, 10, 13, 17, 21, 25, 27, 30, 32, 34, 37, 40, 43, 47, 51, 53, 56, 59, 62, 66, 69, 73, 76, 80, 83, 86, 88, 91, 94, 96, 99, 102, 105, 109, 112, 116, 118
  }
  '-----------------------------------------------------------------------------------------------------------------------'
  ReadOnly NofPiattiPerPagePRANZO() = {
    4, 3, 3, 3, 4, 4, 4, 2, 3, 2, 2, 3, 3, 3, 4, 4, 2, 3, 3, 3, 4, 3, 4, 3, 4, 3, 3, 2, 3, 3, 2, 3, 3, 3, 4, 3, 4, 2, 2
  }
  '-----------------------------------------------------------------------------------------------------------------------'
  ReadOnly CoordinateXP1() = {
    3, 318, 3, 318, 3, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318
  }
  '-----------------------------------------------------------------------------------------------------------------------'
  ReadOnly CoordinateYP1() = {
    80, 118, 110, 93, 67, 67, 76, 162, 34, 118, 92, 93, 113, 100, 57, 57, 129, 85, 99, 97, 44, 102, 46, 92, 39, 87, 69, 133, 99, 75, 141, 107, 96, 100,
    59, 112, 56, 118, 83
  }
  '-----------------------------------------------------------------------------------------------------------------------'
  ReadOnly CoordinateXP2() = {
    3, 318, 3, 318, 3, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318
  }
  '-----------------------------------------------------------------------------------------------------------------------'
  ReadOnly CoordinateYP2() = {
    204, 269, 251, 249, 185, 163, 202, 332, 193, 434, 366, 247, 259, 266, 180, 181, 412, 259, 264, 258, 183, 252, 188, 256, 183, 252, 244, 351, 258, 245,
    433, 265, 265, 262, 190, 296, 188, 372, 304
  }
  '-----------------------------------------------------------------------------------------------------------------------'
  ReadOnly CoordinateXP3() = {
    3, 318, 3, 318, 3, 3, 318, 0, 318, 0, 0, 3, 318, 3, 318, 3, 0, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 0, 318, 3, 0, 3, 318, 3, 318, 3, 318, 0, 0
  }
  '-----------------------------------------------------------------------------------------------------------------------'
  ReadOnly CoordinateYP3() = {
    327, 424, 434, 423, 311, 280, 316, 0, 422, 0, 0, 400, 422, 402, 312, 309, 0, 446, 430, 415, 291, 415, 311, 415, 305, 428, 428, 0, 428, 428, 0, 429, 426, 429,
    294, 437, 299, 0, 0
  }
  '-----------------------------------------------------------------------------------------------------------------------'
  ReadOnly CoordinateXP4() = {
    3, 0, 0, 0, 3, 3, 318, 0, 0, 0, 0, 0, 0, 0, 318, 3, 0, 0, 0, 0, 318, 0, 318, 0, 318, 0, 0, 0, 0, 0, 0, 0, 0, 0, 318, 0, 318, 0, 0
  }
  '-----------------------------------------------------------------------------------------------------------------------'
  ReadOnly CoordinateYP4() = {
    444, 0, 0, 0, 434, 434, 437, 0, 0, 0, 0, 0, 0, 0, 411, 439, 0, 0, 0, 0, 435, 0, 441, 0, 437, 0, 0, 0, 0, 0, 0, 0, 0, 0, 444, 0, 442, 0, 0
  }
  '-----------------------------------------------------------------------------------------------------------------------'
  ReadOnly GruppoPannelli As New List(Of Panel)
  ReadOnly SelezioneTotale(ID_PiattiTot.Length - 1)
  ReadOnly PagineLaunch As Integer = 39
  ReadOnly PagAntipasti As Integer = 0
  ReadOnly PagChirashi As Integer = 6
  ReadOnly PagGunkan As Integer = 7
  ReadOnly PagHosomaki As Integer = 11
  ReadOnly PagNigiri As Integer = 14
  ReadOnly PagSashimi As Integer = 18
  ReadOnly PagUramaki As Integer = 19
  ReadOnly PagTemaki As Integer = 28
  ReadOnly PagPiattiCaldi As Integer = 31


  '--- T O K I D R I F T | Variables -------------------------------------------------------------------------------------'
  '-----------------------------------------------------------------------------------------------------------------------'
  Dim PageIndex As Integer = 0
  Dim indexchanged As Boolean = False


  '--- T O K I D R I F T | Private Functions -----------------------------------------------------------------------------'
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub TokiDrift_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    CheckForIllegalCrossThreadCalls = False
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
    If (ArrayPagePointer(PageIndex) <> 56) Then
      TxtQnt1.Text += 1
      SelezioneTotale(ArrayPagePointer(PageIndex)) = Convert.ToInt32(TxtQnt1.Text)
    Else
      If TxtQnt1.Text = 0 Then
        TxtQnt1.Text += 1
        SelezioneTotale(ArrayPagePointer(PageIndex)) = Convert.ToInt32(TxtQnt1.Text)
      Else
                MessageBox.Show(My.Resources.Str_NmaxTxt, My.Resources.Str_NmaxTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
        MessageBox.Show(My.Resources.Str_NmaxTxt, My.Resources.Str_NmaxTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
    If (ArrayPagePointer(PageIndex) <> 56) And (ArrayPagePointer(PageIndex) <> 13) Then
      TxtQnt3.Text += 1
      SelezioneTotale(ArrayPagePointer(PageIndex) + 2) = Convert.ToInt32(TxtQnt3.Text)
    Else
      If TxtQnt3.Text = 0 Then
        TxtQnt3.Text += 1
        SelezioneTotale(ArrayPagePointer(PageIndex) + 2) = Convert.ToInt32(TxtQnt3.Text)
      Else
        MessageBox.Show(My.Resources.Str_NmaxTxt, My.Resources.Str_NmaxTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
    If (ArrayPagePointer(PageIndex) <> 56) And (ArrayPagePointer(PageIndex) <> 13) And (ArrayPagePointer(PageIndex) <> 105) Then
      TxtQnt4.Text += 1
      SelezioneTotale(ArrayPagePointer(PageIndex) + 3) = Convert.ToInt32(TxtQnt4.Text)
    Else
      If (ArrayPagePointer(PageIndex) = 105) Then
        If TxtQnt4.Text < 3 Then
          TxtQnt4.Text += 1
          SelezioneTotale(ArrayPagePointer(PageIndex) + 3) = Convert.ToInt32(TxtQnt4.Text)
        Else
          MessageBox.Show(My.Resources.Str_3maxTxt, My.Resources.Str_NmaxTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
      Else
        If TxtQnt4.Text = 0 Then
          TxtQnt4.Text += 1
          SelezioneTotale(ArrayPagePointer(PageIndex) + 3) = Convert.ToInt32(TxtQnt4.Text)
        Else
          MessageBox.Show(My.Resources.Str_NmaxTxt, My.Resources.Str_NmaxTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
      End If
    End If
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
    Dim lst_Piatti As New List(Of Integer)
    For i As Integer = 0 To SelezioneTotale.Length - 1
      If SelezioneTotale(i) > 0 Then
        lst_Piatti.Add(i)
        Resoconto.dgv_Resoconto.Rows.Add()
      End If
    Next
    If lst_Piatti.Count > 0 Then
      For i As Integer = 0 To lst_Piatti.Count - 1
        Resoconto.dgv_Resoconto.Item(Resoconto.clm_IdPiatto.Index, i).Value = ID_PiattiTot(lst_Piatti.Item(i))
      Next
      For i As Integer = 0 To lst_Piatti.Count - 1
        Resoconto.dgv_Resoconto.Item(Resoconto.clm_DescPiatto.Index, i).Value = ListaNomi(lst_Piatti.Item(i))
      Next
      For i As Integer = 0 To lst_Piatti.Count - 1
        Resoconto.dgv_Resoconto.Item(Resoconto.clm_Qnt.Index, i).Value = SelezioneTotale(lst_Piatti.Item(i))
      Next
    End If

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

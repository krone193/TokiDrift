Public Class TokiDrift
  '--- T O K I D R I F T | ReadOnly --------------------------------------------------------------------------------------'
  '-----------------------------------------------------------------------------------------------------------------------'
  'ReadOnly Vapor As New VaporChat


  '--- T O K I D R I F T | Struct ----------------------------------------------------------------------------------------'
  '-----------------------------------------------------------------------------------------------------------------------'
  Structure DishSelStruct
    Dim BtnInc As Button
    Dim BtnDec As Button
    Dim TxtNum As TextBox
    Dim Number As UShort
  End Structure
  '-----------------------------------------------------------------------------------------------------------------------'
  Public Structure MenuPageStruct
    Dim DishNum As Byte
    Dim DishSel As List(Of DishSelStruct)
    Dim BtnNext As Button
    Dim BtnPrev As Button
  End Structure


  '--- T O K I D R I F T | Variables -------------------------------------------------------------------------------------'
  '-----------------------------------------------------------------------------------------------------------------------'
  ReadOnly MenuPanel As New List(Of MenuPageStruct)


  '--- T O K I D R I F T | Private Functions -----------------------------------------------------------------------------'
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub TokiDrift_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim menupan As MenuPageStruct
    Dim dishsel As DishSelStruct

    ' Assegnazione pagina 1
    menupan.BtnNext = BtnNext01
    menupan.BtnPrev = BtnPrev01
    menupan.DishNum = 4
    menupan.DishSel = New List(Of DishSelStruct)
    dishsel.BtnInc = BtnInc0101
    dishsel.BtnDec = BtnDec0101
    dishsel.TxtNum = TxtNum0101
    dishsel.Number = 1
    menupan.DishSel.Add(dishsel)
    dishsel.BtnInc = BtnInc0102
    dishsel.BtnDec = BtnDec0102
    dishsel.TxtNum = TxtNum0102
    dishsel.Number = 2
    menupan.DishSel.Add(dishsel)
    dishsel.BtnInc = BtnInc0103
    dishsel.BtnDec = BtnDec0103
    dishsel.TxtNum = TxtNum0103
    dishsel.Number = 3
    menupan.DishSel.Add(dishsel)
    dishsel.BtnInc = BtnInc0104
    dishsel.BtnDec = BtnDec0104
    dishsel.TxtNum = TxtNum0104
    dishsel.Number = 4
    menupan.DishSel.Add(dishsel)
    MenuPanel.Add(menupan)

    ' Assegnazione pagina 2
    menupan.BtnNext = BtnNext02
    menupan.BtnPrev = BtnPrev02
    menupan.DishNum = 3
    menupan.DishSel = New List(Of DishSelStruct)
    dishsel.BtnInc = BtnInc0201
    dishsel.BtnDec = BtnDec0201
    dishsel.TxtNum = TxtNum0201
    dishsel.Number = 5
    menupan.DishSel.Add(dishsel)
    dishsel.BtnInc = BtnInc0202
    dishsel.BtnDec = BtnDec0202
    dishsel.TxtNum = TxtNum0202
    dishsel.Number = 6
    menupan.DishSel.Add(dishsel)
    dishsel.BtnInc = BtnInc0203
    dishsel.BtnDec = BtnDec0203
    dishsel.TxtNum = TxtNum0203
    dishsel.Number = 7
    menupan.DishSel.Add(dishsel)
    MenuPanel.Add(menupan)

    ' Assegnazione pagina 3
    menupan.BtnNext = BtnNext03
    menupan.BtnPrev = BtnPrev03
    menupan.DishNum = 3
    menupan.DishSel = New List(Of DishSelStruct)
    dishsel.BtnInc = BtnInc0301
    dishsel.BtnDec = BtnDec0301
    dishsel.TxtNum = TxtNum0301
    dishsel.Number = 8
    menupan.DishSel.Add(dishsel)
    dishsel.BtnInc = BtnInc0302
    dishsel.BtnDec = BtnDec0302
    dishsel.TxtNum = TxtNum0302
    dishsel.Number = 9
    menupan.DishSel.Add(dishsel)
    dishsel.BtnInc = BtnInc0303
    dishsel.BtnDec = BtnDec0303
    dishsel.TxtNum = TxtNum0303
    dishsel.Number = 10
    menupan.DishSel.Add(dishsel)
    MenuPanel.Add(menupan)

    ' Assegnazione pagina 4
    menupan.BtnNext = BtnNext04
    menupan.BtnPrev = BtnPrev04
    menupan.DishNum = 3
    menupan.DishSel = New List(Of DishSelStruct)
    dishsel.BtnInc = BtnInc0401
    dishsel.BtnDec = BtnDec0401
    dishsel.TxtNum = TxtNum0401
    dishsel.Number = 11
    menupan.DishSel.Add(dishsel)
    dishsel.BtnInc = BtnInc0402
    dishsel.BtnDec = BtnDec0402
    dishsel.TxtNum = TxtNum0402
    dishsel.Number = 12
    menupan.DishSel.Add(dishsel)
    dishsel.BtnInc = BtnInc0403
    dishsel.BtnDec = BtnDec0403
    dishsel.TxtNum = TxtNum0403
    dishsel.Number = 13
    menupan.DishSel.Add(dishsel)
    MenuPanel.Add(menupan)

    ' Mostro il primo pannello del menu
    PanMenuPage01.BringToFront()
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub TokiDrift_KeyPress(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
    If e.KeyCode = Keys.Enter Then
      If MsgBox("Inviare l'ordine?", vbOKCancel) = MsgBoxResult.Ok Then
        Close()
      Else

      End If
    End If
  End Sub


  '--- T O K I D R I F T | Buttons Next and Prev functions ---------------------------------------------------------------'
  'Page 01 ---------------------------------------------------------------------------------------------------------------'
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnNext01_Click(sender As Object, e As EventArgs) Handles BtnNext01.Click
    PanMenuPage02.BringToFront()
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnPrev01_Click(sender As Object, e As EventArgs) Handles BtnPrev01.Click
    Close()
  End Sub
  'Page 02 ---------------------------------------------------------------------------------------------------------------'
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnNext02_Click(sender As Object, e As EventArgs) Handles BtnNext02.Click
    PanMenuPage03.BringToFront()
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnPrev02_Click(sender As Object, e As EventArgs) Handles BtnPrev02.Click
    PanMenuPage01.BringToFront()
  End Sub
  'Page 03 ---------------------------------------------------------------------------------------------------------------'
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnNext03_Click(sender As Object, e As EventArgs) Handles BtnNext03.Click
    PanMenuPage04.BringToFront()
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnPrev03_Click(sender As Object, e As EventArgs) Handles BtnPrev03.Click
    PanMenuPage02.BringToFront()
  End Sub
  'Page 04 ---------------------------------------------------------------------------------------------------------------'
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnNext04_Click(sender As Object, e As EventArgs) Handles BtnNext04.Click
    'PanMenuPage05.BringToFront()
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnPrev04_Click(sender As Object, e As EventArgs) Handles BtnPrev04.Click
    PanMenuPage03.BringToFront()
  End Sub


  '--- T O K I D R I F T | Buttons Inc and Dec functions -----------------------------------------------------------------'
  'Page 01 ---------------------------------------------------------------------------------------------------------------'
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnInc0101_Click(sender As Object, e As EventArgs) Handles BtnInc0101.Click
    TxtNum0101.Text += 1
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnDec0101_Click(sender As Object, e As EventArgs) Handles BtnDec0101.Click
    If TxtNum0101.Text > 0 Then
      TxtNum0101.Text -= 1
    End If
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnInc0102_Click(sender As Object, e As EventArgs) Handles BtnInc0102.Click
    TxtNum0102.Text += 1
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnDec0102_Click(sender As Object, e As EventArgs) Handles BtnDec0102.Click
    If TxtNum0102.Text > 0 Then
      TxtNum0102.Text -= 1
    End If
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnInc0103_Click(sender As Object, e As EventArgs) Handles BtnInc0103.Click
    TxtNum0103.Text += 1
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnDec0103_Click(sender As Object, e As EventArgs) Handles BtnDec0103.Click
    If TxtNum0103.Text > 0 Then
      TxtNum0103.Text -= 1
    End If
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnInc0104_Click(sender As Object, e As EventArgs) Handles BtnInc0104.Click
    TxtNum0104.Text += 1
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnDec0104_Click(sender As Object, e As EventArgs) Handles BtnDec0104.Click
    If TxtNum0104.Text > 0 Then
      TxtNum0104.Text -= 1
    End If
  End Sub
  'Page 02 ---------------------------------------------------------------------------------------------------------------'
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnInc0201_Click(sender As Object, e As EventArgs) Handles BtnInc0201.Click
    TxtNum0201.Text += 1
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnDec0201_Click(sender As Object, e As EventArgs) Handles BtnDec0201.Click
    If TxtNum0201.Text > 0 Then
      TxtNum0201.Text -= 1
    End If
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnInc0202_Click(sender As Object, e As EventArgs) Handles BtnInc0202.Click
    TxtNum0202.Text += 1
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnDec0202_Click(sender As Object, e As EventArgs) Handles BtnDec0202.Click
    If TxtNum0202.Text > 0 Then
      TxtNum0202.Text -= 1
    End If
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnInc0203_Click(sender As Object, e As EventArgs) Handles BtnInc0203.Click
    TxtNum0203.Text += 1
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnDec0203_Click(sender As Object, e As EventArgs) Handles BtnDec0203.Click
    If TxtNum0203.Text > 0 Then
      TxtNum0203.Text -= 1
    End If
  End Sub
  'Page 03 ---------------------------------------------------------------------------------------------------------------'
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnInc0301_Click(sender As Object, e As EventArgs) Handles BtnInc0301.Click
    TxtNum0301.Text += 1
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnDec0301_Click(sender As Object, e As EventArgs) Handles BtnDec0301.Click
    If TxtNum0301.Text > 0 Then
      TxtNum0301.Text -= 1
    End If
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnInc0302_Click(sender As Object, e As EventArgs) Handles BtnInc0302.Click
    TxtNum0302.Text += 1
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnDec0302_Click(sender As Object, e As EventArgs) Handles BtnDec0302.Click
    If TxtNum0302.Text > 0 Then
      TxtNum0302.Text -= 1
    End If
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnInc0303_Click(sender As Object, e As EventArgs) Handles BtnInc0303.Click
    TxtNum0303.Text += 1
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnDec0303_Click(sender As Object, e As EventArgs) Handles BtnDec0303.Click
    If TxtNum0303.Text > 0 Then
      TxtNum0303.Text -= 1
    End If
  End Sub
  'Page 04 ---------------------------------------------------------------------------------------------------------------'
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnInc0401_Click(sender As Object, e As EventArgs) Handles BtnInc0401.Click
    TxtNum0401.Text += 1
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnDec0401_Click(sender As Object, e As EventArgs) Handles BtnDec0401.Click
    If TxtNum0401.Text > 0 Then
      TxtNum0401.Text -= 1
    End If
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnInc0402_Click(sender As Object, e As EventArgs) Handles BtnInc0402.Click
    TxtNum0402.Text += 1
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnDec0402_Click(sender As Object, e As EventArgs) Handles BtnDec0402.Click
    If TxtNum0402.Text > 0 Then
      TxtNum0402.Text -= 1
    End If
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnInc0403_Click(sender As Object, e As EventArgs) Handles BtnInc0403.Click
    TxtNum0403.Text += 1
  End Sub
  '-----------------------------------------------------------------------------------------------------------------------'
  Private Sub BtnDec0403_Click(sender As Object, e As EventArgs) Handles BtnDec0403.Click
    If TxtNum0403.Text > 0 Then
      TxtNum0403.Text -= 1
    End If
  End Sub
End Class
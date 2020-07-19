Public Class TokiDrift
    '--- T O K I D R I F T | ReadOnly --------------------------------------------------------------------------------------'
    '-----------------------------------------------------------------------------------------------------------------------'
    'ReadOnly Vapor As New VaporChat


    '--- T O K I D R I F T | Struct ----------------------------------------------------------------------------------------'
    '-----------------------------------------------------------------------------------------------------------------------'
    'Structure DishSelStruct
    '  Dim BtnInc As Button
    '  Dim BtnDec As Button
    '  Dim TxtNum As TextBox
    '  Dim Number As UShort
    'End Structure
    '-----------------------------------------------------------------------------------------------------------------------'
    '  Public Structure MenuPageStruct
    '  Dim DishNum As Byte
    '  Dim DishSel As List(Of DishSelStruct)
    '  Dim BtnNext As Button
    '  Dim BtnPrev As Button
    'End Structure
    Dim SfondiMenu() = {My.Resources.TokiDrift01, My.Resources.TokiDrift02, My.Resources.TokiDrift03, My.Resources.TokiDrift04, My.Resources.TokiDrift05, My.Resources.TokiDrift06,
        My.Resources.TokiDrift07, My.Resources.TokiDrift08, My.Resources.TokiDrift09, My.Resources.TokiDrift10, My.Resources.TokiDrift11, My.Resources.TokiDrift12,
        My.Resources.TokiDrift13, My.Resources.TokiDrift14, My.Resources.TokiDrift15, My.Resources.TokiDrift16, My.Resources.TokiDrift17, My.Resources.TokiDrift18,
        My.Resources.TokiDrift19, My.Resources.TokiDrift20, My.Resources.TokiDrift21, My.Resources.TokiDrift22, My.Resources.TokiDrift23, My.Resources.TokiDrift24,
        My.Resources.TokiDrift25, My.Resources.TokiDrift26, My.Resources.TokiDrift27, My.Resources.TokiDrift28, My.Resources.TokiDrift29, My.Resources.TokiDrift30,
        My.Resources.TokiDrift31, My.Resources.TokiDrift32, My.Resources.TokiDrift33, My.Resources.TokiDrift34, My.Resources.TokiDrift35, My.Resources.TokiDrift36,
        My.Resources.TokiDrift37, My.Resources.TokiDrift38, My.Resources.TokiDrift39, My.Resources.TokiDrift40}

    Dim PagineLaunch As Integer = 40
    Dim NofPiattiPerPagePRANZO() = {3, 3, 3, 3, 4, 2, 2, 4, 2, 3, 2, 2, 3, 3, 3, 4, 4, 2, 3, 3, 3, 4, 3, 4, 3, 4, 3, 3, 2, 3, 3, 2, 3, 3, 3, 4, 3, 4, 2, 2}
    Dim PageIndex As Integer = 0
    Dim CoordinateXP1() = {3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318}
    Dim CoordinateYP1() = {80, 118, 110, 93, 67, 176, 163, 76, 162, 34, 118, 92, 93, 113, 100, 57, 57, 129, 85, 99, 97, 44, 102, 46, 92, 39, 87, 69, 133, 99, 75, 141, 107, 96, 100,
        59, 112, 56, 118, 83}
    Dim CoordinateXP2() = {3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318}
    Dim CoordinateYP2() = {204, 269, 251, 249, 185, 346, 339, 202, 332, 193, 434, 366, 247, 259, 266, 180, 181, 412, 259, 264, 258, 183, 252, 188, 256, 183, 252, 244, 351, 258, 245,
        433, 265, 265, 262, 190, 296, 188, 372, 304}
    Dim CoordinateXP3() = {3, 318, 3, 318, 3, Nothing, Nothing, 318, Nothing, 318, Nothing, Nothing, 3, 318, 3, 318, 3, Nothing, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, Nothing, 318,
        3, Nothing, 3, 318, 3, 318, 3, 318, Nothing, Nothing}
    Dim CoordinateYP3() = {327, 424, 434, 423, 311, Nothing, Nothing, 316, Nothing, 422, Nothing, Nothing, 400, 422, 402, 312, 309, Nothing, 349, 430, 415, 291, 415, 305, 428, 428,
        Nothing, 428, 428, Nothing, 429, 426, 429, 294, 437, 299, Nothing, Nothing}
    Dim CoordinateXP4() = {3, Nothing, Nothing, Nothing, 3, Nothing, Nothing, 318, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, 318, 3, Nothing, Nothing, Nothing,
        Nothing, 318, Nothing, 318, Nothing, 318, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, 318, Nothing, 318, Nothing, Nothing}
    Dim CoordinateYP4() = {444, Nothing, Nothing, Nothing, 434, Nothing, Nothing, 437, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, 411, 439, Nothing, Nothing,
        Nothing, Nothing, 435, Nothing, 441, Nothing, 437, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, 444, Nothing, 442, Nothing, Nothing}


    '--- T O K I D R I F T | Variables -------------------------------------------------------------------------------------'
    '-----------------------------------------------------------------------------------------------------------------------'
    'ReadOnly MenuPanel As New List(Of MenuPageStruct)


    '--- T O K I D R I F T | Private Functions -----------------------------------------------------------------------------'
    '-----------------------------------------------------------------------------------------------------------------------'
    Private Sub TokiDrift_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources.TokiDrift01
        BtnInc0101.Location = New Point(CoordinateXP1(0), CoordinateYP1(0))
        TxtNum0101.Location = New Point(CoordinateXP1(0), CoordinateYP1(0) + 20)
        BtnDec0101.Location = New Point(CoordinateXP1(0), CoordinateYP1(0) + 39)
        BtnInc0102.Location = New Point(CoordinateXP2(0), CoordinateYP2(0))
        TxtNum0102.Location = New Point(CoordinateXP2(0), CoordinateYP2(0) + 20)
        BtnDec0102.Location = New Point(CoordinateXP2(0), CoordinateYP2(0) + 39)
        BtnInc0103.Location = New Point(CoordinateXP3(0), CoordinateYP3(0))
        TxtNum0103.Location = New Point(CoordinateXP3(0), CoordinateYP3(0) + 20)
        BtnDec0103.Location = New Point(CoordinateXP3(0), CoordinateYP3(0) + 39)
        BtnInc0104.Location = New Point(CoordinateXP4(0), CoordinateYP4(0))
        TxtNum0104.Location = New Point(CoordinateXP4(0), CoordinateYP4(0) + 20)
        BtnDec0104.Location = New Point(CoordinateXP4(0), CoordinateYP4(0) + 39)
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
    Private Sub BtnNext01_Click(sender As Object, e As EventArgs)
        ' PanMenuPage02.BringToFront()
    End Sub
    '-----------------------------------------------------------------------------------------------------------------------'
    Private Sub BtnPrev01_Click(sender As Object, e As EventArgs)
        Close()
    End Sub


    '--- T O K I D R I F T | Buttons Inc and Dec functions -----------------------------------------------------------------'
    'Page 01 ---------------------------------------------------------------------------------------------------------------'
    '-----------------------------------------------------------------------------------------------------------------------'
    Private Sub BtnInc0101_Click(sender As Object, e As EventArgs)
        TxtNum0101.Text += 1
    End Sub
    '-----------------------------------------------------------------------------------------------------------------------'
    Private Sub BtnDec0101_Click(sender As Object, e As EventArgs)
        If TxtNum0101.Text > 0 Then
            TxtNum0101.Text -= 1
        End If
    End Sub
    '-----------------------------------------------------------------------------------------------------------------------'
    Private Sub BtnInc0102_Click(sender As Object, e As EventArgs)
        TxtNum0102.Text += 1
    End Sub
    '-----------------------------------------------------------------------------------------------------------------------'
    Private Sub BtnDec0102_Click(sender As Object, e As EventArgs)
        If TxtNum0102.Text > 0 Then
            TxtNum0102.Text -= 1
        End If
    End Sub
    '-----------------------------------------------------------------------------------------------------------------------'
    Private Sub BtnInc0103_Click(sender As Object, e As EventArgs)
        TxtNum0103.Text += 1
    End Sub
    '-----------------------------------------------------------------------------------------------------------------------'
    Private Sub BtnDec0103_Click(sender As Object, e As EventArgs)
        If TxtNum0103.Text > 0 Then
            TxtNum0103.Text -= 1
        End If
    End Sub
    '-----------------------------------------------------------------------------------------------------------------------'
    Private Sub BtnInc0104_Click(sender As Object, e As EventArgs)
        TxtNum0104.Text += 1
    End Sub
    '-----------------------------------------------------------------------------------------------------------------------'
    Private Sub BtnDec0104_Click(sender As Object, e As EventArgs)
        If TxtNum0104.Text > 0 Then
            TxtNum0104.Text -= 1
        End If
    End Sub

    Private Sub BtnInc0102_Click_1(sender As Object, e As EventArgs) Handles BtnInc0102.Click

    End Sub

    Private Sub TxtNum0102_TextChanged(sender As Object, e As EventArgs) Handles TxtNum0102.TextChanged

    End Sub

    Private Sub BtnDec0102_Click_1(sender As Object, e As EventArgs) Handles BtnDec0102.Click

    End Sub

    Private Sub BtnNext01_Click_1(sender As Object, e As EventArgs) Handles BtnNext01.Click
        PageIndex += 1
        BackgroundImage = SfondiMenu(PageIndex)

        Select Case NofPiattiPerPagePRANZO(PageIndex)
            Case 2
                BtnInc0103.Visible = False
                TxtNum0103.Visible = False
                BtnDec0103.Visible = False
                BtnInc0104.Visible = False
                TxtNum0104.Visible = False
                BtnDec0104.Visible = False
            Case 3
                BtnInc0103.Visible = True
                TxtNum0103.Visible = True
                BtnDec0103.Visible = True
                BtnInc0104.Visible = False
                TxtNum0104.Visible = False
                BtnDec0104.Visible = False
            Case 4
                BtnInc0103.Visible = True
                TxtNum0103.Visible = True
                BtnDec0103.Visible = True
                BtnInc0104.Visible = True
                TxtNum0104.Visible = True
                BtnDec0104.Visible = True
        End Select
    End Sub
End Class
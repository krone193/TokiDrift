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
    Dim NofPiattiPerPagePRANZO() = {4, 3, 3, 3, 4, 2, 2, 4, 2, 3, 2, 2, 3, 3, 3, 4, 4, 2, 3, 3, 3, 4, 3, 4, 3, 4, 3, 3, 2, 3, 3, 2, 3, 3, 3, 4, 3, 4, 2, 2}
    Dim PageIndex As Integer = 0
    Dim CoordinateXP1() = {3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318}
    Dim CoordinateYP1() = {80, 118, 110, 93, 67, 176, 163, 76, 162, 34, 118, 92, 93, 113, 100, 57, 57, 129, 85, 99, 97, 44, 102, 46, 92, 39, 87, 69, 133, 99, 75, 141, 107, 96, 100,
        59, 112, 56, 118, 83}
    Dim CoordinateXP2() = {3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318}
    Dim CoordinateYP2() = {204, 269, 251, 249, 185, 346, 339, 202, 332, 193, 434, 366, 247, 259, 266, 180, 181, 412, 259, 264, 258, 183, 252, 188, 256, 183, 252, 244, 351, 258, 245,
        433, 265, 265, 262, 190, 296, 188, 372, 304}
    Dim CoordinateXP3() = {3, 318, 3, 318, 3, 0, 0, 318, 0, 318, 0, 0, 3, 318, 3, 318, 3, 0, 3, 318, 3, 318, 3, 318, 3, 318, 3, 318, 0, 318, 3, 0, 3, 318, 3, 318, 3, 318, 0, 0}
    Dim CoordinateYP3() = {327, 424, 434, 423, 311, 0, 0, 316, 0, 422, 0, 0, 400, 422, 402, 312, 309, 0, 446, 430, 415, 291, 415, 311, 415, 305, 428, 428, 0, 428, 428, 0, 429, 426, 429,
        294, 437, 299, 0, 0}
    Dim CoordinateXP4() = {3, 0, 0, 0, 3, 0, 0, 318, 0, 0, 0, 0, 0, 0, 0, 318, 3, 0, 0, 0, 0, 318, 0, 318, 0, 318, 0, 0, 0, 0, 0, 0, 0, 0, 0, 318, 0, 318, 0, 0}
    Dim CoordinateYP4() = {444, 0, 0, 0, 434, 0, 0, 437, 0, 0, 0, 0, 0, 0, 0, 411, 439, 0, 0, 0, 0, 435, 0, 441, 0, 437, 0, 0, 0, 0, 0, 0, 0, 0, 0, 444, 0, 442, 0, 0}
    'Dim GruppoControlliInc As New List(Of Button)
    'Dim GruppoControlliTxt As New List(Of TextBox)
    'Dim GruppoControlliDec As New List(Of Button)
    Dim GruppoPannelli As New List(Of Panel)
    Dim indexchanged As Boolean = False


    '--- T O K I D R I F T | Variables -------------------------------------------------------------------------------------'
    '-----------------------------------------------------------------------------------------------------------------------'
    'ReadOnly MenuPanel As New List(Of MenuPageStruct)


    '--- T O K I D R I F T | Private Functions -----------------------------------------------------------------------------'
    '-----------------------------------------------------------------------------------------------------------------------'
    Private Sub TokiDrift_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GruppoPannelli.Add(Pnl_1)
        GruppoPannelli.Add(Pnl_2)
        GruppoPannelli.Add(Pnl_3)
        GruppoPannelli.Add(Pnl_4)


        Me.BackgroundImage = My.Resources.TokiDrift01
        Pnl_1.Location = New Point(CoordinateXP1(0), CoordinateYP1(0))
        Pnl_2.Location = New Point(CoordinateXP2(0), CoordinateYP2(0))
        Pnl_3.Location = New Point(CoordinateXP3(0), CoordinateYP3(0))
        Pnl_4.Location = New Point(CoordinateXP4(0), CoordinateYP4(0))
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
    'Private Sub BtnNext01_Click(sender As Object, e As EventArgs)
    '    ' PanMenuPage02.BringToFront()
    'End Sub
    '-----------------------------------------------------------------------------------------------------------------------'
    Private Sub BtnPrev01_Click(sender As Object, e As EventArgs)
        Close()
    End Sub


    '--- T O K I D R I F T | Buttons Inc and Dec functions -----------------------------------------------------------------'
    'Page 01 ---------------------------------------------------------------------------------------------------------------'
    '-----------------------------------------------------------------------------------------------------------------------'
    Private Sub BtnInc0101_Click(sender As Object, e As EventArgs) Handles Bt_Inc1.Click
        Tb_Qnt1.Text += 1
    End Sub
    '-----------------------------------------------------------------------------------------------------------------------'
    Private Sub BtnDec0101_Click(sender As Object, e As EventArgs) Handles Tb_Dec1.Click
        If Tb_Qnt1.Text > 0 Then
            Tb_Qnt1.Text -= 1
        End If
    End Sub
    '-----------------------------------------------------------------------------------------------------------------------'
    Private Sub BtnInc0102_Click(sender As Object, e As EventArgs) Handles Bt_Inc2.Click
        Tb_Qnt3.Text += 1
    End Sub
    '-----------------------------------------------------------------------------------------------------------------------'
    Private Sub BtnDec0102_Click(sender As Object, e As EventArgs) Handles Bt_Dec2.Click
        If Tb_Qnt3.Text > 0 Then
            Tb_Qnt3.Text -= 1
        End If
    End Sub
    '-----------------------------------------------------------------------------------------------------------------------'
    Private Sub BtnInc0103_Click(sender As Object, e As EventArgs) Handles Bt_Inc3.Click
        Tb_Qnt2.Text += 1
    End Sub
    '-----------------------------------------------------------------------------------------------------------------------'
    Private Sub BtnDec0103_Click(sender As Object, e As EventArgs) Handles Bt_Dec3.Click
        If Tb_Qnt2.Text > 0 Then
            Tb_Qnt2.Text -= 1
        End If
    End Sub
    '-----------------------------------------------------------------------------------------------------------------------'
    Private Sub BtnInc0104_Click(sender As Object, e As EventArgs) Handles Bt_Inc4.Click

    End Sub
    '-----------------------------------------------------------------------------------------------------------------------'
    Private Sub BtnDec0104_Click(sender As Object, e As EventArgs) Handles Bt_Dec4.Click

    End Sub

    Private Sub BtnNext01_Click_1(sender As Object, e As EventArgs) Handles BtnNext01.Click
        If PageIndex < PagineLaunch - 1 Then
            indexchanged = True
            PageIndex += 1
            RelocateButtons()
        End If
    End Sub

    Private Sub RelocateButtons()
        Select Case NofPiattiPerPagePRANZO(PageIndex)
            Case 2
                Pnl_3.Visible = False
                Pnl_4.Visible = False
            Case 3
                Pnl_3.Visible = True
                Pnl_4.Visible = False
            Case 4
                Pnl_3.Visible = True
                Pnl_4.Visible = True
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
    End Sub

    Private Sub RefreshTimer_Tick(sender As Object, e As EventArgs) Handles RefreshTimer.Tick
        If indexchanged = True Then
            indexchanged = False
            BackgroundImage = SfondiMenu(PageIndex)
        End If
    End Sub

    Private Sub BtnPrev01_Click_1(sender As Object, e As EventArgs) Handles BtnPrev01.Click
        If PageIndex > 0 Then
            indexchanged = True
            PageIndex -= 1
            RelocateButtons()
        End If
    End Sub
End Class
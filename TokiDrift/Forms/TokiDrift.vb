Public Class TokiDrift
    '--- T O K I D R I F T | ReadOnly --------------------------------------------------------------------------------------'
    '-----------------------------------------------------------------------------------------------------------------------'
    'ReadOnly Vapor As New VaporChat


    '--- T O K I D R I F T | Struct ----------------------------------------------------------------------------------------'
    '-----------------------------------------------------------------------------------------------------------------------'

    '-----------------------------------------------------------------------------------------------------------------------'
    Dim SfondiMenu() = {My.Resources.TokiDrift01, My.Resources.TokiDrift02, My.Resources.TokiDrift03, My.Resources.TokiDrift04, My.Resources.TokiDrift05, My.Resources.TokiDrift06,
        My.Resources.TokiDrift07, My.Resources.TokiDrift08, My.Resources.TokiDrift09, My.Resources.TokiDrift10, My.Resources.TokiDrift11, My.Resources.TokiDrift12,
        My.Resources.TokiDrift13, My.Resources.TokiDrift14, My.Resources.TokiDrift15, My.Resources.TokiDrift16, My.Resources.TokiDrift17, My.Resources.TokiDrift18,
        My.Resources.TokiDrift19, My.Resources.TokiDrift20, My.Resources.TokiDrift21, My.Resources.TokiDrift22, My.Resources.TokiDrift23, My.Resources.TokiDrift24,
        My.Resources.TokiDrift25, My.Resources.TokiDrift26, My.Resources.TokiDrift27, My.Resources.TokiDrift28, My.Resources.TokiDrift29, My.Resources.TokiDrift30,
        My.Resources.TokiDrift31, My.Resources.TokiDrift32, My.Resources.TokiDrift33, My.Resources.TokiDrift34, My.Resources.TokiDrift35, My.Resources.TokiDrift36,
        My.Resources.TokiDrift37, My.Resources.TokiDrift38, My.Resources.TokiDrift39, My.Resources.TokiDrift40}
    Dim ID_PiattiTot() = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 18, 19, 17, 16, 20, 21, 30, 31, 32, 33, 40, 46, 41, 48, 42, 43, 45, 44, 47, 60, 61, 62, 63, 64, 65, 66, 67, 68,
        80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 101, 102, 100, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 123, 122, 124, 125, 126, 127, 128, 129, 130, 131,
        132, 133, 134, 135, 136, 137, 138, 150, 151, 152, 153, 154, 155, 156, 157, 170, 171, 172, 173, 174, 175, 176, 177, 178, 179, 180, 181, 182, 183, 184, 185, 186, 187, 188, 183, 190,
        191, 192, 193}
    Dim ArrayPagePointer() = {0, 4, 7, 10, 13, 17, 19, 21, 25, 27, 30, 32, 34, 37, 40, 43, 47, 51, 53, 56, 59, 62, 66, 6973, 76, 80, 83, 86, 88, 91, 94, 96, 99, 102, 105, 109, 112, 116,
        118}
    Dim SelezioneTotale(ID_PiattiTot.Length)
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
    Dim GruppoPannelli As New List(Of Panel)
    Dim indexchanged As Boolean = False
    Dim PagAntipasti As Integer = 0
    Dim PagChirashi As Integer = 7
    Dim PagGunkan As Integer = 8
    Dim PagHosomaki As Integer = 12
    Dim PagNigiri As Integer = 15
    Dim PagSashimi As Integer = 19
    Dim PagUramaki As Integer = 20
    Dim PagTemaki As Integer = 29
    Dim PagPiattiCaldi As Integer = 32

    '--- T O K I D R I F T | Variables -------------------------------------------------------------------------------------'
    '-----------------------------------------------------------------------------------------------------------------------'



    '--- T O K I D R I F T | Private Functions -----------------------------------------------------------------------------'
    '-----------------------------------------------------------------------------------------------------------------------'
    Private Sub TokiDrift_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To SelezioneTotale.Length - 1
            SelezioneTotale(i) = 0
        Next
        GruppoPannelli.Add(Pnl_1)
        GruppoPannelli.Add(Pnl_2)
        GruppoPannelli.Add(Pnl_3)
        GruppoPannelli.Add(Pnl_4)
        Tv_BookMark.SelectedNode = Nothing

        Pnl_pages.BackgroundImage = My.Resources.TokiDrift01
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
    Private Sub BtnInc01_Click(sender As Object, e As EventArgs) Handles Bt_Inc1.Click
        Tb_Qnt1.Text += 1
        SelezioneTotale(ArrayPagePointer(PageIndex)) = Convert.ToInt32(Tb_Qnt1.Text)

    End Sub
    '-----------------------------------------------------------------------------------------------------------------------'
    Private Sub BtnDec01_Click(sender As Object, e As EventArgs) Handles Tb_Dec1.Click
        If Tb_Qnt1.Text > 0 Then
            Tb_Qnt1.Text -= 1
            SelezioneTotale(ArrayPagePointer(PageIndex)) = Convert.ToInt32(Tb_Qnt1.Text)
        End If
    End Sub
    '-----------------------------------------------------------------------------------------------------------------------'
    Private Sub BtnInc02_Click(sender As Object, e As EventArgs) Handles Bt_Inc2.Click
        Tb_Qnt2.Text += 1
        SelezioneTotale(ArrayPagePointer(PageIndex) + 1) = Convert.ToInt32(Tb_Qnt2.Text)
    End Sub
    '-----------------------------------------------------------------------------------------------------------------------'
    Private Sub BtnDec02_Click(sender As Object, e As EventArgs) Handles Bt_Dec2.Click
        If Tb_Qnt2.Text > 0 Then
            Tb_Qnt2.Text -= 1
            SelezioneTotale(ArrayPagePointer(PageIndex) + 1) = Convert.ToInt32(Tb_Qnt2.Text)
        End If
    End Sub
    '-----------------------------------------------------------------------------------------------------------------------'
    Private Sub BtnInc03_Click(sender As Object, e As EventArgs) Handles Bt_Inc3.Click
        Tb_Qnt3.Text += 1
        SelezioneTotale(ArrayPagePointer(PageIndex) + 2) = Convert.ToInt32(Tb_Qnt3.Text)
    End Sub
    '-----------------------------------------------------------------------------------------------------------------------'
    Private Sub BtnDec03_Click(sender As Object, e As EventArgs) Handles Bt_Dec3.Click
        If Tb_Qnt3.Text > 0 Then
            Tb_Qnt3.Text -= 1
            SelezioneTotale(ArrayPagePointer(PageIndex) + 1) = Convert.ToInt32(Tb_Qnt3.Text)
        End If
    End Sub
    '-----------------------------------------------------------------------------------------------------------------------'
    Private Sub BtnInc04_Click(sender As Object, e As EventArgs) Handles Bt_Inc4.Click
        Tb_Qnt4.Text += 1
        SelezioneTotale(ArrayPagePointer(PageIndex) + 3) = Convert.ToInt32(Tb_Qnt4.Text)
    End Sub
    '-----------------------------------------------------------------------------------------------------------------------'
    Private Sub BtnDec04_Click(sender As Object, e As EventArgs) Handles Bt_Dec4.Click
        If Tb_Qnt4.Text > 0 Then
            Tb_Qnt4.Text -= 1
            SelezioneTotale(ArrayPagePointer(PageIndex) + 3) = Convert.ToInt32(Tb_Qnt4.Text)
        End If
    End Sub

    Private Sub BtnNext01_Click_1(sender As Object, e As EventArgs) Handles BtnNext01.Click
        If PageIndex < PagineLaunch - 1 Then
            indexchanged = True
            PageIndex += 1
            'Tb_Qnt1.Text = SelezioneTotale(ArrayPagePointer(PageIndex))
            'Tb_Qnt2.Text = SelezioneTotale(ArrayPagePointer(PageIndex) + 1)
            'Tb_Qnt3.Text = SelezioneTotale(ArrayPagePointer(PageIndex) + 2)
            'Tb_Qnt4.Text = SelezioneTotale(ArrayPagePointer(PageIndex) + 3)
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
        Tb_Qnt1.Text = SelezioneTotale(ArrayPagePointer(PageIndex))
        Tb_Qnt2.Text = SelezioneTotale(ArrayPagePointer(PageIndex) + 1)
        Tb_Qnt3.Text = SelezioneTotale(ArrayPagePointer(PageIndex) + 2)
        Tb_Qnt4.Text = SelezioneTotale(ArrayPagePointer(PageIndex) + 3)
    End Sub

    Private Sub RefreshTimer_Tick(sender As Object, e As EventArgs) Handles RefreshTimer.Tick
        If indexchanged = True Then
            indexchanged = False
            Pnl_pages.BackgroundImage = SfondiMenu(PageIndex)
        End If
    End Sub

    Private Sub BtnPrev01_Click_1(sender As Object, e As EventArgs) Handles BtnPrev01.Click
        If PageIndex > 0 Then
            indexchanged = True
            PageIndex -= 1
            'Tb_Qnt1.Text = SelezioneTotale(ArrayPagePointer(PageIndex))
            'Tb_Qnt2.Text = SelezioneTotale(ArrayPagePointer(PageIndex) + 1)
            'Tb_Qnt3.Text = SelezioneTotale(ArrayPagePointer(PageIndex) + 2)
            'Tb_Qnt4.Text = SelezioneTotale(ArrayPagePointer(PageIndex) + 3)
            RelocateButtons()
        End If
    End Sub

    Private Sub Bt_StartOrdine_Click(sender As Object, e As EventArgs) Handles Bt_StartOrdine.Click
        Dim str_Order As String = ""
        For i As Integer = 0 To ID_PiattiTot.Length - 1
            str_Order = str_Order & SelezioneTotale(i) & "." & ID_PiattiTot(i) & ";"
        Next
        MsgBox(str_Order)
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles Tv_BookMark.AfterSelect
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
        Tv_BookMark.SelectedNode = Nothing
    End Sub
End Class
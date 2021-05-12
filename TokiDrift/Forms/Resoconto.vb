Public Class Resoconto
  Private Sub Resoconto_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
    Dispose()
  End Sub

	Private Sub DGV_Resoconto_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Resoconto.CellClick
		Dim idx = e.RowIndex
		Dim plate As String
		If idx >= 0 Then
			plate = dgv_Resoconto.Rows(e.RowIndex).Cells(0).Value
			ChopImage(plate)
		End If
	End Sub

	Private Sub ChopImage(Piatto As String)
    Dim ModImage As Image = Nothing
    Dim CropRect As Rectangle
    Dim CropImage As Bitmap
    Select Case Piatto
      Case "1", "2", "3", "4"
        ModImage = TokiDrift.SfondiMenu(0)

      Case "5", "6", "7"
        ModImage = TokiDrift.SfondiMenu(1)

      Case "8", "9", "10"
        ModImage = TokiDrift.SfondiMenu(2)

      Case "11", "12", "13"
        ModImage = TokiDrift.SfondiMenu(3)

      Case "14", "15", "18", "19"
        ModImage = TokiDrift.SfondiMenu(4)

      Case "21/B", "258", "20", "21"
        ModImage = TokiDrift.SfondiMenu(5)

      Case "30", "31", "32", "33"
        ModImage = TokiDrift.SfondiMenu(6)

      Case "40", "46"
        ModImage = TokiDrift.SfondiMenu(7)

      Case "41", "48", "42"
        ModImage = TokiDrift.SfondiMenu(8)

      Case "43", "45"
        ModImage = TokiDrift.SfondiMenu(9)

      Case "44", "47"
        ModImage = TokiDrift.SfondiMenu(10)

      Case "60", "61", "62"
        ModImage = TokiDrift.SfondiMenu(11)

      Case "63", "64", "65"
        ModImage = TokiDrift.SfondiMenu(12)

      Case "66", "67", "68"
        ModImage = TokiDrift.SfondiMenu(13)

      Case "80", "81", "82", "83"
        ModImage = TokiDrift.SfondiMenu(14)

      Case "84", "85", "86", "87"
        ModImage = TokiDrift.SfondiMenu(15)

      Case "88", "89"
        ModImage = TokiDrift.SfondiMenu(16)

      Case "90", "91", "92"
        ModImage = TokiDrift.SfondiMenu(17)

      Case "101", "102", "100"
        ModImage = TokiDrift.SfondiMenu(18)

      Case "110", "111", "112"
        ModImage = TokiDrift.SfondiMenu(19)

      Case "113", "114", "115", "116"
        ModImage = TokiDrift.SfondiMenu(20)

      Case "117", "118", "119"
        ModImage = TokiDrift.SfondiMenu(21)

      Case "120", "121", "123", "122"
        ModImage = TokiDrift.SfondiMenu(22)

      Case "124", "125", "126"
        ModImage = TokiDrift.SfondiMenu(23)

      Case "127", "128", "129", "130"
        ModImage = TokiDrift.SfondiMenu(24)

      Case "131", "132", "133"
        ModImage = TokiDrift.SfondiMenu(25)

      Case "134", "135", "136"
        ModImage = TokiDrift.SfondiMenu(26)

      Case "137", "138"
        ModImage = TokiDrift.SfondiMenu(27)

      Case "150", "151", "152"
        ModImage = TokiDrift.SfondiMenu(28)

      Case "153", "154", "155"
        ModImage = TokiDrift.SfondiMenu(29)

      Case "156", "157"
        ModImage = TokiDrift.SfondiMenu(30)

      Case "170", "171", "172"
        ModImage = TokiDrift.SfondiMenu(31)

      Case "173", "174", "175"
        ModImage = TokiDrift.SfondiMenu(32)

      Case "176", "177", "178"
        ModImage = TokiDrift.SfondiMenu(33)

      Case "179", "180", "181", "182"
        ModImage = TokiDrift.SfondiMenu(34)

      Case "183", "184", "185"
        ModImage = TokiDrift.SfondiMenu(35)

      Case "186", "187", "188", "189"
        ModImage = TokiDrift.SfondiMenu(36)

      Case "190", "191"
        ModImage = TokiDrift.SfondiMenu(37)

      Case "192", "193"
        ModImage = TokiDrift.SfondiMenu(38)

    End Select

    CropRect = TokiDrift.RectList(TokiDrift.ID_PiattiTot.ToList().IndexOf(Piatto))
    CropImage = New Bitmap(CropRect.Width, CropRect.Height)
    Using grp = Graphics.FromImage(CropImage)
      grp.DrawImage(ModImage, New Rectangle(0, 0, CropRect.Width, CropRect.Height), CropRect, GraphicsUnit.Pixel)
    End Using
    pb_ImagePlate.Image = CropImage
  End Sub

	Private Sub Resoconto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		PictureBox1.Image = My.Resources.EatEverything
	End Sub
End Class
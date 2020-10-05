Public Class StartScreen
	'-----------------------------------------------------------------------------------------------------------------------'
	Private Sub BtnMenuPranzo_Click(sender As Object, e As EventArgs) Handles BtnMenuPranzo.Click
		TokiDrift.Show()
		Close()
	End Sub
	'-----------------------------------------------------------------------------------------------------------------------'
	Private Sub BtnMenuCena_Click(sender As Object, e As EventArgs) Handles BtnMenuCena.Click

	End Sub
	'-----------------------------------------------------------------------------------------------------------------------'
	Private Sub BtnCommandCenter_Click(sender As Object, e As EventArgs) Handles BtnCommandCenter.Click
		If TxtPassword.Text = "Sashimi69" Then
			CommandCenter.Show()
			Close()
		End If
	End Sub

	Private Sub StartScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		CheckForIllegalCrossThreadCalls = False
		LblVersion.Text = "v" & My.Application.Info.Version.ToString()
	End Sub
End Class
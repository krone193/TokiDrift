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
	'-----------------------------------------------------------------------------------------------------------------------'
	Private Sub StartScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		CheckForIllegalCrossThreadCalls = False
		LblVersion.Text = "v" & My.Application.Info.Version.ToString()
		Dim CommandLineArguments As String() = Environment.GetCommandLineArgs()
		If My.Application.CommandLineArgs.Count > 0 Then
			If My.Application.CommandLineArgs.ElementAt(0) <> "" Then
				Dim PassedUser As String = My.Application.CommandLineArgs.ElementAt(0)
				If PassedUser.First() = ControlChars.Quote Then
					PassedUser = PassedUser.Substring(1)
				End If
				If PassedUser.Last() = ControlChars.Quote Then
					PassedUser = PassedUser.Substring(0, PassedUser.Length - 1)
				End If
				My.Settings.Str_Username = PassedUser
			End If
		End If
	End Sub
End Class
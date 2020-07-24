<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartScreen
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartScreen))
    Me.BtnMenuPranzo = New System.Windows.Forms.Button()
    Me.BtnMenuCena = New System.Windows.Forms.Button()
    Me.TxtPassword = New System.Windows.Forms.TextBox()
    Me.BtnCommandCenter = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'BtnMenuPranzo
    '
    Me.BtnMenuPranzo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.BtnMenuPranzo.Location = New System.Drawing.Point(78, 12)
    Me.BtnMenuPranzo.Name = "BtnMenuPranzo"
    Me.BtnMenuPranzo.Size = New System.Drawing.Size(235, 30)
    Me.BtnMenuPranzo.TabIndex = 0
    Me.BtnMenuPranzo.Text = "♥ P R A N Z O ♥"
    Me.BtnMenuPranzo.UseVisualStyleBackColor = True
    '
    'BtnMenuCena
    '
    Me.BtnMenuCena.Enabled = False
    Me.BtnMenuCena.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.BtnMenuCena.Location = New System.Drawing.Point(78, 41)
    Me.BtnMenuCena.Name = "BtnMenuCena"
    Me.BtnMenuCena.Size = New System.Drawing.Size(235, 30)
    Me.BtnMenuCena.TabIndex = 1
    Me.BtnMenuCena.Text = "♥ C E N A ♥"
    Me.BtnMenuCena.UseVisualStyleBackColor = True
    '
    'TxtPassword
    '
    Me.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.TxtPassword.Location = New System.Drawing.Point(78, 213)
    Me.TxtPassword.Name = "TxtPassword"
    Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9829)
    Me.TxtPassword.Size = New System.Drawing.Size(235, 20)
    Me.TxtPassword.TabIndex = 2
    '
    'BtnCommandCenter
    '
    Me.BtnCommandCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.BtnCommandCenter.Location = New System.Drawing.Point(78, 184)
    Me.BtnCommandCenter.Name = "BtnCommandCenter"
    Me.BtnCommandCenter.Size = New System.Drawing.Size(235, 30)
    Me.BtnCommandCenter.TabIndex = 3
    Me.BtnCommandCenter.Text = "指 令 セ ン タ ー"
    Me.BtnCommandCenter.UseVisualStyleBackColor = True
    '
    'StartScreen
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackgroundImage = Global.TokiDriftApplication.My.Resources.Resources.StartScreenBkg
    Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
    Me.ClientSize = New System.Drawing.Size(394, 261)
    Me.Controls.Add(Me.BtnCommandCenter)
    Me.Controls.Add(Me.TxtPassword)
    Me.Controls.Add(Me.BtnMenuCena)
    Me.Controls.Add(Me.BtnMenuPranzo)
    Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Name = "StartScreen"
    Me.Text = "(っ◔◡◔)っ 【 ﻿T O K I   D R I F T 】 (っ◔◡◔)っ"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents BtnMenuPranzo As Button
	Friend WithEvents BtnMenuCena As Button
	Friend WithEvents TxtPassword As TextBox
	Friend WithEvents BtnCommandCenter As Button
End Class

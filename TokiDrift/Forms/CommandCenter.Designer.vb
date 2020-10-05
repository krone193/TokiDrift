<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CommandCenter
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CommandCenter))
		Me.BtnAvviaOrdini = New System.Windows.Forms.Button()
		Me.BtnFermaOrdini = New System.Windows.Forms.Button()
		Me.BtnEsportaOrdini = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.LblNumOrdini = New System.Windows.Forms.Label()
		Me.LblStatusOrdini = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.LstUsers = New System.Windows.Forms.ListView()
		Me.SuspendLayout()
		'
		'BtnAvviaOrdini
		'
		Me.BtnAvviaOrdini.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.BtnAvviaOrdini.Location = New System.Drawing.Point(77, 12)
		Me.BtnAvviaOrdini.Name = "BtnAvviaOrdini"
		Me.BtnAvviaOrdini.Size = New System.Drawing.Size(235, 30)
		Me.BtnAvviaOrdini.TabIndex = 1
		Me.BtnAvviaOrdini.Text = "(っ◔◡◔)っ ♥ Avvia ordini ♥"
		Me.BtnAvviaOrdini.UseVisualStyleBackColor = True
		'
		'BtnFermaOrdini
		'
		Me.BtnFermaOrdini.Enabled = False
		Me.BtnFermaOrdini.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.BtnFermaOrdini.Location = New System.Drawing.Point(77, 48)
		Me.BtnFermaOrdini.Name = "BtnFermaOrdini"
		Me.BtnFermaOrdini.Size = New System.Drawing.Size(235, 30)
		Me.BtnFermaOrdini.TabIndex = 2
		Me.BtnFermaOrdini.Text = "(っ◔◡◔)っ ♥ Ferma ordini ♥"
		Me.BtnFermaOrdini.UseVisualStyleBackColor = True
		'
		'BtnEsportaOrdini
		'
		Me.BtnEsportaOrdini.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.BtnEsportaOrdini.Location = New System.Drawing.Point(77, 219)
		Me.BtnEsportaOrdini.Name = "BtnEsportaOrdini"
		Me.BtnEsportaOrdini.Size = New System.Drawing.Size(235, 30)
		Me.BtnEsportaOrdini.TabIndex = 3
		Me.BtnEsportaOrdini.Text = "E S P O R T A　（ラ芋往）"
		Me.BtnEsportaOrdini.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.Red
		Me.Label1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(76, 129)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(112, 15)
		Me.Label1.TabIndex = 4
		Me.Label1.Text = "Ordini ricevuti"
		'
		'LblNumOrdini
		'
		Me.LblNumOrdini.AutoSize = True
		Me.LblNumOrdini.BackColor = System.Drawing.Color.Red
		Me.LblNumOrdini.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblNumOrdini.ForeColor = System.Drawing.Color.White
		Me.LblNumOrdini.Location = New System.Drawing.Point(298, 129)
		Me.LblNumOrdini.Name = "LblNumOrdini"
		Me.LblNumOrdini.Size = New System.Drawing.Size(14, 15)
		Me.LblNumOrdini.TabIndex = 5
		Me.LblNumOrdini.Text = "0"
		'
		'LblStatusOrdini
		'
		Me.LblStatusOrdini.AutoSize = True
		Me.LblStatusOrdini.BackColor = System.Drawing.Color.Gold
		Me.LblStatusOrdini.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblStatusOrdini.ForeColor = System.Drawing.Color.White
		Me.LblStatusOrdini.Location = New System.Drawing.Point(264, 105)
		Me.LblStatusOrdini.Name = "LblStatusOrdini"
		Me.LblStatusOrdini.Size = New System.Drawing.Size(49, 15)
		Me.LblStatusOrdini.TabIndex = 7
		Me.LblStatusOrdini.Text = "Chiusi"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.BackColor = System.Drawing.Color.Gold
		Me.Label4.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.ForeColor = System.Drawing.Color.White
		Me.Label4.Location = New System.Drawing.Point(76, 105)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(91, 15)
		Me.Label4.TabIndex = 6
		Me.Label4.Text = "Stato ordini"
		'
		'LstUsers
		'
		Me.LstUsers.BackColor = System.Drawing.Color.Pink
		Me.LstUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LstUsers.ForeColor = System.Drawing.Color.Teal
		Me.LstUsers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
		Me.LstUsers.HideSelection = False
		Me.LstUsers.Location = New System.Drawing.Point(77, 148)
		Me.LstUsers.Name = "LstUsers"
		Me.LstUsers.Size = New System.Drawing.Size(235, 65)
		Me.LstUsers.TabIndex = 8
		Me.LstUsers.UseCompatibleStateImageBehavior = False
		Me.LstUsers.View = System.Windows.Forms.View.List
		'
		'CommandCenter
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = Global.TokiDriftApplication.My.Resources.Resources.CommandCenterBkg
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.ClientSize = New System.Drawing.Size(394, 261)
		Me.Controls.Add(Me.LstUsers)
		Me.Controls.Add(Me.LblStatusOrdini)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.LblNumOrdini)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.BtnEsportaOrdini)
		Me.Controls.Add(Me.BtnFermaOrdini)
		Me.Controls.Add(Me.BtnAvviaOrdini)
		Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "CommandCenter"
		Me.Text = "(っ◔◡◔)っ 【 ﻿T O K I   D R I F T 】 (っ◔◡◔)っ"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents BtnAvviaOrdini As Button
	Friend WithEvents BtnFermaOrdini As Button
	Friend WithEvents BtnEsportaOrdini As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents LblNumOrdini As Label
	Friend WithEvents LblStatusOrdini As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents LstUsers As ListView
End Class

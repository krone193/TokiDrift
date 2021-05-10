<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TokiDrift
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Antipasti")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Chirashi")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gunkan")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hosomaki")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Nigiri")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sashimi")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Uramaki")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Temaki")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Piatti caldi")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TokiDrift))
        Me.TxtQnt1 = New System.Windows.Forms.TextBox()
        Me.BtnInc1 = New System.Windows.Forms.Button()
        Me.BtnDec1 = New System.Windows.Forms.Button()
        Me.BtnInc2 = New System.Windows.Forms.Button()
        Me.TxtQnt2 = New System.Windows.Forms.TextBox()
        Me.BtnDec2 = New System.Windows.Forms.Button()
        Me.TxtQnt3 = New System.Windows.Forms.TextBox()
        Me.BtnInc3 = New System.Windows.Forms.Button()
        Me.BtnDec3 = New System.Windows.Forms.Button()
        Me.BtnInc4 = New System.Windows.Forms.Button()
        Me.TxtQnt4 = New System.Windows.Forms.TextBox()
        Me.BtnDec4 = New System.Windows.Forms.Button()
        Me.BtnPrev01 = New System.Windows.Forms.Button()
        Me.BtnNext01 = New System.Windows.Forms.Button()
        Me.RefreshTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Pnl1 = New System.Windows.Forms.Panel()
        Me.Pnl3 = New System.Windows.Forms.Panel()
        Me.Pnl2 = New System.Windows.Forms.Panel()
        Me.Pnl4 = New System.Windows.Forms.Panel()
        Me.PnlPages = New System.Windows.Forms.Panel()
        Me.TrvBookMark = New System.Windows.Forms.TreeView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnResoconto = New System.Windows.Forms.Button()
        Me.BtnStartOrdine = New System.Windows.Forms.Button()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.BtnCancellaOrdine = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PrintOptions = New System.Windows.Forms.PrintDialog()
        Me.PrintOrder = New System.Drawing.Printing.PrintDocument()
        Me.Pnl1.SuspendLayout()
        Me.Pnl3.SuspendLayout()
        Me.Pnl2.SuspendLayout()
        Me.Pnl4.SuspendLayout()
        Me.PnlPages.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtQnt1
        '
        Me.TxtQnt1.BackColor = System.Drawing.Color.White
        Me.TxtQnt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtQnt1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TxtQnt1.Location = New System.Drawing.Point(0, 20)
        Me.TxtQnt1.Name = "TxtQnt1"
        Me.TxtQnt1.ReadOnly = True
        Me.TxtQnt1.Size = New System.Drawing.Size(35, 20)
        Me.TxtQnt1.TabIndex = 16
        Me.TxtQnt1.Text = "0"
        Me.TxtQnt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnInc1
        '
        Me.BtnInc1.BackColor = System.Drawing.SystemColors.Control
        Me.BtnInc1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInc1.Location = New System.Drawing.Point(0, 0)
        Me.BtnInc1.Name = "BtnInc1"
        Me.BtnInc1.Size = New System.Drawing.Size(35, 21)
        Me.BtnInc1.TabIndex = 17
        Me.BtnInc1.Text = "▲"
        Me.BtnInc1.UseVisualStyleBackColor = False
        '
        'BtnDec1
        '
        Me.BtnDec1.BackColor = System.Drawing.SystemColors.Control
        Me.BtnDec1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDec1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDec1.Location = New System.Drawing.Point(0, 39)
        Me.BtnDec1.Name = "BtnDec1"
        Me.BtnDec1.Size = New System.Drawing.Size(35, 21)
        Me.BtnDec1.TabIndex = 18
        Me.BtnDec1.Text = "▼"
        Me.BtnDec1.UseVisualStyleBackColor = False
        '
        'BtnInc2
        '
        Me.BtnInc2.BackColor = System.Drawing.SystemColors.Control
        Me.BtnInc2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInc2.Location = New System.Drawing.Point(0, 0)
        Me.BtnInc2.Name = "BtnInc2"
        Me.BtnInc2.Size = New System.Drawing.Size(35, 21)
        Me.BtnInc2.TabIndex = 20
        Me.BtnInc2.Text = "▲"
        Me.BtnInc2.UseVisualStyleBackColor = False
        '
        'TxtQnt2
        '
        Me.TxtQnt2.BackColor = System.Drawing.Color.White
        Me.TxtQnt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtQnt2.Cursor = System.Windows.Forms.Cursors.Default
        Me.TxtQnt2.Location = New System.Drawing.Point(0, 20)
        Me.TxtQnt2.Name = "TxtQnt2"
        Me.TxtQnt2.ReadOnly = True
        Me.TxtQnt2.Size = New System.Drawing.Size(35, 20)
        Me.TxtQnt2.TabIndex = 19
        Me.TxtQnt2.Text = "0"
        Me.TxtQnt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnDec2
        '
        Me.BtnDec2.BackColor = System.Drawing.SystemColors.Control
        Me.BtnDec2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDec2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDec2.Location = New System.Drawing.Point(0, 39)
        Me.BtnDec2.Name = "BtnDec2"
        Me.BtnDec2.Size = New System.Drawing.Size(35, 21)
        Me.BtnDec2.TabIndex = 21
        Me.BtnDec2.Text = "▼"
        Me.BtnDec2.UseVisualStyleBackColor = False
        '
        'TxtQnt3
        '
        Me.TxtQnt3.BackColor = System.Drawing.Color.White
        Me.TxtQnt3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtQnt3.Cursor = System.Windows.Forms.Cursors.Default
        Me.TxtQnt3.Location = New System.Drawing.Point(0, 20)
        Me.TxtQnt3.Name = "TxtQnt3"
        Me.TxtQnt3.ReadOnly = True
        Me.TxtQnt3.Size = New System.Drawing.Size(35, 20)
        Me.TxtQnt3.TabIndex = 22
        Me.TxtQnt3.Text = "0"
        Me.TxtQnt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnInc3
        '
        Me.BtnInc3.BackColor = System.Drawing.SystemColors.Control
        Me.BtnInc3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInc3.Location = New System.Drawing.Point(0, 0)
        Me.BtnInc3.Name = "BtnInc3"
        Me.BtnInc3.Size = New System.Drawing.Size(35, 21)
        Me.BtnInc3.TabIndex = 23
        Me.BtnInc3.Text = "▲"
        Me.BtnInc3.UseVisualStyleBackColor = False
        '
        'BtnDec3
        '
        Me.BtnDec3.BackColor = System.Drawing.SystemColors.Control
        Me.BtnDec3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDec3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDec3.Location = New System.Drawing.Point(0, 39)
        Me.BtnDec3.Name = "BtnDec3"
        Me.BtnDec3.Size = New System.Drawing.Size(35, 21)
        Me.BtnDec3.TabIndex = 24
        Me.BtnDec3.Text = "▼"
        Me.BtnDec3.UseVisualStyleBackColor = False
        '
        'BtnInc4
        '
        Me.BtnInc4.BackColor = System.Drawing.SystemColors.Control
        Me.BtnInc4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInc4.Location = New System.Drawing.Point(0, 0)
        Me.BtnInc4.Name = "BtnInc4"
        Me.BtnInc4.Size = New System.Drawing.Size(35, 21)
        Me.BtnInc4.TabIndex = 26
        Me.BtnInc4.Text = "▲"
        Me.BtnInc4.UseVisualStyleBackColor = False
        '
        'TxtQnt4
        '
        Me.TxtQnt4.BackColor = System.Drawing.Color.White
        Me.TxtQnt4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtQnt4.Cursor = System.Windows.Forms.Cursors.Default
        Me.TxtQnt4.Location = New System.Drawing.Point(0, 20)
        Me.TxtQnt4.Name = "TxtQnt4"
        Me.TxtQnt4.ReadOnly = True
        Me.TxtQnt4.Size = New System.Drawing.Size(35, 20)
        Me.TxtQnt4.TabIndex = 25
        Me.TxtQnt4.Text = "0"
        Me.TxtQnt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnDec4
        '
        Me.BtnDec4.BackColor = System.Drawing.SystemColors.Control
        Me.BtnDec4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDec4.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDec4.Location = New System.Drawing.Point(0, 39)
        Me.BtnDec4.Name = "BtnDec4"
        Me.BtnDec4.Size = New System.Drawing.Size(35, 21)
        Me.BtnDec4.TabIndex = 27
        Me.BtnDec4.Text = "▼"
        Me.BtnDec4.UseVisualStyleBackColor = False
        '
        'BtnPrev01
        '
        Me.BtnPrev01.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrev01.Location = New System.Drawing.Point(3, 523)
        Me.BtnPrev01.Name = "BtnPrev01"
        Me.BtnPrev01.Size = New System.Drawing.Size(41, 23)
        Me.BtnPrev01.TabIndex = 15
        Me.BtnPrev01.Text = "裏"
        Me.BtnPrev01.UseVisualStyleBackColor = True
        '
        'BtnNext01
        '
        Me.BtnNext01.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNext01.Location = New System.Drawing.Point(310, 523)
        Me.BtnNext01.Name = "BtnNext01"
        Me.BtnNext01.Size = New System.Drawing.Size(41, 23)
        Me.BtnNext01.TabIndex = 14
        Me.BtnNext01.Text = "次"
        Me.BtnNext01.UseVisualStyleBackColor = True
        '
        'RefreshTimer
        '
        Me.RefreshTimer.Enabled = True
        Me.RefreshTimer.Interval = 50
        '
        'Pnl1
        '
        Me.Pnl1.BackColor = System.Drawing.Color.Transparent
        Me.Pnl1.Controls.Add(Me.BtnInc1)
        Me.Pnl1.Controls.Add(Me.TxtQnt1)
        Me.Pnl1.Controls.Add(Me.BtnDec1)
        Me.Pnl1.Location = New System.Drawing.Point(307, 64)
        Me.Pnl1.Name = "Pnl1"
        Me.Pnl1.Size = New System.Drawing.Size(35, 62)
        Me.Pnl1.TabIndex = 28
        '
        'Pnl3
        '
        Me.Pnl3.BackColor = System.Drawing.Color.Transparent
        Me.Pnl3.Controls.Add(Me.BtnInc3)
        Me.Pnl3.Controls.Add(Me.BtnDec3)
        Me.Pnl3.Controls.Add(Me.TxtQnt3)
        Me.Pnl3.Location = New System.Drawing.Point(307, 274)
        Me.Pnl3.Name = "Pnl3"
        Me.Pnl3.Size = New System.Drawing.Size(35, 62)
        Me.Pnl3.TabIndex = 29
        '
        'Pnl2
        '
        Me.Pnl2.BackColor = System.Drawing.Color.Transparent
        Me.Pnl2.Controls.Add(Me.BtnInc2)
        Me.Pnl2.Controls.Add(Me.BtnDec2)
        Me.Pnl2.Controls.Add(Me.TxtQnt2)
        Me.Pnl2.Location = New System.Drawing.Point(307, 175)
        Me.Pnl2.Name = "Pnl2"
        Me.Pnl2.Size = New System.Drawing.Size(35, 62)
        Me.Pnl2.TabIndex = 30
        '
        'Pnl4
        '
        Me.Pnl4.BackColor = System.Drawing.Color.Transparent
        Me.Pnl4.Controls.Add(Me.BtnInc4)
        Me.Pnl4.Controls.Add(Me.BtnDec4)
        Me.Pnl4.Controls.Add(Me.TxtQnt4)
        Me.Pnl4.Location = New System.Drawing.Point(307, 386)
        Me.Pnl4.Name = "Pnl4"
        Me.Pnl4.Size = New System.Drawing.Size(35, 62)
        Me.Pnl4.TabIndex = 30
        '
        'PnlPages
        '
        Me.PnlPages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlPages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlPages.Controls.Add(Me.Pnl1)
        Me.PnlPages.Controls.Add(Me.BtnPrev01)
        Me.PnlPages.Controls.Add(Me.Pnl4)
        Me.PnlPages.Controls.Add(Me.Pnl3)
        Me.PnlPages.Controls.Add(Me.BtnNext01)
        Me.PnlPages.Controls.Add(Me.Pnl2)
        Me.PnlPages.Location = New System.Drawing.Point(0, 0)
        Me.PnlPages.Name = "PnlPages"
        Me.PnlPages.Size = New System.Drawing.Size(356, 551)
        Me.PnlPages.TabIndex = 31
        '
        'TrvBookMark
        '
        Me.TrvBookMark.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TrvBookMark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TrvBookMark.Cursor = System.Windows.Forms.Cursors.Default
        Me.TrvBookMark.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrvBookMark.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.TrvBookMark.HotTracking = True
        Me.TrvBookMark.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TrvBookMark.Indent = 25
        Me.TrvBookMark.ItemHeight = 31
        Me.TrvBookMark.Location = New System.Drawing.Point(355, 0)
        Me.TrvBookMark.Name = "TrvBookMark"
        TreeNode1.Name = "nd_Antipasti"
        TreeNode1.Text = "Antipasti"
        TreeNode2.Name = "nd_Chirashi"
        TreeNode2.Text = "Chirashi"
        TreeNode3.Name = "nd_Gunkan"
        TreeNode3.Text = "Gunkan"
        TreeNode4.Name = "nd_Hosomaki"
        TreeNode4.Text = "Hosomaki"
        TreeNode5.Name = "nd_Nigiri"
        TreeNode5.Text = "Nigiri"
        TreeNode6.Name = "nd_Sashimi"
        TreeNode6.Text = "Sashimi"
        TreeNode7.Name = "nd_Uramaki"
        TreeNode7.Text = "Uramaki"
        TreeNode8.Name = "nd_Temaki"
        TreeNode8.Text = "Temaki"
        TreeNode9.Name = "nd_PiattiCaldi"
        TreeNode9.Text = "Piatti caldi"
        Me.TrvBookMark.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6, TreeNode7, TreeNode8, TreeNode9})
        Me.TrvBookMark.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TrvBookMark.Size = New System.Drawing.Size(145, 286)
        Me.TrvBookMark.TabIndex = 32
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.TokiDriftApplication.My.Resources.Resources.TokiDriftBtnBkg
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnResoconto)
        Me.Panel1.Controls.Add(Me.BtnStartOrdine)
        Me.Panel1.Controls.Add(Me.TxtUser)
        Me.Panel1.Controls.Add(Me.BtnCancellaOrdine)
        Me.Panel1.Location = New System.Drawing.Point(355, 400)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(145, 151)
        Me.Panel1.TabIndex = 37
        '
        'BtnResoconto
        '
        Me.BtnResoconto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnResoconto.Location = New System.Drawing.Point(9, 37)
        Me.BtnResoconto.Name = "BtnResoconto"
        Me.BtnResoconto.Size = New System.Drawing.Size(126, 25)
        Me.BtnResoconto.TabIndex = 37
        Me.BtnResoconto.Text = "Riepilogo ordine"
        Me.BtnResoconto.UseVisualStyleBackColor = True
        '
        'BtnStartOrdine
        '
        Me.BtnStartOrdine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStartOrdine.Location = New System.Drawing.Point(9, 116)
        Me.BtnStartOrdine.Name = "BtnStartOrdine"
        Me.BtnStartOrdine.Size = New System.Drawing.Size(126, 23)
        Me.BtnStartOrdine.TabIndex = 34
        Me.BtnStartOrdine.Text = "ORDINA!!!"
        Me.BtnStartOrdine.UseVisualStyleBackColor = True
        '
        'TxtUser
        '
        Me.TxtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUser.Location = New System.Drawing.Point(9, 90)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(126, 20)
        Me.TxtUser.TabIndex = 36
        Me.TxtUser.Text = "inserisci utente"
        '
        'BtnCancellaOrdine
        '
        Me.BtnCancellaOrdine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancellaOrdine.Location = New System.Drawing.Point(9, 6)
        Me.BtnCancellaOrdine.Name = "BtnCancellaOrdine"
        Me.BtnCancellaOrdine.Size = New System.Drawing.Size(126, 25)
        Me.BtnCancellaOrdine.TabIndex = 35
        Me.BtnCancellaOrdine.Text = "Elimina selezioni"
        Me.BtnCancellaOrdine.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox1.BackgroundImage = Global.TokiDriftApplication.My.Resources.Resources.TokiDriftFoodBkg
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(355, 285)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 116)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'PrintOptions
        '
        Me.PrintOptions.AllowPrintToFile = False
        Me.PrintOptions.Document = Me.PrintOrder
        Me.PrintOptions.UseEXDialog = True
        '
        'TokiDrift
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(500, 551)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TrvBookMark)
        Me.Controls.Add(Me.PnlPages)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "TokiDrift"
        Me.Text = "(っ◔◡◔)っ 【 ﻿T O K I   D R I F T 】 (っ◔◡◔)っ"
        Me.Pnl1.ResumeLayout(False)
        Me.Pnl1.PerformLayout()
        Me.Pnl3.ResumeLayout(False)
        Me.Pnl3.PerformLayout()
        Me.Pnl2.ResumeLayout(False)
        Me.Pnl2.PerformLayout()
        Me.Pnl4.ResumeLayout(False)
        Me.Pnl4.PerformLayout()
        Me.PnlPages.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TxtQnt1 As TextBox
  Friend WithEvents BtnInc1 As Button
  Friend WithEvents BtnDec1 As Button
  Friend WithEvents BtnInc2 As Button
  Friend WithEvents TxtQnt2 As TextBox
  Friend WithEvents BtnDec2 As Button
  Friend WithEvents TxtQnt3 As TextBox
  Friend WithEvents BtnInc3 As Button
  Friend WithEvents BtnDec3 As Button
  Friend WithEvents BtnInc4 As Button
  Friend WithEvents TxtQnt4 As TextBox
  Friend WithEvents BtnDec4 As Button
  Friend WithEvents BtnPrev01 As Button
  Friend WithEvents BtnNext01 As Button
  Friend WithEvents RefreshTimer As Timer
  Friend WithEvents Pnl1 As Panel
  Friend WithEvents Pnl3 As Panel
  Friend WithEvents Pnl2 As Panel
  Friend WithEvents Pnl4 As Panel
  Friend WithEvents PnlPages As Panel
  Friend WithEvents TrvBookMark As TreeView
  Friend WithEvents PictureBox1 As PictureBox
  Friend WithEvents BtnStartOrdine As Button
  Friend WithEvents BtnCancellaOrdine As Button
  Friend WithEvents TxtUser As TextBox
  Friend WithEvents Panel1 As Panel
  Friend WithEvents bt_Resoconto As Button
  Friend WithEvents BtnResoconto As Button
    Friend WithEvents PrintOptions As PrintDialog
    Friend WithEvents PrintOrder As Printing.PrintDocument
End Class

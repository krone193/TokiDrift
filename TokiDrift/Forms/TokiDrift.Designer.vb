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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TokiDrift))
        Me.Tb_Qnt1 = New System.Windows.Forms.TextBox()
        Me.Bt_Inc1 = New System.Windows.Forms.Button()
        Me.Tb_Dec1 = New System.Windows.Forms.Button()
        Me.Bt_Inc3 = New System.Windows.Forms.Button()
        Me.Tb_Qnt3 = New System.Windows.Forms.TextBox()
        Me.Bt_Dec3 = New System.Windows.Forms.Button()
        Me.Tb_Qnt2 = New System.Windows.Forms.TextBox()
        Me.Bt_Inc2 = New System.Windows.Forms.Button()
        Me.Bt_Dec2 = New System.Windows.Forms.Button()
        Me.Bt_Inc4 = New System.Windows.Forms.Button()
        Me.Tb_Qnt4 = New System.Windows.Forms.TextBox()
        Me.Bt_Dec4 = New System.Windows.Forms.Button()
        Me.BtnPrev01 = New System.Windows.Forms.Button()
        Me.BtnNext01 = New System.Windows.Forms.Button()
        Me.RefreshTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Pnl_1 = New System.Windows.Forms.Panel()
        Me.Pnl_3 = New System.Windows.Forms.Panel()
        Me.Pnl_2 = New System.Windows.Forms.Panel()
        Me.Pnl_4 = New System.Windows.Forms.Panel()
        Me.Pnl_1.SuspendLayout()
        Me.Pnl_3.SuspendLayout()
        Me.Pnl_2.SuspendLayout()
        Me.Pnl_4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tb_Qnt1
        '
        Me.Tb_Qnt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tb_Qnt1.Cursor = System.Windows.Forms.Cursors.No
        Me.Tb_Qnt1.Location = New System.Drawing.Point(0, 20)
        Me.Tb_Qnt1.Name = "Tb_Qnt1"
        Me.Tb_Qnt1.Size = New System.Drawing.Size(35, 20)
        Me.Tb_Qnt1.TabIndex = 16
        Me.Tb_Qnt1.Text = "0"
        Me.Tb_Qnt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Bt_Inc1
        '
        Me.Bt_Inc1.BackColor = System.Drawing.SystemColors.Control
        Me.Bt_Inc1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Inc1.Location = New System.Drawing.Point(0, 0)
        Me.Bt_Inc1.Name = "Bt_Inc1"
        Me.Bt_Inc1.Size = New System.Drawing.Size(35, 21)
        Me.Bt_Inc1.TabIndex = 17
        Me.Bt_Inc1.Text = "▲"
        Me.Bt_Inc1.UseVisualStyleBackColor = False
        '
        'Tb_Dec1
        '
        Me.Tb_Dec1.BackColor = System.Drawing.SystemColors.Control
        Me.Tb_Dec1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Tb_Dec1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Dec1.Location = New System.Drawing.Point(0, 39)
        Me.Tb_Dec1.Name = "Tb_Dec1"
        Me.Tb_Dec1.Size = New System.Drawing.Size(35, 21)
        Me.Tb_Dec1.TabIndex = 18
        Me.Tb_Dec1.Text = "▼"
        Me.Tb_Dec1.UseVisualStyleBackColor = False
        '
        'Bt_Inc3
        '
        Me.Bt_Inc3.BackColor = System.Drawing.SystemColors.Control
        Me.Bt_Inc3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Inc3.Location = New System.Drawing.Point(0, 0)
        Me.Bt_Inc3.Name = "Bt_Inc3"
        Me.Bt_Inc3.Size = New System.Drawing.Size(35, 21)
        Me.Bt_Inc3.TabIndex = 20
        Me.Bt_Inc3.Text = "▲"
        Me.Bt_Inc3.UseVisualStyleBackColor = False
        '
        'Tb_Qnt3
        '
        Me.Tb_Qnt3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tb_Qnt3.Cursor = System.Windows.Forms.Cursors.No
        Me.Tb_Qnt3.Location = New System.Drawing.Point(0, 20)
        Me.Tb_Qnt3.Name = "Tb_Qnt3"
        Me.Tb_Qnt3.Size = New System.Drawing.Size(35, 20)
        Me.Tb_Qnt3.TabIndex = 19
        Me.Tb_Qnt3.Text = "0"
        Me.Tb_Qnt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Bt_Dec3
        '
        Me.Bt_Dec3.BackColor = System.Drawing.SystemColors.Control
        Me.Bt_Dec3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Dec3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Dec3.Location = New System.Drawing.Point(0, 39)
        Me.Bt_Dec3.Name = "Bt_Dec3"
        Me.Bt_Dec3.Size = New System.Drawing.Size(35, 21)
        Me.Bt_Dec3.TabIndex = 21
        Me.Bt_Dec3.Text = "▼"
        Me.Bt_Dec3.UseVisualStyleBackColor = False
        '
        'Tb_Qnt2
        '
        Me.Tb_Qnt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tb_Qnt2.Cursor = System.Windows.Forms.Cursors.No
        Me.Tb_Qnt2.Location = New System.Drawing.Point(0, 20)
        Me.Tb_Qnt2.Name = "Tb_Qnt2"
        Me.Tb_Qnt2.Size = New System.Drawing.Size(35, 20)
        Me.Tb_Qnt2.TabIndex = 22
        Me.Tb_Qnt2.Text = "0"
        Me.Tb_Qnt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Bt_Inc2
        '
        Me.Bt_Inc2.BackColor = System.Drawing.SystemColors.Control
        Me.Bt_Inc2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Inc2.Location = New System.Drawing.Point(0, 0)
        Me.Bt_Inc2.Name = "Bt_Inc2"
        Me.Bt_Inc2.Size = New System.Drawing.Size(35, 21)
        Me.Bt_Inc2.TabIndex = 23
        Me.Bt_Inc2.Text = "▲"
        Me.Bt_Inc2.UseVisualStyleBackColor = False
        '
        'Bt_Dec2
        '
        Me.Bt_Dec2.BackColor = System.Drawing.SystemColors.Control
        Me.Bt_Dec2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Dec2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Dec2.Location = New System.Drawing.Point(0, 39)
        Me.Bt_Dec2.Name = "Bt_Dec2"
        Me.Bt_Dec2.Size = New System.Drawing.Size(35, 21)
        Me.Bt_Dec2.TabIndex = 24
        Me.Bt_Dec2.Text = "▼"
        Me.Bt_Dec2.UseVisualStyleBackColor = False
        '
        'Bt_Inc4
        '
        Me.Bt_Inc4.BackColor = System.Drawing.SystemColors.Control
        Me.Bt_Inc4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Inc4.Location = New System.Drawing.Point(0, 0)
        Me.Bt_Inc4.Name = "Bt_Inc4"
        Me.Bt_Inc4.Size = New System.Drawing.Size(35, 21)
        Me.Bt_Inc4.TabIndex = 26
        Me.Bt_Inc4.Text = "▲"
        Me.Bt_Inc4.UseVisualStyleBackColor = False
        '
        'Tb_Qnt4
        '
        Me.Tb_Qnt4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tb_Qnt4.Cursor = System.Windows.Forms.Cursors.No
        Me.Tb_Qnt4.Location = New System.Drawing.Point(0, 20)
        Me.Tb_Qnt4.Name = "Tb_Qnt4"
        Me.Tb_Qnt4.Size = New System.Drawing.Size(35, 20)
        Me.Tb_Qnt4.TabIndex = 25
        Me.Tb_Qnt4.Text = "0"
        Me.Tb_Qnt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Bt_Dec4
        '
        Me.Bt_Dec4.BackColor = System.Drawing.SystemColors.Control
        Me.Bt_Dec4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Dec4.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Dec4.Location = New System.Drawing.Point(0, 39)
        Me.Bt_Dec4.Name = "Bt_Dec4"
        Me.Bt_Dec4.Size = New System.Drawing.Size(35, 21)
        Me.Bt_Dec4.TabIndex = 27
        Me.Bt_Dec4.Text = "▼"
        Me.Bt_Dec4.UseVisualStyleBackColor = False
        '
        'BtnPrev01
        '
        Me.BtnPrev01.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrev01.Location = New System.Drawing.Point(3, 528)
        Me.BtnPrev01.Name = "BtnPrev01"
        Me.BtnPrev01.Size = New System.Drawing.Size(41, 23)
        Me.BtnPrev01.TabIndex = 15
        Me.BtnPrev01.Text = "裏"
        Me.BtnPrev01.UseVisualStyleBackColor = True
        '
        'BtnNext01
        '
        Me.BtnNext01.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNext01.Location = New System.Drawing.Point(312, 528)
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
        'Pnl_1
        '
        Me.Pnl_1.BackColor = System.Drawing.Color.Transparent
        Me.Pnl_1.Controls.Add(Me.Bt_Inc1)
        Me.Pnl_1.Controls.Add(Me.Tb_Qnt1)
        Me.Pnl_1.Controls.Add(Me.Tb_Dec1)
        Me.Pnl_1.Location = New System.Drawing.Point(318, 12)
        Me.Pnl_1.Name = "Pnl_1"
        Me.Pnl_1.Size = New System.Drawing.Size(35, 62)
        Me.Pnl_1.TabIndex = 28
        '
        'Pnl_3
        '
        Me.Pnl_3.BackColor = System.Drawing.Color.Transparent
        Me.Pnl_3.Controls.Add(Me.Bt_Inc2)
        Me.Pnl_3.Controls.Add(Me.Bt_Dec2)
        Me.Pnl_3.Controls.Add(Me.Tb_Qnt2)
        Me.Pnl_3.Location = New System.Drawing.Point(318, 99)
        Me.Pnl_3.Name = "Pnl_3"
        Me.Pnl_3.Size = New System.Drawing.Size(35, 62)
        Me.Pnl_3.TabIndex = 29
        '
        'Pnl_2
        '
        Me.Pnl_2.BackColor = System.Drawing.Color.Transparent
        Me.Pnl_2.Controls.Add(Me.Bt_Inc3)
        Me.Pnl_2.Controls.Add(Me.Bt_Dec3)
        Me.Pnl_2.Controls.Add(Me.Tb_Qnt3)
        Me.Pnl_2.Location = New System.Drawing.Point(318, 199)
        Me.Pnl_2.Name = "Pnl_2"
        Me.Pnl_2.Size = New System.Drawing.Size(35, 62)
        Me.Pnl_2.TabIndex = 30
        '
        'Pnl_4
        '
        Me.Pnl_4.BackColor = System.Drawing.Color.Transparent
        Me.Pnl_4.Controls.Add(Me.Bt_Inc4)
        Me.Pnl_4.Controls.Add(Me.Bt_Dec4)
        Me.Pnl_4.Controls.Add(Me.Tb_Qnt4)
        Me.Pnl_4.Location = New System.Drawing.Point(318, 284)
        Me.Pnl_4.Name = "Pnl_4"
        Me.Pnl_4.Size = New System.Drawing.Size(35, 62)
        Me.Pnl_4.TabIndex = 30
        '
        'TokiDrift
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TokiDriftApplication.My.Resources.Resources.TokiDrift26
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(356, 554)
        Me.Controls.Add(Me.Pnl_4)
        Me.Controls.Add(Me.Pnl_2)
        Me.Controls.Add(Me.Pnl_3)
        Me.Controls.Add(Me.Pnl_1)
        Me.Controls.Add(Me.BtnPrev01)
        Me.Controls.Add(Me.BtnNext01)
        Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TokiDrift"
        Me.Text = "T O K I   D R I F T"
        Me.Pnl_1.ResumeLayout(False)
        Me.Pnl_1.PerformLayout()
        Me.Pnl_3.ResumeLayout(False)
        Me.Pnl_3.PerformLayout()
        Me.Pnl_2.ResumeLayout(False)
        Me.Pnl_2.PerformLayout()
        Me.Pnl_4.ResumeLayout(False)
        Me.Pnl_4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tb_Qnt1 As TextBox
    Friend WithEvents Bt_Inc1 As Button
    Friend WithEvents Tb_Dec1 As Button
    Friend WithEvents Bt_Inc3 As Button
    Friend WithEvents Tb_Qnt3 As TextBox
    Friend WithEvents Bt_Dec3 As Button
    Friend WithEvents Tb_Qnt2 As TextBox
    Friend WithEvents Bt_Inc2 As Button
    Friend WithEvents Bt_Dec2 As Button
    Friend WithEvents Bt_Inc4 As Button
    Friend WithEvents Tb_Qnt4 As TextBox
    Friend WithEvents Bt_Dec4 As Button
    Friend WithEvents BtnPrev01 As Button
    Friend WithEvents BtnNext01 As Button
    Friend WithEvents RefreshTimer As Timer
    Friend WithEvents Pnl_1 As Panel
    Friend WithEvents Pnl_3 As Panel
    Friend WithEvents Pnl_2 As Panel
    Friend WithEvents Pnl_4 As Panel
End Class

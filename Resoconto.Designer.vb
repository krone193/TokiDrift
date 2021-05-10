<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Resoconto
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Resoconto))
    Me.dgv_Resoconto = New System.Windows.Forms.DataGridView()
    Me.pb_ImagePlate = New System.Windows.Forms.PictureBox()
    Me.clm_Qnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.clm_DescPiatto = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.clm_IdPiatto = New System.Windows.Forms.DataGridViewTextBoxColumn()
    CType(Me.dgv_Resoconto, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.pb_ImagePlate, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'dgv_Resoconto
    '
    Me.dgv_Resoconto.AllowUserToAddRows = False
    Me.dgv_Resoconto.AllowUserToDeleteRows = False
    Me.dgv_Resoconto.AllowUserToResizeRows = False
    Me.dgv_Resoconto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgv_Resoconto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clm_IdPiatto, Me.clm_DescPiatto, Me.clm_Qnt})
    Me.dgv_Resoconto.Location = New System.Drawing.Point(1, 1)
    Me.dgv_Resoconto.Name = "dgv_Resoconto"
    Me.dgv_Resoconto.ReadOnly = True
    Me.dgv_Resoconto.RowHeadersVisible = False
    Me.dgv_Resoconto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgv_Resoconto.Size = New System.Drawing.Size(433, 424)
    Me.dgv_Resoconto.TabIndex = 0
    '
    'pb_ImagePlate
    '
    Me.pb_ImagePlate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.pb_ImagePlate.Image = Global.TokiDriftApplication.My.Resources.Resources.TokiDriftFoodBkg
    Me.pb_ImagePlate.Location = New System.Drawing.Point(141, 431)
    Me.pb_ImagePlate.Name = "pb_ImagePlate"
    Me.pb_ImagePlate.Size = New System.Drawing.Size(158, 148)
    Me.pb_ImagePlate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.pb_ImagePlate.TabIndex = 1
    Me.pb_ImagePlate.TabStop = False
    '
    'clm_Qnt
    '
    Me.clm_Qnt.HeaderText = "Quantità selezionata"
    Me.clm_Qnt.Name = "clm_Qnt"
    Me.clm_Qnt.ReadOnly = True
    Me.clm_Qnt.Width = 130
    '
    'clm_DescPiatto
    '
    Me.clm_DescPiatto.HeaderText = "Descrizione piatto"
    Me.clm_DescPiatto.Name = "clm_DescPiatto"
    Me.clm_DescPiatto.ReadOnly = True
    Me.clm_DescPiatto.Width = 190
    '
    'clm_IdPiatto
    '
    Me.clm_IdPiatto.HeaderText = "Numero piatto"
    Me.clm_IdPiatto.Name = "clm_IdPiatto"
    Me.clm_IdPiatto.ReadOnly = True
    '
    'Resoconto
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Black
    Me.ClientSize = New System.Drawing.Size(435, 584)
    Me.Controls.Add(Me.pb_ImagePlate)
    Me.Controls.Add(Me.dgv_Resoconto)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "Resoconto"
    Me.Text = "Resoconto ordini"
    CType(Me.dgv_Resoconto, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.pb_ImagePlate, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents dgv_Resoconto As DataGridView
  Friend WithEvents pb_ImagePlate As PictureBox
  Friend WithEvents clm_IdPiatto As DataGridViewTextBoxColumn
  Friend WithEvents clm_DescPiatto As DataGridViewTextBoxColumn
  Friend WithEvents clm_Qnt As DataGridViewTextBoxColumn
End Class

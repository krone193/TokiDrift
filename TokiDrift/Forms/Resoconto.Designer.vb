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
        Me.dgv_Resoconto = New System.Windows.Forms.DataGridView()
        Me.clm_IdPiatto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clm_DescPiatto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clm_Qnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_Resoconto, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dgv_Resoconto.Size = New System.Drawing.Size(377, 629)
        Me.dgv_Resoconto.TabIndex = 0
        '
        'clm_IdPiatto
        '
        Me.clm_IdPiatto.HeaderText = "Numero piatto"
        Me.clm_IdPiatto.Name = "clm_IdPiatto"
        Me.clm_IdPiatto.ReadOnly = True
        '
        'clm_DescPiatto
        '
        Me.clm_DescPiatto.HeaderText = "Descrizione piatto"
        Me.clm_DescPiatto.Name = "clm_DescPiatto"
        Me.clm_DescPiatto.ReadOnly = True
        Me.clm_DescPiatto.Width = 120
        '
        'clm_Qnt
        '
        Me.clm_Qnt.HeaderText = "Quantità selezionata"
        Me.clm_Qnt.Name = "clm_Qnt"
        Me.clm_Qnt.ReadOnly = True
        Me.clm_Qnt.Width = 130
        '
        'Resoconto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 632)
        Me.Controls.Add(Me.dgv_Resoconto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Resoconto"
        Me.Text = "Resoconto ordini"
        CType(Me.dgv_Resoconto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_Resoconto As DataGridView
    Friend WithEvents clm_IdPiatto As DataGridViewTextBoxColumn
    Friend WithEvents clm_DescPiatto As DataGridViewTextBoxColumn
    Friend WithEvents clm_Qnt As DataGridViewTextBoxColumn
End Class

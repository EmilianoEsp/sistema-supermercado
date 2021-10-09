<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InformeArqueoDiario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblNro = New System.Windows.Forms.Label()
        Me.lblSaldoInicial = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.lblFechActual = New System.Windows.Forms.Label()
        Me.lblSaldObtenido = New System.Windows.Forms.Label()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.NroCaja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoInicial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoFinal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnGenerar = New System.Windows.Forms.Button()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNro
        '
        Me.lblNro.AutoSize = True
        Me.lblNro.Location = New System.Drawing.Point(485, 41)
        Me.lblNro.Name = "lblNro"
        Me.lblNro.Size = New System.Drawing.Size(24, 13)
        Me.lblNro.TabIndex = 27
        Me.lblNro.Text = "Nro"
        '
        'lblSaldoInicial
        '
        Me.lblSaldoInicial.AutoSize = True
        Me.lblSaldoInicial.Location = New System.Drawing.Point(114, 130)
        Me.lblSaldoInicial.Name = "lblSaldoInicial"
        Me.lblSaldoInicial.Size = New System.Drawing.Size(61, 13)
        Me.lblSaldoInicial.TabIndex = 26
        Me.lblSaldoInicial.Text = "SaldoInicial"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.Location = New System.Drawing.Point(537, 282)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(84, 34)
        Me.btnRegistrar.TabIndex = 25
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'lblFechActual
        '
        Me.lblFechActual.AutoSize = True
        Me.lblFechActual.Location = New System.Drawing.Point(76, 59)
        Me.lblFechActual.Name = "lblFechActual"
        Me.lblFechActual.Size = New System.Drawing.Size(37, 13)
        Me.lblFechActual.TabIndex = 24
        Me.lblFechActual.Text = "Fecha"
        '
        'lblSaldObtenido
        '
        Me.lblSaldObtenido.AutoSize = True
        Me.lblSaldObtenido.Location = New System.Drawing.Point(534, 253)
        Me.lblSaldObtenido.Name = "lblSaldObtenido"
        Me.lblSaldObtenido.Size = New System.Drawing.Size(71, 13)
        Me.lblSaldObtenido.TabIndex = 23
        Me.lblSaldObtenido.Text = "SaldObtenido"
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.AllowUserToDeleteRows = False
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NroCaja, Me.MontoInicial, Me.MontoFinal})
        Me.dgvDetalle.Location = New System.Drawing.Point(104, 161)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.ReadOnly = True
        Me.dgvDetalle.Size = New System.Drawing.Size(344, 155)
        Me.dgvDetalle.TabIndex = 22
        '
        'NroCaja
        '
        Me.NroCaja.HeaderText = "Número Caja"
        Me.NroCaja.Name = "NroCaja"
        Me.NroCaja.ReadOnly = True
        '
        'MontoInicial
        '
        Me.MontoInicial.HeaderText = "Monto Inicial"
        Me.MontoInicial.Name = "MontoInicial"
        Me.MontoInicial.ReadOnly = True
        '
        'MontoFinal
        '
        Me.MontoFinal.HeaderText = "Monto Final"
        Me.MontoFinal.Name = "MontoFinal"
        Me.MontoFinal.ReadOnly = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(636, 328)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'btnGenerar
        '
        Me.btnGenerar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerar.Location = New System.Drawing.Point(537, 161)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(84, 34)
        Me.btnGenerar.TabIndex = 28
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'InformeArqueoDiario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 328)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.lblNro)
        Me.Controls.Add(Me.lblSaldoInicial)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.lblFechActual)
        Me.Controls.Add(Me.lblSaldObtenido)
        Me.Controls.Add(Me.dgvDetalle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "InformeArqueoDiario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InformeArqueoDiario"
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNro As System.Windows.Forms.Label
    Friend WithEvents lblSaldoInicial As System.Windows.Forms.Label
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents lblFechActual As System.Windows.Forms.Label
    Friend WithEvents lblSaldObtenido As System.Windows.Forms.Label
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents NroCaja As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoInicial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoFinal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
End Class

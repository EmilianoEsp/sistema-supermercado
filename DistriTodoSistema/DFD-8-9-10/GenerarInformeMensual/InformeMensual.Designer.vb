<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InformeMensual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InformeMensual))
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.MontoInicial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoFinal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Recaudado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.lblTotalRecaudado = New System.Windows.Forms.Label()
        Me.lblPerdida = New System.Windows.Forms.Label()
        Me.lblGanancia = New System.Windows.Forms.Label()
        Me.lblNroIM = New System.Windows.Forms.Label()
        Me.lblFechaIM = New System.Windows.Forms.Label()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDetalle
        '
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MontoInicial, Me.MontoFinal, Me.Recaudado, Me.Fecha})
        Me.dgvDetalle.Location = New System.Drawing.Point(12, 126)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.Size = New System.Drawing.Size(411, 219)
        Me.dgvDetalle.TabIndex = 13
        '
        'MontoInicial
        '
        Me.MontoInicial.HeaderText = "Monto Inicial"
        Me.MontoInicial.Name = "MontoInicial"
        Me.MontoInicial.Width = 90
        '
        'MontoFinal
        '
        Me.MontoFinal.HeaderText = "Monto Final"
        Me.MontoFinal.Name = "MontoFinal"
        Me.MontoFinal.Width = 90
        '
        'Recaudado
        '
        Me.Recaudado.HeaderText = "Recaudado"
        Me.Recaudado.Name = "Recaudado"
        Me.Recaudado.Width = 90
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Width = 95
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(335, 351)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(88, 31)
        Me.btnRegistrar.TabIndex = 12
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'lblTotalRecaudado
        '
        Me.lblTotalRecaudado.AutoSize = True
        Me.lblTotalRecaudado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRecaudado.Location = New System.Drawing.Point(260, 463)
        Me.lblTotalRecaudado.Name = "lblTotalRecaudado"
        Me.lblTotalRecaudado.Size = New System.Drawing.Size(127, 20)
        Me.lblTotalRecaudado.TabIndex = 11
        Me.lblTotalRecaudado.Text = "TotalRecaudado"
        '
        'lblPerdida
        '
        Me.lblPerdida.AutoSize = True
        Me.lblPerdida.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerdida.Location = New System.Drawing.Point(178, 429)
        Me.lblPerdida.Name = "lblPerdida"
        Me.lblPerdida.Size = New System.Drawing.Size(71, 20)
        Me.lblPerdida.TabIndex = 10
        Me.lblPerdida.Text = "Perdidas"
        '
        'lblGanancia
        '
        Me.lblGanancia.AutoSize = True
        Me.lblGanancia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGanancia.Location = New System.Drawing.Point(225, 396)
        Me.lblGanancia.Name = "lblGanancia"
        Me.lblGanancia.Size = New System.Drawing.Size(86, 20)
        Me.lblGanancia.TabIndex = 9
        Me.lblGanancia.Text = "Ganancias"
        '
        'lblNroIM
        '
        Me.lblNroIM.AutoSize = True
        Me.lblNroIM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroIM.Location = New System.Drawing.Point(348, 68)
        Me.lblNroIM.Name = "lblNroIM"
        Me.lblNroIM.Size = New System.Drawing.Size(52, 20)
        Me.lblNroIM.TabIndex = 8
        Me.lblNroIM.Text = "NroIM"
        '
        'lblFechaIM
        '
        Me.lblFechaIM.AutoSize = True
        Me.lblFechaIM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaIM.Location = New System.Drawing.Point(134, 68)
        Me.lblFechaIM.Name = "lblFechaIM"
        Me.lblFechaIM.Size = New System.Drawing.Size(72, 20)
        Me.lblFechaIM.TabIndex = 7
        Me.lblFechaIM.Text = "FechaIM"
        '
        'InformeMensual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(435, 509)
        Me.Controls.Add(Me.dgvDetalle)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.lblTotalRecaudado)
        Me.Controls.Add(Me.lblPerdida)
        Me.Controls.Add(Me.lblGanancia)
        Me.Controls.Add(Me.lblNroIM)
        Me.Controls.Add(Me.lblFechaIM)
        Me.Name = "InformeMensual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InformeMensual"
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents MontoInicial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoFinal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Recaudado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents lblTotalRecaudado As System.Windows.Forms.Label
    Friend WithEvents lblPerdida As System.Windows.Forms.Label
    Friend WithEvents lblGanancia As System.Windows.Forms.Label
    Friend WithEvents lblNroIM As System.Windows.Forms.Label
    Friend WithEvents lblFechaIM As System.Windows.Forms.Label
End Class

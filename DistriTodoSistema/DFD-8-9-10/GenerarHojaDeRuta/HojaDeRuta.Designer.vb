<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HojaDeRuta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HojaDeRuta))
        Me.lblNro = New System.Windows.Forms.Label()
        Me.btnGenerarHojaRuta = New System.Windows.Forms.Button()
        Me.cboConductor = New System.Windows.Forms.ComboBox()
        Me.NomConductor = New System.Windows.Forms.Label()
        Me.lblFechActual = New System.Windows.Forms.Label()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.dgvHojaRuta = New System.Windows.Forms.DataGridView()
        Me.Nro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreyApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dirección = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantArt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorarioEntrega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Firma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvHojaRuta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNro
        '
        Me.lblNro.AutoSize = True
        Me.lblNro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNro.Location = New System.Drawing.Point(675, 22)
        Me.lblNro.Name = "lblNro"
        Me.lblNro.Size = New System.Drawing.Size(33, 18)
        Me.lblNro.TabIndex = 15
        Me.lblNro.Text = "Nro"
        '
        'btnGenerarHojaRuta
        '
        Me.btnGenerarHojaRuta.Location = New System.Drawing.Point(12, 325)
        Me.btnGenerarHojaRuta.Name = "btnGenerarHojaRuta"
        Me.btnGenerarHojaRuta.Size = New System.Drawing.Size(111, 34)
        Me.btnGenerarHojaRuta.TabIndex = 14
        Me.btnGenerarHojaRuta.Text = "Generar Hoja de Ruta"
        Me.btnGenerarHojaRuta.UseVisualStyleBackColor = True
        '
        'cboConductor
        '
        Me.cboConductor.FormattingEnabled = True
        Me.cboConductor.Location = New System.Drawing.Point(170, 64)
        Me.cboConductor.Name = "cboConductor"
        Me.cboConductor.Size = New System.Drawing.Size(121, 21)
        Me.cboConductor.TabIndex = 13
        '
        'NomConductor
        '
        Me.NomConductor.AutoSize = True
        Me.NomConductor.Location = New System.Drawing.Point(190, 67)
        Me.NomConductor.Name = "NomConductor"
        Me.NomConductor.Size = New System.Drawing.Size(56, 13)
        Me.NomConductor.TabIndex = 12
        Me.NomConductor.Text = "Conductor"
        '
        'lblFechActual
        '
        Me.lblFechActual.AutoSize = True
        Me.lblFechActual.Location = New System.Drawing.Point(480, 67)
        Me.lblFechActual.Name = "lblFechActual"
        Me.lblFechActual.Size = New System.Drawing.Size(67, 13)
        Me.lblFechActual.TabIndex = 11
        Me.lblFechActual.Text = "FechaActual"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(634, 339)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(99, 34)
        Me.btnConfirmar.TabIndex = 10
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'dgvHojaRuta
        '
        Me.dgvHojaRuta.AllowUserToAddRows = False
        Me.dgvHojaRuta.AllowUserToDeleteRows = False
        Me.dgvHojaRuta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHojaRuta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nro, Me.NombreyApellido, Me.Dirección, Me.Telefono, Me.CantArt, Me.HorarioEntrega, Me.Monto, Me.Firma})
        Me.dgvHojaRuta.Location = New System.Drawing.Point(4, 86)
        Me.dgvHojaRuta.Name = "dgvHojaRuta"
        Me.dgvHojaRuta.Size = New System.Drawing.Size(734, 235)
        Me.dgvHojaRuta.TabIndex = 9
        '
        'Nro
        '
        Me.Nro.HeaderText = "Nro"
        Me.Nro.Name = "Nro"
        Me.Nro.Width = 35
        '
        'NombreyApellido
        '
        Me.NombreyApellido.HeaderText = "Nombre y Apellido"
        Me.NombreyApellido.Name = "NombreyApellido"
        Me.NombreyApellido.Width = 130
        '
        'Dirección
        '
        Me.Dirección.HeaderText = "Dirección"
        Me.Dirección.Name = "Dirección"
        '
        'Telefono
        '
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        '
        'CantArt
        '
        Me.CantArt.HeaderText = "Cantidad Articulos"
        Me.CantArt.Name = "CantArt"
        Me.CantArt.Width = 85
        '
        'HorarioEntrega
        '
        Me.HorarioEntrega.HeaderText = "Fecha Entrega"
        Me.HorarioEntrega.Name = "HorarioEntrega"
        Me.HorarioEntrega.Width = 90
        '
        'Monto
        '
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.Width = 50
        '
        'Firma
        '
        Me.Firma.HeaderText = "Firma"
        Me.Firma.Name = "Firma"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(361, 345)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'HojaDeRuta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(745, 385)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblNro)
        Me.Controls.Add(Me.btnGenerarHojaRuta)
        Me.Controls.Add(Me.cboConductor)
        Me.Controls.Add(Me.NomConductor)
        Me.Controls.Add(Me.lblFechActual)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.dgvHojaRuta)
        Me.Name = "HojaDeRuta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HojaDeRuta"
        CType(Me.dgvHojaRuta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNro As System.Windows.Forms.Label
    Friend WithEvents btnGenerarHojaRuta As System.Windows.Forms.Button
    Friend WithEvents cboConductor As System.Windows.Forms.ComboBox
    Friend WithEvents NomConductor As System.Windows.Forms.Label
    Friend WithEvents lblFechActual As System.Windows.Forms.Label
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents dgvHojaRuta As System.Windows.Forms.DataGridView
    Friend WithEvents Nro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreyApellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dirección As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantArt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HorarioEntrega As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Firma As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

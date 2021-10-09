<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm3Proveedores01
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm3Proveedores01))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblCUIT = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblNroProveedor = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.cmbProveedores = New System.Windows.Forms.ComboBox()
        Me.btnRegresarPagAnterior = New System.Windows.Forms.Button()
        Me.btnSiguienteOrdenCompra = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTelefono)
        Me.GroupBox1.Controls.Add(Me.lblCUIT)
        Me.GroupBox1.Controls.Add(Me.lblDireccion)
        Me.GroupBox1.Controls.Add(Me.lblNroProveedor)
        Me.GroupBox1.Controls.Add(Me.lbl4)
        Me.GroupBox1.Controls.Add(Me.lbl3)
        Me.GroupBox1.Controls.Add(Me.lbl2)
        Me.GroupBox1.Controls.Add(Me.lbl1)
        Me.GroupBox1.Controls.Add(Me.cmbProveedores)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(408, 171)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Enabled = False
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(167, 119)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(0, 16)
        Me.lblTelefono.TabIndex = 22
        '
        'lblCUIT
        '
        Me.lblCUIT.AutoSize = True
        Me.lblCUIT.Enabled = False
        Me.lblCUIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCUIT.Location = New System.Drawing.Point(167, 93)
        Me.lblCUIT.Name = "lblCUIT"
        Me.lblCUIT.Size = New System.Drawing.Size(0, 16)
        Me.lblCUIT.TabIndex = 21
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Enabled = False
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(167, 67)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(0, 16)
        Me.lblDireccion.TabIndex = 20
        '
        'lblNroProveedor
        '
        Me.lblNroProveedor.AutoSize = True
        Me.lblNroProveedor.Enabled = False
        Me.lblNroProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroProveedor.Location = New System.Drawing.Point(167, 41)
        Me.lblNroProveedor.Name = "lblNroProveedor"
        Me.lblNroProveedor.Size = New System.Drawing.Size(0, 16)
        Me.lblNroProveedor.TabIndex = 19
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Enabled = False
        Me.lbl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.Location = New System.Drawing.Point(89, 119)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(62, 16)
        Me.lbl4.TabIndex = 18
        Me.lbl4.Text = "Telefono"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Enabled = False
        Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.Location = New System.Drawing.Point(112, 93)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(39, 16)
        Me.lbl3.TabIndex = 17
        Me.lbl3.Text = "CUIT"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Enabled = False
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(86, 67)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(65, 16)
        Me.lbl2.TabIndex = 16
        Me.lbl2.Text = "Direccion"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Enabled = False
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(6, 41)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(145, 16)
        Me.lbl1.TabIndex = 15
        Me.lbl1.Text = "Nro/Cod de Proveedor"
        '
        'cmbProveedores
        '
        Me.cmbProveedores.FormattingEnabled = True
        Me.cmbProveedores.Location = New System.Drawing.Point(6, 0)
        Me.cmbProveedores.Name = "cmbProveedores"
        Me.cmbProveedores.Size = New System.Drawing.Size(200, 21)
        Me.cmbProveedores.TabIndex = 0
        Me.cmbProveedores.Text = "(Proveedores)"
        '
        'btnRegresarPagAnterior
        '
        Me.btnRegresarPagAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresarPagAnterior.Location = New System.Drawing.Point(12, 199)
        Me.btnRegresarPagAnterior.Name = "btnRegresarPagAnterior"
        Me.btnRegresarPagAnterior.Size = New System.Drawing.Size(100, 50)
        Me.btnRegresarPagAnterior.TabIndex = 4
        Me.btnRegresarPagAnterior.Text = "Regresar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pag."
        Me.btnRegresarPagAnterior.UseVisualStyleBackColor = True
        '
        'btnSiguienteOrdenCompra
        '
        Me.btnSiguienteOrdenCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguienteOrdenCompra.Location = New System.Drawing.Point(320, 199)
        Me.btnSiguienteOrdenCompra.Name = "btnSiguienteOrdenCompra"
        Me.btnSiguienteOrdenCompra.Size = New System.Drawing.Size(100, 50)
        Me.btnSiguienteOrdenCompra.TabIndex = 5
        Me.btnSiguienteOrdenCompra.Text = "Generar Orden de Compra"
        Me.btnSiguienteOrdenCompra.UseVisualStyleBackColor = True
        '
        'frm3Proveedores01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(432, 261)
        Me.Controls.Add(Me.btnRegresarPagAnterior)
        Me.Controls.Add(Me.btnSiguienteOrdenCompra)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm3Proveedores01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generar Orden de Compra - Seleccionar Proveedor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbProveedores As System.Windows.Forms.ComboBox
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents lblCUIT As System.Windows.Forms.Label
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents lblNroProveedor As System.Windows.Forms.Label
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents btnRegresarPagAnterior As System.Windows.Forms.Button
    Friend WithEvents btnSiguienteOrdenCompra As System.Windows.Forms.Button
End Class

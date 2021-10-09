<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm1Principal01
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm1Principal01))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstProductosPP = New System.Windows.Forms.ListBox()
        Me.rdbOpc2SinOrdCompra = New System.Windows.Forms.RadioButton()
        Me.rdbOpc1ConOrden = New System.Windows.Forms.RadioButton()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnFrmCompletarDatos = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstProductosPP)
        Me.GroupBox1.Controls.Add(Me.rdbOpc2SinOrdCompra)
        Me.GroupBox1.Controls.Add(Me.rdbOpc1ConOrden)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(23, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(476, 361)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Productos en Punto de Pedido"
        '
        'lstProductosPP
        '
        Me.lstProductosPP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstProductosPP.FormattingEnabled = True
        Me.lstProductosPP.ItemHeight = 18
        Me.lstProductosPP.Location = New System.Drawing.Point(6, 84)
        Me.lstProductosPP.Name = "lstProductosPP"
        Me.lstProductosPP.Size = New System.Drawing.Size(464, 256)
        Me.lstProductosPP.TabIndex = 2
        '
        'rdbOpc2SinOrdCompra
        '
        Me.rdbOpc2SinOrdCompra.AutoSize = True
        Me.rdbOpc2SinOrdCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbOpc2SinOrdCompra.Location = New System.Drawing.Point(6, 56)
        Me.rdbOpc2SinOrdCompra.Name = "rdbOpc2SinOrdCompra"
        Me.rdbOpc2SinOrdCompra.Size = New System.Drawing.Size(252, 22)
        Me.rdbOpc2SinOrdCompra.TabIndex = 1
        Me.rdbOpc2SinOrdCompra.TabStop = True
        Me.rdbOpc2SinOrdCompra.Text = "Registrados sin Orden de Compra"
        Me.rdbOpc2SinOrdCompra.UseVisualStyleBackColor = True
        '
        'rdbOpc1ConOrden
        '
        Me.rdbOpc1ConOrden.AutoSize = True
        Me.rdbOpc1ConOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbOpc1ConOrden.Location = New System.Drawing.Point(6, 28)
        Me.rdbOpc1ConOrden.Name = "rdbOpc1ConOrden"
        Me.rdbOpc1ConOrden.Size = New System.Drawing.Size(258, 22)
        Me.rdbOpc1ConOrden.TabIndex = 0
        Me.rdbOpc1ConOrden.TabStop = True
        Me.rdbOpc1ConOrden.Text = "Registrados con Orden de Compra"
        Me.rdbOpc1ConOrden.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.Location = New System.Drawing.Point(211, 385)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(100, 50)
        Me.btnMenu.TabIndex = 2
        Me.btnMenu.Text = "MENU"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'btnFrmCompletarDatos
        '
        Me.btnFrmCompletarDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFrmCompletarDatos.Location = New System.Drawing.Point(408, 385)
        Me.btnFrmCompletarDatos.Name = "btnFrmCompletarDatos"
        Me.btnFrmCompletarDatos.Size = New System.Drawing.Size(100, 50)
        Me.btnFrmCompletarDatos.TabIndex = 3
        Me.btnFrmCompletarDatos.Text = "Generar Orden de Compra"
        Me.btnFrmCompletarDatos.UseVisualStyleBackColor = True
        Me.btnFrmCompletarDatos.Visible = False
        '
        'frm1Principal01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(520, 447)
        Me.Controls.Add(Me.btnFrmCompletarDatos)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm1Principal01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos en Punto de Pedido"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstProductosPP As System.Windows.Forms.ListBox
    Friend WithEvents rdbOpc2SinOrdCompra As System.Windows.Forms.RadioButton
    Friend WithEvents rdbOpc1ConOrden As System.Windows.Forms.RadioButton
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents btnFrmCompletarDatos As System.Windows.Forms.Button

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm1Principal02
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm1Principal02))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblNroOrdenCompra = New System.Windows.Forms.Label()
        Me.btnIrOrdenCompra = New System.Windows.Forms.Button()
        Me.dtgListaOrdenCompra = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtgListaOrdenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblNroOrdenCompra)
        Me.GroupBox1.Controls.Add(Me.btnIrOrdenCompra)
        Me.GroupBox1.Controls.Add(Me.dtgListaOrdenCompra)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(522, 277)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de Orden de Compra"
        '
        'lblNroOrdenCompra
        '
        Me.lblNroOrdenCompra.AutoSize = True
        Me.lblNroOrdenCompra.Enabled = False
        Me.lblNroOrdenCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroOrdenCompra.Location = New System.Drawing.Point(6, 231)
        Me.lblNroOrdenCompra.Name = "lblNroOrdenCompra"
        Me.lblNroOrdenCompra.Size = New System.Drawing.Size(198, 20)
        Me.lblNroOrdenCompra.TabIndex = 4
        Me.lblNroOrdenCompra.Text = "Nro de Orden de Compra:  "
        '
        'btnIrOrdenCompra
        '
        Me.btnIrOrdenCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIrOrdenCompra.Location = New System.Drawing.Point(416, 212)
        Me.btnIrOrdenCompra.Name = "btnIrOrdenCompra"
        Me.btnIrOrdenCompra.Size = New System.Drawing.Size(100, 59)
        Me.btnIrOrdenCompra.TabIndex = 3
        Me.btnIrOrdenCompra.Text = "Ver" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Orden de Compra"
        Me.btnIrOrdenCompra.UseVisualStyleBackColor = True
        '
        'dtgListaOrdenCompra
        '
        Me.dtgListaOrdenCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgListaOrdenCompra.Location = New System.Drawing.Point(6, 25)
        Me.dtgListaOrdenCompra.Name = "dtgListaOrdenCompra"
        Me.dtgListaOrdenCompra.Size = New System.Drawing.Size(510, 181)
        Me.dtgListaOrdenCompra.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(222, 315)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm1Principal02
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(545, 350)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm1Principal02"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Orden de Compra"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtgListaOrdenCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnIrOrdenCompra As System.Windows.Forms.Button
    Friend WithEvents dtgListaOrdenCompra As System.Windows.Forms.DataGridView
    Friend WithEvents lblNroOrdenCompra As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

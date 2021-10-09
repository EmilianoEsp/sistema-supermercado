<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class venta
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtA = New System.Windows.Forms.RadioButton()
        Me.rbtB = New System.Windows.Forms.RadioButton()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.Label()
        Me.tabla2 = New System.Windows.Forms.DataGridView()
        Me.codp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numeric1 = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tabla1 = New System.Windows.Forms.DataGridView()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tabla2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numeric1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabla1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtA)
        Me.GroupBox1.Controls.Add(Me.rbtB)
        Me.GroupBox1.Location = New System.Drawing.Point(690, 4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(111, 63)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de factura"
        '
        'rbtA
        '
        Me.rbtA.AutoSize = True
        Me.rbtA.Location = New System.Drawing.Point(21, 24)
        Me.rbtA.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtA.Name = "rbtA"
        Me.rbtA.Size = New System.Drawing.Size(32, 17)
        Me.rbtA.TabIndex = 0
        Me.rbtA.TabStop = True
        Me.rbtA.Text = "A"
        Me.rbtA.UseVisualStyleBackColor = True
        '
        'rbtB
        '
        Me.rbtB.AutoSize = True
        Me.rbtB.Location = New System.Drawing.Point(67, 24)
        Me.rbtB.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtB.Name = "rbtB"
        Me.rbtB.Size = New System.Drawing.Size(32, 17)
        Me.rbtB.TabIndex = 1
        Me.rbtB.TabStop = True
        Me.rbtB.Text = "B"
        Me.rbtB.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(754, 462)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(17, 17)
        Me.lblTotal.TabIndex = 23
        Me.lblTotal.Text = "X"
        '
        'total
        '
        Me.total.AutoSize = True
        Me.total.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total.Location = New System.Drawing.Point(719, 462)
        Me.total.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(40, 17)
        Me.total.TabIndex = 22
        Me.total.Text = "Total"
        '
        'tabla2
        '
        Me.tabla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabla2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codp, Me.producto, Me.cantidad, Me.precio})
        Me.tabla2.Location = New System.Drawing.Point(33, 102)
        Me.tabla2.Margin = New System.Windows.Forms.Padding(2)
        Me.tabla2.Name = "tabla2"
        Me.tabla2.RowHeadersWidth = 51
        Me.tabla2.RowTemplate.Height = 24
        Me.tabla2.Size = New System.Drawing.Size(814, 353)
        Me.tabla2.TabIndex = 21
        '
        'codp
        '
        Me.codp.HeaderText = "codigo"
        Me.codp.MinimumWidth = 6
        Me.codp.Name = "codp"
        Me.codp.Width = 125
        '
        'producto
        '
        Me.producto.HeaderText = "producto"
        Me.producto.MinimumWidth = 6
        Me.producto.Name = "producto"
        Me.producto.Width = 125
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "cantidad"
        Me.cantidad.MinimumWidth = 6
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Width = 125
        '
        'precio
        '
        Me.precio.HeaderText = "precio"
        Me.precio.MinimumWidth = 6
        Me.precio.Name = "precio"
        Me.precio.Width = 125
        '
        'numeric1
        '
        Me.numeric1.Location = New System.Drawing.Point(372, 26)
        Me.numeric1.Margin = New System.Windows.Forms.Padding(2)
        Me.numeric1.Name = "numeric1"
        Me.numeric1.Size = New System.Drawing.Size(133, 20)
        Me.numeric1.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(317, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Cantidad"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(524, 15)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(116, 40)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Agregar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(704, 505)
        Me.btnSiguiente.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(143, 48)
        Me.btnSiguiente.TabIndex = 17
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(56, 505)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 48)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tabla1
        '
        Me.tabla1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabla1.Location = New System.Drawing.Point(33, 102)
        Me.tabla1.Margin = New System.Windows.Forms.Padding(2)
        Me.tabla1.Name = "tabla1"
        Me.tabla1.RowHeadersWidth = 51
        Me.tabla1.RowTemplate.Height = 24
        Me.tabla1.Size = New System.Drawing.Size(378, 54)
        Me.tabla1.TabIndex = 15
        Me.tabla1.Visible = False
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(144, 25)
        Me.txt1.Margin = New System.Windows.Forms.Padding(2)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(134, 20)
        Me.txt1.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "codigo de barra"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(56, 51)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(220, 31)
        Me.btnBuscar.TabIndex = 25
        Me.btnBuscar.Text = "Buscar por nombre"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(880, 568)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.tabla2)
        Me.Controls.Add(Me.numeric1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tabla1)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "venta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.tabla2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numeric1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabla1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtA As RadioButton
    Friend WithEvents rbtB As RadioButton
    Friend WithEvents lblTotal As Label
    Friend WithEvents total As Label
    Friend WithEvents tabla2 As DataGridView
    Friend WithEvents numeric1 As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents tabla1 As DataGridView
    Friend WithEvents txt1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents codp As DataGridViewTextBoxColumn
    Friend WithEvents producto As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents btnBuscar As Button
End Class

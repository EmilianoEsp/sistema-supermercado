<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gondolas
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.txtCant = New System.Windows.Forms.TextBox()
        Me.txtLugar = New System.Windows.Forms.TextBox()
        Me.txtVencimiento = New System.Windows.Forms.TextBox()
        Me.tablaAux = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.tablaAux, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(132, 39)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(173, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Gondola"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(101, 258)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 48)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "cargar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 88)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 124)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cantidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 166)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Lugar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 209)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "F Vencimiento"
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(132, 88)
        Me.txtProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(172, 20)
        Me.txtProducto.TabIndex = 7
        '
        'txtCant
        '
        Me.txtCant.Location = New System.Drawing.Point(132, 124)
        Me.txtCant.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCant.Name = "txtCant"
        Me.txtCant.Size = New System.Drawing.Size(172, 20)
        Me.txtCant.TabIndex = 8
        '
        'txtLugar
        '
        Me.txtLugar.Location = New System.Drawing.Point(132, 166)
        Me.txtLugar.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLugar.Name = "txtLugar"
        Me.txtLugar.Size = New System.Drawing.Size(172, 20)
        Me.txtLugar.TabIndex = 9
        '
        'txtVencimiento
        '
        Me.txtVencimiento.Location = New System.Drawing.Point(132, 209)
        Me.txtVencimiento.Margin = New System.Windows.Forms.Padding(2)
        Me.txtVencimiento.Name = "txtVencimiento"
        Me.txtVencimiento.Size = New System.Drawing.Size(172, 20)
        Me.txtVencimiento.TabIndex = 10
        '
        'tablaAux
        '
        Me.tablaAux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaAux.Location = New System.Drawing.Point(370, 11)
        Me.tablaAux.Margin = New System.Windows.Forms.Padding(2)
        Me.tablaAux.Name = "tablaAux"
        Me.tablaAux.RowHeadersWidth = 51
        Me.tablaAux.RowTemplate.Height = 24
        Me.tablaAux.Size = New System.Drawing.Size(131, 19)
        Me.tablaAux.TabIndex = 11
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(287, 313)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Volver"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Gondolas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(374, 348)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.tablaAux)
        Me.Controls.Add(Me.txtVencimiento)
        Me.Controls.Add(Me.txtLugar)
        Me.Controls.Add(Me.txtCant)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Gondolas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gondolas"
        CType(Me.tablaAux, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents txtCant As TextBox
    Friend WithEvents txtLugar As TextBox
    Friend WithEvents txtVencimiento As TextBox
    Friend WithEvents tablaAux As DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class

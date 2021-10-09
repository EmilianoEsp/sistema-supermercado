<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pago
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
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.grbMetodo = New System.Windows.Forms.GroupBox()
        Me.lblTarjeta = New System.Windows.Forms.Label()
        Me.cboxTarjeta = New System.Windows.Forms.ComboBox()
        Me.lblCuotas = New System.Windows.Forms.Label()
        Me.cboxCuotas = New System.Windows.Forms.ComboBox()
        Me.rbtTarjeta = New System.Windows.Forms.RadioButton()
        Me.rbtEfectivo = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.grbMetodo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnFinalizar
        '
        Me.btnFinalizar.Location = New System.Drawing.Point(110, 183)
        Me.btnFinalizar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(164, 53)
        Me.btnFinalizar.TabIndex = 3
        Me.btnFinalizar.Text = "Efectuar Pago"
        Me.btnFinalizar.UseVisualStyleBackColor = True
        '
        'grbMetodo
        '
        Me.grbMetodo.Controls.Add(Me.lblTarjeta)
        Me.grbMetodo.Controls.Add(Me.cboxTarjeta)
        Me.grbMetodo.Controls.Add(Me.lblCuotas)
        Me.grbMetodo.Controls.Add(Me.cboxCuotas)
        Me.grbMetodo.Controls.Add(Me.rbtTarjeta)
        Me.grbMetodo.Controls.Add(Me.rbtEfectivo)
        Me.grbMetodo.Location = New System.Drawing.Point(82, 9)
        Me.grbMetodo.Margin = New System.Windows.Forms.Padding(2)
        Me.grbMetodo.Name = "grbMetodo"
        Me.grbMetodo.Padding = New System.Windows.Forms.Padding(2)
        Me.grbMetodo.Size = New System.Drawing.Size(220, 141)
        Me.grbMetodo.TabIndex = 2
        Me.grbMetodo.TabStop = False
        Me.grbMetodo.Text = "Metodo de pago"
        '
        'lblTarjeta
        '
        Me.lblTarjeta.AutoSize = True
        Me.lblTarjeta.Location = New System.Drawing.Point(12, 72)
        Me.lblTarjeta.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTarjeta.Name = "lblTarjeta"
        Me.lblTarjeta.Size = New System.Drawing.Size(75, 13)
        Me.lblTarjeta.TabIndex = 5
        Me.lblTarjeta.Text = "Tipo de tarjeta"
        '
        'cboxTarjeta
        '
        Me.cboxTarjeta.FormattingEnabled = True
        Me.cboxTarjeta.Items.AddRange(New Object() {"Credito", "Debito"})
        Me.cboxTarjeta.Location = New System.Drawing.Point(92, 70)
        Me.cboxTarjeta.Margin = New System.Windows.Forms.Padding(2)
        Me.cboxTarjeta.Name = "cboxTarjeta"
        Me.cboxTarjeta.Size = New System.Drawing.Size(92, 21)
        Me.cboxTarjeta.TabIndex = 4
        '
        'lblCuotas
        '
        Me.lblCuotas.AutoSize = True
        Me.lblCuotas.Location = New System.Drawing.Point(38, 111)
        Me.lblCuotas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCuotas.Name = "lblCuotas"
        Me.lblCuotas.Size = New System.Drawing.Size(40, 13)
        Me.lblCuotas.TabIndex = 3
        Me.lblCuotas.Text = "Cuotas"
        '
        'cboxCuotas
        '
        Me.cboxCuotas.FormattingEnabled = True
        Me.cboxCuotas.Location = New System.Drawing.Point(92, 109)
        Me.cboxCuotas.Margin = New System.Windows.Forms.Padding(2)
        Me.cboxCuotas.Name = "cboxCuotas"
        Me.cboxCuotas.Size = New System.Drawing.Size(92, 21)
        Me.cboxCuotas.TabIndex = 2
        '
        'rbtTarjeta
        '
        Me.rbtTarjeta.AutoSize = True
        Me.rbtTarjeta.Location = New System.Drawing.Point(127, 28)
        Me.rbtTarjeta.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtTarjeta.Name = "rbtTarjeta"
        Me.rbtTarjeta.Size = New System.Drawing.Size(58, 17)
        Me.rbtTarjeta.TabIndex = 1
        Me.rbtTarjeta.TabStop = True
        Me.rbtTarjeta.Text = "Tarjeta"
        Me.rbtTarjeta.UseVisualStyleBackColor = True
        '
        'rbtEfectivo
        '
        Me.rbtEfectivo.AutoSize = True
        Me.rbtEfectivo.Location = New System.Drawing.Point(28, 28)
        Me.rbtEfectivo.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtEfectivo.Name = "rbtEfectivo"
        Me.rbtEfectivo.Size = New System.Drawing.Size(64, 17)
        Me.rbtEfectivo.TabIndex = 0
        Me.rbtEfectivo.TabStop = True
        Me.rbtEfectivo.Text = "Efectivo"
        Me.rbtEfectivo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(424, 9)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(321, 223)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la Tarjeta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(188, 190)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "FECHA V"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 193)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "CODIGO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 150)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "NRO DNI"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 110)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "APELLIDO"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(82, 106)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(235, 20)
        Me.TextBox6.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 67)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "NOMBRE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "NUMERO"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(82, 189)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(76, 20)
        Me.TextBox4.TabIndex = 5
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(242, 188)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(76, 20)
        Me.TextBox5.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(82, 146)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(235, 20)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(82, 67)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(235, 20)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(82, 26)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(235, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Pago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(794, 251)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnFinalizar)
        Me.Controls.Add(Me.grbMetodo)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Pago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pago"
        Me.grbMetodo.ResumeLayout(False)
        Me.grbMetodo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnFinalizar As Button
    Friend WithEvents grbMetodo As GroupBox
    Friend WithEvents lblTarjeta As Label
    Friend WithEvents cboxTarjeta As ComboBox
    Friend WithEvents lblCuotas As Label
    Friend WithEvents cboxCuotas As ComboBox
    Friend WithEvents rbtTarjeta As RadioButton
    Friend WithEvents rbtEfectivo As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class

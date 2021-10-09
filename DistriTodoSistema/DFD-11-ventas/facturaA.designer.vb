<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class facturaA
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
        Me.btnContinuar = New System.Windows.Forms.Button()
        Me.grbA = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCuit = New System.Windows.Forms.TextBox()
        Me.txtEmpresa = New System.Windows.Forms.TextBox()
        Me.grbA.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnContinuar
        '
        Me.btnContinuar.Location = New System.Drawing.Point(326, 156)
        Me.btnContinuar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnContinuar.Name = "btnContinuar"
        Me.btnContinuar.Size = New System.Drawing.Size(130, 37)
        Me.btnContinuar.TabIndex = 6
        Me.btnContinuar.Text = "Continuar"
        Me.btnContinuar.UseVisualStyleBackColor = True
        '
        'grbA
        '
        Me.grbA.Controls.Add(Me.Label2)
        Me.grbA.Controls.Add(Me.Label1)
        Me.grbA.Controls.Add(Me.txtCuit)
        Me.grbA.Controls.Add(Me.txtEmpresa)
        Me.grbA.Location = New System.Drawing.Point(9, 9)
        Me.grbA.Margin = New System.Windows.Forms.Padding(2)
        Me.grbA.Name = "grbA"
        Me.grbA.Padding = New System.Windows.Forms.Padding(2)
        Me.grbA.Size = New System.Drawing.Size(447, 130)
        Me.grbA.TabIndex = 5
        Me.grbA.TabStop = False
        Me.grbA.Text = "Factura A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(139, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "CUIL - CUIT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre de la empresa"
        '
        'txtCuit
        '
        Me.txtCuit.Location = New System.Drawing.Point(218, 63)
        Me.txtCuit.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCuit.Name = "txtCuit"
        Me.txtCuit.Size = New System.Drawing.Size(159, 20)
        Me.txtCuit.TabIndex = 1
        '
        'txtEmpresa
        '
        Me.txtEmpresa.Location = New System.Drawing.Point(218, 18)
        Me.txtEmpresa.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Size = New System.Drawing.Size(159, 20)
        Me.txtEmpresa.TabIndex = 0
        '
        'facturaA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(470, 208)
        Me.Controls.Add(Me.btnContinuar)
        Me.Controls.Add(Me.grbA)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "facturaA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "facturaA"
        Me.grbA.ResumeLayout(False)
        Me.grbA.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnContinuar As Button
    Friend WithEvents grbA As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCuit As TextBox
    Friend WithEvents txtEmpresa As TextBox
End Class

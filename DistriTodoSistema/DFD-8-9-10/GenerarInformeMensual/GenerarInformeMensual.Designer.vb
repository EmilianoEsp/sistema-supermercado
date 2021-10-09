<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerarInformeMensual
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
        Me.btnGenerarInformeM = New System.Windows.Forms.Button()
        Me.gbFF = New System.Windows.Forms.GroupBox()
        Me.dtpFF = New System.Windows.Forms.DateTimePicker()
        Me.gbFI = New System.Windows.Forms.GroupBox()
        Me.dtpFI = New System.Windows.Forms.DateTimePicker()
        Me.lblF = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gbFF.SuspendLayout()
        Me.gbFI.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGenerarInformeM
        '
        Me.btnGenerarInformeM.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarInformeM.Location = New System.Drawing.Point(147, 99)
        Me.btnGenerarInformeM.Name = "btnGenerarInformeM"
        Me.btnGenerarInformeM.Size = New System.Drawing.Size(146, 39)
        Me.btnGenerarInformeM.TabIndex = 5
        Me.btnGenerarInformeM.Text = "Generar Informe Mensual"
        Me.btnGenerarInformeM.UseVisualStyleBackColor = True
        '
        'gbFF
        '
        Me.gbFF.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gbFF.Controls.Add(Me.dtpFF)
        Me.gbFF.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFF.Location = New System.Drawing.Point(233, 29)
        Me.gbFF.Name = "gbFF"
        Me.gbFF.Size = New System.Drawing.Size(200, 64)
        Me.gbFF.TabIndex = 4
        Me.gbFF.TabStop = False
        Me.gbFF.Text = "Seleccione Fecha Final de mes"
        '
        'dtpFF
        '
        Me.dtpFF.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFF.Location = New System.Drawing.Point(39, 28)
        Me.dtpFF.Name = "dtpFF"
        Me.dtpFF.Size = New System.Drawing.Size(106, 21)
        Me.dtpFF.TabIndex = 0
        '
        'gbFI
        '
        Me.gbFI.Controls.Add(Me.dtpFI)
        Me.gbFI.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFI.Location = New System.Drawing.Point(5, 29)
        Me.gbFI.Name = "gbFI"
        Me.gbFI.Size = New System.Drawing.Size(222, 64)
        Me.gbFI.TabIndex = 3
        Me.gbFI.TabStop = False
        Me.gbFI.Text = "Seleccione Fecha de Inicio del Mes"
        '
        'dtpFI
        '
        Me.dtpFI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFI.Location = New System.Drawing.Point(44, 28)
        Me.dtpFI.Name = "dtpFI"
        Me.dtpFI.Size = New System.Drawing.Size(106, 21)
        Me.dtpFI.TabIndex = 0
        '
        'lblF
        '
        Me.lblF.AutoSize = True
        Me.lblF.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblF.Location = New System.Drawing.Point(178, 9)
        Me.lblF.Name = "lblF"
        Me.lblF.Size = New System.Drawing.Size(104, 16)
        Me.lblF.TabIndex = 6
        Me.lblF.Text = "Ingrese Fechas"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(353, 115)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GenerarInformeMensual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(440, 149)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblF)
        Me.Controls.Add(Me.btnGenerarInformeM)
        Me.Controls.Add(Me.gbFF)
        Me.Controls.Add(Me.gbFI)
        Me.Name = "GenerarInformeMensual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GenerarInformeMensual"
        Me.gbFF.ResumeLayout(False)
        Me.gbFI.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGenerarInformeM As System.Windows.Forms.Button
    Friend WithEvents gbFF As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFF As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbFI As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFI As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblF As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

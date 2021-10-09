<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm1Principal03
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm1Principal03))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNotaCredito = New System.Windows.Forms.Button()
        Me.btnVerificarExistencia = New System.Windows.Forms.Button()
        Me.nudNumeroTicket = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudNumeroTicket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnNotaCredito)
        Me.GroupBox1.Controls.Add(Me.btnVerificarExistencia)
        Me.GroupBox1.Controls.Add(Me.nudNumeroTicket)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 237)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Verificar Existencia del Ticket"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nro de Ticket"
        '
        'btnNotaCredito
        '
        Me.btnNotaCredito.Enabled = False
        Me.btnNotaCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotaCredito.Location = New System.Drawing.Point(154, 178)
        Me.btnNotaCredito.Name = "btnNotaCredito"
        Me.btnNotaCredito.Size = New System.Drawing.Size(100, 53)
        Me.btnNotaCredito.TabIndex = 4
        Me.btnNotaCredito.Text = "Generar Nota de Credito"
        Me.btnNotaCredito.UseVisualStyleBackColor = True
        '
        'btnVerificarExistencia
        '
        Me.btnVerificarExistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerificarExistencia.Location = New System.Drawing.Point(6, 178)
        Me.btnVerificarExistencia.Name = "btnVerificarExistencia"
        Me.btnVerificarExistencia.Size = New System.Drawing.Size(100, 53)
        Me.btnVerificarExistencia.TabIndex = 3
        Me.btnVerificarExistencia.Text = "Verificar Existencia del Ticket"
        Me.btnVerificarExistencia.UseVisualStyleBackColor = True
        '
        'nudNumeroTicket
        '
        Me.nudNumeroTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudNumeroTicket.Location = New System.Drawing.Point(127, 62)
        Me.nudNumeroTicket.Name = "nudNumeroTicket"
        Me.nudNumeroTicket.Size = New System.Drawing.Size(120, 22)
        Me.nudNumeroTicket.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(197, 257)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm1Principal03
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(284, 292)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm1Principal03"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Verificar Ticket"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nudNumeroTicket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnVerificarExistencia As System.Windows.Forms.Button
    Friend WithEvents nudNumeroTicket As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnNotaCredito As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

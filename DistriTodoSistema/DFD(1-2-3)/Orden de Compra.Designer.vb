<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdenCompra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdenCompra))
        Me.btnRechazar = New System.Windows.Forms.Button()
        Me.btnAprobar = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRechazar
        '
        Me.btnRechazar.Location = New System.Drawing.Point(12, 520)
        Me.btnRechazar.Name = "btnRechazar"
        Me.btnRechazar.Size = New System.Drawing.Size(100, 50)
        Me.btnRechazar.TabIndex = 6
        Me.btnRechazar.Text = "RECHAZAR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Presupuesto"
        Me.btnRechazar.UseVisualStyleBackColor = True
        Me.btnRechazar.Visible = False
        '
        'btnAprobar
        '
        Me.btnAprobar.Location = New System.Drawing.Point(311, 520)
        Me.btnAprobar.Name = "btnAprobar"
        Me.btnAprobar.Size = New System.Drawing.Size(100, 50)
        Me.btnAprobar.TabIndex = 5
        Me.btnAprobar.Text = "APROBAR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Presupuesto"
        Me.btnAprobar.UseVisualStyleBackColor = True
        Me.btnAprobar.Visible = False
        '
        'btnMenu
        '
        Me.btnMenu.Location = New System.Drawing.Point(155, 520)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(100, 50)
        Me.btnMenu.TabIndex = 4
        Me.btnMenu.Text = "Volver al " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MENU"
        Me.btnMenu.UseVisualStyleBackColor = True
        Me.btnMenu.Visible = False
        '
        'frmOrdenCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(423, 582)
        Me.Controls.Add(Me.btnRechazar)
        Me.Controls.Add(Me.btnAprobar)
        Me.Controls.Add(Me.btnMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOrdenCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orden de Compra"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRechazar As System.Windows.Forms.Button
    Friend WithEvents btnAprobar As System.Windows.Forms.Button
    Friend WithEvents btnMenu As System.Windows.Forms.Button
End Class

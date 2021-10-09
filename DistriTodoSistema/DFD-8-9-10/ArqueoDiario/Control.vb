Public Class Control

    Private Sub btnVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVer.Click
        MovimientosCaja.cboCaja.Text = ""
        MovimientosCaja.cboCaja.Items.Clear()
        MovimientosCaja.gbCaja.Enabled = False
        MovimientosCaja.btnCaja.Enabled = False
        MovimientosCaja.btnVer.Visible = True
        MovimientosCaja.btnVolver.Enabled = False
        Me.Hide()
        MovimientosCaja.Show()
    End Sub

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        InformeArqueoDiario.btnRegistrar.Enabled = False
        Me.Hide()
        InformeArqueoDiario.Show()
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        Inicio_Cajas.Show()
    End Sub
End Class

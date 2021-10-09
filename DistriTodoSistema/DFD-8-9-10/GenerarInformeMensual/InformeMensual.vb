Public Class InformeMensual
    Dim sql As String

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        Dim respuesta As Integer
        respuesta = MsgBox("¿Esta Seguro de Registar y Guardar?", MsgBoxStyle.YesNo)
        If respuesta = vbYes Then
            Call ultimaAlta("InformeMensual", "NroInfMens", codUltimaAlta)
            lblNroIM.Text = codUltimaAlta + 1
            Dim FActual = Date.Today.Year & "-" & Date.Today.Month & "-" & Date.Today.Day
            sql = "insert into InformeMensual values ('" & codUltimaAlta + 1 & "','" & lblGanancia.Text & "','" & lblPerdida.Text & "','" & lblTotalRecaudado.Text & "','" & FActual & "')"
            Call consulta(sql)
            MsgBox("Registro con Exito", vbInformation)
            lblGanancia.Text = 0
            lblTotalRecaudado.Text = 0
            lblPerdida.Text = 0
            If vbInformation = 64 Then
                dgvDetalle.Rows.Clear()
                Me.Hide()
                Inicio.Show()
            End If
        End If
    End Sub
End Class
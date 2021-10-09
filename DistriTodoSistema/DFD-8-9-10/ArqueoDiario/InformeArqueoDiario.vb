Public Class InformeArqueoDiario
    Dim sql As String
    Dim TFinal As Single
    Dim TInicial As Single
    Dim SaldoObtenido As Single

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        Dim fecha As String
        lblSaldoInicial.Text = 2000
        sql = "select curdate()"
        Call consulta(sql)
        While rs.Read
            lblFechActual.Text = rs(0)
        End While
        fecha = (Control.dtpFecha.Value.Date).ToString("yyyy/MM/dd")
        sql = "select nrocaja,saldoi,saldof from cajero where fecha = '" & fecha & "'"
        Call consulta(sql)
        While rs.Read
            dgvDetalle.Rows.Add(rs(0), rs(1), rs(2))
        End While
        sql = "select sum(saldof), sum(saldoi) from cajero where fecha = '" & fecha & "'"
        Call consulta(sql)
        While rs.Read
            SaldoObtenido = Val(rs(0) - rs(1))
            lblSaldObtenido.Text = SaldoObtenido
        End While
        sql = "select sum(saldoi),sum(saldof) from cajero where fecha = '" & fecha & "'"
        Call consulta(sql)
        While rs.Read
            TInicial = rs(0)
            TFinal = rs(1)
        End While
        btnRegistrar.Enabled = True
        btnGenerar.Visible = False
    End Sub

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        Dim respuesta As Integer
        respuesta = MsgBox("¿Esta Seguro de Registar y Guardar?", MsgBoxStyle.YesNo)
        If respuesta = vbYes Then
            Call ultimaAlta("Informe", "NroInf", codUltimaAlta)
            lblNro.Text = codUltimaAlta + 1
            Dim FActual = Date.Today.Year & "-" & Date.Today.Month & "-" & Date.Today.Day
            sql = "insert into informe values (" & codUltimaAlta + 1 & "," & TInicial & "," & TFinal & "," & SaldoObtenido & ",'" & FActual & "')"
            Call consulta(sql)
            MsgBox("Registro con Exito", vbInformation)
            If vbInformation = 64 Then
                lblSaldoInicial.Text = ""
                dgvDetalle.Rows.Clear()
                lblSaldObtenido.Text = ""
                lblFechActual.Text = ""
                lblNro.Text = ""
                TFinal = 0
                TInicial = 0
                Control.btnGenerar.Enabled = False
                btnGenerar.Visible = True
                Me.Hide()
                Inicio_Cajas.Show()
            End If
        End If
    End Sub
End Class
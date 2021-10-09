Public Class GenerarInformeMensual
    Dim respuesta As Integer
    Dim sql As String
    Dim FechaConvert As String
    Dim Ganancia As Single
    Dim TotalRecaudado As Single
    Dim Perdida As Single

    Private Sub btnGenerarInformeM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarInformeM.Click
        Dim FechaI As String
        Dim FechaF As String
        FechaI = (dtpFI.Value.Date).ToString("yyyy/MM/dd")
        FechaF = (dtpFF.Value.Date).ToString("yyyy/MM/dd")
        respuesta = MsgBox("Fecha de Inicio de Mes '" & FechaI & "'- Fecha Final de Mes'" & FechaF & "'                    ¿CONFIRMAR FECHA?", MsgBoxStyle.YesNo)
        If respuesta = vbYes Then

            sql = "select curdate()"
            Call consulta(Sql)
            While rs.Read
                InformeMensual.lblFechaIM.Text = rs(0)
            End While
            sql = "select sum(recaudado),sum(montof) from informe where fecha between '" & FechaI & "' and '" & FechaF & "' "
            Call consulta(Sql)
            While rs.Read
                Ganancia = rs(0)
                TotalRecaudado = rs(1)
            End While
            InformeMensual.lblGanancia.Text = Ganancia
            InformeMensual.lblTotalRecaudado.Text = TotalRecaudado
            sql = "select sum(cant*precio_uni) from detalle_oc doc,orden_compra oc where doc.codoc=oc.codoc and oc.estado = 'Pagado' and FE between '" & FechaI & "' and '" & FechaF & "'"
            Call consulta(Sql)
            While rs.Read
                Perdida = rs(0)
            End While
            InformeMensual.lblPerdida.Text = Perdida
            sql = "select montoi,montof,recaudado,fecha from informe where fecha between '" & FechaI & "' and '" & FechaF & "'"
            Call consulta(Sql)
            While rs.Read
                FechaConvert = rs(3)
                InformeMensual.dgvDetalle.Rows.Add(rs(0), rs(1), rs(2), FechaConvert)
            End While

            Me.Hide()
            InformeMensual.Show()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Inicio_Cajas.Show()
    End Sub
End Class
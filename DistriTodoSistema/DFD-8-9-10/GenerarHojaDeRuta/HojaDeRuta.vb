Public Class HojaDeRuta
    Dim sql As String

    Public Sub Cambio(ByVal Codigo As Integer)
        sql = "update envio set estado = 1 where coden = '" & Codigo & "'"
        Call consulta(sql)
    End Sub

    Private Sub MostrarClientes()
        Dim FechaEnvio As String
        sql = "select e.CodEn, Nombre, Apellido, Direccion, Telefono, sum(dv.cant), e.Fecha, importef from envio e, cliente c, ticket_factura tf, detalle_ventas dv where e.codc = c.codc and e.nrotf = tf.nrotf and tf.nrotf = dv.nrotf and estado = 0 group by dv.nrotf"
        Call consulta(sql)
        While rs.Read
            FechaEnvio = rs(7)
            dgvHojaRuta.Rows.Add(rs(0), rs(1) + " " + rs(2), rs(3), rs(4), rs(5), rs(6), FechaEnvio)
        End While
        Dim Codigo As Integer
        For Each row As DataGridViewRow In Me.dgvHojaRuta.Rows
            Codigo = row.Cells(0).Value
            Call Cambio(Codigo)
        Next
    End Sub

    Private Sub btnGenerarHojaRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarHojaRuta.Click
        Call MostrarClientes()
        lblNro.Text = Val(lblNro.Text) + 1
        sql = "select curdate()"
        Call consulta(sql)
        While rs.Read
            lblFechActual.Text = rs(0)
        End While
        sql = "Select Nombre,Apellido from empleado where sector = 'Conductor' "
        Call consulta(sql)
        While rs.Read
            cboConductor.Items.Add((rs(0) + " " + rs(1)))
        End While
        btnGenerarHojaRuta.Visible = False
    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        Dim respuesta As Integer
        NomConductor.Text = cboConductor.SelectedItem
        cboConductor.SelectedIndex = -1
        cboConductor.Visible = False
        MsgBox("Debe Imprimir la Hoja de Ruta para el Conductor")
        respuesta = MsgBox("¿Desea Imprimir la Hoja de Ruta?", MsgBoxStyle.YesNo)
        If respuesta = vbYes Then
            '-----------------------------------------------------------------------------------
            'AGREGAR IMPRESION DE HOJA DE RUTA
            '--------------------------------------------------------------------------------------
        End If
        If respuesta = vbYes Then
            MsgBox("Entregar Hoja de Ruta al Conductor")
            btnConfirmar.Visible = False
            Me.Hide()
            Inicio.Show()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Inicio_Envios.Show()
    End Sub
End Class
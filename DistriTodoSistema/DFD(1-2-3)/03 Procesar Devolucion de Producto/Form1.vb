Public Class frm1Principal03

    Private Sub frm1Principal03_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call conexion()
    End Sub

    'Cantidad de veces que se ejecuto "limiteFor"
    Public limiteFor = 1
    Private Sub btnSiguienteOrdenCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerificarExistencia.Click

        Call sql("Select count(*) from ticket_factura where NroTF = " & nudNumeroTicket.Value)
        While rs.Read

            If rs(0) = 1 Then                    'Si el Ticket Factura existe...
                MsgBox("Ticket Factura encontrada", MsgBoxStyle.Information, "Verificar Ticket")
                btnNotaCredito.Enabled = True
            Else                                 'Si no existe ...
                MsgBox("Ticket Factura no existe", MsgBoxStyle.Information, "Verificar Ticket")
                btnNotaCredito.Enabled = False
            End If
        End While
    End Sub

    Private Sub btnNotaCredito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotaCredito.Click

        Dim X = 12, Y = 85
        sqlX("Select nombre, cant, precio from Detalle_Ventas inner join Producto using(codP) where NroTF = " & nudNumeroTicket.Value)
        While rsX.Read
            Call crearLabel(limiteFor, rsX(0), X, Y, frm2GenerarNotaCredito03)
            Call crearNumericUpDown("Cantidad" & limiteFor, X + 370, Y, frm2GenerarNotaCredito03, 0, True, rsX(1))
            Call crearNumericUpDown("MaxCant" & limiteFor, X + 500, Y, frm2GenerarNotaCredito03, rsX(1), False)
            Call crearNumericUpDown("Precio" & limiteFor, X + 630, Y, frm2GenerarNotaCredito03, rsX(2), False)

            Y = Y + 26
            limiteFor = limiteFor + 1
        End While
        'Ajuste del formulario y posicion del btn
        frm2GenerarNotaCredito03.btnSiguienteNotaCredito.Location = New Point(346, Y + 26)
        frm2GenerarNotaCredito03.Size = New Size(807, Y + 130)
        Me.Hide()
        frm2GenerarNotaCredito03.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Inicio_Clientes.Show()
    End Sub
End Class
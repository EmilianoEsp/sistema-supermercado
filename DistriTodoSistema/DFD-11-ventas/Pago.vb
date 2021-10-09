Public Class Pago
    Private Sub rbtTarjeta_CheckedChanged(sender As Object, e As EventArgs) Handles rbtTarjeta.CheckedChanged


        If rbtTarjeta.Checked Then

            rbtEfectivo.Checked = False

            cboxTarjeta.Visible = True
            lblCuotas.Visible = True

            cboxCuotas.Visible = True
            lblTarjeta.Visible = True




            Me.Size = New Size(878, 356)

        End If
    End Sub

    Private Sub rbtEfectivo_CheckedChanged(sender As Object, e As EventArgs) Handles rbtEfectivo.CheckedChanged

        If rbtEfectivo.Checked Then

            Me.Size = New Size(424, 356)
            rbtTarjeta.Checked = False



            cboxTarjeta.Visible = False
            lblCuotas.Visible = False

            cboxCuotas.Visible = False
            lblTarjeta.Visible = False

        End If



    End Sub

    Private Sub Pago_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Size = New Size(424, 356)
        rbtEfectivo.Checked = True
        lblCuotas.Visible = False
        cboxTarjeta.Visible = False

        cboxCuotas.Visible = False
        lblTarjeta.Visible = False

    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click

        Dim tf = consultar("Select max(nrotf) + 1 from ticket_factura")
        Dim iva As String
        Dim tipo As String
        If venta.rbtA.Checked Then

            iva = "responsable inscripto"
            tipo = "A"
        Else

            iva = "consumidor final"
            tipo = "B"
        End If

        Dim iFinal As Double = CDbl(venta.lblTotal.Text)
        Dim cajero As String = datosCaja.txtCajero.Text
        Dim fecha As Date = Format(Date.Now, "yyyy/MM/dd")

        Try
            consultar("insert into ticket_factura values(" & tf & ", '" & tipo & "', '" & iva & "', " & iFinal & ", " & cajero & ", '" & fecha & "')")
            Dim sql As String

            For i As Integer = 0 To venta.tabla2.Rows.Count - 2

                Dim producto = venta.tabla2.Rows(i).Cells(0).Value.ToString
                Dim cant = venta.tabla2.Rows(i).Cells(2).Value.ToString
                Dim precio = venta.tabla2.Rows(i).Cells(3).Value.ToString
                Dim fechaP = Format(Date.Today, "yyyy/MM/dd")
                Dim horaP = consultar("select cortime()")


                sql = "insert into detalle_ventas values(" & tf & ", " & producto & ", " & cant & ", " & precio & ", '" & fechaP & "', '" & horaP & "')"

            Next
        Catch

            MsgBox("Error al cargar la venta")

        End Try

    End Sub
End Class
Public Class venta
    Private Sub venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion()

        rbtB.Checked = True
    End Sub

    Private Sub rbtA_CheckedChanged(sender As Object, e As EventArgs) Handles rbtA.CheckedChanged

        If rbtA.Checked Then

            rbtB.Checked = False



        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        tabla1.DataSource = generarTabla("Select codp, nombre, precio from producto where codp = '" & (txt1.Text) & "'")

        tabla2.Rows.Add(tabla1.Rows(0).Cells(0).Value.ToString, tabla1.Rows(0).Cells(1).Value.ToString, numeric1.Value.ToString, (CInt(tabla1.Rows(0).Cells(2).Value)) * CInt(numeric1.Value.ToString))
        lblTotal.Text = 0
        For i As Integer = 0 To (tabla2.Rows.Count) - 2
            lblTotal.Text = CInt(tabla2.Rows(i).Cells(3).Value.ToString) + CInt(lblTotal.Text)

        Next
    End Sub

    Private Sub rbtB_CheckedChanged(sender As Object, e As EventArgs) Handles rbtB.CheckedChanged


        If rbtB.Checked Then

            rbtA.Checked = False

        End If



    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click

        If rbtA.Checked Then

            Me.Hide()
            facturaA.Show()

        Else

            Me.Hide()
            pago.show()

        End If

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        buscar.Show()

    End Sub
End Class

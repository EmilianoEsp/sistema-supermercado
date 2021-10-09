Public Class PedidoInterno
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If NumericUpDown1.Value.Equals(0) Then

            MsgBox("No puede solicitar como cantidad 0")

        Else

            tablaAux.DataSource = generarTabla("Select codp, nombre from producto where codp = " & (txtCodp.Text))

            Try
                table2.Rows.Add(tablaAux.Rows(0).Cells(0).Value, tablaAux.Rows(0).Cells(1).Value, NumericUpDown1.Value.ToString)
            Catch
                MsgBox("OK")
            End Try
        End If
    End Sub

    Private Sub PedidoInterno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tablaAux.Visible = False
        conexion()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            For i As Integer = 0 To (table2.Rows.Count - 2)
                Dim max As Integer
                If i = 0 Then

                    max = CInt(consultar("select max(codPI) + 1 from pedidointerno"))

                Else

                    max = max + 1

                End If

                consultar("insert into pedidointerno values (" & max & ", " & table2.Rows(i).Cells(0).Value & ", " & table2.Rows(i).Cells(2).Value & " )")

                MsgBox("Productos cargados Correctamente")

                table2.Rows.Clear()
            Next
        Catch
            MsgBox("Error al ejecutar la accion")

        End Try


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Inicio_Productos.Show()
    End Sub
End Class
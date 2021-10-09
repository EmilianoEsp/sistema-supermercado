Public Class frm2DatosOrdenCompra01

    Private Sub btnSiguienteProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguienteProveedor.Click
        'VERIFICA QUE TODOS LOS CAMPOS ESTEN CON DATOS
        Dim siguiente = True
        For Each nud As NumericUpDown In Me.Controls.OfType(Of NumericUpDown)()
            If nud.Value = 0 Then
                'SIGUIENTE ESTA EN COMENTARIO PARA REALIZAR PRUEBAS
                siguiente = False
            End If
        Next
        'COMPRUEBA SI SE PUEDE IR AL SIGUIENTE FRM
        If siguiente Then
            Me.Hide()
            frm3Proveedores01.Show()
        Else
            MsgBox("Complete todos los datos", vbCritical, "Generar Orden de Compra - Stock de Productos")
        End If
    End Sub
End Class
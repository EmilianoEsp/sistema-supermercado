Public Class frmOrdenCompra

    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        Me.Hide()
    End Sub

    'Variables que ayudaran a modificar las tas tablas
    Dim codOrdenCompra As String
    Private Sub btnRechazar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRechazar.Click
        'CONFIRMAR RECHAZO DE ORDEN DE COMPRA
        Dim x = MsgBox("Confirmar Rechazo de Orden de compra", MsgBoxStyle.YesNo, "Confirmar RECHAZAR Presupuesto")
        If x = MsgBoxResult.Yes Then
            'Se Rechaza Orden de Compra
            Call buscarLbl(Me, "lblOrdenCompra", codOrdenCompra)
            Call sql("update Orden_Compra set estado = 'Rechazado' where codOC = " & codOrdenCompra)
            MsgBox("Se rechazo la Orden de Compra Nro: " & codOrdenCompra, MsgBoxStyle.Information, "RECHAZAR Presupuesto")
            'Desactiva el boton Aprobar ---------------------------------------------
            btnAprobar.Enabled = False
        Else
            'Se cancela Rechazar Orden de Compra
            MsgBox("Operacion Cancelada", MsgBoxStyle.Information, "Orden de Compra")
        End If

    End Sub

    'Variables que ayudaran a modificar las tas tablas
    Dim nombreProducto, stock As String
    Private Sub btnAprobar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAprobar.Click

        'Confirma Aprobacion
        Dim x = MsgBox("Confirme Aprobar de Orden de compra", vbYesNo, "Confirmar APROBAR Presupuesto")
        If x = MsgBoxResult.Yes Then
            'Se Aprueba Orden de Compra
            Call buscarLbl(Me, "lblOrdenCompra", codOrdenCompra)
            Call sql("update Orden_Compra set estado = 'Aprobado' where codOC = " & codOrdenCompra)
            Call sql("select count(*) from Detalle_oc where codOC = " & codOrdenCompra & "")
            While rs.Read
                For i = 1 To rs(0)
                    Call buscarLbl(Me, "lblProducto" & i, nombreProducto)
                    Call buscarLbl(Me, "lblCantidad" & i, stock)

                    Call sqlX("update Producto set stock = stock + " & stock & " where nombre =  '" & nombreProducto & "'")
                Next
            End While

            MsgBox("Se Registro la Orden de Compra Nro: " & codOrdenCompra, MsgBoxStyle.Information, "APROBAR Presupuesto")
            'Desactiva el boton Rechazar ---------------------------------------------
            btnRechazar.Enabled = False
        Else
            'Se Cancela Operacion
            MsgBox("Operacion Cancelada", MsgBoxStyle.Information, "Orden de Compra")
        End If

    End Sub

    Private Sub frmOrdenCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnAprobar.Enabled = True
        btnRechazar.Enabled = True
    End Sub
End Class
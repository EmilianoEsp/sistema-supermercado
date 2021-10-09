Public Class frm2GenerarNotaCredito03

    
    Private Sub btnSiguienteNotaCredito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguienteNotaCredito.Click
        Dim montoTotal = 0
        Dim x = MsgBox("Confirme Generar Nota de Credito", MsgBoxStyle.YesNo, "Generar Nota de Credito")
        If x = MsgBoxResult.Yes Then
            Dim cant = 0, precio = 0
            For i = 1 To frm1Principal03.limiteFor - 1
                Call buscarNud(Me, "nudCantidad" & i, cant)
                Call buscarNud(Me, "nudPrecio" & i, precio)
                montoTotal = montoTotal + (cant * precio)
            Next
            Dim fechaEmision = Date.Today.Year & "-" & Date.Today.Month & "-" & Date.Today.Day
            Dim fechaVenc = Date.Today.Year & "-" & Date.Today.Month & "-" & Date.Today.Day + 2
            Call obtenerUltimaAlta("CodN", "Nota", CodPK)
            Call sql("insert into Nota_credito values (" & CodPK + 1 & "," & frm1Principal03.nudNumeroTicket.Value & "," & montoTotal & ",'" & fechaEmision & "','" & fechaVenc & "')")

            'Solo cuando se confirme, generar nota credito ira al frm de nota de credito
            Call completarNotaCredito(CodPK + 1)
            Me.Hide()
            frmNotaCredito.Show()

            MsgBox("Se genero la Nota de Credito Nro: " & CodPK + 1, MsgBoxStyle.Information, "Generar Nota de Credito")
        Else
            MsgBox("Operacion Cancelada", MsgBoxStyle.Information, "Generar Nota de Credito")
        End If
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("No puede super el limite maximo de 'Und. Max. a Devolver'", vbInformation)
    End Sub
End Class
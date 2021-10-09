Public Class frm3Proveedores01

    Private Sub frm3Proveedores01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call sql("Select nombre from proveedor")
        While rs.Read
            cmbProveedores.Items.Add(rs(0))
        End While
    End Sub

    Private Sub cmbProveedores_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProveedores.SelectedIndexChanged
        Call sql("Select codProv,lugar,Cuit,tel from proveedor where nombre = '" & cmbProveedores.Text & "'")
        While rs.Read
            lblNroProveedor.Text = rs(0)
            lblDireccion.Text = rs(1)
            lblCUIT.Text = rs(2)
            lblTelefono.Text = rs(3)
        End While
    End Sub

    Private Sub btnSiguienteOrdenCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguienteOrdenCompra.Click
        Dim x As Integer
        If cmbProveedores.Text = "(Proveedores)" Then
            MsgBox("Seleccione un Proveedor para continuar", MsgBoxStyle.Information, "Generar Orden de Compra - Seleccionar Proveedor")
        Else
            x = MsgBox("Registrar Orden de Compra", MsgBoxStyle.YesNo, "Confirmar Registro de Orden de Compra")
        End If

        If x = MsgBoxResult.Yes Then 'SI EL USUARIO CONFIRMA CON UN SI / YES ...
            'AL LLAMAR "obtenerUltimaAlta", LA VARIEBLE "CodPK" ADQUIERE UN VALOR QUE CONSERVARA ASTA QUE SE LE ASIGNE OTRO VALOR
            Call obtenerUltimaAlta("CodOC", "Orden_Compra", CodPK)
            Dim fecha = Date.Today.Year & "-" & Date.Today.Month & "-" & Date.Today.Day
            'SE DA DE ALTA LOS DATOS RECOPILADOS EN LA TABLA ORDENCOMPRA
            Call sql("insert into Orden_Compra values (" & CodPK + 1 & ",'" & fecha & "'," & lblNroProveedor.Text & ",null)")

            Dim cantidad, precio As Integer                    'SE GENERAN 2 VARIABLE QUE ALMACENARAN EL CONTENIDO DE LOS NUMERICUPDOWNS
            For i = 0 To frm1Principal01.limite Step 1         'SE USA LA VARIABLE "limite" DEL FRM PRINCIPAL 01
                Call sql("Select codp from producto where nombre = '" & frm1Principal01.lstProductosPP.Items(i) & "'")
                While rs.Read
                    Call buscarNud(frm2DatosOrdenCompra01, "nud" & i & "Cantidad", cantidad)
                    Call buscarNud(frm2DatosOrdenCompra01, "nud" & i & "Precio", precio)
                    'SE DA DE ALTA LOS DATOS RECOPILADOS EN LA TABLA DETALLE_ORDEN_COMPRA
                    Call sqlX("insert into Detalle_oc values (" & CodPK + 1 & "," & rs(0) & "," & cantidad & "," & precio & ")")
                End While
            Next
            MsgBox("Se a registrado la Orden de Compra", MsgBoxStyle.Information, "Generar Orden de Compra - Seleccionar Proveedor")  'INFORMA QUE LAS ALTAS HAN CONCLUIDO

            Call completarOrdenCompra(CodPK + 1)                         'SE COMPLETA EL DOCUMENTO DE ORDEN DE COMPRA

            frmOrdenCompra.btnMenu.Visible = False : frmOrdenCompra.btnAprobar.Visible = False : frmOrdenCompra.btnRechazar.Visible = False
            frmOrdenCompra.btnMenu.Visible = True
            Me.Hide()
            frmOrdenCompra.Show()
        End If
    End Sub

    Private Sub btnRegresarPagAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegresarPagAnterior.Click
        Me.Hide()
        frm2DatosOrdenCompra01.Show()
    End Sub
End Class
Public Class frm1Principal02

    Private Sub frm1Principal02_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call conexion()
        Call grilla("Lista Orden de Compra", "Select codOC 'Nro de Orden',fechaE 'Fecha de Emision',nombre 'Proveedor' from proveedor inner join Orden_Compra Using (codProv) where estado is null")
        Me.dtgListaOrdenCompra.DataSource = ds.Tables("Lista Orden de Compra")
        dtgListaOrdenCompra.Font = New Font(dtgListaOrdenCompra.Font.Name, 10)                'Cambia el tamaño de la fuente
        dtgListaOrdenCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells    'Ajusta las columnas segun el contenido
    End Sub

    Dim codOrdenCompra As Integer
    Private Sub dtgListaOrdenCompra_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgListaOrdenCompra.CellContentClick
        codOrdenCompra = dtgListaOrdenCompra.Rows(e.RowIndex).Cells(0).Value
        lblNroOrdenCompra.Text = "Nro de Orden de Compra: " & codOrdenCompra
    End Sub

    Private Sub btnIrOrdenCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIrOrdenCompra.Click
        Call completarOrdenCompra(codOrdenCompra)
        frmOrdenCompra.btnMenu.Visible = False : frmOrdenCompra.btnAprobar.Visible = False : frmOrdenCompra.btnRechazar.Visible = False
        frmOrdenCompra.btnAprobar.Visible = True : frmOrdenCompra.btnRechazar.Visible = True : frmOrdenCompra.btnMenu.Visible = True

        Me.Hide()
        frmOrdenCompra.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Inicio_Proveedores.Show()
    End Sub
End Class
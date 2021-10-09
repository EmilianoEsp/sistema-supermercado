Public Class frm1Principal01

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'SE GENERA LA CONXION CON LA BASE DE DATOS
        Call conexion()

    End Sub

    Private Sub rdbOpc1ConOrden_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbOpc1ConOrden.CheckedChanged
        '-------------------------------- AGREGA ITEMS (PORODUCTOS CON ORDEN DE COMPRA) EN LA LISTBOX 
        If rdbOpc1ConOrden.Checked = True Then

            '--------------------------- BLANQUEAR LISTBOX
            lstProductosPP.Items.Clear()
            '--------------------------- AGREGA ITEMS EN LA LISTBOX
            Call sql("Select nombre from Producto where stock <= PP")
            While rs.Read
                lstProductosPP.Items.Add(rs(0))
            End While
        End If
        '---------------------------------------------------------------------'
        Call revelarButton()

    End Sub

    Private Sub rdbOpc2SinOrdCompra_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbOpc2SinOrdCompra.CheckedChanged

        '-------------------------------- AGREGA ITEMS (PORODUCTOS SIN ORDEN DE COMPRA) EN LA LISTBOX
        If rdbOpc2SinOrdCompra.Checked = True Then

            '--------------------------- BLANQUEAR LISTBOX
            lstProductosPP.Items.Clear()
            '--------------------------- AGREGA ITEMS EN LA LISTBOX
            Call sql("Select nombre from Producto where stock <= PP and codp not in (select codp from Detalle_oc  inner join Orden_Compra using(codOC) where estado Is null group by codP)")
            While rs.Read
                lstProductosPP.Items.Add(rs(0))
            End While
        End If
        '---------------------------------------------------------------------'
        Call revelarButton()

    End Sub
    '-------------------------------- VARIABLE CON USO EN OTROS FRM -------------------------------------'
    Public limite As Integer
    Private Sub btnFrmCompletarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrmCompletarDatos.Click
        'Coordenada X - Y del formulario
        Dim x = 25, y = 100
        'Se usa "limite"
        If lstProductosPP.Items.Count - 1 <= 20 - 1 Then : limite = lstProductosPP.Items.Count - 1 : Else : limite = 20 - 1 : MsgBox("Por Orden de Compra, solo se permiten 20 productos como maximo", vbInformation) : End If

        For i = 0 To limite Step 1

            Call crearLabel(i, lstProductosPP.Items(i).ToString, x, y, frm2DatosOrdenCompra01)
            Call crearNumericUpDown(i & "Cantidad", x + 305, y, frm2DatosOrdenCompra01)
            Call crearNumericUpDown(i & "Precio", x + 495, y, frm2DatosOrdenCompra01)

            y = y + 30
        Next

        frm2DatosOrdenCompra01.btnSiguienteProveedor.Location = New Point(290, y + 26)
        frm2DatosOrdenCompra01.Size = New Size(700, y + 130)

        Me.Hide()
        frm2DatosOrdenCompra01.Show()
    End Sub

    '-------------------------------- REVELAR UN BUTTON SOLO CUANDO HAY PRODUCTOS EN PP
    Private Sub revelarButton()

        '--------------------------- En caso de no haber Productos en PP
        If lstProductosPP.Items.Count = 0 Then
            MsgBox("No hay productos en Punto de Pedido (PP)", vbInformation, "Productos en Punto de Pedido")
            btnFrmCompletarDatos.Visible = False
        Else
            '--------------------------- Si hay producto en PP se podra ir al siguiente frm
            btnFrmCompletarDatos.Visible = True
        End If

    End Sub


    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        Me.Hide()
        Inicio_Proveedores.Show()
    End Sub
End Class

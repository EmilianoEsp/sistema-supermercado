Imports System.Data.Odbc
Public Class ControlarProductos

    Private Sub ControlarProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexion()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql As String
        sql = "UPDATE Orden_Compra SET Estado = 'Pagado' WHERE CodOC = '" & Val(TextBox1.Text) & " '  "
        Try
            cmd = New OdbcCommand(Sql, cnn)
            cmd.CommandType = CommandType.Text
            rs = cmd.ExecuteReader()
            MsgBox("Compra aceptada con exito", , "Compra")
            cmd.Dispose()
            Button1.Enabled = False
            Button2.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim sql As String
        sql = "UPDATE Orden_Compra SET Estado = 'Rechazado' WHERE CodOC = '" & Val(TextBox1.Text) & " ' "
        Try
            cmd = New OdbcCommand(sql, cnn)
            cmd.CommandType = CommandType.Text
            rs = cmd.ExecuteReader()
            MsgBox("Compra rechazada con exito", , "Compra")
            cmd.Dispose()
            Button1.Enabled = False
            Button2.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MsgBox("Debe ingresar un número de orden de compra.", , "Error")
        Else
            Try
                Dim consulta As String
                consulta = "SELECT DOC.CodOC as Orden, Prov.Nombre, Prod.Nombre as Producto, Precio, Stock, PP, FechaE, Estado FROM Detalle_OC as DOC, Proveedor as Prov, Producto as Prod, Orden_Compra as OC WHERE DOC.CodOC = OC.CodOC AND DOC.CodP = Prod.CodP AND OC.CodProv = Prov.CodProv AND DOC.CodOC = '" & Val(TextBox1.Text) & " ' "
                datos = New DataSet
                datos.Tables.Add("Orden_de_compra")
                adaptador = New OdbcDataAdapter(consulta, cnn)
                adaptador.Fill(datos.Tables("Orden_de_compra"))
                Me.DataGridView1.DataSource = datos.Tables("Orden_de_compra")
                Button1.Enabled = True
                Button2.Enabled = True
            Catch ex As Exception
                MsgBox("La orden de compra ingresada no existe o es incorrecta.", , "Error")
            End Try
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Inicio_Proveedores.Show()
    End Sub
End Class

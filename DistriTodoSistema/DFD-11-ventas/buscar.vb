Public Class buscar

    Dim codp As Integer
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        Dim sql = "Select codp as codigo, nombre, precio from producto where nombre LIKE '%" & TextBox1.Text & "%' OR nombre LIKE '" & TextBox1.Text & "%' or nombre LIKE '%" & TextBox1.Text & "'"

        'MsgBox(sql)
        table1.DataSource = generarTabla(sql)

    End Sub

    Private Sub buscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        table1.DataSource = generarTabla("Select codp as codigo, nombre, precio from producto")

    End Sub

    Private Sub table1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles table1.CellContentClick

        codp = CInt(table1.Rows(e.RowIndex).Cells(0).Value)

        venta.txt1.Text = codp

        Me.Dispose()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Inicio_Clientes.Show()
    End Sub
End Class
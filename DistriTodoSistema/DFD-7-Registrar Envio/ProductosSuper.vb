Imports System.Data.Odbc
Public Class ProductosSuper
    Public ListaProductos As New List(Of Producto)
    Dim stock As Integer
    Dim producto As String
    Dim precio As Single
    Dim IdBase As Integer

    Private Sub ProductosSuper_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MostrarProductos()
    End Sub
    Private Sub MostrarProductos()
        Dim sql As String
        Dim ds As New DataSet
        Dim adp As OdbcDataAdapter

        sql = "Select CodP,nombre,precio,stock from Producto"
        ds.Tables.Add("Productos")
        adp = New OdbcDataAdapter(sql, cnn)
        adp.Fill(ds.Tables("Productos"))
        Me.DataGridView1.DataSource = ds.Tables("Productos")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        producto = DataGridView1.CurrentRow.Cells("nombre").Value.ToString
        precio = DataGridView1.CurrentRow.Cells("precio").Value.ToString
        IdBase = DataGridView1.CurrentRow.Cells("CodP").Value.ToString
        stock = NumericUpDown1.Value

        ListaProductos.Add(New Producto(producto, stock, precio, IdBase))

        Productos.Items.Add(producto & "(" & stock & ")")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListaProductos.RemoveAt(Productos.SelectedIndex)
        Productos.Items.RemoveAt(Productos.SelectedIndex)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MsgBox("La selección de productos se realizó con éxito")
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        NumericUpDown1.Maximum = DataGridView1.CurrentRow.Cells("stock").Value
    End Sub
End Class
Public Class Cajas_ABM

    Dim Obj As New ABM

    Private Sub btnConexion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConexion.Click
        Obj.conexion()
    End Sub

    Private Sub Cajas_ABM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLeer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeer.Click
        Dim Sql As String = "SELECT * FROM Caja"
        Obj.consulta(DataGridView1, Sql)
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim Sql As String = "INSERT INTO Caja (NroCaja,Lugar) SELECT " & TextBox1.Text & ", '" & TextBox2.Text & "' "
        Obj.operaciones(DataGridView1, Sql)
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Dim Sql As String = "UPDATE Caja Set Lugar='" & TextBox2.Text & "' WHERE NroCaja=" & TextBox1.Text & ""
        Obj.operaciones(DataGridView1, Sql)
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim Sql As String = "DELETE FROM Caja WHERE NroCaja=" & TextBox1.Text & ""
        Obj.operaciones(DataGridView1, Sql)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Inicio_ABM.Show()
    End Sub

End Class
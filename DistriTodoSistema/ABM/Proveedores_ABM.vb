Imports System.Data.Odbc

Public Class Proveedores_ABM
    Dim Obj As New ABM
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        Inicio_ABM.Show()
    End Sub


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Inicio_ABM.Show()
    End Sub

    Private Sub btnConexion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConexion.Click
        Obj.conexion()
    End Sub

    Private Sub btnLeer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeer.Click
        Dim Sql As String = "SELECT * FROM Proveedor"
        Obj.consulta(DataGridView1, Sql)
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim Sql As String = "INSERT INTO Proveedor (CodProv,Nombre,Lugar,CUIT,Tel,Interes) SELECT " & TextBox1.Text & ", '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "', " & TextBox5.Text & ", " & TextBox6.Text & " "
        Obj.operaciones(DataGridView1, Sql)
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Dim Sql As String = "UPDATE Proveedor Set Nombre='" & TextBox2.Text & "', Lugar='" & TextBox3.Text & "', Cuit='" & TextBox4.Text & "', Tel=" & TextBox5.Text & ", Interes=" & TextBox6.Text & " WHERE CodProv=" & TextBox1.Text & ""
        Obj.operaciones(DataGridView1, Sql)
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim Sql As String = "DELETE FROM Proveedor WHERE CodProv=" & TextBox1.Text & ""
        Obj.operaciones(DataGridView1, Sql)
    End Sub
End Class
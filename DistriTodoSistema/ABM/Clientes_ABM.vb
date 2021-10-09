Imports System.Data.Odbc

Public Class Clientes_ABM
    Dim Obj As New ABM
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Inicio_ABM.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub


    Private Sub btnConexion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConexion.Click
        Obj.conexion()
    End Sub

    Private Sub btnLeer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeer.Click
        Dim Sql As String = "SELECT * FROM Cliente"
        Obj.consulta(DataGridView1, Sql)
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim Sql As String = "INSERT INTO Cliente (CodC,Nombre,Apellido,DNI,Telefono,Direccion,Piso,Departamento) SELECT " & TextBox1.Text & ", '" & TextBox2.Text & "', '" & TextBox3.Text & "', " & TextBox4.Text & ", " & TextBox5.Text & ", '" & TextBox6.Text & "', " & TextBox7.Text & ", " & TextBox8.Text & " "
        Obj.operaciones(DataGridView1, Sql)
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Dim Sql As String = "UPDATE Cliente Set Nombre='" & TextBox2.Text & "', Apellido='" & TextBox3.Text & "', DNI=" & TextBox4.Text & ", Telefono=" & TextBox5.Text & ", Direccion='" & TextBox6.Text & "', Piso=" & TextBox7.Text & ", Departamento=" & TextBox8.Text & " WHERE CodC=" & TextBox1.Text & ""
        Obj.operaciones(DataGridView1, Sql)
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim Sql As String = "DELETE FROM Cliente WHERE CodC=" & TextBox1.Text & ""
        Obj.operaciones(DataGridView1, Sql)
    End Sub
End Class
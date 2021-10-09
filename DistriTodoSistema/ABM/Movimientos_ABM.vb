Imports System.Data.Odbc

Public Class Movimientos_ABM
    Dim Obj As New ABM
    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Inicio_ABM.Show()
    End Sub


    Private Sub btnConexion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConexion.Click
        Obj.conexion()
    End Sub

    Private Sub btnLeer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeer.Click
        Dim Sql As String = "SELECT * FROM Movimientos"
        Obj.consulta(DataGridView1, Sql)
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim Sql As String = "INSERT INTO Movimientos (NroM,NroCaja,MontoInicial,Entrada,Salida,Total,Fecha) SELECT " & TextBox1.Text & ", " & TextBox2.Text & ", " & TextBox3.Text & ", " & TextBox4.Text & ", " & TextBox5.Text & ", " & TextBox6.Text & ", '" & TextBox7.Text & "' "
        Obj.operaciones(DataGridView1, Sql)
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Dim Sql As String = "UPDATE Movimientos Set NroCaja=" & TextBox2.Text & ", MontoInicial=" & TextBox3.Text & ", Entrada=" & TextBox4.Text & ", Salida=" & TextBox5.Text & ", Total=" & TextBox6.Text & ", Fecha='" & TextBox7.Text & "' WHERE NroM=" & TextBox1.Text & " "
        Obj.operaciones(DataGridView1, Sql)
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim Sql As String = "DELETE FROM Movimientos WHERE NroM=" & TextBox1.Text & " "
        Obj.operaciones(DataGridView1, Sql)
    End Sub
End Class
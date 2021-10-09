Imports System.Data.Odbc

Public Class Cajeros_ABM
    Dim Obj As New ABM

    

    Private Sub btnConexion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConexion.Click
        Obj.conexion()
    End Sub

    Private Sub btnLeer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeer.Click
        Dim Sql As String = "SELECT * FROM Cajero"
        Obj.consulta(DataGridView1, Sql)
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim Sql As String = "INSERT INTO Cajero (NroCaja,CodE,Fecha,HorarioI,HorarioF,SaldoI,SaldoF,Faltante,Ganancia) SELECT " & TextBox1.Text & ", " & TextBox2.Text & ", '" & TextBox3.Text & "', '" & TextBox4.Text & "', '" & TextBox5.Text & "', " & TextBox6.Text & ", " & TextBox7.Text & ", " & TextBox8.Text & ", " & TextBox9.Text & " "
        Obj.operaciones(DataGridView1, Sql)
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Dim Sql As String = "UPDATE Cajero Set Fecha='" & TextBox3.Text & "', HorarioI='" & TextBox4.Text & "', HorarioF='" & TextBox5.Text & "', SaldoI=" & TextBox6.Text & ", SaldoF=" & TextBox7.Text & ", Faltante=" & TextBox8.Text & ", Ganancia=" & TextBox9.Text & " WHERE NroCaja=" & TextBox1.Text & " AND CodE=" & TextBox2.Text & " "
        Obj.operaciones(DataGridView1, Sql)
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim Sql As String = "DELETE FROM Cajero WHERE NroCaja=" & TextBox1.Text & " AND CodE=" & TextBox2.Text & " "
        Obj.operaciones(DataGridView1, Sql)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Inicio_ABM.Show()
    End Sub
End Class
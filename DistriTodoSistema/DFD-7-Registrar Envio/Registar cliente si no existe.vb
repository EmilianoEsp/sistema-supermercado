Imports System.Data.Odbc
Public Class Form3
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtDNI.Text = Registrarclienteenenvio.TextBox1.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim consulta As String
        consulta = "Insert into Cliente values('' ,'" & TxtNombre.Text & "', '" & TxtApellido.Text & "', '" & TxtDNI.Text & "', '" & TxtTelefono.Text & "', '" & TxtDireccion.Text & "', " & TxtPiso.Text & ", " & TxtDepartamento.Text & ")"
        MsgBox("El nuevo cliente fue ingresado con éxito")
        Me.Hide()
        Call InsertarCliente(consulta)
        Call Registrarclienteenenvio.MostrarClientes()

    End Sub
    Private Sub InsertarCliente(ByVal consulta)
        cmd = New OdbcCommand(consulta, cnn)
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
End Class
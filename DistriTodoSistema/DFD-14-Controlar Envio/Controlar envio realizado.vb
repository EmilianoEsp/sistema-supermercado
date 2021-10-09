Imports System.Data.Odbc
Public Class Form2
    Dim consulta As String
    Dim codEnvio As Integer = 0
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        codEnvio = Elegir_envio_a_controlar.envioSeleccion
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If RadioButton1.Checked Then

            consulta = "Update Envio Set Estado = 1 Where CodEn = " & codEnvio

            cmd = New OdbcCommand(consulta, cnn)
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            MsgBox("El cliente se encontraba en la propiedad. Se registró como envío completado")

        ElseIf RadioButton2.Checked Then

            If IsDate(TextBox1.Text) = False Then
                MsgBox("La fecha ingresada es incorrecta. Ingrese una nueva en formato dd/mm/yyyy")
            Else

                Dim nuevaFecha As Date = TextBox1.Text

                consulta = "Update Envio Set Fecha ='" & Format(CDate(TextBox1.Text), "yyyy/MM/dd") & "',Estado = 0 Where CodEn = " & codEnvio

                cmd = New OdbcCommand(consulta, cnn)
                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                MsgBox("La fecha nueva de envio se registro correctamente")
            End If
        Else
            MsgBox("Seleccione el estado del envio")
        End If
    End Sub
End Class
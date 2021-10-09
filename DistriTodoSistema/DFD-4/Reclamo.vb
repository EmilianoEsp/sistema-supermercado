Imports System.Data.Odbc
Public Class Reclamo

    Private Sub Reclamov_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If cantReclamos = 1 Then
            Label11.Text = cantReclamos
        End If

        TextBox1.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RichTextBox1.Text = "" Then
            MsgBox("Debe ingresar el reclamo.", , "Error")
        ElseIf TextBox1.Text = "" Then
            MsgBox("Debe ingresar la fecha.", , "Error")
        Else
            Try

                Dim consulta As String
                consulta = "INSERT INTO Reclamo(CodRec,Detalle,FE,Estado) VALUES ('','" & RichTextBox1.Text & " ', '" & TextBox1.Text & " ', 0)"
                cmd = New OdbcCommand(consulta, cnn)
                cmd.CommandType = CommandType.Text
                rs = cmd.ExecuteReader()
                cmd.Dispose()
                MsgBox("Reclamo enviado exitosamente", , "Hoja de Reclamo")
                cantReclamos += 1
                Label11.Text = cantReclamos
                Me.Hide()
                VerificarInquietud.Show()
            Catch ex As Exception
                MsgBox(ex.Message, , "Error")
            End Try
        End If
    End Sub
End Class
Imports System.Data.Odbc
Public Class Sugerencia

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If cantSugerencias = 1 Then
            Label4.Text = cantSugerencias
        End If
        RichTextBox2.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Debe ingresar la fecha de la sugerencia.", , "Error")
        ElseIf RichTextBox2.Text = "" Then
            MsgBox("Debe ingresar la sugerencia.", , "Error")
        Else
            Dim consulta As String
            consulta = "INSERT INTO Sugerencia(CodSug,Detalle,FE) VALUES ('', '" & RichTextBox2.Text & " ', '" & TextBox1.Text & " ')"
            Try
                cmd = New OdbcCommand(consulta, cnn)
                cmd.CommandType = CommandType.Text
                rs = cmd.ExecuteReader()
                cmd.Dispose()
                MsgBox("Sugerencia enviada exitosamente", , "Hoja de Sugerencia")
                cantSugerencias += 1
                Label4.Text = cantSugerencias
                Me.Hide()
                VerificarInquietud.Show()
            Catch ex As Exception
                MsgBox(ex.Message, , "Error")
            End Try
        End If
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
End Class
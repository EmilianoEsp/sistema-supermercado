Public Class VerificarInquietud

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexion()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If RadioButton1.Checked = True Then
            MsgBox("Ha seleccionado reclamos", , "Reclamos")
            Me.Hide()
            Reclamo.Show()
        ElseIf RadioButton2.Checked = True Then
            MsgBox("Ha seleccionado sugerencias", , "Sugerencias")
            Me.Hide()
            Sugerencia.Show()
        Else
            MsgBox("Debe seleccionar una opción", , "Inquietud")
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Inicio_Clientes.Show()
    End Sub
End Class

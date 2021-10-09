Public Class Inicio_Cajas

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
        Inicio.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Hide()
        Control.Show()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Me.Hide()
        GenerarInformeMensual.Show()
    End Sub

    Private Sub Inicio_Cajas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If StrComp(tipo, "root") = 0 Or StrComp(tipo, "ROOT") = 0 Then
            Label1.Text = "Administrador"
        End If

        If StrComp(tipo, "empleado") = 0 Or StrComp(tipo, "EMPLEADO") = 0 Then
            Label1.Text = "Empleado"
        End If
    End Sub
End Class
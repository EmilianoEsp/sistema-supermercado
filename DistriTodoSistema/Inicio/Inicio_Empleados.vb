Public Class Inicio_Empleados

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
        Inicio.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        ContratarEmpleado.Show()
    End Sub

    Private Sub Inicio_Empleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If StrComp(tipo, "root") = 0 Or StrComp(tipo, "ROOT") = 0 Then
            Label1.Text = "Administrador"
        End If

        If StrComp(tipo, "empleado") = 0 Or StrComp(tipo, "EMPLEADO") = 0 Then
            Label1.Text = "Empleado"
        End If
    End Sub
End Class
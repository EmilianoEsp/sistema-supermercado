Public Class Inicio_Envios

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
        Inicio.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Elegir_envio_a_controlar.Show()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Me.Hide()
        Registrarclienteenenvio.Show()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Me.Hide()
        HojaDeRuta.Show()
    End Sub

    Private Sub Inicio_Envios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If StrComp(tipo, "root") = 0 Or StrComp(tipo, "ROOT") = 0 Then
            Label1.Text = "Administrador"
        End If

        If StrComp(tipo, "empleado") = 0 Or StrComp(tipo, "EMPLEADO") = 0 Then
            Label1.Text = "Empleado"
        End If
    End Sub
End Class
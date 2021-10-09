Public Class Inicio_Clientes

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
        Inicio.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        VerificarInquietud.Show()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Me.Hide()
        buscar.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Hide()
        frm1Principal03.Show()
    End Sub

    Private Sub Inicio_Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If StrComp(tipo, "root") = 0 Or StrComp(tipo, "ROOT") = 0 Then
            Label1.Text = "Administrador"
        End If

        If StrComp(tipo, "empleado") = 0 Or StrComp(tipo, "EMPLEADO") = 0 Then
            Label1.Text = "Empleado"
        End If
    End Sub
End Class
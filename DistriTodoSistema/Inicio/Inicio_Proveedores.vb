Public Class Inicio_Proveedores

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
        Inicio.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        frm1Principal01.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Hide()
        frm1Principal02.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        ControlarProductos.Show()
    End Sub

    Private Sub Inicio_Proveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If StrComp(tipo, "root") = 0 Or StrComp(tipo, "ROOT") = 0 Then
            Label1.Text = "Administrador"
        End If

        If StrComp(tipo, "empleado") = 0 Or StrComp(tipo, "EMPLEADO") = 0 Then
            Label1.Text = "Empleado"
        End If
    End Sub
End Class
Public Class Legajo

    Private Sub Legajo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label10.Text = nom
        Label11.Text = puesto
        Label12.Text = fecha
        Label15.Text = telefono
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        ContratarEmpleado.Show()
    End Sub
End Class
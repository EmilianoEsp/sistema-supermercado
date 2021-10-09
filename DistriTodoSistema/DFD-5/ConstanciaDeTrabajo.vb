Public Class ConstanciaDeTrabajo
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label4.Text = nom
        Label10.Text = fecha
        Label11.Text = puesto
        Label12.Text = horario
        Label14.Text = descanso
        Label13.Text = salario
        Label15.Text = ""
        Label16.Text = "11-4584-3483"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        ContratarEmpleado.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Legajo.Show()
    End Sub
End Class
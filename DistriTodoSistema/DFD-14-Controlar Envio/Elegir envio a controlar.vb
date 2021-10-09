Imports System.Data.Odbc

Public Class Elegir_envio_a_controlar
    Public envioSeleccion As Integer

    Private Sub Elegir_envio_a_controlar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Conexion()
        Call MostrarEnvios()
    End Sub
    Private Sub MostrarEnvios()
        Dim sql As String
        Dim ds As New DataSet
        Dim adp As OdbcDataAdapter

        sql = "Select CodEn,CodC,NroTF,Fecha from Envio"
        ds.Tables.Add("Envios")
        adp = New OdbcDataAdapter(sql, cnn)
        adp.Fill(ds.Tables("Envios"))
        Me.DataGridView1.DataSource = ds.Tables("Envios")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        envioSeleccion = DataGridView1.CurrentRow.Cells("CodEn").Value
        Form2.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Inicio_Envios.Show()
    End Sub
End Class
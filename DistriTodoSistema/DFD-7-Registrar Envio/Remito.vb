Imports System.Data.Odbc
Public Class Remito

    Private Sub Remito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarDatos()
    End Sub
    Private Sub CargarDatos()
        Dim consulta As String
        consulta = ("Select CodRemito,NroTF,CodC,Fecha from Remito where nroTF = " & Registrarclienteenenvio.nroTicket)

        Dim rsRemito As OdbcDataReader

        cmd = New OdbcCommand(consulta, cnn)
        cmd.CommandType = CommandType.Text

        rsRemito = cmd.ExecuteReader()

        If rsRemito.Read() Then
            Label1.Text = rsRemito(0)
            Label2.Text = rsRemito(1)
            Label3.Text = rsRemito(3)

            consulta = ("Select Nombre,DNI,Direccion from Cliente Where CodC =" & rsRemito(2))
            Dim RsCliente As OdbcDataReader

            cmd = New OdbcCommand(consulta, cnn)
            cmd.CommandType = CommandType.Text

            RsCliente = cmd.ExecuteReader()
            cmd.Dispose()

            If RsCliente.Read() Then
                Label4.Text = RsCliente(1)
                Label5.Text = RsCliente(0)
                Label6.Text = RsCliente(2)
            End If
            For Each prod As Producto In ProductosSuper.ListaProductos
                Productos.Items.Add(prod.stock & "                                     " & prod.nombre)
            Next
        End If
    End Sub
    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'PrintRemito.Print()
    End Sub
End Class
Imports System.Data.Odbc
Public Class Ticket_Factura
    Private Sub Ticket_Factura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarDatos()
    End Sub
    Private Sub CargarDatos()
        Dim consulta As String
        consulta = ("Select NroTF,Tipo,Iva,ImporteF,NroCaja,CodEmp,Fecha from Ticket_Factura where NroTf = " & Registrarclienteenenvio.nroTicket)

        Dim rs As OdbcDataReader

        cmd = New OdbcCommand(consulta, cnn)
        cmd.CommandType = CommandType.Text

        rs = cmd.ExecuteReader()

        If rs.Read() Then
            Label1.Text = rs(0)
            Label3.Text = rs(3)
            Label6.Text = rs(6)

            consulta = ("Select Nombre,Apellido,Direccion from Envio E, Cliente C where E.NroTf = " & rs(0) & " and E.CodC = C.CodC")
            Dim RsCliente As OdbcDataReader

            cmd = New OdbcCommand(consulta, cnn)
            cmd.CommandType = CommandType.Text

            RsCliente = cmd.ExecuteReader()
            cmd.Dispose()

            If RsCliente.Read() Then
                Label2.Text = RsCliente(0)
                Label4.Text = RsCliente(1)
                Label5.Text = RsCliente(2)
            End If

            For Each prod As Producto In ProductosSuper.ListaProductos

                Productos.Items.Add(prod.stock & "                                     " & prod.nombre & "                                                  " & prod.precio & "                  " & prod.stock * prod.precio)
            Next
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'PrintTicket_Factura.Print()
    End Sub
End Class
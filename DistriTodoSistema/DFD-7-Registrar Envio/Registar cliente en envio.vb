Imports System.Data.Odbc
Public Class Registrarclienteenenvio

    Dim TipoPedido As String
    Public cliente As Integer
    Public nroTicket As Integer

    Private Sub Registrarclienteenenvio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call conexion()
        Call MostrarClientes()
    End Sub

    Public Sub MostrarClientes()
        Dim sql As String
        Dim ds As New DataSet
        Dim adp As OdbcDataAdapter

        sql = "Select CodC,Nombre,Apellido,DNI from Cliente"
        ds.Tables.Add("Clientes")
        adp = New OdbcDataAdapter(sql, cnn)
        adp.Fill(ds.Tables("Clientes"))
        Me.DataGridView1.DataSource = ds.Tables("Clientes")

    End Sub

    Private Function cargarConsulta(ByVal consulta)
        Dim rs As OdbcDataReader

        cmd = New OdbcCommand(consulta, cnn)
        cmd.CommandType = CommandType.Text

        rs = cmd.ExecuteReader()
        Dim cont As Integer = 0
        Dim existe As Boolean = False

        While rs.Read() = True
            cont += 1
        End While

        If cont > 0 Then
            existe = True
        End If

        Return existe

    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim existe As Boolean = False
        Dim Consulta As String
        Consulta = "select DNI from Cliente where DNI = " & TextBox1.Text & " "

        existe = cargarConsulta(Consulta)

        If existe = False Then
            MsgBox("El cliente no existe")
            Form3.ShowDialog()
        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            TipoPedido = "Telefónico"
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            TipoPedido = "Presencial"
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ProductosSuper.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim importeF As Single = 0

        Dim sql As String = "SELECT MAX(NroTF) FROM Ticket_Factura"
        Dim rsTicket As OdbcDataReader

        cmd = New OdbcCommand(sql, cnn)
        cmd.CommandType = CommandType.Text
        rsTicket = cmd.ExecuteReader()

        If rsTicket.Read() Then
            nroTicket = rsTicket(0)
            nroTicket = nroTicket + 1
        End If

        cmd.Dispose()


        sql = "INSERT INTO Ticket_Factura VALUES(" & nroTicket & ",'A','0',NULL,NULL,NULL,CURDATE())"
        cmd = New OdbcCommand(sql, cnn)
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        sql = "INSERT INTO Remito Values(''," & nroTicket & "," & cliente & ", CURDATE())"
        cmd = New OdbcCommand(sql, cnn)
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()


        For Each prod As Producto In ProductosSuper.ListaProductos

            importeF = importeF + (prod.precio * prod.stock)

            sql = "CALL cargarVenta(" & nroTicket & "," & prod.IdBase & "," & prod.precio & "," & prod.stock & ")"
            cmd = New OdbcCommand(sql, cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.ExecuteNonQuery()
            cmd.Dispose()

        Next

        sql = "Update Ticket_Factura set importeF =" & importeF & "  WHERE NroTF = " & nroTicket
        cmd = New OdbcCommand(sql, cnn)
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        sql = "INSERT INTO Envio Values(''," & cliente & "," & nroTicket & ", CURDATE(), 0)"
        cmd = New OdbcCommand(sql, cnn)
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        Me.Hide()
        Remito.Show()
        Ticket_Factura.Show()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        cliente = DataGridView1.CurrentRow.Cells("CodC").Value
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Inicio_Envios.Show()
    End Sub
End Class

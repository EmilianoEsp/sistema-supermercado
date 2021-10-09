Imports System.Data.Odbc

Public Class MovimientosCaja
    Dim sql As String
    Dim TotalF As Single
    Dim Total As Single
    Dim Diferencia As Single

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        dgvCaja.Rows.Clear()
        dgvMovimientos.Rows.Clear()
        Control.btnGenerar.Enabled = True
        Me.Hide()
        Control.Show()
    End Sub

    Private Sub btnCaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCaja.Click
        Dim fecha As String
        fecha = (Control.dtpFecha.Value.Date).ToString("yyyy/MM/dd")
        Dim lleno As Boolean = True
        Total = 0
        TotalF = 0
        Diferencia = 0
        If lleno = True Then
            dgvMovimientos.Rows.Clear()
            dgvCaja.Rows.Clear()
        End If
        sql = "select saldoi,saldof,faltante,ganancia from cajero where nrocaja = " & cboCaja.SelectedItem & " and fecha = '" & fecha & "'"
        cmd = New OdbcCommand(sql, cnn)
        cmd.CommandType = CommandType.Text
        rs = cmd.ExecuteReader
        cmd.Dispose()
        While rs.Read
            dgvCaja.Rows.Add(rs(0), rs(1), rs(3), rs(2))
            Diferencia = Diferencia + rs(2)
            Total = Total + rs(3)
        End While
        sql = "select nrotf, importef, nrocaja from ticket_factura where nrocaja = " & cboCaja.SelectedItem & " and fecha = '" & fecha & "'"
        cmd = New OdbcCommand(sql, cnn)
        cmd.CommandType = CommandType.Text
        rs = cmd.ExecuteReader
        cmd.Dispose()
        While rs.Read
            dgvMovimientos.Rows.Add(rs(0), rs(1), rs(2))
            TotalF = TotalF + rs(1)
        End While
        If Total <> TotalF Then
            MsgBox("Hay Problemas es la Caja " & cboCaja.SelectedItem & " con faltante de " & Diferencia & "", vbCritical)
            sql = "update cajero set saldof = saldof + " & Diferencia & "  where nrocaja = " & cboCaja.SelectedItem & " and fecha = '" & fecha & "'"
            cmd = New OdbcCommand(sql, cnn)
            cmd.CommandType = CommandType.Text
            rs = cmd.ExecuteReader
            cmd.Dispose()
            sql = "update cajero set ganancia = " & TotalF & " where nrocaja = " & cboCaja.SelectedItem & " and fecha = '" & fecha & "'"
            cmd = New OdbcCommand(sql, cnn)
            cmd.CommandType = CommandType.Text
            rs = cmd.ExecuteReader
            cmd.Dispose()
            sql = "update cajero set faltante = 0 where nrocaja = " & cboCaja.SelectedItem & " and fecha = '" & fecha & "'"
            cmd = New OdbcCommand(sql, cnn)
            cmd.CommandType = CommandType.Text
            rs = cmd.ExecuteReader
            cmd.Dispose()
            MsgBox("Probleama de Caja Solucionado")
        Else
            MsgBox("La caja no tiene problemas")
        End If
        btnVolver.Enabled = True
        lleno = False
    End Sub

    Private Sub btnVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVer.Click
        Dim fecha As String
        gbCaja.Enabled = True
        fecha = (Control.dtpFecha.Value.Date).ToString("yyyy/MM/dd")
        sql = "select nrocaja from cajero where fecha = '" & fecha & "'"
        Call consulta(sql)
        While rs.Read
            cboCaja.Items.Add(rs(0))
        End While
        btnVer.Visible = False
        btnCaja.Enabled = True
    End Sub

    Private Sub MovimientosCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
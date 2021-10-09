Imports System.Data.Odbc
Public Class Gondolas

    Dim res As OdbcDataReader

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Gondolas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tablaAux.Visible = False
        conexion()

        tablaAux.DataSource = generarTabla("select DISTINCT codG from gondola")

        For i As Integer = 0 To tablaAux.Rows.Count - 2

            ComboBox1.Items.Add(tablaAux.Rows(i).Cells(0).Value.ToString)

        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim cant = consultar("Select stockI from gondola where codp = " & txtProducto.Text)

        If cant = "" Then
            cant = 0

        Else

            cant = CInt(cant) + CInt(txtCant.Text)
        End If
        Dim fecha = Format(CDate(txtVencimiento.Text), "yyyy/MM/dd")
        Try

            consultar("insert into gondola values(" & ComboBox1.Text & ", " & txtProducto.Text & ", " & cant & ", '" & txtLugar.Text & "', '" & fecha & "')")

            MsgBox("Producto cargado correctamente")


        Catch

            MsgBox("ERROR, asegurese de haber ingresado los datos correctamente")

        End Try




        txtCant.Text = ""
        txtLugar.Text = ""
        txtProducto.Text = ""
        txtVencimiento.Text = ""

    End Sub

    Private Sub txtVencimiento_TextChanged(sender As Object, e As EventArgs) Handles txtVencimiento.TextChanged
        If txtVencimiento.TextLength = 2 Then

            txtVencimiento.Text = txtVencimiento.Text & "/"

        ElseIf txtVencimiento.TextLength = 5 Then

            txtVencimiento.Text = txtVencimiento.Text & "/"

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Inicio_Productos.Show()
    End Sub
End Class
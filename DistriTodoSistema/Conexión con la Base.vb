Imports System.Data.Odbc
Imports System.Globalization

Module Module1
    Public cnn As OdbcConnection
    Public cmd As OdbcCommand
    Public rs As OdbcDataReader
    Public adaptador As OdbcDataAdapter
    Public datos As New DataSet
    Public rs1 As OdbcDataReader
    Public codUltimaAlta As Integer
    Dim cambio As New Globalization.CultureInfo("es-ES")

    Public nom As String
    Public puesto As String
    Public fecha As String
    Public horario As String
    Public descanso As String
    Public salario As Decimal

    Public telefono As Integer
    Public nroempleado As Integer

    Public Sub conexion()
        cambio.NumberFormat.NumberDecimalSeparator = (".")
        System.Threading.Thread.CurrentThread.CurrentCulture = cambio
        Try
            cnn = New OdbcConnection("DSN=super") 'DSN en el ODBC
            cnn.Open()
            MsgBox("Conexión Exitosa", , "Base de Datos")
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & "Fallo de la conexión", , "Fallo")
            cnn.Close()
        End Try
    End Sub

    Public Sub consulta(ByVal sql As String)
        cmd = New OdbcCommand(sql, cnn)
        cmd.CommandType = CommandType.Text
        rs = cmd.ExecuteReader()
        cmd.Dispose()
    End Sub

    Public Sub ultimaAlta(ByVal tabla As String, ByVal pk As String, ByRef codUltimaAlta As Integer)
        cmd = New OdbcCommand("select max(" & pk & ") from " & tabla, cnn)
        cmd.CommandType = CommandType.Text
        rs = cmd.ExecuteReader()
        cmd.Dispose()
        While rs.Read
            If rs(0) Is DBNull.Value Then
                codUltimaAlta = 0
            Else
                codUltimaAlta = rs(0)
            End If
        End While
    End Sub

    Public cantReclamos As Integer = 1
    Public cantSugerencias As Integer = 1


    Public Sub sql(ByVal consulta As String)
        cmd = New OdbcCommand(consulta, cnn)
        cmd.CommandType = CommandType.Text
        rs = cmd.ExecuteReader()
        cmd.Dispose()
    End Sub


    Public rsX As OdbcDataReader
    Public Sub sqlX(ByVal consulta As String)
        cmd = New OdbcCommand(consulta, cnn)
        cmd.CommandType = CommandType.Text
        rsX = cmd.ExecuteReader()
        cmd.Dispose()
    End Sub



    '---------------------------------------------- vARIABLE PARA LA POSICION DE OBJETOS
    Dim posicion As System.Drawing.Point

    '---------------------------------------------- CREAR LABELS
    Dim label_control As Label
    '--> numero del lbl / posicion X / posicion Y / formulario
    Public Sub crearLabel(ByVal nombre As String, ByVal txt As String, ByVal X As Integer, ByVal Y As Integer, ByVal frm As Form, Optional ByVal modificable As Boolean = True)
        label_control = New Label
        With label_control
            .Name = "lbl" & nombre                                ' NOMBRE 
            .Text = txt                                           ' CONTENIDO
            posicion.X = (X) : posicion.Y = (Y)                   ' POSICION X - Y
            .Location = posicion                                  ' ASIGANA POSICION
            .Enabled = modificable                                ' PERMITE O NO LA INTERACCION CON EL OBJETO
            .BackColor = Color.Transparent                        ' COLOR DEL FONDO
            .Font = New Font(label_control.Font.Name, 10)         ' TAMAÑO DE LA FUENTE
            .AutoSize = True                                      ' TAMAÑO DEL LABEL AUTOMATICO
        End With
        frm.Controls.Add(label_control)
    End Sub

    '---------------------------------------------- CREAR NUMERICUPDOWNS
    Dim NumericUpDown_control As NumericUpDown
    '--> numero del nud / posicion X / posicion Y / formulario
    Public Sub crearNumericUpDown(ByVal nombre As String, ByVal X As Integer, ByVal Y As Integer, ByVal frm As Form, Optional ByVal valor As Integer = 0, Optional ByVal modificable As Boolean = True, Optional ByVal max As Integer = 1000000)
        NumericUpDown_control = New NumericUpDown
        With NumericUpDown_control
            .Name = "nud" & nombre                                ' NOMBRE 
            posicion.X = (X) : posicion.Y = (Y)                   ' POSICION X - Y
            .Location = posicion                                  ' ASIGANA POSICION
            .AutoSize = True                                      ' TAMAÑO DEL NUMERICUPDOWN AUTOMATICO
            .Enabled = modificable                                ' PERMITE O NO LA INTERACCION CON EL OBJETO
            .Maximum = max                                        ' LIMITE MAXIMO DE LOS VALORES PERMITIDO
            .Size = New Size(120, 20)                             ' TAMAÑO DEL NUMERICUPDOWN MANUAL
            .Value = valor                                        ' VALOR CON EL QUE COMIENZA
        End With
        frm.Controls.Add(NumericUpDown_control)
    End Sub

    '---------------------------------------------- BUSCA LA ULTIMA ALTA 
    Public CodPK As Integer                         'Variable para el uso de la ultima alta 
    Public Sub obtenerUltimaAlta(ByVal pk As String, ByVal tabla As String, ByRef codUltimaAlta As Integer)
        cmd = New OdbcCommand("select max(" & pk & ") from " & tabla, cnn)
        cmd.CommandType = CommandType.Text
        rs = cmd.ExecuteReader()
        cmd.Dispose()
        While rs.Read
            'Si el resultado de la busqueda de NULL entoced la variable toma 1
            If rs(0) Is DBNull.Value Then
                codUltimaAlta = 0
            Else  'En caso contrario, la variable toma lo que obtiene de la Base de Datos
                codUltimaAlta = rs(0)
            End If
        End While
    End Sub

    '---------------------------------------------- BUSCA UN LABEL ESPECIFICO POR SU NOMBRE
    Public Sub buscarLbl(ByVal frm As Form, ByVal nombrelbl As String, ByRef lbl_text As String)  '--> formulario / nombre del lbl / varible a la que se modifica su valor
        For Each lbl As Label In frm.Controls.OfType(Of Label)()   'Busca entre todos los labels del frm indicado
            If lbl.Name.Contains(nombrelbl) Then                   'si el lbl concuerda con el nombre indicado ...
                lbl_text = lbl.Text                                'La variable que ingresa toma el valor que tiene el lbl
            End If
        Next
    End Sub

    '---------------------------------------------- BUSCA UN NUMERICUPDOWN ESPECIFICO POR SU NOMBRE
    Public Sub buscarNud(ByVal frm As Form, ByVal nombrenup As String, ByRef nud_value As Integer) '--> formulario / nombre del nud / varible a la que se modifica su valor
        For Each nud As NumericUpDown In frm.Controls.OfType(Of NumericUpDown)() 'Busca entre todos los NumericUpDowns del frm indicado
            If nud.Name.Contains(nombrenup) Then                                 'si el nud concuerda con el nombre indicado ...
                nud_value = nud.Value                                            'La variable que ingresa toma el valor que tiene el nud
            End If
        Next
    End Sub

    '---------------------------------------------- COMPLETA EL DOCUMENTO ORDEN DE COMPRA --> nro de orden de compra
    Public Sub completarOrdenCompra(ByVal codOC As Integer)

        Call crearLabel("NombreEmpresa", "DISTRITODO", 110, 90, frmOrdenCompra)
        Dim i = 1, x = 24, y = 218
        Dim SubTotal As Integer
        Dim IVA As Integer
        Dim Total As Integer

        Call sql("select codOC, fechaE, nombre, lugar, tel, producto, cant, precio_uni from Orden_Compra inner join Proveedor using(codProv) inner join Detalle_OC using(codOC) inner join producto using(codP) where codOC = " & codOC & ";")
        While rs.Read
            If i = 1 Then 'Solo genera 1 vez los siguientes labels
                Call crearLabel("OrdenCompra", rs(0), 315, 85, frmOrdenCompra)
                Call crearLabel("Fecha", rs(1), 315, 100, frm2DatosOrdenCompra01)
                Call crearLabel("NombreProveedor", rs(2), 67, 137, frmOrdenCompra)
                Call crearLabel("DireccionProveedor", rs(3), 67, 156, frmOrdenCompra)
                Call crearLabel("TelefonoProveedor", rs(4), 320, 156, frmOrdenCompra)
            End If        'Encambio los siguientes se generaran hasta un limite
            Call crearLabel("Item" & i, i, x, y, frmOrdenCompra)
            Call crearLabel("Producto" & i, rs(5), x + 24, y, frmOrdenCompra)
            Call crearLabel("Cantidad" & i, rs(6), x + 182, y, frmOrdenCompra)
            Call crearLabel("Precio" & i, rs(7), x + 236, y, frmOrdenCompra)
            Call crearLabel("ValorTotal" & i, rs(6) * rs(7), x + 308, y, frmOrdenCompra)
            y = y + 10
            SubTotal = SubTotal + (rs(6) * rs(7))
            i = i + 1
        End While

        IVA = SubTotal * 0.21
        Total = SubTotal + IVA
        Call crearLabel("SubTotal", SubTotal, 332, 426, frmOrdenCompra)
        Call crearLabel("IVA", IVA, 332, 436, frmOrdenCompra)
        Call crearLabel("Total", Total, 332, 446, frmOrdenCompra)
    End Sub

    '---------------------------------------------- COMPLETAR UNA GRILLA
    Public ds As New DataSet
    Public adp As OdbcDataAdapter
    'Grilla --> nombre de la grilla / consulta con la que se carga el DataGridWiew
    Public Sub grilla(ByVal nombreGrilla, ByVal consulta)
        ds.Tables.Add(nombreGrilla)
        adp = New OdbcDataAdapter(consulta, cnn)
        adp.Fill(ds.Tables(nombreGrilla))
    End Sub ' --> : FORMULARIO.dgvTablaOrdenesSinEstado.DataSource = ds.Tables("NOMBRE_GRILLA") <--> SOLO PARA RECORDAR, NO TOMAR EN CUENTA ESTE COMENTARIO <-- 

    '---------------------------------------------- COMPLETAR NOTA DE CREDITO --> nro de orden de compra
    Public Sub completarNotaCredito(ByVal NroNota As Integer)
        Call sql("Select codN, Nrotf, monto, Fe from nota where codN = " & NroNota)
        While rs.Read
            Call crearLabel("NroNotaCredito", rs(0), 575, 42, frmNotaCredito)
            Call crearLabel("Fecha", rs(3), 575, 85, frmNotaCredito)
            Call crearLabel("Concepto", "Devolucion de Productos - Valido por 48 Hs.", 85, 122, frmNotaCredito)
            Call crearLabel("Descripcion", "Referente al Ticket Nro " & rs(1), 142, 160, frmNotaCredito)
            Call crearLabel("SubTotal", rs(2), 610, 285, frmNotaCredito)
            Call crearLabel("Total", rs(2), 610, 318, frmNotaCredito)
        End While
    End Sub

    '---------------------------------------------- COMPLETAR TICKETFACTURA --> nro de orden de compra
    Public Sub completarTicketFactura(ByVal NroNota As Integer)
        Call sql("Select codN, Nrotf, monto, Fe from nota where codN = " & NroNota)
        While rs.Read
            Call crearLabel("NroNotaCredito", rs(0), 575, 42, frmNotaCredito)
            Call crearLabel("Fecha", rs(3), 575, 85, frmNotaCredito)
            Call crearLabel("Concepto", "Devolucion de Productos - Valido por 48 Hs.", 85, 122, frmNotaCredito)
            Call crearLabel("Descripcion", "Referente al Ticket Nro " & rs(1), 142, 160, frmNotaCredito)
            Call crearLabel("SubTotal", rs(2), 610, 285, frmNotaCredito)
            Call crearLabel("Total", rs(2), 610, 318, frmNotaCredito)
        End While
    End Sub

    Public Function generarTabla(ByVal sql As String)

        Dim adp As OdbcDataAdapter
        Dim ds As New DataSet

        Try

            ds.Tables.Add("table1")

            adp = New OdbcDataAdapter(sql, cnn)

            adp.Fill(ds.Tables("Table1"))

        Catch ex As Exception

            MsgBox("Error al ejecutar la consulta")


        End Try

        Return ds.Tables("Table1")

    End Function

    Function consultar(ByVal sql As String)

        Dim res As String
        res = ""

        cmd = New OdbcCommand(sql, cnn)
        cmd.CommandType = CommandType.Text
        rs = cmd.ExecuteReader()
        If rs.Read() Then
            res = rs(0)
        End If
        cmd.Dispose()
        Return res

    End Function

    Function consultarTodo(ByVal sql As String)

        Dim res As String
        res = ""

        cmd = New OdbcCommand(sql, cnn)
        cmd.CommandType = CommandType.Text
        rs = cmd.ExecuteReader()

        If rs.Read() Then
            Return rs
        End If
        cmd.Dispose()
        Return rs

    End Function

    Function verificarSiExiste(ByVal sql As String)

        Try
            cmd = New OdbcCommand(sql, cnn)
            cmd.CommandType = CommandType.Text
            rs = cmd.ExecuteReader()
            cmd.Dispose()
            If rs.Read() Then
                Return True
            Else
                Return False
            End If
        Catch

            MsgBox("Error al ejecutar la consulta")

        End Try

        Return False

    End Function

    Public tipo As String


End Module
Public Class ABM
    Sub conexion()
        Try
            cnn = New OdbcConnection("DSN=super") 'DSN en el ODBC
            cnn.Open()
            MsgBox("Conexión realizada de manera exitosa", MsgBoxStyle.Information, "Conexión")
            cnn.Close()
        Catch ex As Exception
            MsgBox("No se logro realizar la conexión debido: " & ex.Message, MsgBoxStyle.Critical, "Tutorial CRUD")
        End Try
    End Sub


    'Creamos el procedimiento para la consulta y le indicamos que debe pedir 2 parametros para
    'ejecutarse correctamente (Tabla, Sql)
    Sub consulta(ByVal Tabla As DataGridView, ByVal Sql As String)
        'Instrucción Try para capturar errores
        Try
            'Creamos el objeto DataAdapter y le pasamos los dos parámetros (Instrucción, conexión)
            Dim da As New OdbcDataAdapter(Sql, cnn)
            'Creamos el objeto DataTable que recibe la información del DataAdapter
            Dim dt As New DataTable
            'Pasamos la información del DataAdapter al DataTable mediante la propiedad Fill
            da.Fill(dt)
            'Mostramos los datos en el DataGridView
            Tabla.DataSource = dt
        Catch ex As Exception
            MsgBox("No se pudo realizar la consulta por: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    'Creamos el procedimiento para Agregar, Actualizar y Eliminar
    Sub operaciones(ByVal Tabla As DataGridView, ByVal Sql As String)
        cnn.Open()
        Try
            'Creamos objeto de tipo Command que almacenará las instrucciones
            Dim cmd As New OdbcCommand(Sql, cnn)
            'Ejecutamos la instruccion mediante la propiedad ExecuteNonQuery del command
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("No se pudo realizar la operación por: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        cnn.Close()
    End Sub
End Class


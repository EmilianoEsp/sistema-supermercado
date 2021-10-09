Imports System.Data.Odbc
Public Class ContratarEmpleado

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Debe ingresar un nombre.", , "Error")
        ElseIf TextBox2.Text = "" Then
            MsgBox("Debe ingresar un apellido.", , "Error")
        ElseIf ComboBox1.Text = "" Then
            MsgBox("Debe ingresar el puesto.", , "Error")
        ElseIf TextBox4.Text = "" Then
            MsgBox("Debe ingresar el teléfono.", , "Error")
        ElseIf TextBox5.Text = "" Then
            MsgBox("Debe ingresar la fecha", , "Error")
        Else
            
            Dim consulta As String
            consulta = "INSERT INTO Empleado(CodE,Nombre,Apellido,Sector,Telefono,FechaIngreso) VALUES ('', '" & TextBox1.Text & " ', '" & TextBox2.Text & " ', '" & ComboBox1.Text & " ', ' " & TextBox4.Text & " ', ' " & TextBox5.Text & " ')"
            Try
                cmd = New OdbcCommand(consulta, cnn)
                cmd.CommandType = CommandType.Text
                rs = cmd.ExecuteReader()

                nom = TextBox1.Text + " " + TextBox2.Text
                puesto = ComboBox1.Text
                fecha = TextBox5.Text
                horario = "08:00 a 16:00"
                descanso = "domingo"
                If puesto.Equals("Gerente") = True Then
                    salario = InputBox("Ingrese el salario:", "Gerente")
                    While salario < 18000 Or salario > 40000
                        MsgBox("Ingrese un salario entre [18000-40000]", , "Error")
                        salario = InputBox("Ingrese el salario:", "Gerente")
                    End While
                ElseIf puesto.Equals("Cajero") = True Then
                    salario = InputBox("Ingrese el salario:", "Cajero")
                    While salario < 18000 Or salario > 40000
                        MsgBox("Ingrese un salario entre [18000-40000]", , "Error")
                        salario = InputBox("Ingrese el salario:", "Gerente")
                    End While
                ElseIf puesto.Equals("Almacen") = True Then
                    salario = InputBox("Ingrese el salario:", "Almacen")
                    While salario < 18000 Or salario > 40000
                        MsgBox("Ingrese un salario entre [18000-40000]", , "Error")
                        salario = InputBox("Ingrese el salario:", "Gerente")
                    End While
                ElseIf puesto.Equals("Reponedor") = True Then
                    salario = InputBox("Ingrese el salario:", "Reponedor")
                    While salario < 18000 Or salario > 40000
                        MsgBox("Ingrese un salario entre [18000-40000]", , "Error")
                        salario = InputBox("Ingrese el salario:", "Gerente")
                    End While
                End If

                telefono = TextBox4.Text

                cmd.Dispose()
                MsgBox("Empleado agregado exitosamente.", , "Empleados")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            ConstanciaDeTrabajo.Show()
            Me.Hide()
            TextBox1.Text = ""
            TextBox2.Text = ""
            ComboBox1.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexion()
        'TextBox1.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Inicio_Empleados.Show()
    End Sub
End Class


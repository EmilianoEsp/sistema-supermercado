Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        tipo = TxtUsuario.Text
        If (TxtUsuario.Text = "root" Or TxtUsuario.Text = "ROOT") And TxtContraseña.Text = "1234" Then 'Ingresar como administrador
            MsgBox("Bienvenido al sistema!", , "DistriTodo")
            Me.Hide() 'se cierra la ventana
            Inicio.Show()
            TxtUsuario.Text = ""
            TxtContraseña.Text = ""
            'Si el usuario y contraseña son correctos aca se debe colocar el primer formulario del sistema
        ElseIf (TxtUsuario.Text = "empleado" Or TxtUsuario.Text = "EMPLEADO") And TxtContraseña.Text = "1234" Then 'Ingresar como empleado
            MsgBox("Bienvenido!", , "DistriTodo")
            Me.Hide()
            Inicio.Show()
            TxtUsuario.Text = ""
            TxtContraseña.Text = ""
        Else
            MsgBox("El usuario o la contraseña son incorrectos", , "Error")
            TxtUsuario.Text = "" 'se limpia el nombre de usuario
            TxtContraseña.Text = "" 'se limpia la contraseña
            TxtUsuario.Focus() 'comienza a escribir en el usuario
        End If
    End Sub
    'cuando la persona escriba se quitara el ejemplo
    Private Sub TxtUsuario_ModifiedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtUsuario.ModifiedChanged
        TxtUsuario.ForeColor = Color.Black 'se cambia el color de la letra a negro
    End Sub

    Private Sub TxtContraseña_ModifiedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtContraseña.ModifiedChanged
        TxtContraseña.ForeColor = Color.Black
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TxtContraseña.UseSystemPasswordChar = False 'el checkbox esta activado, se oculta la contraseña
        Else
            TxtContraseña.UseSystemPasswordChar = True 'el checkbox esta desactivado, se muestra la contraseña
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtContraseña.UseSystemPasswordChar = True 'se oculta la contraseña al momento de cargar
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class

Imports System.Data
Imports System.Data.SqlClient

Public Class TelaDeLogin
    'Private Sub ButtonLogin_Click(sender As System.Object, e As System.EventArgs) Handles ButtonLogin.Click
    '    Dim conexao As New ConexaoComOBancoDeDados()
    '    conexao.ConectarComBanco(TextBoxUser.Text, TextBoxPassword.Text)

    '    Try

    '        Using conn As New SqlConnection(conexao.ConnectionString)

    '            conn.Open()
    '            Dim mainForm As New TelaDeReservas(TextBoxUser.Text, TextBoxPassword.Text)

    '            mainForm.Show()
    '            'Form1.Show()
    '            Me.DialogResult = DialogResult.OK

    '        End Using

    '    Catch ex As Exception
    '        MessageBox.Show("Erro ao conectar ao banco de dados :/", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub



    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(700, 400)

    End Sub

    Private Sub TextBoxUser_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUser.TextChanged

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Close()
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Dim conexao As New ConexaoComOBancoDeDados()
        conexao.ConectarComBanco(TextBoxUser.Text, TextBoxPassword.Text)

        Try

            Using conn As New SqlConnection(conexao.ConnectionString)

                conn.Open()
                Dim mainForm As New TelaDeReservas(TextBoxUser.Text, TextBoxPassword.Text)

                mainForm.Show()
                'Form1.Show()
                Me.DialogResult = DialogResult.OK

            End Using

        Catch ex As Exception
            MessageBox.Show("Erro ao conectar ao banco de dados :/", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

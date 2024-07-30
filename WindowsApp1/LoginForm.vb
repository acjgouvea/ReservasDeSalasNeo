Imports System.Data
Imports System.Data.SqlClient

Public Class LoginForm
    Private Sub ButtonLogin_Click(sender As System.Object, e As System.EventArgs) Handles ButtonLogin.Click
        Dim conexao As New ConexaoComOBancoDeDados()
        conexao.ConectarComBanco(TextBoxUser.Text, TextBoxPassword.Text)

        Try

            Using conn As New SqlConnection(conexao.ConnectionString)

                conn.Open()
                Dim mainForm As New Form1(TextBoxUser.Text, TextBoxPassword.Text)

                mainForm.Show()

                Me.DialogResult = DialogResult.OK

            End Using

        Catch ex As Exception
            MessageBox.Show("Erro ao conectar ao banco de dados :/", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub
End Class

Imports System.Data
Imports System.Data.SqlClient
Imports System.Security.Cryptography.X509Certificates

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

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LabelUser_Click(sender As Object, e As EventArgs) Handles LabelUser.Click

    End Sub

    Private Sub TextBoxUser_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUser.TextChanged

    End Sub

    Private Sub LogoPictureBox_Click(sender As Object, e As EventArgs) Handles LogoPictureBox.Click

    End Sub

    Private Sub ButtonLogin_Enter(sender As Object, e As EventArgs) Handles ButtonLogin.Enter

    End Sub
End Class

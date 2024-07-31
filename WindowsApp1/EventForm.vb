Imports System.Data.SqlClient

Public Class EventForm
    Private conexao As ConexaoComOBancoDeDados
    Private username As String
    Private password As String

    Public Sub New(username As String, password As String)
        InitializeComponent()
        Me.username = username
        Me.password = password
        conexao = New ConexaoComOBancoDeDados()
        conexao.ConectarComBanco(username, password)
    End Sub

    Friend Sub LoadEvent(currentRow As DataGridViewRow)
        TextBoxUsuarioNome.Text = currentRow.Cells("reserva_usuario_nome").Value.ToString()
        DateTimePickerInicio.Value = Convert.ToDateTime(currentRow.Cells("reserva_data_hora_inicio").Value)
        DateTimePickerFim.Value = Convert.ToDateTime(currentRow.Cells("reserva_data_hora_fim").Value)
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Qualquer lógica adicional durante o carregamento do formulário
    End Sub

    Private Sub TextBoxUsuarioNome_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUsuarioNome.TextChanged
        ' Qualquer lógica adicional durante a alteração do texto
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Dim parametros As New List(Of SqlParameter)()
        parametros.Add(New SqlParameter("@reserva_sala_id", 1))
        parametros.Add(New SqlParameter("@reserva_usuario_id", 1))
        parametros.Add(New SqlParameter("@reserva_usuario_nome", TextBoxUsuarioNome.Text))
        parametros.Add(New SqlParameter("@reserva_data_hora_inicio", DateTimePickerInicio.Value))
        parametros.Add(New SqlParameter("@reserva_data_hora_fim", DateTimePickerFim.Value))

        Try
            conexao.ExecutarConsulta(CommandType.StoredProcedure, "sp_ReservaInserir", parametros)
            Me.DialogResult = DialogResult.OK
        Catch ex As Exception
            MessageBox.Show("Erro! " & ex.Message)
        End Try
    End Sub
End Class

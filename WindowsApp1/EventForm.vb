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

    Private Sub EventForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePickerInicio.Format = DateTimePickerFormat.Custom
        DateTimePickerInicio.CustomFormat = "dd/MM/yyyy HH:mm"

        DateTimePickerFim.Format = DateTimePickerFormat.Custom
        DateTimePickerFim.CustomFormat = "dd/MM/yyyy HH:mm"
    End Sub

    Private Sub DateTimePickerInicio_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerInicio.ValueChanged
        If DateTimePickerFim.Value <= DateTimePickerInicio.Value Then
            DateTimePickerFim.Value = DateTimePickerInicio.Value.AddMinutes(30)
        End If
    End Sub

    Private Sub DateTimePickerFim_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerFim.ValueChanged
        If DateTimePickerFim.Value <= DateTimePickerInicio.Value Then
            MessageBox.Show("A hora de fim deve ser maior que a hora de início.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DateTimePickerFim.Value = DateTimePickerInicio.Value.AddMinutes(30)
        End If
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        If DateTimePickerFim.Value <= DateTimePickerInicio.Value Then
            MessageBox.Show("A hora de fim deve ser maior que a hora de início.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Obter o ID do usuário com base no login 
        Dim reservaUsuarioId As Integer
        Try
            reservaUsuarioId = conexao.ObterUsuarioId(username)
        Catch ex As Exception
            MessageBox.Show("Erro ao obter o ID do usuário! " & ex.Message)
            Return
        End Try

        ' Certifique-se de que todos os parâmetros esperados sejam fornecidos
        Dim parametros As New List(Of SqlParameter)()


        parametros.Add(New SqlParameter("@reserva_sala_id", 2)) ' Atualize conforme necessário

        'ID USUARIA TA COM ERRO 
        parametros.Add(New SqlParameter("@reserva_usuario_id", reservaUsuarioId))
        parametros.Add(New SqlParameter("@reserva_data_hora_inicio", DateTimePickerInicio.Value))
        parametros.Add(New SqlParameter("@reserva_data_hora_fim", DateTimePickerFim.Value))

        'PRECISO COLOCAR O EVENTO TAMBEM 
        'parametros.Add(New SqlParameter("@reserva_evento", DateTimePickerFim.Value))
        Try
            conexao.ExecutarConsulta(CommandType.StoredProcedure, "usp_ReservaInserir", parametros)
            Me.DialogResult = DialogResult.OK
        Catch ex As Exception
            MessageBox.Show("Erro ao salvar a reserva! " & ex.Message)
        End Try
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub

    Private Sub TextBoxUsuarioNome_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUsuarioNome.TextChanged





    End Sub
End Class

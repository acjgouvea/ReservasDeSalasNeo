Imports System.Data.SqlClient
Imports DocumentFormat.OpenXml.Math
Imports DocumentFormat.OpenXml.Spreadsheet


Public Class EventForm
    Private conexao As ConexaoComOBancoDeDados
    Private userName As String
    Private password As String
    Public idDaSala As Integer
    Public reservaUsuarioId As String

    Public Sub New(username As String, password As String, sala As String)

        InitializeComponent()
        Me.userName = username
        Me.password = password
        Me.idDaSala = sala

        conexao = New ConexaoComOBancoDeDados()
        conexao.ConectarComBanco(username, password)

    End Sub

    Friend Sub LoadEvent(currentRow As DataGridViewRow)
        TextBoxUsuarioNome.Text = currentRow.Cells(userName).Value.ToString()
        DateTimePickerInicio.Value = Convert.ToDateTime(currentRow.Cells("reserva_data_hora_inicio").Value)
        DateTimePickerFim.Value = Convert.ToDateTime(currentRow.Cells("reserva_data_hora_fim").Value)

    End Sub

    Private Sub EventForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePickerInicio.Format = DateTimePickerFormat.Custom
        DateTimePickerInicio.CustomFormat = "dd/MM HH:mm"

        DateTimePickerFim.Format = DateTimePickerFormat.Custom
        DateTimePickerFim.CustomFormat = "dd/MM HH:mm"
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
        parametros.Add(New SqlParameter("@reserva_sala_id", Me.idDaSala)) ' Atualize conforme necessário
        parametros.Add(New SqlParameter("@reserva_usuario_id", reservaUsuarioId))
        parametros.Add(New SqlParameter("@reserva_data_hora_inicio", DateTimePickerInicio.Value))
        parametros.Add(New SqlParameter("@reserva_data_hora_fim", DateTimePickerFim.Value))
        parametros.Add(New SqlParameter("@reserva_evento", TextBoxUsuarioNome.Text)) ' Adiciona o evento


        Try
            conexao.ExecutarConsulta(CommandType.StoredProcedure, "sp_InserirReserva", parametros)
            Me.DialogResult = DialogResult.OK
        Catch ex As Exception
            MessageBox.Show("Erro ao salvar a reserva! " & ex.Message)
        End Try
        MessageBox.Show("Agendamento feito com sucesso! ")
        Me.Close()
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub

    Private Sub TextBoxUsuarioNome_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUsuarioNome.TextChanged

        Dim reservaUsuarioId As String = userName

    End Sub




End Class
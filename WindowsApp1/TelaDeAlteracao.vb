Imports System.Data.SqlClient
Imports DocumentFormat.OpenXml.Math
Imports DocumentFormat.OpenXml.Spreadsheet

Public Class TelaDeAlteracao
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

        usu_login_VC.Text = Me.userName

    End Sub

    Friend Sub LoadEvent(currentRow As DataGridViewRow)
        usu_login_VC.Text = currentRow.Cells(userName).Value.ToString().Replace(".", "  ")
        DateTimePickerInicio.Value = Convert.ToDateTime(currentRow.Cells("reserva_data_hora_inicio").Value)
        DateTimePickerFim.Value = Convert.ToDateTime(currentRow.Cells("reserva_data_hora_fim").Value)
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Preenche o ComboBox1 e ComboBox2 com horários




        For hora As Integer = 8 To 18
            For minuto As Integer = 0 To 30 Step 30
                Dim time As DateTime = New DateTime(1, 1, 1, hora, minuto, 0)
                ComboBox1.Items.Add(time.ToString("HH:mm"))
                ComboBox2.Items.Add(time.ToString("HH:mm"))
            Next
        Next

        ' Define a seleção do ComboBox com base no valor atual do DateTimePickerInicio e DateTimePickerFim
        ComboBox1.Text = DateTimePickerInicio.Value.ToString("HH:mm")
        ComboBox2.Text = DateTimePickerFim.Value.ToString("HH:mm")

        ' Configurações do DateTimePicker
        DateTimePickerInicio.Format = DateTimePickerFormat.Custom
        DateTimePickerInicio.CustomFormat = "dd/MMMM/yy "


        DateTimePickerFim.Format = DateTimePickerFormat.Custom
        DateTimePickerFim.CustomFormat = "dd/MMMM/yy"



    End Sub

    Private Sub DateTimePickerInicio_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerInicio.ValueChanged
        ComboBox1.Text = DateTimePickerInicio.Value.ToString("HH:mm")
        If DateTimePickerFim.Value <= DateTimePickerInicio.Value Then
            DateTimePickerFim.Value = DateTimePickerInicio.Value.AddMinutes(30)
        End If
    End Sub

    Private Sub DateTimePickerFim_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerFim.ValueChanged
        ComboBox2.Text = DateTimePickerFim.Value.ToString("HH:mm")
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
            reservaUsuarioId = conexao.ObterUsuarioId(userName)
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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' Atualiza o DateTimePickerInicio com o horário selecionado no ComboBox
        Dim selectedTime As String = ComboBox1.SelectedItem.ToString()
        Dim selectedDateTime As DateTime = DateTimePickerInicio.Value.Date.Add(TimeSpan.Parse(selectedTime))
        DateTimePickerInicio.Value = selectedDateTime
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ' Atualiza o DateTimePickerFim com o horário selecionado no ComboBox
        Dim selectedTime As String = ComboBox2.SelectedItem.ToString()
        Dim selectedDateTime As DateTime = DateTimePickerFim.Value.Date.Add(TimeSpan.Parse(selectedTime))
        DateTimePickerFim.Value = selectedDateTime
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub usu_login_VC_Click(sender As Object, e As EventArgs) Handles usu_login_VC.Click

    End Sub

    Private Sub TextBoxUsuarioNome_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUsuarioNome.TextChanged

    End Sub
End Class

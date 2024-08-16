Imports System.Data.SqlClient
Imports DocumentFormat.OpenXml.Drawing

Public Class TelaDeAgendamento

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
        IdSalaAtual.Text = Me.idDaSala

    End Sub
    Public Sub New(username As String)
        InitializeComponent()
        Me.userName = username

        ' Substitui o ponto por espaço no nome do usuário
        Dim nomeFormatado As String = username.Replace(".", " ")

        ' Exibe o nome formatado no controle
        TextBoxUsuarioNome.Text = "Usuario: " & nomeFormatado & Environment.NewLine
    End Sub


    Friend Sub LoadEvent(currentRow As DataGridViewRow)
        Dim sUserName As String = currentRow.Cells(userName).Value.ToString().Replace(".", " ")
        'usu_login_VC.Text = currentRow.Cells(userName).Value.oString()
        usu_login_VC.Text = sUserName
        IdSalaAtual.Text = currentRow.Cells(idDaSala).Value.ToString()
        DateTimePickerInicio.Value = Convert.ToDateTime(currentRow.Cells("reserva_data_hora_inicio").Value)
        DateTimePickerFim.Value = Convert.ToDateTime(currentRow.Cells("reserva_data_hora_fim").Value)
    End Sub

    Private Sub EventForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        usu_login_VC.Text = usu_login_VC.Text.Replace(".", " ")

        Me.StartPosition = FormStartPosition.CenterParent



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


        TextBoxUsuarioNome.Multiline = True
        TextBoxUsuarioNome.Text = "Usuario: " & usu_login_VC.Text & Environment.NewLine
        TextBoxUsuarioNome.SelectionStart = TextBoxUsuarioNome.Text.Length


    End Sub

    Private Sub DateTimePickerInicio_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerInicio.ValueChanged
        ComboBox1.Text = DateTimePickerInicio.Value.ToString("HH:mm")
        If DateTimePickerFim.Value <= DateTimePickerInicio.Value Then
            DateTimePickerFim.Value = DateTimePickerInicio.Value.AddMinutes(30)
        End If
    End Sub

    Private Sub DateTimePickerFim_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerFim.ValueChanged
        ComboBox2.Text = DateTimePickerFim.Value.ToString("HH:mm")

        ' Verifica se o horário de fim é menor ou igual ao horário de início
        ' ou se o intervalo de tempo é menor que 30 minutos
        If DateTimePickerFim.Value <= DateTimePickerInicio.Value OrElse DateTimePickerFim.Value.Subtract(DateTimePickerInicio.Value).TotalMinutes < 30 Then
            MessageBox.Show("A hora de fim deve ser maior que a hora de início por pelo menos 30 minutos.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' Ajusta o tempo de fim para ser 30 minutos após o início
            DateTimePickerFim.Value = DateTimePickerInicio.Value.AddMinutes(30)
        End If
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click

        Dim fixedText As String = "Usuario: " & usu_login_VC.Text & Environment.NewLine
        If TextBoxUsuarioNome.Text.Trim() = fixedText Then
            MessageBox.Show("Por favor, adicione uma descrição para o evento.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If DateTimePickerFim.Value.Subtract(DateTimePickerInicio.Value).TotalMinutes < 30 Then
            MessageBox.Show("O intervalo entre a hora de início e fim deve ser igual ou maior 30 minutos.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Verificar se a hora de fim é maior que a hora de início
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

    Private Sub TextBoxUsuarioNome_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxUsuarioNome.KeyPress
        ' Dim fixedText As String = "Usuario: " & usu_login_VC.Text & Environment.NewLine
        Dim fixedText As String = usu_login_VC.Text & Environment.NewLine


        If TextBoxUsuarioNome.SelectionStart < fixedText.Length AndAlso e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
            Return
        End If


        If TextBoxUsuarioNome.Text.Length >= fixedText.Length + 45 AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub


    Private Sub UsuarioNome_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUsuarioNome.TextChanged

        Dim fixedText As String = usu_login_VC.Text & Environment.NewLine

        If Not TextBoxUsuarioNome.Text.StartsWith(fixedText) Then
            TextBoxUsuarioNome.Text = fixedText
            TextBoxUsuarioNome.SelectionStart = TextBoxUsuarioNome.Text.Length
        End If
    End Sub


End Class


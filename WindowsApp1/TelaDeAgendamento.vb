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

        ' usu_login_VC.Text = Me.userName
        'IdSalaAtual.Text = Me.idDaSala

    End Sub
    Public Sub New(username As String)
        InitializeComponent()
        Me.userName = username


        Dim nomeFormatado As String = username.Replace(".", " ")

    End Sub


    Friend Sub LoadEvent(currentRow As DataGridViewRow)
        Dim sUserName As String = currentRow.Cells(userName).Value.ToString().Replace(".", " ")
        'usu_login_VC.Text = currentRow.Cells(userName).Value.oString()
        ' usu_login_VC.Text = sUserName
        ' IdSalaAtual.Text = currentRow.Cells(idDaSala).Value.ToString()

        DateTimePickerInicio.Value = Convert.ToDateTime(currentRow.Cells("reserva_data_hora_inicio").Value)
        DateTimePickerFim.Value = Convert.ToDateTime(currentRow.Cells("reserva_data_hora_fim").Value)
    End Sub

    Private Sub EventForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' usu_login_VC.Text = usu_login_VC.Text.Replace(".", " ")

        Me.StartPosition = FormStartPosition.Manual
        Me.Top = 400
        Me.Left = 1200

        UtilsNeobetel.UtilGeral.carregaVisualComponente(Panel1)
        UtilsNeobetel.UtilGeral.carregaVisualComponente(Panel2)

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


        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        TextBoxUsuarioNome.MaxLength = 25
        'dgvGridReserva.Columns("").ReadOnly = True

    End Sub

    Private Sub DateTimePickerInicio_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerInicio.ValueChanged
        ComboBox1.Text = DateTimePickerInicio.Value.ToString("HH:mm")
        If DateTimePickerFim.Value <= DateTimePickerInicio.Value Then
            DateTimePickerFim.Value = DateTimePickerInicio.Value.AddMinutes(30)
        End If

        DateTimePickerInicio.Format = DateTimePickerFormat.Custom
        'DateTimePickerInicio.CustomFormat = "dd/MMMM/yy HH:mm"
        DateTimePickerInicio.ShowUpDown = True


    End Sub

    Private Sub DateTimePickerFim_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerFim.ValueChanged
        ComboBox2.Text = DateTimePickerFim.Value.ToString("HH:mm")

        If DateTimePickerFim.Value <= DateTimePickerInicio.Value OrElse DateTimePickerFim.Value.Subtract(DateTimePickerInicio.Value).TotalMinutes < 30 Then
            MessageBox.Show("A hora de fim deve ser maior que a hora de início por pelo menos 30 minutos.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error)


            DateTimePickerFim.Value = DateTimePickerInicio.Value.AddMinutes(30)
        End If
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs)


    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        Dim selectedTime As String = ComboBox1.SelectedItem.ToString()
        Dim selectedDateTime As DateTime = DateTimePickerInicio.Value.Date.Add(TimeSpan.Parse(selectedTime))
        DateTimePickerInicio.Value = selectedDateTime
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

        Dim selectedTime As String = ComboBox2.SelectedItem.ToString()
        Dim selectedDateTime As DateTime = DateTimePickerFim.Value.Date.Add(TimeSpan.Parse(selectedTime))
        DateTimePickerFim.Value = selectedDateTime
    End Sub

    Private Sub TextBoxUsuarioNome_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUsuarioNome.TextChanged

        TextBoxUsuarioNome.Text = TextBoxUsuarioNome.Text.ToUpper()


        TextBoxUsuarioNome.SelectionStart = TextBoxUsuarioNome.Text.Length


        If TextBoxUsuarioNome.Text.Length > 25 Then
            TextBoxUsuarioNome.Text = TextBoxUsuarioNome.Text.Substring(0, 25)
            TextBoxUsuarioNome.SelectionStart = TextBoxUsuarioNome.Text.Length
        End If
    End Sub

    Private Sub TextBoxUsuarioNome_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBoxUsuarioNome.Validating

        If String.IsNullOrWhiteSpace(TextBoxUsuarioNome.Text) Then
            MessageBox.Show("O motivo não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Cancel = True
        End If
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Dim fixedText As String = "Usuario: " '& usu_login_VC.Text & Environment.NewLine
        If TextBoxUsuarioNome.Text.Trim() = fixedText Then
            MessageBox.Show("Por favor, adicione uma descrição para o evento.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If DateTimePickerFim.Value.Subtract(DateTimePickerInicio.Value).TotalMinutes < 30 Then
            MessageBox.Show("O intervalo entre a hora de início e fim deve ser igual ou maior 30 minutos.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        If DateTimePickerFim.Value <= DateTimePickerInicio.Value Then
            MessageBox.Show("A hora de fim deve ser maior que a hora de início.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim reservaUsuarioId As Integer
        Try
            reservaUsuarioId = conexao.ObterUsuarioId(userName)
        Catch ex As Exception
            MessageBox.Show("Erro ao obter o ID do usuário! " & ex.Message)
            Return
        End Try


        Dim parametros As New List(Of SqlParameter)()
        parametros.Add(New SqlParameter("@reserva_sala_id", Me.idDaSala))
        parametros.Add(New SqlParameter("@reserva_usuario_id", reservaUsuarioId))
        parametros.Add(New SqlParameter("@reserva_data_hora_inicio", DateTimePickerInicio.Value))
        parametros.Add(New SqlParameter("@reserva_data_hora_fim", DateTimePickerFim.Value))
        parametros.Add(New SqlParameter("@reserva_evento", TextBoxUsuarioNome.Text))

        Try
            conexao.ExecutarConsulta(CommandType.StoredProcedure, "sp_InserirReserva", parametros)
            Me.DialogResult = DialogResult.OK
        Catch ex As Exception
            MessageBox.Show("Erro ao salvar a reserva! ")
        End Try
        MessageBox.Show("Agendamento feito com sucesso! ")
        Me.Close()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Close()
    End Sub


End Class


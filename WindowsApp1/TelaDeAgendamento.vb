﻿Imports System.Data.SqlClient
Imports DocumentFormat.OpenXml.Drawing

Public Class TelaDeAgendamento

    Private conexao As ConexaoComOBancoDeDados
    Private sUserName As String
    Private sPassword As String
    Public iIdDaSala As Integer
    Public sReservaUsuarioId As String

    Public Sub New(sUsername As String, sPassword As String, iSala As Integer)
        InitializeComponent()
        Me.sUserName = sUsername
        Me.sPassword = sPassword
        Me.iIdDaSala = iSala

        conexao = New ConexaoComOBancoDeDados()
        conexao.ConectarComBanco(sUsername, sPassword)
    End Sub

    Public Sub New(sUsername As String)
        InitializeComponent()
        Me.sUserName = sUsername

        Dim sNomeFormatado As String = sUsername.Replace(".", " ")
    End Sub

    Friend Sub LoadEvent(currentRow As DataGridViewRow)
        Dim sUserName As String = currentRow.Cells("userName").Value.ToString().Replace(".", " ")
        DateTimePickerInicio.Value = Convert.ToDateTime(currentRow.Cells("reserva_data_hora_inicio").Value)
        DateTimePickerFim.Value = Convert.ToDateTime(currentRow.Cells("reserva_data_hora_fim").Value)
    End Sub

    Private Sub EventForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.StartPosition = FormStartPosition.CenterScreen


        '   Me.StartPosition = FormStartPosition.Manual
        ' Me.Top = 400
        ' Me.Left = 1200 '

        UtilsNeobetel.UtilGeral.carregaVisualComponente(Panel1)
        UtilsNeobetel.UtilGeral.carregaVisualComponente(Panel2)

        For iHora As Integer = 8 To 18
            For iMinuto As Integer = 0 To 30 Step 30
                Dim dtTime As DateTime = New DateTime(1, 1, 1, iHora, iMinuto, 0)
                ComboBox1.Items.Add(dtTime.ToString("HH:mm"))
                ComboBox2.Items.Add(dtTime.ToString("HH:mm"))
            Next
        Next

        ComboBox1.Text = DateTimePickerInicio.Value.ToString("HH:mm")
        ComboBox2.Text = DateTimePickerFim.Value.ToString("HH:mm")

        DateTimePickerInicio.Format = DateTimePickerFormat.Custom
        DateTimePickerInicio.CustomFormat = "dd/MMMM/yy "

        DateTimePickerFim.Format = DateTimePickerFormat.Custom
        DateTimePickerFim.CustomFormat = "dd/MMMM/yy"

        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        TextBoxUsuarioNome.MaxLength = 25
    End Sub

    Private Sub DateTimePickerInicio_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerInicio.ValueChanged

        DateTimePickerInicio.MinDate = DateTime.Today
        ComboBox1.Text = DateTimePickerInicio.Value.ToString("HH:mm")
        If DateTimePickerFim.Value <= DateTimePickerInicio.Value Then
            DateTimePickerFim.Value = DateTimePickerInicio.Value.AddMinutes(30)
        End If
        DateTimePickerInicio.ShowUpDown = True
    End Sub

    Private Sub DateTimePickerFim_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerFim.ValueChanged
        ComboBox2.Text = DateTimePickerFim.Value.ToString("HH:mm")

        If DateTimePickerFim.Value <= DateTimePickerInicio.Value OrElse DateTimePickerFim.Value.Subtract(DateTimePickerInicio.Value).TotalMinutes < 30 Then
            MessageBox.Show("A hora de fim deve ser maior que a hora de início por pelo menos 30 minutos.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DateTimePickerFim.Value = DateTimePickerInicio.Value.AddMinutes(30)
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim sSelectedTime As String = ComboBox1.SelectedItem.ToString()
        Dim dtSelectedDateTime As DateTime = DateTimePickerInicio.Value.Date.Add(TimeSpan.Parse(sSelectedTime))
        DateTimePickerInicio.Value = dtSelectedDateTime
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim sSelectedTime As String = ComboBox2.SelectedItem.ToString()
        Dim dtSelectedDateTime As DateTime = DateTimePickerFim.Value.Date.Add(TimeSpan.Parse(sSelectedTime))
        DateTimePickerFim.Value = dtSelectedDateTime
    End Sub

    Private Sub TextBoxUsuarioNome_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUsuarioNome.TextChanged
        ' Converter o texto para maiúsculas
        Dim textUpper As String = TextBoxUsuarioNome.Text.ToUpper()

        ' Limitar a 45 caracteres
        If textUpper.Length > 45 Then
            textUpper = textUpper.Substring(0, 45)
        End If

        ' Atualizar o texto na TextBox e manter o cursor no final
        If TextBoxUsuarioNome.Text <> textUpper Then
            TextBoxUsuarioNome.Text = textUpper
            TextBoxUsuarioNome.SelectionStart = textUpper.Length
        End If
    End Sub

    Private Sub TextBoxUsuarioNome_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBoxUsuarioNome.Validating
        If String.IsNullOrWhiteSpace(TextBoxUsuarioNome.Text) Then
            MessageBox.Show("O motivo não pode ficar em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Cancel = True
        End If
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        If String.IsNullOrWhiteSpace(TextBoxUsuarioNome.Text.Trim()) Then
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

        Dim iReservaUsuarioId As Integer
        Try
            iReservaUsuarioId = conexao.ObterUsuarioId(sUserName)
        Catch ex As Exception
            MessageBox.Show("Erro ao obter o ID do usuário! " & ex.Message)
            Return
        End Try

        Dim lParametros As New List(Of SqlParameter)() From {
            New SqlParameter("@reserva_sala_id", Me.iIdDaSala),
            New SqlParameter("@reserva_usuario_id", iReservaUsuarioId),
            New SqlParameter("@reserva_data_hora_inicio", DateTimePickerInicio.Value),
            New SqlParameter("@reserva_data_hora_fim", DateTimePickerFim.Value),
            New SqlParameter("@reserva_evento", TextBoxUsuarioNome.Text)
        }

        Try
            conexao.ExecutarConsulta(CommandType.StoredProcedure, "sp_InserirReserva", lParametros)
            Me.DialogResult = DialogResult.OK
            MessageBox.Show("Agendamento feito com sucesso!")
        Catch ex As Exception
            MessageBox.Show("Erro ao salvar a reserva! " & ex.Message)
        Finally
            Me.Close()
        End Try
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Close()
    End Sub

End Class

Imports System.Data.SqlClient

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

        '       usu_login_VC.Text = Me.userName
        '      IdSalaAtual.Text = Me.idDaSala
    End Sub

    Friend Sub LoadEvent(currentRow As DataGridViewRow)
        '     usu_login_VC.Text = currentRow.Cells(userName).Value.ToString()
        '   IdSalaAtual.Text = currentRow.Cells(idDaSala).Value.ToString()
        '  DateTimePickerInicio.Value = Convert.ToDateTime(currentRow.Cells("reserva_data_hora_inicio").Value)


    End Sub

    Private Sub EventForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '   usu_login_VC.Text = usu_login_VC.Text.Replace(".", " ")

        Me.StartPosition = FormStartPosition.CenterScreen

        'Me.StartPosition = FormStartPosition.Manual
        'Me.Top = 400
        'Me.Left = 1200

        UtilsNeobetel.UtilGeral.carregaVisualComponente(Panel2)

        For hora As Integer = 8 To 18
            For minuto As Integer = 0 To 30 Step 30
                Dim time As DateTime = New DateTime(1, 1, 1, hora, minuto, 0)
                ComboBox1.Items.Add(time.ToString("HH:mm"))
            Next
        Next


        ComboBox1.Text = DateTimePickerInicio.Value.ToString("HH:mm")


        DateTimePickerInicio.Format = DateTimePickerFormat.Custom
        DateTimePickerInicio.CustomFormat = "dd/MMMM/yy "
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub DateTimePickerInicio_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerInicio.ValueChanged
        ComboBox1.Text = DateTimePickerInicio.Value.ToString("HH:mm")
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click

    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        Dim selectedTime As String = ComboBox1.SelectedItem.ToString()
        Dim selectedDateTime As DateTime = DateTimePickerInicio.Value.Date.Add(TimeSpan.Parse(selectedTime))
        DateTimePickerInicio.Value = selectedDateTime
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Dim reservaUsuarioId As Integer
        Try
            reservaUsuarioId = conexao.ObterUsuarioId(userName)
        Catch ex As Exception
            MessageBox.Show("Erro ao obter o ID do usuário! " & ex.Message)
            Return
        End Try


        Dim result As DialogResult = MessageBox.Show("Tem certeza que deseja excluir todas as suas reservas para esta sala no horário especificado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            Return
        End If

        Dim reservaDataHora As DateTime = DateTimePickerInicio.Value


        Dim parametros As New List(Of SqlParameter)()
        parametros.Add(New SqlParameter("@reserva_usuario_id", reservaUsuarioId))
        parametros.Add(New SqlParameter("@reserva_sala_id", Me.idDaSala))
        parametros.Add(New SqlParameter("@reserva_data_hora_inicio", reservaDataHora))

        Try
            conexao.ExecutarConsulta(CommandType.StoredProcedure, "usp_ExcluirReservasPorUsuarioSalaEData", parametros)


            MessageBox.Show("Reservas na sala especificada foram excluídas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir as reservas! " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Me.Close()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Close()
    End Sub
End Class

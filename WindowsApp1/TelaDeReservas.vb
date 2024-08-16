﻿Imports System.Data.SqlClient
Imports DocumentFormat.OpenXml.Spreadsheet
Imports FontAwesome.Sharp

Public Class TelaDeReservas

    Private conexao As ConexaoComOBancoDeDados
    Private currentStartDate As DateTime
    Private username As String
    Private password As String
    Private formAberto As Boolean
    Private idDaSala As Integer
    Private idDaEmpresa As Integer
    Private selectedDate As Object

    Public Sub New(username As String, password As String)
        InitializeComponent()
        Me.username = username
        Me.password = password
        conexao = New ConexaoComOBancoDeDados()
        conexao.ConectarComBanco(username, password)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen

        'Me.StartPosition = FormStartPosition.Manual
        'Me.Location = New Point(500, 400)

        Try
            If conexao Is Nothing Then
                Throw New InvalidOperationException("Conexão não inicializada.")
            End If

            CarregarEmpresas()
            formAberto = False
            AtualizarSemana(MonthCalendar1.SelectionStart)

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar empresas: " & ex.Message)
        End Try



    End Sub

    Private Sub CarregarEmpresas()
        Dim parametros As New List(Of SqlParameter) From {
            New SqlParameter("@empresaspermitidas_BT", True)
        }

        Dim dataTable As DataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "usp_SelecionarEmpresas", parametros)

        If dataTable Is Nothing OrElse dataTable.Rows.Count = 0 Then
            Throw New InvalidOperationException("Falha ao carregar dados do banco de dados.")
        End If

        SelecaoDeEmpresa.DataSource = dataTable
        SelecaoDeEmpresa.DisplayMember = "emp_fantasia_VC"
    End Sub

    Private Sub CarregarReservasDaSemana(data As DateTime)
        Try
            If conexao Is Nothing Then
                Throw New InvalidOperationException("Conexão não inicializada.")
            End If

            Dim parametros As New List(Of SqlParameter) From {
                New SqlParameter("@Data_DT", data),
                New SqlParameter("@Sala_IN", idDaSala)
            }

            Dim dataTable As DataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "usp_SelecionarReservasDaSemanaPorData", parametros)

            If dataTable Is Nothing OrElse dataTable.Rows.Count = 0 Then
                Throw New InvalidOperationException("Falha ao carregar dados do banco de dados.")
            End If

            dgvGridReserva.AutoGenerateColumns = False
            dgvGridReserva.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar reservas da semana: " & ex.Message)
        End Try


        dgvGridReserva.Columns(0).DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgvGridReserva.Columns(1).DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgvGridReserva.Columns(2).DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgvGridReserva.Columns(3).DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgvGridReserva.Columns(4).DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgvGridReserva.Columns(5).DefaultCellStyle.WrapMode = DataGridViewTriState.True

        dgvGridReserva.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgvGridReserva.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvGridReserva.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells



    End Sub

    Private Sub SelecaoDeEmpresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SelecaoDeEmpresa.SelectedIndexChanged
        If SelecaoDeEmpresa.SelectedIndex = -1 Then Return

        Try
            Dim selectedRow As DataRowView = CType(SelecaoDeEmpresa.SelectedItem, DataRowView)
            idDaEmpresa = Convert.ToInt32(selectedRow("emp_empresa_IN"))
            CarregarSalas(idDaEmpresa)

        Catch ex As Exception
            MessageBox.Show("Erro ao selecionar empresa: " & ex.Message)
        End Try
    End Sub

    Private Sub CarregarSalas(empId As Integer)
        SelecaoDeSalas.DataSource = Nothing
        SelecaoDeSalas.Items.Clear()

        Dim parametros As New List(Of SqlParameter) From {
            New SqlParameter("@emp_empresa_IN", empId)
        }

        Dim dataTable As DataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "usp_SelecionarSalasPorEmpresa", parametros)

        If dataTable Is Nothing OrElse dataTable.Rows.Count = 0 Then

            Exit Sub
        End If

        SelecaoDeSalas.DataSource = dataTable
        SelecaoDeSalas.DisplayMember = "sala_nome"

    End Sub

    Private Sub SelecaoDeSalas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SelecaoDeSalas.SelectedIndexChanged
        If SelecaoDeSalas.SelectedIndex = -1 Then Return

        idDaSala = Convert.ToInt32(SelecaoDeSalas.SelectedValue(0))
        CarregarReservasDaSemana(currentStartDate)
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        AtualizarSemana(MonthCalendar1.SelectionStart)
    End Sub

    Private Sub AtualizarSemana(selectedDate As DateTime)


        Dim dayOfWeek As Integer = CInt(selectedDate.DayOfWeek)
        Dim startOfWeek As DateTime = selectedDate.AddDays(-dayOfWeek + If(dayOfWeek = 0, -6, 1))
        Dim endOfWeek As DateTime = startOfWeek.AddDays(6)

        Label1.Text = "Semana de " & startOfWeek.ToString("dd/MM") & " a " & endOfWeek.ToString("dd/MM")
        currentStartDate = startOfWeek
        CarregarReservasDaSemana(currentStartDate)

        ' Atualizar os cabeçalhos com os dias da semana e datas
        dgvGridReserva.Columns(1).HeaderText = "Segunda " & startOfWeek.ToString("dd/MM")
        dgvGridReserva.Columns(2).HeaderText = "Terça " & startOfWeek.AddDays(1).ToString("dd/MM")
        dgvGridReserva.Columns(3).HeaderText = "Quarta " & startOfWeek.AddDays(2).ToString("dd/MM")
        dgvGridReserva.Columns(4).HeaderText = "Quinta " & startOfWeek.AddDays(3).ToString("dd/MM")
        dgvGridReserva.Columns(5).HeaderText = "Sexta " & startOfWeek.AddDays(4).ToString("dd/MM")


    End Sub
    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        If Not formAberto Then
            CarregarReservasDaSemana(DateTime.Now())
        End If

    End Sub

    Private Sub Agendar_Click(sender As Object, e As EventArgs) Handles Agendar.Click

        Dim eventForm As New TelaDeAgendamento(Me.username, Me.password, Me.idDaSala)

        eventForm.Show()
    End Sub

    Private Sub Excluir_Reserva_Click(sender As Object, e As EventArgs) Handles Excluir_Reserva.Click


        Dim eventForm As New TelaDeAlteracao(Me.username, Me.password, Me.idDaSala)


        eventForm.Show()


    End Sub


    Private Sub dgvGridReserva_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGridReserva.CellClick

        If e.RowIndex >= 0 And e.ColumnIndex > 0 Then
            ' Obter a data e hora da célula clicada
            Dim horario As String = dgvGridReserva.Rows(e.RowIndex).Cells(0).Value.ToString()
            Dim diaDaSemana As String = dgvGridReserva.Columns(e.ColumnIndex).HeaderText

            ' Extrair a data do cabeçalho da coluna (assumindo que está no formato "Dia DD/MM")
            Dim dataTexto As String = diaDaSemana.Split(" "c)(1)
            Dim data As DateTime = DateTime.ParseExact(dataTexto, "dd/MM", Nothing)

            ' Combinar a data e o horário
            Dim dataHoraInicio As DateTime = DateTime.Parse($"{data.ToString("yyyy-MM-dd")} {horario.Split(" "c)(0)}")
            Dim dataHoraFim As DateTime = DateTime.Parse($"{data.ToString("yyyy-MM-dd")} {horario.Split(" "c)(2)}")

            ' Consultar o banco de dados para obter os detalhes da reserva
            Dim parametros As New List(Of SqlParameter) From {
                New SqlParameter("@Sala_IN", idDaSala),
                New SqlParameter("@DataHoraInicio", dataHoraInicio),
                New SqlParameter("@DataHoraFim", dataHoraFim)
            }

            Dim dataTable As DataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "usp_SelecionarDetalhesReserva", parametros)

            If dataTable IsNot Nothing AndAlso dataTable.Rows.Count > 0 Then
                ' Exibir os detalhes da reserva no formulário
                Dim detalhesReserva As DataRow = dataTable.Rows(0)
                GroupBox4.Text = "Detalhes da Reserva"
                lblUsuarioNome.Text = detalhesReserva("reserva_usuario_nome").ToString()
                lblReservadoEm.Text = detalhesReserva("data_reservado").ToString()
                lblDataHoraInicio.Text = detalhesReserva("reserva_data_hora_inicio").ToString()
                lblDataHoraFim.Text = detalhesReserva("reserva_data_hora_fim").ToString()
                lblEvento.Text = detalhesReserva("reserva_evento").ToString()
            Else
                MessageBox.Show("Nenhuma reserva encontrada para o horário selecionado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

    End Sub


    Private Sub dgvGridReserva_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGridReserva.CellDoubleClick

    End Sub
End Class
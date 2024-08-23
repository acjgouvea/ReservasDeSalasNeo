Imports System.Data.SqlClient
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
    'Private WithEvents timerEsconderPainel As New Timer

    Public Sub New(username As String, password As String)
        InitializeComponent()
        Me.username = username
        Me.password = password
        conexao = New ConexaoComOBancoDeDados()
        conexao.ConectarComBanco(username, password)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SelecaoDeEmpresa.DropDownStyle = ComboBoxStyle.DropDownList
        SelecaoDeSalas.DropDownStyle = ComboBoxStyle.DropDownList


        dgvGridReserva.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgvGridReserva.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvGridReserva.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        dgvGridReserva.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells)
        Me.StartPosition = FormStartPosition.CenterScreen
        dgvGridReserva.ColumnHeadersHeight = 40

        dgvGridReserva.RowTemplate.Height = 15

        Me.StartPosition = FormStartPosition.CenterScreen

        ' Me.Location = New Point(300, 100)

        dgvGridReserva.ReadOnly = True

        Try
            If conexao Is Nothing Then
                Throw New InvalidOperationException("Conexão não inicializada.")
            End If

            CarregarEmpresas()
            formAberto = False
            AtualizarSemana(MonthCalendar1.SelectionStart)
            EstilizarGrid()
            AjustarLarguraDasColunas()



            UtilsNeobetel.UtilGeral.carregaVisualComponente(pnlDetalhesReserva)
            UtilsNeobetel.UtilGeral.carregaVisualComponente(Panel1)
            UtilsNeobetel.UtilGeral.carregaVisualComponente(Panel2)
            UtilsNeobetel.UtilGeral.carregaVisualComponente(Panel3)



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

            AjustarLarguraDasColunas()


            'dgvGridReserva.Columns(1).Width = 300
            dgvGridReserva.ColumnHeadersHeight = 40


            dgvGridReserva.RowTemplate.Height = 15

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
        EstilizarGrid()




    End Sub

    Private Sub SelecaoDeSalas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SelecaoDeSalas.SelectedIndexChanged


        If SelecaoDeSalas.SelectedIndex = -1 Then Return

        idDaSala = Convert.ToInt32(SelecaoDeSalas.SelectedValue(0))
        Label6.Text = "SALA ATUAL - " & SelecaoDeSalas.Text
        CarregarReservasDaSemana(currentStartDate)
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        AtualizarSemana(MonthCalendar1.SelectionStart)
    End Sub

    Private Sub AtualizarSemana(selectedDate As DateTime)


        Dim dayOfWeek As Integer = CInt(selectedDate.DayOfWeek)
        Dim startOfWeek As DateTime = selectedDate.AddDays(-dayOfWeek + If(dayOfWeek = 0, -6, 1))
        Dim endOfWeek As DateTime = startOfWeek.AddDays(6)

        'Label1.Text = "Semana de " & startOfWeek.ToString("dd/MM") & " a " & endOfWeek.ToString("dd/MM")
        currentStartDate = startOfWeek
        CarregarReservasDaSemana(currentStartDate)

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

    'Public Sub New()
    '    InitializeComponent()

    '    timerEsconderPainel.Interval = 7000
    'End Sub



    Private Sub dgvGridReserva_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGridReserva.CellClick

        Try
            pnlDetalhesReserva.Visible = True

            If e.RowIndex >= 0 And e.ColumnIndex > 0 Then
                'Dim horario As String = dgvGridReserva.Rows(e.RowIndex).Cells(0).Value.ToString()
                Dim horario As String = dgvGridReserva.Rows(e.RowIndex).Cells(6).Value.ToString()
                Dim diaDaSemana As String = dgvGridReserva.Columns(e.ColumnIndex).HeaderText

                ' Tente extrair a data do cabeçalho
                Dim dataTexto As String
                Try
                    dataTexto = diaDaSemana.Split(" "c)(1)
                Catch ex As Exception
                    MessageBox.Show("Formato do cabeçalho inesperado. Verifique o formato de data.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try

                ' Converte a data
                Dim data As DateTime
                Try
                    data = DateTime.ParseExact(dataTexto, "dd/MM", Nothing)
                Catch ex As Exception
                    MessageBox.Show("Erro ao converter a data. Verifique o formato.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try

                'Dim dataHoraInicio As DateTime = DateTime.Parse($"{data.ToString("yyyy-MM-dd")} {horario.Split(" "c)(0)}")
                'Dim dataHoraFim As DateTime = DateTime.Parse($"{data.ToString("yyyy-MM-dd")} {horario.Split(" "c)(2)}")
                Dim dataHora As DateTime = DateTime.Parse($"{data.ToString("yyyy-MM-dd")} {horario.ToString()}")

                Dim parametros As New List(Of SqlParameter) From {
                    New SqlParameter("@Sala_IN", idDaSala),
                    New SqlParameter("@DataHora", dataHora)
                }

                Dim dataTable As DataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "usp_SelecionarDetalhesReserva", parametros)

                If dataTable IsNot Nothing AndAlso dataTable.Rows.Count > 0 Then
                    Dim detalhesReserva As DataRow = dataTable.Rows(0)

                    lblUsuarioNome.Text = detalhesReserva("reserva_usuario_nome").ToString()
                    lblReservadoEm.Text = Convert.ToDateTime(detalhesReserva("data_reservado")).ToString("dd/MM/yy HH:mm")
                    lblDataHoraInicio.Text = Convert.ToDateTime(detalhesReserva("reserva_data_hora_inicio")).ToString("dd/MM/yy HH:mm")
                    lblDataHoraFim.Text = Convert.ToDateTime(detalhesReserva("reserva_data_hora_fim")).ToString("dd/MM/yy HH:mm")
                    lblEvento.Text = detalhesReserva("reserva_evento").ToString()
                Else
                    '    MessageBox.Show("Nenhuma reserva encontrada para o horário selecionado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    lblUsuarioNome.Text = ""
                    lblReservadoEm.Text = ""
                    lblDataHoraInicio.Text = ""
                    lblDataHoraFim.Text = ""
                    lblEvento.Text = ""
                    pnlDetalhesReserva.Visible = False
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dgvGridReserva_SelectionChanged(sender As Object, e As EventArgs) Handles dgvGridReserva.SelectionChanged
        'Try
        'pnlDetalhesReserva.Visible = True

        '    ' Verificar se há células selecionadas
        '    If dgvGridReserva.SelectedCells.Count > 0 Then
        '        ' Iterar por todas as células selecionadas
        '        For Each cell As DataGridViewCell In dgvGridReserva.SelectedCells
        '            If cell.RowIndex >= 0 And cell.ColumnIndex > 0 Then
        '                Dim horarioCell = dgvGridReserva.Rows(cell.RowIndex).Cells(0).Value

        '                ' Verifica se a célula de horário está vazia ou nula
        '                If horarioCell Is Nothing OrElse String.IsNullOrWhiteSpace(horarioCell.ToString()) Then
        '                    Continue For ' Pula para a próxima célula se esta estiver vazia
        '                End If

        '                Dim horario As String = horarioCell.ToString()
        '                Dim diaDaSemana As String = dgvGridReserva.Columns(cell.ColumnIndex).HeaderText

        '                ' Tente extrair a data do cabeçalho
        '                Dim dataTexto As String
        '                Try
        '                    dataTexto = diaDaSemana.Split(" "c)(1)
        '                Catch ex As Exception
        '                    MessageBox.Show("Formato do cabeçalho inesperado. Verifique o formato de data.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '                    Exit Sub
        '                End Try

        '                ' Converte a data
        '                Dim data As DateTime
        '                Try
        '                    data = DateTime.ParseExact(dataTexto, "dd/MM", Nothing)
        '                Catch ex As Exception
        '                    MessageBox.Show("Erro ao converter a data. Verifique o formato.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '                    Exit Sub
        '                End Try

        '                Dim dataHoraInicio As DateTime = DateTime.Parse($"{data.ToString("yyyy-MM-dd")} {horario.Split(" "c)(0)}")
        '                Dim dataHoraFim As DateTime = DateTime.Parse($"{data.ToString("yyyy-MM-dd")} {horario.Split(" "c)(2)}")

        '                Dim parametros As New List(Of SqlParameter) From {
        '                New SqlParameter("@Sala_IN", idDaSala),
        '                New SqlParameter("@DataHoraInicio", dataHoraInicio),
        '                New SqlParameter("@DataHoraFim", dataHoraFim)
        '            }

        '                Dim dataTable As DataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "usp_SelecionarDetalhesReserva", parametros)

        '                If dataTable IsNot Nothing AndAlso dataTable.Rows.Count > 0 Then
        '                    Dim detalhesReserva As DataRow = dataTable.Rows(0)

        '                    lblUsuarioNome.Text = detalhesReserva("reserva_usuario_nome").ToString()
        '                    lblReservadoEm.Text = Convert.ToDateTime(detalhesReserva("data_reservado")).ToString("dd/MM/yy HH:mm")
        '                    lblDataHoraInicio.Text = Convert.ToDateTime(detalhesReserva("reserva_data_hora_inicio")).ToString("dd/MM/yy HH:mm")
        '                    lblDataHoraFim.Text = Convert.ToDateTime(detalhesReserva("reserva_data_hora_fim")).ToString("dd/MM/yy HH:mm")
        '                    lblEvento.Text = detalhesReserva("reserva_evento").ToString()
        '                Else
        '                    ' Nenhuma reserva encontrada para a célula selecionada
        '                    'MessageBox.Show($"Nenhuma reserva encontrada para o horário: {horario} no dia: {diaDaSemana}.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '                End If
        '            End If
        '        Next
        '    End If

        'Catch ex As Exception
        '    MessageBox.Show("Ocorreu um erro: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

    End Sub


    'Private Sub timerEsconderPainel_Tick(sender As Object, e As EventArgs) Handles timerEsconderPainel.Tick

    '    ' Esconde o painel e para o Timer
    '    pnlDetalhesReserva.Visible = False
    '    timerEsconderPainel.Stop()
    'End Sub
    Private Sub pnlDetalhesReserva_Paint(sender As Object, e As PaintEventArgs) Handles pnlDetalhesReserva.Paint

    End Sub


    Private Sub EstilizarGrid()
        ' Definir fonte para as células e cabeçalhos
        dgvGridReserva.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI Semiboldl", 8, FontStyle.Regular)
        dgvGridReserva.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 10, FontStyle.Bold)
        dgvGridReserva.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        ' Cor de fundo para o cabeçalho
        dgvGridReserva.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 29, 63)
        dgvGridReserva.EnableHeadersVisualStyles = False

        ' Cor do texto no cabeçalho
        dgvGridReserva.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(246, 186, 16)


        ' Cor do texto para as células
        dgvGridReserva.DefaultCellStyle.ForeColor = System.Drawing.Color.Black

        ' Cor de fundo padrão para todas as células
        dgvGridReserva.DefaultCellStyle.BackColor = System.Drawing.Color.White

        ' Cor do grid
        dgvGridReserva.GridColor = System.Drawing.Color.LightGray

        ' Alterar cor de fundo para a primeira coluna
        dgvGridReserva.Columns(0).DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 29, 63)

        ' Alterar cor de texto para a primeira coluna, se necessário
        dgvGridReserva.Columns(0).DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(246, 186, 16)

    End Sub

    'Private Sub dgvGridReserva_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
    '    ' Verifica se estamos formatando uma linha alternada (índice de linha ímpar)
    '    If e.RowIndex Mod 2 = 1 AndAlso e.ColumnIndex > 0 Then
    '        e.CellStyle.BackColor = System.Drawing.Color.LightGray

    '    End If


    '  End Sub

    Private Sub dgvGridReserva_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvGridReserva.CellFormatting
        ' Verifica se estamos formatando uma linha alternada (índice de linha ímpar)
        If e.RowIndex Mod 2 = 1 AndAlso e.ColumnIndex > 0 Then
            e.CellStyle.BackColor = System.Drawing.Color.LightGray
        End If


        If e.CellStyle.Font Is Nothing Then
            e.CellStyle.Font = dgvGridReserva.DefaultCellStyle.Font
        End If

    End Sub

    Private Sub AjustarLarguraDasColunas()
        '' Definir largura mínima e máxima para todas as colunas
        'For Each col As DataGridViewColumn In dgvGridReserva.Columns
        '    col.MinimumWidth = 170
        '    col.Width = 170
        '    'col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        '    col.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        'Next

        ' Desativar temporariamente o ajuste automático para garantir que as larguras definidas sejam aplicadas corretamente
        dgvGridReserva.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

        ' Configura a largura mínima e a largura desejada para todas as colunas e permite quebra de linha
        For Each col As DataGridViewColumn In dgvGridReserva.Columns
            col.MinimumWidth = 170
            col.Width = 170
            col.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Next

        ' Reativar o ajuste automático de largura das colunas e das linhas
        dgvGridReserva.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvGridReserva.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvGridReserva.DefaultCellStyle.WrapMode = DataGridViewTriState.True

        ' Garantir que a altura das linhas seja ajustada corretamente
        dgvGridReserva.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells)

        dgvGridReserva.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvGridReserva.Columns(0).Width = 90
    End Sub


    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click

        Dim eventForm As New TelaDeAgendamento(Me.username, Me.password, Me.idDaSala)

        eventForm.Show()
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click

        Dim eventForm As New TelaDeAlteracao(Me.username, Me.password, Me.idDaSala)

        eventForm.Show()
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        Me.Close()
    End Sub





    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        Me.Close()
    End Sub

    Private Sub dgvGridReserva_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGridReserva.CellContentClick

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class
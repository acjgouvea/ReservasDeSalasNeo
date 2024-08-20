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

    Public Sub New(username As String, password As String)
        InitializeComponent()
        Me.username = username
        Me.password = password
        conexao = New ConexaoComOBancoDeDados()
        conexao.ConectarComBanco(username, password)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Me.StartPosition = FormStartPosition.CenterScreen
        dgvGridReserva.ColumnHeadersHeight = 40

        dgvGridReserva.RowTemplate.Height = 15

        'Me.StartPosition = FormStartPosition.Manual
        'Me.Location = New Point(500, 400)

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
            'UtilsNeobetel.UtilGeral.carregaVisualComponente(dgvGridReserva)

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
    Private Sub dgvGridReserva_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGridReserva.CellClick

        If e.RowIndex >= 0 And e.ColumnIndex > 0 Then

            Dim horario As String = dgvGridReserva.Rows(e.RowIndex).Cells(0).Value.ToString()
            Dim diaDaSemana As String = dgvGridReserva.Columns(e.ColumnIndex).HeaderText


            Dim dataTexto As String = diaDaSemana.Split(" "c)(1)
            Dim data As DateTime = DateTime.ParseExact(dataTexto, "dd/MM", Nothing)


            Dim dataHoraInicio As DateTime = DateTime.Parse($"{data.ToString("yyyy-MM-dd")} {horario.Split(" "c)(0)}")
            Dim dataHoraFim As DateTime = DateTime.Parse($"{data.ToString("yyyy-MM-dd")} {horario.Split(" "c)(2)}")


            Dim parametros As New List(Of SqlParameter) From {
                New SqlParameter("@Sala_IN", idDaSala),
                New SqlParameter("@DataHoraInicio", dataHoraInicio),
                New SqlParameter("@DataHoraFim", dataHoraFim)
            }

            Dim dataTable As DataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "usp_SelecionarDetalhesReserva", parametros)

            If dataTable IsNot Nothing AndAlso dataTable.Rows.Count > 0 Then

                Dim detalhesReserva As DataRow = dataTable.Rows(0)

                'GroupBox4.Text = "Detalhes da Reserva"
                lblUsuarioNome.Text = detalhesReserva("reserva_usuario_nome").ToString()
                lblReservadoEm.Text = Convert.ToDateTime(detalhesReserva("data_reservado")).ToString("dd/MM/yy HH:mm")
                lblDataHoraInicio.Text = Convert.ToDateTime(detalhesReserva("reserva_data_hora_inicio")).ToString("dd/MM/yy HH:mm")
                lblDataHoraFim.Text = Convert.ToDateTime(detalhesReserva("reserva_data_hora_fim")).ToString("dd/MM/yy HH:mm")
                lblEvento.Text = detalhesReserva("reserva_evento").ToString()
            Else
                MessageBox.Show("Nenhuma reserva encontrada para o horário selecionado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

    End Sub




    Private Sub EstilizarGrid()
        ' Definir fonte para as células e cabeçalhos
        dgvGridReserva.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI Semiboldl", 10, FontStyle.Regular)
        dgvGridReserva.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 12, FontStyle.Bold)

        ' Cor de fundo para o cabeçalho
        dgvGridReserva.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 29, 63)
        dgvGridReserva.EnableHeadersVisualStyles = False

        ' Cor do texto no cabeçalho
        dgvGridReserva.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(246, 186, 16)

        ' Cor de fundo alternada para as linhas
        'dgvGridReserva.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.

        ' Cor do texto para as células
        dgvGridReserva.DefaultCellStyle.ForeColor = System.Drawing.Color.Black

        ' Cor de fundo padrão para todas as células
        dgvGridReserva.DefaultCellStyle.BackColor = System.Drawing.Color.White

        ' Cor do grid
        dgvGridReserva.GridColor = System.Drawing.Color.Gray

        ' Alterar cor de fundo para a primeira coluna
        dgvGridReserva.Columns(0).DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 29, 63)

        ' Alterar cor de texto para a primeira coluna, se necessário
        dgvGridReserva.Columns(0).DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(246, 186, 16)

    End Sub

    Private Sub AjustarLarguraDasColunas()
        ' Definir largura mínima e máxima para todas as colunas
        For Each col As DataGridViewColumn In dgvGridReserva.Columns
            col.MinimumWidth = 170
            col.Width = 170
            'col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            col.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Next
    End Sub


    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click

        Dim eventForm As New TelaDeAgendamento(Me.username, Me.password, Me.idDaSala)

        eventForm.Show()
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click

        Dim eventForm As New TelaDeAlteracao(Me.username, Me.password, Me.idDaSala)

        eventForm.Show()
    End Sub

End Class
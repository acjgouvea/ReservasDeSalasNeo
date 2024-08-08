Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports FontAwesome.Sharp

Public Class Form1

    Private conexao As ConexaoComOBancoDeDados
    Private currentStartDate As DateTime
    Private username As String
    Private password As String
    Public formAberto As Boolean
    Public idDaSala As Integer
    Public idDaEmpresa As Integer

    Public Sub New(username As String, password As String)
        InitializeComponent()
        Me.username = username
        Me.password = password
        conexao = New ConexaoComOBancoDeDados()
        conexao.ConectarComBanco(username, password)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If conexao Is Nothing Then
                Throw New InvalidOperationException("Conexão não inicializada.")
            End If

            Dim parametros As New List(Of SqlParameter)()
            parametros.Add(New SqlParameter("@empresaspermitidas_BT", True))

            ' Carregar a lista de empresas no ComboBox2
            Dim dataTable As DataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "usp_SelecionarEmpresas", parametros)

            If dataTable Is Nothing OrElse dataTable.Rows.Count = 0 Then
                Throw New InvalidOperationException("Falha ao carregar dados do banco de dados.")
            End If

            SelecaoDeEmpresa.DataSource = dataTable
            SelecaoDeEmpresa.DisplayMember = "emp_fantasia_VC"
            SelecaoDeEmpresa.ValueMember = "emp_id"

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar empresas: " & ex.Message)
        End Try

        formAberto = False
        AtualizarSemana(MonthCalendar1.SelectionStart)
    End Sub

    Private Sub CarregarReservasDaSemana(data As DateTime)
        Try
            If conexao Is Nothing Then
                Throw New InvalidOperationException("Conexão não inicializada.")
            End If

            Dim parametros As New List(Of SqlParameter)()
            parametros.Add(New SqlParameter("@Data_DT", data))
            parametros.Add(New SqlParameter("@Sala_IN", idDaSala))

            Dim dataTable As DataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "usp_SelecionarReservasDaSemanaPorData", parametros)

            If dataTable Is Nothing OrElse dataTable.Rows.Count = 0 Then
                Throw New InvalidOperationException("Falha ao carregar dados do banco de dados.")
            End If

            dgvGridReserva.AutoGenerateColumns = False
            dgvGridReserva.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar reservas da semana: " & ex.Message)
        End Try
    End Sub

    Private Sub SelecaoDeEmpresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SelecaoDeEmpresa.SelectedIndexChanged
        If SelecaoDeEmpresa.SelectedIndex = -1 Then Return

        idDaEmpresa = Convert.ToInt32(SelecaoDeEmpresa.SelectedValue)
        SelecaoDeSalas.Items.Clear()

        Try
            Dim parametros As New List(Of SqlParameter)()
            parametros.Add(New SqlParameter("@emp_empresa_IN", idDaEmpresa))

            ' Carregar a lista de salas associadas à empresa selecionada no ComboBox1
            Dim dataTable As DataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "usp_SelecionarSalasPorEmpresa", parametros)

            If dataTable Is Nothing OrElse dataTable.Rows.Count = 0 Then
                Throw New InvalidOperationException("Falha ao carregar salas.")
            End If

            SelecaoDeSalas.DataSource = dataTable
            SelecaoDeSalas.DisplayMember = "sala_nome"
            SelecaoDeSalas.ValueMember = "sala_id"

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar salas: " & ex.Message)
        End Try
    End Sub

    Private Sub SelecaoDeSalas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SelecaoDeSalas.SelectedIndexChanged
        If SelecaoDeSalas.SelectedIndex = -1 Then Return

        idDaSala = Convert.ToInt32(SelecaoDeSalas.SelectedValue)
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
    End Sub

    Private Sub dgvGridReserva_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGridReserva.CellDoubleClick
        Dim eventForm As New EventForm(Me.username, Me.password, Me.idDaSala)
        eventForm.Show()
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If formAberto = False Then
            CarregarReservasDaSemana(DateTime.Now())
        End If
    End Sub

    Private Sub dgvGridReserva_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvGridReserva.CellMouseUp
        dgvGridReserva.SelectionMode = DataGridViewSelectionMode.CellSelect
        dgvGridReserva.MultiSelect = True

        CarregarReservasDaSemana(currentStartDate)
    End Sub

End Class

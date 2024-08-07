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

    Public Sub New(username As String, password As String)

        InitializeComponent()
        Me.username = username
        Me.password = password
        conexao = New ConexaoComOBancoDeDados()
        conexao.ConectarComBanco(username, password)

    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        formAberto = False
        ComboBox2.Items.AddRange(New String() {"NEOBETEL GRU", "NEOBETEL RJ", "NEOBETEL PE", "NEOBETEL MG", "NEOBETEL GO", "NEOBETEL ES", "NEOBETEL SP"})
        ComboBox1.Items.AddRange(New String() {"SALA 1 Financeiro", "SALA 2 Elevador", "SALA 3 3M - Treinamento", "SALA 4 MSA -Compras", "SALA 5 CT -Prédio Antigo"})
        AtualizarSemana(MonthCalendar1.SelectionStart)


    End Sub



    Private Sub CarregarReservasDaSemana(data As DateTime)
        Try
            ' Verifica se a conexão está inicializada
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
            MessageBox.Show("Erro ao carregar semana: " & ex.Message)
        End Try
    End Sub


    Private Sub ButtonPrevWeek_Click(sender As Object, e As EventArgs)
        currentStartDate = currentStartDate.AddDays(-7)
        CarregarReservasDaSemana(currentStartDate)
    End Sub

    Private Sub ButtonNextWeek_Click(sender As Object, e As EventArgs)
        currentStartDate = currentStartDate.AddDays(7)
        CarregarReservasDaSemana(currentStartDate)
    End Sub

    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        currentStartDate = e.Start
        CarregarReservasDaSemana(currentStartDate)
    End Sub

    Private Sub IconButton_Click(sender As Object, e As EventArgs)
        Dim eventForm As New EventForm(Me.username, Me.password)
        eventForm.Show()
    End Sub


    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGridReserva.CellDoubleClick
        Dim eventForm As New EventForm(Me.username, Me.password)
        eventForm.Show()

    End Sub


    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated


        If formAberto = False Then
            CarregarReservasDaSemana(DateTime.Now())
        End If
    End Sub


    'estou aqui configurando o selecionar 
    Private Sub dgvGridReserva_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvGridReserva.CellMouseClick

    End Sub



    Private Sub dgvGridReserva_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvGridReserva.CellMouseUp

        dgvGridReserva.SelectionMode = DataGridViewSelectionMode.CellSelect
        dgvGridReserva.MultiSelect = True

        ' Carregar reservas da semana atual
        currentStartDate = DateTime.Now
        CarregarReservasDaSemana(currentStartDate)
    End Sub

    Private Sub dgvGridReserva_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGridReserva.CellContentClick

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

        ' Obtém o texto do item selecionado
        Dim selectedItem As String = ComboBox2.SelectedItem.ToString()

        Select Case selectedItem
            Case "NEOBETEL GRU"
                ' Ação para NEOBETEL GRU
                MessageBox.Show("NEOBETEL GRU selecionado")

            Case "NEOBETEL RJ"
                ' Ação para NEOBETEL RJ
                MessageBox.Show("NEOBETEL RJ selecionado")

            Case "NEOBETEL PE"
                ' Ação para NEOBETEL PE
                MessageBox.Show("NEOBETEL PE selecionado")

            Case "NEOBETEL MG"
                ' Ação para NEOBETEL MG
                MessageBox.Show("NEOBETEL MG selecionado")

            Case "NEOBETEL GO"
                ' Ação para NEOBETEL GO
                MessageBox.Show("NEOBETEL GO selecionado")

            Case "NEOBETEL ES"
                ' Ação para NEOBETEL ES
                MessageBox.Show("NEOBETEL ES selecionado")

            Case "NEOBETEL SP"
                ' Ação para NEOBETEL SP
                MessageBox.Show("NEOBETEL SP selecionado")

            Case Else
                ' Ação padrão caso nenhuma opção corresponda
                MessageBox.Show("Seleção desconhecida")
        End Select
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim selectedItem As String = ComboBox1.SelectedItem.ToString()

        Select Case selectedItem
            Case "SALA 1 Financeiro"
                idDaSala = 1
                MessageBox.Show("SALA 1 Financeiro selecionada")
            Case "SALA 2 Elevador"
                idDaSala = 2
                MessageBox.Show("SALA 2 Elevador selecionada")
            Case "SALA 3 3M - Treinamento"
                idDaSala = 3
                MessageBox.Show("SALA 3 3M - Treinamento selecionada")
            Case "SALA 4 MSA -Compras"
                idDaSala = 4
                MessageBox.Show("SALA 4 MSA -Compras selecionada")
            Case "SALA 5 CT -Prédio Antigo"
                idDaSala = 5
                MessageBox.Show("SALA 5 CT -Prédio Antigo selecionada")
            Case Else
                MessageBox.Show("Seleção desconhecida")
        End Select
    End Sub



    Public Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged

        AtualizarSemana(MonthCalendar1.SelectionStart)
    End Sub
    Private Sub AtualizarSemana(selectedDate As DateTime)
        ' Calcula o dia da semana (0 = domingo, 1 = segunda, ..., 6 = sábado)
        Dim dayOfWeek As Integer = CInt(selectedDate.DayOfWeek)

        ' Calcula a data de início da semana (segunda-feira)
        ' Se for domingo (dayOfWeek = 0), subtrai 6 dias para obter a segunda-feira anterior, caso contrário, subtrai dayOfWeek - 1 dias.
        Dim startOfWeek As DateTime = selectedDate.AddDays(-dayOfWeek + If(dayOfWeek = 0, -6, 1))

        ' Calcula a data de fim da semana (domingo)
        Dim endOfWeek As DateTime = startOfWeek.AddDays(6)

        ' Mostra o intervalo da semana em um Label
        Label1.Text = "Semana de " & startOfWeek.ToString("dd/MM") & " a " & endOfWeek.ToString("dd/MM")
    End Sub


End Class

Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

<DebuggerDisplay("{GetDebuggerDisplay(),nq}")>
Public Class Form1

    Private conexao As ConexaoComOBancoDeDados
    Private currentStartDate As DateTime



    Public Sub New(username As String, password As String)

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        conexao = New ConexaoComOBancoDeDados()
        conexao.ConectarComBanco(username, password)


        ' Adicione qualquer inicialização após a chamada InitializeComponent().
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        currentStartDate = DateTime.Now
        CarregarReservasDaSemana(currentStartDate)

    End Sub

    Private Sub CarregarReservasDaSemana(data As DateTime)
        Try
            Dim parametros As New List(Of SqlParameter)()
            parametros.Add(New SqlParameter("@Data_DT", data))
            parametros.Add(New SqlParameter("@Sala_IN", 1))

            Dim dataTable As DataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "usp_SelecionarReservasDaSemanaPorData", parametros)

            'DataGridView1.DataSource = dataTable

            If Not dataTable.Columns.Contains("Horario") Then
                dataTable.Columns.Add("Horario", GetType(String))
            End If

            ' Popula a coluna "horario" com os valores de "HoraAprensentação_VC"
            For Each row As DataRow In dataTable.Rows
                row("Horario") = row("HoraApresentacao_VC")
            Next

            ' Cria uma nova tabela para reorganizar as colunas
            Dim newTable As New DataTable()
            newTable.Columns.Add("Horario", GetType(String))

            ' Copia os dados para a nova tabela
            For Each row As DataRow In dataTable.Rows
                Dim newRow As DataRow = newTable.NewRow()
                newRow("Horario") = row("Horario")
                newTable.Rows.Add(newRow)
            Next

            ' Define o DataSource do DataGridView para a nova tabela
            DataGridView1.DataSource = newTable

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar semana: " & ex.Message)
        End Try
    End Sub

    Private Function GetDataGridView1() As DataGridView
        Return DataGridView1
    End Function
    'Private Sub LoadCalendar()
    '    Dim startDate As DateTime = currentStartDate
    '    Dim endDate As DateTime = startDate.AddDays(6)

    '    Using conn As New SqlConnection(connString)
    '        Dim query As String = "SELECT * FROM sala_reserva WHERE reserva_data_hora_inicio BETWEEN @startDate AND @endDate"
    '        Using cmd As New SqlCommand(query, conn)
    '            cmd.Parameters.AddWithValue("@startDate", startDate)
    '            cmd.Parameters.AddWithValue("@endDate", endDate)

    '            Dim adapter As New SqlDataAdapter(cmd)
    '            Dim table As New DataTable()
    '            adapter.Fill(table)

    '            ' Adiciona a coluna do dia da semana na tabela
    '            If Not table.Columns.Contains("DiaDaSemana") Then
    '                table.Columns.Add("DiaDaSemana", GetType(String))
    '            End If

    '            For Each row As DataRow In table.Rows
    '                Dim data As DateTime = Convert.ToDateTime(row("reserva_data_hora_inicio"))
    '                row("DiaDaSemana") = data.ToString("dddd", New Globalization.CultureInfo("pt-BR"))
    '            Next

    '            DataGridView1.DataSource = table
    '        End Using
    '    End Using
    'End Sub



    'Private Sub LoadCalendar(dataGridView1 As DataGridView)
    '    Dim startDate As DateTime = currentStartDate
    '    Dim endDate As DateTime = startDate.AddDays(6)

    '    Using conn As New SqlConnection(conexao)
    '        Dim query As String = "SELECT * FROM sala_reserva WHERE reserva_data_hora_inicio BETWEEN @startDate AND @endDate"
    '        Using cmd As New SqlCommand(query, conn)
    '            cmd.Parameters.AddWithValue("@startDate", startDate)
    '            cmd.Parameters.AddWithValue("@endDate", endDate)

    '            Dim adapter As New SqlDataAdapter(cmd)
    '            Dim table As New DataTable()
    '            adapter.Fill(table)
    '            dataGridView1.DataSource = table
    '        End Using
    '    End Using
    'End Sub

    'Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click

    '    Dim form As New EventForm()

    '    If form.ShowDialog() = DialogResult.OK Then
    '        LoadCalendar(GetDataGridView1())

    '    End If

    'End Sub

    'Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
    '    If DataGridView1.CurrentRow IsNot Nothing Then
    '        Dim form As New EventForm()
    '        form.LoadEvent(DataGridView1.CurrentRow)
    '        If form.ShowDialog() = DialogResult.OK Then
    '            LoadCalendar(GetDataGridView1())
    '        End If
    '    End If
    'End Sub

    ''Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
    ''    If DataGridView1.CurrentRow IsNot Nothing Then
    ''        Dim reservaId As Integer = Convert.ToInt32(DataGridView1.CurrentRow.Cells("reserva_id").Value)

    ''        Using conn As New SqlConnection(conexao)
    ''            Using cmd As New SqlCommand("sp_ExcluirReserva", conn)
    ''                cmd.CommandType = CommandType.StoredProcedure
    ''                cmd.Parameters.AddWithValue("@reserva_id", reservaId)
    ''                conn.Open()
    ''                cmd.ExecuteNonQuery()
    ''            End Using
    ''        End Using

    ''        LoadCalendar(GetDataGridView1())
    ''    End If
    ''End Sub

    Private Sub ButtonPrevWeek_Click(sender As Object, e As EventArgs) Handles ButtonPrevWeek.Click
        currentStartDate = currentStartDate.AddDays(-7)
        CarregarReservasDaSemana(currentStartDate)
    End Sub

    Private Sub ButtonNextWeek_Click(sender As Object, e As EventArgs) Handles ButtonNextWeek.Click
        currentStartDate = currentStartDate.AddDays(7)
        CarregarReservasDaSemana(currentStartDate)
    End Sub

    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        currentStartDate = e.Start
        CarregarReservasDaSemana(currentStartDate)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Function GetDebuggerDisplay() As String
        Return ToString()
    End Function
End Class

Module Extensions
End Module

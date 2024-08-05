Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports FontAwesome.Sharp

Public Class Form1
    Private conexao As ConexaoComOBancoDeDados
    Private currentStartDate As DateTime
    Private username As String
    Private password As String

    Public Sub New(username As String, password As String)
        InitializeComponent()
        Me.username = username
        Me.password = password
        conexao = New ConexaoComOBancoDeDados()
        conexao.ConectarComBanco(username, password)
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Limpar colunas existentes
        DataGridView1.Columns.Clear()

        ' Adicionar colunas específicas ao DataGridView
        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn() With {
        .HeaderText = "Horário",
        .DataPropertyName = "HoraApresentacao_VC"
    })
        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn() With {
        .HeaderText = "Segunda-Feira",
        .DataPropertyName = "EventoSegunda_VC"
    })
        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn() With {
        .HeaderText = "Terça-Feira",
        .DataPropertyName = "EventoTerca_VC"
    })
        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn() With {
        .HeaderText = "Quarta-Feira",
        .DataPropertyName = "EventoQuarta_VC"
    })
        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn() With {
        .HeaderText = "Quinta-Feira",
        .DataPropertyName = "EventoQuinta_VC"
    })
        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn() With {
        .HeaderText = "Sexta-Feira",
        .DataPropertyName = "EventoSexta_VC"
    })

        ' Configurar o DataSource do DataGridView
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' Carregar reservas da semana atual
        currentStartDate = DateTime.Now
        CarregarReservasDaSemana(currentStartDate)
    End Sub



    Private Sub CarregarReservasDaSemana(data As DateTime)
        Try
            ' Verifica se a conexão está inicializada
            If conexao Is Nothing Then
                Throw New InvalidOperationException("Conexão não inicializada.")
            End If

            Dim parametros As New List(Of SqlParameter)()
            parametros.Add(New SqlParameter("@Data_DT", data))
            parametros.Add(New SqlParameter("@Sala_IN", 1))

            Dim dataTable As DataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "usp_SelecionarReservasDaSemanaPorData", parametros)

            If dataTable Is Nothing OrElse dataTable.Rows.Count = 0 Then
                Throw New InvalidOperationException("Falha ao carregar dados do banco de dados.")
            End If

            ' Configurar o DataGridView para preencher as colunas manualmente
            DataGridView1.Columns.Clear()

            DataGridView1.Columns.Add(New DataGridViewTextBoxColumn() With {
            .HeaderText = "Horário",
            .DataPropertyName = "HoraApresentacao_VC"
        })
            DataGridView1.Columns.Add(New DataGridViewTextBoxColumn() With {
            .HeaderText = "Segunda-Feira",
            .DataPropertyName = "IdSegunda_IN"
        })
            DataGridView1.Columns.Add(New DataGridViewTextBoxColumn() With {
            .HeaderText = "Teça-Feira",
            .DataPropertyName = "IdTerca_IN"
        })
            DataGridView1.Columns.Add(New DataGridViewTextBoxColumn() With {
            .HeaderText = "Quarta-Feira",
            .DataPropertyName = "IdSegunda_IN"
        })
            DataGridView1.Columns.Add(New DataGridViewTextBoxColumn() With {
            .HeaderText = "Quintaa-Feira",
            .DataPropertyName = "IdQuinta_IN"
        })
            DataGridView1.Columns.Add(New DataGridViewTextBoxColumn() With {
            .HeaderText = "Sexta-Feira",
            .DataPropertyName = "IdSexta_IN"
        })


            'Preenche o DataGridView com os dados
            For Each row As DataRow In dataTable.Rows
                DataGridView1.Rows.Add(
                row("HoraApresentacao_VC").ToString(),
                row("IdSegunda_IN").ToString(),
                row("IdTerca_IN").ToString(),
                row("IdQuarta_IN").ToString(),
                row("IdQuinta_IN").ToString(),
                row("IdSexta_IN").ToString()
                )
            Next
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar semana: " & ex.Message)
        End Try
    End Sub
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

    Private Sub IconButton_Click(sender As Object, e As EventArgs)
        Dim eventForm As New EventForm(Me.username, Me.password)
        eventForm.Show()
    End Sub


    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim eventForm As New EventForm(Me.username, Me.password)
        eventForm.Show()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class

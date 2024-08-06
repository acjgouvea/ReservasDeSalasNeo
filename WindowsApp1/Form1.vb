Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports FontAwesome.Sharp

Public Class Form1
    Private conexao As ConexaoComOBancoDeDados
    Private currentStartDate As DateTime
    Private username As String
    Private password As String
    Public formAberto As Boolean

    Public Sub New(username As String, password As String)
        InitializeComponent()
        Me.username = username
        Me.password = password
        conexao = New ConexaoComOBancoDeDados()
        conexao.ConectarComBanco(username, password)
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        formAberto = False


    End Sub



    Private Sub CarregarReservasDaSemana(data As DateTime)
        Try
            ' Verifica se a conexão está inicializada
            If conexao Is Nothing Then
                Throw New InvalidOperationException("Conexão não inicializada.")
            End If

            Dim parametros As New List(Of SqlParameter)()
            parametros.Add(New SqlParameter("@Data_DT", data))
            parametros.Add(New SqlParameter("@Sala_IN", 2))

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


    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGridReserva.CellDoubleClick
        Dim eventForm As New EventForm(Me.username, Me.password)
        eventForm.Show()

    End Sub


    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated


        If formAberto = False Then
            CarregarReservasDaSemana(DateTime.Now())
        End If
    End Sub
End Class

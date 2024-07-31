Imports System.Collections.ObjectModel
Imports System.Data.Common
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
        currentStartDate = DateTime.Now
        CarregarReservasDaSemana(currentStartDate)

        Dim iconButton As New IconButton()

        iconButton.IconFont = IconFont.Auto
        iconButton.Text = "Adicionar Reunião"
        iconButton.TextImageRelation = TextImageRelation.ImageBeforeText
        iconButton.Size = New Size(227, 33)
        iconButton.Location = New Point(768, 368) ' Define a posição do botão

        Me.Controls.Add(iconButton)
        AddHandler iconButton.Click, AddressOf Me.IconButton_Click
    End Sub

    Private Sub CarregarReservasDaSemana(data As DateTime)
        Try
            Dim parametros As New List(Of SqlParameter)()
            parametros.Add(New SqlParameter("@Data_DT", data))
            parametros.Add(New SqlParameter("@Sala_IN", 1))

            Dim dataTable As DataTable = conexao.ExecutarConsulta(CommandType.StoredProcedure, "usp_SelecionarReservasDaSemanaPorData", parametros)

            If Not dataTable.Columns.Contains("Horario") Then
                dataTable.Columns.Add("Horario", GetType(String))
            End If

            For Each row As DataRow In dataTable.Rows
                row("Horario") = row("HoraApresentacao_VC")
            Next

            Dim newTable As New DataTable()
            newTable.Columns.Add("Horario", GetType(String))

            For Each col As DataColumn In dataTable.Columns
                If col.ColumnName <> "Horario" Then
                    newTable.Columns.Add(col.ColumnName, col.DataType)
                End If
            Next

            DataGridView1.AutoGenerateColumns = True
            DataGridView1.DataSource = dataTable
            DataGridView1.Columns("Horario").DisplayIndex = 0

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
End Class

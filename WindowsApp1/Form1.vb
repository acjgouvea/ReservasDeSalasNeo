Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports System.Data.SqlClient
Imports FontAwesome.Sharp

Public Class Form1
    Private conexao As ConexaoComOBancoDeDados
    Private currentStartDate As DateTime

    Public Sub New(username As String, password As String)
        InitializeComponent()
        conexao = New ConexaoComOBancoDeDados()
        conexao.ConectarComBanco(username, password)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        currentStartDate = DateTime.Now

        CarregarReservasDaSemana(currentStartDate)

        'Dim iconButton As New IconButton()
        'iconButton.IconChar = IconChar.Plus
        'iconButton.IconColor = Color.Black
        'iconButton.IconFont = IconFont.Auto
        'iconButton.Text = "Adicionar Reserva"
        'iconButton.TextImageRelation = TextImageRelation.ImageBeforeText
        'iconButton.Size = New Size(150, 50)
        'iconButton.Location = New Point(10, 10)

        '' Adiciona o botão ao formulário e configura o evento de clique
        'AddHandler iconButton.Click, AddressOf Me.ButtonAdd_Click
        'Me.Controls.Add(iconButton)


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

            ' Adiciona as outras colunas
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

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click

        Dim iconButton As New IconButton()
        iconButton.IconChar = IconChar.Plus
        iconButton.IconColor = Color.Black
        iconButton.IconFont = IconFont.Auto
        iconButton.Text = "Adicionar"
        iconButton.TextImageRelation = TextImageRelation.ImageBeforeText
        iconButton.Size = New Size(100, 50)
        iconButton.Location = New Point(10, 70) ' Define a posição do botão

        ' Adiciona o botão ao formulário
        Me.Controls.Add(iconButton)

        ' Adiciona o evento de clique ao botão dinamicamente
        AddHandler iconButton.Click, AddressOf Me.IconButton_Click

    End Sub
End Class

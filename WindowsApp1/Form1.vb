Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel




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

            For Each row As DataRow In dataTable.Rows
                Dim newRow As DataRow = newTable.NewRow()
                newRow("Horario") = row("Horario")
                For Each col As DataColumn In dataTable.Columns
                    If col.ColumnName <> "Horario" Then
                        newRow(col.ColumnName) = row(col.ColumnName)
                    End If
                Next
                newTable.Rows.Add(newRow)
            Next

            DataGridView1.DataSource = newTable

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar semana: " & ex.Message)
        End Try
    End Sub

    Private Function GetDataGridView1() As DataGridView
        Return DataGridView1
    End Function
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



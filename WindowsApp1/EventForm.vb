Imports System.Data.SqlClient

Public Class EventForm
    Private conexao As ConexaoComOBancoDeDados
    Private username As String
    Private password As String

    Public Sub New(username As String, password As String)
        InitializeComponent()
        Me.username = username
        Me.password = password
        conexao = New ConexaoComOBancoDeDados()
        conexao.ConectarComBanco(username, password)
    End Sub

    Friend Sub LoadEvent(currentRow As DataGridViewRow)
        TextBoxUsuarioNome.Text = currentRow.Cells("reserva_usuario_nome").Value.ToString()
        DateTimePickerInicio.Value = Convert.ToDateTime(currentRow.Cells("reserva_data_hora_inicio").Value)
        DateTimePickerFim.Value = Convert.ToDateTime(currentRow.Cells("reserva_data_hora_fim").Value)
    End Sub

    Private Sub EventForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DateTimePickerInicio.Format = DateTimePickerFormat.Custom
        DateTimePickerInicio.CustomFormat = "dd/MM/yyyy HH:mm"

        DateTimePickerFim.Format = DateTimePickerFormat.Custom
        DateTimePickerFim.CustomFormat = "dd/MM/yyyy HH:mm"
    End Sub



    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click


        Dim parametros As New List(Of SqlParameter)()

        'estou aqui
        'tenho que passar  :    Data_DT e Sala_IN
        '                       parametros.Add(New SqlParameter("@Data_DT", data))
        '                       parametros.Add(New SqlParameter("@Sala_IN", salaId))


        parametros.Add(New SqlParameter("@Data_DT", 1))
        parametros.Add(New SqlParameter("@Sala_IN", 1))


        Try
            conexao.ExecutarConsulta(CommandType.StoredProcedure, "usp_ReservaInserir", parametros)
            Me.DialogResult = DialogResult.OK
        Catch ex As Exception
            MessageBox.Show("Erro ao salvar a reserva! " & ex.Message)
        End Try
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub
End Class

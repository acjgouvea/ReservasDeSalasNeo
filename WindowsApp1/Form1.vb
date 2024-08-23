Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

        Label1.Text = Form1.ActiveForm.Width.ToString() + " " + Form1.ActiveForm.Height.ToString()
    End Sub
End Class
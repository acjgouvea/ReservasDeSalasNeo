<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EventForm
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LabelUsuarioNome = New System.Windows.Forms.Label()
        Me.LabelDataInicio = New System.Windows.Forms.Label()
        Me.LabelDataFim = New System.Windows.Forms.Label()
        Me.TextBoxUsuarioNome = New System.Windows.Forms.TextBox()
        Me.DateTimePickerInicio = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerFim = New System.Windows.Forms.DateTimePicker()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelUsuarioNome
        '
        Me.LabelUsuarioNome.AutoSize = True
        Me.LabelUsuarioNome.Location = New System.Drawing.Point(42, 135)
        Me.LabelUsuarioNome.Name = "LabelUsuarioNome"
        Me.LabelUsuarioNome.Size = New System.Drawing.Size(89, 13)
        Me.LabelUsuarioNome.TabIndex = 1
        Me.LabelUsuarioNome.Text = "Nome do Usuario"
        '
        'LabelDataInicio
        '
        Me.LabelDataInicio.AutoSize = True
        Me.LabelDataInicio.Location = New System.Drawing.Point(42, 192)
        Me.LabelDataInicio.Name = "LabelDataInicio"
        Me.LabelDataInicio.Size = New System.Drawing.Size(108, 13)
        Me.LabelDataInicio.TabIndex = 2
        Me.LabelDataInicio.Text = "Data e Hora de Inicio"
        '
        'LabelDataFim
        '
        Me.LabelDataFim.AutoSize = True
        Me.LabelDataFim.Location = New System.Drawing.Point(42, 161)
        Me.LabelDataFim.Name = "LabelDataFim"
        Me.LabelDataFim.Size = New System.Drawing.Size(121, 13)
        Me.LabelDataFim.TabIndex = 3
        Me.LabelDataFim.Text = "Data e Hora de Termino"
        '
        'TextBoxUsuarioNome
        '
        Me.TextBoxUsuarioNome.Location = New System.Drawing.Point(45, 99)
        Me.TextBoxUsuarioNome.Name = "TextBoxUsuarioNome"
        Me.TextBoxUsuarioNome.Size = New System.Drawing.Size(271, 20)
        Me.TextBoxUsuarioNome.TabIndex = 4
        '
        'DateTimePickerInicio
        '
        Me.DateTimePickerInicio.Location = New System.Drawing.Point(45, 32)
        Me.DateTimePickerInicio.Name = "DateTimePickerInicio"
        Me.DateTimePickerInicio.Size = New System.Drawing.Size(271, 20)
        Me.DateTimePickerInicio.TabIndex = 5
        '
        'DateTimePickerFim
        '
        Me.DateTimePickerFim.Location = New System.Drawing.Point(45, 58)
        Me.DateTimePickerFim.Name = "DateTimePickerFim"
        Me.DateTimePickerFim.Size = New System.Drawing.Size(271, 20)
        Me.DateTimePickerFim.TabIndex = 6
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(45, 243)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSave.TabIndex = 7
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(126, 243)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 8
        Me.ButtonCancel.Text = "Cancelar"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'EventForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 301)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.DateTimePickerFim)
        Me.Controls.Add(Me.DateTimePickerInicio)
        Me.Controls.Add(Me.TextBoxUsuarioNome)
        Me.Controls.Add(Me.LabelDataFim)
        Me.Controls.Add(Me.LabelDataInicio)
        Me.Controls.Add(Me.LabelUsuarioNome)
        Me.Name = "EventForm"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelUsuarioNome As Label
    Friend WithEvents LabelDataInicio As Label
    Friend WithEvents LabelDataFim As Label
    Friend WithEvents TextBoxUsuarioNome As TextBox
    Friend WithEvents DateTimePickerInicio As DateTimePicker
    Friend WithEvents DateTimePickerFim As DateTimePicker
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonCancel As Button
End Class

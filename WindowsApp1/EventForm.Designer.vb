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
        Me.TextBoxUsuarioNome = New System.Windows.Forms.TextBox()
        Me.DateTimePickerInicio = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerFim = New System.Windows.Forms.DateTimePicker()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.usu_login_VC = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxUsuarioNome
        '
        Me.TextBoxUsuarioNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUsuarioNome.Location = New System.Drawing.Point(10, 105)
        Me.TextBoxUsuarioNome.Name = "TextBoxUsuarioNome"
        Me.TextBoxUsuarioNome.Size = New System.Drawing.Size(337, 22)
        Me.TextBoxUsuarioNome.TabIndex = 4
        '
        'DateTimePickerInicio
        '
        Me.DateTimePickerInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerInicio.Location = New System.Drawing.Point(12, 42)
        Me.DateTimePickerInicio.Name = "DateTimePickerInicio"
        Me.DateTimePickerInicio.Size = New System.Drawing.Size(339, 22)
        Me.DateTimePickerInicio.TabIndex = 5
        '
        'DateTimePickerFim
        '
        Me.DateTimePickerFim.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerFim.Location = New System.Drawing.Point(10, 67)
        Me.DateTimePickerFim.Name = "DateTimePickerFim"
        Me.DateTimePickerFim.Size = New System.Drawing.Size(339, 22)
        Me.DateTimePickerFim.TabIndex = 6
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(195, 201)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSave.TabIndex = 7
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(276, 201)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 8
        Me.ButtonCancel.Text = "Cancelar"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'usu_login_VC
        '
        Me.usu_login_VC.AutoSize = True
        Me.usu_login_VC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usu_login_VC.Location = New System.Drawing.Point(9, 9)
        Me.usu_login_VC.Name = "usu_login_VC"
        Me.usu_login_VC.Size = New System.Drawing.Size(94, 16)
        Me.usu_login_VC.TabIndex = 9
        Me.usu_login_VC.Text = "Nome Usuario"
        '
        'EventForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 236)
        Me.Controls.Add(Me.usu_login_VC)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.DateTimePickerFim)
        Me.Controls.Add(Me.DateTimePickerInicio)
        Me.Controls.Add(Me.TextBoxUsuarioNome)
        Me.Name = "EventForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxUsuarioNome As TextBox
    Friend WithEvents DateTimePickerInicio As DateTimePicker
    Friend WithEvents DateTimePickerFim As DateTimePicker
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents usu_login_VC As Label
End Class

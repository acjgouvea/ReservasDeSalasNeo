<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TelaDeAgendamento
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
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.usu_login_VC = New System.Windows.Forms.Label()
        Me.IdSalaAtual = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.DateTimePickerFim = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxUsuarioNome = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DateTimePickerInicio = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(152, 259)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(88, 32)
        Me.ButtonSave.TabIndex = 7
        Me.ButtonSave.Text = "Salvar"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(246, 259)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(88, 32)
        Me.ButtonCancel.TabIndex = 8
        Me.ButtonCancel.Text = "Cancelar"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'usu_login_VC
        '
        Me.usu_login_VC.AutoSize = True
        Me.usu_login_VC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usu_login_VC.Location = New System.Drawing.Point(6, 16)
        Me.usu_login_VC.Name = "usu_login_VC"
        Me.usu_login_VC.Size = New System.Drawing.Size(94, 16)
        Me.usu_login_VC.TabIndex = 9
        Me.usu_login_VC.Text = "Nome Usuario"
        '
        'IdSalaAtual
        '
        Me.IdSalaAtual.AutoSize = True
        Me.IdSalaAtual.Location = New System.Drawing.Point(6, 19)
        Me.IdSalaAtual.Name = "IdSalaAtual"
        Me.IdSalaAtual.Size = New System.Drawing.Size(76, 16)
        Me.IdSalaAtual.TabIndex = 13
        Me.IdSalaAtual.Text = "IdSalaAtual"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.usu_login_VC)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(7, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(160, 38)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Nome Usuario"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.IdSalaAtual)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(173, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(104, 38)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Id da Sala"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.ComboBox2)
        Me.GroupBox5.Controls.Add(Me.DateTimePickerFim)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox5.Location = New System.Drawing.Point(173, 56)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(160, 99)
        Me.GroupBox5.TabIndex = 22
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Data/Hora Fim"
        '
        'ComboBox2
        '
        Me.ComboBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(6, 60)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(148, 24)
        Me.ComboBox2.TabIndex = 11
        '
        'DateTimePickerFim
        '
        Me.DateTimePickerFim.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateTimePickerFim.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerFim.Location = New System.Drawing.Point(6, 25)
        Me.DateTimePickerFim.Name = "DateTimePickerFim"
        Me.DateTimePickerFim.Size = New System.Drawing.Size(148, 22)
        Me.DateTimePickerFim.TabIndex = 6
        '
        'TextBoxUsuarioNome
        '
        Me.TextBoxUsuarioNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUsuarioNome.Location = New System.Drawing.Point(7, 161)
        Me.TextBoxUsuarioNome.Multiline = True
        Me.TextBoxUsuarioNome.Name = "TextBoxUsuarioNome"
        Me.TextBoxUsuarioNome.Size = New System.Drawing.Size(326, 70)
        Me.TextBoxUsuarioNome.TabIndex = 21
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.ComboBox1)
        Me.GroupBox6.Controls.Add(Me.DateTimePickerInicio)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(7, 56)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(160, 99)
        Me.GroupBox6.TabIndex = 23
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Data/Hora Inicio"
        '
        'ComboBox1
        '
        Me.ComboBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(6, 60)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(148, 24)
        Me.ComboBox1.TabIndex = 10
        '
        'DateTimePickerInicio
        '
        Me.DateTimePickerInicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateTimePickerInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerInicio.Location = New System.Drawing.Point(6, 25)
        Me.DateTimePickerInicio.MaxDate = New Date(2025, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerInicio.MinDate = New Date(2024, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerInicio.Name = "DateTimePickerInicio"
        Me.DateTimePickerInicio.Size = New System.Drawing.Size(148, 22)
        Me.DateTimePickerInicio.TabIndex = 5
        '
        'TelaDeAgendamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 303)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.TextBoxUsuarioNome)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Name = "TelaDeAgendamento"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents usu_login_VC As Label
    Friend WithEvents IdSalaAtual As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents DateTimePickerFim As DateTimePicker
    Friend WithEvents TextBoxUsuarioNome As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePickerInicio As DateTimePicker
End Class

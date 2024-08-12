<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TelaDeAlteracao
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.usu_login_VC = New System.Windows.Forms.Label()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.DateTimePickerFim = New System.Windows.Forms.DateTimePicker()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.TextBoxUsuarioNome = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DateTimePickerInicio = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'usu_login_VC
        '
        Me.usu_login_VC.AutoSize = True
        Me.usu_login_VC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usu_login_VC.Location = New System.Drawing.Point(10, 24)
        Me.usu_login_VC.Name = "usu_login_VC"
        Me.usu_login_VC.Size = New System.Drawing.Size(94, 16)
        Me.usu_login_VC.TabIndex = 16
        Me.usu_login_VC.Text = "Nome Usuario"
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(262, 221)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 15
        Me.ButtonCancel.Text = "Cancelar"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.DateTimePickerFim)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(179, 64)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(160, 99)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data/Hora Fim"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(6, 60)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(148, 21)
        Me.ComboBox2.TabIndex = 11
        '
        'DateTimePickerFim
        '
        Me.DateTimePickerFim.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerFim.Location = New System.Drawing.Point(6, 25)
        Me.DateTimePickerFim.Name = "DateTimePickerFim"
        Me.DateTimePickerFim.Size = New System.Drawing.Size(148, 22)
        Me.DateTimePickerFim.TabIndex = 6
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(181, 221)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSave.TabIndex = 14
        Me.ButtonSave.Text = "Alterar"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'TextBoxUsuarioNome
        '
        Me.TextBoxUsuarioNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUsuarioNome.Location = New System.Drawing.Point(13, 169)
        Me.TextBoxUsuarioNome.Multiline = True
        Me.TextBoxUsuarioNome.Name = "TextBoxUsuarioNome"
        Me.TextBoxUsuarioNome.Size = New System.Drawing.Size(326, 46)
        Me.TextBoxUsuarioNome.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerInicio)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(160, 99)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data/Hora Inicio"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(6, 60)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(148, 21)
        Me.ComboBox1.TabIndex = 10
        '
        'DateTimePickerInicio
        '
        Me.DateTimePickerInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerInicio.Location = New System.Drawing.Point(6, 25)
        Me.DateTimePickerInicio.Name = "DateTimePickerInicio"
        Me.DateTimePickerInicio.Size = New System.Drawing.Size(148, 22)
        Me.DateTimePickerInicio.TabIndex = 5
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 269)
        Me.Controls.Add(Me.usu_login_VC)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.TextBoxUsuarioNome)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents usu_login_VC As Label
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents DateTimePickerFim As DateTimePicker
    Friend WithEvents ButtonSave As Button
    Friend WithEvents TextBoxUsuarioNome As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePickerInicio As DateTimePicker
End Class

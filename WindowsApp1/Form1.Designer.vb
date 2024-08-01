<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonPrevWeek = New System.Windows.Forms.Button()
        Me.ButtonNextWeek = New System.Windows.Forms.Button()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Segunda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Terca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quarta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quinta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sexta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Horario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Location = New System.Drawing.Point(801, 397)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(227, 33)
        Me.ButtonEdit.TabIndex = 2
        Me.ButtonEdit.Text = "Editar"
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(801, 436)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(227, 33)
        Me.ButtonDelete.TabIndex = 3
        Me.ButtonDelete.Text = "Excluir"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonPrevWeek
        '
        Me.ButtonPrevWeek.Location = New System.Drawing.Point(24, 499)
        Me.ButtonPrevWeek.Name = "ButtonPrevWeek"
        Me.ButtonPrevWeek.Size = New System.Drawing.Size(227, 33)
        Me.ButtonPrevWeek.TabIndex = 4
        Me.ButtonPrevWeek.Text = "Semana Anterior"
        Me.ButtonPrevWeek.UseVisualStyleBackColor = True
        '
        'ButtonNextWeek
        '
        Me.ButtonNextWeek.Location = New System.Drawing.Point(257, 499)
        Me.ButtonNextWeek.Name = "ButtonNextWeek"
        Me.ButtonNextWeek.Size = New System.Drawing.Size(227, 33)
        Me.ButtonNextWeek.TabIndex = 5
        Me.ButtonNextWeek.Text = "Proxima Semana"
        Me.ButtonNextWeek.UseVisualStyleBackColor = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(801, 18)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 6
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Segunda, Me.Terca, Me.Quarta, Me.Quinta, Me.Sexta, Me.Horario})
        Me.DataGridView1.Location = New System.Drawing.Point(24, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(765, 457)
        Me.DataGridView1.TabIndex = 0
        '
        'Segunda
        '
        Me.Segunda.DataPropertyName = "IdSegunda_IN"
        Me.Segunda.HeaderText = "Segunda"
        Me.Segunda.MinimumWidth = 100
        Me.Segunda.Name = "Segunda"
        Me.Segunda.Width = 120
        '
        'Terca
        '
        Me.Terca.HeaderText = "Terça"
        Me.Terca.MinimumWidth = 100
        Me.Terca.Name = "Terca"
        Me.Terca.Width = 120
        '
        'Quarta
        '
        Me.Quarta.HeaderText = "Quarta"
        Me.Quarta.MinimumWidth = 100
        Me.Quarta.Name = "Quarta"
        Me.Quarta.Width = 120
        '
        'Quinta
        '
        Me.Quinta.HeaderText = "Quinta"
        Me.Quinta.MinimumWidth = 100
        Me.Quinta.Name = "Quinta"
        Me.Quinta.Width = 120
        '
        'Sexta
        '
        Me.Sexta.HeaderText = "Sexta"
        Me.Sexta.MinimumWidth = 100
        Me.Sexta.Name = "Sexta"
        Me.Sexta.Width = 120
        '
        'Horario
        '
        Me.Horario.HeaderText = "Horario"
        Me.Horario.MinimumWidth = 100
        Me.Horario.Name = "Horario"
        Me.Horario.Width = 120
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 573)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.ButtonNextWeek)
        Me.Controls.Add(Me.ButtonPrevWeek)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonPrevWeek As Button
    Friend WithEvents ButtonNextWeek As Button
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Segunda As DataGridViewTextBoxColumn
    Friend WithEvents Terca As DataGridViewTextBoxColumn
    Friend WithEvents Quarta As DataGridViewTextBoxColumn
    Friend WithEvents Quinta As DataGridViewTextBoxColumn
    Friend WithEvents Sexta As DataGridViewTextBoxColumn
    Friend WithEvents Horario As DataGridViewTextBoxColumn
End Class

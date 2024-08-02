<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonPrevWeek = New System.Windows.Forms.Button()
        Me.ButtonNextWeek = New System.Windows.Forms.Button()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.HoraApresentacao_VC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdSegunda_IN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTerca_IN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdQuarta_IN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdQuinta_IN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Location = New System.Drawing.Point(801, 519)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(227, 33)
        Me.ButtonEdit.TabIndex = 2
        Me.ButtonEdit.Text = "Editar"
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(801, 558)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(227, 33)
        Me.ButtonDelete.TabIndex = 3
        Me.ButtonDelete.Text = "Excluir"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonPrevWeek
        '
        Me.ButtonPrevWeek.Location = New System.Drawing.Point(801, 231)
        Me.ButtonPrevWeek.Name = "ButtonPrevWeek"
        Me.ButtonPrevWeek.Size = New System.Drawing.Size(227, 33)
        Me.ButtonPrevWeek.TabIndex = 4
        Me.ButtonPrevWeek.Text = "Semana Anterior"
        Me.ButtonPrevWeek.UseVisualStyleBackColor = True
        '
        'ButtonNextWeek
        '
        Me.ButtonNextWeek.Location = New System.Drawing.Point(801, 192)
        Me.ButtonNextWeek.Name = "ButtonNextWeek"
        Me.ButtonNextWeek.Size = New System.Drawing.Size(227, 33)
        Me.ButtonNextWeek.TabIndex = 5
        Me.ButtonNextWeek.Text = "Proxima Semana"
        Me.ButtonNextWeek.UseVisualStyleBackColor = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(801, 12)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 6
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.HoraApresentacao_VC, Me.IdSegunda_IN, Me.IdTerca_IN, Me.IdQuarta_IN, Me.IdQuinta_IN})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(777, 579)
        Me.DataGridView1.TabIndex = 0
        '
        'HoraApresentacao_VC
        '
        Me.HoraApresentacao_VC.HeaderText = "Horário"
        Me.HoraApresentacao_VC.Name = "HoraApresentacao_VC"
        '
        'IdSegunda_IN
        '
        Me.IdSegunda_IN.HeaderText = "Segunda"
        Me.IdSegunda_IN.Name = "IdSegunda_IN"
        '
        'IdTerca_IN
        '
        Me.IdTerca_IN.HeaderText = "Terça"
        Me.IdTerca_IN.Name = "IdTerca_IN"
        '
        'IdQuarta_IN
        '
        Me.IdQuarta_IN.HeaderText = "Quarta"
        Me.IdQuarta_IN.Name = "IdQuarta_IN"
        '
        'IdQuinta_IN
        '
        Me.IdQuinta_IN.HeaderText = "Quinta"
        Me.IdQuinta_IN.Name = "IdQuinta_IN"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1036, 603)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.ButtonNextWeek)
        Me.Controls.Add(Me.ButtonPrevWeek)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Reservas de Salas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonPrevWeek As Button
    Friend WithEvents ButtonNextWeek As Button
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents HoraApresentacao_VC As DataGridViewTextBoxColumn
    Friend WithEvents IdSegunda_IN As DataGridViewTextBoxColumn
    Friend WithEvents IdTerca_IN As DataGridViewTextBoxColumn
    Friend WithEvents IdQuarta_IN As DataGridViewTextBoxColumn
    Friend WithEvents IdQuinta_IN As DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
End Class

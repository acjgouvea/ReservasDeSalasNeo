<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TelaDeReservas
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.dgvGridReserva = New System.Windows.Forms.DataGridView()
        Me.HoraApresentacao_VC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdSegunda_IN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTerca_IN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdQuarta_IN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdQuinta_IN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sexta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelecaoDeSalas = New System.Windows.Forms.ComboBox()
        Me.SelecaoDeEmpresa = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.MASERP_HMLDataSet = New WindowsApp1.MASERP_HMLDataSet()
        Me.MASERPHMLDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Agendar = New System.Windows.Forms.Button()
        CType(Me.dgvGridReserva, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.MASERP_HMLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MASERPHMLDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MonthCalendar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar1.Location = New System.Drawing.Point(840, 18)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 6
        Me.MonthCalendar1.TitleBackColor = System.Drawing.Color.Wheat
        Me.MonthCalendar1.TrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption
        '
        'dgvGridReserva
        '
        Me.dgvGridReserva.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.dgvGridReserva.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGridReserva.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvGridReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGridReserva.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.HoraApresentacao_VC, Me.IdSegunda_IN, Me.IdTerca_IN, Me.IdQuarta_IN, Me.IdQuinta_IN, Me.Sexta})
        Me.dgvGridReserva.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvGridReserva.Location = New System.Drawing.Point(14, 18)
        Me.dgvGridReserva.Margin = New System.Windows.Forms.Padding(5)
        Me.dgvGridReserva.MultiSelect = False
        Me.dgvGridReserva.Name = "dgvGridReserva"
        Me.dgvGridReserva.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgvGridReserva.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvGridReserva.RowHeadersVisible = False
        Me.dgvGridReserva.RowHeadersWidth = 50
        Me.dgvGridReserva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvGridReserva.Size = New System.Drawing.Size(812, 572)
        Me.dgvGridReserva.TabIndex = 0
        '
        'HoraApresentacao_VC
        '
        Me.HoraApresentacao_VC.DataPropertyName = "HoraApresentacao_VC"
        Me.HoraApresentacao_VC.FillWeight = 120.0!
        Me.HoraApresentacao_VC.HeaderText = "Horário"
        Me.HoraApresentacao_VC.MinimumWidth = 120
        Me.HoraApresentacao_VC.Name = "HoraApresentacao_VC"
        Me.HoraApresentacao_VC.Width = 120
        '
        'IdSegunda_IN
        '
        Me.IdSegunda_IN.DataPropertyName = "EventoSegunda_VC"
        Me.IdSegunda_IN.FillWeight = 120.0!
        Me.IdSegunda_IN.HeaderText = "Segunda"
        Me.IdSegunda_IN.MinimumWidth = 120
        Me.IdSegunda_IN.Name = "IdSegunda_IN"
        Me.IdSegunda_IN.Width = 120
        '
        'IdTerca_IN
        '
        Me.IdTerca_IN.DataPropertyName = "EventoTerca_VC"
        Me.IdTerca_IN.FillWeight = 120.0!
        Me.IdTerca_IN.HeaderText = "Terça"
        Me.IdTerca_IN.MinimumWidth = 120
        Me.IdTerca_IN.Name = "IdTerca_IN"
        Me.IdTerca_IN.Width = 120
        '
        'IdQuarta_IN
        '
        Me.IdQuarta_IN.DataPropertyName = "EventoQuarta_VC"
        Me.IdQuarta_IN.FillWeight = 120.0!
        Me.IdQuarta_IN.HeaderText = "Quarta"
        Me.IdQuarta_IN.MinimumWidth = 120
        Me.IdQuarta_IN.Name = "IdQuarta_IN"
        Me.IdQuarta_IN.Width = 120
        '
        'IdQuinta_IN
        '
        Me.IdQuinta_IN.DataPropertyName = "EventoQuinta_VC"
        Me.IdQuinta_IN.FillWeight = 120.0!
        Me.IdQuinta_IN.HeaderText = "Quinta"
        Me.IdQuinta_IN.MinimumWidth = 120
        Me.IdQuinta_IN.Name = "IdQuinta_IN"
        Me.IdQuinta_IN.Width = 120
        '
        'Sexta
        '
        Me.Sexta.DataPropertyName = "EventoSexta_VC"
        Me.Sexta.FillWeight = 120.0!
        Me.Sexta.HeaderText = "Sexta"
        Me.Sexta.MinimumWidth = 120
        Me.Sexta.Name = "Sexta"
        Me.Sexta.Width = 120
        '
        'SelecaoDeSalas
        '
        Me.SelecaoDeSalas.BackColor = System.Drawing.SystemColors.Info
        Me.SelecaoDeSalas.FormattingEnabled = True
        Me.SelecaoDeSalas.Location = New System.Drawing.Point(7, 19)
        Me.SelecaoDeSalas.Name = "SelecaoDeSalas"
        Me.SelecaoDeSalas.Size = New System.Drawing.Size(214, 24)
        Me.SelecaoDeSalas.TabIndex = 7
        '
        'SelecaoDeEmpresa
        '
        Me.SelecaoDeEmpresa.BackColor = System.Drawing.SystemColors.Info
        Me.SelecaoDeEmpresa.FormattingEnabled = True
        Me.SelecaoDeEmpresa.Location = New System.Drawing.Point(7, 19)
        Me.SelecaoDeEmpresa.Name = "SelecaoDeEmpresa"
        Me.SelecaoDeEmpresa.Size = New System.Drawing.Size(214, 24)
        Me.SelecaoDeEmpresa.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Info
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Label1"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(840, 203)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(227, 43)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Semana Atual"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox2.Controls.Add(Me.SelecaoDeEmpresa)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(840, 265)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(227, 53)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Empresa:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox3.Controls.Add(Me.SelecaoDeSalas)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(840, 339)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(227, 53)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sala:"
        '
        'MASERP_HMLDataSet
        '
        Me.MASERP_HMLDataSet.DataSetName = "MASERP_HMLDataSet"
        Me.MASERP_HMLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MASERPHMLDataSetBindingSource
        '
        Me.MASERPHMLDataSetBindingSource.DataSource = Me.MASERP_HMLDataSet
        Me.MASERPHMLDataSetBindingSource.Position = 0
        '
        'Agendar
        '
        Me.Agendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agendar.Location = New System.Drawing.Point(840, 545)
        Me.Agendar.Name = "Agendar"
        Me.Agendar.Size = New System.Drawing.Size(227, 45)
        Me.Agendar.TabIndex = 12
        Me.Agendar.Text = "Agendar"
        Me.Agendar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1085, 622)
        Me.Controls.Add(Me.Agendar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvGridReserva)
        Me.Name = "Form1"
        Me.Text = "Reservas de Salas"
        CType(Me.dgvGridReserva, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.MASERP_HMLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MASERPHMLDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents SelecaoDeSalas As ComboBox
    Friend WithEvents SelecaoDeEmpresa As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents HoraApresentacao_VC As DataGridViewTextBoxColumn
    Friend WithEvents IdSegunda_IN As DataGridViewTextBoxColumn
    Friend WithEvents IdTerca_IN As DataGridViewTextBoxColumn
    Friend WithEvents IdQuarta_IN As DataGridViewTextBoxColumn
    Friend WithEvents IdQuinta_IN As DataGridViewTextBoxColumn
    Friend WithEvents Sexta As DataGridViewTextBoxColumn
    Friend WithEvents dgvGridReserva As DataGridView
    Friend WithEvents MASERP_HMLDataSet As MASERP_HMLDataSet
    Friend WithEvents MASERPHMLDataSetBindingSource As BindingSource
    Friend WithEvents Agendar As Button
End Class

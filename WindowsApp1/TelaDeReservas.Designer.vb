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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.dgvGridReserva = New System.Windows.Forms.DataGridView()
        Me.SelecaoDeSalas = New System.Windows.Forms.ComboBox()
        Me.SelecaoDeEmpresa = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.MASERP_HMLDataSet = New WindowsApp1.MASERP_HMLDataSet()
        Me.MASERPHMLDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Agendar = New System.Windows.Forms.Button()
        Me.Excluir_Reserva = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.lblDataHoraInicio = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblUsuarioNome = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.lblDataHoraFim = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lblEvento = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.lblReservadoEm = New System.Windows.Forms.Label()
        Me.HoraApresentacao_VC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdSegunda_IN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTerca_IN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdQuarta_IN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdQuinta_IN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sexta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvGridReserva, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.MASERP_HMLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MASERPHMLDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MonthCalendar1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar1.Location = New System.Drawing.Point(1380, 22)
        Me.MonthCalendar1.Margin = New System.Windows.Forms.Padding(10, 11, 10, 11)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 6
        Me.MonthCalendar1.TitleBackColor = System.Drawing.Color.Wheat
        Me.MonthCalendar1.TrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption
        '
        'dgvGridReserva
        '
        Me.dgvGridReserva.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.dgvGridReserva.AllowUserToDeleteRows = False
        Me.dgvGridReserva.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.dgvGridReserva.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGridReserva.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvGridReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGridReserva.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.HoraApresentacao_VC, Me.IdSegunda_IN, Me.IdTerca_IN, Me.IdQuarta_IN, Me.IdQuinta_IN, Me.Sexta})
        Me.dgvGridReserva.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvGridReserva.Location = New System.Drawing.Point(59, 22)
        Me.dgvGridReserva.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.dgvGridReserva.MultiSelect = False
        Me.dgvGridReserva.Name = "dgvGridReserva"
        Me.dgvGridReserva.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgvGridReserva.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvGridReserva.RowHeadersVisible = False
        Me.dgvGridReserva.RowHeadersWidth = 50
        Me.dgvGridReserva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvGridReserva.Size = New System.Drawing.Size(1197, 954)
        Me.dgvGridReserva.TabIndex = 0
        '
        'SelecaoDeSalas
        '
        Me.SelecaoDeSalas.BackColor = System.Drawing.SystemColors.Control
        Me.SelecaoDeSalas.FormattingEnabled = True
        Me.SelecaoDeSalas.Location = New System.Drawing.Point(11, 23)
        Me.SelecaoDeSalas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SelecaoDeSalas.Name = "SelecaoDeSalas"
        Me.SelecaoDeSalas.Size = New System.Drawing.Size(217, 24)
        Me.SelecaoDeSalas.TabIndex = 7
        '
        'SelecaoDeEmpresa
        '
        Me.SelecaoDeEmpresa.BackColor = System.Drawing.SystemColors.Control
        Me.SelecaoDeEmpresa.FormattingEnabled = True
        Me.SelecaoDeEmpresa.Location = New System.Drawing.Point(11, 23)
        Me.SelecaoDeEmpresa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SelecaoDeEmpresa.Name = "SelecaoDeEmpresa"
        Me.SelecaoDeEmpresa.Size = New System.Drawing.Size(217, 24)
        Me.SelecaoDeEmpresa.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Label1"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(1380, 236)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(227, 53)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Semana Atual"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox2.Controls.Add(Me.SelecaoDeEmpresa)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(1379, 297)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(228, 65)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Empresa:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox3.Controls.Add(Me.SelecaoDeSalas)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(1379, 369)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(228, 65)
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
        Me.Agendar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agendar.Location = New System.Drawing.Point(1430, 869)
        Me.Agendar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Agendar.Name = "Agendar"
        Me.Agendar.Size = New System.Drawing.Size(133, 34)
        Me.Agendar.TabIndex = 12
        Me.Agendar.Text = "Agendar"
        Me.Agendar.UseVisualStyleBackColor = True
        '
        'Excluir_Reserva
        '
        Me.Excluir_Reserva.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Excluir_Reserva.Location = New System.Drawing.Point(1560, 869)
        Me.Excluir_Reserva.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Excluir_Reserva.Name = "Excluir_Reserva"
        Me.Excluir_Reserva.Size = New System.Drawing.Size(133, 34)
        Me.Excluir_Reserva.TabIndex = 14
        Me.Excluir_Reserva.Text = "Excluir Reserva"
        Me.Excluir_Reserva.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox7)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.GroupBox9)
        Me.GroupBox4.Controls.Add(Me.GroupBox6)
        Me.GroupBox4.Controls.Add(Me.GroupBox8)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox4.Location = New System.Drawing.Point(1380, 455)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(227, 331)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Detalhes Reserva"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.lblDataHoraInicio)
        Me.GroupBox7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(10, 193)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox7.Size = New System.Drawing.Size(186, 49)
        Me.GroupBox7.TabIndex = 17
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Data/Hora Inicio"
        '
        'lblDataHoraInicio
        '
        Me.lblDataHoraInicio.AutoSize = True
        Me.lblDataHoraInicio.Location = New System.Drawing.Point(7, 20)
        Me.lblDataHoraInicio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDataHoraInicio.Name = "lblDataHoraInicio"
        Me.lblDataHoraInicio.Size = New System.Drawing.Size(0, 16)
        Me.lblDataHoraInicio.TabIndex = 1
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblUsuarioNome)
        Me.GroupBox5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(10, 23)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Size = New System.Drawing.Size(186, 49)
        Me.GroupBox5.TabIndex = 16
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Usuario "
        '
        'lblUsuarioNome
        '
        Me.lblUsuarioNome.AutoSize = True
        Me.lblUsuarioNome.Location = New System.Drawing.Point(7, 20)
        Me.lblUsuarioNome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsuarioNome.Name = "lblUsuarioNome"
        Me.lblUsuarioNome.Size = New System.Drawing.Size(0, 16)
        Me.lblUsuarioNome.TabIndex = 0
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.lblDataHoraFim)
        Me.GroupBox9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.Location = New System.Drawing.Point(10, 137)
        Me.GroupBox9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox9.Size = New System.Drawing.Size(186, 49)
        Me.GroupBox9.TabIndex = 17
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Data/Hora Fim"
        '
        'lblDataHoraFim
        '
        Me.lblDataHoraFim.AutoSize = True
        Me.lblDataHoraFim.Location = New System.Drawing.Point(7, 20)
        Me.lblDataHoraFim.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDataHoraFim.Name = "lblDataHoraFim"
        Me.lblDataHoraFim.Size = New System.Drawing.Size(0, 16)
        Me.lblDataHoraFim.TabIndex = 2
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lblEvento)
        Me.GroupBox6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(10, 250)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox6.Size = New System.Drawing.Size(186, 63)
        Me.GroupBox6.TabIndex = 17
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Descrição do Evento"
        '
        'lblEvento
        '
        Me.lblEvento.AutoSize = True
        Me.lblEvento.Location = New System.Drawing.Point(7, 20)
        Me.lblEvento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEvento.Name = "lblEvento"
        Me.lblEvento.Size = New System.Drawing.Size(0, 16)
        Me.lblEvento.TabIndex = 3
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.lblReservadoEm)
        Me.GroupBox8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(10, 80)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox8.Size = New System.Drawing.Size(186, 49)
        Me.GroupBox8.TabIndex = 17
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Reservado Em"
        '
        'lblReservadoEm
        '
        Me.lblReservadoEm.AutoSize = True
        Me.lblReservadoEm.Location = New System.Drawing.Point(7, 20)
        Me.lblReservadoEm.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReservadoEm.Name = "lblReservadoEm"
        Me.lblReservadoEm.Size = New System.Drawing.Size(0, 16)
        Me.lblReservadoEm.TabIndex = 4
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
        Me.IdSegunda_IN.MinimumWidth = 170
        Me.IdSegunda_IN.Name = "IdSegunda_IN"
        Me.IdSegunda_IN.Width = 170
        '
        'IdTerca_IN
        '
        Me.IdTerca_IN.DataPropertyName = "EventoTerca_VC"
        Me.IdTerca_IN.FillWeight = 120.0!
        Me.IdTerca_IN.HeaderText = "Terça"
        Me.IdTerca_IN.MinimumWidth = 170
        Me.IdTerca_IN.Name = "IdTerca_IN"
        Me.IdTerca_IN.Width = 170
        '
        'IdQuarta_IN
        '
        Me.IdQuarta_IN.DataPropertyName = "EventoQuarta_VC"
        Me.IdQuarta_IN.FillWeight = 120.0!
        Me.IdQuarta_IN.HeaderText = "Quarta"
        Me.IdQuarta_IN.MinimumWidth = 170
        Me.IdQuarta_IN.Name = "IdQuarta_IN"
        Me.IdQuarta_IN.Width = 170
        '
        'IdQuinta_IN
        '
        Me.IdQuinta_IN.DataPropertyName = "EventoQuinta_VC"
        Me.IdQuinta_IN.FillWeight = 120.0!
        Me.IdQuinta_IN.HeaderText = "Quinta"
        Me.IdQuinta_IN.MinimumWidth = 170
        Me.IdQuinta_IN.Name = "IdQuinta_IN"
        Me.IdQuinta_IN.Width = 170
        '
        'Sexta
        '
        Me.Sexta.DataPropertyName = "EventoSexta_VC"
        Me.Sexta.FillWeight = 120.0!
        Me.Sexta.HeaderText = "Sexta"
        Me.Sexta.MinimumWidth = 170
        Me.Sexta.Name = "Sexta"
        Me.Sexta.Width = 170
        '
        'TelaDeReservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1682, 820)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Excluir_Reserva)
        Me.Controls.Add(Me.Agendar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvGridReserva)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "TelaDeReservas"
        Me.Text = " "
        CType(Me.dgvGridReserva, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.MASERP_HMLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MASERPHMLDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents SelecaoDeSalas As ComboBox
    Friend WithEvents SelecaoDeEmpresa As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvGridReserva As DataGridView
    Friend WithEvents MASERP_HMLDataSet As MASERP_HMLDataSet
    Friend WithEvents MASERPHMLDataSetBindingSource As BindingSource
    Friend WithEvents Agendar As Button
    Friend WithEvents Excluir_Reserva As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lblReservadoEm As Label
    Friend WithEvents lblDataHoraFim As Label
    Friend WithEvents lblDataHoraInicio As Label
    Friend WithEvents lblUsuarioNome As Label
    Friend WithEvents lblEvento As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents HoraApresentacao_VC As DataGridViewTextBoxColumn
    Friend WithEvents IdSegunda_IN As DataGridViewTextBoxColumn
    Friend WithEvents IdTerca_IN As DataGridViewTextBoxColumn
    Friend WithEvents IdQuarta_IN As DataGridViewTextBoxColumn
    Friend WithEvents IdQuinta_IN As DataGridViewTextBoxColumn
    Friend WithEvents Sexta As DataGridViewTextBoxColumn
End Class

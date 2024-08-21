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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TelaDeReservas))
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.SelecaoDeSalas = New System.Windows.Forms.ComboBox()
        Me.SelecaoDeEmpresa = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.MASERP_HMLDataSet = New WindowsApp1.MASERP_HMLDataSet()
        Me.MASERPHMLDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.pnlDetalhesReserva = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.lblDataHoraInicio = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblUsuarioNome = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.lblDataHoraFim = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.lblReservadoEm = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lblEvento = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.dgvGridReserva = New System.Windows.Forms.DataGridView()
        Me.HoraApresentacao_VC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdSegunda_IN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTerca_IN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdQuarta_IN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdQuinta_IN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sexta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IconButton4 = New FontAwesome.Sharp.IconButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.MASERP_HMLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MASERPHMLDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDetalhesReserva.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvGridReserva, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.BackColor = System.Drawing.SystemColors.ActiveCaption
        resources.ApplyResources(Me.MonthCalendar1, "MonthCalendar1")
        Me.MonthCalendar1.MaxDate = New Date(2025, 12, 31, 0, 0, 0, 0)
        Me.MonthCalendar1.MinDate = New Date(2024, 1, 1, 0, 0, 0, 0)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TitleBackColor = System.Drawing.Color.Wheat
        Me.MonthCalendar1.TrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption
        '
        'SelecaoDeSalas
        '
        Me.SelecaoDeSalas.BackColor = System.Drawing.SystemColors.Control
        Me.SelecaoDeSalas.FormattingEnabled = True
        resources.ApplyResources(Me.SelecaoDeSalas, "SelecaoDeSalas")
        Me.SelecaoDeSalas.Name = "SelecaoDeSalas"
        '
        'SelecaoDeEmpresa
        '
        Me.SelecaoDeEmpresa.BackColor = System.Drawing.SystemColors.Control
        Me.SelecaoDeEmpresa.FormattingEnabled = True
        resources.ApplyResources(Me.SelecaoDeEmpresa, "SelecaoDeEmpresa")
        Me.SelecaoDeEmpresa.Name = "SelecaoDeEmpresa"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Label1.Name = "Label1"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.SelecaoDeEmpresa)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.SelecaoDeSalas)
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
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
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(63, Byte), Integer))
        resources.ApplyResources(Me.IconButton1, "IconButton1")
        Me.IconButton1.ForeColor = System.Drawing.Color.White
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.ClockFour
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 24
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'IconButton2
        '
        Me.IconButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(63, Byte), Integer))
        resources.ApplyResources(Me.IconButton2, "IconButton2")
        Me.IconButton2.ForeColor = System.Drawing.Color.White
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.IconButton2.IconColor = System.Drawing.Color.White
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 24
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'pnlDetalhesReserva
        '
        Me.pnlDetalhesReserva.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.pnlDetalhesReserva.Controls.Add(Me.PictureBox1)
        Me.pnlDetalhesReserva.Controls.Add(Me.Label2)
        Me.pnlDetalhesReserva.Controls.Add(Me.GroupBox7)
        Me.pnlDetalhesReserva.Controls.Add(Me.GroupBox5)
        Me.pnlDetalhesReserva.Controls.Add(Me.GroupBox9)
        Me.pnlDetalhesReserva.Controls.Add(Me.GroupBox8)
        Me.pnlDetalhesReserva.Controls.Add(Me.GroupBox6)
        resources.ApplyResources(Me.pnlDetalhesReserva, "pnlDetalhesReserva")
        Me.pnlDetalhesReserva.Name = "pnlDetalhesReserva"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(63, Byte), Integer))
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(63, Byte), Integer))
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Label2.Name = "Label2"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.lblDataHoraInicio)
        resources.ApplyResources(Me.GroupBox7, "GroupBox7")
        Me.GroupBox7.ForeColor = System.Drawing.Color.Black
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.TabStop = False
        '
        'lblDataHoraInicio
        '
        resources.ApplyResources(Me.lblDataHoraInicio, "lblDataHoraInicio")
        Me.lblDataHoraInicio.Name = "lblDataHoraInicio"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblUsuarioNome)
        resources.ApplyResources(Me.GroupBox5, "GroupBox5")
        Me.GroupBox5.ForeColor = System.Drawing.Color.Black
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.TabStop = False
        '
        'lblUsuarioNome
        '
        resources.ApplyResources(Me.lblUsuarioNome, "lblUsuarioNome")
        Me.lblUsuarioNome.Name = "lblUsuarioNome"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.lblDataHoraFim)
        resources.ApplyResources(Me.GroupBox9, "GroupBox9")
        Me.GroupBox9.ForeColor = System.Drawing.Color.Black
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.TabStop = False
        '
        'lblDataHoraFim
        '
        resources.ApplyResources(Me.lblDataHoraFim, "lblDataHoraFim")
        Me.lblDataHoraFim.Name = "lblDataHoraFim"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.lblReservadoEm)
        resources.ApplyResources(Me.GroupBox8, "GroupBox8")
        Me.GroupBox8.ForeColor = System.Drawing.Color.Black
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.TabStop = False
        '
        'lblReservadoEm
        '
        resources.ApplyResources(Me.lblReservadoEm, "lblReservadoEm")
        Me.lblReservadoEm.Name = "lblReservadoEm"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lblEvento)
        resources.ApplyResources(Me.GroupBox6, "GroupBox6")
        Me.GroupBox6.ForeColor = System.Drawing.Color.Black
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.TabStop = False
        '
        'lblEvento
        '
        resources.ApplyResources(Me.lblEvento, "lblEvento")
        Me.lblEvento.Name = "lblEvento"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.Label3)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(63, Byte), Integer))
        resources.ApplyResources(Me.PictureBox3, "PictureBox3")
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(63, Byte), Integer))
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(63, Byte), Integer))
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Label4.Name = "Label4"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.MonthCalendar1)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(63, Byte), Integer))
        resources.ApplyResources(Me.PictureBox2, "PictureBox2")
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.TabStop = False
        '
        'dgvGridReserva
        '
        Me.dgvGridReserva.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.dgvGridReserva.AllowUserToDeleteRows = False
        Me.dgvGridReserva.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(63, Byte), Integer))
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 9.75!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGridReserva.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvGridReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGridReserva.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.HoraApresentacao_VC, Me.IdSegunda_IN, Me.IdTerca_IN, Me.IdQuarta_IN, Me.IdQuinta_IN, Me.Sexta})
        Me.dgvGridReserva.GridColor = System.Drawing.SystemColors.ActiveCaption
        resources.ApplyResources(Me.dgvGridReserva, "dgvGridReserva")
        Me.dgvGridReserva.MultiSelect = False
        Me.dgvGridReserva.Name = "dgvGridReserva"
        Me.dgvGridReserva.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvGridReserva.RowHeadersVisible = False
        Me.dgvGridReserva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        '
        'HoraApresentacao_VC
        '
        Me.HoraApresentacao_VC.DataPropertyName = "HoraApresentacao_VC"
        Me.HoraApresentacao_VC.FillWeight = 120.0!
        resources.ApplyResources(Me.HoraApresentacao_VC, "HoraApresentacao_VC")
        Me.HoraApresentacao_VC.Name = "HoraApresentacao_VC"
        '
        'IdSegunda_IN
        '
        Me.IdSegunda_IN.DataPropertyName = "EventoSegunda_VC"
        Me.IdSegunda_IN.FillWeight = 120.0!
        resources.ApplyResources(Me.IdSegunda_IN, "IdSegunda_IN")
        Me.IdSegunda_IN.Name = "IdSegunda_IN"
        '
        'IdTerca_IN
        '
        Me.IdTerca_IN.DataPropertyName = "EventoTerca_VC"
        Me.IdTerca_IN.FillWeight = 120.0!
        resources.ApplyResources(Me.IdTerca_IN, "IdTerca_IN")
        Me.IdTerca_IN.Name = "IdTerca_IN"
        '
        'IdQuarta_IN
        '
        Me.IdQuarta_IN.DataPropertyName = "EventoQuarta_VC"
        Me.IdQuarta_IN.FillWeight = 120.0!
        resources.ApplyResources(Me.IdQuarta_IN, "IdQuarta_IN")
        Me.IdQuarta_IN.Name = "IdQuarta_IN"
        '
        'IdQuinta_IN
        '
        Me.IdQuinta_IN.DataPropertyName = "EventoQuinta_VC"
        Me.IdQuinta_IN.FillWeight = 120.0!
        resources.ApplyResources(Me.IdQuinta_IN, "IdQuinta_IN")
        Me.IdQuinta_IN.Name = "IdQuinta_IN"
        '
        'Sexta
        '
        Me.Sexta.DataPropertyName = "EventoSexta_VC"
        Me.Sexta.FillWeight = 120.0!
        resources.ApplyResources(Me.Sexta, "Sexta")
        Me.Sexta.Name = "Sexta"
        '
        'IconButton4
        '
        Me.IconButton4.BackColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.IconButton4, "IconButton4")
        Me.IconButton4.ForeColor = System.Drawing.Color.White
        Me.IconButton4.IconChar = FontAwesome.Sharp.IconChar.PersonWalkingDashedLineArrowRight
        Me.IconButton4.IconColor = System.Drawing.Color.White
        Me.IconButton4.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton4.IconSize = 24
        Me.IconButton4.Name = "IconButton4"
        Me.IconButton4.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.DimGray
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Label5.Name = "Label5"
        '
        'TelaDeReservas
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.IconButton4)
        Me.Controls.Add(Me.dgvGridReserva)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlDetalhesReserva)
        Me.Controls.Add(Me.IconButton2)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.Label5)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.Name = "TelaDeReservas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.MASERP_HMLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MASERPHMLDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDetalhesReserva.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvGridReserva, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents SelecaoDeSalas As ComboBox
    Friend WithEvents SelecaoDeEmpresa As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents MASERP_HMLDataSet As MASERP_HMLDataSet
    Friend WithEvents MASERPHMLDataSetBindingSource As BindingSource
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlDetalhesReserva As Panel
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents lblDataHoraInicio As Label
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents lblDataHoraFim As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents lblEvento As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents lblReservadoEm As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents lblUsuarioNome As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvGridReserva As DataGridView
    Friend WithEvents HoraApresentacao_VC As DataGridViewTextBoxColumn
    Friend WithEvents IdSegunda_IN As DataGridViewTextBoxColumn
    Friend WithEvents IdTerca_IN As DataGridViewTextBoxColumn
    Friend WithEvents IdQuarta_IN As DataGridViewTextBoxColumn
    Friend WithEvents IdQuinta_IN As DataGridViewTextBoxColumn
    Friend WithEvents Sexta As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents Label5 As Label
End Class

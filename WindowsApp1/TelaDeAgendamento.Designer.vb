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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TelaDeAgendamento))
        Me.DataHoraFim = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.DateTimePickerFim = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxUsuarioNome = New System.Windows.Forms.TextBox()
        Me.DataHoraInicio = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DateTimePickerInicio = New System.Windows.Forms.DateTimePicker()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Motivo = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataHoraFim.SuspendLayout()
        Me.DataHoraInicio.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataHoraFim
        '
        Me.DataHoraFim.Controls.Add(Me.ComboBox2)
        Me.DataHoraFim.Controls.Add(Me.DateTimePickerFim)
        Me.DataHoraFim.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.DataHoraFim.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataHoraFim.Location = New System.Drawing.Point(178, 50)
        Me.DataHoraFim.Margin = New System.Windows.Forms.Padding(5)
        Me.DataHoraFim.Name = "DataHoraFim"
        Me.DataHoraFim.Padding = New System.Windows.Forms.Padding(5)
        Me.DataHoraFim.Size = New System.Drawing.Size(160, 99)
        Me.DataHoraFim.TabIndex = 22
        Me.DataHoraFim.TabStop = False
        Me.DataHoraFim.Text = "Fim reserva"
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.SystemColors.Info
        Me.ComboBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(6, 60)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(148, 21)
        Me.ComboBox2.TabIndex = 11
        '
        'DateTimePickerFim
        '
        Me.DateTimePickerFim.CalendarMonthBackground = System.Drawing.SystemColors.Info
        Me.DateTimePickerFim.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateTimePickerFim.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerFim.Location = New System.Drawing.Point(6, 25)
        Me.DateTimePickerFim.MaxDate = New Date(2025, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerFim.MinDate = New Date(2024, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerFim.Name = "DateTimePickerFim"
        Me.DateTimePickerFim.Size = New System.Drawing.Size(148, 22)
        Me.DateTimePickerFim.TabIndex = 6
        '
        'TextBoxUsuarioNome
        '
        Me.TextBoxUsuarioNome.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxUsuarioNome.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.TextBoxUsuarioNome.Location = New System.Drawing.Point(2, 35)
        Me.TextBoxUsuarioNome.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBoxUsuarioNome.Multiline = True
        Me.TextBoxUsuarioNome.Name = "TextBoxUsuarioNome"
        Me.TextBoxUsuarioNome.Size = New System.Drawing.Size(328, 58)
        Me.TextBoxUsuarioNome.TabIndex = 21
        '
        'DataHoraInicio
        '
        Me.DataHoraInicio.Controls.Add(Me.ComboBox1)
        Me.DataHoraInicio.Controls.Add(Me.DateTimePickerInicio)
        Me.DataHoraInicio.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.DataHoraInicio.Location = New System.Drawing.Point(10, 50)
        Me.DataHoraInicio.Margin = New System.Windows.Forms.Padding(5)
        Me.DataHoraInicio.Name = "DataHoraInicio"
        Me.DataHoraInicio.Padding = New System.Windows.Forms.Padding(5)
        Me.DataHoraInicio.Size = New System.Drawing.Size(160, 99)
        Me.DataHoraInicio.TabIndex = 23
        Me.DataHoraInicio.TabStop = False
        Me.DataHoraInicio.Text = "Inicio reserva"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.Info
        Me.ComboBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(6, 60)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(148, 21)
        Me.ComboBox1.TabIndex = 10
        '
        'DateTimePickerInicio
        '
        Me.DateTimePickerInicio.CalendarMonthBackground = System.Drawing.SystemColors.Info
        Me.DateTimePickerInicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateTimePickerInicio.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerInicio.Location = New System.Drawing.Point(6, 25)
        Me.DateTimePickerInicio.MaxDate = New Date(2025, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerInicio.MinDate = New Date(2024, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerInicio.Name = "DateTimePickerInicio"
        Me.DateTimePickerInicio.Size = New System.Drawing.Size(148, 22)
        Me.DateTimePickerInicio.TabIndex = 5
        '
        'IconButton2
        '
        Me.IconButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton2.ForeColor = System.Drawing.Color.White
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk
        Me.IconButton2.IconColor = System.Drawing.Color.White
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 24
        Me.IconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton2.Location = New System.Drawing.Point(120, 314)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(113, 30)
        Me.IconButton2.TabIndex = 25
        Me.IconButton2.Text = "&Salvar"
        Me.IconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.Red
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.White
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.PersonWalkingDashedLineArrowRight
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 24
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton1.Location = New System.Drawing.Point(246, 314)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(113, 30)
        Me.IconButton1.TabIndex = 26
        Me.IconButton1.Text = "&Sair"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TextBoxUsuarioNome)
        Me.Panel1.Controls.Add(Me.Motivo)
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Panel1.Location = New System.Drawing.Point(8, 195)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(351, 111)
        Me.Panel1.TabIndex = 27
        '
        'Motivo
        '
        Me.Motivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Motivo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Motivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Motivo.Location = New System.Drawing.Point(-1, 0)
        Me.Motivo.Name = "Motivo"
        Me.Motivo.Size = New System.Drawing.Size(352, 30)
        Me.Motivo.TabIndex = 20
        Me.Motivo.Text = "Motivo"
        Me.Motivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.DataHoraInicio)
        Me.Panel2.Controls.Add(Me.DataHoraFim)
        Me.Panel2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Panel2.Location = New System.Drawing.Point(8, 14)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(351, 171)
        Me.Panel2.TabIndex = 28
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(307, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 27)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(-1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(352, 30)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Horario"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TelaDeAgendamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(364, 347)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.IconButton2)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TelaDeAgendamento"
        Me.Text = "Agendamento"
        Me.DataHoraFim.ResumeLayout(False)
        Me.DataHoraInicio.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataHoraFim As GroupBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents DateTimePickerFim As DateTimePicker
    Friend WithEvents TextBoxUsuarioNome As TextBox
    Friend WithEvents DataHoraInicio As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePickerInicio As DateTimePicker
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Motivo As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TelaDeAlteracao))
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DateTimePickerInicio = New System.Windows.Forms.DateTimePicker()
        Me.MASERP_HMLDataSet = New WindowsApp1.MASERP_HMLDataSet()
        Me.MASERPHMLDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MASERP_HMLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MASERPHMLDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancel.Location = New System.Drawing.Point(189, 80)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(79, 25)
        Me.ButtonCancel.TabIndex = 15
        Me.ButtonCancel.Text = "Cancelar"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.Location = New System.Drawing.Point(104, 80)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(79, 25)
        Me.ButtonSave.TabIndex = 14
        Me.ButtonSave.Text = "Excluir"
        Me.ButtonSave.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerInicio)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 35)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(275, 58)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data/Hora "
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(152, 21)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(94, 24)
        Me.ComboBox1.TabIndex = 10
        '
        'DateTimePickerInicio
        '
        Me.DateTimePickerInicio.CalendarMonthBackground = System.Drawing.SystemColors.Info
        Me.DateTimePickerInicio.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerInicio.Location = New System.Drawing.Point(8, 23)
        Me.DateTimePickerInicio.MaxDate = New Date(2025, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerInicio.MinDate = New Date(2024, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerInicio.Name = "DateTimePickerInicio"
        Me.DateTimePickerInicio.Size = New System.Drawing.Size(96, 22)
        Me.DateTimePickerInicio.TabIndex = 5
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel2.Size = New System.Drawing.Size(298, 121)
        Me.Panel2.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(-1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 30)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Horario"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.IconButton1.Location = New System.Drawing.Point(190, 141)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(120, 40)
        Me.IconButton1.TabIndex = 30
        Me.IconButton1.Text = "&Sair"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'IconButton2
        '
        Me.IconButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton2.ForeColor = System.Drawing.Color.White
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.IconButton2.IconColor = System.Drawing.Color.White
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 24
        Me.IconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton2.Location = New System.Drawing.Point(63, 141)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(120, 40)
        Me.IconButton2.TabIndex = 29
        Me.IconButton2.Text = "&Excluir Reserva"
        Me.IconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(231, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 27)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'TelaDeAlteracao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(323, 197)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.IconButton2)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TelaDeAlteracao"
        Me.Text = "Excluir reserva"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.MASERP_HMLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MASERPHMLDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePickerInicio As DateTimePicker
    Friend WithEvents MASERP_HMLDataSet As MASERP_HMLDataSet
    Friend WithEvents MASERPHMLDataSetBindingSource As BindingSource
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox2 As PictureBox
End Class

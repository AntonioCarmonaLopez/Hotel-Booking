<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar
        Me.BtnVer = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtInicio = New System.Windows.Forms.TextBox
        Me.TxtFin = New System.Windows.Forms.TextBox
        Me.MonthCalendar2 = New System.Windows.Forms.MonthCalendar
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.BtnSiguiente = New System.Windows.Forms.Button
        Me.BtnAnterior = New System.Windows.Forms.Button
        Me.BtnFinal = New System.Windows.Forms.Button
        Me.BtnPrincipio = New System.Windows.Forms.Button
        Me.BtnHacer = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtFecha = New System.Windows.Forms.TextBox
        Me.TxtEstado2 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.LblHabitacion = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MonthCalendar1.Location = New System.Drawing.Point(356, 74)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 1
        '
        'BtnVer
        '
        Me.BtnVer.Location = New System.Drawing.Point(547, 327)
        Me.BtnVer.Name = "BtnVer"
        Me.BtnVer.Size = New System.Drawing.Size(94, 23)
        Me.BtnVer.TabIndex = 2
        Me.BtnVer.Text = "Ver Reservas"
        Me.BtnVer.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(522, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Introduce fechas inicio y final"
        '
        'TxtInicio
        '
        Me.TxtInicio.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtInicio.Location = New System.Drawing.Point(426, 255)
        Me.TxtInicio.Name = "TxtInicio"
        Me.TxtInicio.Size = New System.Drawing.Size(100, 20)
        Me.TxtInicio.TabIndex = 5
        '
        'TxtFin
        '
        Me.TxtFin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtFin.Location = New System.Drawing.Point(707, 258)
        Me.TxtFin.Name = "TxtFin"
        Me.TxtFin.Size = New System.Drawing.Size(100, 20)
        Me.TxtFin.TabIndex = 7
        '
        'MonthCalendar2
        '
        Me.MonthCalendar2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MonthCalendar2.Location = New System.Drawing.Point(648, 74)
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(688, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Fecha Fin"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(423, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Fecha de Inicio"
        '
        'BtnSiguiente
        '
        Me.BtnSiguiente.Location = New System.Drawing.Point(148, 100)
        Me.BtnSiguiente.Name = "BtnSiguiente"
        Me.BtnSiguiente.Size = New System.Drawing.Size(33, 23)
        Me.BtnSiguiente.TabIndex = 27
        Me.BtnSiguiente.Text = ">"
        Me.BtnSiguiente.UseVisualStyleBackColor = True
        '
        'BtnAnterior
        '
        Me.BtnAnterior.Location = New System.Drawing.Point(109, 100)
        Me.BtnAnterior.Name = "BtnAnterior"
        Me.BtnAnterior.Size = New System.Drawing.Size(33, 23)
        Me.BtnAnterior.TabIndex = 26
        Me.BtnAnterior.Text = "<"
        Me.BtnAnterior.UseVisualStyleBackColor = True
        '
        'BtnFinal
        '
        Me.BtnFinal.Location = New System.Drawing.Point(187, 100)
        Me.BtnFinal.Name = "BtnFinal"
        Me.BtnFinal.Size = New System.Drawing.Size(30, 23)
        Me.BtnFinal.TabIndex = 25
        Me.BtnFinal.Text = ">>"
        Me.BtnFinal.UseVisualStyleBackColor = True
        '
        'BtnPrincipio
        '
        Me.BtnPrincipio.Location = New System.Drawing.Point(73, 99)
        Me.BtnPrincipio.Name = "BtnPrincipio"
        Me.BtnPrincipio.Size = New System.Drawing.Size(30, 23)
        Me.BtnPrincipio.TabIndex = 24
        Me.BtnPrincipio.Text = "<<"
        Me.BtnPrincipio.UseVisualStyleBackColor = True
        '
        'BtnHacer
        '
        Me.BtnHacer.Location = New System.Drawing.Point(148, 255)
        Me.BtnHacer.Name = "BtnHacer"
        Me.BtnHacer.Size = New System.Drawing.Size(91, 23)
        Me.BtnHacer.TabIndex = 21
        Me.BtnHacer.Text = "Hacer Reserva"
        Me.BtnHacer.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.Location = New System.Drawing.Point(237, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Fecha"
        '
        'TxtFecha
        '
        Me.TxtFecha.Location = New System.Drawing.Point(229, 160)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(100, 20)
        Me.TxtFecha.TabIndex = 20
        '
        'TxtEstado2
        '
        Me.TxtEstado2.Location = New System.Drawing.Point(176, 74)
        Me.TxtEstado2.Name = "TxtEstado2"
        Me.TxtEstado2.Size = New System.Drawing.Size(100, 20)
        Me.TxtEstado2.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Location = New System.Drawing.Point(21, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Habitación"
        '
        'LblHabitacion
        '
        Me.LblHabitacion.AutoSize = True
        Me.LblHabitacion.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LblHabitacion.Location = New System.Drawing.Point(91, 74)
        Me.LblHabitacion.Name = "LblHabitacion"
        Me.LblHabitacion.Size = New System.Drawing.Size(25, 13)
        Me.LblHabitacion.TabIndex = 18
        Me.LblHabitacion.Text = "???"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(199, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Estado"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(880, 557)
        Me.Controls.Add(Me.BtnSiguiente)
        Me.Controls.Add(Me.BtnAnterior)
        Me.Controls.Add(Me.BtnFinal)
        Me.Controls.Add(Me.BtnPrincipio)
        Me.Controls.Add(Me.BtnHacer)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtFecha)
        Me.Controls.Add(Me.TxtEstado2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LblHabitacion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtFin)
        Me.Controls.Add(Me.MonthCalendar2)
        Me.Controls.Add(Me.TxtInicio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnVer)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Gestión Hotel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnVer As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtInicio As System.Windows.Forms.TextBox
    Friend WithEvents TxtFin As System.Windows.Forms.TextBox
    Friend WithEvents MonthCalendar2 As System.Windows.Forms.MonthCalendar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents BtnSiguiente As System.Windows.Forms.Button
    Friend WithEvents BtnAnterior As System.Windows.Forms.Button
    Friend WithEvents BtnFinal As System.Windows.Forms.Button
    Friend WithEvents BtnPrincipio As System.Windows.Forms.Button
    Friend WithEvents BtnHacer As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtFecha As System.Windows.Forms.TextBox
    Friend WithEvents TxtEstado2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LblHabitacion As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class

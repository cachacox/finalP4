<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInsertar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNumINC = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxPrioridad = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtHoras = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtFechaEstimada = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.lblFechaCreacion = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbxModulo = New System.Windows.Forms.ComboBox()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Incidente #: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(81, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "IN - "
        '
        'lblNumINC
        '
        Me.lblNumINC.AutoSize = True
        Me.lblNumINC.Location = New System.Drawing.Point(103, 8)
        Me.lblNumINC.Name = "lblNumINC"
        Me.lblNumINC.Size = New System.Drawing.Size(0, 13)
        Me.lblNumINC.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Usuario: "
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(116, 38)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(150, 20)
        Me.txtNombre.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Fecha creación: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Prioridad: "
        '
        'cbxPrioridad
        '
        Me.cbxPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPrioridad.FormattingEnabled = True
        Me.cbxPrioridad.Items.AddRange(New Object() {"Emergencia", "Alta", "Media", "Baja"})
        Me.cbxPrioridad.Location = New System.Drawing.Point(117, 103)
        Me.cbxPrioridad.Name = "cbxPrioridad"
        Me.cbxPrioridad.Size = New System.Drawing.Size(121, 21)
        Me.cbxPrioridad.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Horas: "
        '
        'txtHoras
        '
        Me.txtHoras.Enabled = False
        Me.txtHoras.Location = New System.Drawing.Point(117, 137)
        Me.txtHoras.Name = "txtHoras"
        Me.txtHoras.Size = New System.Drawing.Size(33, 20)
        Me.txtHoras.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Fecha Estimada: "
        '
        'txtFechaEstimada
        '
        Me.txtFechaEstimada.Enabled = False
        Me.txtFechaEstimada.Location = New System.Drawing.Point(117, 167)
        Me.txtFechaEstimada.Name = "txtFechaEstimada"
        Me.txtFechaEstimada.Size = New System.Drawing.Size(195, 20)
        Me.txtFechaEstimada.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 206)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Estado: "
        '
        'txtEstado
        '
        Me.txtEstado.Enabled = False
        Me.txtEstado.Location = New System.Drawing.Point(117, 199)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(100, 20)
        Me.txtEstado.TabIndex = 14
        Me.txtEstado.Text = "Pendiente"
        '
        'lblFechaCreacion
        '
        Me.lblFechaCreacion.AutoSize = True
        Me.lblFechaCreacion.Location = New System.Drawing.Point(117, 75)
        Me.lblFechaCreacion.Name = "lblFechaCreacion"
        Me.lblFechaCreacion.Size = New System.Drawing.Size(0, 13)
        Me.lblFechaCreacion.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 236)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Modulo: "
        '
        'cbxModulo
        '
        Me.cbxModulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxModulo.FormattingEnabled = True
        Me.cbxModulo.Items.AddRange(New Object() {"AIA", "AIA - Integracion Siebel", "ATV", "ATV - Error Datos", "ATV Error Datos", "BEM - Invoice", "BO", "BRM  - Invoice", "BRM - Ajuste", "BRM - Ajustes", "BRM - Billing", "BRM - Collections ", "BRM - Cuentas", "BRM -- Cuentas", "BRM - Facturacion", "BRM - GL", "BRM - Invoice", "BRM - Pricing", "BRM - Raring", "BRM - Rating", "BRM - Roaming", "BRM - Tasacion", "BRM . Cuentas", "BRM -Ajustes", "BRM- Invoice", "Concilia", "Concilia ", "CRM", "CRM - Datos", "CRM Aplicativo", "GUI - Operativa", "GUI - Operativa Error Humano", "ICEPAD", "Infraestrucutra", "Integracion - BRM", "Integracion - Legados ", "Integracion - Legados - Cofra", "Integracion - Legados - Compra", "Integracion - Legados - Gepa", "Integracion - Legados - Notificacion", "Integracion - Legados - Remo", "Integracion - Legados -Gepa", "Integracion - Legados- Remo", "Integracion - Siebel", "Integracon - Legados - Gepa", "Integracon - Siebel", "Intregracion - BRM", "Migracion", "MZ", "N/A", "Portabilidad", "Portal Corporativo", "Reportes", "Sincronizacion Datos"})
        Me.cbxModulo.Location = New System.Drawing.Point(117, 228)
        Me.cbxModulo.Name = "cbxModulo"
        Me.cbxModulo.Size = New System.Drawing.Size(150, 21)
        Me.cbxModulo.TabIndex = 17
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(380, 135)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(75, 23)
        Me.btnInsertar.TabIndex = 18
        Me.btnInsertar.Text = "&Guardar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'frmInsertar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 354)
        Me.Controls.Add(Me.btnInsertar)
        Me.Controls.Add(Me.cbxModulo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblFechaCreacion)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtFechaEstimada)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtHoras)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbxPrioridad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblNumINC)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmInsertar"
        Me.Text = "Insertar Incidente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNumINC As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbxPrioridad As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtHoras As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtFechaEstimada As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents lblFechaCreacion As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbxModulo As ComboBox
    Friend WithEvents btnInsertar As Button
End Class

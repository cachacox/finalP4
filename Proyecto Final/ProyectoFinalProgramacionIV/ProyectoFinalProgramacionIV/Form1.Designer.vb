<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PanelResumen = New System.Windows.Forms.Panel()
        Me.LabelCargando = New System.Windows.Forms.Label()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.ButtonGuardarData = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonCargarExcel = New System.Windows.Forms.Button()
        Me.Resumenes = New System.Windows.Forms.Label()
        Me.ButtonIncidentesResueltos = New System.Windows.Forms.Button()
        Me.ButtonIncidentesNuevos = New System.Windows.Forms.Button()
        Me.ButtonIncidentesPendientes = New System.Windows.Forms.Button()
        Me.ButtonIncidentesMora = New System.Windows.Forms.Button()
        Me.ButtonModulosAfectados = New System.Windows.Forms.Button()
        Me.DataGridViewPrincipal = New System.Windows.Forms.DataGridView()
        Me.ButtonInsertar = New System.Windows.Forms.Button()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ButtonModificar = New System.Windows.Forms.Button()
        Me.ButtonActualizar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPrincIncidente = New System.Windows.Forms.TextBox()
        Me.txtPrincUsuario = New System.Windows.Forms.TextBox()
        Me.txtPrincFechaCrea = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPrincHoras = New System.Windows.Forms.TextBox()
        Me.txtPrincFechaEst = New System.Windows.Forms.TextBox()
        Me.txtPrincEstado = New System.Windows.Forms.TextBox()
        Me.txtPrincPrioridad = New System.Windows.Forms.TextBox()
        Me.dtpPrincAsignado = New System.Windows.Forms.DateTimePicker()
        Me.dtpPrincResol = New System.Windows.Forms.DateTimePicker()
        Me.cbxPrincModulo = New System.Windows.Forms.ComboBox()
        Me.cbxPrincPrioReal = New System.Windows.Forms.ComboBox()
        Me.PanelResumen.SuspendLayout()
        CType(Me.DataGridViewPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelResumen
        '
        Me.PanelResumen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelResumen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelResumen.Controls.Add(Me.LabelCargando)
        Me.PanelResumen.Controls.Add(Me.ProgressBar)
        Me.PanelResumen.Controls.Add(Me.ButtonGuardarData)
        Me.PanelResumen.Controls.Add(Me.Label1)
        Me.PanelResumen.Controls.Add(Me.ButtonCargarExcel)
        Me.PanelResumen.Controls.Add(Me.Resumenes)
        Me.PanelResumen.Controls.Add(Me.ButtonIncidentesResueltos)
        Me.PanelResumen.Controls.Add(Me.ButtonIncidentesNuevos)
        Me.PanelResumen.Controls.Add(Me.ButtonIncidentesPendientes)
        Me.PanelResumen.Controls.Add(Me.ButtonIncidentesMora)
        Me.PanelResumen.Controls.Add(Me.ButtonModulosAfectados)
        Me.PanelResumen.Location = New System.Drawing.Point(784, 2)
        Me.PanelResumen.Name = "PanelResumen"
        Me.PanelResumen.Size = New System.Drawing.Size(153, 422)
        Me.PanelResumen.TabIndex = 0
        '
        'LabelCargando
        '
        Me.LabelCargando.AutoSize = True
        Me.LabelCargando.Location = New System.Drawing.Point(46, 113)
        Me.LabelCargando.Name = "LabelCargando"
        Me.LabelCargando.Size = New System.Drawing.Size(53, 13)
        Me.LabelCargando.TabIndex = 8
        Me.LabelCargando.Text = "Cargando"
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(10, 132)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(131, 23)
        Me.ProgressBar.TabIndex = 6
        '
        'ButtonGuardarData
        '
        Me.ButtonGuardarData.Location = New System.Drawing.Point(10, 74)
        Me.ButtonGuardarData.Name = "ButtonGuardarData"
        Me.ButtonGuardarData.Size = New System.Drawing.Size(131, 23)
        Me.ButtonGuardarData.TabIndex = 7
        Me.ButtonGuardarData.Text = "Guardar en SQL"
        Me.ButtonGuardarData.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Comandos"
        '
        'ButtonCargarExcel
        '
        Me.ButtonCargarExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonCargarExcel.Location = New System.Drawing.Point(10, 36)
        Me.ButtonCargarExcel.Name = "ButtonCargarExcel"
        Me.ButtonCargarExcel.Size = New System.Drawing.Size(131, 23)
        Me.ButtonCargarExcel.TabIndex = 6
        Me.ButtonCargarExcel.Text = "Importar Excel"
        Me.ButtonCargarExcel.UseVisualStyleBackColor = True
        '
        'Resumenes
        '
        Me.Resumenes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Resumenes.AutoSize = True
        Me.Resumenes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resumenes.Location = New System.Drawing.Point(33, 168)
        Me.Resumenes.Name = "Resumenes"
        Me.Resumenes.Size = New System.Drawing.Size(92, 17)
        Me.Resumenes.TabIndex = 5
        Me.Resumenes.Text = "Resumenes"
        '
        'ButtonIncidentesResueltos
        '
        Me.ButtonIncidentesResueltos.Location = New System.Drawing.Point(10, 376)
        Me.ButtonIncidentesResueltos.Name = "ButtonIncidentesResueltos"
        Me.ButtonIncidentesResueltos.Size = New System.Drawing.Size(132, 23)
        Me.ButtonIncidentesResueltos.TabIndex = 4
        Me.ButtonIncidentesResueltos.Text = "Incidentes Resueltos"
        Me.ButtonIncidentesResueltos.UseVisualStyleBackColor = True
        '
        'ButtonIncidentesNuevos
        '
        Me.ButtonIncidentesNuevos.Location = New System.Drawing.Point(10, 333)
        Me.ButtonIncidentesNuevos.Name = "ButtonIncidentesNuevos"
        Me.ButtonIncidentesNuevos.Size = New System.Drawing.Size(132, 23)
        Me.ButtonIncidentesNuevos.TabIndex = 3
        Me.ButtonIncidentesNuevos.Text = "Incidentes Nuevos"
        Me.ButtonIncidentesNuevos.UseVisualStyleBackColor = True
        '
        'ButtonIncidentesPendientes
        '
        Me.ButtonIncidentesPendientes.Location = New System.Drawing.Point(10, 289)
        Me.ButtonIncidentesPendientes.Name = "ButtonIncidentesPendientes"
        Me.ButtonIncidentesPendientes.Size = New System.Drawing.Size(132, 23)
        Me.ButtonIncidentesPendientes.TabIndex = 2
        Me.ButtonIncidentesPendientes.Text = "Incidentes Pendientes"
        Me.ButtonIncidentesPendientes.UseVisualStyleBackColor = True
        '
        'ButtonIncidentesMora
        '
        Me.ButtonIncidentesMora.Location = New System.Drawing.Point(10, 247)
        Me.ButtonIncidentesMora.Name = "ButtonIncidentesMora"
        Me.ButtonIncidentesMora.Size = New System.Drawing.Size(132, 23)
        Me.ButtonIncidentesMora.TabIndex = 1
        Me.ButtonIncidentesMora.Text = "Incidentes de Mora"
        Me.ButtonIncidentesMora.UseVisualStyleBackColor = True
        '
        'ButtonModulosAfectados
        '
        Me.ButtonModulosAfectados.Location = New System.Drawing.Point(10, 202)
        Me.ButtonModulosAfectados.Name = "ButtonModulosAfectados"
        Me.ButtonModulosAfectados.Size = New System.Drawing.Size(132, 23)
        Me.ButtonModulosAfectados.TabIndex = 0
        Me.ButtonModulosAfectados.Text = "Modulos Afectados"
        Me.ButtonModulosAfectados.UseVisualStyleBackColor = True
        '
        'DataGridViewPrincipal
        '
        Me.DataGridViewPrincipal.AllowUserToAddRows = False
        Me.DataGridViewPrincipal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewPrincipal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPrincipal.Location = New System.Drawing.Point(12, 197)
        Me.DataGridViewPrincipal.Name = "DataGridViewPrincipal"
        Me.DataGridViewPrincipal.Size = New System.Drawing.Size(757, 218)
        Me.DataGridViewPrincipal.TabIndex = 1
        '
        'ButtonInsertar
        '
        Me.ButtonInsertar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonInsertar.Location = New System.Drawing.Point(694, 46)
        Me.ButtonInsertar.Name = "ButtonInsertar"
        Me.ButtonInsertar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonInsertar.TabIndex = 2
        Me.ButtonInsertar.Text = "Insertar"
        Me.ButtonInsertar.UseVisualStyleBackColor = True
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonEliminar.Location = New System.Drawing.Point(694, 75)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEliminar.TabIndex = 3
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = True
        '
        'ButtonModificar
        '
        Me.ButtonModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonModificar.Location = New System.Drawing.Point(694, 104)
        Me.ButtonModificar.Name = "ButtonModificar"
        Me.ButtonModificar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonModificar.TabIndex = 4
        Me.ButtonModificar.Text = "Modificar"
        Me.ButtonModificar.UseVisualStyleBackColor = True
        '
        'ButtonActualizar
        '
        Me.ButtonActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonActualizar.Location = New System.Drawing.Point(694, 133)
        Me.ButtonActualizar.Name = "ButtonActualizar"
        Me.ButtonActualizar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonActualizar.TabIndex = 5
        Me.ButtonActualizar.Text = "Actualizar"
        Me.ButtonActualizar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "No. Incidente:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Usuario:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fecha Creación:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Prioridad:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Prioridad Real:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(335, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Estado:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(333, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Fecha Resolución:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(332, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Fecha Asignado:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(333, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Fecha Estimada:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(332, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Horas:"
        '
        'txtPrincIncidente
        '
        Me.txtPrincIncidente.Enabled = False
        Me.txtPrincIncidente.Location = New System.Drawing.Point(118, 12)
        Me.txtPrincIncidente.Name = "txtPrincIncidente"
        Me.txtPrincIncidente.Size = New System.Drawing.Size(80, 20)
        Me.txtPrincIncidente.TabIndex = 16
        '
        'txtPrincUsuario
        '
        Me.txtPrincUsuario.Enabled = False
        Me.txtPrincUsuario.Location = New System.Drawing.Point(118, 43)
        Me.txtPrincUsuario.Name = "txtPrincUsuario"
        Me.txtPrincUsuario.Size = New System.Drawing.Size(132, 20)
        Me.txtPrincUsuario.TabIndex = 17
        '
        'txtPrincFechaCrea
        '
        Me.txtPrincFechaCrea.Enabled = False
        Me.txtPrincFechaCrea.Location = New System.Drawing.Point(118, 78)
        Me.txtPrincFechaCrea.Name = "txtPrincFechaCrea"
        Me.txtPrincFechaCrea.Size = New System.Drawing.Size(190, 20)
        Me.txtPrincFechaCrea.TabIndex = 18
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(335, 164)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Módulo:"
        '
        'txtPrincHoras
        '
        Me.txtPrincHoras.Enabled = False
        Me.txtPrincHoras.Location = New System.Drawing.Point(430, 8)
        Me.txtPrincHoras.Name = "txtPrincHoras"
        Me.txtPrincHoras.Size = New System.Drawing.Size(43, 20)
        Me.txtPrincHoras.TabIndex = 22
        '
        'txtPrincFechaEst
        '
        Me.txtPrincFechaEst.Enabled = False
        Me.txtPrincFechaEst.Location = New System.Drawing.Point(430, 37)
        Me.txtPrincFechaEst.Name = "txtPrincFechaEst"
        Me.txtPrincFechaEst.Size = New System.Drawing.Size(140, 20)
        Me.txtPrincFechaEst.TabIndex = 23
        '
        'txtPrincEstado
        '
        Me.txtPrincEstado.Enabled = False
        Me.txtPrincEstado.Location = New System.Drawing.Point(430, 125)
        Me.txtPrincEstado.Name = "txtPrincEstado"
        Me.txtPrincEstado.Size = New System.Drawing.Size(80, 20)
        Me.txtPrincEstado.TabIndex = 26
        '
        'txtPrincPrioridad
        '
        Me.txtPrincPrioridad.Enabled = False
        Me.txtPrincPrioridad.Location = New System.Drawing.Point(118, 114)
        Me.txtPrincPrioridad.Name = "txtPrincPrioridad"
        Me.txtPrincPrioridad.Size = New System.Drawing.Size(80, 20)
        Me.txtPrincPrioridad.TabIndex = 20
        '
        'dtpPrincAsignado
        '
        Me.dtpPrincAsignado.Enabled = False
        Me.dtpPrincAsignado.Location = New System.Drawing.Point(430, 66)
        Me.dtpPrincAsignado.Name = "dtpPrincAsignado"
        Me.dtpPrincAsignado.Size = New System.Drawing.Size(200, 20)
        Me.dtpPrincAsignado.TabIndex = 28
        '
        'dtpPrincResol
        '
        Me.dtpPrincResol.Enabled = False
        Me.dtpPrincResol.Location = New System.Drawing.Point(430, 95)
        Me.dtpPrincResol.Name = "dtpPrincResol"
        Me.dtpPrincResol.Size = New System.Drawing.Size(200, 20)
        Me.dtpPrincResol.TabIndex = 29
        '
        'cbxPrincModulo
        '
        Me.cbxPrincModulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPrincModulo.FormattingEnabled = True
        Me.cbxPrincModulo.Items.AddRange(New Object() {"AIA", "AIA - Integracion Siebel", "ATV", "ATV - Error Datos", "ATV Error Datos", "BEM - Invoice", "BO", "BRM  - Invoice", "BRM - Ajuste", "BRM - Ajustes", "BRM - Billing", "BRM - Collections ", "BRM - Cuentas", "BRM -- Cuentas", "BRM - Facturacion", "BRM - GL", "BRM - Invoice", "BRM - Pricing", "BRM - Raring", "BRM - Rating", "BRM - Roaming", "BRM - Tasacion", "BRM . Cuentas", "BRM -Ajustes", "BRM- Invoice", "Concilia", "Concilia ", "CRM", "CRM - Datos", "CRM Aplicativo", "GUI - Operativa", "GUI - Operativa Error Humano", "ICEPAD", "Infraestrucutra", "Integracion - BRM", "Integracion - Legados ", "Integracion - Legados - Cofra", "Integracion - Legados - Compra", "Integracion - Legados - Gepa", "Integracion - Legados - Notificacion", "Integracion - Legados - Remo", "Integracion - Legados -Gepa", "Integracion - Legados- Remo", "Integracion - Siebel", "Integracon - Legados - Gepa", "Integracon - Siebel", "Intregracion - BRM", "Migracion", "MZ", "N/A", "Portabilidad", "Portal Corporativo", "Reportes", "Sincronizacion Datos"})
        Me.cbxPrincModulo.Location = New System.Drawing.Point(430, 155)
        Me.cbxPrincModulo.Name = "cbxPrincModulo"
        Me.cbxPrincModulo.Size = New System.Drawing.Size(121, 21)
        Me.cbxPrincModulo.TabIndex = 30
        '
        'cbxPrincPrioReal
        '
        Me.cbxPrincPrioReal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPrincPrioReal.FormattingEnabled = True
        Me.cbxPrincPrioReal.Items.AddRange(New Object() {"", "Emergencia", "Alta", "Media", "Baja"})
        Me.cbxPrincPrioReal.Location = New System.Drawing.Point(118, 148)
        Me.cbxPrincPrioReal.Name = "cbxPrincPrioReal"
        Me.cbxPrincPrioReal.Size = New System.Drawing.Size(80, 21)
        Me.cbxPrincPrioReal.TabIndex = 31
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 427)
        Me.Controls.Add(Me.cbxPrincPrioReal)
        Me.Controls.Add(Me.cbxPrincModulo)
        Me.Controls.Add(Me.dtpPrincResol)
        Me.Controls.Add(Me.dtpPrincAsignado)
        Me.Controls.Add(Me.txtPrincEstado)
        Me.Controls.Add(Me.txtPrincFechaEst)
        Me.Controls.Add(Me.txtPrincHoras)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtPrincPrioridad)
        Me.Controls.Add(Me.txtPrincFechaCrea)
        Me.Controls.Add(Me.txtPrincUsuario)
        Me.Controls.Add(Me.txtPrincIncidente)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonActualizar)
        Me.Controls.Add(Me.ButtonModificar)
        Me.Controls.Add(Me.ButtonEliminar)
        Me.Controls.Add(Me.ButtonInsertar)
        Me.Controls.Add(Me.DataGridViewPrincipal)
        Me.Controls.Add(Me.PanelResumen)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proyecto Final Programación IV"
        Me.PanelResumen.ResumeLayout(False)
        Me.PanelResumen.PerformLayout()
        CType(Me.DataGridViewPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelResumen As Panel
    Friend WithEvents Resumenes As Label
    Friend WithEvents ButtonIncidentesResueltos As Button
    Friend WithEvents ButtonIncidentesNuevos As Button
    Friend WithEvents ButtonIncidentesPendientes As Button
    Friend WithEvents ButtonIncidentesMora As Button
    Friend WithEvents ButtonModulosAfectados As Button
    Friend WithEvents DataGridViewPrincipal As DataGridView
    Friend WithEvents ButtonInsertar As Button
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents ButtonModificar As Button
    Friend WithEvents ButtonActualizar As Button
    Friend WithEvents ButtonCargarExcel As Button
    Friend WithEvents ButtonGuardarData As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents LabelCargando As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPrincIncidente As TextBox
    Friend WithEvents txtPrincUsuario As TextBox
    Friend WithEvents txtPrincFechaCrea As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtPrincHoras As TextBox
    Friend WithEvents txtPrincFechaEst As TextBox
    Friend WithEvents txtPrincEstado As TextBox
    Friend WithEvents txtPrincPrioridad As TextBox
    Friend WithEvents dtpPrincAsignado As DateTimePicker
    Friend WithEvents dtpPrincResol As DateTimePicker
    Friend WithEvents cbxPrincModulo As ComboBox
    Friend WithEvents cbxPrincPrioReal As ComboBox
End Class

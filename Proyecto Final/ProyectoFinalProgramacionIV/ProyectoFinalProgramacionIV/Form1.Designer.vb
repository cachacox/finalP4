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
        Me.PanelResumen.Location = New System.Drawing.Point(677, 2)
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
        Me.DataGridViewPrincipal.Size = New System.Drawing.Size(650, 218)
        Me.DataGridViewPrincipal.TabIndex = 1
        '
        'ButtonInsertar
        '
        Me.ButtonInsertar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonInsertar.Location = New System.Drawing.Point(587, 78)
        Me.ButtonInsertar.Name = "ButtonInsertar"
        Me.ButtonInsertar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonInsertar.TabIndex = 2
        Me.ButtonInsertar.Text = "Insertar"
        Me.ButtonInsertar.UseVisualStyleBackColor = True
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonEliminar.Location = New System.Drawing.Point(587, 107)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEliminar.TabIndex = 3
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = True
        '
        'ButtonModificar
        '
        Me.ButtonModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonModificar.Location = New System.Drawing.Point(587, 136)
        Me.ButtonModificar.Name = "ButtonModificar"
        Me.ButtonModificar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonModificar.TabIndex = 4
        Me.ButtonModificar.Text = "Modificar"
        Me.ButtonModificar.UseVisualStyleBackColor = True
        '
        'ButtonActualizar
        '
        Me.ButtonActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonActualizar.Location = New System.Drawing.Point(587, 165)
        Me.ButtonActualizar.Name = "ButtonActualizar"
        Me.ButtonActualizar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonActualizar.TabIndex = 5
        Me.ButtonActualizar.Text = "Actualizar"
        Me.ButtonActualizar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Label3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 427)
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
End Class

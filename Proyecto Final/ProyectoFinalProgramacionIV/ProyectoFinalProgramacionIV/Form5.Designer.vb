﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IncidentesNuevos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IncidentesNuevos))
        Me.DataGridViewIncidentesNuevos = New System.Windows.Forms.DataGridView()
        Me.ButtonFiltrar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePickerFinal = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxFiltro = New System.Windows.Forms.ComboBox()
        Me.ButtonRestablecerFiltro = New System.Windows.Forms.Button()
        CType(Me.DataGridViewIncidentesNuevos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewIncidentesNuevos
        '
        Me.DataGridViewIncidentesNuevos.AllowUserToAddRows = False
        Me.DataGridViewIncidentesNuevos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewIncidentesNuevos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewIncidentesNuevos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewIncidentesNuevos.Location = New System.Drawing.Point(12, 134)
        Me.DataGridViewIncidentesNuevos.Name = "DataGridViewIncidentesNuevos"
        Me.DataGridViewIncidentesNuevos.Size = New System.Drawing.Size(560, 215)
        Me.DataGridViewIncidentesNuevos.TabIndex = 0
        '
        'ButtonFiltrar
        '
        Me.ButtonFiltrar.Location = New System.Drawing.Point(60, 105)
        Me.ButtonFiltrar.Name = "ButtonFiltrar"
        Me.ButtonFiltrar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonFiltrar.TabIndex = 14
        Me.ButtonFiltrar.Text = "Filtrar"
        Me.ButtonFiltrar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Inicio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Final:"
        '
        'DateTimePickerFinal
        '
        Me.DateTimePickerFinal.Location = New System.Drawing.Point(60, 76)
        Me.DateTimePickerFinal.Name = "DateTimePickerFinal"
        Me.DateTimePickerFinal.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerFinal.TabIndex = 11
        '
        'DateTimePickerInicio
        '
        Me.DateTimePickerInicio.Location = New System.Drawing.Point(60, 45)
        Me.DateTimePickerInicio.Name = "DateTimePickerInicio"
        Me.DateTimePickerInicio.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerInicio.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Modulo:"
        '
        'ComboBoxFiltro
        '
        Me.ComboBoxFiltro.FormattingEnabled = True
        Me.ComboBoxFiltro.Location = New System.Drawing.Point(60, 12)
        Me.ComboBoxFiltro.Name = "ComboBoxFiltro"
        Me.ComboBoxFiltro.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxFiltro.TabIndex = 8
        '
        'ButtonRestablecerFiltro
        '
        Me.ButtonRestablecerFiltro.Location = New System.Drawing.Point(141, 105)
        Me.ButtonRestablecerFiltro.Name = "ButtonRestablecerFiltro"
        Me.ButtonRestablecerFiltro.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRestablecerFiltro.TabIndex = 16
        Me.ButtonRestablecerFiltro.Text = "Restablecer"
        Me.ButtonRestablecerFiltro.UseVisualStyleBackColor = True
        '
        'IncidentesNuevos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.ButtonRestablecerFiltro)
        Me.Controls.Add(Me.ButtonFiltrar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePickerFinal)
        Me.Controls.Add(Me.DateTimePickerInicio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxFiltro)
        Me.Controls.Add(Me.DataGridViewIncidentesNuevos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "IncidentesNuevos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Incidentes Nuevos"
        CType(Me.DataGridViewIncidentesNuevos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewIncidentesNuevos As DataGridView
    Friend WithEvents ButtonFiltrar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePickerFinal As DateTimePicker
    Friend WithEvents DateTimePickerInicio As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxFiltro As ComboBox
    Friend WithEvents ButtonRestablecerFiltro As Button
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IncidentesResueltos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IncidentesResueltos))
        Me.DataGridViewIncidentesResueltos = New System.Windows.Forms.DataGridView()
        Me.ComboBoxFiltro = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePickerInicio = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonFiltrar = New System.Windows.Forms.Button()
        Me.ButtonRestablecerFiltro = New System.Windows.Forms.Button()
        CType(Me.DataGridViewIncidentesResueltos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewIncidentesResueltos
        '
        Me.DataGridViewIncidentesResueltos.AllowUserToAddRows = False
        Me.DataGridViewIncidentesResueltos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewIncidentesResueltos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewIncidentesResueltos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewIncidentesResueltos.Location = New System.Drawing.Point(12, 131)
        Me.DataGridViewIncidentesResueltos.Name = "DataGridViewIncidentesResueltos"
        Me.DataGridViewIncidentesResueltos.Size = New System.Drawing.Size(560, 218)
        Me.DataGridViewIncidentesResueltos.TabIndex = 0
        '
        'ComboBoxFiltro
        '
        Me.ComboBoxFiltro.FormattingEnabled = True
        Me.ComboBoxFiltro.Location = New System.Drawing.Point(61, 9)
        Me.ComboBoxFiltro.Name = "ComboBoxFiltro"
        Me.ComboBoxFiltro.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxFiltro.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Modulo:"
        '
        'DateTimePickerInicio
        '
        Me.DateTimePickerInicio.Location = New System.Drawing.Point(61, 42)
        Me.DateTimePickerInicio.Name = "DateTimePickerInicio"
        Me.DateTimePickerInicio.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerInicio.TabIndex = 3
        '
        'DateTimePickerFinal
        '
        Me.DateTimePickerFinal.Location = New System.Drawing.Point(61, 73)
        Me.DateTimePickerFinal.Name = "DateTimePickerFinal"
        Me.DateTimePickerFinal.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerFinal.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Final:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Inicio:"
        '
        'ButtonFiltrar
        '
        Me.ButtonFiltrar.Location = New System.Drawing.Point(61, 102)
        Me.ButtonFiltrar.Name = "ButtonFiltrar"
        Me.ButtonFiltrar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonFiltrar.TabIndex = 7
        Me.ButtonFiltrar.Text = "Filtrar"
        Me.ButtonFiltrar.UseVisualStyleBackColor = True
        '
        'ButtonRestablecerFiltro
        '
        Me.ButtonRestablecerFiltro.Location = New System.Drawing.Point(142, 102)
        Me.ButtonRestablecerFiltro.Name = "ButtonRestablecerFiltro"
        Me.ButtonRestablecerFiltro.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRestablecerFiltro.TabIndex = 16
        Me.ButtonRestablecerFiltro.Text = "Restablecer"
        Me.ButtonRestablecerFiltro.UseVisualStyleBackColor = True
        '
        'IncidentesResueltos
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
        Me.Controls.Add(Me.DataGridViewIncidentesResueltos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "IncidentesResueltos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Incidentes Resueltos"
        CType(Me.DataGridViewIncidentesResueltos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewIncidentesResueltos As DataGridView
    Friend WithEvents ComboBoxFiltro As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePickerInicio As DateTimePicker
    Friend WithEvents DateTimePickerFinal As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonFiltrar As Button
    Friend WithEvents ButtonRestablecerFiltro As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        CType(Me.DataGridViewIncidentesNuevos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewIncidentesNuevos
        '
        Me.DataGridViewIncidentesNuevos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewIncidentesNuevos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewIncidentesNuevos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewIncidentesNuevos.Location = New System.Drawing.Point(12, 12)
        Me.DataGridViewIncidentesNuevos.Name = "DataGridViewIncidentesNuevos"
        Me.DataGridViewIncidentesNuevos.Size = New System.Drawing.Size(560, 337)
        Me.DataGridViewIncidentesNuevos.TabIndex = 0
        '
        'IncidentesNuevos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.DataGridViewIncidentesNuevos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "IncidentesNuevos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Incidentes Nuevos"
        CType(Me.DataGridViewIncidentesNuevos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewIncidentesNuevos As DataGridView
End Class

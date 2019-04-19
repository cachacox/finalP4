<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        CType(Me.DataGridViewIncidentesResueltos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewIncidentesResueltos
        '
        Me.DataGridViewIncidentesResueltos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewIncidentesResueltos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewIncidentesResueltos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewIncidentesResueltos.Location = New System.Drawing.Point(12, 12)
        Me.DataGridViewIncidentesResueltos.Name = "DataGridViewIncidentesResueltos"
        Me.DataGridViewIncidentesResueltos.Size = New System.Drawing.Size(560, 337)
        Me.DataGridViewIncidentesResueltos.TabIndex = 0
        '
        'IncidentesResueltos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.DataGridViewIncidentesResueltos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "IncidentesResueltos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Incidentes Resueltos"
        CType(Me.DataGridViewIncidentesResueltos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewIncidentesResueltos As DataGridView
End Class

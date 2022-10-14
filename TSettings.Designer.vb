<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TSettings
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TSettings))
        Me.Closea = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DMode = New System.Windows.Forms.Button()
        Me.Lmode = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Closea
        '
        Me.Closea.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Closea.AutoSize = True
        Me.Closea.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Closea.Location = New System.Drawing.Point(411, 0)
        Me.Closea.Name = "Closea"
        Me.Closea.Size = New System.Drawing.Size(37, 37)
        Me.Closea.TabIndex = 144
        Me.Closea.Text = "X"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 38)
        Me.Label1.TabIndex = 146
        Me.Label1.Text = "Theme Settings"
        '
        'DMode
        '
        Me.DMode.BackColor = System.Drawing.SystemColors.ControlText
        Me.DMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DMode.ForeColor = System.Drawing.SystemColors.Control
        Me.DMode.Location = New System.Drawing.Point(41, 149)
        Me.DMode.Name = "DMode"
        Me.DMode.Size = New System.Drawing.Size(166, 33)
        Me.DMode.TabIndex = 149
        Me.DMode.Text = "Dark Mode"
        Me.DMode.UseVisualStyleBackColor = False
        '
        'Lmode
        '
        Me.Lmode.BackColor = System.Drawing.SystemColors.ControlText
        Me.Lmode.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lmode.ForeColor = System.Drawing.SystemColors.Control
        Me.Lmode.Location = New System.Drawing.Point(233, 149)
        Me.Lmode.Name = "Lmode"
        Me.Lmode.Size = New System.Drawing.Size(166, 33)
        Me.Lmode.TabIndex = 150
        Me.Lmode.Text = "Light Mode"
        Me.Lmode.UseVisualStyleBackColor = False
        '
        'TSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(447, 211)
        Me.Controls.Add(Me.Lmode)
        Me.Controls.Add(Me.DMode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Closea)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "TSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Theme Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Closea As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DMode As Button
    Friend WithEvents Lmode As Button
End Class

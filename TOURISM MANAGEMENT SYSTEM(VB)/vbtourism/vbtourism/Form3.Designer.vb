<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.MAPGB = New System.Windows.Forms.GroupBox
        Me.GOAMAP = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.MAPGB.SuspendLayout()
        CType(Me.GOAMAP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MAPGB
        '
        Me.MAPGB.Controls.Add(Me.GOAMAP)
        Me.MAPGB.Location = New System.Drawing.Point(33, 44)
        Me.MAPGB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MAPGB.Name = "MAPGB"
        Me.MAPGB.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MAPGB.Size = New System.Drawing.Size(1082, 535)
        Me.MAPGB.TabIndex = 12
        Me.MAPGB.TabStop = False
        Me.MAPGB.Text = "MAP"
        '
        'GOAMAP
        '
        Me.GOAMAP.Location = New System.Drawing.Point(92, 23)
        Me.GOAMAP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GOAMAP.Name = "GOAMAP"
        Me.GOAMAP.Size = New System.Drawing.Size(936, 468)
        Me.GOAMAP.TabIndex = 2
        Me.GOAMAP.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(537, 601)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 57)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1186, 702)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MAPGB)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.MAPGB.ResumeLayout(False)
        CType(Me.GOAMAP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MAPGB As System.Windows.Forms.GroupBox
    Friend WithEvents GOAMAP As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

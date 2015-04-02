<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.titlelab = New System.Windows.Forms.Label
        Me.admnbtn = New System.Windows.Forms.Button
        Me.userbtn = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'titlelab
        '
        Me.titlelab.AutoSize = True
        Me.titlelab.Location = New System.Drawing.Point(164, 46)
        Me.titlelab.Name = "titlelab"
        Me.titlelab.Size = New System.Drawing.Size(184, 13)
        Me.titlelab.TabIndex = 0
        Me.titlelab.Text = "TOURISM MANAGEMENT SYSTEM"
        '
        'admnbtn
        '
        Me.admnbtn.Location = New System.Drawing.Point(155, 107)
        Me.admnbtn.Name = "admnbtn"
        Me.admnbtn.Size = New System.Drawing.Size(193, 68)
        Me.admnbtn.TabIndex = 1
        Me.admnbtn.Text = "ADMIN"
        Me.admnbtn.UseVisualStyleBackColor = True
        '
        'userbtn
        '
        Me.userbtn.Location = New System.Drawing.Point(155, 245)
        Me.userbtn.Name = "userbtn"
        Me.userbtn.Size = New System.Drawing.Size(193, 67)
        Me.userbtn.TabIndex = 2
        Me.userbtn.Text = "USER"
        Me.userbtn.UseVisualStyleBackColor = True
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 465)
        Me.Controls.Add(Me.userbtn)
        Me.Controls.Add(Me.admnbtn)
        Me.Controls.Add(Me.titlelab)
        Me.Name = "login"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents titlelab As System.Windows.Forms.Label
    Friend WithEvents admnbtn As System.Windows.Forms.Button
    Friend WithEvents userbtn As System.Windows.Forms.Button

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class user
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
        Me.newbtn = New System.Windows.Forms.Button
        Me.titlab = New System.Windows.Forms.Label
        Me.entrylab = New System.Windows.Forms.Label
        Me.entrytb = New System.Windows.Forms.TextBox
        Me.numlab = New System.Windows.Forms.Label
        Me.numnb = New System.Windows.Forms.NumericUpDown
        Me.checkgb = New System.Windows.Forms.GroupBox
        Me.checkcb = New System.Windows.Forms.CheckBox
        Me.seniornb = New System.Windows.Forms.NumericUpDown
        Me.adultnb = New System.Windows.Forms.NumericUpDown
        Me.childnb = New System.Windows.Forms.NumericUpDown
        Me.seniorlab = New System.Windows.Forms.Label
        Me.adultlab = New System.Windows.Forms.Label
        Me.childlab = New System.Windows.Forms.Label
        Me.addtb = New System.Windows.Forms.RichTextBox
        Me.addlab = New System.Windows.Forms.Label
        CType(Me.numnb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.checkgb.SuspendLayout()
        CType(Me.seniornb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.adultnb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.childnb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'newbtn
        '
        Me.newbtn.Location = New System.Drawing.Point(30, 64)
        Me.newbtn.Name = "newbtn"
        Me.newbtn.Size = New System.Drawing.Size(164, 59)
        Me.newbtn.TabIndex = 0
        Me.newbtn.Text = "CLICK ME TO REGISTER"
        Me.newbtn.UseVisualStyleBackColor = True
        '
        'titlab
        '
        Me.titlab.AutoSize = True
        Me.titlab.Location = New System.Drawing.Point(234, 31)
        Me.titlab.Name = "titlab"
        Me.titlab.Size = New System.Drawing.Size(115, 13)
        Me.titlab.TabIndex = 1
        Me.titlab.Text = "FILL IN THE DETAILS"
        '
        'entrylab
        '
        Me.entrylab.AutoSize = True
        Me.entrylab.Location = New System.Drawing.Point(438, 64)
        Me.entrylab.Name = "entrylab"
        Me.entrylab.Size = New System.Drawing.Size(81, 13)
        Me.entrylab.TabIndex = 2
        Me.entrylab.Text = "REGISTER NO"
        '
        'entrytb
        '
        Me.entrytb.Location = New System.Drawing.Point(531, 57)
        Me.entrytb.Name = "entrytb"
        Me.entrytb.Size = New System.Drawing.Size(100, 20)
        Me.entrytb.TabIndex = 3
        '
        'numlab
        '
        Me.numlab.AutoSize = True
        Me.numlab.Location = New System.Drawing.Point(39, 295)
        Me.numlab.Name = "numlab"
        Me.numlab.Size = New System.Drawing.Size(116, 13)
        Me.numlab.TabIndex = 12
        Me.numlab.Text = "NO OF PASSENGERS"
        '
        'numnb
        '
        Me.numnb.Location = New System.Drawing.Point(237, 288)
        Me.numnb.Name = "numnb"
        Me.numnb.Size = New System.Drawing.Size(120, 20)
        Me.numnb.TabIndex = 13
        '
        'checkgb
        '
        Me.checkgb.Controls.Add(Me.checkcb)
        Me.checkgb.Controls.Add(Me.seniornb)
        Me.checkgb.Controls.Add(Me.adultnb)
        Me.checkgb.Controls.Add(Me.childnb)
        Me.checkgb.Controls.Add(Me.seniorlab)
        Me.checkgb.Controls.Add(Me.adultlab)
        Me.checkgb.Controls.Add(Me.childlab)
        Me.checkgb.Location = New System.Drawing.Point(12, 357)
        Me.checkgb.Name = "checkgb"
        Me.checkgb.Size = New System.Drawing.Size(671, 135)
        Me.checkgb.TabIndex = 14
        Me.checkgb.TabStop = False
        Me.checkgb.Text = "CHECK DETAILS"
        '
        'checkcb
        '
        Me.checkcb.AutoSize = True
        Me.checkcb.Location = New System.Drawing.Point(247, 101)
        Me.checkcb.Name = "checkcb"
        Me.checkcb.Size = New System.Drawing.Size(217, 17)
        Me.checkcb.TabIndex = 6
        Me.checkcb.Text = "CLICK HERE TO PROCEED FURTHER"
        Me.checkcb.UseVisualStyleBackColor = True
        '
        'seniornb
        '
        Me.seniornb.Location = New System.Drawing.Point(515, 61)
        Me.seniornb.Name = "seniornb"
        Me.seniornb.Size = New System.Drawing.Size(120, 20)
        Me.seniornb.TabIndex = 5
        '
        'adultnb
        '
        Me.adultnb.Location = New System.Drawing.Point(275, 61)
        Me.adultnb.Name = "adultnb"
        Me.adultnb.Size = New System.Drawing.Size(120, 20)
        Me.adultnb.TabIndex = 4
        '
        'childnb
        '
        Me.childnb.Location = New System.Drawing.Point(51, 61)
        Me.childnb.Name = "childnb"
        Me.childnb.Size = New System.Drawing.Size(120, 20)
        Me.childnb.TabIndex = 3
        '
        'seniorlab
        '
        Me.seniorlab.AutoSize = True
        Me.seniorlab.Location = New System.Drawing.Point(526, 27)
        Me.seniorlab.Name = "seniorlab"
        Me.seniorlab.Size = New System.Drawing.Size(100, 13)
        Me.seniorlab.TabIndex = 2
        Me.seniorlab.Text = "SENIOR CITIZENS"
        '
        'adultlab
        '
        Me.adultlab.AutoSize = True
        Me.adultlab.Location = New System.Drawing.Point(307, 27)
        Me.adultlab.Name = "adultlab"
        Me.adultlab.Size = New System.Drawing.Size(43, 13)
        Me.adultlab.TabIndex = 1
        Me.adultlab.Text = "ADULT"
        '
        'childlab
        '
        Me.childlab.AutoSize = True
        Me.childlab.Location = New System.Drawing.Point(79, 27)
        Me.childlab.Name = "childlab"
        Me.childlab.Size = New System.Drawing.Size(39, 13)
        Me.childlab.TabIndex = 0
        Me.childlab.Text = "CHILD"
        '
        'addtb
        '
        Me.addtb.Location = New System.Drawing.Point(237, 164)
        Me.addtb.Name = "addtb"
        Me.addtb.Size = New System.Drawing.Size(205, 79)
        Me.addtb.TabIndex = 11
        Me.addtb.Text = ""
        '
        'addlab
        '
        Me.addlab.AutoSize = True
        Me.addlab.Location = New System.Drawing.Point(39, 188)
        Me.addlab.Name = "addlab"
        Me.addlab.Size = New System.Drawing.Size(133, 13)
        Me.addlab.TabIndex = 7
        Me.addlab.Text = "RESIDENTIAL ADDRESS"
        '
        'user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 528)
        Me.Controls.Add(Me.checkgb)
        Me.Controls.Add(Me.numnb)
        Me.Controls.Add(Me.numlab)
        Me.Controls.Add(Me.addtb)
        Me.Controls.Add(Me.addlab)
        Me.Controls.Add(Me.entrytb)
        Me.Controls.Add(Me.entrylab)
        Me.Controls.Add(Me.titlab)
        Me.Controls.Add(Me.newbtn)
        Me.Name = "user"
        Me.Text = "Form1"
        CType(Me.numnb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.checkgb.ResumeLayout(False)
        Me.checkgb.PerformLayout()
        CType(Me.seniornb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.adultnb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.childnb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents newbtn As System.Windows.Forms.Button
    Friend WithEvents titlab As System.Windows.Forms.Label
    Friend WithEvents entrylab As System.Windows.Forms.Label
    Friend WithEvents entrytb As System.Windows.Forms.TextBox
    Friend WithEvents numlab As System.Windows.Forms.Label
    Friend WithEvents numnb As System.Windows.Forms.NumericUpDown
    Friend WithEvents checkgb As System.Windows.Forms.GroupBox
    Friend WithEvents seniornb As System.Windows.Forms.NumericUpDown
    Friend WithEvents adultnb As System.Windows.Forms.NumericUpDown
    Friend WithEvents childnb As System.Windows.Forms.NumericUpDown
    Friend WithEvents seniorlab As System.Windows.Forms.Label
    Friend WithEvents adultlab As System.Windows.Forms.Label
    Friend WithEvents childlab As System.Windows.Forms.Label
    Friend WithEvents checkcb As System.Windows.Forms.CheckBox
    Friend WithEvents addtb As System.Windows.Forms.RichTextBox
    Friend WithEvents addlab As System.Windows.Forms.Label
End Class

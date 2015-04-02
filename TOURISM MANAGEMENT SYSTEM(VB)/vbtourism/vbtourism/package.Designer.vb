<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class package
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
        Me.typelab = New System.Windows.Forms.Label
        Me.pilgrilab = New System.Windows.Forms.Label
        Me.domlab = New System.Windows.Forms.Label
        Me.packcb = New System.Windows.Forms.ComboBox
        Me.domgb = New System.Windows.Forms.GroupBox
        Me.domcb = New System.Windows.Forms.ComboBox
        Me.pilgrigb = New System.Windows.Forms.GroupBox
        Me.pilgricb = New System.Windows.Forms.ComboBox
        Me.hisgb = New System.Windows.Forms.GroupBox
        Me.hiscb = New System.Windows.Forms.ComboBox
        Me.hislab = New System.Windows.Forms.Label
        Me.check1cb = New System.Windows.Forms.CheckBox
        Me.nextbtn1 = New System.Windows.Forms.Button
        Me.numnb = New System.Windows.Forms.NumericUpDown
        Me.newbtn = New System.Windows.Forms.Button
        Me.numlab = New System.Windows.Forms.Label
        Me.addtb = New System.Windows.Forms.RichTextBox
        Me.adultnb = New System.Windows.Forms.NumericUpDown
        Me.entrytb = New System.Windows.Forms.TextBox
        Me.seniornb = New System.Windows.Forms.NumericUpDown
        Me.checkgb = New System.Windows.Forms.GroupBox
        Me.checkcb = New System.Windows.Forms.CheckBox
        Me.childnb = New System.Windows.Forms.NumericUpDown
        Me.seniorlab = New System.Windows.Forms.Label
        Me.adultlab = New System.Windows.Forms.Label
        Me.childlab = New System.Windows.Forms.Label
        Me.titlab = New System.Windows.Forms.Label
        Me.entrylab = New System.Windows.Forms.Label
        Me.addlab = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.domgb.SuspendLayout()
        Me.pilgrigb.SuspendLayout()
        Me.hisgb.SuspendLayout()
        CType(Me.numnb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.adultnb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seniornb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.checkgb.SuspendLayout()
        CType(Me.childnb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'typelab
        '
        Me.typelab.AutoSize = True
        Me.typelab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.typelab.Location = New System.Drawing.Point(33, 330)
        Me.typelab.Name = "typelab"
        Me.typelab.Size = New System.Drawing.Size(136, 13)
        Me.typelab.TabIndex = 1
        Me.typelab.Text = "TYPES OF PACKAGES"
        '
        'pilgrilab
        '
        Me.pilgrilab.AutoSize = True
        Me.pilgrilab.Location = New System.Drawing.Point(23, 39)
        Me.pilgrilab.Name = "pilgrilab"
        Me.pilgrilab.Size = New System.Drawing.Size(54, 13)
        Me.pilgrilab.TabIndex = 2
        Me.pilgrilab.Text = "SELECT"
        '
        'domlab
        '
        Me.domlab.AutoSize = True
        Me.domlab.Location = New System.Drawing.Point(26, 41)
        Me.domlab.Name = "domlab"
        Me.domlab.Size = New System.Drawing.Size(54, 13)
        Me.domlab.TabIndex = 3
        Me.domlab.Text = "SELECT"
        '
        'packcb
        '
        Me.packcb.FormattingEnabled = True
        Me.packcb.Items.AddRange(New Object() {"SELECT", "DOMESTIC", "PILGRIMAGE", "HISTORICAL"})
        Me.packcb.Location = New System.Drawing.Point(233, 330)
        Me.packcb.Name = "packcb"
        Me.packcb.Size = New System.Drawing.Size(140, 21)
        Me.packcb.TabIndex = 7
        '
        'domgb
        '
        Me.domgb.Controls.Add(Me.domcb)
        Me.domgb.Controls.Add(Me.domlab)
        Me.domgb.Location = New System.Drawing.Point(36, 381)
        Me.domgb.Name = "domgb"
        Me.domgb.Size = New System.Drawing.Size(363, 88)
        Me.domgb.TabIndex = 8
        Me.domgb.TabStop = False
        Me.domgb.Text = "DOMESTIC PACKAGES"
        '
        'domcb
        '
        Me.domcb.FormattingEnabled = True
        Me.domcb.Items.AddRange(New Object() {"SELECT", "GOA ", "KERELA"})
        Me.domcb.Location = New System.Drawing.Point(107, 36)
        Me.domcb.Name = "domcb"
        Me.domcb.Size = New System.Drawing.Size(210, 21)
        Me.domcb.TabIndex = 4
        '
        'pilgrigb
        '
        Me.pilgrigb.Controls.Add(Me.pilgricb)
        Me.pilgrigb.Controls.Add(Me.pilgrilab)
        Me.pilgrigb.Location = New System.Drawing.Point(426, 381)
        Me.pilgrigb.Name = "pilgrigb"
        Me.pilgrigb.Size = New System.Drawing.Size(371, 100)
        Me.pilgrigb.TabIndex = 9
        Me.pilgrigb.TabStop = False
        Me.pilgrigb.Text = "PILGRIMAGE PACKAGES"
        '
        'pilgricb
        '
        Me.pilgricb.FormattingEnabled = True
        Me.pilgricb.Items.AddRange(New Object() {"SELECT", "HINDUS PILGRIMAGE PLACES", "CHRISTIANS PILGRIMAGE PLACES"})
        Me.pilgricb.Location = New System.Drawing.Point(138, 33)
        Me.pilgricb.Name = "pilgricb"
        Me.pilgricb.Size = New System.Drawing.Size(184, 21)
        Me.pilgricb.TabIndex = 3
        '
        'hisgb
        '
        Me.hisgb.Controls.Add(Me.hiscb)
        Me.hisgb.Controls.Add(Me.hislab)
        Me.hisgb.Location = New System.Drawing.Point(36, 498)
        Me.hisgb.Name = "hisgb"
        Me.hisgb.Size = New System.Drawing.Size(335, 82)
        Me.hisgb.TabIndex = 10
        Me.hisgb.TabStop = False
        Me.hisgb.Text = "HISTORICAL PACKAGES"
        '
        'hiscb
        '
        Me.hiscb.FormattingEnabled = True
        Me.hiscb.Items.AddRange(New Object() {"SELECT", "DELHI HISTORICAL PACKAGE", "MYSORE HISTORICAL PACKAGE"})
        Me.hiscb.Location = New System.Drawing.Point(107, 31)
        Me.hiscb.Name = "hiscb"
        Me.hiscb.Size = New System.Drawing.Size(210, 21)
        Me.hiscb.TabIndex = 1
        '
        'hislab
        '
        Me.hislab.AutoSize = True
        Me.hislab.Location = New System.Drawing.Point(23, 34)
        Me.hislab.Name = "hislab"
        Me.hislab.Size = New System.Drawing.Size(54, 13)
        Me.hislab.TabIndex = 0
        Me.hislab.Text = "SELECT"
        '
        'check1cb
        '
        Me.check1cb.AutoSize = True
        Me.check1cb.Location = New System.Drawing.Point(441, 330)
        Me.check1cb.Name = "check1cb"
        Me.check1cb.Size = New System.Drawing.Size(91, 17)
        Me.check1cb.TabIndex = 11
        Me.check1cb.Text = "CLICK ME!!"
        Me.check1cb.UseVisualStyleBackColor = True
        '
        'nextbtn1
        '
        Me.nextbtn1.Location = New System.Drawing.Point(413, 514)
        Me.nextbtn1.Name = "nextbtn1"
        Me.nextbtn1.Size = New System.Drawing.Size(106, 66)
        Me.nextbtn1.TabIndex = 13
        Me.nextbtn1.Text = "NEXT"
        Me.nextbtn1.UseVisualStyleBackColor = True
        '
        'numnb
        '
        Me.numnb.Location = New System.Drawing.Point(258, 147)
        Me.numnb.Name = "numnb"
        Me.numnb.Size = New System.Drawing.Size(141, 20)
        Me.numnb.TabIndex = 22
        '
        'newbtn
        '
        Me.newbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newbtn.Location = New System.Drawing.Point(52, 21)
        Me.newbtn.Name = "newbtn"
        Me.newbtn.Size = New System.Drawing.Size(139, 51)
        Me.newbtn.TabIndex = 15
        Me.newbtn.Text = "CLICK ME TO REGISTER"
        Me.newbtn.UseVisualStyleBackColor = True
        '
        'numlab
        '
        Me.numlab.AutoSize = True
        Me.numlab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numlab.Location = New System.Drawing.Point(33, 147)
        Me.numlab.Name = "numlab"
        Me.numlab.Size = New System.Drawing.Size(132, 13)
        Me.numlab.TabIndex = 21
        Me.numlab.Text = "NO OF PASSENGERS"
        '
        'addtb
        '
        Me.addtb.Location = New System.Drawing.Point(258, 67)
        Me.addtb.Name = "addtb"
        Me.addtb.Size = New System.Drawing.Size(240, 53)
        Me.addtb.TabIndex = 20
        Me.addtb.Text = ""
        '
        'adultnb
        '
        Me.adultnb.Location = New System.Drawing.Point(322, 61)
        Me.adultnb.Name = "adultnb"
        Me.adultnb.Size = New System.Drawing.Size(140, 20)
        Me.adultnb.TabIndex = 4
        '
        'entrytb
        '
        Me.entrytb.Location = New System.Drawing.Point(706, 21)
        Me.entrytb.Name = "entrytb"
        Me.entrytb.Size = New System.Drawing.Size(117, 20)
        Me.entrytb.TabIndex = 18
        '
        'seniornb
        '
        Me.seniornb.Location = New System.Drawing.Point(600, 61)
        Me.seniornb.Name = "seniornb"
        Me.seniornb.Size = New System.Drawing.Size(140, 20)
        Me.seniornb.TabIndex = 5
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
        Me.checkgb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkgb.Location = New System.Drawing.Point(36, 173)
        Me.checkgb.Name = "checkgb"
        Me.checkgb.Size = New System.Drawing.Size(761, 133)
        Me.checkgb.TabIndex = 23
        Me.checkgb.TabStop = False
        Me.checkgb.Text = "CHECK DETAILS"
        '
        'checkcb
        '
        Me.checkcb.AutoSize = True
        Me.checkcb.Location = New System.Drawing.Point(288, 101)
        Me.checkcb.Name = "checkcb"
        Me.checkcb.Size = New System.Drawing.Size(246, 17)
        Me.checkcb.TabIndex = 6
        Me.checkcb.Text = "CLICK HERE TO PROCEED FURTHER"
        Me.checkcb.UseVisualStyleBackColor = True
        '
        'childnb
        '
        Me.childnb.Location = New System.Drawing.Point(54, 61)
        Me.childnb.Name = "childnb"
        Me.childnb.Size = New System.Drawing.Size(140, 20)
        Me.childnb.TabIndex = 3
        '
        'seniorlab
        '
        Me.seniorlab.AutoSize = True
        Me.seniorlab.Location = New System.Drawing.Point(614, 27)
        Me.seniorlab.Name = "seniorlab"
        Me.seniorlab.Size = New System.Drawing.Size(115, 13)
        Me.seniorlab.TabIndex = 2
        Me.seniorlab.Text = "SENIOR CITIZENS"
        '
        'adultlab
        '
        Me.adultlab.AutoSize = True
        Me.adultlab.Location = New System.Drawing.Point(358, 27)
        Me.adultlab.Name = "adultlab"
        Me.adultlab.Size = New System.Drawing.Size(48, 13)
        Me.adultlab.TabIndex = 1
        Me.adultlab.Text = "ADULT"
        '
        'childlab
        '
        Me.childlab.AutoSize = True
        Me.childlab.Location = New System.Drawing.Point(92, 27)
        Me.childlab.Name = "childlab"
        Me.childlab.Size = New System.Drawing.Size(44, 13)
        Me.childlab.TabIndex = 0
        Me.childlab.Text = "CHILD"
        '
        'titlab
        '
        Me.titlab.AutoSize = True
        Me.titlab.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titlab.Location = New System.Drawing.Point(293, 9)
        Me.titlab.Name = "titlab"
        Me.titlab.Size = New System.Drawing.Size(182, 21)
        Me.titlab.TabIndex = 16
        Me.titlab.Text = "FILL IN THE DETAILS"
        '
        'entrylab
        '
        Me.entrylab.AutoSize = True
        Me.entrylab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.entrylab.Location = New System.Drawing.Point(556, 28)
        Me.entrylab.Name = "entrylab"
        Me.entrylab.Size = New System.Drawing.Size(92, 13)
        Me.entrylab.TabIndex = 17
        Me.entrylab.Text = "REGISTER NO"
        '
        'addlab
        '
        Me.addlab.AutoSize = True
        Me.addlab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addlab.Location = New System.Drawing.Point(36, 88)
        Me.addlab.Name = "addlab"
        Me.addlab.Size = New System.Drawing.Size(152, 13)
        Me.addlab.TabIndex = 19
        Me.addlab.Text = "RESIDENTIAL ADDRESS"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(564, 514)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 62)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(696, 514)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 63)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "LOGIN"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'package
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.vbtourism.My.Resources.Resources._A8
        Me.ClientSize = New System.Drawing.Size(856, 672)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.numnb)
        Me.Controls.Add(Me.newbtn)
        Me.Controls.Add(Me.numlab)
        Me.Controls.Add(Me.addtb)
        Me.Controls.Add(Me.entrytb)
        Me.Controls.Add(Me.checkgb)
        Me.Controls.Add(Me.titlab)
        Me.Controls.Add(Me.entrylab)
        Me.Controls.Add(Me.addlab)
        Me.Controls.Add(Me.nextbtn1)
        Me.Controls.Add(Me.check1cb)
        Me.Controls.Add(Me.pilgrigb)
        Me.Controls.Add(Me.hisgb)
        Me.Controls.Add(Me.domgb)
        Me.Controls.Add(Me.packcb)
        Me.Controls.Add(Me.typelab)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "package"
        Me.Text = "Form2"
        Me.domgb.ResumeLayout(False)
        Me.domgb.PerformLayout()
        Me.pilgrigb.ResumeLayout(False)
        Me.pilgrigb.PerformLayout()
        Me.hisgb.ResumeLayout(False)
        Me.hisgb.PerformLayout()
        CType(Me.numnb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.adultnb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seniornb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.checkgb.ResumeLayout(False)
        Me.checkgb.PerformLayout()
        CType(Me.childnb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents typelab As System.Windows.Forms.Label
    Friend WithEvents pilgrilab As System.Windows.Forms.Label
    Friend WithEvents domlab As System.Windows.Forms.Label
    Friend WithEvents packcb As System.Windows.Forms.ComboBox
    Friend WithEvents domgb As System.Windows.Forms.GroupBox
    Friend WithEvents pilgrigb As System.Windows.Forms.GroupBox
    Friend WithEvents hisgb As System.Windows.Forms.GroupBox
    Friend WithEvents domcb As System.Windows.Forms.ComboBox
    Friend WithEvents pilgricb As System.Windows.Forms.ComboBox
    Friend WithEvents hislab As System.Windows.Forms.Label
    Friend WithEvents hiscb As System.Windows.Forms.ComboBox
    Friend WithEvents check1cb As System.Windows.Forms.CheckBox
    Friend WithEvents nextbtn1 As System.Windows.Forms.Button
    Friend WithEvents numnb As System.Windows.Forms.NumericUpDown
    Friend WithEvents newbtn As System.Windows.Forms.Button
    Friend WithEvents numlab As System.Windows.Forms.Label
    Friend WithEvents addtb As System.Windows.Forms.RichTextBox
    Friend WithEvents adultnb As System.Windows.Forms.NumericUpDown
    Friend WithEvents entrytb As System.Windows.Forms.TextBox
    Friend WithEvents seniornb As System.Windows.Forms.NumericUpDown
    Friend WithEvents checkgb As System.Windows.Forms.GroupBox
    Friend WithEvents childnb As System.Windows.Forms.NumericUpDown
    Friend WithEvents seniorlab As System.Windows.Forms.Label
    Friend WithEvents adultlab As System.Windows.Forms.Label
    Friend WithEvents childlab As System.Windows.Forms.Label
    Friend WithEvents titlab As System.Windows.Forms.Label
    Friend WithEvents entrylab As System.Windows.Forms.Label
    Friend WithEvents addlab As System.Windows.Forms.Label
    Friend WithEvents checkcb As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class

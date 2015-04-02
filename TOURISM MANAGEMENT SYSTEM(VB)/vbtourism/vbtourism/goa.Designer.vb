<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GOA
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
        Me.durlab = New System.Windows.Forms.Label
        Me.daylab = New System.Windows.Forms.Label
        Me.fromlab = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.day1lab = New System.Windows.Forms.Label
        Me.day2lab = New System.Windows.Forms.Label
        Me.schgb = New System.Windows.Forms.GroupBox
        Me.day2rb = New System.Windows.Forms.RichTextBox
        Me.day1rb = New System.Windows.Forms.RichTextBox
        Me.menuselect = New System.Windows.Forms.MenuStrip
        Me.VIEWSCHEDULEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IMAGESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MAPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ACCOMODATIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TRANSPORTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FOODToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IMAGESSB = New System.Windows.Forms.GroupBox
        Me.MAPGB = New System.Windows.Forms.GroupBox
        Me.GOAMAP = New System.Windows.Forms.PictureBox
        Me.PB3 = New System.Windows.Forms.PictureBox
        Me.PB2 = New System.Windows.Forms.PictureBox
        Me.GOAPB1 = New System.Windows.Forms.PictureBox
        Me.day2pb = New System.Windows.Forms.PictureBox
        Me.day1pb = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.schgb.SuspendLayout()
        Me.menuselect.SuspendLayout()
        Me.IMAGESSB.SuspendLayout()
        Me.MAPGB.SuspendLayout()
        CType(Me.GOAMAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GOAPB1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.day2pb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.day1pb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'durlab
        '
        Me.durlab.AutoSize = True
        Me.durlab.Location = New System.Drawing.Point(97, 49)
        Me.durlab.Name = "durlab"
        Me.durlab.Size = New System.Drawing.Size(72, 13)
        Me.durlab.TabIndex = 1
        Me.durlab.Text = "DURATION"
        '
        'daylab
        '
        Me.daylab.AutoSize = True
        Me.daylab.Location = New System.Drawing.Point(243, 49)
        Me.daylab.Name = "daylab"
        Me.daylab.Size = New System.Drawing.Size(117, 13)
        Me.daylab.TabIndex = 2
        Me.daylab.Text = "NUMBER OF DAYS"
        '
        'fromlab
        '
        Me.fromlab.AutoSize = True
        Me.fromlab.Location = New System.Drawing.Point(97, 94)
        Me.fromlab.Name = "fromlab"
        Me.fromlab.Size = New System.Drawing.Size(79, 13)
        Me.fromlab.TabIndex = 3
        Me.fromlab.Text = "FROM DATE"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(246, 87)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(233, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'day1lab
        '
        Me.day1lab.AutoSize = True
        Me.day1lab.Location = New System.Drawing.Point(20, 79)
        Me.day1lab.Name = "day1lab"
        Me.day1lab.Size = New System.Drawing.Size(43, 13)
        Me.day1lab.TabIndex = 5
        Me.day1lab.Text = "DAY 1"
        '
        'day2lab
        '
        Me.day2lab.AutoSize = True
        Me.day2lab.Location = New System.Drawing.Point(427, 88)
        Me.day2lab.Name = "day2lab"
        Me.day2lab.Size = New System.Drawing.Size(39, 13)
        Me.day2lab.TabIndex = 7
        Me.day2lab.Text = "DAY2"
        '
        'schgb
        '
        Me.schgb.Controls.Add(Me.day2rb)
        Me.schgb.Controls.Add(Me.day1rb)
        Me.schgb.Controls.Add(Me.day2pb)
        Me.schgb.Controls.Add(Me.day1lab)
        Me.schgb.Controls.Add(Me.day2lab)
        Me.schgb.Controls.Add(Me.day1pb)
        Me.schgb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.schgb.Location = New System.Drawing.Point(58, 123)
        Me.schgb.Name = "schgb"
        Me.schgb.Size = New System.Drawing.Size(839, 270)
        Me.schgb.TabIndex = 8
        Me.schgb.TabStop = False
        Me.schgb.Text = "SCHEDULE"
        '
        'day2rb
        '
        Me.day2rb.Location = New System.Drawing.Point(451, 166)
        Me.day2rb.Name = "day2rb"
        Me.day2rb.Size = New System.Drawing.Size(366, 61)
        Me.day2rb.TabIndex = 10
        Me.day2rb.Text = ""
        '
        'day1rb
        '
        Me.day1rb.Location = New System.Drawing.Point(23, 166)
        Me.day1rb.Name = "day1rb"
        Me.day1rb.Size = New System.Drawing.Size(362, 61)
        Me.day1rb.TabIndex = 9
        Me.day1rb.Text = ""
        '
        'menuselect
        '
        Me.menuselect.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VIEWSCHEDULEToolStripMenuItem, Me.IMAGESToolStripMenuItem, Me.MAPToolStripMenuItem, Me.ACCOMODATIONToolStripMenuItem, Me.TRANSPORTToolStripMenuItem, Me.FOODToolStripMenuItem})
        Me.menuselect.Location = New System.Drawing.Point(0, 0)
        Me.menuselect.Name = "menuselect"
        Me.menuselect.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.menuselect.Size = New System.Drawing.Size(1003, 24)
        Me.menuselect.TabIndex = 9
        Me.menuselect.Text = "MenuStrip1"
        '
        'VIEWSCHEDULEToolStripMenuItem
        '
        Me.VIEWSCHEDULEToolStripMenuItem.Name = "VIEWSCHEDULEToolStripMenuItem"
        Me.VIEWSCHEDULEToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.VIEWSCHEDULEToolStripMenuItem.Text = "VIEW SCHEDULE"
        '
        'IMAGESToolStripMenuItem
        '
        Me.IMAGESToolStripMenuItem.Name = "IMAGESToolStripMenuItem"
        Me.IMAGESToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.IMAGESToolStripMenuItem.Text = "IMAGES"
        '
        'MAPToolStripMenuItem
        '
        Me.MAPToolStripMenuItem.Name = "MAPToolStripMenuItem"
        Me.MAPToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.MAPToolStripMenuItem.Text = "MAP"
        '
        'ACCOMODATIONToolStripMenuItem
        '
        Me.ACCOMODATIONToolStripMenuItem.Name = "ACCOMODATIONToolStripMenuItem"
        Me.ACCOMODATIONToolStripMenuItem.Size = New System.Drawing.Size(116, 20)
        Me.ACCOMODATIONToolStripMenuItem.Text = "ACCOMODATION"
        '
        'TRANSPORTToolStripMenuItem
        '
        Me.TRANSPORTToolStripMenuItem.Name = "TRANSPORTToolStripMenuItem"
        Me.TRANSPORTToolStripMenuItem.Size = New System.Drawing.Size(12, 20)
        '
        'FOODToolStripMenuItem
        '
        Me.FOODToolStripMenuItem.Name = "FOODToolStripMenuItem"
        Me.FOODToolStripMenuItem.Size = New System.Drawing.Size(12, 20)
        '
        'IMAGESSB
        '
        Me.IMAGESSB.Controls.Add(Me.PB3)
        Me.IMAGESSB.Controls.Add(Me.PB2)
        Me.IMAGESSB.Controls.Add(Me.GOAPB1)
        Me.IMAGESSB.Location = New System.Drawing.Point(42, 408)
        Me.IMAGESSB.Name = "IMAGESSB"
        Me.IMAGESSB.Size = New System.Drawing.Size(894, 184)
        Me.IMAGESSB.TabIndex = 10
        Me.IMAGESSB.TabStop = False
        Me.IMAGESSB.Text = "IMAGES"
        '
        'MAPGB
        '
        Me.MAPGB.Controls.Add(Me.GOAMAP)
        Me.MAPGB.Location = New System.Drawing.Point(42, 607)
        Me.MAPGB.Name = "MAPGB"
        Me.MAPGB.Size = New System.Drawing.Size(220, 127)
        Me.MAPGB.TabIndex = 11
        Me.MAPGB.TabStop = False
        Me.MAPGB.Text = "MAP"
        '
        'GOAMAP
        '
        Me.GOAMAP.Location = New System.Drawing.Point(7, 19)
        Me.GOAMAP.Name = "GOAMAP"
        Me.GOAMAP.Size = New System.Drawing.Size(206, 102)
        Me.GOAMAP.TabIndex = 2
        Me.GOAMAP.TabStop = False
        '
        'PB3
        '
        Me.PB3.Location = New System.Drawing.Point(594, 29)
        Me.PB3.Name = "PB3"
        Me.PB3.Size = New System.Drawing.Size(261, 149)
        Me.PB3.TabIndex = 2
        Me.PB3.TabStop = False
        '
        'PB2
        '
        Me.PB2.Location = New System.Drawing.Point(300, 29)
        Me.PB2.Name = "PB2"
        Me.PB2.Size = New System.Drawing.Size(238, 149)
        Me.PB2.TabIndex = 1
        Me.PB2.TabStop = False
        '
        'GOAPB1
        '
        Me.GOAPB1.Location = New System.Drawing.Point(7, 29)
        Me.GOAPB1.Name = "GOAPB1"
        Me.GOAPB1.Size = New System.Drawing.Size(240, 149)
        Me.GOAPB1.TabIndex = 0
        Me.GOAPB1.TabStop = False
        '
        'day2pb
        '
        Me.day2pb.Location = New System.Drawing.Point(556, 19)
        Me.day2pb.Name = "day2pb"
        Me.day2pb.Size = New System.Drawing.Size(197, 130)
        Me.day2pb.TabIndex = 8
        Me.day2pb.TabStop = False
        '
        'day1pb
        '
        Me.day1pb.Location = New System.Drawing.Point(132, 19)
        Me.day1pb.Name = "day1pb"
        Me.day1pb.Size = New System.Drawing.Size(197, 130)
        Me.day1pb.TabIndex = 6
        Me.day1pb.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(332, 644)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 54)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "BACK "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(449, 644)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 51)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "LOGIN"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GOA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 746)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MAPGB)
        Me.Controls.Add(Me.IMAGESSB)
        Me.Controls.Add(Me.schgb)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.fromlab)
        Me.Controls.Add(Me.daylab)
        Me.Controls.Add(Me.durlab)
        Me.Controls.Add(Me.menuselect)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.menuselect
        Me.Name = "GOA"
        Me.Text = "Form3"
        Me.schgb.ResumeLayout(False)
        Me.schgb.PerformLayout()
        Me.menuselect.ResumeLayout(False)
        Me.menuselect.PerformLayout()
        Me.IMAGESSB.ResumeLayout(False)
        Me.MAPGB.ResumeLayout(False)
        CType(Me.GOAMAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GOAPB1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.day2pb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.day1pb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents durlab As System.Windows.Forms.Label
    Friend WithEvents daylab As System.Windows.Forms.Label
    Friend WithEvents fromlab As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents day1lab As System.Windows.Forms.Label
    Friend WithEvents day2lab As System.Windows.Forms.Label
    Friend WithEvents schgb As System.Windows.Forms.GroupBox
    Friend WithEvents menuselect As System.Windows.Forms.MenuStrip
    Friend WithEvents VIEWSCHEDULEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IMAGESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MAPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents day2rb As System.Windows.Forms.RichTextBox
    Friend WithEvents day1rb As System.Windows.Forms.RichTextBox
    Friend WithEvents IMAGESSB As System.Windows.Forms.GroupBox
    Friend WithEvents MAPGB As System.Windows.Forms.GroupBox
    Friend WithEvents ACCOMODATIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TRANSPORTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FOODToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents day2pb As System.Windows.Forms.PictureBox
    Friend WithEvents day1pb As System.Windows.Forms.PictureBox
    Friend WithEvents PB3 As System.Windows.Forms.PictureBox
    Friend WithEvents PB2 As System.Windows.Forms.PictureBox
    Friend WithEvents GOAPB1 As System.Windows.Forms.PictureBox
    Friend WithEvents GOAMAP As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class

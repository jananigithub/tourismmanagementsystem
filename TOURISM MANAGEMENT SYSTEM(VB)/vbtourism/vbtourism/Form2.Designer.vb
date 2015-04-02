<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container
        Dim IDLabel As System.Windows.Forms.Label
        Dim NAMESLabel As System.Windows.Forms.Label
        Dim NATIONALITYLabel As System.Windows.Forms.Label
        Dim CONTACTLabel As System.Windows.Forms.Label
        Dim PLACELabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Table2BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.Table2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database5DataSet = New vbtourism.Database5DataSet
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.Table2BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.IDTextBox = New System.Windows.Forms.TextBox
        Me.NAMESTextBox = New System.Windows.Forms.TextBox
        Me.NATIONALITYTextBox = New System.Windows.Forms.TextBox
        Me.CONTACTTextBox = New System.Windows.Forms.TextBox
        Me.PLACETextBox = New System.Windows.Forms.TextBox
        Me.Table2DataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Table2TableAdapter = New vbtourism.Database5DataSetTableAdapters.Table2TableAdapter
        Me.TableAdapterManager = New vbtourism.Database5DataSetTableAdapters.TableAdapterManager
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        IDLabel = New System.Windows.Forms.Label
        NAMESLabel = New System.Windows.Forms.Label
        NATIONALITYLabel = New System.Windows.Forms.Label
        CONTACTLabel = New System.Windows.Forms.Label
        PLACELabel = New System.Windows.Forms.Label
        CType(Me.Table2BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Table2BindingNavigator.SuspendLayout()
        CType(Me.Table2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database5DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table2DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(73, 71)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(24, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'NAMESLabel
        '
        NAMESLabel.AutoSize = True
        NAMESLabel.Location = New System.Drawing.Point(42, 113)
        NAMESLabel.Name = "NAMESLabel"
        NAMESLabel.Size = New System.Drawing.Size(54, 13)
        NAMESLabel.TabIndex = 3
        NAMESLabel.Text = "NAMES:"
        '
        'NATIONALITYLabel
        '
        NATIONALITYLabel.AutoSize = True
        NATIONALITYLabel.Location = New System.Drawing.Point(14, 156)
        NATIONALITYLabel.Name = "NATIONALITYLabel"
        NATIONALITYLabel.Size = New System.Drawing.Size(93, 13)
        NATIONALITYLabel.TabIndex = 5
        NATIONALITYLabel.Text = "NATIONALITY:"
        '
        'CONTACTLabel
        '
        CONTACTLabel.AutoSize = True
        CONTACTLabel.Location = New System.Drawing.Point(37, 206)
        CONTACTLabel.Name = "CONTACTLabel"
        CONTACTLabel.Size = New System.Drawing.Size(69, 13)
        CONTACTLabel.TabIndex = 7
        CONTACTLabel.Text = "CONTACT:"
        '
        'PLACELabel
        '
        PLACELabel.AutoSize = True
        PLACELabel.Location = New System.Drawing.Point(47, 254)
        PLACELabel.Name = "PLACELabel"
        PLACELabel.Size = New System.Drawing.Size(50, 13)
        PLACELabel.TabIndex = 9
        PLACELabel.Text = "PLACE:"
        '
        'Table2BindingNavigator
        '
        Me.Table2BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Table2BindingNavigator.BindingSource = Me.Table2BindingSource
        Me.Table2BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Table2BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Table2BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Table2BindingNavigatorSaveItem})
        Me.Table2BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Table2BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Table2BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Table2BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Table2BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Table2BindingNavigator.Name = "Table2BindingNavigator"
        Me.Table2BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Table2BindingNavigator.Size = New System.Drawing.Size(1053, 25)
        Me.Table2BindingNavigator.TabIndex = 0
        Me.Table2BindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'Table2BindingSource
        '
        Me.Table2BindingSource.DataMember = "Table2"
        Me.Table2BindingSource.DataSource = Me.Database5DataSet
        '
        'Database5DataSet
        '
        Me.Database5DataSet.DataSetName = "Database5DataSet"
        Me.Database5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Table2BindingNavigatorSaveItem
        '
        Me.Table2BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Table2BindingNavigatorSaveItem.Image = CType(resources.GetObject("Table2BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Table2BindingNavigatorSaveItem.Name = "Table2BindingNavigatorSaveItem"
        Me.Table2BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Table2BindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table2BindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(133, 64)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(152, 20)
        Me.IDTextBox.TabIndex = 2
        '
        'NAMESTextBox
        '
        Me.NAMESTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table2BindingSource, "NAMES", True))
        Me.NAMESTextBox.Location = New System.Drawing.Point(133, 106)
        Me.NAMESTextBox.Name = "NAMESTextBox"
        Me.NAMESTextBox.Size = New System.Drawing.Size(152, 20)
        Me.NAMESTextBox.TabIndex = 4
        '
        'NATIONALITYTextBox
        '
        Me.NATIONALITYTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table2BindingSource, "NATIONALITY", True))
        Me.NATIONALITYTextBox.Location = New System.Drawing.Point(133, 156)
        Me.NATIONALITYTextBox.Name = "NATIONALITYTextBox"
        Me.NATIONALITYTextBox.Size = New System.Drawing.Size(152, 20)
        Me.NATIONALITYTextBox.TabIndex = 6
        '
        'CONTACTTextBox
        '
        Me.CONTACTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table2BindingSource, "CONTACT", True))
        Me.CONTACTTextBox.Location = New System.Drawing.Point(133, 203)
        Me.CONTACTTextBox.Name = "CONTACTTextBox"
        Me.CONTACTTextBox.Size = New System.Drawing.Size(152, 20)
        Me.CONTACTTextBox.TabIndex = 8
        '
        'PLACETextBox
        '
        Me.PLACETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table2BindingSource, "PLACE", True))
        Me.PLACETextBox.Location = New System.Drawing.Point(133, 254)
        Me.PLACETextBox.Name = "PLACETextBox"
        Me.PLACETextBox.Size = New System.Drawing.Size(152, 20)
        Me.PLACETextBox.TabIndex = 10
        '
        'Table2DataGridView
        '
        Me.Table2DataGridView.AutoGenerateColumns = False
        Me.Table2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table2DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Table2DataGridView.DataSource = Me.Table2BindingSource
        Me.Table2DataGridView.Location = New System.Drawing.Point(383, 71)
        Me.Table2DataGridView.Name = "Table2DataGridView"
        Me.Table2DataGridView.Size = New System.Drawing.Size(657, 302)
        Me.Table2DataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NAMES"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NAMES"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NATIONALITY"
        Me.DataGridViewTextBoxColumn3.HeaderText = "NATIONALITY"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CONTACT"
        Me.DataGridViewTextBoxColumn4.HeaderText = "CONTACT"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PLACE"
        Me.DataGridViewTextBoxColumn5.HeaderText = "PLACE"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Table2TableAdapter
        '
        Me.Table2TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Table2TableAdapter = Me.Table2TableAdapter
        Me.TableAdapterManager.UpdateOrder = vbtourism.Database5DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(117, 340)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(169, 59)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "ADD RECORD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(366, 379)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 47)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "CANCEL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(541, 379)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 47)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "NEXT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(351, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 20)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "ENTER YOUR DETAILS"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.vbtourism.My.Resources.Resources.KERELA1
        Me.ClientSize = New System.Drawing.Size(1053, 438)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Table2DataGridView)
        Me.Controls.Add(PLACELabel)
        Me.Controls.Add(Me.PLACETextBox)
        Me.Controls.Add(CONTACTLabel)
        Me.Controls.Add(Me.CONTACTTextBox)
        Me.Controls.Add(NATIONALITYLabel)
        Me.Controls.Add(Me.NATIONALITYTextBox)
        Me.Controls.Add(NAMESLabel)
        Me.Controls.Add(Me.NAMESTextBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.Table2BindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.Table2BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Table2BindingNavigator.ResumeLayout(False)
        Me.Table2BindingNavigator.PerformLayout()
        CType(Me.Table2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database5DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table2DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Database5DataSet As vbtourism.Database5DataSet
    Friend WithEvents Table2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table2TableAdapter As vbtourism.Database5DataSetTableAdapters.Table2TableAdapter
    Friend WithEvents TableAdapterManager As vbtourism.Database5DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Table2BindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Table2BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NAMESTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NATIONALITYTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CONTACTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PLACETextBox As System.Windows.Forms.TextBox
    Friend WithEvents Table2DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class

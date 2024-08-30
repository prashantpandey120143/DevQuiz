<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form12
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlanguageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeleftDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PscoreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.T1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db111DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db111DataSet = New DevQuiz.db111DataSet()
        Me.T1TableAdapter = New DevQuiz.db111DataSetTableAdapters.t1TableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db111DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db111DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UsernameDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.PnameDataGridViewTextBoxColumn, Me.PlanguageDataGridViewTextBoxColumn, Me.TimeleftDataGridViewTextBoxColumn, Me.PscoreDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.T1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(58, 49)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1176, 524)
        Me.DataGridView1.TabIndex = 0
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "username"
        Me.UsernameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.ReadOnly = True
        Me.UsernameDataGridViewTextBoxColumn.Width = 125
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "password"
        Me.PasswordDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        Me.PasswordDataGridViewTextBoxColumn.ReadOnly = True
        Me.PasswordDataGridViewTextBoxColumn.Width = 125
        '
        'PnameDataGridViewTextBoxColumn
        '
        Me.PnameDataGridViewTextBoxColumn.DataPropertyName = "pname"
        Me.PnameDataGridViewTextBoxColumn.HeaderText = "pname"
        Me.PnameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PnameDataGridViewTextBoxColumn.Name = "PnameDataGridViewTextBoxColumn"
        Me.PnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.PnameDataGridViewTextBoxColumn.Width = 125
        '
        'PlanguageDataGridViewTextBoxColumn
        '
        Me.PlanguageDataGridViewTextBoxColumn.DataPropertyName = "planguage"
        Me.PlanguageDataGridViewTextBoxColumn.HeaderText = "planguage"
        Me.PlanguageDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PlanguageDataGridViewTextBoxColumn.Name = "PlanguageDataGridViewTextBoxColumn"
        Me.PlanguageDataGridViewTextBoxColumn.ReadOnly = True
        Me.PlanguageDataGridViewTextBoxColumn.Width = 125
        '
        'TimeleftDataGridViewTextBoxColumn
        '
        Me.TimeleftDataGridViewTextBoxColumn.DataPropertyName = "timeleft"
        Me.TimeleftDataGridViewTextBoxColumn.HeaderText = "timeleft"
        Me.TimeleftDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TimeleftDataGridViewTextBoxColumn.Name = "TimeleftDataGridViewTextBoxColumn"
        Me.TimeleftDataGridViewTextBoxColumn.ReadOnly = True
        Me.TimeleftDataGridViewTextBoxColumn.Width = 125
        '
        'PscoreDataGridViewTextBoxColumn
        '
        Me.PscoreDataGridViewTextBoxColumn.DataPropertyName = "pscore"
        Me.PscoreDataGridViewTextBoxColumn.HeaderText = "pscore"
        Me.PscoreDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PscoreDataGridViewTextBoxColumn.Name = "PscoreDataGridViewTextBoxColumn"
        Me.PscoreDataGridViewTextBoxColumn.ReadOnly = True
        Me.PscoreDataGridViewTextBoxColumn.Width = 125
        '
        'T1BindingSource
        '
        Me.T1BindingSource.DataMember = "t1"
        Me.T1BindingSource.DataSource = Me.Db111DataSetBindingSource
        '
        'Db111DataSetBindingSource
        '
        Me.Db111DataSetBindingSource.DataSource = Me.Db111DataSet
        Me.Db111DataSetBindingSource.Position = 0
        '
        'Db111DataSet
        '
        Me.Db111DataSet.DataSetName = "db111DataSet"
        Me.Db111DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'T1TableAdapter
        '
        Me.T1TableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(351, 615)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 58)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Admin Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(849, 615)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 58)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Main Menu"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1316, 703)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form12"
        Me.Text = "Form12"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db111DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db111DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Db111DataSetBindingSource As BindingSource
    Friend WithEvents Db111DataSet As db111DataSet
    Friend WithEvents T1BindingSource As BindingSource
    Friend WithEvents T1TableAdapter As db111DataSetTableAdapters.t1TableAdapter
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlanguageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeleftDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PscoreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class

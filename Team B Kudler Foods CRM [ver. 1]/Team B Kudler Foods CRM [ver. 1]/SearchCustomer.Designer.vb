<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SearchCustomer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtSearchFirstName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSearcLastName = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.First_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Last_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSearchFirstName
        '
        Me.txtSearchFirstName.Location = New System.Drawing.Point(137, 102)
        Me.txtSearchFirstName.Name = "txtSearchFirstName"
        Me.txtSearchFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtSearchFirstName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "First Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(255, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Last Name:"
        '
        'txtSearcLastName
        '
        Me.txtSearcLastName.Location = New System.Drawing.Point(317, 102)
        Me.txtSearcLastName.Name = "txtSearcLastName"
        Me.txtSearcLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtSearcLastName.TabIndex = 3
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(485, 100)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.First_Name, Me.Last_Name})
        Me.DataGridView1.Location = New System.Drawing.Point(75, 201)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(485, 199)
        Me.DataGridView1.TabIndex = 5
        '
        'First_Name
        '
        Me.First_Name.HeaderText = "First Name"
        Me.First_Name.Name = "First_Name"
        '
        'Last_Name
        '
        Me.Last_Name.HeaderText = "Last Name"
        Me.Last_Name.Name = "Last_Name"
        '
        'SearchCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 463)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearcLastName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSearchFirstName)
        Me.Name = "SearchCustomer"
        Me.Text = "View_Customer"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSearchFirstName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearcLastName As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents First_Name As DataGridViewTextBoxColumn
    Friend WithEvents Last_Name As DataGridViewTextBoxColumn
End Class

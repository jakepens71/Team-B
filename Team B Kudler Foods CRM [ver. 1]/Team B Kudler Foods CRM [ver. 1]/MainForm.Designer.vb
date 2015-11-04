<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.radViewFutureRewards = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCreateCustomer = New System.Windows.Forms.Button()
        Me.radViewAllCustomers = New System.Windows.Forms.RadioButton()
        Me.radSearchCustomer = New System.Windows.Forms.RadioButton()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblRewards = New System.Windows.Forms.Label()
        Me.lblPoints = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.rdCreateCustomer = New System.Windows.Forms.RadioButton()
        Me.lblname = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(493, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.radViewFutureRewards)
        Me.GroupBox1.Location = New System.Drawing.Point(270, 107)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rewards Functions"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(39, 30)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(130, 17)
        Me.RadioButton3.TabIndex = 0
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "View Earned Rewards"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'radViewFutureRewards
        '
        Me.radViewFutureRewards.AutoSize = True
        Me.radViewFutureRewards.Location = New System.Drawing.Point(39, 53)
        Me.radViewFutureRewards.Name = "radViewFutureRewards"
        Me.radViewFutureRewards.Size = New System.Drawing.Size(126, 17)
        Me.radViewFutureRewards.TabIndex = 1
        Me.radViewFutureRewards.TabStop = True
        Me.radViewFutureRewards.Text = "View Future Rewards"
        Me.radViewFutureRewards.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(358, 60)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Kudler Fine Foods Customer " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Reference Program"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdCreateCustomer)
        Me.GroupBox2.Controls.Add(Me.btnCreateCustomer)
        Me.GroupBox2.Controls.Add(Me.radViewAllCustomers)
        Me.GroupBox2.Controls.Add(Me.radSearchCustomer)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 107)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 122)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer Functions"
        '
        'btnCreateCustomer
        '
        Me.btnCreateCustomer.Location = New System.Drawing.Point(28, 24)
        Me.btnCreateCustomer.Name = "btnCreateCustomer"
        Me.btnCreateCustomer.Size = New System.Drawing.Size(131, 23)
        Me.btnCreateCustomer.TabIndex = 0
        Me.btnCreateCustomer.Text = "Create / View Customer"
        Me.btnCreateCustomer.UseVisualStyleBackColor = True
        '
        'radViewAllCustomers
        '
        Me.radViewAllCustomers.AutoSize = True
        Me.radViewAllCustomers.Location = New System.Drawing.Point(28, 76)
        Me.radViewAllCustomers.Name = "radViewAllCustomers"
        Me.radViewAllCustomers.Size = New System.Drawing.Size(113, 17)
        Me.radViewAllCustomers.TabIndex = 2
        Me.radViewAllCustomers.TabStop = True
        Me.radViewAllCustomers.Text = "Veiw all Customers"
        Me.radViewAllCustomers.UseVisualStyleBackColor = True
        '
        'radSearchCustomer
        '
        Me.radSearchCustomer.AutoSize = True
        Me.radSearchCustomer.Location = New System.Drawing.Point(28, 53)
        Me.radSearchCustomer.Name = "radSearchCustomer"
        Me.radSearchCustomer.Size = New System.Drawing.Size(106, 17)
        Me.radSearchCustomer.TabIndex = 1
        Me.radSearchCustomer.TabStop = True
        Me.radSearchCustomer.Text = "Search Customer"
        Me.radSearchCustomer.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(199, 383)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblname)
        Me.GroupBox3.Controls.Add(Me.lblRewards)
        Me.GroupBox3.Controls.Add(Me.lblPoints)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(63, 258)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(358, 100)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Results"
        '
        'lblRewards
        '
        Me.lblRewards.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRewards.Location = New System.Drawing.Point(158, 72)
        Me.lblRewards.Name = "lblRewards"
        Me.lblRewards.Size = New System.Drawing.Size(150, 14)
        Me.lblRewards.TabIndex = 5
        Me.lblRewards.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPoints
        '
        Me.lblPoints.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPoints.Location = New System.Drawing.Point(158, 46)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(150, 14)
        Me.lblPoints.TabIndex = 2
        Me.lblPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Future Rewards:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Reward Points:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Customer Name:"
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(182, 229)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(109, 23)
        Me.btnDisplay.TabIndex = 2
        Me.btnDisplay.Text = "Display Selections"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'rdCreateCustomer
        '
        Me.rdCreateCustomer.AutoSize = True
        Me.rdCreateCustomer.Location = New System.Drawing.Point(28, 99)
        Me.rdCreateCustomer.Name = "rdCreateCustomer"
        Me.rdCreateCustomer.Size = New System.Drawing.Size(91, 17)
        Me.rdCreateCustomer.TabIndex = 3
        Me.rdCreateCustomer.TabStop = True
        Me.rdCreateCustomer.Text = "Add Customer"
        Me.rdCreateCustomer.UseVisualStyleBackColor = True
        '
        'lblname
        '
        Me.lblname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblname.Location = New System.Drawing.Point(158, 16)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(150, 14)
        Me.lblname.TabIndex = 6
        Me.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 458)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "Main Form"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents radViewFutureRewards As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radViewAllCustomers As System.Windows.Forms.RadioButton
    Friend WithEvents radSearchCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCreateCustomer As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblRewards As System.Windows.Forms.Label
    Friend WithEvents lblPoints As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents rdCreateCustomer As RadioButton
    Friend WithEvents lblname As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTotalEmployeeDue = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTotalReimbursement = New System.Windows.Forms.Label()
        Me.lblTotalTravelCost = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtDays = New System.Windows.Forms.TextBox()
        Me.txtAirCost = New System.Windows.Forms.TextBox()
        Me.txtLodgingCost = New System.Windows.Forms.TextBox()
        Me.txtFoodCost = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.radManagement = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radNonManagement = New System.Windows.Forms.RadioButton()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lblTotalEmployeeDue)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.lblTotalReimbursement)
        Me.GroupBox2.Controls.Add(Me.lblTotalTravelCost)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 287)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(295, 139)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Totals"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Travel Costs"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(43, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Reimbursement"
        '
        'lblTotalEmployeeDue
        '
        Me.lblTotalEmployeeDue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalEmployeeDue.Location = New System.Drawing.Point(156, 94)
        Me.lblTotalEmployeeDue.Name = "lblTotalEmployeeDue"
        Me.lblTotalEmployeeDue.Size = New System.Drawing.Size(103, 23)
        Me.lblTotalEmployeeDue.TabIndex = 22
        Me.lblTotalEmployeeDue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(43, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Due"
        '
        'lblTotalReimbursement
        '
        Me.lblTotalReimbursement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalReimbursement.Location = New System.Drawing.Point(156, 63)
        Me.lblTotalReimbursement.Name = "lblTotalReimbursement"
        Me.lblTotalReimbursement.Size = New System.Drawing.Size(103, 23)
        Me.lblTotalReimbursement.TabIndex = 21
        Me.lblTotalReimbursement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalTravelCost
        '
        Me.lblTotalTravelCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalTravelCost.Location = New System.Drawing.Point(156, 32)
        Me.lblTotalTravelCost.Name = "lblTotalTravelCost"
        Me.lblTotalTravelCost.Size = New System.Drawing.Size(103, 23)
        Me.lblTotalTravelCost.TabIndex = 20
        Me.lblTotalTravelCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Number of Days"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(175, 441)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(68, 23)
        Me.btnExit.TabIndex = 27
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(83, 441)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(68, 23)
        Me.btnClear.TabIndex = 26
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(129, 258)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(68, 23)
        Me.btnSubmit.TabIndex = 25
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtDays
        '
        Me.txtDays.Location = New System.Drawing.Point(154, 34)
        Me.txtDays.Name = "txtDays"
        Me.txtDays.Size = New System.Drawing.Size(100, 20)
        Me.txtDays.TabIndex = 0
        '
        'txtAirCost
        '
        Me.txtAirCost.Location = New System.Drawing.Point(154, 65)
        Me.txtAirCost.Name = "txtAirCost"
        Me.txtAirCost.Size = New System.Drawing.Size(100, 20)
        Me.txtAirCost.TabIndex = 1
        '
        'txtLodgingCost
        '
        Me.txtLodgingCost.Location = New System.Drawing.Point(154, 96)
        Me.txtLodgingCost.Name = "txtLodgingCost"
        Me.txtLodgingCost.Size = New System.Drawing.Size(100, 20)
        Me.txtLodgingCost.TabIndex = 2
        '
        'txtFoodCost
        '
        Me.txtFoodCost.Location = New System.Drawing.Point(154, 127)
        Me.txtFoodCost.Name = "txtFoodCost"
        Me.txtFoodCost.Size = New System.Drawing.Size(100, 20)
        Me.txtFoodCost.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Air Travel Cost"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Lodging Cost"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Food Cost"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Employee Type"
        '
        'radManagement
        '
        Me.radManagement.AutoSize = True
        Me.radManagement.Location = New System.Drawing.Point(154, 170)
        Me.radManagement.Name = "radManagement"
        Me.radManagement.Size = New System.Drawing.Size(87, 17)
        Me.radManagement.TabIndex = 4
        Me.radManagement.Text = "Management"
        Me.radManagement.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDays)
        Me.GroupBox1.Controls.Add(Me.txtAirCost)
        Me.GroupBox1.Controls.Add(Me.txtLodgingCost)
        Me.GroupBox1.Controls.Add(Me.txtFoodCost)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.radManagement)
        Me.GroupBox1.Controls.Add(Me.radNonManagement)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(295, 235)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employee Expenditures"
        '
        'radNonManagement
        '
        Me.radNonManagement.AutoSize = True
        Me.radNonManagement.Checked = True
        Me.radNonManagement.Location = New System.Drawing.Point(154, 193)
        Me.radNonManagement.Name = "radNonManagement"
        Me.radNonManagement.Size = New System.Drawing.Size(110, 17)
        Me.radNonManagement.TabIndex = 5
        Me.radNonManagement.TabStop = True
        Me.radNonManagement.Text = "Non-Management"
        Me.radNonManagement.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 480)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Business Travel Expenses"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTotalEmployeeDue As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTotalReimbursement As Label
    Friend WithEvents lblTotalTravelCost As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtDays As TextBox
    Friend WithEvents txtAirCost As TextBox
    Friend WithEvents txtLodgingCost As TextBox
    Friend WithEvents txtFoodCost As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents radManagement As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radNonManagement As RadioButton
End Class

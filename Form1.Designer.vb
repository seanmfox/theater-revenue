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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtAdultPrice = New System.Windows.Forms.TextBox()
        Me.txtAdultSold = New System.Windows.Forms.TextBox()
        Me.txtChildPrice = New System.Windows.Forms.TextBox()
        Me.txtChildSold = New System.Windows.Forms.TextBox()
        Me.btnCalcRevenue = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblAdultPrice = New System.Windows.Forms.Label()
        Me.lblAdultSold = New System.Windows.Forms.Label()
        Me.lblAdultGrossSalesDescriptor = New System.Windows.Forms.Label()
        Me.lblAdultGrossSalesAmount = New System.Windows.Forms.Label()
        Me.lblChildGrossSalesDescriptor = New System.Windows.Forms.Label()
        Me.lblChildGrossSalesAmount = New System.Windows.Forms.Label()
        Me.lblTotalGrossRevenueDescriptor = New System.Windows.Forms.Label()
        Me.lblTotalGrossRevenueAmount = New System.Windows.Forms.Label()
        Me.lblAdultNetSalesDescriptor = New System.Windows.Forms.Label()
        Me.lblAdultNetSalesAmount = New System.Windows.Forms.Label()
        Me.lblChildNetSalesDescriptor = New System.Windows.Forms.Label()
        Me.lblChildNetSalesAmount = New System.Windows.Forms.Label()
        Me.lblTotalNetRevenueDescriptor = New System.Windows.Forms.Label()
        Me.lblTotalNetRevenueAmount = New System.Windows.Forms.Label()
        Me.lblChildPrice = New System.Windows.Forms.Label()
        Me.lblChildSold = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblAdultSold)
        Me.GroupBox1.Controls.Add(Me.lblAdultPrice)
        Me.GroupBox1.Controls.Add(Me.txtAdultSold)
        Me.GroupBox1.Controls.Add(Me.txtAdultPrice)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(323, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Adult Ticket Sales"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTotalNetRevenueAmount)
        Me.GroupBox2.Controls.Add(Me.lblTotalNetRevenueDescriptor)
        Me.GroupBox2.Controls.Add(Me.lblChildNetSalesAmount)
        Me.GroupBox2.Controls.Add(Me.lblChildNetSalesDescriptor)
        Me.GroupBox2.Controls.Add(Me.lblAdultNetSalesAmount)
        Me.GroupBox2.Controls.Add(Me.lblAdultNetSalesDescriptor)
        Me.GroupBox2.Location = New System.Drawing.Point(408, 164)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(322, 196)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Net Ticket Revenue"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblTotalGrossRevenueAmount)
        Me.GroupBox3.Controls.Add(Me.lblTotalGrossRevenueDescriptor)
        Me.GroupBox3.Controls.Add(Me.lblChildGrossSalesAmount)
        Me.GroupBox3.Controls.Add(Me.lblChildGrossSalesDescriptor)
        Me.GroupBox3.Controls.Add(Me.lblAdultGrossSalesAmount)
        Me.GroupBox3.Controls.Add(Me.lblAdultGrossSalesDescriptor)
        Me.GroupBox3.Location = New System.Drawing.Point(41, 164)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(323, 196)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Gross Ticket Revenue"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblChildSold)
        Me.GroupBox4.Controls.Add(Me.lblChildPrice)
        Me.GroupBox4.Controls.Add(Me.txtChildSold)
        Me.GroupBox4.Controls.Add(Me.txtChildPrice)
        Me.GroupBox4.Location = New System.Drawing.Point(408, 30)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(322, 100)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Child Ticket Sales"
        '
        'txtAdultPrice
        '
        Me.txtAdultPrice.Location = New System.Drawing.Point(175, 32)
        Me.txtAdultPrice.Name = "txtAdultPrice"
        Me.txtAdultPrice.Size = New System.Drawing.Size(125, 22)
        Me.txtAdultPrice.TabIndex = 2
        '
        'txtAdultSold
        '
        Me.txtAdultSold.Location = New System.Drawing.Point(175, 60)
        Me.txtAdultSold.Name = "txtAdultSold"
        Me.txtAdultSold.Size = New System.Drawing.Size(125, 22)
        Me.txtAdultSold.TabIndex = 3
        '
        'txtChildPrice
        '
        Me.txtChildPrice.Location = New System.Drawing.Point(171, 35)
        Me.txtChildPrice.Name = "txtChildPrice"
        Me.txtChildPrice.Size = New System.Drawing.Size(132, 22)
        Me.txtChildPrice.TabIndex = 3
        '
        'txtChildSold
        '
        Me.txtChildSold.Location = New System.Drawing.Point(171, 64)
        Me.txtChildSold.Name = "txtChildSold"
        Me.txtChildSold.Size = New System.Drawing.Size(132, 22)
        Me.txtChildSold.TabIndex = 4
        '
        'btnCalcRevenue
        '
        Me.btnCalcRevenue.Location = New System.Drawing.Point(81, 400)
        Me.btnCalcRevenue.Name = "btnCalcRevenue"
        Me.btnCalcRevenue.Size = New System.Drawing.Size(199, 50)
        Me.btnCalcRevenue.TabIndex = 2
        Me.btnCalcRevenue.Text = "&Calculate Ticket Revenue"
        Me.btnCalcRevenue.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(346, 400)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(115, 50)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Cl&ear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(559, 400)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(118, 50)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblAdultPrice
        '
        Me.lblAdultPrice.AutoSize = True
        Me.lblAdultPrice.Location = New System.Drawing.Point(38, 32)
        Me.lblAdultPrice.Name = "lblAdultPrice"
        Me.lblAdultPrice.Size = New System.Drawing.Size(111, 17)
        Me.lblAdultPrice.TabIndex = 5
        Me.lblAdultPrice.Text = "Price per Ticket:"
        '
        'lblAdultSold
        '
        Me.lblAdultSold.AutoSize = True
        Me.lblAdultSold.Location = New System.Drawing.Point(38, 63)
        Me.lblAdultSold.Name = "lblAdultSold"
        Me.lblAdultSold.Size = New System.Drawing.Size(89, 17)
        Me.lblAdultSold.TabIndex = 6
        Me.lblAdultSold.Text = "Tickets Sold:"
        '
        'lblAdultGrossSalesDescriptor
        '
        Me.lblAdultGrossSalesDescriptor.AutoSize = True
        Me.lblAdultGrossSalesDescriptor.Location = New System.Drawing.Point(37, 35)
        Me.lblAdultGrossSalesDescriptor.Name = "lblAdultGrossSalesDescriptor"
        Me.lblAdultGrossSalesDescriptor.Size = New System.Drawing.Size(125, 17)
        Me.lblAdultGrossSalesDescriptor.TabIndex = 7
        Me.lblAdultGrossSalesDescriptor.Text = "Adult Ticket Sales:"
        '
        'lblAdultGrossSalesAmount
        '
        Me.lblAdultGrossSalesAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAdultGrossSalesAmount.Location = New System.Drawing.Point(168, 32)
        Me.lblAdultGrossSalesAmount.Name = "lblAdultGrossSalesAmount"
        Me.lblAdultGrossSalesAmount.Size = New System.Drawing.Size(125, 29)
        Me.lblAdultGrossSalesAmount.TabIndex = 8
        Me.lblAdultGrossSalesAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblChildGrossSalesDescriptor
        '
        Me.lblChildGrossSalesDescriptor.AutoSize = True
        Me.lblChildGrossSalesDescriptor.Location = New System.Drawing.Point(37, 83)
        Me.lblChildGrossSalesDescriptor.Name = "lblChildGrossSalesDescriptor"
        Me.lblChildGrossSalesDescriptor.Size = New System.Drawing.Size(124, 17)
        Me.lblChildGrossSalesDescriptor.TabIndex = 9
        Me.lblChildGrossSalesDescriptor.Text = "Child Ticket Sales:"
        '
        'lblChildGrossSalesAmount
        '
        Me.lblChildGrossSalesAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblChildGrossSalesAmount.Location = New System.Drawing.Point(168, 79)
        Me.lblChildGrossSalesAmount.Name = "lblChildGrossSalesAmount"
        Me.lblChildGrossSalesAmount.Size = New System.Drawing.Size(125, 30)
        Me.lblChildGrossSalesAmount.TabIndex = 10
        Me.lblChildGrossSalesAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalGrossRevenueDescriptor
        '
        Me.lblTotalGrossRevenueDescriptor.Location = New System.Drawing.Point(17, 118)
        Me.lblTotalGrossRevenueDescriptor.Name = "lblTotalGrossRevenueDescriptor"
        Me.lblTotalGrossRevenueDescriptor.Size = New System.Drawing.Size(145, 53)
        Me.lblTotalGrossRevenueDescriptor.TabIndex = 11
        Me.lblTotalGrossRevenueDescriptor.Text = "Total Gross Revenue for Ticket Sales:"
        Me.lblTotalGrossRevenueDescriptor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalGrossRevenueAmount
        '
        Me.lblTotalGrossRevenueAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalGrossRevenueAmount.Location = New System.Drawing.Point(168, 134)
        Me.lblTotalGrossRevenueAmount.Name = "lblTotalGrossRevenueAmount"
        Me.lblTotalGrossRevenueAmount.Size = New System.Drawing.Size(125, 31)
        Me.lblTotalGrossRevenueAmount.TabIndex = 12
        Me.lblTotalGrossRevenueAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAdultNetSalesDescriptor
        '
        Me.lblAdultNetSalesDescriptor.AutoSize = True
        Me.lblAdultNetSalesDescriptor.Location = New System.Drawing.Point(47, 35)
        Me.lblAdultNetSalesDescriptor.Name = "lblAdultNetSalesDescriptor"
        Me.lblAdultNetSalesDescriptor.Size = New System.Drawing.Size(125, 17)
        Me.lblAdultNetSalesDescriptor.TabIndex = 6
        Me.lblAdultNetSalesDescriptor.Text = "Adult Ticket Sales:"
        '
        'lblAdultNetSalesAmount
        '
        Me.lblAdultNetSalesAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAdultNetSalesAmount.Location = New System.Drawing.Point(171, 28)
        Me.lblAdultNetSalesAmount.Name = "lblAdultNetSalesAmount"
        Me.lblAdultNetSalesAmount.Size = New System.Drawing.Size(132, 29)
        Me.lblAdultNetSalesAmount.TabIndex = 7
        Me.lblAdultNetSalesAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblChildNetSalesDescriptor
        '
        Me.lblChildNetSalesDescriptor.AutoSize = True
        Me.lblChildNetSalesDescriptor.Location = New System.Drawing.Point(47, 83)
        Me.lblChildNetSalesDescriptor.Name = "lblChildNetSalesDescriptor"
        Me.lblChildNetSalesDescriptor.Size = New System.Drawing.Size(124, 17)
        Me.lblChildNetSalesDescriptor.TabIndex = 8
        Me.lblChildNetSalesDescriptor.Text = "Child Ticket Sales:"
        '
        'lblChildNetSalesAmount
        '
        Me.lblChildNetSalesAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblChildNetSalesAmount.Location = New System.Drawing.Point(171, 78)
        Me.lblChildNetSalesAmount.Name = "lblChildNetSalesAmount"
        Me.lblChildNetSalesAmount.Size = New System.Drawing.Size(132, 28)
        Me.lblChildNetSalesAmount.TabIndex = 9
        Me.lblChildNetSalesAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalNetRevenueDescriptor
        '
        Me.lblTotalNetRevenueDescriptor.Location = New System.Drawing.Point(26, 124)
        Me.lblTotalNetRevenueDescriptor.Name = "lblTotalNetRevenueDescriptor"
        Me.lblTotalNetRevenueDescriptor.Size = New System.Drawing.Size(139, 41)
        Me.lblTotalNetRevenueDescriptor.TabIndex = 10
        Me.lblTotalNetRevenueDescriptor.Text = "Total Net Revenue for Ticket Sales:"
        Me.lblTotalNetRevenueDescriptor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalNetRevenueAmount
        '
        Me.lblTotalNetRevenueAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalNetRevenueAmount.Location = New System.Drawing.Point(171, 134)
        Me.lblTotalNetRevenueAmount.Name = "lblTotalNetRevenueAmount"
        Me.lblTotalNetRevenueAmount.Size = New System.Drawing.Size(132, 31)
        Me.lblTotalNetRevenueAmount.TabIndex = 11
        Me.lblTotalNetRevenueAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblChildPrice
        '
        Me.lblChildPrice.AutoSize = True
        Me.lblChildPrice.Location = New System.Drawing.Point(43, 37)
        Me.lblChildPrice.Name = "lblChildPrice"
        Me.lblChildPrice.Size = New System.Drawing.Size(111, 17)
        Me.lblChildPrice.TabIndex = 6
        Me.lblChildPrice.Text = "Price per Ticket:"
        '
        'lblChildSold
        '
        Me.lblChildSold.AutoSize = True
        Me.lblChildSold.Location = New System.Drawing.Point(43, 65)
        Me.lblChildSold.Name = "lblChildSold"
        Me.lblChildSold.Size = New System.Drawing.Size(89, 17)
        Me.lblChildSold.TabIndex = 7
        Me.lblChildSold.Text = "Tickets Sold:"
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCalcRevenue
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 494)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalcRevenue)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Theater Revenue"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtAdultSold As TextBox
    Friend WithEvents txtAdultPrice As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtChildSold As TextBox
    Friend WithEvents txtChildPrice As TextBox
    Friend WithEvents btnCalcRevenue As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblAdultSold As Label
    Friend WithEvents lblAdultPrice As Label
    Friend WithEvents lblTotalNetRevenueAmount As Label
    Friend WithEvents lblTotalNetRevenueDescriptor As Label
    Friend WithEvents lblChildNetSalesAmount As Label
    Friend WithEvents lblChildNetSalesDescriptor As Label
    Friend WithEvents lblAdultNetSalesAmount As Label
    Friend WithEvents lblAdultNetSalesDescriptor As Label
    Friend WithEvents lblTotalGrossRevenueAmount As Label
    Friend WithEvents lblTotalGrossRevenueDescriptor As Label
    Friend WithEvents lblChildGrossSalesAmount As Label
    Friend WithEvents lblChildGrossSalesDescriptor As Label
    Friend WithEvents lblAdultGrossSalesAmount As Label
    Friend WithEvents lblAdultGrossSalesDescriptor As Label
    Friend WithEvents lblChildSold As Label
    Friend WithEvents lblChildPrice As Label
End Class

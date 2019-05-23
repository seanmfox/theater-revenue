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
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtAdultSold)
        Me.GroupBox1.Controls.Add(Me.txtAdultPrice)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(283, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Adult Ticket Sales"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(408, 164)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(309, 196)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Net Ticket Revenue"
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(41, 164)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(323, 196)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Gross Ticket Revenue"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtChildSold)
        Me.GroupBox4.Controls.Add(Me.txtChildPrice)
        Me.GroupBox4.Location = New System.Drawing.Point(380, 30)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(285, 100)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Child Ticket Sales"
        '
        'txtAdultPrice
        '
        Me.txtAdultPrice.Location = New System.Drawing.Point(130, 32)
        Me.txtAdultPrice.Name = "txtAdultPrice"
        Me.txtAdultPrice.Size = New System.Drawing.Size(100, 22)
        Me.txtAdultPrice.TabIndex = 2
        '
        'txtAdultSold
        '
        Me.txtAdultSold.Location = New System.Drawing.Point(130, 60)
        Me.txtAdultSold.Name = "txtAdultSold"
        Me.txtAdultSold.Size = New System.Drawing.Size(100, 22)
        Me.txtAdultSold.TabIndex = 3
        '
        'txtChildPrice
        '
        Me.txtChildPrice.Location = New System.Drawing.Point(179, 32)
        Me.txtChildPrice.Name = "txtChildPrice"
        Me.txtChildPrice.Size = New System.Drawing.Size(100, 22)
        Me.txtChildPrice.TabIndex = 3
        '
        'txtChildSold
        '
        Me.txtChildSold.Location = New System.Drawing.Point(179, 72)
        Me.txtChildSold.Name = "txtChildSold"
        Me.txtChildSold.Size = New System.Drawing.Size(100, 22)
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
        'Form1
        '
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
End Class

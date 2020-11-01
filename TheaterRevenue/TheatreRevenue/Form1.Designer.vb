<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSoldAdults = New System.Windows.Forms.TextBox()
        Me.txtTicketAdults = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSoldChild = New System.Windows.Forms.TextBox()
        Me.txtTicketChild = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblGrossRevenue = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblGrossSaleChild = New System.Windows.Forms.Label()
        Me.lblGrossSaleAdults = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblNetRevenue = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblNetSaleChild = New System.Windows.Forms.Label()
        Me.lblNetSalesAdults = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnCalculateRevenue = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDate
        '
        Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDate.Location = New System.Drawing.Point(347, 13)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(213, 34)
        Me.lblDate.TabIndex = 0
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTime
        '
        Me.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTime.Location = New System.Drawing.Point(139, 13)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(213, 34)
        Me.lblTime.TabIndex = 1
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtSoldAdults)
        Me.GroupBox1.Controls.Add(Me.txtTicketAdults)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(50, 69)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(302, 146)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Adult Ticket Sales"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Tickets Sold"
        '
        'txtSoldAdults
        '
        Me.txtSoldAdults.Location = New System.Drawing.Point(151, 83)
        Me.txtSoldAdults.Name = "txtSoldAdults"
        Me.txtSoldAdults.Size = New System.Drawing.Size(130, 26)
        Me.txtSoldAdults.TabIndex = 5
        '
        'txtTicketAdults
        '
        Me.txtTicketAdults.Location = New System.Drawing.Point(151, 43)
        Me.txtTicketAdults.Name = "txtTicketAdults"
        Me.txtTicketAdults.Size = New System.Drawing.Size(130, 26)
        Me.txtTicketAdults.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Price Per Ticket"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtSoldChild)
        Me.GroupBox2.Controls.Add(Me.txtTicketChild)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(404, 69)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(304, 146)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Child Tickets Sales"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(24, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tickets Sold"
        '
        'txtSoldChild
        '
        Me.txtSoldChild.Location = New System.Drawing.Point(159, 83)
        Me.txtSoldChild.Name = "txtSoldChild"
        Me.txtSoldChild.Size = New System.Drawing.Size(121, 26)
        Me.txtSoldChild.TabIndex = 5
        '
        'txtTicketChild
        '
        Me.txtTicketChild.Location = New System.Drawing.Point(159, 36)
        Me.txtTicketChild.Name = "txtTicketChild"
        Me.txtTicketChild.Size = New System.Drawing.Size(121, 26)
        Me.txtTicketChild.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(24, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Price Per Ticket"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox3.Controls.Add(Me.lblGrossRevenue)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.lblGrossSaleChild)
        Me.GroupBox3.Controls.Add(Me.lblGrossSaleAdults)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(48, 249)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(304, 162)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Gross Ticket Revenue"
        '
        'lblGrossRevenue
        '
        Me.lblGrossRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrossRevenue.Location = New System.Drawing.Point(160, 114)
        Me.lblGrossRevenue.Name = "lblGrossRevenue"
        Me.lblGrossRevenue.Size = New System.Drawing.Size(121, 26)
        Me.lblGrossRevenue.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(5, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(155, 44)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Total Gross Revenue for Ticket Sales:"
        '
        'lblGrossSaleChild
        '
        Me.lblGrossSaleChild.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrossSaleChild.Location = New System.Drawing.Point(160, 78)
        Me.lblGrossSaleChild.Name = "lblGrossSaleChild"
        Me.lblGrossSaleChild.Size = New System.Drawing.Size(121, 26)
        Me.lblGrossSaleChild.TabIndex = 8
        '
        'lblGrossSaleAdults
        '
        Me.lblGrossSaleAdults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrossSaleAdults.Location = New System.Drawing.Point(160, 43)
        Me.lblGrossSaleAdults.Name = "lblGrossSaleAdults"
        Me.lblGrossSaleAdults.Size = New System.Drawing.Size(121, 26)
        Me.lblGrossSaleAdults.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(5, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 19)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Child Tickets Sales:"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(4, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 19)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Adults Tickets Sales:"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox4.Controls.Add(Me.lblNetRevenue)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.lblNetSaleChild)
        Me.GroupBox4.Controls.Add(Me.lblNetSalesAdults)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Location = New System.Drawing.Point(404, 245)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(304, 162)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Net Ticket Revenue"
        '
        'lblNetRevenue
        '
        Me.lblNetRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNetRevenue.Location = New System.Drawing.Point(160, 114)
        Me.lblNetRevenue.Name = "lblNetRevenue"
        Me.lblNetRevenue.Size = New System.Drawing.Size(121, 26)
        Me.lblNetRevenue.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(5, 114)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(155, 44)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Total Net Revenue for Ticket Sales:"
        '
        'lblNetSaleChild
        '
        Me.lblNetSaleChild.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNetSaleChild.Location = New System.Drawing.Point(160, 78)
        Me.lblNetSaleChild.Name = "lblNetSaleChild"
        Me.lblNetSaleChild.Size = New System.Drawing.Size(121, 26)
        Me.lblNetSaleChild.TabIndex = 8
        '
        'lblNetSalesAdults
        '
        Me.lblNetSalesAdults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNetSalesAdults.Location = New System.Drawing.Point(160, 43)
        Me.lblNetSalesAdults.Name = "lblNetSalesAdults"
        Me.lblNetSalesAdults.Size = New System.Drawing.Size(121, 26)
        Me.lblNetSalesAdults.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(7, 85)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(149, 19)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Child Tickets Sales:"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(4, 43)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(156, 19)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Adults Tickets Sales:"
        '
        'btnCalculateRevenue
        '
        Me.btnCalculateRevenue.Location = New System.Drawing.Point(70, 446)
        Me.btnCalculateRevenue.Name = "btnCalculateRevenue"
        Me.btnCalculateRevenue.Size = New System.Drawing.Size(227, 35)
        Me.btnCalculateRevenue.TabIndex = 6
        Me.btnCalculateRevenue.Text = "C&alculate Ticket Revenue"
        Me.btnCalculateRevenue.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(347, 446)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(95, 35)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(513, 446)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(95, 35)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 506)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculateRevenue)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDate)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Theater Revenue"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSoldAdults As TextBox
    Friend WithEvents txtTicketAdults As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSoldChild As TextBox
    Friend WithEvents txtTicketChild As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblGrossRevenue As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblGrossSaleChild As Label
    Friend WithEvents lblGrossSaleAdults As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lblNetRevenue As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblNetSaleChild As Label
    Friend WithEvents lblNetSalesAdults As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnCalculateRevenue As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class

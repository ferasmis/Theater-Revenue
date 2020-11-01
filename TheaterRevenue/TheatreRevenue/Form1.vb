Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'get the system date and display out
        lblDate.Text = Now.ToString("D")
        'get the system time and display out
        lblTime.Text = Now.ToString("T")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear all labels and textboxs
        lblGrossRevenue.Text = ""
        lblGrossSaleAdults.Text = ""
        lblGrossSaleChild.Text = ""
        lblNetRevenue.Text = ""
        lblNetSaleChild.Text = ""
        lblNetSalesAdults.Text = ""
        txtSoldAdults.Text = ""
        txtSoldChild.Text = ""
        txtTicketAdults.Text = ""
        txtTicketChild.Text = ""

        'reset system date and time 
        lblDate.Text = Today.ToString("D")
        lblTime.Text = TimeOfDay.ToString("T")

        'focus to first control
        txtTicketAdults.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'close the application
        Me.Close()
    End Sub

    Private Sub btnCalculateRevenue_Click(sender As Object, e As EventArgs) Handles btnCalculateRevenue.Click
        'declare variables and constants 

        Dim dblAdultTicketTotal As Double
        Dim dblChildTicketTotal As Double
        Dim dblTotalGross As Double

        Dim dblNetAdultTotal As Double
        Dim dblNetChildTotal As Double
        Dim dblTotalNetRevenue As Double
        Const dblBOX_OFFICE_RECEIPTS_RATE As Double = 0.2

        Try
            'calculations and conversions for gross revenue
            dblAdultTicketTotal = CDbl(txtTicketAdults.Text) * CDbl(txtSoldAdults.Text)
            dblChildTicketTotal = CDbl(txtTicketChild.Text) * CDbl(txtSoldChild.Text)
            dblTotalGross = dblAdultTicketTotal + dblChildTicketTotal

            'display in labels for gross revenue
            lblGrossSaleAdults.Text = dblAdultTicketTotal.ToString("c")
            lblGrossSaleChild.Text = dblChildTicketTotal.ToString("c")
            lblGrossRevenue.Text = dblTotalGross.ToString("c")

            'calculations and conversions for net revenue
            dblNetAdultTotal = CDbl(lblGrossSaleAdults.Text) * dblBOX_OFFICE_RECEIPTS_RATE
            dblNetChildTotal = CDbl(lblGrossSaleChild.Text) * dblBOX_OFFICE_RECEIPTS_RATE
            dblTotalNetRevenue = dblTotalGross * dblBOX_OFFICE_RECEIPTS_RATE

            'display in labels for net revenue 
            lblNetSalesAdults.Text = dblNetAdultTotal.ToString("c")
            lblNetSaleChild.Text = dblNetChildTotal.ToString("c")
            lblNetRevenue.Text = dblTotalNetRevenue.ToString("c")
        Catch
            MessageBox.Show("Enter Numeric Values", "Error")
        End Try

    End Sub
End Class

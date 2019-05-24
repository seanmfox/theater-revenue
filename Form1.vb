'Name: Sean Fox
'Course: CIT-161-Z03B
'Date: 5-23-19
'Program Name: Theater Revenue
'Description: Chapter 3, Programming Challenge 4 - Create an application that reflects the gross and net revenue of a theater


Public Class Form1

    Const decPERCENT_REVENUE As Decimal = 0.2D
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnCalcRevenue_Click(sender As Object, e As EventArgs) Handles btnCalcRevenue.Click
        Try
            'Retrieve TextBox inputs
            Dim decAdultPrice As Decimal = CDec(txtAdultPrice.Text)
            Dim decChildPrice As Decimal = CDec(txtChildPrice.Text)
            Dim decAdultSold As Decimal = CDec(txtAdultSold.Text)
            Dim decChildSold As Decimal = CDec(txtChildSold.Text)

            Dim decAdultGrossSales As Decimal = decAdultPrice * decAdultSold
            lblAdultGrossSalesAmount.Text = decAdultGrossSales.ToString("c")

            Dim decChildGrossSales As Decimal = decChildPrice * decChildSold
            lblChildGrossSalesAmount.Text = decChildGrossSales.ToString("c")

            Dim decTotalGrossRevenue = decAdultGrossSales + decChildGrossSales
            lblTotalGrossRevenueAmount.Text = decTotalGrossRevenue.ToString("c")

            Dim decAdultNetSales As Decimal = decAdultGrossSales * decPERCENT_REVENUE
            lblAdultNetSalesAmount.Text = decAdultNetSales.ToString("c")

            Dim decChildNetSales As Decimal = decChildGrossSales * decPERCENT_REVENUE
            lblChildNetSalesAmount.Text = decChildNetSales.ToString("c")

            Dim decTotalNetRevenue = decAdultNetSales + decChildNetSales
            lblTotalNetRevenueAmount.Text = decTotalNetRevenue.ToString("c")

        Catch ex As Exception
            MessageBox.Show("Only numeric values can be entered in the form.")
        End Try
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAdultPrice.Text = String.Empty
        txtChildPrice.Text = String.Empty
        txtAdultSold.Text = String.Empty
        txtChildSold.Text = String.Empty
        lblAdultGrossSalesAmount.Text = String.Empty
        lblChildGrossSalesAmount.Text = String.Empty
        lblTotalGrossRevenueAmount.Text = String.Empty
        lblAdultNetSalesAmount.Text = String.Empty
        lblChildNetSalesAmount.Text = String.Empty
        lblTotalNetRevenueAmount.Text = String.Empty
        txtAdultPrice.Focus()

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

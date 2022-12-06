Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmVoucherReport
    Sub fillPaymentID()
        Try
            Dim CN As New SqlConnection(cs)
            CN.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct RTRIM(VoucherNo) FROM Voucher", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbVoucherNo.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbVoucherNo.Items.Add(drow(0).ToString())
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmLogs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillPaymentID()
    End Sub
    Sub Reset()
        cmbVoucherNo.Text = ""
        fillPaymentID()
    End Sub
    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        Reset()
    End Sub


    Private Sub btnClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If cmbVoucherNo.Text = "" Then
                MessageBox.Show("Please select voucher no.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbVoucherNo.Focus()
                Exit Sub
            End If
            Cursor = Cursors.WaitCursor
            Timer1.Enabled = True
            Dim rpt As New rptVoucher 'The report you created.
            Dim myConnection As SqlConnection
            Dim MyCommand As New SqlCommand()
            Dim myDA As New SqlDataAdapter()
            Dim myDS As New DataSet 'The DataSet you created.
            myConnection = New SqlConnection(cs)
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "SELECT Voucher.ID, Voucher.VoucherNo, Voucher.Date, Voucher.Name, Voucher.Details, Voucher.SchoolID, Voucher.GrandTotal, Voucher_OtherDetails.VD_ID, Voucher_OtherDetails.VoucherID,Voucher_OtherDetails.Particulars, Voucher_OtherDetails.Amount, Voucher_OtherDetails.Note, SchoolInfo.S_Id, SchoolInfo.SchoolName, SchoolInfo.Address, SchoolInfo.ContactNo, SchoolInfo.AltContactNo,SchoolInfo.FaxNo, SchoolInfo.Email, SchoolInfo.Website, SchoolInfo.Logo, SchoolInfo.RegistrationNo, SchoolInfo.DiseNo, SchoolInfo.IndexNo, SchoolInfo.EstablishedYear, SchoolInfo.Class,SchoolInfo.SchoolType FROM Voucher INNER JOIN Voucher_OtherDetails ON Voucher.ID = Voucher_OtherDetails.VoucherID INNER JOIN SchoolInfo ON Voucher.SchoolID = SchoolInfo.S_Id where VoucherNo='" & cmbVoucherNo.Text & "'"
            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand
            myDA.Fill(myDS, "Voucher")
            myDA.Fill(myDS, "Voucher_OtherDetails")
            myDA.Fill(myDS, "SchoolInfo")
            rpt.SetDataSource(myDS)
            frmReport.CrystalReportViewer1.ReportSource = rpt
            frmReport.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Cursor = Cursors.Default
        Timer1.Enabled = False
    End Sub

End Class

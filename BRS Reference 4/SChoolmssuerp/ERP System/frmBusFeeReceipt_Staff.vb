Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmBusFeeReceipt_Staff
    Sub fillPaymentID()
        Try
            Dim CN As New SqlConnection(cs)
            CN.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct RTRIM(PaymentID) FROM BusFeePayment_Staff", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbPaymentID.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbPaymentID.Items.Add(drow(0).ToString())
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmLogs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillPaymentID()
    End Sub
    Sub Reset()
        cmbPaymentID.Text = ""
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
            If cmbPaymentID.Text = "" Then
                MessageBox.Show("Please select payment id", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbPaymentID.Focus()
                Exit Sub
            End If
            Cursor = Cursors.WaitCursor
                Timer1.Enabled = True
                Dim rpt As New rptBusFeeReceipt_Staff 'The report you created.
                Dim myConnection As SqlConnection
                Dim MyCommand As New SqlCommand()
                Dim myDA As New SqlDataAdapter()
                Dim myDS As New DataSet 'The DataSet you created.
                myConnection = New SqlConnection(cs)
                MyCommand.Connection = myConnection
            MyCommand.CommandText = "SELECT BusFeePayment_Staff.Id, BusFeePayment_Staff.BFP_ID, BusFeePayment_Staff.PaymentID, BusFeePayment_Staff.BusHolderID, BusFeePayment_Staff.Session, BusFeePayment_Staff.Installment,BusFeePayment_Staff.TotalFee, BusFeePayment_Staff.DiscountPer, BusFeePayment_Staff.DiscountAmt, BusFeePayment_Staff.PreviousDue, BusFeePayment_Staff.Fine, BusFeePayment_Staff.GrandTotal, BusFeePayment_Staff.TotalPaid, BusFeePayment_Staff.ModeOfPayment, BusFeePayment_Staff.PaymentModeDetails, BusFeePayment_Staff.PaymentDate, BusFeePayment_Staff.PaymentDue,BusCardHolder_Staff.BCH_ID, BusCardHolder_Staff.StaffID, BusCardHolder_Staff.BusNo, BusCardHolder_Staff.Location, BusCardHolder_Staff.JoiningDate, BusCardHolder_Staff.Status, Staff.St_ID,Staff.StaffID AS Expr1, Staff.StaffName, Staff.DateOfJoining, Staff.Gender, Staff.FatherName, Staff.TemporaryAddress, Staff.PermanentAddress, Staff.Designation, Staff.Qualifications, Staff.DOB, Staff.PhoneNo,Staff.MobileNo, Staff.Photo, Staff.ClassType, Staff.SchoolID, Staff.AccountName, Staff.AccountNumber, Staff.Bank, Staff.Branch, Staff.IFSCcode, Staff.Salary, SchoolInfo.S_Id,SchoolInfo.SchoolName, SchoolInfo.Address, SchoolInfo.ContactNo, SchoolInfo.AltContactNo, SchoolInfo.FaxNo, SchoolInfo.Email , SchoolInfo.Website, SchoolInfo.Logo, SchoolInfo.RegistrationNo,SchoolInfo.DiseNo, SchoolInfo.IndexNo, SchoolInfo.EstablishedYear, SchoolInfo.Class, SchoolInfo.SchoolType FROM BusFeePayment_Staff INNER JOIN BusCardHolder_Staff ON BusFeePayment_Staff.BusHolderID = BusCardHolder_Staff.BCH_ID INNER JOIN Staff ON BusCardHolder_Staff.StaffID = Staff.St_ID INNER JOIN SchoolInfo ON Staff.SchoolID = SchoolInfo.S_Id where BusFeePayment_Staff.PaymentID='" & cmbPaymentID.Text & "'"
                MyCommand.CommandType = CommandType.Text
                myDA.SelectCommand = MyCommand
                myDA.Fill(myDS, "SchoolInfo")
                myDA.Fill(myDS, "Staff")
                myDA.Fill(myDS, "BusCardHolder_Staff")
                myDA.Fill(myDS, "BusFeePayment_Staff")
                rpt.SetDataSource(myDS)
                rpt.SetParameterValue("p1", txtStaffID.Text)
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

    Private Sub cmbPaymentID_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbPaymentID.SelectedIndexChanged
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandText = "SELECT Staff.StaffID FROM Staff,BusCardHolder_Staff,BusFeePayment_Staff where Staff.St_ID=BusCardHolder_Staff.StaffID and BusCardHolder_Staff.BCH_ID=BusFeePayment_Staff.BusHolderID and PaymentID='" & cmbPaymentID.Text & "'"
            cmd.Parameters.AddWithValue("@d1", txtStaffID.Text)
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                txtStaffID.Text = rdr.GetValue(0).ToString().Trim()
            End If
            If (rdr IsNot Nothing) Then
                rdr.Close()
            End If
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub
End Class

Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmAdvanceEntryReport
    Sub fillStaff()
        Try
            Dim CN As New SqlConnection(cs)
            CN.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct RTRIM(StaffName) FROM Staff,AdvanceEntry where Staff.St_ID=AdvanceEntry.StaffID", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbStaffName.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbStaffName.Items.Add(drow(0).ToString())
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmLogs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillStaff()
    End Sub
    Sub Reset()
        cmbStaffName.SelectedIndex = -1
        DateTimePicker1.Text = Now
        DateTimePicker2.Text = Today
        dtpDateFrom.Text = Today
        dtpDateTo.Text = Now
        fillStaff()
    End Sub
    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        Reset()
    End Sub


    Private Sub btnClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If Len(Trim(cmbStaffName.Text)) = 0 Then
                MessageBox.Show("Please select Staff name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbStaffName.Focus()
                Exit Sub
            End If
            Cursor = Cursors.WaitCursor
            Timer1.Enabled = True
            Dim rpt As New rptAdvanceEntry 'The report you created.
            Dim myConnection As SqlConnection
            Dim MyCommand As New SqlCommand()
            Dim myDA As New SqlDataAdapter()
            Dim myDS As New DataSet 'The DataSet you created.
            myConnection = New SqlConnection(cs)
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "SELECT AdvanceEntry.Id, AdvanceEntry.StaffID, AdvanceEntry.Amount, AdvanceEntry.Deduction, AdvanceEntry.WorkingDate, Staff.St_ID, Staff.StaffID AS Expr1, Staff.StaffName, Staff.DateOfJoining, Staff.Gender,Staff.FatherName, Staff.TemporaryAddress, Staff.PermanentAddress, Staff.Designation, Staff.Qualifications, Staff.DOB, Staff.PhoneNo, Staff.MobileNo, Staff.Email, Staff.Photo, Staff.ClassType, Staff.SchoolID,Staff.AccountName, Staff.AccountNumber, Staff.Bank, Staff.Branch, Staff.IFSCcode, Staff.Status, Staff.Salary FROM AdvanceEntry INNER JOIN Staff ON AdvanceEntry.StaffID = Staff.St_ID where WorkingDate between @d1 and @d2 and StaffName=@d3 and Amount > 0 order by WorkingDate"
            MyCommand.Parameters.Add("@d1", SqlDbType.DateTime, 30, "DateIN").Value = dtpDateFrom.Value.Date
            MyCommand.Parameters.Add("@d2", SqlDbType.DateTime, 30, "DateIN").Value = dtpDateTo.Value
            MyCommand.Parameters.Add("@d3", SqlDbType.NChar, 200, "Name").Value = cmbStaffName.Text
            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand
            myDA.Fill(myDS, "Staff")
            myDA.Fill(myDS, "AdvanceEntry")
            rpt.SetDataSource(myDS)
            rpt.SetParameterValue("v1", dtpDateFrom.Value.Date)
            rpt.SetParameterValue("v2", dtpDateTo.Value.Date)
            frmReport.CrystalReportViewer1.ReportSource = rpt
            frmReport.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Cursor = Cursors.WaitCursor
            Timer1.Enabled = True
            Dim rpt As New rptAdvanceEntry 'The report you created.
            Dim myConnection As SqlConnection
            Dim MyCommand As New SqlCommand()
            Dim myDA As New SqlDataAdapter()
            Dim myDS As New DataSet 'The DataSet you created.
            myConnection = New SqlConnection(cs)
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "SELECT AdvanceEntry.Id, AdvanceEntry.StaffID, AdvanceEntry.Amount, AdvanceEntry.Deduction, AdvanceEntry.WorkingDate, Staff.St_ID, Staff.StaffID AS Expr1, Staff.StaffName, Staff.DateOfJoining, Staff.Gender,Staff.FatherName, Staff.TemporaryAddress, Staff.PermanentAddress, Staff.Designation, Staff.Qualifications, Staff.DOB, Staff.PhoneNo, Staff.MobileNo, Staff.Email, Staff.Photo, Staff.ClassType, Staff.SchoolID,Staff.AccountName, Staff.AccountNumber, Staff.Bank, Staff.Branch, Staff.IFSCcode, Staff.Status, Staff.Salary FROM AdvanceEntry INNER JOIN Staff ON AdvanceEntry.StaffID = Staff.St_ID where WorkingDate between @d1 and @d2 and Amount > 0 order by WorkingDate"
            MyCommand.Parameters.Add("@d1", SqlDbType.DateTime, 30, "DateIN").Value = DateTimePicker2.Value.Date
            MyCommand.Parameters.Add("@d2", SqlDbType.DateTime, 30, "DateIN").Value = DateTimePicker1.Value
            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand
            myDA.Fill(myDS, "Staff")
            myDA.Fill(myDS, "AdvanceEntry")
            rpt.SetDataSource(myDS)
            rpt.SetParameterValue("v1", DateTimePicker2.Value.Date)
            rpt.SetParameterValue("v2", DateTimePicker1.Value.Date)
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

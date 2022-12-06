Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Public Class frmStaffPayment
    Sub Reset()
        DateFrom.value = Today
        DateTo.value = Today
        StaffID.Text = ""
        StaffName.Text = ""
        Designation.Text = ""
        Salary.Text = ""
        PresentDays.Text = ""
        Advance.Text = ""
        Deduction.Text = ""
        PaymentDate.Text = Now
        paymentmode.SelectedIndex = -1
        PaymentModeDetails.Text = ""
        NetPay.Text = ""
        PaymentID.Text = ""
        txtStaff.Text = ""
        txtStaff.Text = ""
        GetData()
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        btnPrint.Enabled = False
        DateFrom.Enabled = True
        DateTo.Enabled = True
        PaymentDate.Enabled = True
        Deduction.ReadOnly = False
        dgw.Enabled = True
        auto()
    End Sub
    Sub GetData()
        Try
            con = New SqlConnection(cs)
            con.Open()
            Dim sql As String = "SELECT RTRIM(Staff.St_ID) ,RTRIM(Staff.StaffID),RTRIM(StaffName),RTRIM(Designation),RTRIM(Salary) from Staff order by StaffName"
            cmd = New SqlCommand(sql, con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            While (rdr.Read() = True)
                dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Try
            If Len(Trim(StaffID.Text)) = 0 Then
                MessageBox.Show("Please retrieve Staff id", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                StaffID.Focus()
                Exit Sub
            End If
            If Len(Trim(paymentmode.Text)) = 0 Then
                MessageBox.Show("Please select payment mode", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                paymentmode.Focus()
                Exit Sub
            End If
            If Advance.Text = Nothing Then
                Advance.Text = 0
            End If
            If Val(Advance.Text) < Val(Deduction.Text) Then
                MessageBox.Show("You can not deduct amount more than advance amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Deduction.Focus()
                Exit Sub
            End If
            If Val(NetPay.Text) < 0 Then
                MessageBox.Show("net pay should be more than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If DateTo.Value.Date < DateFrom.Value.Date Then
                MessageBox.Show("Selected 'Date To' must be greater than 'Date From'", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DateTo.Focus()
                Exit Sub
            End If
            If DateTo.Value.Date = DateFrom.Value.Date Then
                MessageBox.Show("Selected 'Date From' is equal to 'Date To'", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DateFrom.Focus()
                Exit Sub
            End If
            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "SELECT * FROM StaffPayment WHERE DateFrom <= @d1 AND DateTo >= @d2 and StaffID=" & txtStID.Text & ""
            cmd = New SqlCommand(ct)
            cmd.Parameters.AddWithValue("@d1", DateTo.Value.Date)
            cmd.Parameters.AddWithValue("@d2", DateFrom.Value.Date)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If rdr.Read Then
                MessageBox.Show("Salary already paid..Select correct payment date", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If
            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "insert into Staffpayment(ID,PaymentID,DateFrom,DateTo,StaffID,PresentDays,Salary,Advance,Deduction,PaymentDate,ModeOfPayment,PaymentModeDetails,Netpay) values(" & txtID.Text & ",@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12)"
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", PaymentID.Text)
            cmd.Parameters.AddWithValue("@d2", DateFrom.Text)
            cmd.Parameters.AddWithValue("@d3", DateTo.Text)
            cmd.Parameters.AddWithValue("@d4", txtStID.Text)
            cmd.Parameters.AddWithValue("@d5", PresentDays.Text)
            cmd.Parameters.AddWithValue("@d6", Salary.Text)
            cmd.Parameters.AddWithValue("@d7", Advance.Text)
            cmd.Parameters.AddWithValue("@d8", Deduction.Text)
            cmd.Parameters.AddWithValue("@d9", PaymentDate.Value)
            cmd.Parameters.AddWithValue("@d10", paymentmode.Text)
            cmd.Parameters.AddWithValue("@d11", PaymentModeDetails.Text)
            cmd.Parameters.AddWithValue("@d12", NetPay.Text)
            cmd.ExecuteNonQuery()
            con.Close()
            auto1()
            con = New SqlConnection(cs)
            con.Open()
            Dim cb2 As String = "insert into advanceentry(ID,workingdate,StaffID,amount,deduction) VALUES (" & txtID1.Text & ",@d1,@d2,@d3,@d4)"
            cmd = New SqlCommand(cb2)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", PaymentDate.Value)
            cmd.Parameters.AddWithValue("@d2", txtStID.Text)
            cmd.Parameters.AddWithValue("@d3", 0)
            cmd.Parameters.AddWithValue("@d4", Deduction.Text)
            cmd.ExecuteReader()
            con.Close()
            Dim st As String = "added the new payment entry having payment id '" & PaymentID.Text & "'"
            LogFunc(lblUser.Text, st)
            MessageBox.Show("Successfully paid", "Staff", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnSave.Enabled = False
            con.Close()
            Print()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click

        Try
            If Len(Trim(StaffID.Text)) = 0 Then
                MessageBox.Show("Please retrieve Staff id", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                StaffID.Focus()
                Exit Sub
            End If
            If Len(Trim(paymentmode.Text)) = 0 Then
                MessageBox.Show("Please select payment mode", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                paymentmode.Focus()
                Exit Sub
            End If
            If Advance.Text = Nothing Then
                Advance.Text = 0
            End If
            If Val(Advance.Text) < Val(Deduction.Text) Then
                MessageBox.Show("You can not deduct amount more than advance amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Deduction.Focus()
                Exit Sub
            End If
            If Val(NetPay.Text) < 0 Then
                MessageBox.Show("net pay should be more than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If DateTo.Value.Date < DateFrom.Value.Date Then
                MessageBox.Show("Selected 'Date To' must be greater than 'Date From'", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DateTo.Focus()
                Exit Sub
            End If
            If DateTo.Value.Date = DateFrom.Value.Date Then
                MessageBox.Show("Selected 'Date From' is equal to 'Date To'", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DateFrom.Focus()
                Exit Sub
            End If
            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "update Staffpayment set PaymentID=@d1,StaffID=@d4,PresentDays=@d5,Salary=@d6,Advance=@d7,Deduction=@d8,ModeOfPayment=@d9,PaymentModeDetails=@d10,Netpay=@d11 where ID=" & txtID.Text & ""
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", PaymentID.Text)
            cmd.Parameters.AddWithValue("@d4", txtStID.Text)
            cmd.Parameters.AddWithValue("@d5", PresentDays.Text)
            cmd.Parameters.AddWithValue("@d6", Salary.Text)
            cmd.Parameters.AddWithValue("@d7", Advance.Text)
            cmd.Parameters.AddWithValue("@d8", Deduction.Text)
            cmd.Parameters.AddWithValue("@d9", paymentmode.Text)
            cmd.Parameters.AddWithValue("@d10", PaymentModeDetails.Text)
            cmd.Parameters.AddWithValue("@d11", NetPay.Text)
            cmd.ExecuteNonQuery()
            con.Close()
            Dim st As String = "updated the payment entry having payment id '" & PaymentID.Text & "'"
            LogFunc(lblUser.Text, st)
            MessageBox.Show("Successfully updated", "Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnUpdate.Enabled = False
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        Try
            If MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                DeleteRecord()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub DeleteRecord()
        Try
            Dim RowsAffected As Integer = 0
            con = New SqlConnection(cs)
            con.Open()
            Dim cq As String = "delete from StaffPayment where id=" & txtID.Text & ""
            cmd = New SqlCommand(cq)
            cmd.Connection = con
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                Dim st As String = "deleted the payment entry having payment id '" & PaymentID.Text & "'"
                LogFunc(lblUser.Text, st)
                MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                GetData()
                Reset()
                Reset()
            Else
                MessageBox.Show("No Record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()
            End If
            If con.State = ConnectionState.Open Then
                con.Close()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Reset()
        Reset()
    End Sub

    Private Sub frmAdvanceEntry_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        GetData()
    End Sub
    Sub Compute()
        Try
            Dim num1, num2 As Double
            num1 = CDbl((Val(txtSalary.Text) * Val(PresentDays.Text)) / 30)
            num1 = Math.Round(num1, 2)
            Salary.Text = num1
            num2 = CDbl(Val(Salary.Text) - Val(Deduction.Text))
            num2 = Math.Round(num2, 2)
            NetPay.Text = num2
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub dgw_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles dgw.MouseClick
        Try
            If DateTo.Value.Date < DateFrom.Value.Date Then
                MessageBox.Show("Selected 'Date To' must be greater than 'Date From'", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DateTo.Focus()
                Exit Sub
            End If
            If DateTo.Value.Date = DateFrom.Value.Date Then
                MessageBox.Show("Selected 'Date From' is equal to 'Date To'", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DateFrom.Focus()
                Exit Sub
            End If
            Dim dr As DataGridViewRow = dgw.SelectedRows(0)
            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "SELECT * FROM StaffPayment WHERE DateFrom <= @d1 AND DateTo >= @d2 and StaffID=" & dr.Cells(0).Value & ""
            cmd = New SqlCommand(ct)
            cmd.Parameters.AddWithValue("@d1", DateTo.Value.Date)
            cmd.Parameters.AddWithValue("@d2", DateFrom.Value.Date)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If rdr.Read Then
                MessageBox.Show("Salary already paid..Select correct payment date", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If
            con.Close()
            txtStID.Text = dr.Cells(0).Value.ToString
            StaffID.Text = dr.Cells(1).Value.ToString
            StaffName.Text = dr.Cells(2).Value.ToString
            Designation.Text = dr.Cells(3).Value.ToString
            txtSalary.Text = dr.Cells(4).Value.ToString
            con.Open()
            Dim cp As String = "select count(status) from StaffAttendance where WorkingDate between @d1 and @d2 and status='P' and  StaffID=" & txtStID.Text & ""
            cmd = New SqlCommand(cp)
            cmd.Connection = con
            cmd.Parameters.Add("@d1", SqlDbType.DateTime, 30, "DateIN").Value = DateFrom.Value.Date
            cmd.Parameters.Add("@d2", SqlDbType.DateTime, 30, "DateIN").Value = DateTo.Value.Date
            Dim result = cmd.ExecuteScalar()
            PresentDays.Text = Convert.ToString(result)
            Dim num1 As Double
            num1 = CDbl((Val(txtSalary.Text) * Val(PresentDays.Text)) / 30)
            num1 = Math.Round(num1, 2)
            Salary.Text = num1
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            Dim cp1 As String = "select sum(amount)-sum(deduction) from advanceentry where StaffID=" & txtStID.Text & ""
            cmd = New SqlCommand(cp1)
            cmd.Connection = con
            Dim result1 = cmd.ExecuteScalar()
            Advance.Text = Convert.ToString(result1)
            If Advance.Text = Nothing Then
                Advance.Text = 0
            End If
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            Deduction.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgw_RowPostPaint(sender As Object, e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgw.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString()
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If dgw.RowHeadersWidth < Convert.ToInt32((size.Width + 20)) Then
            dgw.RowHeadersWidth = Convert.ToInt32((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))

    End Sub
    Private Sub auto1()
        Dim Num As Integer = 0
        con = New SqlConnection(cs)
        con.Open()
        Dim sql As String = ("SELECT MAX(ID) FROM AdvanceEntry")
        cmd = New SqlCommand(sql)
        cmd.Connection = con
        If (IsDBNull(cmd.ExecuteScalar)) Then
            Num = 1
            txtID1.Text = Num.ToString
        Else
            Num = cmd.ExecuteScalar + 1
            txtID1.Text = Num.ToString
        End If
        cmd.Dispose()
        con.Close()
        con.Dispose()
    End Sub
    Private Sub auto()
        Dim Num As Integer = 0
        con = New SqlConnection(cs)
        con.Open()
        Dim sql As String = ("SELECT MAX(ID) FROM StaffPayment")
        cmd = New SqlCommand(sql)
        cmd.Connection = con
        If (IsDBNull(cmd.ExecuteScalar)) Then
            Num = 1
            txtID.Text = Num.ToString
            PaymentID.Text = "P-" + Num.ToString
        Else
            Num = cmd.ExecuteScalar + 1
            txtID.Text = Num.ToString
            PaymentID.Text = "P-" + Num.ToString
        End If
        cmd.Dispose()
        con.Close()
        con.Dispose()
    End Sub
    Private Sub btnGetData_Click(sender As System.Object, e As System.EventArgs) Handles btnGetData.Click
        frmStaffPaymentRecord.lblSet.Text = "Payment Entry"
        frmStaffPaymentRecord.Reset()
        frmStaffPaymentRecord.ShowDialog()
    End Sub

    Private Sub txtStaff_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtStaff.TextChanged
        Try
            con = New SqlConnection(cs)
            con.Open()
            Dim sql As String = "SELECT RTRIM(Staff.St_ID) ,RTRIM(Staff.StaffID),RTRIM(StaffName),RTRIM(Designation),RTRIM(Salary) from Staff where StaffName like '" & txtStaff.Text & "%' order by StaffName"
            cmd = New SqlCommand(sql, con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            While (rdr.Read() = True)
                dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub OvertimeRate_TextChanged(sender As System.Object, e As System.EventArgs)
        Compute()
    End Sub

    Private Sub Deduction_TextChanged(sender As System.Object, e As System.EventArgs) Handles Deduction.TextChanged
        Compute()
    End Sub

    Private Sub DateTo_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles DateTo.Validating
        If DateTo.Value.Date < DateFrom.Value.Date Then
            MessageBox.Show("Selected 'Date To' must be greater than 'Date From'", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DateTo.Focus()
            Exit Sub
        End If
        If DateTo.Value.Date = DateFrom.Value.Date Then
            MessageBox.Show("Selected 'Date To' is equal to 'Date From'", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DateFrom.Focus()
            Exit Sub
        End If
    End Sub
    Sub Print()
        Try
            Cursor = Cursors.WaitCursor
            Timer1.Enabled = True
            Dim rpt As New rptSalarySlip 'The report you created.
            Dim myConnection As SqlConnection
            Dim MyCommand As New SqlCommand()
            Dim myDA As New SqlDataAdapter()
            Dim myDS As New DataSet 'The DataSet you created.
            myConnection = New SqlConnection(cs)
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "SELECT SchoolInfo.S_Id, SchoolInfo.SchoolName, SchoolInfo.Address, SchoolInfo.ContactNo, SchoolInfo.AltContactNo, SchoolInfo.FaxNo, SchoolInfo.Email, SchoolInfo.Website, SchoolInfo.Logo, SchoolInfo.RegistrationNo,SchoolInfo.DiseNo, SchoolInfo.IndexNo, SchoolInfo.EstablishedYear, SchoolInfo.Class, SchoolInfo.SchoolType, Staff.StaffID, Staff.StaffName, Staff.DateOfJoining, Staff.Gender, Staff.FatherName,Staff.TemporaryAddress, Staff.PermanentAddress, Staff.Designation, Staff.Qualifications, Staff.DOB, Staff.PhoneNo, Staff.MobileNo, Staff.Email AS Expr1, Staff.Photo, Staff.ClassType, Staff.SchoolID,Staff.AccountName, Staff.AccountNumber, Staff.Bank, Staff.Branch, Staff.IFSCcode, Staff.Status, StaffPayment.Id, StaffPayment.PaymentID, StaffPayment.DateFrom, StaffPayment.DateTo,StaffPayment.StaffID AS Expr2, StaffPayment.PresentDays, StaffPayment.Salary , StaffPayment.Advance, StaffPayment.Deduction, StaffPayment.PaymentDate, StaffPayment.ModeOfPayment,StaffPayment.PaymentModeDetails, StaffPayment.NetPay FROM SchoolInfo INNER JOIN Staff ON SchoolInfo.S_Id = Staff.SchoolID INNER JOIN StaffPayment ON Staff.St_ID = StaffPayment.StaffID where PaymentID='" & PaymentID.Text & "'"
            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand
            myDA.Fill(myDS, "StaffPayment")
            myDA.Fill(myDS, "Staff")
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

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Print()
    End Sub

    Private Sub Deduction_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles Deduction.Validating
        If Val(Advance.Text) < Val(Deduction.Text) Then
            MessageBox.Show("You can not deduct amount more than advance amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Deduction.Focus()
            Exit Sub
        End If
    End Sub
End Class

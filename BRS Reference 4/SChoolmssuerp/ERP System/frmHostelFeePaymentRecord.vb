Imports System.Data.SqlClient
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmHostelFeePaymentRecord
    Public Sub GetData()
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("Select RTRIM(HostelFeePayment.Id) as [ID], RTRIM(HFP_ID) as [HFP ID], RTRIM(PaymentID) as [Payment ID],RTRIM(HostelerID) as [Hosteler ID], RTRIM(Student.AdmissionNo) as [Admission No.],RTRIM(StudentName) as [StudentName],RTRIM(EnrollmentNo) as [Enrollment No.],RTRIM(SchoolName) as [School Name],RTRIM(Hostelname) as [Hostel name],RTRIM(HostelFeePayment.Class) as [Class],RTRIM(HostelFeePayment.Section) as [Section], RTRIM(HostelFeePayment.Session) as [Session],RTRIM(installment) as [installment],  RTRIM(TotalFee) as [Total Fee], RTRIM(DiscountPer) as [Discount %], RTRIM(DiscountAmt) as [Discount], RTRIM(PreviousDue) as [Previous Due], RTRIM(Fine) as [Fine], RTRIM(GrandTotal) as [Grand Total], RTRIM(TotalPaid) as [Total Paid], RTRIM(ModeOfPayment) as [Payment Mode], RTRIM(PaymentModeDetails) as [Payement Mode Info], Convert(Datetime,PaymentDate,131) as [Payement Date], RTRIM(PaymentDue) as [Payement Due],RTRIM(HostelFeePayment.ClassType) as [Class Type], RTRIM(HostelFeePayment.SchoolType) as [School Type] from Student,SchoolInfo,HostelFeePayment,Hosteler,Hostelinfo where SchoolInfo.S_ID=Student.SchoolID and Hosteler.H_ID=HostelFeePayment.HostelerID and HostelInfo.HI_ID=Hosteler.HostelID and Student.AdmissionNo=Hosteler.AdmissionNo order by StudentName", con)
            adp = New SqlDataAdapter(cmd)
            ds = New DataSet()
            adp.Fill(ds, "Student")
            dgw.DataSource = ds.Tables("Student").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub txtStudentName_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtStudentName.TextChanged
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("Select RTRIM(HostelFeePayment.Id) as [ID], RTRIM(HFP_ID) as [HFP ID], RTRIM(PaymentID) as [Payment ID],RTRIM(HostelerID) as [Hosteler ID], RTRIM(Student.AdmissionNo) as [Admission No.],RTRIM(StudentName) as [StudentName],RTRIM(EnrollmentNo) as [Enrollment No.],RTRIM(SchoolName) as [School Name],RTRIM(Hostelname) as [Hostel name],RTRIM(HostelFeePayment.Class) as [Class],RTRIM(HostelFeePayment.Section) as [Section], RTRIM(HostelFeePayment.Session) as [Session],RTRIM(installment) as [installment],  RTRIM(TotalFee) as [Total Fee], RTRIM(DiscountPer) as [Discount %], RTRIM(DiscountAmt) as [Discount], RTRIM(PreviousDue) as [Previous Due], RTRIM(Fine) as [Fine], RTRIM(GrandTotal) as [Grand Total], RTRIM(TotalPaid) as [Total Paid], RTRIM(ModeOfPayment) as [Payment Mode], RTRIM(PaymentModeDetails) as [Payement Mode Info], Convert(Datetime,PaymentDate,131) as [Payement Date], RTRIM(PaymentDue) as [Payement Due],RTRIM(HostelFeePayment.ClassType) as [Class Type], RTRIM(HostelFeePayment.SchoolType) as [School Type] from Student,SchoolInfo,HostelFeePayment,Hosteler,Hostelinfo where SchoolInfo.S_ID=Student.SchoolID and Hosteler.H_ID=HostelFeePayment.HostelerID and HostelInfo.HI_ID=Hosteler.HostelID and Student.AdmissionNo=Hosteler.AdmissionNo and StudentName like '" & txtStudentName.Text & "%' order by StudentName", con)
            adp = New SqlDataAdapter(cmd)
            ds = New DataSet()
            adp.Fill(ds, "Student")
            dgw.DataSource = ds.Tables("Student").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("Select RTRIM(HostelFeePayment.Id) as [ID], RTRIM(HFP_ID) as [HFP ID], RTRIM(PaymentID) as [Payment ID],RTRIM(HostelerID) as [Hosteler ID], RTRIM(Student.AdmissionNo) as [Admission No.],RTRIM(StudentName) as [StudentName],RTRIM(EnrollmentNo) as [Enrollment No.],RTRIM(SchoolName) as [School Name],RTRIM(Hostelname) as [Hostel name],RTRIM(HostelFeePayment.Class) as [Class],RTRIM(HostelFeePayment.Section) as [Section], RTRIM(HostelFeePayment.Session) as [Session],RTRIM(installment) as [installment],  RTRIM(TotalFee) as [Total Fee], RTRIM(DiscountPer) as [Discount %], RTRIM(DiscountAmt) as [Discount], RTRIM(PreviousDue) as [Previous Due], RTRIM(Fine) as [Fine], RTRIM(GrandTotal) as [Grand Total], RTRIM(TotalPaid) as [Total Paid], RTRIM(ModeOfPayment) as [Payment Mode], RTRIM(PaymentModeDetails) as [Payement Mode Info], Convert(Datetime,PaymentDate,131) as [Payement Date], RTRIM(PaymentDue) as [Payement Due],RTRIM(HostelFeePayment.ClassType) as [Class Type], RTRIM(HostelFeePayment.SchoolType) as [School Type] from Student,SchoolInfo,HostelFeePayment,Hosteler,Hostelinfo where SchoolInfo.S_ID=Student.SchoolID and Hosteler.H_ID=HostelFeePayment.HostelerID and HostelInfo.HI_ID=Hosteler.HostelID and Student.AdmissionNo=Hosteler.AdmissionNo and HostelFeePayment.Session=@d1 and HostelFeePayment.Class=@d2 order by StudentName", con)
            cmd.Parameters.AddWithValue("@d1", cmbSession.Text)
            cmd.Parameters.AddWithValue("@d2", cmbClass.Text)
            adp = New SqlDataAdapter(cmd)
            ds = New DataSet()
            adp.Fill(ds, "Student")
            dgw.DataSource = ds.Tables("Student").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("Select RTRIM(HostelFeePayment.Id) as [ID], RTRIM(HFP_ID) as [HFP ID], RTRIM(PaymentID) as [Payment ID],RTRIM(HostelerID) as [Hosteler ID], RTRIM(Student.AdmissionNo) as [Admission No.],RTRIM(StudentName) as [StudentName],RTRIM(EnrollmentNo) as [Enrollment No.],RTRIM(SchoolName) as [School Name],RTRIM(Hostelname) as [Hostel name],RTRIM(HostelFeePayment.Class) as [Class],RTRIM(HostelFeePayment.Section) as [Section], RTRIM(HostelFeePayment.Session) as [Session],RTRIM(installment) as [installment],  RTRIM(TotalFee) as [Total Fee], RTRIM(DiscountPer) as [Discount %], RTRIM(DiscountAmt) as [Discount], RTRIM(PreviousDue) as [Previous Due], RTRIM(Fine) as [Fine], RTRIM(GrandTotal) as [Grand Total], RTRIM(TotalPaid) as [Total Paid], RTRIM(ModeOfPayment) as [Payment Mode], RTRIM(PaymentModeDetails) as [Payement Mode Info], Convert(Datetime,PaymentDate,131) as [Payement Date], RTRIM(PaymentDue) as [Payement Due],RTRIM(HostelFeePayment.ClassType) as [Class Type], RTRIM(HostelFeePayment.SchoolType) as [School Type] from Student,SchoolInfo,HostelFeePayment,Hosteler,Hostelinfo where SchoolInfo.S_ID=Student.SchoolID and Hosteler.H_ID=HostelFeePayment.HostelerID and HostelInfo.HI_ID=Hosteler.HostelID and Student.AdmissionNo=Hosteler.AdmissionNo and PaymentDate between @d1 and @d2 order by StudentName", con)
            cmd.Parameters.Add("@d1", SqlDbType.DateTime, 30, "Date").Value = dtpDateFrom.Value.Date
            cmd.Parameters.Add("@d2", SqlDbType.DateTime, 30, "Date").Value = dtpDateTo.Value
            adp = New SqlDataAdapter(cmd)
            ds = New DataSet()
            adp.Fill(ds, "Student")
            dgw.DataSource = ds.Tables("Student").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub fillSession()
        Try
            con = New SqlConnection(cs)
            con.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct (Session) FROM HostelFeePayment", con)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbSession.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbSession.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbSession_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbSession.SelectedIndexChanged
        Try
            cmbClass.Enabled = True
            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "SELECT distinct RTRIM(Class) FROM HostelFeePayment where HostelFeePayment.Session=@d1"
            cmd = New SqlCommand(ct)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", cmbSession.Text)
            rdr = cmd.ExecuteReader()
            cmbClass.Items.Clear()
            While rdr.Read
                cmbClass.Items.Add(rdr(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub txtAdmissionNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtAdmissionNo.TextChanged
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("Select RTRIM(HostelFeePayment.Id) as [ID], RTRIM(HFP_ID) as [HFP ID], RTRIM(PaymentID) as [Payment ID],RTRIM(HostelerID) as [Hosteler ID], RTRIM(Student.AdmissionNo) as [Admission No.],RTRIM(StudentName) as [StudentName],RTRIM(EnrollmentNo) as [Enrollment No.],RTRIM(SchoolName) as [School Name],RTRIM(Hostelname) as [Hostel name],RTRIM(HostelFeePayment.Class) as [Class],RTRIM(HostelFeePayment.Section) as [Section], RTRIM(HostelFeePayment.Session) as [Session],RTRIM(installment) as [installment],  RTRIM(TotalFee) as [Total Fee], RTRIM(DiscountPer) as [Discount %], RTRIM(DiscountAmt) as [Discount], RTRIM(PreviousDue) as [Previous Due], RTRIM(Fine) as [Fine], RTRIM(GrandTotal) as [Grand Total], RTRIM(TotalPaid) as [Total Paid], RTRIM(ModeOfPayment) as [Payment Mode], RTRIM(PaymentModeDetails) as [Payement Mode Info], Convert(Datetime,PaymentDate,131) as [Payement Date], RTRIM(PaymentDue) as [Payement Due],RTRIM(HostelFeePayment.ClassType) as [Class Type], RTRIM(HostelFeePayment.SchoolType) as [School Type] from Student,SchoolInfo,HostelFeePayment,Hosteler,Hostelinfo where SchoolInfo.S_ID=Student.SchoolID and Hosteler.H_ID=HostelFeePayment.HostelerID and HostelInfo.HI_ID=Hosteler.HostelID and Student.AdmissionNo=Hosteler.AdmissionNo and Student.AdmissionNo like '" & txtAdmissionNo.Text & "%' order by StudentName", con)
            adp = New SqlDataAdapter(cmd)
            ds = New DataSet()
            adp.Fill(ds, "Student")
            dgw.DataSource = ds.Tables("Student").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub Reset()
        txtAdmissionNo.Text = ""
        txtStudentName.Text = ""
        cmbClass.SelectedIndex = -1
        cmbSession.SelectedIndex = -1
        cmbClass.Enabled = False
        dtpDateFrom.Text = Today
        dtpDateTo.Text = Now
        GetData()
    End Sub
    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        Reset()
    End Sub

    Private Sub frmStudentRecord_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        fillSession()
        GetData()
    End Sub

    Private Sub dgw_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles dgw.MouseClick
        Try
            Dim dr As DataGridViewRow = dgw.SelectedRows(0)
            If lblSet.Text = "Hostel Fee Payment" Then
                Me.Hide()
                frmHostelFeePayment.Show()
                frmHostelFeePayment.txtID.Text = dr.Cells(0).Value.ToString()
                frmHostelFeePayment.txtHFPId.Text = dr.Cells(1).Value.ToString()
                frmHostelFeePayment.txtFeePaymentID.Text = dr.Cells(2).Value.ToString()
                frmHostelFeePayment.txtHostelerID.Text = dr.Cells(3).Value.ToString()
                frmHostelFeePayment.txtAdmissionNo.Text = dr.Cells(4).Value.ToString()
                frmHostelFeePayment.txtStudentName.Text = dr.Cells(5).Value.ToString()
                frmHostelFeePayment.txtEnrollmentNo.Text = dr.Cells(6).Value.ToString()
                frmHostelFeePayment.txtHostelName.Text = dr.Cells(7).Value.ToString() '
                frmHostelFeePayment.txtSchoolName.Text = dr.Cells(8).Value.ToString()
                frmHostelFeePayment.txtClass.Text = dr.Cells(9).Value.ToString()
                frmHostelFeePayment.txtSection.Text = dr.Cells(10).Value.ToString()
                frmHostelFeePayment.txtSession.Text = dr.Cells(11).Value.ToString()
                frmHostelFeePayment.cmbInstallment.Text = dr.Cells(12).Value.ToString()
                frmHostelFeePayment.txthostelFee.Text = dr.Cells(13).Value.ToString()
                frmHostelFeePayment.txtDiscountPer.Text = dr.Cells(14).Value.ToString()
                frmHostelFeePayment.txtDiscount.Text = dr.Cells(15).Value.ToString()
                frmHostelFeePayment.txtPreviousDue.Text = dr.Cells(16).Value.ToString()
                frmHostelFeePayment.txtFine.Text = dr.Cells(17).Value.ToString()
                frmHostelFeePayment.txtGrandTotal.Text = dr.Cells(18).Value.ToString()
                frmHostelFeePayment.txtTotalPaid.Text = dr.Cells(19).Value.ToString()
                frmHostelFeePayment.cmbPaymentMode.Text = dr.Cells(20).Value.ToString()
                frmHostelFeePayment.txtPaymentModeDetails.Text = dr.Cells(21).Value.ToString()
                frmHostelFeePayment.dtpPaymentDate.Text = dr.Cells(22).Value.ToString()
                frmHostelFeePayment.txtBalance.Text = dr.Cells(23).Value.ToString()
                frmHostelFeePayment.txtClassType.Text = dr.Cells(24).Value.ToString()
                frmHostelFeePayment.txtSchoolType.Text = dr.Cells(25).Value.ToString()
                frmHostelFeePayment.btnDelete.Enabled = True
                frmHostelFeePayment.btnPrint.Enabled = True
                frmHostelFeePayment.btnUpdate.Enabled = True
                frmHostelFeePayment.btnSave.Enabled = False
                frmHostelFeePayment.Button2.Enabled = False
                frmHostelFeePayment.dtpPaymentDate.Enabled = False
                frmHostelFeePayment.cmbInstallment.Enabled = False
                con = New SqlConnection(cs)
                con.Open()
                cmd = con.CreateCommand()
                cmd.CommandText = "SELECT Installment FROM hostelfeepayment where ID=@d1"
                cmd.Parameters.AddWithValue("@d1", dr.Cells(0).Value)
                rdr = cmd.ExecuteReader()
                If rdr.Read() Then
                    frmHostelFeePayment.cmbInstallment.Text = rdr.GetValue(0)
                End If
                If (rdr IsNot Nothing) Then
                    rdr.Close()
                End If
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                lblSet.Text = ""
            End If

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

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim rowsTotal, colsTotal As Short
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application
        Try
            Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            xlApp.Visible = True

            rowsTotal = dgw.RowCount
            colsTotal = dgw.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = dgw.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = dgw.Rows(I).Cells(j).Value
                    Next j
                Next I
                .Rows("1:1").Font.FontStyle = "Bold"
                .Rows("1:1").Font.Size = 12

                .Cells.Columns.AutoFit()
                .Cells.Select()
                .Cells.EntireColumn.AutoFit()
                .Cells(1, 1).Select()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'RELEASE ALLOACTED RESOURCES
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            xlApp = Nothing
        End Try
    End Sub
End Class

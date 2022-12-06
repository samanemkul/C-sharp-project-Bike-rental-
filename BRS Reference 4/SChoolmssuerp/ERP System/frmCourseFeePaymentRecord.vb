Imports System.Data.SqlClient
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmCourseFeePaymentRecord
    Public Sub GetData()
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("Select  RTRIM(CourseFeePayment.Id) as [ID], RTRIM(CFP_ID) as [CFP ID], RTRIM(PaymentID) as [Payment ID], RTRIM(Student.AdmissionNo) as [Admission No.],RTRIM(StudentName) as [StudentName],RTRIM(EnrollmentNo) as [Enrollment No.],RTRIM(SchoolName) as [School Name],RTRIM(CourseFeePayment.Class) as [Class],RTRIM(CourseFeePayment.Section) as [Section], RTRIM(CourseFeePayment.Session) as [Session], RTRIM(Semester) as [Semester], RTRIM(TotalFee) as [Total Fee], RTRIM(DiscountPer) as [Discount %], RTRIM(DiscountAmt) as [Discount], RTRIM(PreviousDue) as [Previous Due], RTRIM(Fine) as [Fine], RTRIM(GrandTotal) as [Grand Total], RTRIM(TotalPaid) as [Total Paid], RTRIM(ModeOfPayment) as [Payment Mode], RTRIM(PaymentModeDetails) as [Payement Mode Info], Convert(Datetime,PaymentDate,131) as [Payement Date], RTRIM(PaymentDue) as [Payement Due],RTRIM(CourseFeePayment.ClassType) as [Class Type], RTRIM(CourseFeePayment.SchoolType) as [School Type] from Student,Class,Section,SchoolInfo,CourseFeePayment where Student.SectionID=Section.ID and Class.ClassName=Section.Class and SchoolInfo.S_ID=Student.SchoolID and Student.AdmissionNo=CourseFeePayment.AdmissionNo order by StudentName", con)
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
            cmd = New SqlCommand("Select  RTRIM(CourseFeePayment.Id) as [ID], RTRIM(CFP_ID) as [CFP ID], RTRIM(PaymentID) as [Payment ID], RTRIM(Student.AdmissionNo) as [Admission No.],RTRIM(StudentName) as [StudentName],RTRIM(EnrollmentNo) as [Enrollment No.],RTRIM(SchoolName) as [School Name],RTRIM(CourseFeePayment.Class) as [Class],RTRIM(CourseFeePayment.Section) as [Section], RTRIM(CourseFeePayment.Session) as [Session], RTRIM(Semester) as [Semester], RTRIM(TotalFee) as [Total Fee], RTRIM(DiscountPer) as [Discount %], RTRIM(DiscountAmt) as [Discount], RTRIM(PreviousDue) as [Previous Due], RTRIM(Fine) as [Fine], RTRIM(GrandTotal) as [Grand Total], RTRIM(TotalPaid) as [Total Paid], RTRIM(ModeOfPayment) as [Payment Mode], RTRIM(PaymentModeDetails) as [Payement Mode Info], Convert(Datetime,PaymentDate,131) as [Payement Date], RTRIM(PaymentDue) as [Payement Due],RTRIM(CourseFeePayment.ClassType) as [Class Type], RTRIM(CourseFeePayment.SchoolType) as [School Type] from Student,Class,Section,SchoolInfo,CourseFeePayment where Student.SectionID=Section.ID and Class.ClassName=Section.Class and SchoolInfo.S_ID=Student.SchoolID and Student.AdmissionNo=CourseFeePayment.AdmissionNo and StudentName like '" & txtStudentName.Text & "%' order by StudentName", con)
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
            cmd = New SqlCommand("Select  RTRIM(CourseFeePayment.Id) as [ID], RTRIM(CFP_ID) as [CFP ID], RTRIM(PaymentID) as [Payment ID], RTRIM(Student.AdmissionNo) as [Admission No.],RTRIM(StudentName) as [StudentName],RTRIM(EnrollmentNo) as [Enrollment No.],RTRIM(SchoolName) as [School Name],RTRIM(CourseFeePayment.Class) as [Class],RTRIM(CourseFeePayment.Section) as [Section], RTRIM(CourseFeePayment.Session) as [Session], RTRIM(Semester) as [Semester], RTRIM(TotalFee) as [Total Fee], RTRIM(DiscountPer) as [Discount %], RTRIM(DiscountAmt) as [Discount], RTRIM(PreviousDue) as [Previous Due], RTRIM(Fine) as [Fine], RTRIM(GrandTotal) as [Grand Total], RTRIM(TotalPaid) as [Total Paid], RTRIM(ModeOfPayment) as [Payment Mode], RTRIM(PaymentModeDetails) as [Payement Mode Info], Convert(Datetime,PaymentDate,131) as [Payement Date], RTRIM(PaymentDue) as [Payement Due],RTRIM(CourseFeePayment.ClassType) as [Class Type], RTRIM(CourseFeePayment.SchoolType) as [School Type] from Student,Class,Section,SchoolInfo,CourseFeePayment where Student.SectionID=Section.ID and Class.ClassName=Section.Class and SchoolInfo.S_ID=Student.SchoolID and Student.AdmissionNo=CourseFeePayment.AdmissionNo and CourseFeePayment.Session=@d1 and CourseFeePayment.Class=@d2 order by StudentName", con)
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
            cmd = New SqlCommand("Select  RTRIM(CourseFeePayment.Id) as [ID], RTRIM(CFP_ID) as [CFP ID], RTRIM(PaymentID) as [Payment ID], RTRIM(Student.AdmissionNo) as [Admission No.],RTRIM(StudentName) as [StudentName],RTRIM(EnrollmentNo) as [Enrollment No.],RTRIM(SchoolName) as [School Name],RTRIM(CourseFeePayment.Class) as [Class],RTRIM(CourseFeePayment.Section) as [Section], RTRIM(CourseFeePayment.Session) as [Session], RTRIM(Semester) as [Semester], RTRIM(TotalFee) as [Total Fee], RTRIM(DiscountPer) as [Discount %], RTRIM(DiscountAmt) as [Discount], RTRIM(PreviousDue) as [Previous Due], RTRIM(Fine) as [Fine], RTRIM(GrandTotal) as [Grand Total], RTRIM(TotalPaid) as [Total Paid], RTRIM(ModeOfPayment) as [Payment Mode], RTRIM(PaymentModeDetails) as [Payement Mode Info], Convert(Datetime,PaymentDate,131) as [Payement Date], RTRIM(PaymentDue) as [Payement Due],RTRIM(CourseFeePayment.ClassType) as [Class Type], RTRIM(CourseFeePayment.SchoolType) as [School Type] from Student,Class,Section,SchoolInfo,CourseFeePayment where Student.SectionID=Section.ID and Class.ClassName=Section.Class and SchoolInfo.S_ID=Student.SchoolID and Student.AdmissionNo=CourseFeePayment.AdmissionNo and PaymentDate between @d1 and @d2 order by StudentName", con)
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
            adp.SelectCommand = New SqlCommand("SELECT distinct (Session) FROM CourseFeepayment", con)
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
            Dim ct As String = "SELECT distinct RTRIM(Class) FROM CourseFeePayment where CourseFeePayment.Session=@d1"
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
            cmd = New SqlCommand("Select  RTRIM(CourseFeePayment.Id) as [ID], RTRIM(CFP_ID) as [CFP ID], RTRIM(PaymentID) as [Payment ID], RTRIM(Student.AdmissionNo) as [Admission No.],RTRIM(StudentName) as [StudentName],RTRIM(EnrollmentNo) as [Enrollment No.],RTRIM(SchoolName) as [School Name],RTRIM(CourseFeePayment.Class) as [Class],RTRIM(CourseFeePayment.Section) as [Section], RTRIM(CourseFeePayment.Session) as [Session], RTRIM(Semester) as [Semester], RTRIM(TotalFee) as [Total Fee], RTRIM(DiscountPer) as [Discount %], RTRIM(DiscountAmt) as [Discount], RTRIM(PreviousDue) as [Previous Due], RTRIM(Fine) as [Fine], RTRIM(GrandTotal) as [Grand Total], RTRIM(TotalPaid) as [Total Paid], RTRIM(ModeOfPayment) as [Payment Mode], RTRIM(PaymentModeDetails) as [Payement Mode Info], Convert(Datetime,PaymentDate,131) as [Payement Date], RTRIM(PaymentDue) as [Payement Due],RTRIM(CourseFeePayment.ClassType) as [Class Type], RTRIM(CourseFeePayment.SchoolType) as [School Type] from Student,Class,Section,SchoolInfo,CourseFeePayment where Student.SectionID=Section.ID and Class.ClassName=Section.Class and SchoolInfo.S_ID=Student.SchoolID and Student.AdmissionNo=CourseFeePayment.AdmissionNo and Student.AdmissionNo like '" & txtAdmissionNo.Text & "%' order by StudentName", con)
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
            If lblSet.Text = "Course Fee Payment" Then
                Me.Hide()
                frmCourseFeePayment.Show()
                frmCourseFeePayment.txtID.Text = dr.Cells(0).Value.ToString()
                frmCourseFeePayment.txtCFPId.Text = dr.Cells(1).Value.ToString()
                frmCourseFeePayment.txtFeePaymentID.Text = dr.Cells(2).Value.ToString()
                frmCourseFeePayment.txtAdmissionNo.Text = dr.Cells(3).Value.ToString()
                frmCourseFeePayment.txtStudentName.Text = dr.Cells(4).Value.ToString()
                frmCourseFeePayment.txtEnrollmentNo.Text = dr.Cells(5).Value.ToString() '
                frmCourseFeePayment.txtSchoolName.Text = dr.Cells(6).Value.ToString()
                frmCourseFeePayment.txtClass.Text = dr.Cells(7).Value.ToString()
                frmCourseFeePayment.txtSection.Text = dr.Cells(8).Value.ToString()
                frmCourseFeePayment.txtSession.Text = dr.Cells(9).Value.ToString()
                frmCourseFeePayment.cmbSemester.Text = dr.Cells(10).Value.ToString()
                frmCourseFeePayment.txtCourseFee.Text = dr.Cells(11).Value.ToString()
                frmCourseFeePayment.txtDiscountPer.Text = dr.Cells(12).Value.ToString()
                frmCourseFeePayment.txtDiscount.Text = dr.Cells(13).Value.ToString()
                frmCourseFeePayment.txtPreviousDue.Text = dr.Cells(14).Value.ToString()
                frmCourseFeePayment.txtFine.Text = dr.Cells(15).Value.ToString()
                frmCourseFeePayment.txtGrandTotal.Text = dr.Cells(16).Value.ToString()
                frmCourseFeePayment.txtTotalPaid.Text = dr.Cells(17).Value.ToString()
                frmCourseFeePayment.cmbPaymentMode.Text = dr.Cells(18).Value.ToString()
                frmCourseFeePayment.txtPaymentModeDetails.Text = dr.Cells(19).Value.ToString()
                frmCourseFeePayment.dtpPaymentDate.Text = dr.Cells(20).Value.ToString()
                frmCourseFeePayment.txtBalance.Text = dr.Cells(21).Value.ToString()
                frmCourseFeePayment.txtClassType.Text = dr.Cells(22).Value.ToString()
                frmCourseFeePayment.txtSchoolType.Text = dr.Cells(23).Value.ToString()
                con = New SqlConnection(cs)
                con.Open()
                cmd = New SqlCommand("SELECT FeeName,CourseFeePayment_Join.Fee from CourseFeePayment,CourseFeePayment_Join where CourseFeePayment.ID=CourseFeePayment_Join.C_PaymentID and CourseFeePayment.ID=" & dr.Cells(0).Value & "", con)
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                frmCourseFeePayment.dgw.Rows.Clear()
                While (rdr.Read() = True)
                    frmCourseFeePayment.dgw.Rows.Add(rdr(0), rdr(1))
                End While
                con.Close()
                frmCourseFeePayment.btnDelete.Enabled = True
                frmCourseFeePayment.btnUpdate.Enabled = True
                frmCourseFeePayment.btnSave.Enabled = False
                frmCourseFeePayment.Button2.Enabled = False
                frmCourseFeePayment.dtpPaymentDate.Enabled = False
                frmCourseFeePayment.btnPrint.Enabled = True
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

Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmBusCardHolder_StudentRecord
    Sub fillSession()
        Try
            con = New SqlConnection(cs)
            con.Open()
            adp = New sqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct (session) FROM Student,BusCardHolder_Student where Student.AdmissionNo=BusCardHolder_Student.AdmissionNo", con)
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
    Private Sub dgw_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgw.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString()
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If dgw.RowHeadersWidth < Convert.ToInt32((size.Width + 20)) Then
            dgw.RowHeadersWidth = Convert.ToInt32((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))

    End Sub

    Private Sub dgw_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgw.MouseClick
        Try
            Dim dr As DataGridViewRow = dgw.SelectedRows(0)
            If lblSet.Text = "Bus Holder Entry" Then
                Me.Hide()
                frmBusCardHolder_Student.Show()
                frmBusCardHolder_Student.txtID.Text = dr.Cells(0).Value.ToString()
                frmBusCardHolder_Student.txtAdmissionNo.Text = dr.Cells(1).Value.ToString()
                frmBusCardHolder_Student.txtStudentName.Text = dr.Cells(2).Value.ToString()
                frmBusCardHolder_Student.txtClass.Text = dr.Cells(3).Value.ToString()
                frmBusCardHolder_Student.txtSection.Text = dr.Cells(4).Value.ToString()
                frmBusCardHolder_Student.txtSchoolName.Text = dr.Cells(5).Value.ToString()
                frmBusCardHolder_Student.cmbBusNo.Text = dr.Cells(6).Value.ToString()
                frmBusCardHolder_Student.cmbLocationName.Text = dr.Cells(7).Value.ToString()
                frmBusCardHolder_Student.dtpJoiningDate.Text = dr.Cells(8).Value.ToString()
                frmBusCardHolder_Student.cmbStatus.Text = dr.Cells(9).Value.ToString()
                frmBusCardHolder_Student.btnDelete.Enabled = True
                frmBusCardHolder_Student.btnUpdate.Enabled = True
                frmBusCardHolder_Student.btnSave.Enabled = False
            End If
            If lblSet.Text = "Bus Fee Payment" Then
                Me.Hide()
                frmBusFeePayment_Student.Show()
                frmBusFeePayment_Student.txtBusHolderID.Text = dr.Cells(0).Value.ToString()
                frmBusFeePayment_Student.txtAdmissionNo.Text = dr.Cells(1).Value.ToString()
                frmBusFeePayment_Student.txtStudentName.Text = dr.Cells(2).Value.ToString()
                frmBusFeePayment_Student.txtClass.Text = dr.Cells(3).Value.ToString()
                frmBusFeePayment_Student.txtSection.Text = dr.Cells(4).Value.ToString()
                frmBusFeePayment_Student.txtSchoolName.Text = dr.Cells(5).Value.ToString()
                frmBusFeePayment_Student.txtLocation.Text = dr.Cells(7).Value.ToString()
                frmBusFeePayment_Student.FillData()
                frmBusFeePayment_Student.fillInstallment()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub GetData()
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("SELECT RTRIM(BusCardHolder_Student.BCH_ID) as [ID],RTRIM(Student.AdmissionNo) as [Admission No.], RTRIM(StudentName) as [StudentName], RTRIM(ClassName) as [Class], RTRIM(SectionName) as Section,RTRIM(SchoolName) as [School Name],RTRIM(BusInfo.BusNo) as [Bus No.],RTRIM(LocationName) as [Location Name], CONVERT(DateTime,JoiningDate,105) as [Joining Date],RTRIM(BusCardHolder_Student.Status) as [Status] from Student,BusCardHolder_Student,Location,Section,Class,SchoolInfo,BusInfo where Student.SectionID=Section.ID  and Location.LocationName=BusCardHolder_Student.Location and Student.AdmissionNo=BusCardHolder_Student.AdmissionNo and Class.ClassName=Section.Class and Student.SchoolID=SchoolInfo.S_ID and BusInfo.BusNo=BusCardHolder_Student.BusNo order by StudentName", con)
            adp = New SqlDataAdapter(cmd)
            ds = New DataSet()
            adp.Fill(ds, "Student")
            dgw.DataSource = ds.Tables("Student").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtStudentName_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtStudentName.TextChanged
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("SELECT RTRIM(BusCardHolder_Student.BCH_ID) as [ID],RTRIM(Student.AdmissionNo) as [Admission No.], RTRIM(StudentName) as [StudentName], RTRIM(ClassName) as [Class], RTRIM(SectionName) as Section,RTRIM(SchoolName) as [School Name],RTRIM(BusInfo.BusNo) as [Bus No.],RTRIM(LocationName) as [Location Name], CONVERT(DateTime,JoiningDate,105) as [Joining Date],RTRIM(BusCardHolder_Student.Status) as [Status] from Student,BusCardHolder_Student,Location,Section,Class,SchoolInfo,BusInfo where Student.SectionID=Section.ID  and Location.LocationName=BusCardHolder_Student.Location and Student.AdmissionNo=BusCardHolder_Student.AdmissionNo and Class.ClassName=Section.Class and Student.SchoolID=SchoolInfo.S_ID and BusInfo.BusNo=BusCardHolder_Student.BusNo and StudentName like '" & txtStudentName.Text & "%' order by StudentName", con)
            adp = New SqlDataAdapter(cmd)
            ds = New DataSet()
            adp.Fill(ds, "Student")
            dgw.DataSource = ds.Tables("Student").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtLocation_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtLocation.TextChanged
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("SELECT RTRIM(BusCardHolder_Student.BCH_ID) as [ID],RTRIM(Student.AdmissionNo) as [Admission No.], RTRIM(StudentName) as [StudentName], RTRIM(ClassName) as [Class], RTRIM(SectionName) as Section,RTRIM(SchoolName) as [School Name],RTRIM(BusInfo.BusNo) as [Bus No.],RTRIM(LocationName) as [Location Name], CONVERT(DateTime,JoiningDate,105) as [Joining Date],RTRIM(BusCardHolder_Student.Status) as [Status] from Student,BusCardHolder_Student,Location,Section,Class,SchoolInfo,BusInfo where Student.SectionID=Section.ID  and Location.LocationName=BusCardHolder_Student.Location and Student.AdmissionNo=BusCardHolder_Student.AdmissionNo and Class.ClassName=Section.Class and Student.SchoolID=SchoolInfo.S_ID and BusInfo.BusNo=BusCardHolder_Student.BusNo and LocationName like '" & txtLocation.Text & "%' order by StudentName", con)
            adp = New SqlDataAdapter(cmd)
            ds = New DataSet()
            adp.Fill(ds, "Student")
            dgw.DataSource = ds.Tables("Student").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbSession_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbSession.SelectedIndexChanged
        Try
            cmbClass.Enabled = True
            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "SELECT distinct RTRIM(ClassName) FROM Student,Section,Class where Student.SectionID=Section.ID and Section.Class=Class.Classname and session=@d1"
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

    Private Sub cmbClass_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbClass.SelectedIndexChanged
        Try
            cmbSection.Enabled = True
            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "SELECT distinct RTRIM(SectionName) FROM Student,Section,Class where Student.SectionID=Section.ID and Section.Class=Class.ClassName and session=@d1 and ClassName=@d2"
            cmd = New SqlCommand(ct)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", cmbSession.Text)
            cmd.Parameters.AddWithValue("@d2", cmbClass.Text)
            rdr = cmd.ExecuteReader()
            cmbSection.Items.Clear()
            While rdr.Read
                cmbSection.Items.Add(rdr(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            If Len(Trim(cmbSession.Text)) = 0 Then
                MessageBox.Show("Please select session", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbSession.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbClass.Text)) = 0 Then
                MessageBox.Show("Please select class", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbClass.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbSection.Text)) = 0 Then
                MessageBox.Show("Please select section", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbSection.Focus()
                Exit Sub
            End If
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("SELECT RTRIM(BusCardHolder_Student.BCH_ID) as [ID],RTRIM(Student.AdmissionNo) as [Admission No.], RTRIM(StudentName) as [StudentName], RTRIM(ClassName) as [Class], RTRIM(SectionName) as Section,RTRIM(SchoolName) as [School Name],RTRIM(BusInfo.BusNo) as [Bus No.],RTRIM(LocationName) as [Location Name], CONVERT(DateTime,JoiningDate,105) as [Joining Date],RTRIM(BusCardHolder_Student.Status) as [Status] from Student,BusCardHolder_Student,Location,Section,Class,SchoolInfo,BusInfo where Student.SectionID=Section.ID  and Location.LocationName=BusCardHolder_Student.Location and Student.AdmissionNo=BusCardHolder_Student.AdmissionNo and Class.ClassName=Section.Class and Student.SchoolID=SchoolInfo.S_ID and BusInfo.BusNo=BusCardHolder_Student.BusNo and Session=@d1 and Classname=@d2 and SectionName=@d3 order by StudentName", con)
            cmd.Parameters.AddWithValue("@d1", cmbSession.Text)
            cmd.Parameters.AddWithValue("@d2", cmbClass.Text)
            cmd.Parameters.AddWithValue("@d3", cmbSection.Text)
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
            cmd = New SqlCommand("SELECT RTRIM(BusCardHolder_Student.BCH_ID) as [ID],RTRIM(Student.AdmissionNo) as [Admission No.], RTRIM(StudentName) as [StudentName], RTRIM(ClassName) as [Class], RTRIM(SectionName) as Section,RTRIM(SchoolName) as [School Name],RTRIM(BusInfo.BusNo) as [Bus No.],RTRIM(LocationName) as [Location Name], CONVERT(DateTime,JoiningDate,105) as [Joining Date],RTRIM(BusCardHolder_Student.Status) as [Status] from Student,BusCardHolder_Student,Location,Section,Class,SchoolInfo,BusInfo where Student.SectionID=Section.ID  and Location.LocationName=BusCardHolder_Student.Location and Student.AdmissionNo=BusCardHolder_Student.AdmissionNo and Class.ClassName=Section.Class and Student.SchoolID=SchoolInfo.S_ID and BusInfo.BusNo=BusCardHolder_Student.BusNo and JoiningDate between @d1 and @d2 order by StudentName", con)
            cmd.Parameters.Add("@d1", SqlDbType.DateTime, 30, "JoiningDate").Value = dtpDateFrom.Value.Date
            cmd.Parameters.Add("@d2", SqlDbType.DateTime, 30, "JoiningDate").Value = dtpDateTo.Value.Date
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
        txtLocation.Text = ""
        txtStudentName.Text = ""
        cmbClass.SelectedIndex = -1
        cmbSection.SelectedIndex = -1
        cmbSession.SelectedIndex = -1
        cmbClass.Enabled = False
        cmbSection.Enabled = False
        GetData()
    End Sub

    Private Sub frmBusCardHolder_StudentRecord_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        GetData()
        fillSession()
    End Sub

    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        Reset()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub btnExportExcel_Click(sender As System.Object, e As System.EventArgs) Handles btnExportExcel.Click
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

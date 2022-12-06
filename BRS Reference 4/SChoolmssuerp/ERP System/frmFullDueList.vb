Imports System.Data.SqlClient
Imports System.Data
Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmFullDueList
    Sub fillSession()
        Try
            con = New SqlConnection(cs)
            con.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct (Session) FROM Session_Master", con)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbSession.Items.Clear()
            cmbSession1.Items.Clear()
            cmbSession2.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbSession.Items.Add(drow(0).ToString())
                cmbSession1.Items.Add(drow(0).ToString())
                cmbSession2.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub fillClass()
        Try
            con = New SqlConnection(cs)
            con.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct (ClassName) FROM Class", con)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbClass.Items.Clear()
            cmbClass1.Items.Clear()
            cmbClass2.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbClass.Items.Add(drow(0).ToString())
                cmbClass1.Items.Add(drow(0).ToString())
                cmbClass2.Items.Add(drow(0).ToString())
            Next
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
            If Len(Trim(cmbSemester.Text)) = 0 Then
                MessageBox.Show("Please select semester", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbSemester.Focus()
                Exit Sub
            End If
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("SELECT RTRIM(Student.AdmissionNo),RTRIM(GRNo),RTRIM(StudentName),RTRIM(SchoolName),Sum(Fee) from Student,SchoolInfo,CourseFee,Class where Student.SchoolID=SchoolInfo.S_ID and Class.Classname=CourseFee.Class and CourseFee.SchoolID=SchoolInfo.S_ID and Student.Session=@d1 and CourseFee.Class=@d2 and CourseFee.Semester=@d3 group by Student.AdmissionNo,GRNo,StudentName,SchoolName Except SELECT RTRIM(Student.AdmissionNo),RTRIM(GRNo),RTRIM(StudentName),RTRIM(SchoolName),Sum(Fee) from Student,SchoolInfo,CourseFee,CourseFeePayment,Class where CourseFee.SchoolID=SchoolInfo.S_ID and Class.Classname=CourseFee.Class and Student.SchoolID=SchoolInfo.S_ID and CourseFeePayment.Class=CourseFee.Class and Student.AdmissionNo=CourseFeePayment.AdmissionNo and CourseFee.Semester=CourseFeePayment.Semester and CourseFeePayment.Session=@d1 and CourseFee.Class=@d2 and CourseFee.Semester=@d3 group by Student.AdmissionNo,GRNo,StudentName,SchoolName order by 3", con)
            cmd.Parameters.AddWithValue("@d1", cmbSession.Text)
            cmd.Parameters.AddWithValue("@d2", cmbClass.Text)
            cmd.Parameters.AddWithValue("@d3", cmbSemester.Text)
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

    Private Sub cmbClass_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbClass.SelectedIndexChanged
        cmbSemester.Enabled = True
    End Sub

    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        cmbSession.SelectedIndex = -1
        cmbClass.SelectedIndex = -1
        cmbSemester.SelectedIndex = -1
        cmbSemester.Enabled = False
        cmbClass.Enabled = False
        dgw.Rows.Clear()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
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
    Sub Reset()
        cmbSession.SelectedIndex = -1
        cmbClass.SelectedIndex = -1
        cmbSemester.SelectedIndex = -1
        cmbSemester.Enabled = False
        cmbClass.Enabled = False
        dgw.Rows.Clear()
        cmbSession1.SelectedIndex = -1
        cmbClass1.SelectedIndex = -1
        cmbInstallment.SelectedIndex = -1
        cmbClass1.Enabled = False
        cmbInstallment.Enabled = False
        dgw1.Rows.Clear()
        cmbSession2.SelectedIndex = -1
        cmbClass2.SelectedIndex = -1
        cmbInstallment1.SelectedIndex = -1
        cmbInstallment1.Enabled = False
        cmbClass2.Enabled = False
        dgw2.Rows.Clear()
        fillSession()
        fillClass()
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmPartialDueList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        fillSession()
        fillClass()
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        cmbSession1.SelectedIndex = -1
        cmbClass1.SelectedIndex = -1
        cmbInstallment.SelectedIndex = -1
        cmbClass1.Enabled = False
        cmbInstallment.Enabled = False
        dgw1.Rows.Clear()
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        cmbSession2.SelectedIndex = -1
        cmbClass2.SelectedIndex = -1
        cmbInstallment1.SelectedIndex = -1
        cmbInstallment1.Enabled = False
        cmbClass2.Enabled = False
        dgw2.Rows.Clear()
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Dim rowsTotal, colsTotal As Short
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application
        Try
            Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            xlApp.Visible = True

            rowsTotal = dgw2.RowCount
            colsTotal = dgw2.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = dgw2.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = dgw2.Rows(I).Cells(j).Value
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

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim rowsTotal, colsTotal As Short
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application
        Try
            Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            xlApp.Visible = True

            rowsTotal = dgw1.RowCount
            colsTotal = dgw1.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = dgw1.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = dgw1.Rows(I).Cells(j).Value
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

    Private Sub cmbSession1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbSession1.SelectedIndexChanged
          cmbClass1.Enabled = True
    End Sub

    Private Sub cmbSession2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbSession2.SelectedIndexChanged
        Try
            cmbClass2.Enabled = True
            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "SELECT distinct RTRIM(Class) FROM Class,Section,Student where Class.ClassName=Section.Class and Student.SectionID=Section.ID"
            cmd = New SqlCommand(ct)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", cmbSession2.Text)
            rdr = cmd.ExecuteReader()
            cmbClass2.Items.Clear()
            While rdr.Read
                cmbClass2.Items.Add(rdr(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TabControl1_Click(sender As System.Object, e As System.EventArgs) Handles TabControl1.Click
        Reset()
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Try
            If Len(Trim(cmbSession1.Text)) = 0 Then
                MessageBox.Show("Please select session", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbSession1.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbClass1.Text)) = 0 Then
                MessageBox.Show("Please select class", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbClass1.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbInstallment.Text)) = 0 Then
                MessageBox.Show("Please select installment", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbInstallment.Focus()
                Exit Sub
            End If
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("SELECT RTRIM(Student.AdmissionNo),RTRIM(GRNo),RTRIM(StudentName),RTRIM(HostelName),RTRIM(SchoolName),SUM(Charges) FROM Student,Hosteler,HostelInfo,Installment_Hostel,schoolInfo,Class where Student.AdmissionNo=Hosteler.AdmissionNo and HostelInfo.HI_ID=Hosteler.HostelID and Installment_Hostel.HostelID=HostelInfo.HI_ID and Student.SchoolID=SchoolInfo.S_ID and Installment_Hostel.SchoolID=SchoolInfo.S_ID and Installment_Hostel.Class=Class.Classname and Student.Session=@d1 and Installment_Hostel.Class=@d2 and Installment=@d3 group by student.admissionno,GRNO,StudentName,SchoolName,HostelName Except SELECT RTRIM(Student.AdmissionNo),RTRIM(GRNo),RTRIM(StudentName),RTRIM(SchoolName),RTRIM(HostelName),SUM(Charges) FROM Student,Hosteler,HostelInfo,Installment_Hostel,schoolInfo,Class,HostelFeePayment where Student.AdmissionNo=Hosteler.AdmissionNo and HostelInfo.HI_ID=Hosteler.HostelID and Installment_Hostel.HostelID=HostelInfo.HI_ID and Student.SchoolID=SchoolInfo.S_ID and Installment_Hostel.SchoolID=SchoolInfo.S_ID and Installment_Hostel.Class=Class.Classname and HostelFeePayment.HostelerID=Hosteler.H_ID and Installment_Hostel.Installment=HostelFeePayment.Installment and HostelFeePayment.Session=@d1 and Installment_Hostel.Class=@d2 and Installment_Hostel.Installment=@d3 group by student.admissionno,GRNO,StudentName,SchoolName,HostelName order by 3 ", con)
            cmd.Parameters.AddWithValue("@d1", cmbSession1.Text)
            cmd.Parameters.AddWithValue("@d2", cmbClass1.Text)
            cmd.Parameters.AddWithValue("@d3", cmbInstallment.Text)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw1.Rows.Clear()
            While (rdr.Read() = True)
                dgw1.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        Try
            If Len(Trim(cmbSession2.Text)) = 0 Then
                MessageBox.Show("Please select session", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbSession2.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbClass2.Text)) = 0 Then
                MessageBox.Show("Please select class", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbClass2.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbInstallment1.Text)) = 0 Then
                MessageBox.Show("Please select installment", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbInstallment1.Focus()
                Exit Sub
            End If
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("SELECT RTRIM(Student.AdmissionNo),RTRIM(GRNo),RTRIM(StudentName),RTRIM(Location.LocationName),RTRIM(SchoolName),SUM(Charges) FROM Student,BusCardHolder_Student,Installment_Bus,schoolInfo,Location,Class,Section where BusCardHolder_Student.Location=Location.LocationName and Student.AdmissionNo=BusCardHolder_Student.AdmissionNo and Installment_Bus.Location=Location.LocationName and Student.SchoolID=SchoolInfo.S_ID and Class.Classname=Section.Class and Section.ID=Student.SectionID and Student.Session=@d1 and Class.ClassName=@d2 and Installment_Bus.Installment=@d3 group by student.admissionno,GRNO,StudentName,SchoolName,LocationName Except SELECT RTRIM(Student.AdmissionNo),RTRIM(GRNo),RTRIM(StudentName),RTRIM(LocationName),RTRIM(SchoolName),SUM(Charges) FROM Student,BusCardHolder_Student,Installment_Bus,schoolInfo,Location,Class,Section,BusFeePayment_Student where BusCardHolder_Student.Location=Location.LocationName and Student.AdmissionNo=BusCardHolder_Student.AdmissionNo and Installment_Bus.Location=Location.LocationName and Student.SchoolID=SchoolInfo.S_ID and Class.Classname=Section.Class and Section.ID=Student.SectionID and BusFeePayment_Student.BusHolderID=BusCardHolder_Student.BCH_ID and BusFeePayment_Student.Installment=Installment_Bus.Installment and BusFeePayment_Student.Session=@d1 and BusFeePayment_Student.Class=@d2 and Installment_Bus.Installment=@d3 group by student.admissionno,GRNO,StudentName,SchoolName,LocationName order by 3", con)
            cmd.Parameters.AddWithValue("@d1", cmbSession2.Text)
            cmd.Parameters.AddWithValue("@d2", cmbClass2.Text)
            cmd.Parameters.AddWithValue("@d3", cmbInstallment1.Text)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw2.Rows.Clear()
            While (rdr.Read() = True)
                dgw2.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbClass1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbClass1.SelectedIndexChanged
        Try
            cmbInstallment.Enabled = True
            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "SELECT distinct Installment from Installment_Hostel where Class=@d1"
            cmd = New SqlCommand(ct)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", cmbClass1.Text)
            rdr = cmd.ExecuteReader()
            cmbInstallment.Items.Clear()
            While rdr.Read
                cmbInstallment.Items.Add(rdr(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbClass2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbClass2.SelectedIndexChanged
        Try
            cmbInstallment1.Enabled = True
            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "SELECT distinct RTRIM(Installment) from Installment_Bus"
            cmd = New SqlCommand(ct)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            cmbInstallment1.Items.Clear()
            While rdr.Read
                cmbInstallment1.Items.Add(rdr(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
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
            If Len(Trim(cmbSemester.Text)) = 0 Then
                MessageBox.Show("Please select semester", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbSemester.Focus()
                Exit Sub
            End If
            Cursor = Cursors.WaitCursor
            Timer1.Enabled = True
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("SELECT RTRIM(Student.AdmissionNo),RTRIM(GRNo),RTRIM(StudentName),RTRIM(SchoolName),Sum(Fee) from Student,SchoolInfo,CourseFee,Class where Student.SchoolID=SchoolInfo.S_ID and Class.Classname=CourseFee.Class and CourseFee.SchoolID=SchoolInfo.S_ID and Student.Session=@d1 and CourseFee.Class=@d2 and CourseFee.Semester=@d3 group by Student.AdmissionNo,GRNo,StudentName,SchoolName Except SELECT RTRIM(Student.AdmissionNo),RTRIM(GRNo),RTRIM(StudentName),RTRIM(SchoolName),Sum(Fee) from Student,SchoolInfo,CourseFee,CourseFeePayment,Class where CourseFee.SchoolID=SchoolInfo.S_ID and Class.Classname=CourseFee.Class and Student.SchoolID=SchoolInfo.S_ID and CourseFeePayment.Class=CourseFee.Class and Student.AdmissionNo=CourseFeePayment.AdmissionNo and CourseFee.Semester=CourseFeePayment.Semester and CourseFeePayment.Session=@d1 and CourseFee.Class=@d2 and CourseFee.Semester=@d3 group by Student.AdmissionNo,GRNo,StudentName,SchoolName order by 3", con)
            cmd.Parameters.AddWithValue("@d1", cmbSession.Text)
            cmd.Parameters.AddWithValue("@d2", cmbClass.Text)
            cmd.Parameters.AddWithValue("@d3", cmbSemester.Text)
            adp = New SqlDataAdapter(cmd)
            dtable = New DataTable()
            adp.Fill(dtable)
            con.Close()
            DataGridView1.DataSource = dtable
            ds = New DataSet()
            ds.Tables.Add(dtable)
            ds.WriteXmlSchema("ClassFeeFullDue.xml")
            Dim rpt As New rptClassFeeFullDue
            rpt.SetDataSource(ds)
            rpt.SetParameterValue("p1", cmbSession.Text)
            rpt.SetParameterValue("p2", cmbClass.Text)
            rpt.SetParameterValue("p3", cmbSemester.Text)
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

    Private Sub cmbSession_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbSession.SelectedIndexChanged
        cmbClass.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Try
            If Len(Trim(cmbSession1.Text)) = 0 Then
                MessageBox.Show("Please select session", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbSession1.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbClass1.Text)) = 0 Then
                MessageBox.Show("Please select class", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbClass1.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbInstallment.Text)) = 0 Then
                MessageBox.Show("Please select installment", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbInstallment.Focus()
                Exit Sub
            End If
            Cursor = Cursors.WaitCursor
            Timer1.Enabled = True
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("SELECT RTRIM(Student.AdmissionNo),RTRIM(GRNo),RTRIM(StudentName),RTRIM(HostelName),RTRIM(SchoolName),SUM(Charges) FROM Student,Hosteler,HostelInfo,Installment_Hostel,schoolInfo,Class where Student.AdmissionNo=Hosteler.AdmissionNo and HostelInfo.HI_ID=Hosteler.HostelID and Installment_Hostel.HostelID=HostelInfo.HI_ID and Student.SchoolID=SchoolInfo.S_ID and Installment_Hostel.SchoolID=SchoolInfo.S_ID and Installment_Hostel.Class=Class.Classname and Student.Session=@d1 and Installment_Hostel.Class=@d2 and Installment=@d3 group by student.admissionno,GRNO,StudentName,SchoolName,HostelName Except SELECT RTRIM(Student.AdmissionNo),RTRIM(GRNo),RTRIM(StudentName),RTRIM(SchoolName),RTRIM(HostelName),SUM(Charges) FROM Student,Hosteler,HostelInfo,Installment_Hostel,schoolInfo,Class,HostelFeePayment where Student.AdmissionNo=Hosteler.AdmissionNo and HostelInfo.HI_ID=Hosteler.HostelID and Installment_Hostel.HostelID=HostelInfo.HI_ID and Student.SchoolID=SchoolInfo.S_ID and Installment_Hostel.SchoolID=SchoolInfo.S_ID and Installment_Hostel.Class=Class.Classname and HostelFeePayment.HostelerID=Hosteler.H_ID and Installment_Hostel.Installment=HostelFeePayment.Installment and HostelFeePayment.Session=@d1 and Installment_Hostel.Class=@d2 and Installment_Hostel.Installment=@d3 group by student.admissionno,GRNO,StudentName,SchoolName,HostelName order by 3 ", con)
            cmd.Parameters.AddWithValue("@d1", cmbSession1.Text)
            cmd.Parameters.AddWithValue("@d2", cmbClass1.Text)
            cmd.Parameters.AddWithValue("@d3", cmbInstallment.Text)
            adp = New SqlDataAdapter(cmd)
            dtable = New DataTable()
            adp.Fill(dtable)
            con.Close()
            DataGridView2.DataSource = dtable
            ds = New DataSet()
            ds.Tables.Add(dtable)
            ds.WriteXmlSchema("HostelFeeFullDue.xml")
            Dim rpt As New rptHostelFeeFullDue
            rpt.SetDataSource(ds)
            rpt.SetParameterValue("p1", cmbSession1.Text)
            rpt.SetParameterValue("p2", cmbClass1.Text)
            rpt.SetParameterValue("p3", cmbInstallment.Text)
            frmReport.CrystalReportViewer1.ReportSource = rpt
            frmReport.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Try
            If Len(Trim(cmbSession2.Text)) = 0 Then
                MessageBox.Show("Please select session", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbSession2.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbClass2.Text)) = 0 Then
                MessageBox.Show("Please select class", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbClass2.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbInstallment1.Text)) = 0 Then
                MessageBox.Show("Please select installment", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbInstallment1.Focus()
                Exit Sub
            End If
            Cursor = Cursors.WaitCursor
            Timer1.Enabled = True
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("SELECT RTRIM(Student.AdmissionNo),RTRIM(GRNo),RTRIM(StudentName),RTRIM(Location.LocationName),RTRIM(SchoolName),SUM(Charges) FROM Student,BusCardHolder_Student,Installment_Bus,schoolInfo,Location,Class,Section where BusCardHolder_Student.Location=Location.LocationName and Student.AdmissionNo=BusCardHolder_Student.AdmissionNo and Installment_Bus.Location=Location.LocationName and Student.SchoolID=SchoolInfo.S_ID and Class.Classname=Section.Class and Section.ID=Student.SectionID and Student.Session=@d1 and Class.ClassName=@d2 and Installment_Bus.Installment=@d3 group by student.admissionno,GRNO,StudentName,SchoolName,LocationName Except SELECT RTRIM(Student.AdmissionNo),RTRIM(GRNo),RTRIM(StudentName),RTRIM(LocationName),RTRIM(SchoolName),SUM(Charges) FROM Student,BusCardHolder_Student,Installment_Bus,schoolInfo,Location,Class,Section,BusFeePayment_Student where BusCardHolder_Student.Location=Location.LocationName and Student.AdmissionNo=BusCardHolder_Student.AdmissionNo and Installment_Bus.Location=Location.LocationName and Student.SchoolID=SchoolInfo.S_ID and Class.Classname=Section.Class and Section.ID=Student.SectionID and BusFeePayment_Student.BusHolderID=BusCardHolder_Student.BCH_ID and BusFeePayment_Student.Installment=Installment_Bus.Installment and BusFeePayment_Student.Session=@d1 and BusFeePayment_Student.Class=@d2 and Installment_Bus.Installment=@d3 group by student.admissionno,GRNO,StudentName,SchoolName,LocationName order by 3", con)
            cmd.Parameters.AddWithValue("@d1", cmbSession2.Text)
            cmd.Parameters.AddWithValue("@d2", cmbClass2.Text)
            cmd.Parameters.AddWithValue("@d3", cmbInstallment1.Text)
            adp = New SqlDataAdapter(cmd)
            dtable = New DataTable()
            adp.Fill(dtable)
            con.Close()
            DataGridView3.DataSource = dtable
            ds = New DataSet()
            ds.Tables.Add(dtable)
            ds.WriteXmlSchema("BusFeeFullDue_Student.xml")
            Dim rpt As New rptBusFeeFullDue_Student
            rpt.SetDataSource(ds)
            rpt.SetParameterValue("p1", cmbSession2.Text)
            rpt.SetParameterValue("p2", cmbClass2.Text)
            rpt.SetParameterValue("p3", cmbInstallment1.Text)
            frmReport.CrystalReportViewer1.ReportSource = rpt
            frmReport.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

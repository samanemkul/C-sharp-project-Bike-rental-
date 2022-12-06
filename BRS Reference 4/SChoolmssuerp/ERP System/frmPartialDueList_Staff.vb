Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmPartialDueList_Staff

    Sub fillSession()
        Try
            con = New SqlConnection(cs)
            con.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct (Session) FROM BusFeepayment_Student", con)
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
  
    Sub Reset()
        cmbSession.SelectedIndex = -1
        cmbInstallment.SelectedIndex = -1
        cmbInstallment.Enabled = False
        dgw.Rows.Clear()
        fillSession()
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmPartialDueList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        fillSession()
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        Reset()
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

    Private Sub TabControl1_Click(sender As System.Object, e As System.EventArgs) Handles TabControl1.Click
        Reset()
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        Try
            If Len(Trim(cmbSession.Text)) = 0 Then
                MessageBox.Show("Please select session", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbSession.Focus()
                Exit Sub
            End If
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("SELECT RTRIM(Staff.StaffID),RTRIM(Staffname),RTRIM(Designation),RTRIM(BusCardHolder_Staff.Location),RTRIM(SchoolName),RTRIM(PaymentDue) FROM BusFeePayment_Staff,Staff,BusCardHolder_Staff,SchoolInfo where Staff.ST_ID=BusCardHolder_Staff.StaffID and BusFeePayment_Staff.BusHolderID=BusCardHolder_Staff.BCH_ID and SchoolInfo.S_ID=Staff.schoolID and BusFeePayment_Staff.Session=@d1 and Installment=@d2 and PaymentDue > 0 order by StaffName", con)
            cmd.Parameters.AddWithValue("@d1", cmbSession.Text)
            cmd.Parameters.AddWithValue("@d2", cmbInstallment.Text)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            While (rdr.Read() = True)
                dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Cursor = Cursors.Default
        Timer1.Enabled = False
    End Sub


    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Try
            If Len(Trim(cmbSession.Text)) = 0 Then
                MessageBox.Show("Please select session", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbSession.Focus()
                Exit Sub
            End If
            Cursor = Cursors.WaitCursor
            Timer1.Enabled = True
            Dim rpt As New rptBusFeePartialDue_Student 'The report you created.
            Dim myConnection As SqlConnection
            Dim MyCommand As New SqlCommand()
            Dim myDA As New SqlDataAdapter()
            Dim myDS As New DataSet 'The DataSet you created.
            myConnection = New SqlConnection(cs)
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "SELECT BusFeePayment_Staff.Id, BusFeePayment_Staff.BFP_ID, BusFeePayment_Staff.PaymentID, BusFeePayment_Staff.BusHolderID, BusFeePayment_Staff.Session, BusFeePayment_Staff.Installment,BusFeePayment_Staff.TotalFee, BusFeePayment_Staff.DiscountPer, BusFeePayment_Staff.DiscountAmt, BusFeePayment_Staff.PreviousDue, BusFeePayment_Staff.Fine, BusFeePayment_Staff.GrandTotal, BusFeePayment_Staff.TotalPaid, BusFeePayment_Staff.ModeOfPayment, BusFeePayment_Staff.PaymentModeDetails, BusFeePayment_Staff.PaymentDate, BusFeePayment_Staff.PaymentDue,BusCardHolder_Staff.BCH_ID, BusCardHolder_Staff.StaffID, BusCardHolder_Staff.BusNo, BusCardHolder_Staff.Location, BusCardHolder_Staff.JoiningDate, BusCardHolder_Staff.Status, Staff.St_ID,Staff.StaffID AS Expr1, Staff.StaffName, Staff.DateOfJoining, Staff.Gender, Staff.FatherName, Staff.TemporaryAddress, Staff.PermanentAddress, Staff.Designation, Staff.Qualifications, Staff.DOB, Staff.PhoneNo,Staff.MobileNo, Staff.Photo, Staff.ClassType, Staff.SchoolID, Staff.AccountName, Staff.AccountNumber, Staff.Bank, Staff.Branch, Staff.IFSCcode, Staff.Salary, SchoolInfo.S_Id,SchoolInfo.SchoolName, SchoolInfo.Address, SchoolInfo.ContactNo, SchoolInfo.AltContactNo, SchoolInfo.FaxNo, SchoolInfo.Email , SchoolInfo.Website, SchoolInfo.Logo, SchoolInfo.RegistrationNo,SchoolInfo.DiseNo, SchoolInfo.IndexNo, SchoolInfo.EstablishedYear, SchoolInfo.Class, SchoolInfo.SchoolType FROM BusFeePayment_Staff INNER JOIN BusCardHolder_Staff ON BusFeePayment_Staff.BusHolderID = BusCardHolder_Staff.BCH_ID INNER JOIN Staff ON BusCardHolder_Staff.StaffID = Staff.St_ID INNER JOIN SchoolInfo ON Staff.SchoolID = SchoolInfo.S_Id where BusFeePayment_Staff.Session=@d1 and PaymentDue > 0 order by StaffName"
            MyCommand.Parameters.AddWithValue("@d1", cmbSession.Text)
            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand
            myDA.Fill(myDS, "Staff")
            myDA.Fill(myDS, "BusCardHolder_Staff")
            myDA.Fill(myDS, "SchoolInfo")
            myDA.Fill(myDS, "BusFeePayment_Staff")
            rpt.SetDataSource(myDS)
            frmReport.CrystalReportViewer1.ReportSource = rpt
            frmReport.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbSession_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbSession.SelectedIndexChanged
        Try
            cmbInstallment.Enabled = True
            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "SELECT distinct RTRIM(Installment) FROM BusFeePayment_Staff,Staff,BusCardHolder_Staff where Staff.St_ID=BusCardHolder_Staff.StaffID and BusFeePayment_Staff.BusHolderID=BusCardHolder_Staff.BCH_ID and BusFeePayment_Staff.Session=@d1"
            cmd = New SqlCommand(ct)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", cmbSession.Text)
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
End Class

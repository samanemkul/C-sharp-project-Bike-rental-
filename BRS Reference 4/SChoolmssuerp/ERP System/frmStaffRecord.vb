Imports System.Data.SqlClient
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmStaffRecord
    Public Sub GetData()
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("Select RTRIM(St_ID) as [ID], RTRIM(StaffID) as [Staff ID], RTRIM(StaffName) as [Staff Name], Convert(DateTime,DateOfJoining,103) as [Joining Date], RTRIM(Gender) as [Gender], RTRIM(FatherName) as [Father's Name], RTRIM(TemporaryAddress) as [Temporary Address], RTRIM(PermanentAddress) as [Permanent Address], RTRIM(Designation) as [Designation], RTRIM(Qualifications) as [Qualifications], Convert(DateTime,DOB,103) as [DOB], RTRIM(PhoneNo) as [Phone No.], RTRIM(MobileNo) as [Mobile No.], RTRIM(Staff.Email) as [Email ID],RTRIM(SchoolID) as [School ID],RTRIM(SchoolName) as [School Name],RTRIM(ClassType) as [Class Type],RTRIM(Salary) as [Basic Salary],RTRIM(AccountName) as [Account Name],RTRIM(AccountNumber) as [Account No.],RTRIM(Bank) as [Bank],RTRIM(Branch) as [Branch],RTRIM(IFSCcode) as [IFSC Code], Photo,RTRIM(Status) as [Status] from Staff,ClassType,SchoolInfo where Staff.ClassType=ClassType.Type and Staff.SchoolID=SchoolInfo.S_ID order by StaffName", con)
            adp = New SqlDataAdapter(cmd)
            ds = New DataSet()
            adp.Fill(ds, "Staff")
            dgw.DataSource = ds.Tables("Staff").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub


    Sub Reset()
        txtStaffName.Text = ""
        dtpDateFrom.Text = Today
        dtpDateTo.Text = Today
        GetData()
    End Sub
    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        Reset()
    End Sub

    Private Sub frmStudentRecord_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        GetData()
    End Sub

    Private Sub dgw_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles dgw.MouseClick
        Try
            Dim dr As DataGridViewRow = dgw.SelectedRows(0)
            If lblSet.Text = "Staff Entry" Then
                Me.Hide()
                frmStaff.Show()
                frmStaff.txtID.Text = dr.Cells(0).Value.ToString()
                frmStaff.txtStaffID.Text = dr.Cells(1).Value.ToString()
                frmStaff.txtStaffName.Text = dr.Cells(2).Value.ToString()
                frmStaff.dtpDateOfJoining.Text = dr.Cells(3).Value.ToString()
                If (dr.Cells(4).Value.ToString() = "Male") Then
                    frmStaff.rbMale.Checked = True
                End If
                If (dr.Cells(2).Value.ToString() = "Female") Then
                    frmStaff.rbFemale.Checked = True
                End If
                frmStaff.txtFatherName.Text = dr.Cells(5).Value.ToString()
                frmStaff.txtTempAddress.Text = dr.Cells(6).Value.ToString()
                frmStaff.txtPermanentAddress.Text = dr.Cells(7).Value.ToString()
                frmStaff.cmbDesignation.Text = dr.Cells(8).Value.ToString()
                frmStaff.txtQualifications.Text = dr.Cells(9).Value.ToString()
                frmStaff.dtpDOB.Text = dr.Cells(10).Value.ToString()
                frmStaff.txtPhoneNo.Text = dr.Cells(11).Value.ToString()
                frmStaff.txtMobileNo.Text = dr.Cells(12).Value.ToString()
                frmStaff.txtEmail.Text = dr.Cells(13).Value.ToString()
                frmStaff.txtSchoolID.Text = dr.Cells(14).Value.ToString()
                frmStaff.cmbSchoolName.Text = dr.Cells(15).Value.ToString()
                frmStaff.cmbClassType.Text = dr.Cells(16).Value.ToString()
                frmStaff.txtBasicSalary.Text = dr.Cells(17).Value.ToString()
                frmStaff.txtAccountName.Text = dr.Cells(18).Value.ToString()
                frmStaff.txtAccountNo.Text = dr.Cells(19).Value.ToString()
                frmStaff.txtBank.Text = dr.Cells(20).Value.ToString()
                frmStaff.txtBranch.Text = dr.Cells(21).Value.ToString()
                frmStaff.txtIFSCcode.Text = dr.Cells(22).Value.ToString()
                Dim data As Byte() = DirectCast(dr.Cells(23).Value, Byte())
                Dim ms As New MemoryStream(data)
                frmStaff.Picture.Image = Image.FromStream(ms)
                frmStaff.cmbStatus.Text = dr.Cells(24).Value.ToString()
                frmStaff.btnUpdate.Enabled = True
                frmStaff.btnDelete.Enabled = True
                frmStaff.btnSave.Enabled = False
                con = New SqlConnection(cs)
                con.Open()
                cmd = New SqlCommand("SELECT Department.ID,DepartmentName from Staff,Department,Staff_Department where Staff.St_ID=Staff_Department.StaffID and Department.ID=Staff_Department.DepartmentID and Staff.St_ID=" & dr.Cells(0).Value & "", con)
                rdr = cmd.ExecuteReader()
                While rdr.Read()

                    Dim lst As New ListViewItem()
                    lst.SubItems.Add(rdr(0))
                    lst.SubItems.Add(rdr(1).ToString().Trim())
                    frmStaff.ListView1.Items.Add(lst)
                End While
                con = New SqlConnection(cs)
                con.Open()
                cmd = con.CreateCommand()
                cmd.CommandText = "SELECT ClassType,Designation FROM Staff where St_iD=@d1"
                cmd.Parameters.AddWithValue("@d1", dr.Cells(0).Value)
                rdr = cmd.ExecuteReader()
                If rdr.Read() Then
                    frmStaff.cmbClassType.Text = rdr.GetValue(0)
                    frmStaff.cmbDesignation.Text = rdr.GetValue(1)
                End If
                If (rdr IsNot Nothing) Then
                    rdr.Close()
                End If
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                lblSet.Text = ""
            End If
            If lblSet.Text = "Bus Holder Entry" Then
                Me.Hide()
                frmBusCardHolder_Staff.Show()
                frmBusCardHolder_Staff.txtS_ID.Text = dr.Cells(0).Value.ToString()
                frmBusCardHolder_Staff.txtStaffID.Text = dr.Cells(1).Value.ToString()
                frmBusCardHolder_Staff.txtStaffName.Text = dr.Cells(2).Value.ToString()
                frmBusCardHolder_Staff.txtSchoolName.Text = dr.Cells(15).Value.ToString()
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

    Private Sub txtStaffName_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtStaffName.TextChanged
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("Select RTRIM(St_ID) as [ID], RTRIM(StaffID) as [Staff ID], RTRIM(StaffName) as [Staff Name], Convert(DateTime,DateOfJoining,103) as [Joining Date], RTRIM(Gender) as [Gender], RTRIM(FatherName) as [Father's Name], RTRIM(TemporaryAddress) as [Temporary Address], RTRIM(PermanentAddress) as [Permanent Address], RTRIM(Designation) as [Designation], RTRIM(Qualifications) as [Qualifications], Convert(DateTime,DOB,103) as [DOB], RTRIM(PhoneNo) as [Phone No.], RTRIM(MobileNo) as [Mobile No.], RTRIM(Staff.Email) as [Email ID],RTRIM(SchoolID) as [School ID],RTRIM(SchoolName) as [School Name],RTRIM(ClassType) as [Class Type],RTRIM(Salary) as [Basic Salary],RTRIM(AccountName) as [Account Name],RTRIM(AccountNumber) as [Account No.],RTRIM(Bank) as [Bank],RTRIM(Branch) as [Branch],RTRIM(IFSCcode) as [IFSC Code], Photo,RTRIM(Status) as [Status] from Staff,ClassType,SchoolInfo where Staff.ClassType=ClassType.Type and Staff.SchoolID=SchoolInfo.S_ID where Staffname like '" & txtStaffName.Text & "%' order by StaffName", con)
            adp = New SqlDataAdapter(cmd)
            ds = New DataSet()
            adp.Fill(ds, "Staff")
            dgw.DataSource = ds.Tables("Staff").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dtpDateTo_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles dtpDateTo.Validating
        If (dtpDateFrom.Value.Date) > (dtpDateTo.Value.Date) Then
            MessageBox.Show("Invalid Selection", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dtpDateTo.Focus()
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("Select RTRIM(St_ID) as [ID], RTRIM(StaffID) as [Staff ID], RTRIM(StaffName) as [Staff Name], Convert(DateTime,DateOfJoining,103) as [Joining Date], RTRIM(Gender) as [Gender], RTRIM(FatherName) as [Father's Name], RTRIM(TemporaryAddress) as [Temporary Address], RTRIM(PermanentAddress) as [Permanent Address], RTRIM(Designation) as [Designation], RTRIM(Qualifications) as [Qualifications], Convert(DateTime,DOB,103) as [DOB], RTRIM(PhoneNo) as [Phone No.], RTRIM(MobileNo) as [Mobile No.], RTRIM(Staff.Email) as [Email ID],RTRIM(SchoolID) as [School ID],RTRIM(SchoolName) as [School Name],RTRIM(ClassType) as [Class Type],RTRIM(Salary) as [Basic Salary],RTRIM(AccountName) as [Account Name],RTRIM(AccountNumber) as [Account No.],RTRIM(Bank) as [Bank],RTRIM(Branch) as [Branch],RTRIM(IFSCcode) as [IFSC Code], Photo,RTRIM(Status) as [Status] from Staff,ClassType,SchoolInfo where Staff.ClassType=ClassType.Type and Staff.SchoolID=SchoolInfo.S_ID where DateOfJoining between @d1 and @d2 order by StaffName", con)
            cmd.Parameters.Add("@d1", SqlDbType.DateTime, 30, "Date").Value = dtpDateFrom.Value.Date
            cmd.Parameters.Add("@d2", SqlDbType.DateTime, 30, "Date").Value = dtpDateTo.Value.Date
            adp = New SqlDataAdapter(cmd)
            ds = New DataSet()
            adp.Fill(ds, "Staff")
            dgw.DataSource = ds.Tables("Staff").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

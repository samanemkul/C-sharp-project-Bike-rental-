Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmBusCardHolder_StaffRecord
   
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
                frmBusCardHolder_Staff.Show()
                frmBusCardHolder_Staff.txtID.Text = dr.Cells(0).Value.ToString()
                frmBusCardHolder_Staff.txtS_ID.Text = dr.Cells(1).Value.ToString()
                frmBusCardHolder_Staff.txtStaffID.Text = dr.Cells(2).Value.ToString()
                frmBusCardHolder_Staff.txtStaffName.Text = dr.Cells(3).Value.ToString()
                frmBusCardHolder_Staff.txtSchoolName.Text = dr.Cells(4).Value.ToString()
                frmBusCardHolder_Staff.cmbBusNo.Text = dr.Cells(5).Value.ToString()
                frmBusCardHolder_Staff.cmbLocationName.Text = dr.Cells(6).Value.ToString()
                frmBusCardHolder_Staff.dtpJoiningDate.Text = dr.Cells(7).Value.ToString()
                frmBusCardHolder_Staff.cmbStatus.Text = dr.Cells(8).Value.ToString()
                frmBusCardHolder_Staff.btnDelete.Enabled = True
                frmBusCardHolder_Staff.btnUpdate.Enabled = True
                frmBusCardHolder_Staff.btnSave.Enabled = False
            End If
            If lblSet.Text = "Bus Fee Payment" Then
                Me.Hide()
                frmBusFeePayment_Staff.Show()
                frmBusFeePayment_Staff.txtBusHolderID.Text = dr.Cells(0).Value.ToString()
                frmBusFeePayment_Staff.txtSt_ID.Text = dr.Cells(1).Value.ToString()
                frmBusFeePayment_Staff.txtStaffID.Text = dr.Cells(2).Value.ToString()
                frmBusFeePayment_Staff.txtStaffName.Text = dr.Cells(3).Value.ToString()
                frmBusFeePayment_Staff.txtLocation.Text = dr.Cells(6).Value.ToString()
                frmBusFeePayment_Staff.fillInstallment()
                con = New SqlConnection(cs)
                con.Open()
                cmd = con.CreateCommand()
                cmd.CommandText = "SELECT Designation FROM Staff where ST_ID=@d1"
                cmd.Parameters.AddWithValue("@d1", dr.Cells(0).Value)
                rdr = cmd.ExecuteReader()
                If rdr.Read() Then
                    frmBusFeePayment_Staff.txtDesignation.Text = rdr.GetValue(0)
                End If
                If (rdr IsNot Nothing) Then
                    rdr.Close()
                End If
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub GetData()
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("SELECT RTRIM(BusCardHolder_Staff.BCH_ID) as [ID],RTRIM(Staff.St_ID) as [SID],RTRIM(Staff.StaffID) as [Staff ID], RTRIM(StaffName) as [StaffName],RTRIM(SchoolName) as [School Name],RTRIM(BusInfo.BusNo) as [Bus No.],RTRIM(LocationName) as [Location Name], CONVERT(DateTime,JoiningDate,105) as [Joining Date],RTRIM(BusCardHolder_Staff.Status) as [Status] from Staff,BusCardHolder_Staff,Location,BusInfo,schoolInfo where Staff.St_ID=BusCardHolder_Staff.StaffID  and Location.LocationName=BusCardHolder_Staff.Location and Staff.SchoolID=SchoolInfo.S_ID and BusInfo.BusNo=BusCardHolder_Staff.BusNo order by StaffName", con)
            adp = New SqlDataAdapter(cmd)
            ds = New DataSet()
            adp.Fill(ds, "Staff")
            dgw.DataSource = ds.Tables("Staff").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtStaffName_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtStaffName.TextChanged
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("SELECT RTRIM(BusCardHolder_Staff.BCH_ID) as [ID],RTRIM(Staff.St_ID) as [SID],RTRIM(Staff.StaffID) as [Staff ID], RTRIM(StaffName) as [StaffName],RTRIM(SchoolName) as [School Name],RTRIM(BusInfo.BusNo) as [Bus No.],RTRIM(LocationName) as [Location Name], CONVERT(DateTime,JoiningDate,105) as [Joining Date],RTRIM(BusCardHolder_Staff.Status) as [Status] from Staff,BusCardHolder_Staff,Location,BusInfo,schoolInfo where Staff.St_ID=BusCardHolder_Staff.StaffID  and Location.LocationName=BusCardHolder_Staff.Location and Staff.SchoolID=SchoolInfo.S_ID and BusInfo.BusNo=BusCardHolder_Staff.BusNo and StaffName like '" & txtStaffName.Text & "%' order by StaffName", con)
            adp = New SqlDataAdapter(cmd)
            ds = New DataSet()
            adp.Fill(ds, "Staff")
            dgw.DataSource = ds.Tables("Staff").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtLocation_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtLocation.TextChanged
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("SELECT RTRIM(BusCardHolder_Staff.BCH_ID) as [ID],RTRIM(Staff.St_ID) as [SID],RTRIM(Staff.StaffID) as [Staff ID], RTRIM(StaffName) as [StaffName],RTRIM(SchoolName) as [School Name],RTRIM(BusInfo.BusNo) as [Bus No.],RTRIM(LocationName) as [Location Name], CONVERT(DateTime,JoiningDate,105) as [Joining Date],RTRIM(BusCardHolder_Staff.Status) as [Status] from Staff,BusCardHolder_Staff,Location,BusInfo,schoolInfo where Staff.St_ID=BusCardHolder_Staff.StaffID  and Location.LocationName=BusCardHolder_Staff.Location and Staff.SchoolID=SchoolInfo.S_ID and BusInfo.BusNo=BusCardHolder_Staff.BusNo and LocationName like '" & txtLocation.Text & "%' order by StaffName", con)
            adp = New SqlDataAdapter(cmd)
            ds = New DataSet()
            adp.Fill(ds, "Staff")
            dgw.DataSource = ds.Tables("Staff").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("SELECT RTRIM(BusCardHolder_Staff.BCH_ID) as [ID],RTRIM(Staff.St_ID) as [SID],RTRIM(Staff.StaffID) as [Staff ID], RTRIM(StaffName) as [StaffName],RTRIM(SchoolName) as [School Name],RTRIM(BusInfo.BusNo) as [Bus No.],RTRIM(LocationName) as [Location Name], CONVERT(DateTime,JoiningDate,105) as [Joining Date],RTRIM(BusCardHolder_Staff.Status) as [Status] from Staff,BusCardHolder_Staff,Location,BusInfo,schoolInfo where Staff.St_ID=BusCardHolder_Staff.StaffID  and Location.LocationName=BusCardHolder_Staff.Location and Staff.SchoolID=SchoolInfo.S_ID and BusInfo.BusNo=BusCardHolder_Staff.BusNo and JoiningDate between @d1 and @d2 order by StaffName", con)
            cmd.Parameters.Add("@d1", SqlDbType.DateTime, 30, "JoiningDate").Value = dtpDateFrom.Value.Date
            cmd.Parameters.Add("@d2", SqlDbType.DateTime, 30, "JoiningDate").Value = dtpDateTo.Value.Date
            adp = New SqlDataAdapter(cmd)
            ds = New DataSet()
            adp.Fill(ds, "Staff")
            dgw.DataSource = ds.Tables("Staff").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub Reset()
        txtLocation.Text = ""
        txtStaffName.Text = ""
        GetData()
    End Sub

    Private Sub frmBusCardHolder_StaffRecord_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        GetData()
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

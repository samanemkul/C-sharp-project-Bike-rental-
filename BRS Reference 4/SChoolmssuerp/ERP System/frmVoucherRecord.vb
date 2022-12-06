Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmVoucherRecord
    Sub fillVoucherNo()
        Try
            Dim CN As New SqlConnection(cs)
            CN.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct RTRIM(VoucherNo) FROM Voucher", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbVoucherNo.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbVoucherNo.Items.Add(drow(0).ToString())
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub GetData()
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("Select RTRIM(Voucher.Id) as [Voucher ID], RTRIM(VoucherNo) as [Voucher No.],Convert(DateTime,Date,103) as [Voucher Date], RTRIM(Name) as [Name],RTRIM(Details) as [Details],RTRIM(SchoolID) as [School ID],RTRIM(SchoolName) as [School Name],RTRIM(Voucher.GrandTotal) as [Grand Total] from Voucher,SchoolInfo where Voucher.SchoolID=schoolInfo.S_ID order by Date", con)
            Dim myDA As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Voucher")
            dgw.DataSource = myDataSet.Tables("Voucher").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub frmLogs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetData()
        fillVoucherNo()
    End Sub
    Sub Reset()
        cmbVoucherNo.Text = ""
        dtpDateFrom.Text = Today
        dtpDateTo.Text = Now
        GetData()
    End Sub
    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        Reset()
    End Sub


    Private Sub btnClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnExportExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportExcel.Click
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

    Private Sub dgw_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgw.MouseClick
        Try
            Dim dr As DataGridViewRow = dgw.SelectedRows(0)
            Me.Hide()
            frmVoucher.Show()
            ' or simply use column name instead of index
            'dr.Cells["id"].Value.ToString();
            frmVoucher.txtVoucherID.Text = dr.Cells(0).Value.ToString()
            frmVoucher.txtVoucherNo.Text = dr.Cells(1).Value.ToString()
            frmVoucher.dtpDate.Text = dr.Cells(2).Value.ToString()
            frmVoucher.txtName.Text = dr.Cells(3).Value.ToString()
            frmVoucher.txtDetails.Text = dr.Cells(4).Value.ToString()
            frmVoucher.txtSchoolID.Text = dr.Cells(5).Value.ToString()
            frmVoucher.cmbSchoolName.Text = dr.Cells(6).Value.ToString()
            frmVoucher.txtGrandTotal.Text = dr.Cells(7).Value.ToString()
            frmVoucher.btnSave.Enabled = False
            frmVoucher.btnDelete.Enabled = True
            frmVoucher.btnUpdate.Enabled = True
            frmVoucher.btnPrint.Enabled = True
            frmVoucher.btnRemove.Enabled = False
            con = New SqlConnection(cs)
            con.Open()
            Dim sql As String = "Select RTRIM(Particulars),RTRIM(Amount),RTRIM(Note) from Voucher,Voucher_OtherDetails where Voucher.Id=Voucher_OtherDetails.VoucherID and Voucher.ID=" & dr.Cells(0).Value & ""
            cmd = New SqlCommand(sql, con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            frmVoucher.DataGridView1.Rows.Clear()
            While (rdr.Read() = True)
                frmVoucher.DataGridView1.Rows.Add(rdr(0), rdr(1), rdr(2))
            End While
            con.Close()
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("Select RTRIM(Voucher.Id) as [Voucher ID], RTRIM(VoucherNo) as [Voucher No.],Convert(DateTime,Date,103) as [Voucher Date], RTRIM(Name) as [Name],RTRIM(Details) as [Details],RTRIM(SchoolID) as [School ID],RTRIM(SchoolName) as [School Name],RTRIM(Voucher.GrandTotal) as [Grand Total] from Voucher,SchoolInfo where Voucher.SchoolID=schoolInfo.S_ID and Date between @d1 and @d2 order by Date", con)
            cmd.Parameters.Add("@d1", SqlDbType.DateTime, 30, "Date").Value = dtpDateFrom.Value.Date
            cmd.Parameters.Add("@d2", SqlDbType.DateTime, 30, "Date").Value = dtpDateTo.Value
            Dim myDA As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Voucher")
            dgw.DataSource = myDataSet.Tables("Voucher").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbBillNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbVoucherNo.SelectedIndexChanged
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("Select RTRIM(Voucher.Id) as [Voucher ID], RTRIM(VoucherNo) as [Voucher No.],Convert(DateTime,Date,103) as [Voucher Date], RTRIM(Name) as [Name],RTRIM(Details) as [Details],RTRIM(SchoolID) as [School ID],RTRIM(SchoolName) as [School Name],RTRIM(Voucher.GrandTotal) as [Grand Total] from Voucher,SchoolInfo where Voucher.SchoolID=schoolInfo.S_ID and VoucherNo='" & cmbVoucherNo.Text & "' order by Date", con)
            Dim myDA As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Voucher")
            dgw.DataSource = myDataSet.Tables("Voucher").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

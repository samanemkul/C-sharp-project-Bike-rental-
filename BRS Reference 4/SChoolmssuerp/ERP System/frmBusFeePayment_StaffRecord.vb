Imports System.Data.SqlClient
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmBusFeePayment_StaffRecord
    Public Sub GetData()
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("Select  RTRIM(BusFeePayment_Staff.Id) as [ID], RTRIM(BFP_ID) as [BFP ID], RTRIM(PaymentID) as [Payment ID],RTRIM(BusHolderID) as [Bus Holder ID], RTRIM(Staff.St_ID) as [ST ID],RTRIM(Staff.StaffID) as [Staff ID],RTRIM(StaffName) as [Staff Name],RTRIM(Designation) as [Designation],RTRIM(BusCardHolder_Staff.Location) as [Location], RTRIM(BusFeePayment_Staff.Session) as [Session],RTRIM(installment) as [installment],  RTRIM(TotalFee) as [Total Fee], RTRIM(DiscountPer) as [Discount %], RTRIM(DiscountAmt) as [Discount], RTRIM(PreviousDue) as [Previous Due], RTRIM(Fine) as [Fine], RTRIM(GrandTotal) as [Grand Total], RTRIM(TotalPaid) as [Total Paid], RTRIM(ModeOfPayment) as [Payment Mode], RTRIM(PaymentModeDetails) as [Payement Mode Info], Convert(Datetime,PaymentDate,131) as [Payement Date], RTRIM(PaymentDue) as [Payement Due] from Staff,BusFeePayment_Staff,BusCardHolder_Staff where BusCardHolder_Staff.BCH_ID=BusFeePayment_Staff.BusHolderID and BusCardHolder_Staff.StaffID=Staff.St_ID order by StaffName", con)
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

    Private Sub txtStaffName_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtStaffName.TextChanged
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("Select  RTRIM(BusFeePayment_Staff.Id) as [ID], RTRIM(BFP_ID) as [BFP ID], RTRIM(PaymentID) as [Payment ID],RTRIM(BusHolderID) as [Bus Holder ID], RTRIM(Staff.St_ID) as [ST ID],RTRIM(Staff.StaffID) as [Staff ID],RTRIM(StaffName) as [Staff Name],RTRIM(Designation) as [Designation],RTRIM(BusCardHolder_Staff.Location) as [Location], RTRIM(BusFeePayment_Staff.Session) as [Session],RTRIM(installment) as [installment],  RTRIM(TotalFee) as [Total Fee], RTRIM(DiscountPer) as [Discount %], RTRIM(DiscountAmt) as [Discount], RTRIM(PreviousDue) as [Previous Due], RTRIM(Fine) as [Fine], RTRIM(GrandTotal) as [Grand Total], RTRIM(TotalPaid) as [Total Paid], RTRIM(ModeOfPayment) as [Payment Mode], RTRIM(PaymentModeDetails) as [Payement Mode Info], Convert(Datetime,PaymentDate,131) as [Payement Date], RTRIM(PaymentDue) as [Payement Due] from Staff,BusFeePayment_Staff,BusCardHolder_Staff where BusCardHolder_Staff.BCH_ID=BusFeePayment_Staff.BusHolderID and BusCardHolder_Staff.StaffID=Staff.St_ID and StaffName like '" & txtStaffName.Text & "%' order by Staffname", con)
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
            cmd = New SqlCommand("Select  RTRIM(BusFeePayment_Staff.Id) as [ID], RTRIM(BFP_ID) as [BFP ID], RTRIM(PaymentID) as [Payment ID],RTRIM(BusHolderID) as [Bus Holder ID], RTRIM(Staff.St_ID) as [ST ID],RTRIM(Staff.StaffID) as [Staff ID],RTRIM(StaffName) as [Staff Name],RTRIM(Designation) as [Designation],RTRIM(BusCardHolder_Staff.Location) as [Location], RTRIM(BusFeePayment_Staff.Session) as [Session],RTRIM(installment) as [installment],  RTRIM(TotalFee) as [Total Fee], RTRIM(DiscountPer) as [Discount %], RTRIM(DiscountAmt) as [Discount], RTRIM(PreviousDue) as [Previous Due], RTRIM(Fine) as [Fine], RTRIM(GrandTotal) as [Grand Total], RTRIM(TotalPaid) as [Total Paid], RTRIM(ModeOfPayment) as [Payment Mode], RTRIM(PaymentModeDetails) as [Payement Mode Info], Convert(Datetime,PaymentDate,131) as [Payement Date], RTRIM(PaymentDue) as [Payement Due] from Staff,BusFeePayment_Staff,BusCardHolder_Staff where BusCardHolder_Staff.BCH_ID=BusFeePayment_Staff.BusHolderID and BusCardHolder_Staff.StaffID=Staff.St_ID and PaymentDate between @d1 and @d2 order by StaffName", con)
            cmd.Parameters.Add("@d1", SqlDbType.DateTime, 30, "Date").Value = dtpDateFrom.Value.Date
            cmd.Parameters.Add("@d2", SqlDbType.DateTime, 30, "Date").Value = dtpDateTo.Value
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
        txtStaffName.Text = ""
        dtpDateFrom.Text = Today
        dtpDateTo.Text = Now
        GetData()
    End Sub
    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        Reset()
    End Sub

    Private Sub frmStaffRecord_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        GetData()
    End Sub

    Private Sub dgw_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles dgw.MouseClick
        Try
            Dim dr As DataGridViewRow = dgw.SelectedRows(0)
            If lblSet.Text = "Bus Fee Payment" Then
                Me.Hide()
                frmBusFeePayment_Staff.Show()
                frmBusFeePayment_Staff.cmbSession.DropDownStyle = ComboBoxStyle.DropDown
                frmBusFeePayment_Staff.txtID.Text = dr.Cells(0).Value.ToString()
                frmBusFeePayment_Staff.cmbInstallment.DropDownStyle = ComboBoxStyle.DropDown
                frmBusFeePayment_Staff.txtBFPId.Text = dr.Cells(1).Value.ToString()
                frmBusFeePayment_Staff.txtFeePaymentID.Text = dr.Cells(2).Value.ToString()
                frmBusFeePayment_Staff.txtBusHolderID.Text = dr.Cells(3).Value.ToString()
                frmBusFeePayment_Staff.txtSt_ID.Text = dr.Cells(4).Value.ToString()
                frmBusFeePayment_Staff.txtStaffID.Text = dr.Cells(5).Value.ToString()
                frmBusFeePayment_Staff.txtStaffName.Text = dr.Cells(6).Value.ToString()
                frmBusFeePayment_Staff.txtDesignation.Text = dr.Cells(7).Value.ToString() '
                frmBusFeePayment_Staff.txtLocation.Text = dr.Cells(8).Value.ToString()
                frmBusFeePayment_Staff.cmbSession.Text = dr.Cells(9).Value.ToString()
                frmBusFeePayment_Staff.cmbInstallment.Text = dr.Cells(10).Value.ToString()
                frmBusFeePayment_Staff.txtBusFee.Text = dr.Cells(11).Value.ToString()
                frmBusFeePayment_Staff.txtDiscountPer.Text = dr.Cells(12).Value.ToString()
                frmBusFeePayment_Staff.txtDiscount.Text = dr.Cells(13).Value.ToString()
                frmBusFeePayment_Staff.txtPreviousDue.Text = dr.Cells(14).Value.ToString()
                frmBusFeePayment_Staff.txtFine.Text = dr.Cells(15).Value.ToString()
                frmBusFeePayment_Staff.txtGrandTotal.Text = dr.Cells(16).Value.ToString()
                frmBusFeePayment_Staff.txtTotalPaid.Text = dr.Cells(17).Value.ToString()
                frmBusFeePayment_Staff.cmbPaymentMode.Text = dr.Cells(18).Value.ToString()
                frmBusFeePayment_Staff.txtPaymentModeDetails.Text = dr.Cells(19).Value.ToString()
                frmBusFeePayment_Staff.dtpPaymentDate.Text = dr.Cells(20).Value.ToString()
                frmBusFeePayment_Staff.txtBalance.Text = dr.Cells(21).Value.ToString()
                frmBusFeePayment_Staff.btnDelete.Enabled = True
                frmBusFeePayment_Staff.cmbSession.Enabled = False
                frmBusFeePayment_Staff.btnUpdate.Enabled = True
                frmBusFeePayment_Staff.btnSave.Enabled = False
                frmBusFeePayment_Staff.Button2.Enabled = False
                frmBusFeePayment_Staff.dtpPaymentDate.Enabled = False
                frmBusFeePayment_Staff.btnPrint.Enabled = True
                frmBusFeePayment_Staff.cmbInstallment.Enabled = False
                con = New SqlConnection(cs)
                con.Open()
                cmd = con.CreateCommand()
                cmd.CommandText = "SELECT Session from BusFeePayment_Staff where ID=@d1"
                cmd.Parameters.AddWithValue("@d1", dr.Cells(0).Value)
                rdr = cmd.ExecuteReader()
                If rdr.Read() Then
                    frmBusFeePayment_Staff.cmbSession.Text = rdr.GetValue(0)
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

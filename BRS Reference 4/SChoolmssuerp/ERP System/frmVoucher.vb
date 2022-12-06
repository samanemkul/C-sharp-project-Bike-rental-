Imports System.Data.SqlClient
Public Class frmVoucher
    Sub fillSchool()
        Try
            con = New SqlConnection(cs)
            con.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct (SchoolName) FROM SchoolInfo", con)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbSchoolName.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbSchoolName.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Sub Reset()
        txtVoucherID.Text = ""
        txtName.Text = ""
        txtDetails.Text = ""
        txtParticulars.Text = ""
        txtNotes.Text = ""
        cmbSchoolName.SelectedIndex = -1
        txtVoucherNo.Text = ""
        txtAmount.Text = ""
        txtGrandTotal.Text = ""
        dtpDate.Text = Today
        DataGridView1.Rows.Clear()
        btnPrint.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        btnAdd.Enabled = True
        btnRemove.Enabled = False
        Clear()
        auto()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            If txtParticulars.Text = "" Then
                MessageBox.Show("Please enter particulars", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtParticulars.Focus()
                Exit Sub
            End If
            If txtAmount.Text = "" Then
                MessageBox.Show("Please enter amount", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtAmount.Focus()
                Exit Sub
            End If
            If DataGridView1.Rows.Count = 0 Then
                DataGridView1.Rows.Add(txtParticulars.Text, txtAmount.Text, txtNotes.Text)
                Dim k As Double = 0
                k = GrandTotal()
                k = Math.Round(k, 2)
                txtGrandTotal.Text = k
                Clear()
                Exit Sub
            End If
            DataGridView1.Rows.Add(txtParticulars.Text, txtAmount.Text, txtNotes.Text)
            Dim j As Double = 0
            j = GrandTotal()
            j = Math.Round(j, 2)
            txtGrandTotal.Text = j
            Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub Clear()
        txtParticulars.Text = ""
        txtAmount.Text = ""
        txtNotes.Text = ""
    End Sub

    Public Function GrandTotal() As Double
        Dim sum As Double = 0
        Try
            For Each r As DataGridViewRow In Me.DataGridView1.Rows
                sum = sum + r.Cells(1).Value
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return sum
    End Function


    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Reset()
        Reset()
    End Sub



    Private Sub auto()
        Dim Num As Integer = 0
        con = New SqlConnection(cs)
        con.Open()
        Dim sql As String = ("SELECT MAX(ID) from Voucher")
        cmd = New SqlCommand(sql)
        cmd.Connection = con
        If (IsDBNull(cmd.ExecuteScalar)) Then
            Num = 1
            txtVoucherID.Text = Num.ToString
            txtVoucherNo.Text = "V-" + Num.ToString
        Else
            Num = cmd.ExecuteScalar + 1
            txtVoucherID.Text = Num.ToString
            txtVoucherNo.Text = "V-" + Num.ToString
        End If
        cmd.Dispose()
        con.Close()
        con.Dispose()
    End Sub

    Sub Print()
        Try
            Cursor = Cursors.WaitCursor
            Timer1.Enabled = True
            Dim rpt As New rptVoucher 'The report you created.
            Dim myConnection As SqlConnection
            Dim MyCommand As New SqlCommand()
            Dim myDA As New SqlDataAdapter()
            Dim myDS As New DataSet 'The DataSet you created.
            myConnection = New SqlConnection(cs)
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "SELECT Voucher.ID, Voucher.VoucherNo, Voucher.Date, Voucher.Name, Voucher.Details, Voucher.SchoolID, Voucher.GrandTotal, Voucher_OtherDetails.VD_ID, Voucher_OtherDetails.VoucherID,Voucher_OtherDetails.Particulars, Voucher_OtherDetails.Amount, Voucher_OtherDetails.Note, SchoolInfo.S_Id, SchoolInfo.SchoolName, SchoolInfo.Address, SchoolInfo.ContactNo, SchoolInfo.AltContactNo,SchoolInfo.FaxNo, SchoolInfo.Email, SchoolInfo.Website, SchoolInfo.Logo, SchoolInfo.RegistrationNo, SchoolInfo.DiseNo, SchoolInfo.IndexNo, SchoolInfo.EstablishedYear, SchoolInfo.Class,SchoolInfo.SchoolType FROM Voucher INNER JOIN Voucher_OtherDetails ON Voucher.ID = Voucher_OtherDetails.VoucherID INNER JOIN SchoolInfo ON Voucher.SchoolID = SchoolInfo.S_Id where VoucherNo='" & txtVoucherNo.Text & "'"
            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand
            myDA.Fill(myDS, "Voucher")
            myDA.Fill(myDS, "Voucher_OtherDetails")
            myDA.Fill(myDS, "SchoolInfo")
            rpt.SetDataSource(myDS)
            frmReport.CrystalReportViewer1.ReportSource = rpt
            frmReport.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If Len(Trim(cmbSchoolName.Text)) = 0 Then
                MessageBox.Show("Please select school name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbSchoolName.Focus()
                Exit Sub
            End If
            If DataGridView1.Rows.Count = 0 Then
                MessageBox.Show("sorry no data added to grid", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "insert into Voucher( Id, VoucherNo, Date,Name,Details,schoolID,GrandTotal) Values (@d1,@d2,@d3,@d4,@d5,@d6,@d7)"
            cmd = New SqlCommand(cb)
            cmd.Parameters.AddWithValue("@d1", txtVoucherID.Text)
            cmd.Parameters.AddWithValue("@d2", txtVoucherNo.Text)
            cmd.Parameters.AddWithValue("@d3", dtpDate.Text)
            cmd.Parameters.AddWithValue("@d4", txtName.Text)
            cmd.Parameters.AddWithValue("@d5", txtDetails.Text)
            cmd.Parameters.AddWithValue("@d6", txtSchoolID.Text)
            cmd.Parameters.AddWithValue("@d7", txtGrandTotal.Text)
            cmd.Connection = con
            cmd.ExecuteReader()
            con.Close()
            con = New SqlConnection(cs)
            con.Open()
            Dim cb1 As String = "insert into Voucher_OtherDetails(VoucherID,Particulars,Amount,Note) VALUES (" & txtVoucherID.Text & ",@d1,@d2,@d3)"
            cmd = New SqlCommand(cb1)
            cmd.Connection = con
            ' Prepare command for repeated execution
            cmd.Prepare()
            ' Data to be inserted
            For Each row As DataGridViewRow In DataGridView1.Rows
                If Not row.IsNewRow Then
                    cmd.Parameters.AddWithValue("@d1", row.Cells(0).Value)
                    cmd.Parameters.AddWithValue("@d2", row.Cells(1).Value)
                    cmd.Parameters.AddWithValue("@d3", row.Cells(2).Value)
                    cmd.ExecuteNonQuery()
                    cmd.Parameters.Clear()
                End If
            Next
            con.Close()
            Dim st As String = "added the new voucher having voucher no.'" & txtVoucherNo.Text & "'"
            LogFunc(lblUser.Text, st)
            btnSave.Enabled = False
            MessageBox.Show("Successfully saved", "Voucher", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Print()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub DeleteRecord()
        Try
            Dim RowsAffected As Integer = 0
            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "delete from Voucher where ID=" & txtVoucherID.Text & ""
            cmd = New SqlCommand(ct)
            cmd.Connection = con
            RowsAffected = cmd.ExecuteNonQuery()
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            If RowsAffected > 0 Then
                Dim st As String = "deleted the voucher having voucher no.'" & txtVoucherNo.Text & "'"
                LogFunc(lblUser.Text, st)
                MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()
                Reset()
            Else
                MessageBox.Show("No record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                DeleteRecord()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            If Len(Trim(cmbSchoolName.Text)) = 0 Then
                MessageBox.Show("Please select school name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbSchoolName.Focus()
                Exit Sub
            End If
            If DataGridView1.Rows.Count = 0 Then
                MessageBox.Show("sorry no data added to grid", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "Update Voucher set VoucherNo=@d2, Date=@d3,Name=@d4,Details=@d5,schoolID=@d6,GrandTotal=@d7 where ID=@d1"
            cmd = New SqlCommand(cb)
            cmd.Parameters.AddWithValue("@d1", txtVoucherID.Text)
            cmd.Parameters.AddWithValue("@d2", txtVoucherNo.Text)
            cmd.Parameters.AddWithValue("@d3", dtpDate.Text)
            cmd.Parameters.AddWithValue("@d4", txtName.Text)
            cmd.Parameters.AddWithValue("@d5", txtDetails.Text)
            cmd.Parameters.AddWithValue("@d6", txtSchoolID.Text)
            cmd.Parameters.AddWithValue("@d7", txtGrandTotal.Text)
            cmd.Connection = con
            cmd.ExecuteReader()
            con.Close()
            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "delete from Voucher_OtherDetails where VoucherID=" & txtVoucherID.Text & ""
            cmd = New SqlCommand(ct)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            con = New SqlConnection(cs)
            con.Open()
            Dim cb1 As String = "insert into Voucher_OtherDetails(VoucherID,Particulars,Amount,Note) VALUES (" & txtVoucherID.Text & ",@d1,@d2,@d3)"
            cmd = New SqlCommand(cb1)
            cmd.Connection = con
            ' Prepare command for repeated execution
            cmd.Prepare()
            ' Data to be inserted
            For Each row As DataGridViewRow In DataGridView1.Rows
                If Not row.IsNewRow Then
                    cmd.Parameters.AddWithValue("@d1", row.Cells(0).Value)
                    cmd.Parameters.AddWithValue("@d2", row.Cells(1).Value)
                    cmd.Parameters.AddWithValue("@d3", row.Cells(2).Value)
                    cmd.ExecuteNonQuery()
                    cmd.Parameters.Clear()
                End If
            Next
            con.Close()
            Dim st As String = "updated the voucher having voucher no.'" & txtVoucherNo.Text & "'"
            LogFunc(lblUser.Text, st)
            btnUpdate.Enabled = False
            MessageBox.Show("Successfully updated", "Voucher", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub DataGridView1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseClick
        btnRemove.Enabled = True
    End Sub


    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        Try
            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                DataGridView1.Rows.Remove(row)
            Next
            Dim k As Double = 0
            k = GrandTotal()
            k = Math.Round(k, 2)
            txtGrandTotal.Text = k
            btnRemove.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Print()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Cursor = Cursors.Default
        Timer1.Enabled = False
    End Sub

    Private Sub txtAmount_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmount.KeyPress
        Dim keyChar = e.KeyChar

        If Char.IsControl(keyChar) Then
            'Allow all control characters.
        ElseIf Char.IsDigit(keyChar) OrElse keyChar = "."c Then
            Dim text = Me.txtAmount.Text
            Dim selectionStart = Me.txtAmount.SelectionStart
            Dim selectionLength = Me.txtAmount.SelectionLength

            text = text.Substring(0, selectionStart) & keyChar & text.Substring(selectionStart + selectionLength)

            If Integer.TryParse(text, New Integer) AndAlso text.Length > 16 Then
                'Reject an integer that is longer than 16 digits.
                e.Handled = True
            ElseIf Double.TryParse(text, New Double) AndAlso text.IndexOf("."c) < text.Length - 3 Then
                'Reject a real number with two many decimal places.
                e.Handled = False
            End If
        Else
            'Reject all other characters.
            e.Handled = True
        End If
    End Sub

    Private Sub frmVoucher_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        fillSchool()
    End Sub

    Private Sub btnGetData_Click(sender As System.Object, e As System.EventArgs) Handles btnGetData.Click
        frmVoucherRecord.Reset()
        frmVoucherRecord.ShowDialog()
    End Sub

    Private Sub cmbSchoolName_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbSchoolName.SelectedIndexChanged
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandText = "SELECT S_ID FROM SchoolInfo where SchoolName=@d1"
            cmd.Parameters.AddWithValue("@d1", cmbSchoolName.Text)
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                txtSchoolID.Text = rdr.GetValue(0)
            End If
            If (rdr IsNot Nothing) Then
                rdr.Close()
            End If
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub
End Class

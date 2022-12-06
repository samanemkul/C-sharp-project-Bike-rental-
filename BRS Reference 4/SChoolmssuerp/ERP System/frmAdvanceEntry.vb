Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Public Class frmAdvanceEntry
    Sub Reset()
        txtStaffID.Text = ""
        txtStaffName.Text = ""
        txtAmount.Text = ""
        dtpEntryDate.Text = Now
        GetData()
        btnDelete.Enabled = False
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        dtpEntryDate.Enabled = True
    End Sub
    Sub GetData()
        Try
            con = New SqlConnection(cs)
            con.Open()
            Dim sql As String = "SELECT RTRIM(Staff.St_ID),RTRIM(Staff.StaffID),RTRIM(StaffName),sum(Amount)-sum(Deduction) FROM Staff left join AdvanceEntry on Staff.St_ID=AdvanceEntry.StaffID where Staff.Status='Active' group by StaffName,Staff.StaffID,Staff.St_ID  order by StaffName"
            cmd = New SqlCommand(sql, con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            While (rdr.Read() = True)
                dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If Len(Trim(txtStaffID.Text)) = 0 Then
            MessageBox.Show("Please retrieve staff info", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtStaffID.Focus()
            Exit Sub
        End If
        If Len(Trim(txtAmount.Text)) = 0 Then
            MessageBox.Show("Please enter Amount", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAmount.Focus()
            Exit Sub
        End If

        Try
            auto()
            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "insert into advanceentry(ID,workingdate,StaffID,amount,deduction) VALUES (" & txtID.Text & ",@d1," & txtStID.Text & "," & txtAmount.Text & ",0)"
            cmd = New SqlCommand(cb)
            cmd.Parameters.AddWithValue("@d1", dtpEntryDate.Value)
            cmd.Connection = con
            cmd.ExecuteReader()
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Close()
            Dim st As String = "added the new advance entry having id '" & txtID.Text & "'"
            LogFunc(lblUser.Text, st)
            MessageBox.Show("Successfully saved", "Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnSave.Enabled = False
            con.Close()
            GetData()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
        If Len(Trim(txtStaffID.Text)) = 0 Then
            MessageBox.Show("Please retrieve Staff info", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtStaffID.Focus()
            Exit Sub
        End If
        If Len(Trim(txtAmount.Text)) = 0 Then
            MessageBox.Show("Please enter Amount", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAmount.Focus()
            Exit Sub
        End If

        Try
            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "Update advanceentry set StaffID=" & txtStID.Text & ",Amount=" & txtAmount.Text & " where id=" & txtID.Text & ""
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            cmd.ExecuteReader()
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Close()
            Dim st As String = "updated the advance entry having id '" & txtID.Text & "'"
            LogFunc(lblUser.Text, st)
            MessageBox.Show("Successfully updated", "Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnUpdate.Enabled = False
            con.Close()
            GetData()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        Try
            If MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                DeleteRecord()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub DeleteRecord()
        Try
            Dim RowsAffected As Integer = 0
            con = New SqlConnection(cs)
            con.Open()
            Dim cq As String = "delete from AdvanceEntry where id=" & txtID.Text & ""
            cmd = New SqlCommand(cq)
            cmd.Connection = con
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                Dim st As String = "deleted the advance entry having id '" & txtID.Text & "'"
                LogFunc(lblUser.Text, st)
                MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                GetData()
                Reset()
            Else
                MessageBox.Show("No Record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()
            End If
            If con.State = ConnectionState.Open Then
                con.Close()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Reset()
    End Sub

    Private Sub frmAdvanceEntry_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        GetData()
    End Sub

    Private Sub dgw_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles dgw.MouseClick
        Try
            Dim dr As DataGridViewRow = dgw.SelectedRows(0)
            txtStID.Text = dr.Cells(0).Value.ToString
            txtStaffID.Text = dr.Cells(1).Value.ToString
            txtStaffName.Text = dr.Cells(2).Value.ToString
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
                'Reject an Integereger that is longer than 16 digits.
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
    Private Sub auto()
        Dim Num As Integer = 0
        con = New SqlConnection(cs)
        con.Open()
        Dim sql As String = ("SELECT MAX(ID) FROM AdvanceEntry")
        cmd = New SqlCommand(sql)
        cmd.Connection = con
        If (IsDBNull(cmd.ExecuteScalar)) Then
            Num = 1
            txtID.Text = Num.ToString
        Else
            Num = cmd.ExecuteScalar + 1
            txtID.Text = Num.ToString
        End If
        cmd.Dispose()
        con.Close()
        con.Dispose()
    End Sub
    Private Sub btnGetData_Click(sender As System.Object, e As System.EventArgs) Handles btnGetData.Click
        frmAdvanceEntryRecord.lblSet.Text = "Advance Entry"
        frmAdvanceEntryRecord.Reset()
        frmAdvanceEntryRecord.ShowDialog()
    End Sub
End Class

Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Public Class frmAttendance
    Sub Reset()
        WorkingDate.Text = Today
        StaffID.Text = ""
        StaffName.Text = ""
        InTime.Text = Now
        OutTime.Text = Now
        Status.SelectedIndex = -1
        txtStaff.Text = ""
        GetData()
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        txtOutTime.Visible = False
        txtInTime.Visible = False
        btnSave.Enabled = True
        WorkingDate.Enabled = True
        InTime.Enabled = False
        OutTime.Enabled = False
    End Sub
    Sub GetData()
        Try
            con = New SqlConnection(cs)
            con.Open()
            Dim sql As String = "SELECT RTRIM(Staff.St_ID) ,RTRIM(Staff.StaffID),RTRIM(StaffName) from Staff order by StaffName"
            cmd = New SqlCommand(sql, con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            While (rdr.Read() = True)
                dgw.Rows.Add(rdr(0), rdr(1), rdr(2))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If Len(Trim(StaffID.Text)) = 0 Then
            MessageBox.Show("Please retrieve Staff id", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            StaffID.Focus()
            Exit Sub
        End If
        If Len(Trim(Status.Text)) = 0 Then
            MessageBox.Show("Please select Status", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Status.Focus()
            Exit Sub
        End If
        Try
            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "select StaffID,workingdate from StaffAttendance where StaffID=" & txtStID.Text & " and workingdate=@d1"
            cmd = New SqlCommand(ct)
            cmd.Parameters.AddWithValue("@d1", WorkingDate.Text)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If rdr.Read Then
                MessageBox.Show("Staff today's attendance is already saved", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If
            auto()
            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "insert into StaffAttendance(ID,Workingdate,StaffID,status,intime,outtime) VALUES (" & txtID.Text & ",@d1,@d2,@d3,@d4,@d5)"
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", WorkingDate.Text)
            cmd.Parameters.AddWithValue("@d2", txtStID.Text)
            cmd.Parameters.AddWithValue("@d3", Status.Text)
            If Status.Text = "P" Then
                cmd.Parameters.AddWithValue("@d4", InTime.Text)
                cmd.Parameters.AddWithValue("@d5", OutTime.Text)
            ElseIf Status.Text = "A" Then
                cmd.Parameters.AddWithValue("@d4", txtInTime.Text)
                cmd.Parameters.AddWithValue("@d5", txtOutTime.Text)
            End If
            cmd.ExecuteReader()
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Close()
            Dim st As String = "added the new attendance entry having id '" & txtID.Text & "'"
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
        If Len(Trim(StaffID.Text)) = 0 Then
            MessageBox.Show("Please retrieve Staff id", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            StaffID.Focus()
            Exit Sub
        End If
        If Len(Trim(Status.Text)) = 0 Then
            MessageBox.Show("Please select Status", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Status.Focus()
            Exit Sub
        End If
        Try
            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "Update StaffAttendance set StaffID=@d2,status=@d3,intime=@d4,outtime=@d5 where ID=" & txtID.Text & ""
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d2", txtStID.Text)
            cmd.Parameters.AddWithValue("@d3", Status.Text)
            If Status.Text = "P" Then
                cmd.Parameters.AddWithValue("@d4", InTime.Text)
                cmd.Parameters.AddWithValue("@d5", OutTime.Text)
            ElseIf Status.Text = "A" Then
                cmd.Parameters.AddWithValue("@d4", txtInTime.Text)
                cmd.Parameters.AddWithValue("@d5", txtOutTime.Text)
            End If
            cmd.ExecuteReader()
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Close()
            Dim st As String = "updated the attendance entry having id '" & txtID.Text & "'"
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
            Dim cq As String = "delete from StaffAttendance where id=" & txtID.Text & ""
            cmd = New SqlCommand(cq)
            cmd.Connection = con
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                Dim st As String = "deleted the attendance entry having id '" & txtID.Text & "'"
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
            StaffID.Text = dr.Cells(1).Value.ToString
            StaffName.Text = dr.Cells(2).Value.ToString
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

    Private Sub auto()
        Dim Num As Integer = 0
        con = New SqlConnection(cs)
        con.Open()
        Dim sql As String = ("SELECT MAX(ID) FROM StaffAttendance")
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
        frmAttendanceEntryRecord.lblSet.Text = "Attendance Entry"
        frmAttendanceEntryRecord.Reset()
        frmAttendanceEntryRecord.ShowDialog()
    End Sub

    Private Sub Status_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Status.SelectedIndexChanged
        If Status.Text = "P" Then
            txtOutTime.Visible = False
            txtInTime.Visible = False
            InTime.Enabled = True
            OutTime.Enabled = True
            InTime.Text = Now
            OutTime.Text = Now
           
        ElseIf Status.Text = "A" Then
            txtOutTime.Visible = True
            txtInTime.Visible = True
            txtOutTime.Text = "00:00:00"
            txtInTime.Text = "00:00:00"
        End If
    End Sub

    Private Sub txtStaff_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtStaff.TextChanged
        Try
            con = New SqlConnection(cs)
            con.Open()
            Dim sql As String = "SELECT RTRIM(Staff.St_ID) ,RTRIM(Staff.StaffID),RTRIM(StaffName) from Staff where StaffName like '" & txtStaff.Text & "%' order by StaffName"
            cmd = New SqlCommand(sql, con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            While (rdr.Read() = True)
                dgw.Rows.Add(rdr(0), rdr(1), rdr(2))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

Imports System.Data.SqlClient
Public Class frmBusCardHolder_Staff
    Private Sub auto()
        Try
            Dim Num As Integer = 0
            con = New SqlConnection(cs)
            con.Open()
            Dim sql As String = ("SELECT MAX(BCH_ID) FROM BusCardHolder_Staff")
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
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub fillLocationName()
        Try
            Dim CN As New SqlConnection(cs)
            CN.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct RTRIM(LocationName) FROM Location", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbLocationName.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbLocationName.Items.Add(drow(0).ToString())
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub fillBusNo()
        Try
            Dim CN As New SqlConnection(cs)
            CN.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct RTRIM(BusNo) FROM BusInfo", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbBusNo.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbBusNo.Items.Add(drow(0).ToString())
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Sub Reset()
        dtpJoiningDate.Text = Today
        cmbStatus.SelectedIndex = -1
        cmbBusNo.SelectedIndex = -1
        txtStaffName.Text = ""
        txtS_ID.Text = ""
        txtStaffID.Text = ""
        txtSchoolName.Text = ""
        cmbLocationName.SelectedIndex = -1
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        txtStaffID.Focus()
        auto()
    End Sub
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Reset()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Len(Trim(txtStaffID.Text)) = 0 Then
            MessageBox.Show("Please retrieve staff id", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtStaffID.Focus()
            Exit Sub
        End If
        If Len(Trim(cmbBusNo.Text)) = 0 Then
            MessageBox.Show("Please select bus no.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbBusNo.Focus()
            Exit Sub
        End If
        If Len(Trim(cmbLocationName.Text)) = 0 Then
            MessageBox.Show("Please select Location name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbLocationName.Focus()
            Exit Sub
        End If
        If Len(Trim(cmbStatus.Text)) = 0 Then
            MessageBox.Show("Please select status", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbStatus.Focus()
            Exit Sub
        End If
        Try
            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "select StaffID from BusCardHolder_Staff where StaffID=@d1"
            cmd = New SqlCommand(ct)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtS_ID.Text)
            rdr = cmd.ExecuteReader()
            If rdr.Read Then
                MessageBox.Show("Record already exists", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Reset()
                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If
            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "insert into BusCardHolder_Staff(BCH_ID,StaffID, Location, JoiningDate, Status,BusNo) VALUES (" & txtID.Text & ",@d1,@d2,@d3,@d4,@d5)"
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtS_ID.Text)
            cmd.Parameters.AddWithValue("@d2", cmbLocationName.Text)
            cmd.Parameters.AddWithValue("@d3", CDate(dtpJoiningDate.Text))
            cmd.Parameters.AddWithValue("@d4", cmbStatus.Text)
            cmd.Parameters.AddWithValue("@d5", cmbBusNo.Text)
            cmd.ExecuteNonQuery()
            LogFunc(lblUser.Text, "added new bus holder '" & txtStaffName.Text & "' having staff id '" & txtStaffID.Text & "'")
            MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnSave.Enabled = False
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If Len(Trim(txtStaffID.Text)) = 0 Then
            MessageBox.Show("Please retrieve staff id", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtStaffID.Focus()
            Exit Sub
        End If
        If Len(Trim(cmbBusNo.Text)) = 0 Then
            MessageBox.Show("Please select bus no.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbBusNo.Focus()
            Exit Sub
        End If
        If Len(Trim(cmbLocationName.Text)) = 0 Then
            MessageBox.Show("Please select Location name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbLocationName.Focus()
            Exit Sub
        End If
        If Len(Trim(cmbStatus.Text)) = 0 Then
            MessageBox.Show("Please select status", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbStatus.Focus()
            Exit Sub
        End If
        Try
            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "Update BusCardHolder_Staff set StaffID=@d1, Location=@d2, JoiningDate=@d3, Status=@d4,BusNo=@d5 where BCH_ID=" & txtID.Text & ""
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtS_ID.Text)
            cmd.Parameters.AddWithValue("@d2", cmbLocationName.Text)
            cmd.Parameters.AddWithValue("@d3", CDate(dtpJoiningDate.Text))
            cmd.Parameters.AddWithValue("@d4", cmbStatus.Text)
            cmd.Parameters.AddWithValue("@d5", cmbBusNo.Text)
            cmd.ExecuteNonQuery()
            LogFunc(lblUser.Text, "updated the record of bus holder '" & txtStaffName.Text & "' having staff id '" & txtStaffID.Text & "'")
            MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnUpdate.Enabled = False
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If MessageBox.Show("Do you really want to delete the record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                delete_records()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub delete_records()
        Try
            Dim RowsAffected As Integer = 0
            con = New SqlConnection(cs)
            con.Open()
            Dim cl As String = "select BusHolderID from BusCardHolder_Staff,BusFeePayment_Staff where BusCardHolder_Staff.BCH_ID=BusFeePayment_Staff.BusHolderID and BusHolderID=@d1"
            cmd = New SqlCommand(cl)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtID.Text)
            rdr = cmd.ExecuteReader()
            If rdr.Read Then
                MessageBox.Show("Unable to delete..Already in use in Bus Fee Payment [Staff]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If
            con = New SqlConnection(cs)
            con.Open()
            Dim cq As String = "delete from BusCardHolder_Staff where BCH_ID= " & txtID.Text & ""
            cmd = New SqlCommand(cq)
            cmd.Connection = con
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                LogFunc(lblUser.Text, "deleted the bus holder '" & txtStaffName.Text & "' having staff id '" & txtStaffID.Text & "'")
                MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()
            Else
                MessageBox.Show("No record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()
                If con.State = ConnectionState.Open Then

                    con.Close()
                End If

                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmBusCardHolder_Student_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        fillLocationName()
        fillBusNo()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        frmStaffRecord.Reset()
        frmStaffRecord.lblSet.Text = "Bus Holder Entry"
        frmStaffRecord.ShowDialog()
    End Sub

    Private Sub btnGetData_Click(sender As System.Object, e As System.EventArgs) Handles btnGetData.Click
        frmBusCardHolder_StaffRecord.Reset()
        frmBusCardHolder_StaffRecord.lblSet.Text = "Bus Holder Entry"
        frmBusCardHolder_StaffRecord.ShowDialog()
    End Sub
End Class

Imports System.Data.SqlClient
Public Class frmHosteler
    Private Sub auto()
        Try
            Dim Num As Integer = 0
            con = New SqlConnection(cs)
            con.Open()
            Dim sql As String = ("SELECT MAX(H_ID) FROM Hosteler")
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
    Sub fillHostelName()
        Try
            Dim CN As New SqlConnection(cs)
            CN.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct RTRIM(HostelName) FROM HostelInfo", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbHostelName.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbHostelName.Items.Add(drow(0).ToString())
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
        txtStudentName.Text = ""
        txtSection.Text = ""
        txtAdmissionNo.Text = ""
        txtClass.Text = ""
        txtSchoolName.Text = ""
        cmbHostelName.SelectedIndex = -1
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        txtAdmissionNo.Focus()
        auto()
    End Sub
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Reset()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Len(Trim(txtAdmissionNo.Text)) = 0 Then
            MessageBox.Show("Please retrieve admission no.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAdmissionNo.Focus()
            Exit Sub
        End If
        If Len(Trim(cmbHostelName.Text)) = 0 Then
            MessageBox.Show("Please select hostel name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbHostelName.Focus()
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
            Dim ct As String = "select AdmissionNo from Hosteler where AdmissionNo=@d1"
            cmd = New SqlCommand(ct)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtAdmissionNo.Text)
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
            Dim cb As String = "insert into Hosteler(H_ID,AdmissionNo,HostelID, JoiningDate, Status) VALUES (" & txtID.Text & ",@d1,@d2,@d3,@d4)"
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtAdmissionNo.Text)
            cmd.Parameters.AddWithValue("@d2", txtHostelID.Text)
            cmd.Parameters.AddWithValue("@d3", CDate(dtpJoiningDate.Text))
            cmd.Parameters.AddWithValue("@d4", cmbStatus.Text)
            cmd.ExecuteNonQuery()
            LogFunc(lblUser.Text, "added new hosteler '" & txtStudentName.Text & "' having admission no. '" & txtAdmissionNo.Text & "'")
            MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnSave.Enabled = False
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If Len(Trim(txtAdmissionNo.Text)) = 0 Then
            MessageBox.Show("Please retrieve admission no.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAdmissionNo.Focus()
            Exit Sub
        End If
        If Len(Trim(cmbHostelName.Text)) = 0 Then
            MessageBox.Show("Please select hostel name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbHostelName.Focus()
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
            Dim cb As String = "Update Hosteler set AdmissionNo=@d1, HostelID=@d2, JoiningDate=@d3, Status=@d4 where H_ID=" & txtID.Text & ""
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtAdmissionNo.Text)
            cmd.Parameters.AddWithValue("@d2", txtHostelID.Text)
            cmd.Parameters.AddWithValue("@d3", CDate(dtpJoiningDate.Text))
            cmd.Parameters.AddWithValue("@d4", cmbStatus.Text)
            cmd.ExecuteNonQuery()
            LogFunc(lblUser.Text, "updated the hosteler '" & txtStudentName.Text & "' having admission no. '" & txtAdmissionNo.Text & "'")
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
            Dim cl As String = "select HostelerID from Hosteler,HostelFeePayment where Hosteler.H_ID=HostelFeePayment.HostelerID and HostelerID=@d1"
            cmd = New SqlCommand(cl)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtID.Text)
            rdr = cmd.ExecuteReader()
            If rdr.Read Then
                MessageBox.Show("Unable to delete..Already in use in Hostel Fee Payment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If
            con = New SqlConnection(cs)
            con.Open()
            Dim cq As String = "delete from Hosteler where H_ID= " & txtID.Text & ""
            cmd = New SqlCommand(cq)
            cmd.Connection = con
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                LogFunc(lblUser.Text, "deleted the hosteler '" & txtStudentName.Text & "' having admission no. '" & txtAdmissionNo.Text & "'")
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

    Private Sub frmHosteler_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        fillHostelName()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        frmStudentRecord.Reset()
        frmStudentRecord.lblSet.Text = "Hosteler Entry"
        frmStudentRecord.ShowDialog()
    End Sub

    Private Sub btnGetData_Click(sender As System.Object, e As System.EventArgs) Handles btnGetData.Click
        frmHostelerRecord.Reset()
        frmHostelerRecord.lblSet.Text = "Hosteler Entry"
        frmHostelerRecord.ShowDialog()
    End Sub

    Private Sub cmbHostelName_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbHostelName.SelectedIndexChanged
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandText = "SELECT HI_ID FROM HostelInfo where HostelName=@d1"
            cmd.Parameters.AddWithValue("@d1", cmbHostelName.Text)
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                txtHostelID.Text = rdr.GetValue(0)
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

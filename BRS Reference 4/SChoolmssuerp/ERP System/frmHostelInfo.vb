Imports System.Data.SqlClient
Imports System.IO

Public Class frmhostelInfo
    Private Sub auto()
        Try
            Dim Num As Integer = 0
            con = New SqlConnection(cs)
            con.Open()
            Dim sql As String = ("SELECT MAX(HI_ID) FROM HostelInfo")
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

    Sub Reset()
        txtAddress.Text = ""
        txtPersonIncharge.Text = ""
        txtContactNo.Text = ""
        txtContactNo_PI.Text = ""
        txtID.Text = ""
        txtHostelName.Text = ""
        txtHostelName.Focus()
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        auto()
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtHostelName.Text = "" Then
            MessageBox.Show("Please enter hostel name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtHostelName.Focus()
            Return
        End If
        If txtAddress.Text = "" Then
            MessageBox.Show("Please enter address", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAddress.Focus()
            Return
        End If
        If txtContactNo.Text = "" Then
            MessageBox.Show("Please enter contact no.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtContactNo.Focus()
            Return
        End If
        Try
            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "select HostelName from HostelInfo where Hostelname=@d1"
            cmd = New SqlCommand(ct)
            cmd.Parameters.AddWithValue("@d1", txtHostelName.Text)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()

            If rdr.Read() Then
                MessageBox.Show("Hostel Name Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtHostelName.Text = ""
                txtHostelName.Focus()
                If (rdr IsNot Nothing) Then
                    rdr.Close()
                End If
                Return
            End If
            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "insert into hostelInfo(HI_Id, Hostelname, Address, ContactNo, ManagedBy, Person_ContactNo) VALUES (@d1,@d2,@d3,@d4,@d5,@d6)"
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtID.Text)
            cmd.Parameters.AddWithValue("@d2", txtHostelName.Text)
            cmd.Parameters.AddWithValue("@d3", txtAddress.Text)
            cmd.Parameters.AddWithValue("@d4", txtContactNo.Text)
            cmd.Parameters.AddWithValue("@d5", txtPersonIncharge.Text)
            cmd.Parameters.AddWithValue("@d6", txtContactNo_PI.Text)
            cmd.ExecuteNonQuery()
            con.Close()
            Dim st As String = "added the hostel '" & txtHostelName.Text & "' info"
            LogFunc(lblUser.Text, st)
            MessageBox.Show("Successfully saved", "Hostel Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnSave.Enabled = False
            Getdata()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub


    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If txtHostelName.Text = "" Then
            MessageBox.Show("Please enter hostel name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtHostelName.Focus()
            Return
        End If
        If txtAddress.Text = "" Then
            MessageBox.Show("Please enter address", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAddress.Focus()
            Return
        End If
        If txtContactNo.Text = "" Then
            MessageBox.Show("Please enter contact no.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtContactNo.Focus()
            Return
        End If
        Try
            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "Update hostelInfo set hostelName=@d2, Address=@d3, ContactNo=@d4, ManagedBy=@d5, Person_ContactNo=@d6 where HI_ID=@d1"
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtID.Text)
            cmd.Parameters.AddWithValue("@d2", txtHostelName.Text)
            cmd.Parameters.AddWithValue("@d3", txtAddress.Text)
            cmd.Parameters.AddWithValue("@d4", txtContactNo.Text)
            cmd.Parameters.AddWithValue("@d5", txtPersonIncharge.Text)
            cmd.Parameters.AddWithValue("@d6", txtContactNo_PI.Text)
            cmd.ExecuteNonQuery()
            con.Close()
            Dim st As String = "updated the hostel '" & txtHostelName.Text & "' info"
            LogFunc(lblUser.Text, st)
            MessageBox.Show("Successfully updated", "Hostel Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnUpdate.Enabled = False
            Getdata()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub
    Public Sub Getdata()
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("SELECT RTRIM(HI_Id), RTRIM(hostelName), RTRIM(Address), RTRIM(ContactNo), RTRIM(ManagedBy), RTRIM(Person_ContactNo) from hostelInfo order by hostelname", con)
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
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Reset()
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

    Private Sub frmRegistration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Getdata()
    End Sub

    Private Sub dgw_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgw.MouseClick
        Try
            Dim dr As DataGridViewRow = dgw.SelectedRows(0)
            txtID.Text = dr.Cells(0).Value.ToString()
            txtHostelName.Text = dr.Cells(1).Value.ToString()
            txtAddress.Text = dr.Cells(2).Value.ToString()
            txtContactNo.Text = dr.Cells(3).Value.ToString()
            txtPersonIncharge.Text = dr.Cells(4).Value.ToString()
            txtContactNo_PI.Text = dr.Cells(5).Value.ToString()
            btnUpdate.Enabled = True
            btnSave.Enabled = False
            btnDelete.Enabled = True
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
            Dim cl As String = "select HI_ID from hostelInfo,Hosteler where hostelInfo.HI_ID=Hosteler.hostelID and HI_ID=@d1"
            cmd = New SqlCommand(cl)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtID.Text)
            rdr = cmd.ExecuteReader()
            If rdr.Read Then
                MessageBox.Show("Unable to delete..Already in use in Hosteler Entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If
            con = New SqlConnection(cs)
            con.Open()
            Dim cl1 As String = "select HI_ID from hostelInfo,Installment_Hostel where hostelInfo.HI_ID=Installment_Hostel.hostelID and HI_ID=@d1"
            cmd = New SqlCommand(cl1)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtID.Text)
            rdr = cmd.ExecuteReader()
            If rdr.Read Then
                MessageBox.Show("Unable to delete..Already in use in Hostel Installment Entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If
            con = New SqlConnection(cs)
            con.Open()
            Dim cq As String = "delete from hostelInfo where HI_id=" & txtID.Text & ""
            cmd = New SqlCommand(cq)
            cmd.Connection = con
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                Dim st As String = "deleted the hostel '" & txtHostelName.Text & "'"
                LogFunc(lblUser.Text, st)
                MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Getdata()
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

End Class

Imports System.Data.SqlClient
Public Class frmRegistration

    Sub Reset()
        txtContactNo.Text = ""
        txtEmailID.Text = ""
        txtName.Text = ""
        txtPassword.Text = ""
        txtUserID.Text = ""
        cmbUserType.SelectedIndex = -1
        txtUserID.Focus()
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtUserID.Text = "" Then
            MessageBox.Show("Please enter user id", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            txtUserID.Focus()
            Return
        End If
        If cmbUserType.Text = "" Then
            MessageBox.Show("Please select user type", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            cmbUserType.Focus()
            Return
        End If
        If txtPassword.Text = "" Then
            MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            txtPassword.Focus()
            Return
        End If
        If txtName.Text = "" Then
            MessageBox.Show("Please enter name", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            txtName.Focus()
            Return
        End If
        If txtContactNo.Text = "" Then
            MessageBox.Show("Please enter contact no.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            txtContactNo.Focus()
            Return
        End If

        Try
            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "select userid from registration where userid='" & txtUserID.Text & "'"

            cmd = New SqlCommand(ct)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()

            If rdr.Read() Then
                MessageBox.Show("user id Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtUserID.Text = ""
                txtUserID.Focus()
                If (rdr IsNot Nothing) Then
                    rdr.Close()
                End If
                Return
            End If

            con = New SqlConnection(cs)
            con.Open()

            Dim cb As String = "insert into Registration(userid, UserType, Password, Name, ContactNo, EmailID,JoiningDate) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7)"
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtUserID.Text)
            cmd.Parameters.AddWithValue("@d2", cmbUserType.Text)
            cmd.Parameters.AddWithValue("@d3", Encrypt(txtPassword.Text.Trim()))
            cmd.Parameters.AddWithValue("@d4", txtName.Text)
            cmd.Parameters.AddWithValue("@d5", txtContactNo.Text)
            cmd.Parameters.AddWithValue("@d6", txtEmailID.Text)
            cmd.Parameters.AddWithValue("@d7", Now)
            cmd.ExecuteReader()
            con.Close()
            con = New SqlConnection(cs)
            con.Open()
            Dim st As String = "added the new user '" & txtUserID.Text & "'"
            Dim cb1 As String = "insert into Logs(userid,Operation,Date) VALUES (@d1,@d2,@d3)"
            cmd = New SqlCommand(cb1)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", lblUser.Text)
            cmd.Parameters.AddWithValue("@d2", st)
            cmd.Parameters.AddWithValue("@d3", System.DateTime.Now)
            cmd.ExecuteReader()
            con.Close()
            MessageBox.Show("Successfully Registered", "User", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnSave.Enabled = False
            Getdata()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
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
    Private Sub DeleteRecord()

        Try
            If txtUserID.Text = "admin" Or txtUserID.Text = "Admin" Then
                MessageBox.Show("Admin account can not be deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim RowsAffected As Integer = 0
            con = New SqlConnection(cs)
            con.Open()
            Dim cq As String = "delete from Registration where userid='" & txtUserID.Text & "'"
            cmd = New SqlCommand(cq)
            cmd.Connection = con
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                con = New SqlConnection(cs)
                con.Open()
                Dim st As String = "deleted the user '" & txtUserID.Text & "'"
                Dim cb1 As String = "insert into Logs(userid,Operation,Date) VALUES (@d1,@d2,@d3)"
                cmd = New SqlCommand(cb1)
                cmd.Connection = con
                cmd.Parameters.AddWithValue("@d1", lblUser.Text)
                cmd.Parameters.AddWithValue("@d2", st)
                cmd.Parameters.AddWithValue("@d3", System.DateTime.Now)
                cmd.ExecuteReader()
                con.Close()
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

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            If txtUserID.Text = "" Then
                MessageBox.Show("Please enter user id", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtUserID.Focus()
                Return
            End If
            If cmbUserType.Text = "" Then
                MessageBox.Show("Please select user type", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                cmbUserType.Focus()
                Return
            End If
            If txtPassword.Text = "" Then
                MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtPassword.Focus()
                Return
            End If
            If txtName.Text = "" Then
                MessageBox.Show("Please enter name", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtName.Focus()
                Return
            End If
            If txtContactNo.Text = "" Then
                MessageBox.Show("Please enter contact no.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtContactNo.Focus()
                Return
            End If

            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "update registration set userid=@d1, usertype=@d2,password=@d3,name=@d4,contactno=@d5,emailid=@d6 where userid=@d7"
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtUserID.Text)
            cmd.Parameters.AddWithValue("@d2", cmbUserType.Text)
            cmd.Parameters.AddWithValue("@d3", Encrypt(txtPassword.Text.Trim()))
            cmd.Parameters.AddWithValue("@d4", txtName.Text)
            cmd.Parameters.AddWithValue("@d5", txtContactNo.Text)
            cmd.Parameters.AddWithValue("@d6", txtEmailID.Text)
            cmd.Parameters.AddWithValue("@d7", TextBox1.Text)
            cmd.ExecuteReader()
            con.Close()
            con.Open()
            Dim st As String = "updated the user '" & txtUserID.Text & "' details"
            Dim cb1 As String = "insert into Logs(userid,Operation,Date) VALUES (@d1,@d2,@d3)"
            cmd = New SqlCommand(cb1)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", lblUser.Text)
            cmd.Parameters.AddWithValue("@d2", st)
            cmd.Parameters.AddWithValue("@d3", System.DateTime.Now)
            cmd.ExecuteReader()
            con.Close()
            MessageBox.Show("Successfully updated", "User Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            cmd = New SqlCommand("SELECT RTRIM(userid), RTRIM(UserType), RTRIM(Password), RTRIM(Name), RTRIM(EmailID), RTRIM(ContactNo),RTRIM(JoiningDate) from Registration order by JoiningDate", con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            While (rdr.Read() = True)
                dgw.Rows.Add(rdr(0), rdr(1), Decrypt(rdr(2)), rdr(3), rdr(4), rdr(5), rdr(6))
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
            txtUserID.Text = dr.Cells(0).Value.ToString()
            TextBox1.Text = dr.Cells(0).Value.ToString()
            cmbUserType.Text = dr.Cells(1).Value.ToString()
            txtPassword.Text = dr.Cells(2).Value.ToString()
            txtName.Text = dr.Cells(3).Value.ToString()
            txtContactNo.Text = dr.Cells(5).Value.ToString()
            txtEmailID.Text = dr.Cells(4).Value.ToString()
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
            btnSave.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

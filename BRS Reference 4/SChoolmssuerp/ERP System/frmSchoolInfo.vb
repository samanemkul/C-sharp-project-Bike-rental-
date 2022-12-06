Imports System.Data.SqlClient
Imports System.IO

Public Class frmSchoolInfo
    Private Sub auto()
        Try
            Dim Num As Integer = 0
            con = New SqlConnection(cs)
            con.Open()
            Dim sql As String = ("SELECT MAX(S_ID) FROM SchoolInfo")
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
    Sub fillCombo()
        Try
            con = New SqlConnection(cs)
            con.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct RTRIM(Type) FROM SchoolType", con)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbSchoolType.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbSchoolType.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub Reset()
        txtAddress.Text = ""
        txtAltContactNo.Text = ""
        txtClass.Text = ""
        txtContactNo.Text = ""
        txtDiseNo.Text = ""
        txtEmailID.Text = ""
        txtEstablishedYear.Text = ""
        txtFax.Text = ""
        txtID.Text = ""
        txtIndexNo.Text = ""
        txtRegistrationNo.Text = ""
        txtSchoolName.Text = ""
        txtWebsite.Text = ""
        cmbSchoolType.SelectedIndex = -1
        PictureBox1.Image = My.Resources.kcK56zncj
        txtSchoolName.Focus()
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        auto()
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtSchoolName.Text = "" Then
            MessageBox.Show("Please enter school name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSchoolName.Focus()
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

        If txtEmailID.Text = "" Then
            MessageBox.Show("Please enter email id", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmailID.Focus()
            Return
        End If
        If txtEstablishedYear.Text = "" Then
            MessageBox.Show("Please enter established year", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEstablishedYear.Focus()
            Return
        End If
        If cmbSchoolType.Text = "" Then
            MessageBox.Show("Please select school type", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbSchoolType.Focus()
            Return
        End If
        Try
            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "select SchoolName from SchoolInfo where SchoolName=@d1"
            cmd = New SqlCommand(ct)
            cmd.Parameters.AddWithValue("@d1", txtSchoolName.Text)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()

            If rdr.Read() Then
                MessageBox.Show("School Name Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtSchoolName.Text = ""
                txtSchoolName.Focus()
                If (rdr IsNot Nothing) Then
                    rdr.Close()
                End If
                Return
            End If
            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "insert into SchoolInfo( S_Id, SchoolName, Address, ContactNo, AltContactNo, FaxNo, Email, Website,RegistrationNo, DiseNo, IndexNo, EstablishedYear, Class, SchoolType,Logo) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12,@d13,@d14,@d15)"
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtID.Text)
            cmd.Parameters.AddWithValue("@d2", txtSchoolName.Text)
            cmd.Parameters.AddWithValue("@d3", txtAddress.Text)
            cmd.Parameters.AddWithValue("@d4", txtContactNo.Text)
            cmd.Parameters.AddWithValue("@d5", txtAltContactNo.Text)
            cmd.Parameters.AddWithValue("@d6", txtFax.Text)
            cmd.Parameters.AddWithValue("@d7", txtEmailID.Text)
            cmd.Parameters.AddWithValue("@d8", txtWebsite.Text)
            cmd.Parameters.AddWithValue("@d9", txtRegistrationNo.Text)
            cmd.Parameters.AddWithValue("@d10", txtDiseNo.Text)
            cmd.Parameters.AddWithValue("@d11", txtIndexNo.Text)
            cmd.Parameters.AddWithValue("@d12", txtEstablishedYear.Text)
            cmd.Parameters.AddWithValue("@d13", txtClass.Text)
            cmd.Parameters.AddWithValue("@d14", cmbSchoolType.Text)
            Dim ms As New MemoryStream()
            Dim bmpImage As New Bitmap(PictureBox1.Image)
            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim data As Byte() = ms.GetBuffer()
            Dim p As New SqlParameter("@d15", SqlDbType.Image)
            p.Value = data
            cmd.Parameters.Add(p)
            cmd.ExecuteNonQuery()
            con.Close()
            Dim st As String = "added the School '" & txtSchoolName.Text & "' info"
            LogFunc(lblUser.Text, st)
            MessageBox.Show("Successfully saved", "School Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnSave.Enabled = False
            Getdata()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub


    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If txtSchoolName.Text = "" Then
            MessageBox.Show("Please enter school name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSchoolName.Focus()
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

        If txtEmailID.Text = "" Then
            MessageBox.Show("Please enter email id", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmailID.Focus()
            Return
        End If
        If txtEstablishedYear.Text = "" Then
            MessageBox.Show("Please enter established year", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEstablishedYear.Focus()
            Return
        End If
        If cmbSchoolType.Text = "" Then
            MessageBox.Show("Please select school type", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbSchoolType.Focus()
            Return
        End If
        Try
            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "Update SchoolInfo set SchoolName=@d2, Address=@d3, ContactNo=@d4, AltContactNo=@d5, FaxNo=@d6, Email=@d7, Website=@d8,RegistrationNo=@d9, DiseNo=@d10, IndexNo=@d11, EstablishedYear=@d12, Class=@d13, SchoolType=@d14,Logo=@d15 where S_ID=@d1"
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtID.Text)
            cmd.Parameters.AddWithValue("@d2", txtSchoolName.Text)
            cmd.Parameters.AddWithValue("@d3", txtAddress.Text)
            cmd.Parameters.AddWithValue("@d4", txtContactNo.Text)
            cmd.Parameters.AddWithValue("@d5", txtAltContactNo.Text)
            cmd.Parameters.AddWithValue("@d6", txtFax.Text)
            cmd.Parameters.AddWithValue("@d7", txtEmailID.Text)
            cmd.Parameters.AddWithValue("@d8", txtWebsite.Text)
            cmd.Parameters.AddWithValue("@d9", txtRegistrationNo.Text)
            cmd.Parameters.AddWithValue("@d10", txtDiseNo.Text)
            cmd.Parameters.AddWithValue("@d11", txtIndexNo.Text)
            cmd.Parameters.AddWithValue("@d12", txtEstablishedYear.Text)
            cmd.Parameters.AddWithValue("@d13", txtClass.Text)
            cmd.Parameters.AddWithValue("@d14", cmbSchoolType.Text)
            Dim ms As New MemoryStream()
            Dim bmpImage As New Bitmap(PictureBox1.Image)
            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim data As Byte() = ms.GetBuffer()
            Dim p As New SqlParameter("@d15", SqlDbType.Image)
            p.Value = data
            cmd.Parameters.Add(p)
            cmd.ExecuteNonQuery()
            con.Close()
            Dim st As String = "updated the School '" & txtSchoolName.Text & "' info"
            LogFunc(lblUser.Text, st)
            MessageBox.Show("Successfully updated", "School Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            cmd = New SqlCommand("SELECT RTRIM(S_Id), RTRIM(SchoolName), RTRIM(Address), RTRIM(ContactNo), RTRIM(AltContactNo), RTRIM(FaxNo), RTRIM(Email), RTRIM(Website),RTRIM(RegistrationNo), RTRIM(DiseNo), RTRIM(IndexNo), RTRIM(EstablishedYear), RTRIM(Class), RTRIM(SchoolType),Logo from SchoolInfo order by schoolname", con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            While (rdr.Read() = True)
                dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5), rdr(6), rdr(7), rdr(8), rdr(9), rdr(10), rdr(11), rdr(12), rdr(13), rdr(14))
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
        fillCombo()
    End Sub

    Private Sub dgw_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgw.MouseClick
        Try
            Dim dr As DataGridViewRow = dgw.SelectedRows(0)
            txtID.Text = dr.Cells(0).Value.ToString()
            txtSchoolName.Text = dr.Cells(1).Value.ToString()
            txtAddress.Text = dr.Cells(2).Value.ToString()
            txtContactNo.Text = dr.Cells(3).Value.ToString()
            txtAltContactNo.Text = dr.Cells(4).Value.ToString()
            txtFax.Text = dr.Cells(5).Value.ToString()
            txtEmailID.Text = dr.Cells(6).Value.ToString()
            txtWebsite.Text = dr.Cells(7).Value.ToString()
            txtRegistrationNo.Text = dr.Cells(8).Value.ToString()
            txtDiseNo.Text = dr.Cells(9).Value.ToString()
            txtIndexNo.Text = dr.Cells(10).Value.ToString()
            txtEstablishedYear.Text = dr.Cells(11).Value.ToString()
            txtClass.Text = dr.Cells(12).Value.ToString()
            cmbSchoolType.Text = dr.Cells(13).Value.ToString()
            Dim data As Byte() = DirectCast(dr.Cells(14).Value, Byte())
            Dim ms As New MemoryStream(data)
            Me.PictureBox1.Image = Image.FromStream(ms)
            btnUpdate.Enabled = True
            btnSave.Enabled = False
            btnDelete.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Try
            With OpenFileDialog1
                .Filter = ("Images |*.png; *.bmp; *.jpg;*.jpeg; *.gif;*.ico;")
                .FilterIndex = 4
            End With
            'Clear the file name
            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
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
            Dim cl As String = "select S_ID from SchoolInfo,Student where SchoolInfo.S_ID=Student.SchoolID and S_ID=@d1"
            cmd = New SqlCommand(cl)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtID.Text)
            rdr = cmd.ExecuteReader()
            If rdr.Read Then
                MessageBox.Show("Unable to delete..Already in use in Student Entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If
            con = New SqlConnection(cs)
            con.Open()
            Dim cl1 As String = "select S_ID from SchoolInfo,Staff where SchoolInfo.S_ID=Staff.SchoolID and S_ID=@d1"
            cmd = New SqlCommand(cl1)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtID.Text)
            rdr = cmd.ExecuteReader()
            If rdr.Read Then
                MessageBox.Show("Unable to delete..Already in use in Staff Entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If
            con = New SqlConnection(cs)
            con.Open()
            Dim cl2 As String = "select S_ID from SchoolInfo,Voucher where SchoolInfo.S_ID=Voucher.SchoolID and S_ID=@d1"
            cmd = New SqlCommand(cl2)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtID.Text)
            rdr = cmd.ExecuteReader()
            If rdr.Read Then
                MessageBox.Show("Unable to delete..Already in use in Voucher Entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If
            con = New SqlConnection(cs)
            con.Open()
            Dim cl3 As String = "select S_ID from SchoolInfo,CourseFee where SchoolInfo.S_ID=CourseFee.SchoolID and S_ID=@d1"
            cmd = New SqlCommand(cl3)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtID.Text)
            rdr = cmd.ExecuteReader()
            If rdr.Read Then
                MessageBox.Show("Unable to delete..Already in use in Class Fee Entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If
            con = New SqlConnection(cs)
            con.Open()
            Dim cl4 As String = "select S_ID from SchoolInfo,Installment_Hostel where SchoolInfo.S_ID=Installment_Hostel.SchoolID and S_ID=@d1"
            cmd = New SqlCommand(cl4)
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
            Dim cq As String = "delete from SchoolInfo where S_id=" & txtID.Text & ""
            cmd = New SqlCommand(cq)
            cmd.Connection = con
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                Dim st As String = "deleted the school '" & txtSchoolName.Text & "'"
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

    Private Sub txtEstablishedYear_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtEstablishedYear.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub
End Class

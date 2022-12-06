Imports System.Data.SqlClient
Imports System.IO

Public Class frmStaff
    Dim s1 As String
    Dim Photoname As String = ""
    Dim IsImageChanged As Boolean = False
    Dim gender As String
    Private Sub auto()
        Try
            Dim Num As Integer = 0
            con = New SqlConnection(cs)
            con.Open()
            Dim sql As String = ("SELECT MAX(St_ID) FROM Staff")
            cmd = New SqlCommand(sql)
            cmd.Connection = con
            If (IsDBNull(cmd.ExecuteScalar)) Then
                Num = 1
                txtID.Text = Num.ToString
                txtStaffID.Text = "S-" + Num.ToString
            Else
                Num = cmd.ExecuteScalar + 1
                txtID.Text = Num.ToString
                txtStaffID.Text = "S-" + Num.ToString
            End If
            cmd.Dispose()
            con.Close()
            con.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
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
    Sub fillClassType()
        Try
            con = New SqlConnection(cs)
            con.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct (Type) FROM ClassType", con)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbClassType.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbClassType.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub Reset()
        txtStaffID.Text = ""
        cmbDepartment.SelectedIndex = -1
        cmbDesignation.SelectedIndex = -1
        cmbStatus.SelectedIndex = -1
        ListView1.Items.Clear()
        txtEmail.Text = ""
        txtFatherName.Text = ""
        txtMobileNo.Text = ""
        txtPermanentAddress.Text = ""
        txtPhoneNo.Text = ""
        txtStaffName.Text = ""
        txtTempAddress.Text = ""
        txtPermanentAddress.Text = ""
        dtpDateOfJoining.Text = Today
        dtpDOB.Text = Today
        cmbDepartment.SelectedIndex = -1
        cmbClassType.SelectedIndex = -1
        cmbSchoolName.SelectedIndex = -1
        txtAccountName.Text = ""
        txtQualifications.Text = ""
        txtAccountNo.Text = ""
        txtBank.Text = ""
        txtBranch.Text = ""
        txtIFSCcode.Text = ""
        txtBasicSalary.Text = ""
        Picture.Image = My.Resources.photo
        rbMale.Checked = False
        rbFemale.Checked = False
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        txtStaffName.Focus()
        auto()
    End Sub


    Private Sub Browse_Click_1(sender As System.Object, e As System.EventArgs) Handles Browse.Click
        Try
            With OpenFileDialog1
                .Filter = ("Images |*.png; *.bmp; *.jpg;*.jpeg; *.gif;")
                .FilterIndex = 4
            End With
            'Clear the file name
            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Picture.Image = Image.FromFile(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BRemove_Click(sender As System.Object, e As System.EventArgs) Handles BRemove.Click
        Picture.Image = My.Resources.photo
    End Sub

    Private Sub BStartCapture_Click(sender As System.Object, e As System.EventArgs) Handles BStartCapture.Click
        Dim k As New frmCamera
        k.ShowDialog()
        If TempFileNames2.Length > 0 Then

            Picture.Image = Image.FromFile(TempFileNames2)
            Photoname = TempFileNames2
            IsImageChanged = True
        End If
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Reset()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Try
            If Len(Trim(txtStaffName.Text)) = 0 Then
                MessageBox.Show("Please enter staff name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtStaffName.Focus()
                Exit Sub
            End If
            If rbMale.Checked = False And rbFemale.Checked = False Then
                MessageBox.Show("Please select gender", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
                Exit Sub
            End If
            If Len(Trim(txtFatherName.Text)) = 0 Then
                MessageBox.Show("Please enter father's name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtFatherName.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbDesignation.Text)) = 0 Then
                MessageBox.Show("Please select designation", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbDesignation.Focus()
                Exit Sub
            End If
            If Len(Trim(txtTempAddress.Text)) = 0 Then
                MessageBox.Show("Please enter temporary address", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtTempAddress.Focus()
                Exit Sub
            End If
            If Len(Trim(txtPermanentAddress.Text)) = 0 Then
                MessageBox.Show("Please enter permanent address", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPermanentAddress.Focus()
                Exit Sub
            End If
            If Len(Trim(txtMobileNo.Text)) = 0 Then
                MessageBox.Show("Please enter mobile no.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtMobileNo.Focus()
                Exit Sub
            End If
            If Len(Trim(txtBasicSalary.Text)) = 0 Then
                MessageBox.Show("Please enter basic salary", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtBasicSalary.Focus()
                Exit Sub
            End If
            If ListView1.Items.Count = 0 Then
                MessageBox.Show("Please add department to listview", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbDepartment.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbSchoolName.Text)) = 0 Then
                MessageBox.Show("Please select school name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbSchoolName.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbClassType.Text)) = 0 Then
                MessageBox.Show("Please select class type", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbClassType.Focus()
                Exit Sub
            End If
            If Len(Trim(txtAccountName.Text)) = 0 Then
                MessageBox.Show("Please enter account name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtAccountName.Focus()
                Exit Sub
            End If
            If Len(Trim(txtAccountNo.Text)) = 0 Then
                MessageBox.Show("Please enter account no.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtAccountNo.Focus()
                Exit Sub
            End If
            If Len(Trim(txtBank.Text)) = 0 Then
                MessageBox.Show("Please enter bank", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtBank.Focus()
                Exit Sub
            End If
            If Len(Trim(txtBranch.Text)) = 0 Then
                MessageBox.Show("Please enter branch", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtBranch.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbStatus.Text)) = 0 Then
                MessageBox.Show("Please select status", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbStatus.Focus()
                Exit Sub
            End If
            If rbMale.Checked = True Then
                gender = rbMale.Text
            End If
            If rbFemale.Checked = True Then
                gender = rbFemale.Text
            End If
            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "insert into Staff( St_ID, StaffID, StaffName, DateOfJoining, Gender, FatherName, TemporaryAddress, PermanentAddress, Designation, Qualifications, DOB, PhoneNo, MobileNo, Email, Photo,Status,SchoolID,ClassType,Salary,AccountName,AccountNumber,Bank,Branch,IFSCcode) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12,@d13,@d14,@d15,'" & cmbStatus.Text & "',@d16,@d17,@d18,@d19,@d20,@d21,@d22,@d23)"
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtID.Text)
            cmd.Parameters.AddWithValue("@d2", txtStaffID.Text)
            cmd.Parameters.AddWithValue("@d3", txtStaffName.Text)
            cmd.Parameters.AddWithValue("@d4", dtpDateOfJoining.Text)
            cmd.Parameters.AddWithValue("@d5", gender)
            cmd.Parameters.AddWithValue("@d6", txtFatherName.Text)
            cmd.Parameters.AddWithValue("@d7", txtTempAddress.Text)
            cmd.Parameters.AddWithValue("@d8", txtPermanentAddress.Text)
            cmd.Parameters.AddWithValue("@d9", cmbDesignation.Text)
            cmd.Parameters.AddWithValue("@d10", txtQualifications.Text)
            cmd.Parameters.AddWithValue("@d11", dtpDOB.Text)
            cmd.Parameters.AddWithValue("@d12", txtPhoneNo.Text)
            cmd.Parameters.AddWithValue("@d13", txtMobileNo.Text)
            cmd.Parameters.AddWithValue("@d14", txtEmail.Text)
            cmd.Parameters.AddWithValue("@d16", txtSchoolID.Text)
            cmd.Parameters.AddWithValue("@d17", cmbClassType.Text)
            cmd.Parameters.AddWithValue("@d18", txtBasicSalary.Text)
            cmd.Parameters.AddWithValue("@d19", txtAccountName.Text)
            cmd.Parameters.AddWithValue("@d20", txtAccountNo.Text)
            cmd.Parameters.AddWithValue("@d21", txtBank.Text)
            cmd.Parameters.AddWithValue("@d22", txtBranch.Text)
            cmd.Parameters.AddWithValue("@d23", txtIFSCcode.Text)
            Dim ms As New MemoryStream()
            Dim bmpImage As New Bitmap(Picture.Image)
            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim data As Byte() = ms.GetBuffer()
            Dim p As New SqlParameter("@d15", SqlDbType.Image)
            p.Value = data
            cmd.Parameters.Add(p)
            cmd.ExecuteNonQuery()
            For i = 0 To ListView1.Items.Count - 1
                con = New SqlConnection(cs)
                Dim cd As String = "insert Into Staff_Department(StaffID,DepartmentID) VALUES (@d1,@d2)"
                cmd = New SqlCommand(cd)
                cmd.Connection = con
                cmd.Parameters.AddWithValue("@d1", txtID.Text)
                cmd.Parameters.AddWithValue("@d2", CInt(ListView1.Items(i).SubItems(1).Text))
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            Next
            con = New SqlConnection(cs)
            con.Open()
            Dim cb1 As String = "insert into Cards_Staff(StaffID) VALUES (@d1)"
            cmd = New SqlCommand(cb1)
            cmd.Parameters.AddWithValue("@d1", txtID.Text)
            cmd.Connection = con
            cmd.ExecuteReader()
            con.Close()
            con = New SqlConnection(cs)
            con.Open()
            Dim cb2 As String = "insert into NoDues_Staff(StaffID) VALUES (@d1)"
            cmd = New SqlCommand(cb2)
            cmd.Parameters.AddWithValue("@d1", txtID.Text)
            cmd.Connection = con
            cmd.ExecuteReader()
            con.Close()
            con = New SqlConnection(cs)
            con.Open()
            Dim cb3 As String = "insert into Discount_Staff(StaffID,Discount) VALUES (@d1,0.00)"
            cmd = New SqlCommand(cb3)
            cmd.Parameters.AddWithValue("@d1", txtID.Text)
            cmd.Connection = con
            cmd.ExecuteReader()
            con.Close()
            LogFunc(lblUser.Text, "added new staff '" & txtStaffName.Text & "' has staff id '" & txtStaffID.Text & "'")
            MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnSave.Enabled = False
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Close()

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
    Public Sub DeleteRecord()
        Try
            Dim RowsAffected As Integer = 0
            con = New SqlConnection(cs)
            con.Open()
            Dim cq As String = "delete from Staff where St_ID=@d1"
            cmd = New SqlCommand(cq)
            cmd.Parameters.AddWithValue("@d1", txtID.Text)
            cmd.Connection = con
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                LogFunc(lblUser.Text, "deleted the staff '" & txtStaffName.Text & "' has staff id '" & txtStaffID.Text & "'")
                MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
        Try
            If Len(Trim(txtStaffName.Text)) = 0 Then
                MessageBox.Show("Please enter staff name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtStaffName.Focus()
                Exit Sub
            End If
            If rbMale.Checked = False And rbFemale.Checked = False Then
                MessageBox.Show("Please select gender", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
                Exit Sub
            End If
            If Len(Trim(txtFatherName.Text)) = 0 Then
                MessageBox.Show("Please enter father's name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtFatherName.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbDesignation.Text)) = 0 Then
                MessageBox.Show("Please select designation", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbDesignation.Focus()
                Exit Sub
            End If
            If Len(Trim(txtTempAddress.Text)) = 0 Then
                MessageBox.Show("Please enter temporary address", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtTempAddress.Focus()
                Exit Sub
            End If
            If Len(Trim(txtPermanentAddress.Text)) = 0 Then
                MessageBox.Show("Please enter permanent address", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPermanentAddress.Focus()
                Exit Sub
            End If
            If Len(Trim(txtMobileNo.Text)) = 0 Then
                MessageBox.Show("Please enter mobile no.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtMobileNo.Focus()
                Exit Sub
            End If
            If Len(Trim(txtBasicSalary.Text)) = 0 Then
                MessageBox.Show("Please enter basic salary", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtBasicSalary.Focus()
                Exit Sub
            End If
            If ListView1.Items.Count = 0 Then
                MessageBox.Show("Please add department to listview", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbDepartment.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbSchoolName.Text)) = 0 Then
                MessageBox.Show("Please select school name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbSchoolName.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbClassType.Text)) = 0 Then
                MessageBox.Show("Please select class type", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbClassType.Focus()
                Exit Sub
            End If
            If Len(Trim(txtAccountName.Text)) = 0 Then
                MessageBox.Show("Please enter account name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtAccountName.Focus()
                Exit Sub
            End If
            If Len(Trim(txtAccountNo.Text)) = 0 Then
                MessageBox.Show("Please enter account no.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtAccountNo.Focus()
                Exit Sub
            End If
            If Len(Trim(txtBank.Text)) = 0 Then
                MessageBox.Show("Please enter bank", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtBank.Focus()
                Exit Sub
            End If
            If Len(Trim(txtBranch.Text)) = 0 Then
                MessageBox.Show("Please enter branch", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtBranch.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbStatus.Text)) = 0 Then
                MessageBox.Show("Please select status", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbStatus.Focus()
                Exit Sub
            End If
            If rbMale.Checked = True Then
                gender = rbMale.Text
            End If
            If rbFemale.Checked = True Then
                gender = rbFemale.Text
            End If
            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "Update Staff set StaffID=@d2, StaffName=@d3, DateOfJoining=@d4, Gender=@d5, FatherName=@d6, TemporaryAddress=@d7, PermanentAddress=@d8, Designation=@d9, Qualifications=@d10, DOB=@d11, PhoneNo=@d12, MobileNo=@d13, Email=@d14, Photo=@d15,Status='" & cmbStatus.Text & "',SchoolID=@d16,ClassType=@d17,Salary=@d18,AccountName=@d19,AccountNumber=@d20,Bank=@d21,Branch=@d22,IFSCcode=@d23 where St_ID=" & txtID.Text & ""
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d2", txtStaffID.Text)
            cmd.Parameters.AddWithValue("@d3", txtStaffName.Text)
            cmd.Parameters.AddWithValue("@d4", dtpDateOfJoining.Text)
            cmd.Parameters.AddWithValue("@d5", gender)
            cmd.Parameters.AddWithValue("@d6", txtFatherName.Text)
            cmd.Parameters.AddWithValue("@d7", txtTempAddress.Text)
            cmd.Parameters.AddWithValue("@d8", txtPermanentAddress.Text)
            cmd.Parameters.AddWithValue("@d9", cmbDesignation.Text)
            cmd.Parameters.AddWithValue("@d10", txtQualifications.Text)
            cmd.Parameters.AddWithValue("@d11", dtpDOB.Text)
            cmd.Parameters.AddWithValue("@d12", txtPhoneNo.Text)
            cmd.Parameters.AddWithValue("@d13", txtMobileNo.Text)
            cmd.Parameters.AddWithValue("@d14", txtEmail.Text)
            cmd.Parameters.AddWithValue("@d16", txtSchoolID.Text)
            cmd.Parameters.AddWithValue("@d17", cmbClassType.Text)
            cmd.Parameters.AddWithValue("@d18", txtBasicSalary.Text)
            cmd.Parameters.AddWithValue("@d19", txtAccountName.Text)
            cmd.Parameters.AddWithValue("@d20", txtAccountNo.Text)
            cmd.Parameters.AddWithValue("@d21", txtBank.Text)
            cmd.Parameters.AddWithValue("@d22", txtBranch.Text)
            cmd.Parameters.AddWithValue("@d23", txtIFSCcode.Text)
            Dim ms As New MemoryStream()
            Dim bmpImage As New Bitmap(Picture.Image)
            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim data As Byte() = ms.GetBuffer()
            Dim p As New SqlParameter("@d15", SqlDbType.Image)
            p.Value = data
            cmd.Parameters.Add(p)
            cmd.ExecuteNonQuery()
            con = New SqlConnection(cs)
            con.Open()
            Dim cb1 As String = "delete from Staff_Department where StaffID=" & txtID.Text & ""
            cmd = New SqlCommand(cb1)
            cmd.Connection = con
            cmd.ExecuteReader()
            con.Close()
            For i = 0 To ListView1.Items.Count - 1
                con = New SqlConnection(cs)
                Dim cd As String = "insert Into Staff_Department(StaffID,DepartmentID) VALUES (@d1,@d2)"
                cmd = New SqlCommand(cd)
                cmd.Connection = con
                cmd.Parameters.AddWithValue("@d1", txtID.Text)
                cmd.Parameters.AddWithValue("@d2", CInt(ListView1.Items(i).SubItems(1).Text))
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            Next
            LogFunc(lblUser.Text, "updated the staff '" & txtStaffName.Text & "' has staff id '" & txtStaffID.Text & "'")
            MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnUpdate.Enabled = False
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Try
            If Len(Trim(cmbDepartment.Text)) = 0 Then
                MessageBox.Show("Please select department", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbDepartment.Focus()
                Exit Sub
            End If
            Dim temp As Integer
            temp = ListView1.Items.Count()
            If temp = 0 Then
                Dim i As Integer
                Dim lst As New ListViewItem(i)
                lst.SubItems.Add(txtDepartmentID.Text)
                lst.SubItems.Add(cmbDepartment.Text)
                ListView1.Items.Add(lst)
                i = i + 1
                cmbDepartment.SelectedIndex = -1
                Exit Sub
            End If
            For j = 0 To temp - 1
                If (ListView1.Items(j).SubItems(2).Text = cmbDepartment.Text) Then
                    MessageBox.Show("Department already added", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Next j
            Dim k As Integer
            Dim lst1 As New ListViewItem(k)
            lst1.SubItems.Add(txtDepartmentID.Text)
            lst1.SubItems.Add(cmbDepartment.Text)
            ListView1.Items.Add(lst1)
            k = k + 1
            cmbDepartment.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click
        Try
            If (ListView1.SelectedItems.Count > 0) Then
                Dim itmCnt, i, t As Integer
                ListView1.FocusedItem.Remove()
                itmCnt = ListView1.Items.Count
                t = 1
                For i = 1 To itmCnt + 1

                    'Dim lst1 As New ListViewItem(i)
                    'ListView1.Items(i).SubItems(0).Text = t
                    t = t + 1
                Next
                btnRemove.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        btnRemove.Enabled = True
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Sub fillDesignation()
        Try
            con = New SqlConnection(cs)
            con.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct (Designation) FROM Designation", con)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbDesignation.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbDesignation.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub fillDepartment()
        Try
            con = New SqlConnection(cs)
            con.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct (Departmentname) FROM Department", con)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbDepartment.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbDepartment.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub frmStudent_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        fillDepartment()
        fillDesignation()
        fillClassType()
        fillSchool()
    End Sub

    Private Sub btnGetData_Click(sender As System.Object, e As System.EventArgs) Handles btnGetData.Click
        frmStaffRecord.Reset()
        frmStaffRecord.lblSet.Text = "Staff Entry"
        frmStaffRecord.ShowDialog()
    End Sub

    Private Sub cmbDepartment_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbDepartment.SelectedIndexChanged
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandText = "SELECT ID FROM Department where DepartmentName=@d1"
            cmd.Parameters.AddWithValue("@d1", cmbDepartment.Text)
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                txtDepartmentID.Text = rdr.GetValue(0)
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

    Private Sub txtBasicSalary_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtBasicSalary.KeyPress
        Dim keyChar = e.KeyChar

        If Char.IsControl(keyChar) Then
            'Allow all control characters.
        ElseIf Char.IsDigit(keyChar) OrElse keyChar = "."c Then
            Dim text = Me.txtBasicSalary.Text
            Dim selectionStart = Me.txtBasicSalary.SelectionStart
            Dim selectionLength = Me.txtBasicSalary.SelectionLength

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
End Class

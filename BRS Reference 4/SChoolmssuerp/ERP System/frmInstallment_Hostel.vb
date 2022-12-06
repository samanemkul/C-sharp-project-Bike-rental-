Imports System.Data.SqlClient
Public Class frmInstallment_Hostel
    Private Sub auto()
        Try
            Dim Num As Integer = 0
            con = New SqlConnection(cs)
            con.Open()
            Dim sql As String = ("SELECT MAX(IH_ID) FROM Installment_Hostel")
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
        txtInstallment.Text = ""
        cmbHostel.SelectedIndex = -1
        cmbClass.SelectedIndex = -1
        cmbSchoolName.SelectedIndex = -1
        txtSearchByClass.Text = ""
        txtCharges.Text = ""
        txtInstallment.Focus()
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        Getdata()
        auto()
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If Len(Trim(txtInstallment.Text)) = 0 Then
            MessageBox.Show("Please enter installment", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtInstallment.Focus()
            Exit Sub
        End If
        If Len(Trim(cmbHostel.Text)) = 0 Then
            MessageBox.Show("Please select hostel", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbHostel.Focus()
            Exit Sub
        End If
        If Len(Trim(cmbSchoolName.Text)) = 0 Then
            MessageBox.Show("Please select school name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbSchoolName.Focus()
            Exit Sub
        End If
        If Len(Trim(cmbClass.Text)) = 0 Then
            MessageBox.Show("Please select class", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbClass.Focus()
            Exit Sub
        End If
        If Len(Trim(txtCharges.Text)) = 0 Then
            MessageBox.Show("Please enter charges", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCharges.Focus()
            Exit Sub
        End If
        Try
            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "select Installment,HostelID,SchoolID,ClassName from Installment_Hostel,HostelInfo,SchoolInfo,Class where Class.Classname=Installment_Hostel.Class and HostelInfo.HI_ID=Installment_Hostel.HostelID and SchoolInfo.S_ID=Installment_Hostel.SchoolID and Installment=@d1 and HostelID=@d2 and SchoolID=@d3 and ClassName=@d4"
            cmd = New SqlCommand(ct)
            cmd.Parameters.AddWithValue("@d1", txtInstallment.Text)
            cmd.Parameters.AddWithValue("@d2", txtHostelID.Text)
            cmd.Parameters.AddWithValue("@d3", txtSchoolID.Text)
            cmd.Parameters.AddWithValue("@d4", cmbClass.Text)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                MessageBox.Show("Record Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                If (rdr IsNot Nothing) Then
                    rdr.Close()
                End If
                Return
            End If
            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "insert into Installment_Hostel(IH_ID,Installment,Charges,HostelID,SchoolID,Class) VALUES (" & txtID.Text & ",@d1,@d2," & txtHostelID.Text & ",@d3,@d4)"
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtInstallment.Text)
            cmd.Parameters.AddWithValue("@d2", txtCharges.Text)
            cmd.Parameters.AddWithValue("@d3", txtSchoolID.Text)
            cmd.Parameters.AddWithValue("@d4", cmbClass.Text)
            cmd.ExecuteReader()
            con.Close()
            LogFunc(lblUser.Text, "added the new Installment '" & txtInstallment.Text & "' for hostel '" & cmbHostel.Text & "'")
            MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Getdata()
            Autocomplete()
            auto()
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
            con.Open()
            Dim cl As String = "select InstallmentID from Installment_Hostel,HostelFeePayment where Installment_Hostel.IH_ID=HostelFeePayment.InstallmentID and InstallmentID=@d1"
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
            Dim RowsAffected As Integer = 0
            con = New SqlConnection(cs)
            con.Open()
            Dim cq As String = "delete from Installment_Hostel where IH_ID=@d1"
            cmd = New SqlCommand(cq)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtID.Text)
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                LogFunc(lblUser.Text, "deleted the Installment '" & txtInstallment.Text & "' of hostel '" & cmbHostel.Text & "'")
                MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Getdata()
                Reset()
                Autocomplete()
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
    Sub fillCombo()
        Try
            con = New SqlConnection(cs)
            con.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct RTRIM(Hostelname) FROM HostelInfo", con)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbHostel.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbHostel.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        If Len(Trim(txtInstallment.Text)) = 0 Then
            MessageBox.Show("Please enter installment", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtInstallment.Focus()
            Exit Sub
        End If
        If Len(Trim(cmbHostel.Text)) = 0 Then
            MessageBox.Show("Please select hostel", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbHostel.Focus()
            Exit Sub
        End If
        If Len(Trim(cmbSchoolName.Text)) = 0 Then
            MessageBox.Show("Please select school name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbSchoolName.Focus()
            Exit Sub
        End If
        If Len(Trim(cmbClass.Text)) = 0 Then
            MessageBox.Show("Please select class", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbClass.Focus()
            Exit Sub
        End If
        If Len(Trim(txtCharges.Text)) = 0 Then
            MessageBox.Show("Please enter charges", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCharges.Focus()
            Exit Sub
        End If
        Try
            con = New SqlConnection(cs)
            con.Open() '
            Dim cb As String = "Update Installment_Hostel set Installment=@d1,Charges=@d2,HostelID=" & txtHostelID.Text & ",SchoolID=@d3,Class=@d4 where IH_ID=" & txtID.Text & ""
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtInstallment.Text)
            cmd.Parameters.AddWithValue("@d2", txtCharges.Text)
            cmd.Parameters.AddWithValue("@d3", txtSchoolID.Text)
            cmd.Parameters.AddWithValue("@d4", cmbClass.Text)
            cmd.ExecuteReader()
            con.Close()
            LogFunc(lblUser.Text, "updated the Installment '" & txtInstallment.Text & "' of hostel '" & cmbHostel.Text & "'")
            MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnUpdate.Enabled = False
            Getdata()
            Autocomplete()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub
    Public Sub Getdata()
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("SELECT RTRIM(IH_ID), RTRIM(Installment),RTRIM(HostelID),RTRIM(HostelName),RTRIM(SchoolID),RTRIM(Schoolname),RTRIM(ClassName),RTRIM(Charges) from Installment_Hostel,HostelInfo,SchoolInfo,Class where Class.Classname=Installment_Hostel.Class and HostelInfo.HI_ID=Installment_Hostel.HostelID and SchoolInfo.S_ID=Installment_Hostel.SchoolID order by HostelName,Installment", con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            While (rdr.Read() = True)
                dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5), rdr(6), rdr(7))
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

    Private Sub frmCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Getdata()
        fillCombo()
        fillClass()
        fillSchool()
        Autocomplete()
    End Sub
    Sub Autocomplete()
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("SELECT Distinct Installment from Installment_Hostel", con)
            ds = New DataSet()
            adp = New SqlDataAdapter(cmd)
            adp.Fill(ds, "Installment")
            Dim col As AutoCompleteStringCollection = New AutoCompleteStringCollection()
            Dim i As Integer = 0
            For i = 0 To ds.Tables(0).Rows.Count - 1
                col.Add(ds.Tables(0).Rows(i)("Installment").ToString())
            Next
            txtInstallment.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtInstallment.AutoCompleteCustomSource = col
            txtInstallment.AutoCompleteMode = AutoCompleteMode.Suggest
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub
    Private Sub dgw_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgw.MouseClick
        Try
            Dim dr As DataGridViewRow = dgw.SelectedRows(0)
            txtInstallment.Text = dr.Cells(1).Value.ToString()
            txtID.Text = dr.Cells(0).Value.ToString()
            txtHostelID.Text = dr.Cells(2).Value.ToString()
            cmbHostel.Text = dr.Cells(3).Value.ToString()
            txtSchoolID.Text = dr.Cells(4).Value.ToString()
            cmbSchoolName.Text = dr.Cells(5).Value.ToString()
            cmbClass.Text = dr.Cells(6).Value.ToString()
            txtCharges.Text = dr.Cells(7).Value.ToString()
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
            btnSave.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub txtFee_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCharges.KeyPress
        Dim keyChar = e.KeyChar

        If Char.IsControl(keyChar) Then
            'Allow all control characters.
        ElseIf Char.IsDigit(keyChar) OrElse keyChar = "."c Then
            Dim text = Me.txtCharges.Text
            Dim selectionStart = Me.txtCharges.SelectionStart
            Dim selectionLength = Me.txtCharges.SelectionLength

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

    Private Sub cmbHostel_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbHostel.SelectedIndexChanged
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandText = "SELECT HI_ID FROM HostelInfo where HostelName=@d1"
            cmd.Parameters.AddWithValue("@d1", cmbHostel.Text)
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

    Private Sub txtInstallment_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtInstallment.TextChanged
        txtInstallment.Text = txtInstallment.Text.Trim()
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
    Sub fillClass()
        Try
            con = New SqlConnection(cs)
            con.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct RTRIM(ClassName) FROM Class", con)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbClass.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbClass.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtSearchByClass_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSearchByClass.TextChanged
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("SELECT RTRIM(IH_ID), RTRIM(Installment),RTRIM(HostelID),RTRIM(HostelName),RTRIM(SchoolID),RTRIM(Schoolname),RTRIM(Class),RTRIM(Charges) from Installment_Hostel,HostelInfo,SchoolInfo,Class where Class.Classname=Installment_Hostel.Class and HostelInfo.HI_ID=Installment_Hostel.HostelID and SchoolInfo.S_ID=Installment_Hostel.SchoolID and Installment_Hostel.Class like '" & txtSearchByClass.Text & "%' order by HostelName,Installment", con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            While (rdr.Read() = True)
                dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5), rdr(6), rdr(7))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click

    End Sub
End Class

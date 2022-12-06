Imports System.Data.SqlClient
Public Class frmClassFeeInfo
    Private Sub auto()
        Try
            Dim Num As Integer = 0
            con = New SqlConnection(cs)
            con.Open()
            Dim sql As String = ("SELECT MAX(C_ID) FROM CourseFee")
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
    Sub fillFeeName()
        Try
            con = New SqlConnection(cs)
            con.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct RTRIM(FeeName) FROM Fee", con)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbFeeName.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbFeeName.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub Reset()
        cmbClass.SelectedIndex = -1
        cmbFeeName.SelectedIndex = -1
        cmbSemester.SelectedIndex = -1
        cmbSchoolName.SelectedIndex = -1
        txtFee.Text = ""
        txtSearchByClass.Text = ""
        txtSearchByFeeName.Text = ""
        cmbClass.Focus()
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

        If Len(Trim(cmbClass.Text)) = 0 Then
            MessageBox.Show("Please select Class", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbClass.Focus()
            Exit Sub
        End If
        If Len(Trim(cmbFeeName.Text)) = 0 Then
            MessageBox.Show("Please select Fee Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbFeeName.Focus()
            Exit Sub
        End If
        If Len(Trim(cmbSchoolName.Text)) = 0 Then
            MessageBox.Show("Please select school name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbSchoolName.Focus()
            Exit Sub
        End If
        If Len(Trim(cmbSemester.Text)) = 0 Then
            MessageBox.Show("Please select Semester", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbSemester.Focus()
            Exit Sub
        End If
        If Len(Trim(txtFee.Text)) = 0 Then
            MessageBox.Show("Please enter fee", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtFee.Focus()
            Exit Sub
        End If
        Try
            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "select CourseFee.Class,Feename,Semester,SchoolID from CourseFee where Class=@d1 and Feename=@d2 and Semester=@d3 and SchoolID=" & txtSchoolID.Text & ""
            cmd = New SqlCommand(ct)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", cmbClass.Text)
            cmd.Parameters.AddWithValue("@d2", cmbFeeName.Text)
            cmd.Parameters.AddWithValue("@d3", cmbSemester.Text)
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
            Dim cb As String = "insert into CourseFee(C_ID,Class,Feename,Semester,Fee,SchoolID) VALUES (" & txtID.Text & ",@d1,@d2,@d3,@d4," & txtSchoolID.Text & ")"
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", cmbClass.Text)
            cmd.Parameters.AddWithValue("@d2", cmbFeeName.Text)
            cmd.Parameters.AddWithValue("@d3", cmbSemester.Text)
            cmd.Parameters.AddWithValue("@d4", txtFee.Text)
            cmd.ExecuteReader()
            con.Close()
            LogFunc(lblUser.Text, "added the new Course Fee having Fee Name '" & cmbFeeName.Text & "' for Class '" & cmbClass.Text & "' and Semester='" & cmbSemester.Text & "' and School '" & cmbSchoolName.Text & "'")
            MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Getdata()
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

            Dim RowsAffected As Integer = 0
            con = New SqlConnection(cs)
            con.Open()
            Dim cq As String = "delete from CourseFee where C_ID=@d1"
            cmd = New SqlCommand(cq)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtID.Text)
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                LogFunc(lblUser.Text, "deleted the Course Fee having Fee Name '" & cmbFeeName.Text & "' for Class '" & cmbClass.Text & "' and Semester='" & cmbSemester.Text & "' and School '" & cmbSchoolName.Text & "'")
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
        If Len(Trim(cmbClass.Text)) = 0 Then
            MessageBox.Show("Please select Class", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbClass.Focus()
            Exit Sub
        End If
        If Len(Trim(cmbFeeName.Text)) = 0 Then
            MessageBox.Show("Please select Fee Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbFeeName.Focus()
            Exit Sub
        End If
        If Len(Trim(cmbSchoolName.Text)) = 0 Then
            MessageBox.Show("Please select school name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbSchoolName.Focus()
            Exit Sub
        End If
        If Len(Trim(cmbSemester.Text)) = 0 Then
            MessageBox.Show("Please select Semester", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbSemester.Focus()
            Exit Sub
        End If
        If Len(Trim(txtFee.Text)) = 0 Then
            MessageBox.Show("Please enter fee", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtFee.Focus()
            Exit Sub
        End If
        Try
            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "Update CourseFee set Class=@d1,Feename=@d2,Semester=@d3,Fee=@d4,SchoolID=" & txtSchoolID.Text & " where C_ID=" & txtID.Text & ""
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", cmbClass.Text)
            cmd.Parameters.AddWithValue("@d2", cmbFeeName.Text)
            cmd.Parameters.AddWithValue("@d3", cmbSemester.Text)
            cmd.Parameters.AddWithValue("@d4", txtFee.Text)
            cmd.ExecuteReader()
            con.Close()
            LogFunc(lblUser.Text, "updated the Course Fee having Fee Name '" & cmbFeeName.Text & "' for Class '" & cmbClass.Text & "' and Semester='" & cmbSemester.Text & "' and School '" & cmbSchoolName.Text & "'")
            MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            cmd = New SqlCommand("SELECT RTRIM(C_ID), RTRIM(CourseFee.Class), RTRIM(Feename),RTRIM(SchoolID),RTRIM(SchoolName),RTRIM(Semester),RTRIM(Fee) from CourseFee,SchoolInfo where SchoolInfo.S_ID=CourseFee.SchoolID order by CourseFee.Class,FeeName", con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            While (rdr.Read() = True)
                dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5), rdr(6))
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
        fillClass()
        fillFeeName()
        fillSchool()
    End Sub

    Private Sub dgw_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgw.MouseClick
        Try
            Dim dr As DataGridViewRow = dgw.SelectedRows(0)
            cmbClass.Text = dr.Cells(1).Value.ToString()
            txtID.Text = dr.Cells(0).Value.ToString()
            cmbFeeName.Text = dr.Cells(2).Value.ToString()
            txtSchoolID.Text = dr.Cells(3).Value.ToString()
            cmbSchoolName.Text = dr.Cells(4).Value.ToString()
            cmbSemester.Text = dr.Cells(5).Value.ToString()
            txtFee.Text = dr.Cells(6).Value.ToString()
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
            btnSave.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtSearchByClass_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSearchByClass.TextChanged
        Try
            con = New SqlConnection(cs)
                con.Open()
            cmd = New SqlCommand("SELECT RTRIM(C_ID), RTRIM(CourseFee.Class), RTRIM(Feename),RTRIM(SchoolID),RTRIM(SchoolName),RTRIM(Semester),RTRIM(Fee) from CourseFee,SchoolInfo where SchoolInfo.S_ID=CourseFee.SchoolID and CourseFee.Class like '" & txtSearchByClass.Text & "%' order by CourseFee.Class,FeeName", con)
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                dgw.Rows.Clear()
                While (rdr.Read() = True)
                    dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5), rdr(6))
                End While
                con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtSearchByFeeName_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSearchByFeeName.TextChanged
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("SELECT RTRIM(C_ID), RTRIM(CourseFee.Class), RTRIM(Feename),RTRIM(SchoolID),RTRIM(SchoolName),RTRIM(Semester),RTRIM(Fee) from CourseFee,SchoolInfo where SchoolInfo.S_ID=CourseFee.SchoolID and CourseFee.FeeName like '" & txtSearchByFeeName.Text & "%' order by CourseFee.Class,FeeName", con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            While (rdr.Read() = True)
                dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5), rdr(6))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtFee_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtFee.KeyPress
        Dim keyChar = e.KeyChar

        If Char.IsControl(keyChar) Then
            'Allow all control characters.
        ElseIf Char.IsDigit(keyChar) OrElse keyChar = "."c Then
            Dim text = Me.txtFee.Text
            Dim selectionStart = Me.txtFee.SelectionStart
            Dim selectionLength = Me.txtFee.SelectionLength

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
End Class

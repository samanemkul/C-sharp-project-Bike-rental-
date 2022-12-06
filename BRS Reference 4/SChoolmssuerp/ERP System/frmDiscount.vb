Imports System.Data.SqlClient
Public Class frmDiscount
    Sub fillSession()
        Try
            con = New SqlConnection(cs)
            con.Open()
            adp = New sqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct (session) FROM Student", con)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbSession.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbSession.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Sub Reset()
        cmbClass.SelectedIndex = -1
        cmbSection.SelectedIndex = -1
        cmbSession.SelectedIndex = -1
        cmbFeeType.SelectedIndex = -1
        dgw.Rows.Clear()
        cmbClass.Enabled = False
        cmbSection.Enabled = False
        btnUpdate.Enabled = False
    End Sub
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Reset()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            If MessageBox.Show("Do you really want to update the records?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                update_records()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub update_records()
        Try
            If Len(Trim(cmbFeeType.Text)) = 0 Then
                MessageBox.Show("Please select fee type", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbFeeType.Focus()
                Exit Sub
            End If
            If dgw.Rows.Count = 0 Then
                MessageBox.Show("Sorry nothing to update.." & vbCrLf & "Please retrieve data in datagridview", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "delete from discount where admissionNo=@d1 and FeeType=@d2"
            cmd = New SqlCommand(cb)
            cmd.Connection = con

            ' Add Parameters to Command Parameters collection
            cmd.Parameters.Add(New SqlParameter("@d1", System.Data.SqlDbType.NChar, 15, "AdmissionNo"))

            cmd.Parameters.Add(New SqlParameter("@d2", System.Data.SqlDbType.NChar, 50, "FeeType"))


            ' Prepare command for repeated execution
            cmd.Prepare()

            ' Data to be inserted
            For Each row As DataGridViewRow In dgw.Rows
                If Not row.IsNewRow Then

                    cmd.Parameters("@d1").Value = row.Cells(0).Value.ToString
                    cmd.Parameters("@d2").Value = cmbFeeType.Text
                    cmd.ExecuteNonQuery()
                End If
            Next
            con.Close()
            con = New SqlConnection(cs)
            con.Open()
            Dim cb1 As String = "insert into Discount(AdmissionNo,FeeType,Discount) VALUES (@d1,@d2,@d3)"
            cmd = New SqlCommand(cb1)
            cmd.Connection = con



            ' Add Parameters to Command Parameters collection
            cmd.Parameters.Add(New SqlParameter("@d1", System.Data.SqlDbType.NChar, 15, "AdmissionNo"))

            cmd.Parameters.Add(New SqlParameter("@d2", System.Data.SqlDbType.NChar, 50, "FeeType"))

            cmd.Parameters.Add(New SqlParameter("@d3", System.Data.SqlDbType.Float, 10, "Discount"))


            ' Prepare command for repeated execution
            cmd.Prepare()

            ' Data to be inserted
            For Each row As DataGridViewRow In dgw.Rows
                If Not row.IsNewRow Then

                    cmd.Parameters("@d1").Value = row.Cells(0).Value.ToString
                    cmd.Parameters("@d2").Value = cmbFeeType.Text
                    cmd.Parameters("@d3").Value = CDbl(row.Cells(3).Value.ToString)
                    cmd.ExecuteNonQuery()
                End If
            Next
            MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnUpdate.Enabled = False
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

    Private Sub frmFeeName_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillSession()
    End Sub

    Private Sub cmbSession_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbSession.SelectedIndexChanged
        Try
            cmbClass.Enabled = True
            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "SELECT distinct RTRIM(ClassName) FROM Student,Section,Class where Student.SectionID=Section.ID and Section.Class=Class.ClassName and session=@d1"
            cmd = New SqlCommand(ct)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", cmbSession.Text)
            rdr = cmd.ExecuteReader()
            cmbClass.Items.Clear()
            While rdr.Read
                cmbClass.Items.Add(rdr(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbClass_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbClass.SelectedIndexChanged
        Try
            cmbSection.Enabled = True
            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "SELECT distinct RTRIM(SectionName) FROM Student,Section,Class where Student.SectionID=Section.ID and Section.Class=Class.ClassName and session=@d1 and ClassName=@d2"
            cmd = New SqlCommand(ct)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", cmbSession.Text)
            cmd.Parameters.AddWithValue("@d2", cmbClass.Text)
            rdr = cmd.ExecuteReader()
            cmbSection.Items.Clear()
            While rdr.Read
                cmbSection.Items.Add(rdr(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnGetData_Click(sender As System.Object, e As System.EventArgs) Handles btnGetData.Click
        Try
            If Len(Trim(cmbSession.Text)) = 0 Then
                MessageBox.Show("Please select session", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbSession.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbClass.Text)) = 0 Then
                MessageBox.Show("Please select class", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbClass.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbSection.Text)) = 0 Then
                MessageBox.Show("Please select section", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbSection.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbFeeType.Text)) = 0 Then
                MessageBox.Show("Please select fee type", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbFeeType.Focus()
                Exit Sub
            End If
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("SELECT RTRIM(Student.AdmissionNo),RTRIM(StudentName),RTRIM(Caste),RTRIM(Discount) from Student,Class,Section,SchoolInfo,Discount where Student.SectionID=Section.ID and Class.Classname=Section.Class and SchoolInfo.S_ID=Student.SchoolID and Discount.AdmissionNo=Student.AdmissionNo and SectionName=@d1 and ClassName=@d2 and Session=@d3 and FeeType='" & cmbFeeType.Text & "' and Status='Active' order by StudentName", con)
            cmd.Parameters.AddWithValue("@d1", cmbSection.Text)
            cmd.Parameters.AddWithValue("@d2", cmbClass.Text)
            cmd.Parameters.AddWithValue("@d3", cmbSession.Text)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            While (rdr.Read() = True)
                dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3))
            End While
            con.Close()
            btnUpdate.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class

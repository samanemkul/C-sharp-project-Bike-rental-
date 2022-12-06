Imports System.Data.SqlClient
Public Class frmInstallment_Bus
    Private Sub auto()
        Try
            Dim Num As Integer = 0
            con = New SqlConnection(cs)
            con.Open()
            Dim sql As String = ("SELECT MAX(IB_ID) FROM Installment_Bus")
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
            adp.SelectCommand = New SqlCommand("SELECT distinct RTRIM(LocationName) FROM Location", con)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbLocation.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbLocation.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub Reset()
        txtInstallment.Text = ""
        cmbLocation.SelectedIndex = -1
        txtCharges.Text = ""
        txtInstallment.Focus()
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        txtSearchByLocation.Text = ""
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
        If Len(Trim(cmbLocation.Text)) = 0 Then
            MessageBox.Show("Please select location", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbLocation.Focus()
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
            Dim ct As String = "select Installment,Location from Installment_Bus where Installment=@d1 and Location=@d2"
            cmd = New SqlCommand(ct)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtInstallment.Text)
            cmd.Parameters.AddWithValue("@d2", cmbLocation.Text)
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
            Dim cb As String = "insert into Installment_Bus(IB_ID,Installment,Charges,Location) VALUES (" & txtID.Text & ",@d1,@d2,@d3)"
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtInstallment.Text)
            cmd.Parameters.AddWithValue("@d2", txtCharges.Text)
            cmd.Parameters.AddWithValue("@d3", cmbLocation.Text)
            cmd.ExecuteReader()
            con.Close()
            LogFunc(lblUser.Text, "added the new Installment '" & txtInstallment.Text & "' for location '" & cmbLocation.Text & "'")
            MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnSave.Enabled = False
            Getdata()
            Autocomplete()
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
            con = New SqlConnection(cs)
            con.Open()
            Dim cl As String = "select InstallmentID from Installment_Bus,HostelFeePayment where Installment_Bus.IB_ID=HostelFeePayment.InstallmentID and InstallmentID=@d1"
            cmd = New SqlCommand(cl)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtID.Text)
            rdr = cmd.ExecuteReader()
            If rdr.Read Then
                MessageBox.Show("Unable to delete..Already in use in Bus Fee Payment [Student]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If
            Dim RowsAffected As Integer = 0
            con = New SqlConnection(cs)
            con.Open()
            Dim cq As String = "delete from Installment_Bus where IB_ID=@d1"
            cmd = New SqlCommand(cq)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtID.Text)
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                LogFunc(lblUser.Text, "deleted the Installment '" & txtInstallment.Text & "' of location '" & cmbLocation.Text & "'")
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

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        If Len(Trim(txtInstallment.Text)) = 0 Then
            MessageBox.Show("Please enter installment", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtInstallment.Focus()
            Exit Sub
        End If
        If Len(Trim(cmbLocation.Text)) = 0 Then
            MessageBox.Show("Please select location", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbLocation.Focus()
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
            Dim cb As String = "Update Installment_Bus set Installment=@d1,Charges=@d2,Location=@d3 where IB_ID=" & txtID.Text & ""
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtInstallment.Text)
            cmd.Parameters.AddWithValue("@d2", txtCharges.Text)
            cmd.Parameters.AddWithValue("@d3", cmbLocation.Text)
            cmd.ExecuteReader()
            con.Close()
            LogFunc(lblUser.Text, "updated the Installment '" & txtInstallment.Text & "' of location '" & cmbLocation.Text & "'")
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
            cmd = New SqlCommand("SELECT RTRIM(IB_ID), RTRIM(Installment),RTRIM(Location),RTRIM(Charges) from Installment_Bus order by Location,installment", con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            While (rdr.Read() = True)
                dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3))
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
        Autocomplete()
    End Sub

    Private Sub dgw_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgw.MouseClick
        Try
            Dim dr As DataGridViewRow = dgw.SelectedRows(0)
            txtInstallment.Text = dr.Cells(1).Value.ToString()
            txtID.Text = dr.Cells(0).Value.ToString()
            cmbLocation.Text = dr.Cells(2).Value.ToString()
            txtCharges.Text = dr.Cells(3).Value.ToString()
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
            btnSave.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub Autocomplete()
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("SELECT Distinct Installment from Installment_Bus", con)
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

    Private Sub txtSearchByLocation_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSearchByLocation.TextChanged
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("SELECT RTRIM(IB_ID), RTRIM(Installment),RTRIM(Location),RTRIM(Charges) from Installment_Bus where Location like '" & txtSearchByLocation.Text & "%' order by Location,installment", con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            While (rdr.Read() = True)
                dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtInstallment_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtInstallment.TextChanged
        txtInstallment.Text = txtInstallment.Text.Trim()
    End Sub
End Class

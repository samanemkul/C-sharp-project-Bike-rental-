Imports System.Data.SqlClient
Imports System.IO

Public Class frmBusInfo
   
    Sub Reset()
        txtDriverName.Text = ""
        txtSupporterName.Text = ""
        txtContactNo.Text = ""
        txtContactNo_S.Text = ""
        txtBus.Text = ""
        txtBusNo.Text = ""
        txtBusNo.Focus()
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtBusNo.Text = "" Then
            MessageBox.Show("Please enter bus no.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtBusNo.Focus()
            Return
        End If
        If txtDriverName.Text = "" Then
            MessageBox.Show("Please enter driver name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDriverName.Focus()
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
            Dim ct As String = "select BusNo from BusInfo where BusNo=@d1"
            cmd = New SqlCommand(ct)
            cmd.Parameters.AddWithValue("@d1", txtBusNo.Text)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()

            If rdr.Read() Then
                MessageBox.Show("Bus no. Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtBusNo.Text = ""
                txtBusNo.Focus()
                If (rdr IsNot Nothing) Then
                    rdr.Close()
                End If
                Return
            End If
            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "insert into BusInfo(BusNo,DriverName,ContactNo,SupporterName,S_ContactNo) VALUES (@d1,@d2,@d3,@d4,@d5)"
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtBusNo.Text)
            cmd.Parameters.AddWithValue("@d2", txtDriverName.Text)
            cmd.Parameters.AddWithValue("@d3", txtContactNo.Text)
            cmd.Parameters.AddWithValue("@d4", txtSupporterName.Text)
            cmd.Parameters.AddWithValue("@d5", txtContactNo_S.Text)
            cmd.ExecuteNonQuery()
            con.Close()
            Dim st As String = "added the new bus having bus no. '" & txtBusNo.Text & "'"
            LogFunc(lblUser.Text, st)
            MessageBox.Show("Successfully saved", "Bus Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnSave.Enabled = False
            Getdata()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub


    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If txtBusNo.Text = "" Then
            MessageBox.Show("Please enter bus no.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtBusNo.Focus()
            Return
        End If
        If txtDriverName.Text = "" Then
            MessageBox.Show("Please enter driver name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDriverName.Focus()
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
            Dim cb As String = "Update BusInfo set BusNo=@d2, DriverName=@d3, ContactNo=@d4, SupporterName=@d5, S_ContactNo=@d6 where BusNo=@d1"
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtBus.Text)
            cmd.Parameters.AddWithValue("@d2", txtBusNo.Text)
            cmd.Parameters.AddWithValue("@d3", txtDriverName.Text)
            cmd.Parameters.AddWithValue("@d4", txtContactNo.Text)
            cmd.Parameters.AddWithValue("@d5", txtSupporterName.Text)
            cmd.Parameters.AddWithValue("@d6", txtContactNo_S.Text)
            cmd.ExecuteNonQuery()
            con.Close()
            Dim st As String = "updated the bus info having bus no. '" & txtBusNo.Text & "'"
            LogFunc(lblUser.Text, st)
            MessageBox.Show("Successfully updated", "Bus Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            cmd = New SqlCommand("SELECT RTRIM(BusNo), RTRIM(DriverName), RTRIM(ContactNo), RTRIM(SupporterName), RTRIM(S_ContactNo) from BusInfo order by BusNo", con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            While (rdr.Read() = True)
                dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4))
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
            txtBus.Text = dr.Cells(0).Value.ToString()
            txtBusNo.Text = dr.Cells(0).Value.ToString()
            txtDriverName.Text = dr.Cells(1).Value.ToString()
            txtContactNo.Text = dr.Cells(2).Value.ToString()
            txtSupporterName.Text = dr.Cells(3).Value.ToString()
            txtContactNo_S.Text = dr.Cells(4).Value.ToString()
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
            Dim cl As String = "select BusInfo.BusNo from BusInfo,BusCardHolder_Student where BusInfo.BusNo=BusCardHolder_Student.BusNo and BusInfo.BusNo=@d1"
            cmd = New SqlCommand(cl)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtBus.Text)
            rdr = cmd.ExecuteReader()
            If rdr.Read Then
                MessageBox.Show("Unable to delete..Already in use in Bus Holder [Student]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If
            con = New SqlConnection(cs)
            con.Open()
            Dim cl1 As String = "select BusInfo.BusNo from BusInfo,BusCardHolder_Staff where BusInfo.BusNo=BusCardHolder_Staff.BusNo and BusInfo.BusNo=@d1"
            cmd = New SqlCommand(cl1)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtBus.Text)
            rdr = cmd.ExecuteReader()
            If rdr.Read Then
                MessageBox.Show("Unable to delete..Already in use in Bus Holder [Staff]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If
            con = New SqlConnection(cs)
            con.Open()
            Dim cq As String = "delete from BusInfo where BusNo=@d1"
            cmd = New SqlCommand(cq)
            cmd.Parameters.AddWithValue("@d1", txtBus.Text)
            cmd.Connection = con
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                Dim st As String = "deleted the bus having bus no. '" & txtBusNo.Text & "'"
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

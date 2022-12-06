Imports System.Data.SqlClient
Public Class frmDiscount_Staff
    Public Sub Getdata()
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("SELECT RTRIM(St_ID),RTRIM(StaffID),RTRIM(StaffName) from Staff order by StaffName", con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            While (rdr.Read() = True)
                dgw.Rows.Add(rdr(0), rdr(1), rdr(2))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Sub Reset()
        Getdata()
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
           
            If dgw.Rows.Count = 0 Then
                MessageBox.Show("Sorry nothing to update.." & vbCrLf & "Please retrieve data in datagridview", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "delete from discount_Staff where StaffID=@d1"
            cmd = New SqlCommand(cb)
            cmd.Connection = con

            ' Add Parameters to Command Parameters collection
            cmd.Parameters.Add(New SqlParameter("@d1", System.Data.SqlDbType.Int, 10, "StaffID"))


            ' Prepare command for repeated execution
            cmd.Prepare()

            ' Data to be inserted
            For Each row As DataGridViewRow In dgw.Rows
                If Not row.IsNewRow Then

                    cmd.Parameters("@d1").Value = row.Cells(0).Value.ToString
                    cmd.ExecuteNonQuery()
                End If
            Next
            con.Close()
            con = New SqlConnection(cs)
            con.Open()
            Dim cb1 As String = "insert into Discount_Staff(StaffID,Discount) VALUES (@d1,@d2)"
            cmd = New SqlCommand(cb1)
            cmd.Connection = con



            ' Add Parameters to Command Parameters collection
            cmd.Parameters.Add(New SqlParameter("@d1", System.Data.SqlDbType.Int, 10, "StaffID"))

            cmd.Parameters.Add(New SqlParameter("@d2", System.Data.SqlDbType.Float, 10, "Discount"))


            ' Prepare command for repeated execution
            cmd.Prepare()

            ' Data to be inserted
            For Each row As DataGridViewRow In dgw.Rows
                If Not row.IsNewRow Then

                    cmd.Parameters("@d1").Value = row.Cells(0).Value.ToString
                    cmd.Parameters("@d2").Value = CDbl(row.Cells(3).Value.ToString)
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
        Getdata()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            btnUpdate.Enabled = True
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("SELECT RTRIM(Staff.St_ID),RTRIM(Staff.StaffID),RTRIM(StaffName),RTRIM(Discount) from Staff,Discount_Staff where Staff.St_ID=Discount_Staff.StaffID order by StaffName", con)
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
End Class

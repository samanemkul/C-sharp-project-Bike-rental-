Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmFeeStructure

  
    Private Sub frmFeeStructure_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        fillSchool()
        fillLocation()
        GetData()
    End Sub

    Sub Reset()
        cmbSchoolName.SelectedIndex = -1
        cmbClass.SelectedIndex = -1
        cmbSemester.SelectedIndex = -1
        cmbClass.Enabled = False
        cmbSemester.Enabled = False
        GroupBox10.Visible = False
        cmbSchoolName1.SelectedIndex = -1
        cmbClass1.SelectedIndex = -1
        cmbClass1.Enabled = False
        GroupBox11.Visible = False
        cmbLocation.SelectedIndex = -1
        GroupBox12.Visible = False
        dgw.Rows.Clear()
        dgw1.Rows.Clear()
        dgw2.Rows.Clear()
        fillSchool()
        fillLocation()
        GetData()
    End Sub

    Private Sub TabControl1_Click(sender As System.Object, e As System.EventArgs) Handles TabControl1.Click
        Reset()
    End Sub

    Private Sub Button16_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        cmbSchoolName.SelectedIndex = -1
        cmbClass.SelectedIndex = -1
        cmbSemester.SelectedIndex = -1
        cmbClass.Enabled = False
        cmbSemester.Enabled = False
        GroupBox10.Visible = False
        dgw.Rows.Clear()
    End Sub

    Private Sub cmbSchoolName_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbSchoolName.SelectedIndexChanged
        Try
            cmbClass.Enabled = True
            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "SELECT distinct CourseFee.Class from CourseFee,SchoolInfo where CourseFee.SchoolID=SchoolInfo.S_ID and SchoolName=@d1"
            cmd = New SqlCommand(ct)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", cmbSchoolName.Text)
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
            cmbSemester.Enabled = True
            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "SELECT distinct Semester from CourseFee,Class,SchoolInfo where Class.Classname=CourseFee.Class and SchoolInfo.S_ID=CourseFee.SchoolID and CourseFee.Class=@d1 and SchoolName=@d2"
            cmd = New SqlCommand(ct)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", cmbClass.Text)
            cmd.Parameters.AddWithValue("@d2", cmbSchoolName.Text)
            rdr = cmd.ExecuteReader()
            cmbSemester.Items.Clear()
            While rdr.Read
                cmbSemester.Items.Add(rdr(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub fillSchool()
        Try
            con = New SqlConnection(cs)
            con.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT RTRIM(SchoolName) FROM SchoolInfo", con)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbSchoolName.Items.Clear()
            cmbSchoolName1.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbSchoolName.Items.Add(drow(0).ToString())
                cmbSchoolName1.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub fillLocation()
        Try
            con = New SqlConnection(cs)
            con.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT Distinct RTRIM(Location) FROM Installment_Bus", con)
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

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
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
            If Len(Trim(cmbSemester.Text)) = 0 Then
                MessageBox.Show("Please select semester", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbSemester.Focus()
                Exit Sub
            End If
            GroupBox10.Visible = True
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("SELECT RTRIM(FeeName),RTRIM(Fee) from Class,CourseFee,SchoolInfo where Class.Classname=CourseFee.Class and CourseFee.SchoolID=SchoolInfo.S_ID and SchoolName=@d1 and CourseFee.Class=@d2 and Semester=@d3 order by FeeName", con)
            cmd.Parameters.AddWithValue("@d1", cmbSchoolName.Text)
            cmd.Parameters.AddWithValue("@d2", cmbClass.Text)
            cmd.Parameters.AddWithValue("@d3", cmbSemester.Text)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            While (rdr.Read() = True)
                dgw.Rows.Add(rdr(0), rdr(1))
            End While
            Dim sum As Double = 0
            For Each r As DataGridViewRow In Me.dgw.Rows
                sum = sum + r.Cells(1).Value
            Next
            Dim num As Double
            num = sum
            num = Math.Round(num, 2)
            txtClassFeeTotal.Text = num
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbSchoolName1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbSchoolName1.SelectedIndexChanged
        Try
            cmbClass1.Enabled = True
            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "SELECT distinct Installment_Hostel.Class from Installment_Hostel,SchoolInfo where Installment_Hostel.SchoolID=SchoolInfo.S_ID and SchoolName=@d1"
            cmd = New SqlCommand(ct)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", cmbSchoolName1.Text)
            rdr = cmd.ExecuteReader()
            cmbClass1.Items.Clear()
            While rdr.Read
                cmbClass1.Items.Add(rdr(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        cmbSchoolName1.SelectedIndex = -1
        cmbClass1.SelectedIndex = -1
        cmbClass1.Enabled = False
        GroupBox11.Visible = False
        dgw1.Rows.Clear()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Try
            If Len(Trim(cmbSchoolName1.Text)) = 0 Then
                MessageBox.Show("Please select school name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbSchoolName1.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbClass1.Text)) = 0 Then
                MessageBox.Show("Please select class", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbClass1.Focus()
                Exit Sub
            End If
            GroupBox11.Visible = True
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("SELECT RTRIM(HostelName),RTRIM(Installment),RTRIM(Charges) from HostelInfo,SchoolInfo,Installment_Hostel,Class where Class.Classname=Installment_Hostel.Class and Installment_Hostel.SchoolID=SchoolInfo.S_ID and HostelInfo.HI_ID=Installment_Hostel.HostelID and SchoolName=@d1 and Installment_Hostel.Class=@d2 order by Hostelname", con)
            cmd.Parameters.AddWithValue("@d1", cmbSchoolName1.Text)
            cmd.Parameters.AddWithValue("@d2", cmbClass1.Text)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw1.Rows.Clear()
            While (rdr.Read() = True)
                dgw1.Rows.Add(rdr(0), rdr(1), rdr(2))
            End While
            Dim sum As Double = 0
            For Each r As DataGridViewRow In Me.dgw1.Rows
                sum = sum + r.Cells(2).Value
            Next
            Dim num As Double
            num = sum
            num = Math.Round(num, 2)
            txtHostelFeeTotal.Text = num
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        cmbLocation.SelectedIndex = -1
        GroupBox12.Visible = False
        dgw2.Rows.Clear()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Try
            If Len(Trim(cmbLocation.Text)) = 0 Then
                MessageBox.Show("Please select location", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbLocation.Focus()
                Exit Sub
            End If
            GroupBox12.Visible = True
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("SELECT RTRIM(Location),RTRIM(Installment),RTRIM(Charges) from Installment_Bus where Location=@d1 order by installment", con)
            cmd.Parameters.AddWithValue("@d1", cmbLocation.Text)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw2.Rows.Clear()
            While (rdr.Read() = True)
                dgw2.Rows.Add(rdr(0), rdr(1), rdr(2))
            End While
            Dim sum As Double = 0
            For Each r As DataGridViewRow In Me.dgw2.Rows
                sum = sum + r.Cells(2).Value
            Next
            Dim num As Double
            num = sum
            num = Math.Round(num, 2)
            txtBusFeeTotal.Text = num
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub GetData()
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("SELECT RTRIM(Location),RTRIM(Installment),RTRIM(Charges) from Installment_Bus order by Location,installment", con)
            cmd.Parameters.AddWithValue("@d1", cmbLocation.Text)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw2.Rows.Clear()
            While (rdr.Read() = True)
                dgw2.Rows.Add(rdr(0), rdr(1), rdr(2))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmClassFeeReceipt
    Sub fillPaymentID()
        Try
            Dim CN As New SqlConnection(cs)
            CN.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct RTRIM(PaymentID) FROM CourseFeePayment", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbPaymentID.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbPaymentID.Items.Add(drow(0).ToString())
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmLogs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillPaymentID()
    End Sub
    Sub Reset()
        cmbPaymentID.Text = ""
        fillPaymentID()
    End Sub
    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        Reset()
    End Sub


    Private Sub btnClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If cmbPaymentID.Text = "" Then
                MessageBox.Show("Please select payment id", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbPaymentID.Focus()
                Exit Sub
            End If
            Cursor = Cursors.WaitCursor
            Timer1.Enabled = True
            Dim rpt As New rptCourseFeeReceipt 'The report you created.
            Dim myConnection As SqlConnection
            Dim MyCommand As New SqlCommand()
            Dim myDA As New SqlDataAdapter()
            Dim myDS As New DataSet 'The DataSet you created.
            myConnection = New SqlConnection(cs)
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "SELECT SchoolInfo.S_Id, SchoolInfo.SchoolName, SchoolInfo.Address, SchoolInfo.ContactNo, SchoolInfo.AltContactNo, SchoolInfo.FaxNo, SchoolInfo.Email, SchoolInfo.Website, SchoolInfo.Logo, SchoolInfo.RegistrationNo,SchoolInfo.DiseNo, SchoolInfo.IndexNo, SchoolInfo.EstablishedYear, Student.AdmissionNo, Student.EnrollmentNo, Student.GRNo, Student.UID, Student.StudentName,Student.FatherName, Student.MotherName, Student.FatherCN, Student.PermanentAddress, Student.TemporaryAddress, Student.EmailID, Student.DOB, Student.Gender,Student.AdmissionDate, Student.Session, Student.Caste, Student.Religion, Student.SectionID, Student.Photo, Student.Nationality, Student.SchoolID, Student.LastSchoolAttended, Student.Result,Student.PassPercentage, CourseFeePayment.Id, CourseFeePayment.CFP_ID, CourseFeePayment.PaymentID,CourseFeePayment.Semester, CourseFeePayment.TotalFee, CourseFeePayment.DiscountPer, CourseFeePayment.DiscountAmt, CourseFeePayment.PreviousDue, CourseFeePayment.Fine,CourseFeePayment.GrandTotal, CourseFeePayment.TotalPaid, CourseFeePayment.ModeOfPayment, CourseFeePayment.PaymentModeDetails, CourseFeePayment.PaymentDate,CourseFeePayment.PaymentDue, CourseFeePayment.ClassType, CourseFeePayment.Class , CourseFeePayment.Section, CourseFeePayment_Join.CFPJ_Id,CourseFeePayment_Join.C_PaymentID, CourseFeePayment_Join.FeeName, CourseFeePayment_Join.Fee FROM SchoolInfo INNER JOIN Student ON SchoolInfo.S_Id = Student.SchoolID INNER JOIN CourseFeePayment ON Student.AdmissionNo = CourseFeePayment.AdmissionNo INNER JOIN CourseFeePayment_Join ON CourseFeePayment.Id = CourseFeePayment_Join.C_PaymentID where PaymentID='" & cmbPaymentID.Text & "'"
            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand
            myDA.Fill(myDS, "Student")
            myDA.Fill(myDS, "CourseFeePayment")
            myDA.Fill(myDS, "SchoolInfo")
            myDA.Fill(myDS, "CourseFeePayment_Join")
            rpt.SetDataSource(myDS)
            frmReport.CrystalReportViewer1.ReportSource = rpt
            frmReport.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Cursor = Cursors.Default
        Timer1.Enabled = False
    End Sub
End Class

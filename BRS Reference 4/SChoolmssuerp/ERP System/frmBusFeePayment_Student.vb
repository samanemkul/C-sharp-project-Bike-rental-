Imports System.Data.SqlClient
Imports System.IO

Public Class frmBusFeePayment_Student
    Sub Calculate()
        Dim num1, num2 As Double
        num1 = CDbl(Val(txtBusFee.Text) + Val(txtFine.Text) + Val(txtPreviousDue.Text) - Val(txtDiscount.Text))
        num1 = Math.Round(num1, 2)
        txtGrandTotal.Text = num1
        num2 = Val(txtGrandTotal.Text) - Val(txtTotalPaid.Text)
        num2 = Math.Round(num2, 2)
        txtBalance.Text = num2
    End Sub
    Sub Print()
        Try
            Cursor = Cursors.WaitCursor
            Timer1.Enabled = True
            Dim rpt As New rptBusFeeReceipt_Student 'The report you created.
            Dim myConnection As SqlConnection
            Dim MyCommand As New SqlCommand()
            Dim myDA As New SqlDataAdapter()
            Dim myDS As New DataSet 'The DataSet you created.
            myConnection = New SqlConnection(cs)
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "SELECT SchoolInfo.S_Id, SchoolInfo.SchoolName, SchoolInfo.Address, SchoolInfo.ContactNo, SchoolInfo.AltContactNo, SchoolInfo.FaxNo, SchoolInfo.Email, SchoolInfo.Website, SchoolInfo.Logo, SchoolInfo.RegistrationNo,SchoolInfo.DiseNo, SchoolInfo.IndexNo, SchoolInfo.EstablishedYear, Student.AdmissionNo, Student.EnrollmentNo, Student.GRNo, Student.UID, Student.StudentName,Student.FatherName, Student.MotherName, Student.FatherCN, Student.PermanentAddress, Student.TemporaryAddress, Student.EmailID, Student.DOB, Student.Gender,Student.AdmissionDate, Student.Caste, Student.Religion, Student.SectionID, Student.Photo, Student.Nationality, Student.SchoolID, Student.LastSchoolAttended, Student.Result,Student.PassPercentage, Student.Status, BusCardHolder_Student.BCH_Id, BusCardHolder_Student.AdmissionNo AS Expr2, BusCardHolder_Student.BusNo, BusCardHolder_Student.Location,BusCardHolder_Student.JoiningDate, BusFeePayment_Student.Id, BusFeePayment_Student.BFP_ID, BusFeePayment_Student.PaymentID,BusFeePayment_Student.BusHolderID, BusFeePayment_Student.Session , BusFeePayment_Student.Installment, BusFeePayment_Student.TotalFee, BusFeePayment_Student.DiscountPer,BusFeePayment_Student.DiscountAmt, BusFeePayment_Student.PreviousDue, BusFeePayment_Student.Fine, BusFeePayment_Student.GrandTotal, BusFeePayment_Student.TotalPaid,BusFeePayment_Student.ModeOfPayment, BusFeePayment_Student.PaymentModeDetails, BusFeePayment_Student.PaymentDate, BusFeePayment_Student.PaymentDue, BusFeePayment_Student.ClassType,BusFeePayment_Student.SchoolType , BusFeePayment_Student.Class , BusFeePayment_Student.Section FROM SchoolInfo INNER JOIN Student ON SchoolInfo.S_Id = Student.SchoolID INNER JOIN BusCardHolder_Student ON Student.AdmissionNo = BusCardHolder_Student.AdmissionNo INNER JOIN BusFeePayment_Student ON BusCardHolder_Student.BCH_Id = BusFeePayment_Student.BusHolderID where PaymentID='" & txtFeePaymentID.Text & "'"
            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand
            myDA.Fill(myDS, "Student")
            myDA.Fill(myDS, "BusCardHolder_Student")
            myDA.Fill(myDS, "SchoolInfo")
            myDA.Fill(myDS, "BusFeePayment_Student")
            rpt.SetDataSource(myDS)
            frmReport.CrystalReportViewer1.ReportSource = rpt
            frmReport.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function GenerateID() As String
        con = New SqlConnection(cs)
        Dim value As String = "0000"
        Try
            ' Fetch the latest ID from the database
            con.Open()
            cmd = New SqlCommand("SELECT TOP 1 (BFP_ID) FROM BusFeePayment_Student where ClassType='Nursery' and SchoolType='English' ORDER BY BFP_ID DESC", con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If rdr.HasRows Then
                rdr.Read()
                value = rdr.Item("BFP_ID")
            End If
            rdr.Close()
            ' Increase the ID by 1
            value += 1
            ' Because incrementing a string with an integer removes 0's
            ' we need to replace them. If necessary.
            If value <= 9 Then 'Value is between 0 and 10
                value = "000" & value
            ElseIf value <= 99 Then 'Value is between 9 and 100
                value = "00" & value
            ElseIf value <= 999 Then 'Value is between 999 and 1000
                value = "0" & value
            End If
        Catch ex As Exception
            ' If an error occurs, check the connection state and close it if necessary.
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            value = "0000"
        End Try
        Return value
    End Function
    Public Sub auto()
        Try
            txtBFPId.Text = GenerateID()
            Dim a As String = txtAdmissionNo.Text
            txtFeePaymentID.Text = "EBFN-" + GenerateID() + "-" + a
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub
    Private Function GenerateID1() As String
        con = New SqlConnection(cs)
        Dim value As String = "0000"
        Try
            ' Fetch the latest ID from the database
            con.Open()
            cmd = New SqlCommand("SELECT TOP 1 (BFP_ID) FROM BusFeePayment_Student where ClassType='Primary' and SchoolType='English' ORDER BY BFP_ID DESC", con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If rdr.HasRows Then
                rdr.Read()
                value = rdr.Item("BFP_ID")
            End If
            rdr.Close()
            ' Increase the ID by 1
            value += 1
            ' Because incrementing a string with an integer removes 0's
            ' we need to replace them. If necessary.
            If value <= 9 Then 'Value is between 0 and 10
                value = "000" & value
            ElseIf value <= 99 Then 'Value is between 9 and 100
                value = "00" & value
            ElseIf value <= 999 Then 'Value is between 999 and 1000
                value = "0" & value
            End If
        Catch ex As Exception
            ' If an error occurs, check the connection state and close it if necessary.
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            value = "0000"
        End Try
        Return value
    End Function
    Sub auto1()
        Try
            txtBFPId.Text = GenerateID1()
            Dim a As String = txtAdmissionNo.Text
            txtFeePaymentID.Text = "EBFP-" + GenerateID1() + "-" + a
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub
    Private Function GenerateID2() As String
        con = New SqlConnection(cs)
        Dim value As String = "0000"
        Try
            ' Fetch the latest ID from the database
            con.Open()
            cmd = New SqlCommand("SELECT TOP 1 (BFP_ID) FROM BusFeePayment_Student where ClassType='Secondary' and SchoolType='English' ORDER BY BFP_ID DESC", con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If rdr.HasRows Then
                rdr.Read()
                value = rdr.Item("BFP_ID")
            End If
            rdr.Close()
            ' Increase the ID by 1
            value += 1
            ' Because incrementing a string with an integer removes 0's
            ' we need to replace them. If necessary.
            If value <= 9 Then 'Value is between 0 and 10
                value = "000" & value
            ElseIf value <= 99 Then 'Value is between 9 and 100
                value = "00" & value
            ElseIf value <= 999 Then 'Value is between 999 and 1000
                value = "0" & value
            End If
        Catch ex As Exception
            ' If an error occurs, check the connection state and close it if necessary.
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            value = "0000"
        End Try
        Return value
    End Function
    Sub auto2()
        Try
            txtBFPId.Text = GenerateID2()
            Dim a As String = txtAdmissionNo.Text
            txtFeePaymentID.Text = "EBFS-" + GenerateID2() + "-" + a
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub
    Private Function GenerateID3() As String
        con = New SqlConnection(cs)
        Dim value As String = "0000"
        Try
            ' Fetch the latest ID from the database
            con.Open()
            cmd = New SqlCommand("SELECT TOP 1 (BFP_ID) FROM BusFeePayment_Student where ClassType='Higher Secondary' and SchoolType='English' ORDER BY BFP_ID DESC", con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If rdr.HasRows Then
                rdr.Read()
                value = rdr.Item("BFP_ID")
            End If
            rdr.Close()
            ' Increase the ID by 1
            value += 1
            ' Because incrementing a string with an integer removes 0's
            ' we need to replace them. If necessary.
            If value <= 9 Then 'Value is between 0 and 10
                value = "000" & value
            ElseIf value <= 99 Then 'Value is between 9 and 100
                value = "00" & value
            ElseIf value <= 999 Then 'Value is between 999 and 1000
                value = "0" & value
            End If
        Catch ex As Exception
            ' If an error occurs, check the connection state and close it if necessary.
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            value = "0000"
        End Try
        Return value
    End Function
    Sub auto3()
        Try
            txtBFPId.Text = GenerateID3()
            Dim a As String = txtAdmissionNo.Text
            txtFeePaymentID.Text = "EBFHS-" + GenerateID3() + "-" + a
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub
    Private Function GenerateID4() As String
        con = New SqlConnection(cs)
        Dim value As String = "0000"
        Try
            ' Fetch the latest ID from the database
            con.Open()
            cmd = New SqlCommand("SELECT TOP 1 (BFP_ID) FROM BusFeePayment_Student where ClassType='Nursery' and SchoolType='Gujarati' ORDER BY BFP_ID DESC", con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If rdr.HasRows Then
                rdr.Read()
                value = rdr.Item("BFP_ID")
            End If
            rdr.Close()
            ' Increase the ID by 1
            value += 1
            ' Because incrementing a string with an integer removes 0's
            ' we need to replace them. If necessary.
            If value <= 9 Then 'Value is between 0 and 10
                value = "000" & value
            ElseIf value <= 99 Then 'Value is between 9 and 100
                value = "00" & value
            ElseIf value <= 999 Then 'Value is between 999 and 1000
                value = "0" & value
            End If
        Catch ex As Exception
            ' If an error occurs, check the connection state and close it if necessary.
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            value = "0000"
        End Try
        Return value
    End Function
    Sub auto4()
        Try
            txtBFPId.Text = GenerateID4()
            Dim a As String = txtAdmissionNo.Text
            txtFeePaymentID.Text = "GBFN-" + GenerateID4() + "-" + a
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub
    Private Function GenerateID5() As String
        con = New SqlConnection(cs)
        Dim value As String = "0000"
        Try
            ' Fetch the latest ID from the database
            con.Open()
            cmd = New SqlCommand("SELECT TOP 1 (BFP_ID) FROM BusFeePayment_Student where ClassType='Primary' and SchoolType='Gujarati' ORDER BY BFP_ID DESC", con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If rdr.HasRows Then
                rdr.Read()
                value = rdr.Item("BFP_ID")
            End If
            rdr.Close()
            ' Increase the ID by 1
            value += 1
            ' Because incrementing a string with an integer removes 0's
            ' we need to replace them. If necessary.
            If value <= 9 Then 'Value is between 0 and 10
                value = "000" & value
            ElseIf value <= 99 Then 'Value is between 9 and 100
                value = "00" & value
            ElseIf value <= 999 Then 'Value is between 999 and 1000
                value = "0" & value
            End If
        Catch ex As Exception
            ' If an error occurs, check the connection state and close it if necessary.
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            value = "0000"
        End Try
        Return value
    End Function
    Sub auto5()
        Try
            txtBFPId.Text = GenerateID5()
            Dim a As String = txtAdmissionNo.Text
            txtFeePaymentID.Text = "GBFP-" + GenerateID5() + "-" + a
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub
    Private Function GenerateID6() As String
        con = New SqlConnection(cs)
        Dim value As String = "0000"
        Try
            ' Fetch the latest ID from the database
            con.Open()
            cmd = New SqlCommand("SELECT TOP 1 (BFP_ID) FROM BusFeePayment_Student where ClassType='Secondary' and SchoolType='Gujarati' ORDER BY BFP_ID DESC", con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If rdr.HasRows Then
                rdr.Read()
                value = rdr.Item("BFP_ID")
            End If
            rdr.Close()
            ' Increase the ID by 1
            value += 1
            ' Because incrementing a string with an integer removes 0's
            ' we need to replace them. If necessary.
            If value <= 9 Then 'Value is between 0 and 10
                value = "000" & value
            ElseIf value <= 99 Then 'Value is between 9 and 100
                value = "00" & value
            ElseIf value <= 999 Then 'Value is between 999 and 1000
                value = "0" & value
            End If
        Catch ex As Exception
            ' If an error occurs, check the connection state and close it if necessary.
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            value = "0000"
        End Try
        Return value
    End Function
    Sub auto6()
        Try
            txtBFPId.Text = GenerateID6()
            Dim a As String = txtAdmissionNo.Text
            txtFeePaymentID.Text = "GBFS-" + GenerateID6() + "-" + a
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub
    Private Function GenerateID7() As String
        con = New SqlConnection(cs)
        Dim value As String = "0000"
        Try
            ' Fetch the latest ID from the database
            con.Open()
            cmd = New SqlCommand("SELECT TOP 1 (BFP_ID) FROM BusFeePayment_Student where ClassType='Higher Secondary' and SchoolType='Gujarati' ORDER BY BFP_ID DESC", con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If rdr.HasRows Then
                rdr.Read()
                value = rdr.Item("BFP_ID")
            End If
            rdr.Close()
            ' Increase the ID by 1
            value += 1
            ' Because incrementing a string with an integer removes 0's
            ' we need to replace them. If necessary.
            If value <= 9 Then 'Value is between 0 and 10
                value = "000" & value
            ElseIf value <= 99 Then 'Value is between 9 and 100
                value = "00" & value
            ElseIf value <= 999 Then 'Value is between 999 and 1000
                value = "0" & value
            End If
        Catch ex As Exception
            ' If an error occurs, check the connection state and close it if necessary.
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            value = "0000"
        End Try
        Return value
    End Function
    Sub auto7()
        Try
            txtBFPId.Text = GenerateID7()
            Dim a As String = txtAdmissionNo.Text
            txtFeePaymentID.Text = "GBFHS-" + GenerateID7() + "-" + a
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub
    Sub Reset()
        cmbInstallment.DropDownStyle = ComboBoxStyle.DropDownList
        txtAdmissionNo.Text = ""
        txtBusFee.Text = ""
        txtPaymentModeDetails.Text = ""
        txtBalance.Text = ""
        txtClass.Text = ""
        txtDiscount.Text = ""
        txtDiscountPer.Text = ""
        txtEnrollmentNo.Text = ""
        txtFine.Text = ""
        txtGrandTotal.Text = ""
        txtPreviousDue.Text = ""
        txtLocation.Text = ""
        txtSection.Text = ""
        txtSession.Text = ""
        txtStudentName.Text = ""
        txtTotalPaid.Text = ""
        txtClassType.Text = ""
        txtSchoolType.Text = ""
        cmbPaymentMode.SelectedIndex = -1
        cmbInstallment.SelectedIndex = -1
        dtpPaymentDate.Text = Now
        btnSave.Enabled = True
        cmbInstallment.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnPrint.Enabled = False
        Button2.Enabled = True
        dtpPaymentDate.Enabled = True
    End Sub
    Sub FillData()
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandText = "SELECT Type FROM ClassType,Class where ClassType.Type=Class.ClassType and Classname=@d1"
            cmd.Parameters.AddWithValue("@d1", txtClass.Text)
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                txtClassType.Text = rdr.GetValue(0).ToString().Trim()
            End If
            If (rdr IsNot Nothing) Then
                rdr.Close()
            End If
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con = New SqlConnection(cs)
            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandText = "SELECT Type FROM SchoolType,SchoolInfo where SchoolType.Type=SchoolInfo.SchoolType and SchoolName=@d1"
            cmd.Parameters.AddWithValue("@d1", txtSchoolName.Text)
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                txtSchoolType.Text = rdr.GetValue(0).ToString().Trim()
            End If
            If (rdr IsNot Nothing) Then
                rdr.Close()
            End If
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con = New SqlConnection(cs)
            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandText = "SELECT EnrollmentNo,Session FROM Student where AdmissionNo=@d1"
            cmd.Parameters.AddWithValue("@d1", txtAdmissionNo.Text)
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                txtEnrollmentNo.Text = rdr.GetValue(0).ToString().Trim()
                txtSession.Text = rdr.GetValue(1).ToString().Trim()
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
    Sub Fill()
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandText = "SELECT Discount from Discount where AdmissionNo=@d1 and FeeType='Bus'"
            cmd.Parameters.AddWithValue("@d1", txtAdmissionNo.Text)
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                txtDiscountPer.Text = rdr.GetValue(0)
                Dim num As Double
                num = CDbl((Val(txtBusFee.Text) * Val(txtDiscountPer.Text)) / 100)
                num = Math.Round(num, 2)
                txtDiscount.Text = num
            End If
            If (rdr IsNot Nothing) Then
                rdr.Close()
            End If
            If con.State = ConnectionState.Open Then
                con.Close()
            End If

            Calculate()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        frmBusCardHolder_StudentRecord.lblSet.Text = "Bus Fee Payment"
        frmBusCardHolder_StudentRecord.Reset()
        frmBusCardHolder_StudentRecord.ShowDialog()
    End Sub

    Private Sub btnGetFeeList_Click(sender As System.Object, e As System.EventArgs) Handles btnGetFeeList.Click
        Try
            If txtAdmissionNo.Text = "" Then
                MessageBox.Show("Please retrieve buser info", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtAdmissionNo.Focus()
                Return
            End If
            If cmbInstallment.Text = "" Then
                MessageBox.Show("Please select installment", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbInstallment.Focus()
                Return
            End If
            con = New SqlConnection(cs)
            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandText = "SELECT Charges from Installment_Bus where Installment=@d1 and Location=@d2"
            cmd.Parameters.AddWithValue("@d1", cmbInstallment.Text)
            cmd.Parameters.AddWithValue("@d2", txtLocation.Text)
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                txtBusFee.Text = rdr.GetValue(0)
            End If
            If (rdr IsNot Nothing) Then
                rdr.Close()
            End If
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con = New SqlConnection(cs)
            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandText = "SELECT Sum(PaymentDue-PreviousDue) from BusFeePayment_Student where BusHolderID=@d1 group by BusHolderID"
            cmd.Parameters.AddWithValue("@d1", txtBusHolderID.Text)
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                txtPreviousDue.Text = rdr.GetValue(0)
            Else
                txtPreviousDue.Text = 0
            End If
            If (rdr IsNot Nothing) Then
                rdr.Close()
            End If
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            Fill()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Reset()
        Reset()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If Len(Trim(txtAdmissionNo.Text)) = 0 Then
            MessageBox.Show("Please retrieve bus holder info", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAdmissionNo.Focus()
            Exit Sub
        End If
        If Len(Trim(cmbInstallment.Text)) = 0 Then
            MessageBox.Show("Please select installment", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbInstallment.Focus()
            Exit Sub
        End If
        If Len(Trim(txtFine.Text)) = 0 Then
            MessageBox.Show("Please enter fine", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtFine.Focus()
            Exit Sub
        End If
        If Len(Trim(cmbPaymentMode.Text)) = 0 Then
            MessageBox.Show("Please select Payment Mode", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbPaymentMode.Focus()
            Exit Sub
        End If
        If Len(Trim(txtTotalPaid.Text)) = 0 Then
            MessageBox.Show("Please enter total paid", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTotalPaid.Focus()
            Exit Sub
        End If
        If Val(txtBalance.Text) < 0 Then
            MessageBox.Show("Balance is not possible less than zero", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Try
            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "select Session,BusHolderID,Installment from BusFeePayment_Student where Session=@d1 and BusHolderID=@d2 and Installment=@d3"
            cmd = New SqlCommand(ct)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtSession.Text)
            cmd.Parameters.AddWithValue("@d2", txtBusHolderID.Text)
            cmd.Parameters.AddWithValue("@d3", cmbInstallment.Text)
            rdr = cmd.ExecuteReader()
            If rdr.Read Then
                MessageBox.Show("Already paid", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If
            If txtClassType.Text = "Nursery" And txtSchoolType.Text = "English" Then
                auto()
            End If
            If txtClassType.Text = "Primary" And txtSchoolType.Text = "English" Then
                auto1()
            End If
            If txtClassType.Text = "Secondary" And txtSchoolType.Text = "English" Then
                auto2()
            End If
            If txtClassType.Text = "Higher Secondary" And txtSchoolType.Text = "English" Then
                auto3()
            End If
            If txtClassType.Text = "Nursery" And txtSchoolType.Text = "Gujarati" Then
                auto4()
            End If
            If txtClassType.Text = "Primary" And txtSchoolType.Text = "Gujarati" Then
                auto5()
            End If
            If txtClassType.Text = "Secondary" And txtSchoolType.Text = "Gujarati" Then
                auto6()
            End If
            If txtClassType.Text = "Higher Secondary" And txtSchoolType.Text = "Gujarati" Then
                auto7()
            End If
            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "insert into BusFeePayment_Student(BFP_ID, PaymentID, BusHolderID, Session,installment,TotalFee, DiscountPer, DiscountAmt, PreviousDue, Fine, GrandTotal, TotalPaid, ModeOfPayment, PaymentModeDetails, PaymentDate, PaymentDue, ClassType,SchoolType,Class,Section) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12,@d13,@d14,@d15,@d16,@d17,@d18,@d19,@d20)"
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtBFPId.Text)
            cmd.Parameters.AddWithValue("@d2", txtFeePaymentID.Text)
            cmd.Parameters.AddWithValue("@d3", txtBusHolderID.Text)
            cmd.Parameters.AddWithValue("@d4", txtSession.Text)
            cmd.Parameters.AddWithValue("@d5", cmbInstallment.Text)
            cmd.Parameters.AddWithValue("@d6", txtBusFee.Text)
            cmd.Parameters.AddWithValue("@d7", txtDiscountPer.Text)
            cmd.Parameters.AddWithValue("@d8", txtDiscount.Text)
            cmd.Parameters.AddWithValue("@d9", txtPreviousDue.Text)
            cmd.Parameters.AddWithValue("@d10", txtFine.Text)
            cmd.Parameters.AddWithValue("@d11", txtGrandTotal.Text)
            cmd.Parameters.AddWithValue("@d12", txtTotalPaid.Text)
            cmd.Parameters.AddWithValue("@d13", cmbPaymentMode.Text)
            cmd.Parameters.AddWithValue("@d14", txtPaymentModeDetails.Text)
            cmd.Parameters.AddWithValue("@d15", dtpPaymentDate.Value)
            cmd.Parameters.AddWithValue("@d16", txtBalance.Text)
            cmd.Parameters.AddWithValue("@d17", txtClassType.Text)
            cmd.Parameters.AddWithValue("@d18", txtSchoolType.Text)
            cmd.Parameters.AddWithValue("@d19", txtClass.Text)
            cmd.Parameters.AddWithValue("@d20", txtSection.Text)
            cmd.ExecuteNonQuery()
            Dim st As String = "added the new bus fee payment entry having payment id '" & txtFeePaymentID.Text & "'"
            LogFunc(lblUser.Text, st)
            MessageBox.Show("Successfully paid", "Fee", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnSave.Enabled = False
            con.Close()
            Print()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        Try
            If MessageBox.Show("Do you really want to delete the record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                delete_records()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub delete_records()
        Try
            Dim RowsAffected As Integer = 0
            con = New SqlConnection(cs)
            con.Open()
            Dim cq As String = "delete from BusFeePayment_Student where ID= " & txtID.Text & ""
            cmd = New SqlCommand(cq)
            cmd.Connection = con
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                Dim st As String = "deleted the bus fee payment entry having payment id '" & txtFeePaymentID.Text & "'"
                LogFunc(lblUser.Text, st)
                MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()
                Reset()
            Else
                MessageBox.Show("No record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()
                Reset()
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
        If Len(Trim(txtAdmissionNo.Text)) = 0 Then
            MessageBox.Show("Please retrieve bus holder info", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAdmissionNo.Focus()
            Exit Sub
        End If
        If Len(Trim(cmbInstallment.Text)) = 0 Then
            MessageBox.Show("Please select installment", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbInstallment.Focus()
            Exit Sub
        End If
        If Len(Trim(txtFine.Text)) = 0 Then
            MessageBox.Show("Please enter fine", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtFine.Focus()
            Exit Sub
        End If
        If Len(Trim(cmbPaymentMode.Text)) = 0 Then
            MessageBox.Show("Please select Payment Mode", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbPaymentMode.Focus()
            Exit Sub
        End If
        If Len(Trim(txtTotalPaid.Text)) = 0 Then
            MessageBox.Show("Please enter total paid", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTotalPaid.Focus()
            Exit Sub
        End If
        If Val(txtBalance.Text) < 0 Then
            MessageBox.Show("Balance is not possible less than zero", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Try
            'con = New SqlConnection(cs)
            'con.Open()
            'Dim ct As String = "select PaymentDate from BusFeePayment_Student where AdmissionNo=@d1"
            'cmd = New SqlCommand(ct)
            'cmd.Connection = con
            'cmd.Parameters.AddWithValue("@d1", txtAdmissionNo.Text)
            'Dim da As New SqlDataAdapter(cmd)
            'Dim ds As DataSet = New DataSet()
            'da.Fill(ds)
            'If ds.Tables(0).Rows.Count > 0 Then
            'If dtpPaymentDate.Value.Date < ds.Tables(0).Rows(0)("PaymentDate") Then
            'MessageBox.Show("updating old record is not allowed when student has been already paid fee again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End If
            'Exit Sub
            'End If
            'con.Close()
            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "Update BusFeePayment_Student set BFP_ID=@d1, PaymentID=@d2, BusHolderID=@d3, Session=@d4, Installment=@d5,TotalFee=@d6, DiscountPer=@d7, DiscountAmt=@d8, PreviousDue=@d9, Fine=@d10, GrandTotal=@d11, TotalPaid=@d12, ModeOfPayment=@d13, PaymentModeDetails=@d14,PaymentDue=@d16, ClassType=@d17,SchoolType=@d18,Class=@d19,Section=@d20 where ID= " & txtID.Text & ""
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtBFPId.Text)
            cmd.Parameters.AddWithValue("@d2", txtFeePaymentID.Text)
            cmd.Parameters.AddWithValue("@d3", txtBusHolderID.Text)
            cmd.Parameters.AddWithValue("@d4", txtSession.Text)
            cmd.Parameters.AddWithValue("@d5", cmbInstallment.Text)
            cmd.Parameters.AddWithValue("@d6", txtBusFee.Text)
            cmd.Parameters.AddWithValue("@d7", txtDiscountPer.Text)
            cmd.Parameters.AddWithValue("@d8", txtDiscount.Text)
            cmd.Parameters.AddWithValue("@d9", txtPreviousDue.Text)
            cmd.Parameters.AddWithValue("@d10", txtFine.Text)
            cmd.Parameters.AddWithValue("@d11", txtGrandTotal.Text)
            cmd.Parameters.AddWithValue("@d12", txtTotalPaid.Text)
            cmd.Parameters.AddWithValue("@d13", cmbPaymentMode.Text)
            cmd.Parameters.AddWithValue("@d14", txtPaymentModeDetails.Text)
            cmd.Parameters.AddWithValue("@d16", txtBalance.Text)
            cmd.Parameters.AddWithValue("@d17", txtClassType.Text)
            cmd.Parameters.AddWithValue("@d18", txtSchoolType.Text)
            cmd.Parameters.AddWithValue("@d19", txtClass.Text)
            cmd.Parameters.AddWithValue("@d20", txtSection.Text)
            cmd.ExecuteNonQuery()
            con.Close()
            Dim st As String = "updated the bus fee payment entry having payment id '" & txtFeePaymentID.Text & "'"
            LogFunc(lblUser.Text, st)
            MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnUpdate.Enabled = False
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtFine_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtFine.KeyPress
        Dim keyChar = e.KeyChar

        If Char.IsControl(keyChar) Then
            'Allow all control characters.
        ElseIf Char.IsDigit(keyChar) OrElse keyChar = "."c Then
            Dim text = Me.txtFine.Text
            Dim selectionStart = Me.txtFine.SelectionStart
            Dim selectionLength = Me.txtFine.SelectionLength

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

    Private Sub txtTotalPaid_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotalPaid.KeyPress
        Dim keyChar = e.KeyChar

        If Char.IsControl(keyChar) Then
            'Allow all control characters.
        ElseIf Char.IsDigit(keyChar) OrElse keyChar = "."c Then
            Dim text = Me.txtTotalPaid.Text
            Dim selectionStart = Me.txtTotalPaid.SelectionStart
            Dim selectionLength = Me.txtTotalPaid.SelectionLength

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

    Private Sub txtTotalPaid_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles txtTotalPaid.Validating
        If Val(txtTotalPaid.Text) > Val(txtGrandTotal.Text) Then
            MessageBox.Show("Total Pay can not be more than grand total", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTotalPaid.Text = ""
            txtTotalPaid.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txtFine_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtFine.TextChanged
        Fill()
    End Sub

    Private Sub txtTotalPaid_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTotalPaid.TextChanged
        Fill()
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnGetData_Click(sender As System.Object, e As System.EventArgs) Handles btnGetData.Click
        frmBusFeePayment_StudentRecord.lblSet.Text = "Bus Fee Payment"
        frmBusFeePayment_StudentRecord.Reset()
        frmBusFeePayment_StudentRecord.ShowDialog()
    End Sub
     Sub fillInstallment()
        Try
            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "SELECT distinct RTRIM(Installment) FROM Installment_Bus where Location=@d1"
            cmd = New SqlCommand(ct)
            cmd.Parameters.AddWithValue("@d1", txtLocation.Text)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            cmbInstallment.Items.Clear()
            While rdr.Read
                cmbInstallment.Items.Add(rdr(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub frmBusFeePayment_Student_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        fillInstallment()
    End Sub

  
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Cursor = Cursors.Default
        Timer1.Enabled = False
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Print()
    End Sub
End Class

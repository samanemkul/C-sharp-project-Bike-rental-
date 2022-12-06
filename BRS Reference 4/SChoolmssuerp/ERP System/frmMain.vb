Imports System.Data.SqlClient
Public Class frmMain

    Private Sub ClassToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassToolStripMenuItem.Click
        frmClass.lblUser.Text = lblUser.Text
        frmClass.Reset()
        frmClass.ShowDialog()
    End Sub

    Private Sub SectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SectionToolStripMenuItem.Click
        frmSection.lblUser.Text = lblUser.Text
        frmSection.Reset()
        frmSection.ShowDialog()
    End Sub

    Private Sub DepartmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentToolStripMenuItem.Click
        frmDepartment.lblUser.Text = lblUser.Text
        frmDepartment.Reset()
        frmDepartment.ShowDialog()
    End Sub

    Private Sub FeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FeeToolStripMenuItem.Click
        frmFee.lblUser.Text = lblUser.Text
        frmFee.Reset()
        frmFee.ShowDialog()
    End Sub

    Private Sub FeeInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FeeInfoToolStripMenuItem.Click
        frmClassFeeInfo.lblUser.Text = lblUser.Text
        frmClassFeeInfo.Reset()
        frmClassFeeInfo.ShowDialog()
    End Sub

    Private Sub LocationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocationToolStripMenuItem.Click
        frmLocation.lblUser.Text = lblUser.Text
        frmLocation.Reset()
        frmLocation.ShowDialog()
    End Sub

    Private Sub DocumentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DocumentToolStripMenuItem.Click
        frmDocument.lblUser.Text = lblUser.Text
        frmDocument.Reset()
        frmDocument.ShowDialog()
    End Sub

    Private Sub HostelInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HostelInfoToolStripMenuItem.Click
        frmhostelInfo.lblUser.Text = lblUser.Text
        frmhostelInfo.Reset()
        frmhostelInfo.ShowDialog()
    End Sub

    Private Sub SchoolInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SchoolInfoToolStripMenuItem.Click
        frmSchoolInfo.lblUser.Text = lblUser.Text
        frmSchoolInfo.Reset()
        frmSchoolInfo.ShowDialog()
    End Sub


    Private Sub CalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculatorToolStripMenuItem.Click
        System.Diagnostics.Process.Start("Calc.exe")
    End Sub

    Private Sub NotepadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotepadToolStripMenuItem.Click
        System.Diagnostics.Process.Start("Notepad.exe")
    End Sub

    Private Sub WordPadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WordPadToolStripMenuItem.Click
        System.Diagnostics.Process.Start("WordPad.exe")
    End Sub

    Private Sub MSWordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MSWordToolStripMenuItem.Click
        System.Diagnostics.Process.Start("WinWord.exe")
    End Sub

    Private Sub MSPaintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MSPaintToolStripMenuItem.Click
        System.Diagnostics.Process.Start("MSPaint.exe")
    End Sub

    Private Sub TaskManagerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TaskManagerToolStripMenuItem.Click
        System.Diagnostics.Process.Start("TaskMgr.exe")
    End Sub

    Private Sub SystemInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SystemInfoToolStripMenuItem.Click
        frmSystemInfo.Show()
    End Sub

    Private Sub BusFeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BusFeeToolStripMenuItem.Click
        frmInstallment_Bus.lblUser.Text = lblUser.Text
        frmInstallment_Bus.Reset()
        frmInstallment_Bus.ShowDialog()
    End Sub

    Private Sub HostelFeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HostelFeeToolStripMenuItem.Click
        frmInstallment_Hostel.lblUser.Text = lblUser.Text
        frmInstallment_Hostel.Reset()
        frmInstallment_Hostel.ShowDialog()
    End Sub


    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        lblDateTime.Text = Now
    End Sub

    Private Sub SchoolTypeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        frmSchoolType.lblUser.Text = lblUser.Text
        frmSchoolType.Reset()
        frmSchoolType.ShowDialog()
    End Sub

    Private Sub ClassTypeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClassTypeToolStripMenuItem.Click
        frmClassType.lblUser.Text = lblUser.Text
        frmClassType.Reset()
        frmClassType.ShowDialog()
    End Sub

    Private Sub RegistrationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RegistrationToolStripMenuItem.Click
        frmRegistration.lblUser.Text = lblUser.Text
        frmRegistration.Reset()
        frmRegistration.ShowDialog()
    End Sub

    Private Sub LogsToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles LogsToolStripMenuItem.Click
        frmLogs.Reset()
        frmLogs.lblUser.Text = lblUser.Text
        frmLogs.ShowDialog()
    End Sub

    Private Sub BackupToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BackupToolStripMenuItem.Click
        Backup()
    End Sub
    Sub Backup()
        Try
            Cursor = Cursors.WaitCursor
            Timer2.Enabled = True
            If (Not System.IO.Directory.Exists("C:\DBBackup")) Then
                System.IO.Directory.CreateDirectory("C:\DBBackup")
            End If
            Dim destdir As String = "C:\DBBackup\ERPS_DB " & DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss") & ".bak"
            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "backup database [" & System.Windows.Forms.Application.StartupPath & "\ERPS_DB.mdf] to disk='" & destdir & "'with init,stats=10"
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            cmd.ExecuteReader()
            con.Close()
            Dim st As String = "Sucessfully performed the backup"
            LogFunc(lblUser.Text, st)
            MessageBox.Show("Successfully performed", "Database Backup", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'GetData()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub RestoreToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RestoreToolStripMenuItem.Click
        Try
            With OpenFileDialog1
                .Filter = ("DB Backup File|*.bak;")
                .FilterIndex = 4
            End With
            'Clear the file name
            OpenFileDialog1.FileName = ""

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Cursor = Cursors.WaitCursor
                Timer2.Enabled = True
                SqlConnection.ClearAllPools()
                con = New SqlConnection(cs)
                con.Open()
                Dim cb As String = "USE Master ALTER DATABASE [" & System.Windows.Forms.Application.StartupPath & "\ERPS_DB.mdf] SET Single_User WITH Rollback Immediate Restore database [" & System.Windows.Forms.Application.StartupPath & "\ERPS_DB.mdf] FROM disk='" & OpenFileDialog1.FileName & "' WITH REPLACE ALTER DATABASE [" & System.Windows.Forms.Application.StartupPath & "\ERPS_DB.mdf] SET Multi_User "
                cmd = New SqlCommand(cb)
                cmd.Connection = con
                cmd.ExecuteReader()
                Dim st As String = "Sucessfully performed the restore"
                LogFunc(lblUser.Text, st)
                MessageBox.Show("Successfully performed", "Database Restore", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'GetData()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Cursor = Cursors.Default
        Timer2.Enabled = False
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Try
            If MessageBox.Show("Do you really want to logout from application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If MessageBox.Show("Do you want backup database before logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Backup()
                    LogOut()
                Else
                    LogOut()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub LogOut()
        Dim st As String = "Successfully logged out"
        LogFunc(lblUser.Text, st)
        Me.Hide()
        frmLogin.Show()
        frmLogin.UserID.Text = ""
        frmLogin.Password.Text = ""
        frmLogin.UserID.Focus()
    End Sub

    Private Sub ProfileEntryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProfileEntryToolStripMenuItem.Click
        frmStudent.lblUser.Text = lblUser.Text
        frmStudent.Reset()
        frmStudent.ShowDialog()
    End Sub

    Private Sub BusHolderToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BusHolderToolStripMenuItem.Click
        frmBusCardHolder_Student.lblUser.Text = lblUser.Text
        frmBusCardHolder_Student.Reset()
        frmBusCardHolder_Student.ShowDialog()
    End Sub

    Private Sub HostelerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HostelerToolStripMenuItem.Click
        frmHosteler.lblUser.Text = lblUser.Text
        frmHosteler.Reset()
        frmHosteler.ShowDialog()
    End Sub

    Private Sub StudentsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StudentsToolStripMenuItem.Click
        frmStudentRecord1.Reset()
        frmStudentRecord1.ShowDialog()
    End Sub

    Private Sub BusHoldersStudentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BusHoldersStudentToolStripMenuItem.Click
        frmBusCardHolder_StudentRecord.Reset()
        frmBusCardHolder_StudentRecord.ShowDialog()
    End Sub

    Private Sub HostelersToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HostelersToolStripMenuItem.Click
        frmHostelerRecord.Reset()
        frmHostelerRecord.ShowDialog()
    End Sub

    Private Sub SessionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SessionToolStripMenuItem.Click
        frmSession.lblUser.Text = lblUser.Text
        frmSession.Reset()
        frmSession.ShowDialog()
    End Sub

    Private Sub ClassTransferToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClassTransferToolStripMenuItem.Click
        frmClassTransfer.lblUser.Text = lblUser.Text
        frmClassTransfer.Reset()
        frmClassTransfer.ShowDialog()
    End Sub

    Private Sub NoDuesStudentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NoDuesStudentToolStripMenuItem.Click
        frmStudentsNoDuesRecord.Reset()
        frmStudentsNoDuesRecord.ShowDialog()
    End Sub

    Private Sub NoDuesStaffToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NoDuesStaffToolStripMenuItem.Click
        frmStaffNoDuesRecord.Reset()
        frmStaffNoDuesRecord.ShowDialog()
    End Sub

    Private Sub CardsStudentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CardsStudentToolStripMenuItem.Click
        frmStudentsCardRecord.Reset()
        frmStudentsCardRecord.ShowDialog()
    End Sub

    Private Sub CardsStaffToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CardsStaffToolStripMenuItem.Click
        frmStaffCardRecord.Reset()
        frmStaffCardRecord.ShowDialog()
    End Sub

    Private Sub ProfileEntryToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles ProfileEntryToolStripMenuItem2.Click
        frmStaff.lblUser.Text = lblUser.Text
        frmStaff.Reset()
        frmStaff.ShowDialog()
    End Sub

    Private Sub DesignatToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DesignatToolStripMenuItem.Click
        frmDesignation.lblUser.Text = lblUser.Text
        frmDesignation.Reset()
        frmDesignation.ShowDialog()
    End Sub

    Private Sub StaffsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StaffsToolStripMenuItem.Click
        frmStaffRecord1.Reset()
        frmStaffRecord1.ShowDialog()
    End Sub

    Private Sub BusInfoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BusInfoToolStripMenuItem.Click
        frmBusInfo.lblUser.Text = lblUser.Text
        frmBusInfo.Reset()
        frmBusInfo.ShowDialog()
    End Sub

    Private Sub InactiveEntryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InactiveEntryToolStripMenuItem.Click
        frmInactive.lblUser.Text = lblUser.Text
        frmInactive.Reset()
        frmInactive.ShowDialog()
    End Sub

    Private Sub BusHolderToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles BusHolderToolStripMenuItem1.Click
        frmBusCardHolder_Staff.lblUser.Text = lblUser.Text
        frmBusCardHolder_Staff.Reset()
        frmBusCardHolder_Staff.ShowDialog()
    End Sub

    Private Sub BusHoldersStaffToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BusHoldersStaffToolStripMenuItem.Click
        frmBusCardHolder_StaffRecord.Reset()
        frmBusCardHolder_Staff.ShowDialog()
    End Sub

    Private Sub AdvanceEntryToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles AdvanceEntryToolStripMenuItem1.Click
        frmAdvanceEntryRecord.Reset()
        frmAdvanceEntryRecord.ShowDialog()
    End Sub

    Private Sub CurrentAdvanceToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CurrentAdvanceToolStripMenuItem.Click
        frmAdvanceEntryRecord1.Reset()
        frmAdvanceEntryRecord1.ShowDialog()
    End Sub

    Private Sub StaffAttendance1ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StaffAttendance1ToolStripMenuItem.Click
        frmAttendanceEntryRecord.Reset()
        frmAttendanceEntryRecord.ShowDialog()
    End Sub

    Private Sub StaffAttendance2ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StaffAttendance2ToolStripMenuItem.Click
        frmAttendanceEntryRecord1.Reset()
        frmAttendanceEntryRecord1.ShowDialog()
    End Sub

    Private Sub StaffPayment1ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StaffPayment1ToolStripMenuItem.Click
        frmStaffPaymentRecord.Reset()
        frmStaffPaymentRecord.ShowDialog()
    End Sub

    Private Sub StaffPayment2ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StaffPayment2ToolStripMenuItem.Click
        frmStaffPaymentRecord1.Reset()
        frmStaffPaymentRecord1.ShowDialog()
    End Sub

    Private Sub AdvanceEntryToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles AdvanceEntryToolStripMenuItem2.Click
        frmAdvanceEntryReport.Reset()
        frmAdvanceEntryReport.ShowDialog()
    End Sub

    Private Sub StaffPaymentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StaffPaymentToolStripMenuItem.Click
        frmStaffPaymentReport.Reset()
        frmStaffPaymentReport.ShowDialog()
    End Sub

    Private Sub SalarySlipToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalarySlipToolStripMenuItem.Click
        frmSalaryslip.Reset()
        frmSalaryslip.ShowDialog()
    End Sub

    Private Sub ExpensesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExpensesToolStripMenuItem.Click
        frmVoucher.lblUser.Text = lblUser.Text
        frmVoucher.Reset()
        frmVoucher.ShowDialog()
    End Sub

    Private Sub VoucherToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VoucherToolStripMenuItem.Click
        frmVoucherReport.Reset()
        frmVoucherReport.ShowDialog()
    End Sub

    Private Sub CouseFeePaymentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CouseFeePaymentToolStripMenuItem.Click
        frmCourseFeePayment.lblUser.Text = lblUser.Text
        frmCourseFeePayment.Reset()
        frmCourseFeePayment.ShowDialog()
    End Sub

    Private Sub SchoolTypeToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles SchoolTypeToolStripMenuItem.Click
        frmSchoolType.lblUser.Text = lblUser.Text
        frmSchoolType.Reset()
        frmSchoolType.ShowDialog()
    End Sub

    Private Sub PaymentToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles PaymentToolStripMenuItem1.Click
        frmStaffPayment.lblUser.Text = lblUser.Text
        frmStaffPayment.Reset()
        frmStaffPayment.ShowDialog()
    End Sub

    Private Sub AttendanceToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles AttendanceToolStripMenuItem1.Click
        frmAttendance.lblUser.Text = lblUser.Text
        frmAttendance.Reset()
        frmAttendance.ShowDialog()
    End Sub

    Private Sub AdvanceEntryToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles AdvanceEntryToolStripMenuItem3.Click
        frmAdvanceEntry.lblUser.Text = lblUser.Text
        frmAdvanceEntry.Reset()
        frmAdvanceEntry.ShowDialog()
    End Sub

    Private Sub NoDuesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NoDuesToolStripMenuItem.Click
        frmNoDues_Docs.lblUser.Text = lblUser.Text
        frmNoDues_Docs.Reset()
        frmNoDues_Docs.ShowDialog()
    End Sub

    Private Sub CardsToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles CardsToolStripMenuItem2.Click
        frmCards.lblUser.Text = lblUser.Text
        frmCards.Reset()
        frmCards.ShowDialog()
    End Sub

    Private Sub CourseFeePaymentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CourseFeePaymentToolStripMenuItem.Click
        frmCourseFeePaymentRecord.Reset()
        frmCourseFeePaymentRecord.ShowDialog()
    End Sub

    Private Sub HostelFeePaymentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HostelFeePaymentToolStripMenuItem.Click
        frmHostelFeePayment.lblUser.Text = lblUser.Text
        frmHostelFeePayment.Reset()
        frmHostelFeePayment.ShowDialog()
    End Sub

    Private Sub HostelFeePaymentToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles HostelFeePaymentToolStripMenuItem1.Click
        frmHostelFeePaymentRecord.Reset()
        frmHostelFeePaymentRecord.ShowDialog()
    End Sub

    Private Sub StudentToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles StudentToolStripMenuItem2.Click
        frmBusFeePayment_Student.lblUser.Text = lblUser.Text
        frmBusFeePayment_Student.Reset()
        frmBusFeePayment_Student.ShowDialog()
    End Sub

    Private Sub frmMain_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
    End Sub

    Private Sub BusFeePaymentStudentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BusFeePaymentStudentToolStripMenuItem.Click
        frmBusFeePayment_StudentRecord.Reset()
        frmBusFeePayment_StudentRecord.ShowDialog()
    End Sub

    Private Sub StudentsToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles StudentsToolStripMenuItem1.Click
        frmDiscount.lblUser.Text = lblUser.Text
        frmDiscount.Reset()
        frmDiscount.ShowDialog()
    End Sub

    Private Sub StaffsToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles StaffsToolStripMenuItem1.Click
        frmDiscount_Staff.lblUser.Text = lblUser.Text
        frmDiscount_Staff.Reset()
        frmDiscount_Staff.ShowDialog()
    End Sub

    Private Sub HostelFeeReceiptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HostelFeeReceiptToolStripMenuItem.Click
        frmHostelFeeReceipt.Reset()
        frmHostelFeeReceipt.ShowDialog()
    End Sub

    Private Sub BusFeeReceiptStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BusFeeReceiptStudentToolStripMenuItem.Click
        frmBusFeeReceipt_Student.Reset()
        frmBusFeeReceipt_Student.ShowDialog()
    End Sub

    Private Sub FeeStructureToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FeeStructureToolStripMenuItem.Click
        frmFeeStructure.Reset()
        frmFeeStructure.ShowDialog()
    End Sub

    Private Sub CourseFeeReceiptToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CourseFeeReceiptToolStripMenuItem.Click
        frmClassFeeReceipt.Reset()
        frmClassFeeReceipt.ShowDialog()
    End Sub

    Private Sub PartialDueToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PartialDueToolStripMenuItem.Click
        frmPartialDueList.Reset()
        frmPartialDueList.ShowDialog()
    End Sub

    Private Sub FullDueToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FullDueToolStripMenuItem.Click
        frmFullDueList.Reset()
        frmFullDueList.ShowDialog()
    End Sub

    Private Sub StaffToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles StaffToolStripMenuItem1.Click
        frmBusFeePayment_Staff.lblUser.Text = lblUser.Text
        frmBusFeePayment_Staff.Reset()
        frmBusFeePayment_Staff.ShowDialog()
    End Sub

    Private Sub BusFeePaymentStaffToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BusFeePaymentStaffToolStripMenuItem.Click
        frmBusFeePayment_StaffRecord.Reset()
        frmBusFeePayment_StaffRecord.ShowDialog()
    End Sub

    Private Sub PartialBusFeeDueStaffsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PartialBusFeeDueStaffsToolStripMenuItem.Click
        frmPartialDueList_Staff.Reset()
        frmPartialDueList_Staff.ShowDialog()
    End Sub

    Private Sub BusFeeReceiptStaffsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BusFeeReceiptStaffsToolStripMenuItem.Click
        frmBusFeeReceipt_Staff.Reset()
        frmBusFeeReceipt_Staff.ShowDialog()
    End Sub
End Class
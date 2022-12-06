Imports System.Data.SqlClient
Public Class frmChangePassword
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim RowsAffected As Integer = 0
            If Len(Trim(UserID.Text)) = 0 Then
                MessageBox.Show("Please enter user id", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                UserID.Focus()
                Exit Sub
            End If
            If Len(Trim(OldPassword.Text)) = 0 Then
                MessageBox.Show("Please enter old password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                OldPassword.Focus()
                Exit Sub
            End If
            If Len(Trim(NewPassword.Text)) = 0 Then
                MessageBox.Show("Please enter new password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                NewPassword.Focus()
                Exit Sub
            End If
            If Len(Trim(ConfirmPassword.Text)) = 0 Then
                MessageBox.Show("Please confirm new password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ConfirmPassword.Focus()
                Exit Sub
            End If
            If NewPassword.TextLength < 5 Then
                MessageBox.Show("The New Password Should be of Atleast 5 Characters", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                NewPassword.Text = ""
                ConfirmPassword.Text = ""
                NewPassword.Focus()
                Exit Sub
            ElseIf NewPassword.Text <> ConfirmPassword.Text Then
                MessageBox.Show("Password do not match", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                NewPassword.Text = ""
                OldPassword.Text = ""
                ConfirmPassword.Text = ""
                OldPassword.Focus()
                Exit Sub
            ElseIf OldPassword.Text = NewPassword.Text Then
                MessageBox.Show("Password is same..Re-enter new password", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                NewPassword.Text = ""
                ConfirmPassword.Text = ""
                NewPassword.Focus()
                Exit Sub
            End If
            con = New SqlConnection(cs)
            con.Open()
            Dim co As String = "update Registration set password = '" & Encrypt(NewPassword.Text) & "'where userid='" & UserID.Text & "' and password = '" & Encrypt(OldPassword.Text) & "'"
            cmd = New SqlCommand(co)
            cmd.Connection = con
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then

                MessageBox.Show("Successfully changed", "Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                frmLogin.Show()
                frmLogin.UserID.Text = ""
                frmLogin.Password.Text = ""
                frmLogin.UserID.Focus()
            Else

                MessageBox.Show("invalid user name or password", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                UserID.Text = ""
                NewPassword.Text = ""
                OldPassword.Text = ""
                ConfirmPassword.Text = ""
                UserID.Focus()
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmChangePassword1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        frmLogin.Show()
        frmLogin.UserID.Text = ""
        frmLogin.Password.Text = ""
        frmLogin.UserID.Focus()
    End Sub

    Private Sub frmChangePassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
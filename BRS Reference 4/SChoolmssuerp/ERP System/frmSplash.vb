Imports System.Data.SqlClient
Public Class frmSplash

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            If txtActivationID.Text = TextBox1.Text Then
                ProgressBar1.Visible = True
                ProgressBar1.Value = ProgressBar1.Value + 2
                If (ProgressBar1.Value = 10) Then
                    Label3.Text = "Reading modules.."
                ElseIf (ProgressBar1.Value = 20) Then
                    Label3.Text = "Turning on modules."
                ElseIf (ProgressBar1.Value = 40) Then
                    Label3.Text = "Starting modules.."
                ElseIf (ProgressBar1.Value = 60) Then
                    Label3.Text = "Loading modules.."
                ElseIf (ProgressBar1.Value = 80) Then
                    Label3.Text = "Done Loading modules.."
                ElseIf (ProgressBar1.Value = 100) Then
                    frmLogin.Show()
                    Timer1.Enabled = False
                    Me.Hide()
                End If
            End If
            If txtActivationID.Text <> TextBox1.Text Then
                ProgressBar1.Visible = True
                ProgressBar1.Value = ProgressBar1.Value + 2
                If (ProgressBar1.Value = 10) Then
                    Label3.Text = "Reading modules.."
                ElseIf (ProgressBar1.Value = 20) Then
                    Label3.Text = "Turning on modules."
                ElseIf (ProgressBar1.Value = 40) Then
                    Label3.Text = "Starting modules.."
                ElseIf (ProgressBar1.Value = 60) Then
                    Label3.Text = "Loading modules.."
                ElseIf (ProgressBar1.Value = 80) Then
                    Label3.Text = "Done Loading modules.."
                ElseIf (ProgressBar1.Value = 100) Then
                    frmActivation.Show()
                    Timer1.Enabled = False
                    Me.Hide()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")
            End
        End Try
    End Sub

    Private Sub frmSplash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProgressBar1.Width = Me.Width
        Try
            Dim i As System.Management.ManagementObject
            Dim searchInfo_Processor As New System.Management.ManagementObjectSearcher("Select * from Win32_Processor")
            For Each i In searchInfo_Processor.Get()
                txtHardwareID.Text = i("ProcessorID").ToString
            Next
            Dim searchInfo_Board As New System.Management.ManagementObjectSearcher("Select * from Win32_BaseBoard")
            For Each i In searchInfo_Board.Get()
                txtSerialNo.Text = i("SerialNumber").ToString
            Next
            Dim st As String = (txtHardwareID.Text) + (txtSerialNo.Text)
            TextBox1.Text = Encryption.MakePassword(st, 659)
            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "select RTRIM(ActivationID) from Activation where HardwareID=@d1 and SerialNo=@d2"
            cmd = New SqlCommand(ct)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtHardwareID.Text)
            cmd.Parameters.AddWithValue("@d2", txtSerialNo.Text)
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                txtActivationID.Text = Decrypt(rdr.GetValue(0))
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")
            End
        End Try
    End Sub
End Class
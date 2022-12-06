<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusFeePayment_Staff
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBusFeePayment_Staff))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtTotalPaid = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtPaymentModeDetails = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmbPaymentMode = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dtpPaymentDate = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtFine = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtPreviousDue = New System.Windows.Forms.TextBox()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtDiscountPer = New System.Windows.Forms.TextBox()
        Me.txtGrandTotal = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBusFee = New System.Windows.Forms.TextBox()
        Me.btnGetFeeList = New System.Windows.Forms.Button()
        Me.cmbInstallment = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbSession = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDesignation = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtStaffID = New System.Windows.Forms.TextBox()
        Me.txtStaffName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtSt_ID = New System.Windows.Forms.TextBox()
        Me.txtBusHolderID = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtFeePaymentID = New System.Windows.Forms.TextBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.txtBFPId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnGetData = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.groupBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(13, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(640, 649)
        Me.Panel1.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.txtBalance)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.txtTotalPaid)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.txtPaymentModeDetails)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.cmbPaymentMode)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.dtpPaymentDate)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.txtFine)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.txtPreviousDue)
        Me.GroupBox3.Controls.Add(Me.txtDiscount)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txtDiscountPer)
        Me.GroupBox3.Controls.Add(Me.txtGrandTotal)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(9, 346)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(450, 291)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Payment Info"
        '
        'txtBalance
        '
        Me.txtBalance.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalance.Location = New System.Drawing.Point(166, 256)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.Size = New System.Drawing.Size(135, 21)
        Me.txtBalance.TabIndex = 9
        Me.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(20, 256)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(58, 15)
        Me.Label21.TabIndex = 131
        Me.Label21.Text = "Balance :"
        '
        'txtTotalPaid
        '
        Me.txtTotalPaid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPaid.Location = New System.Drawing.Point(166, 229)
        Me.txtTotalPaid.Name = "txtTotalPaid"
        Me.txtTotalPaid.Size = New System.Drawing.Size(135, 21)
        Me.txtTotalPaid.TabIndex = 8
        Me.txtTotalPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(20, 229)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(68, 15)
        Me.Label20.TabIndex = 129
        Me.Label20.Text = "Total Paid :"
        '
        'txtPaymentModeDetails
        '
        Me.txtPaymentModeDetails.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPaymentModeDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaymentModeDetails.Location = New System.Drawing.Point(166, 173)
        Me.txtPaymentModeDetails.Name = "txtPaymentModeDetails"
        Me.txtPaymentModeDetails.Size = New System.Drawing.Size(271, 21)
        Me.txtPaymentModeDetails.TabIndex = 6
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(20, 173)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(137, 15)
        Me.Label19.TabIndex = 127
        Me.Label19.Text = "Payment Mode Details :"
        '
        'cmbPaymentMode
        '
        Me.cmbPaymentMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPaymentMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPaymentMode.FormattingEnabled = True
        Me.cmbPaymentMode.Items.AddRange(New Object() {"By Cash", "By Cheque", "By DD"})
        Me.cmbPaymentMode.Location = New System.Drawing.Point(166, 143)
        Me.cmbPaymentMode.Name = "cmbPaymentMode"
        Me.cmbPaymentMode.Size = New System.Drawing.Size(135, 23)
        Me.cmbPaymentMode.TabIndex = 5
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(20, 143)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 15)
        Me.Label18.TabIndex = 125
        Me.Label18.Text = "Payment Mode :"
        '
        'dtpPaymentDate
        '
        Me.dtpPaymentDate.CustomFormat = "dd/MMM/yyyy"
        Me.dtpPaymentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPaymentDate.Location = New System.Drawing.Point(166, 116)
        Me.dtpPaymentDate.Name = "dtpPaymentDate"
        Me.dtpPaymentDate.Size = New System.Drawing.Size(135, 21)
        Me.dtpPaymentDate.TabIndex = 4
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(20, 116)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(90, 15)
        Me.Label17.TabIndex = 123
        Me.Label17.Text = "Payment Date :"
        '
        'txtFine
        '
        Me.txtFine.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFine.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFine.Location = New System.Drawing.Point(166, 89)
        Me.txtFine.Name = "txtFine"
        Me.txtFine.Size = New System.Drawing.Size(80, 21)
        Me.txtFine.TabIndex = 3
        Me.txtFine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(20, 89)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(37, 15)
        Me.Label16.TabIndex = 121
        Me.Label16.Text = "Fine :"
        '
        'txtPreviousDue
        '
        Me.txtPreviousDue.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPreviousDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPreviousDue.Location = New System.Drawing.Point(166, 61)
        Me.txtPreviousDue.Name = "txtPreviousDue"
        Me.txtPreviousDue.ReadOnly = True
        Me.txtPreviousDue.Size = New System.Drawing.Size(135, 21)
        Me.txtPreviousDue.TabIndex = 2
        Me.txtPreviousDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiscount
        '
        Me.txtDiscount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.Location = New System.Drawing.Point(263, 33)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.ReadOnly = True
        Me.txtDiscount.Size = New System.Drawing.Size(92, 21)
        Me.txtDiscount.TabIndex = 1
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(239, 36)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(18, 15)
        Me.Label14.TabIndex = 118
        Me.Label14.Text = "%"
        '
        'txtDiscountPer
        '
        Me.txtDiscountPer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDiscountPer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscountPer.Location = New System.Drawing.Point(166, 33)
        Me.txtDiscountPer.Name = "txtDiscountPer"
        Me.txtDiscountPer.ReadOnly = True
        Me.txtDiscountPer.Size = New System.Drawing.Size(64, 21)
        Me.txtDiscountPer.TabIndex = 0
        Me.txtDiscountPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtGrandTotal
        '
        Me.txtGrandTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrandTotal.Location = New System.Drawing.Point(166, 202)
        Me.txtGrandTotal.Name = "txtGrandTotal"
        Me.txtGrandTotal.ReadOnly = True
        Me.txtGrandTotal.Size = New System.Drawing.Size(135, 21)
        Me.txtGrandTotal.TabIndex = 7
        Me.txtGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(20, 202)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 15)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Grand Total :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(20, 61)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 15)
        Me.Label12.TabIndex = 114
        Me.Label12.Text = "Previous Due :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(20, 33)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 15)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Discount :"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtBusFee)
        Me.GroupBox2.Controls.Add(Me.btnGetFeeList)
        Me.GroupBox2.Controls.Add(Me.cmbInstallment)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(9, 251)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(373, 94)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fee Info"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(23, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 15)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Bus Fee :"
        '
        'txtBusFee
        '
        Me.txtBusFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusFee.Location = New System.Drawing.Point(139, 61)
        Me.txtBusFee.Name = "txtBusFee"
        Me.txtBusFee.ReadOnly = True
        Me.txtBusFee.Size = New System.Drawing.Size(91, 21)
        Me.txtBusFee.TabIndex = 7
        Me.txtBusFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnGetFeeList
        '
        Me.btnGetFeeList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetFeeList.ForeColor = System.Drawing.Color.Black
        Me.btnGetFeeList.Location = New System.Drawing.Point(230, 32)
        Me.btnGetFeeList.Name = "btnGetFeeList"
        Me.btnGetFeeList.Size = New System.Drawing.Size(83, 23)
        Me.btnGetFeeList.TabIndex = 1
        Me.btnGetFeeList.Text = "Get Fee Info"
        Me.btnGetFeeList.UseVisualStyleBackColor = True
        '
        'cmbInstallment
        '
        Me.cmbInstallment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbInstallment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbInstallment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbInstallment.FormattingEnabled = True
        Me.cmbInstallment.Items.AddRange(New Object() {"1st", "2nd"})
        Me.cmbInstallment.Location = New System.Drawing.Point(139, 32)
        Me.cmbInstallment.Name = "cmbInstallment"
        Me.cmbInstallment.Size = New System.Drawing.Size(85, 23)
        Me.cmbInstallment.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(23, 32)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(73, 15)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Installment :"
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.Transparent
        Me.groupBox1.Controls.Add(Me.cmbSession)
        Me.groupBox1.Controls.Add(Me.Label2)
        Me.groupBox1.Controls.Add(Me.txtDesignation)
        Me.groupBox1.Controls.Add(Me.Button2)
        Me.groupBox1.Controls.Add(Me.Label5)
        Me.groupBox1.Controls.Add(Me.txtLocation)
        Me.groupBox1.Controls.Add(Me.Label8)
        Me.groupBox1.Controls.Add(Me.txtStaffID)
        Me.groupBox1.Controls.Add(Me.txtStaffName)
        Me.groupBox1.Controls.Add(Me.Label3)
        Me.groupBox1.Controls.Add(Me.Label6)
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.ForeColor = System.Drawing.Color.Black
        Me.groupBox1.Location = New System.Drawing.Point(9, 75)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(492, 169)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Bus Holder Info"
        '
        'cmbSession
        '
        Me.cmbSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSession.FormattingEnabled = True
        Me.cmbSession.Location = New System.Drawing.Point(139, 138)
        Me.cmbSession.Name = "cmbSession"
        Me.cmbSession.Size = New System.Drawing.Size(136, 23)
        Me.cmbSession.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 15)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "Session :"
        '
        'txtDesignation
        '
        Me.txtDesignation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesignation.Location = New System.Drawing.Point(139, 86)
        Me.txtDesignation.Name = "txtDesignation"
        Me.txtDesignation.ReadOnly = True
        Me.txtDesignation.Size = New System.Drawing.Size(142, 21)
        Me.txtDesignation.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(287, 27)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 21)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 15)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "Designation :"
        '
        'txtLocation
        '
        Me.txtLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocation.Location = New System.Drawing.Point(139, 113)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.ReadOnly = True
        Me.txtLocation.Size = New System.Drawing.Size(246, 21)
        Me.txtLocation.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 15)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Location :"
        '
        'txtStaffID
        '
        Me.txtStaffID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffID.Location = New System.Drawing.Point(139, 27)
        Me.txtStaffID.Name = "txtStaffID"
        Me.txtStaffID.ReadOnly = True
        Me.txtStaffID.Size = New System.Drawing.Size(142, 21)
        Me.txtStaffID.TabIndex = 0
        '
        'txtStaffName
        '
        Me.txtStaffName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffName.Location = New System.Drawing.Point(139, 54)
        Me.txtStaffName.Multiline = True
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.ReadOnly = True
        Me.txtStaffName.Size = New System.Drawing.Size(338, 24)
        Me.txtStaffName.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Staff ID :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 15)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Staff Name :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.txtSt_ID)
        Me.Panel2.Controls.Add(Me.txtBusHolderID)
        Me.Panel2.Controls.Add(Me.txtID)
        Me.Panel2.Controls.Add(Me.txtFeePaymentID)
        Me.Panel2.Controls.Add(Me.lblUser)
        Me.Panel2.Controls.Add(Me.txtBFPId)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(9, 7)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(618, 62)
        Me.Panel2.TabIndex = 0
        '
        'txtSt_ID
        '
        Me.txtSt_ID.Location = New System.Drawing.Point(110, 39)
        Me.txtSt_ID.Name = "txtSt_ID"
        Me.txtSt_ID.Size = New System.Drawing.Size(81, 20)
        Me.txtSt_ID.TabIndex = 330
        Me.txtSt_ID.Visible = False
        '
        'txtBusHolderID
        '
        Me.txtBusHolderID.Location = New System.Drawing.Point(25, 20)
        Me.txtBusHolderID.Name = "txtBusHolderID"
        Me.txtBusHolderID.Size = New System.Drawing.Size(81, 20)
        Me.txtBusHolderID.TabIndex = 328
        Me.txtBusHolderID.Visible = False
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(23, 39)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(81, 20)
        Me.txtID.TabIndex = 328
        Me.txtID.Visible = False
        '
        'txtFeePaymentID
        '
        Me.txtFeePaymentID.Location = New System.Drawing.Point(110, 20)
        Me.txtFeePaymentID.Name = "txtFeePaymentID"
        Me.txtFeePaymentID.Size = New System.Drawing.Size(81, 20)
        Me.txtFeePaymentID.TabIndex = 45
        Me.txtFeePaymentID.Visible = False
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(113, 4)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(39, 13)
        Me.lblUser.TabIndex = 43
        Me.lblUser.Text = "Label8"
        Me.lblUser.Visible = False
        '
        'txtBFPId
        '
        Me.txtBFPId.Location = New System.Drawing.Point(23, 20)
        Me.txtBFPId.Name = "txtBFPId"
        Me.txtBFPId.Size = New System.Drawing.Size(81, 20)
        Me.txtBFPId.TabIndex = 44
        Me.txtBFPId.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(211, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bus Fee Payment"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnPrint)
        Me.Panel3.Controls.Add(Me.btnClose)
        Me.Panel3.Controls.Add(Me.btnGetData)
        Me.Panel3.Controls.Add(Me.btnDelete)
        Me.Panel3.Controls.Add(Me.btnUpdate)
        Me.Panel3.Controls.Add(Me.btnSave)
        Me.Panel3.Controls.Add(Me.btnNew)
        Me.Panel3.Location = New System.Drawing.Point(516, 82)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(111, 235)
        Me.Panel3.TabIndex = 41
        '
        'btnPrint
        '
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.Enabled = False
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(13, 165)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(82, 28)
        Me.btnPrint.TabIndex = 45
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(13, 197)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(82, 28)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnGetData
        '
        Me.btnGetData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGetData.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGetData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetData.Location = New System.Drawing.Point(13, 133)
        Me.btnGetData.Name = "btnGetData"
        Me.btnGetData.Size = New System.Drawing.Size(82, 28)
        Me.btnGetData.TabIndex = 5
        Me.btnGetData.Text = "Get Data"
        Me.btnGetData.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Enabled = False
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(13, 101)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(82, 28)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(13, 69)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(82, 28)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(13, 38)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(82, 28)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save + Print"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(13, 7)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(82, 28)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'frmBusFeePayment_Staff
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(663, 676)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBusFeePayment_Staff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents txtBFPId As System.Windows.Forms.TextBox
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents txtFeePaymentID As System.Windows.Forms.TextBox
    Friend WithEvents btnGetData As System.Windows.Forms.Button
    Public WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents txtDesignation As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Private WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents txtLocation As System.Windows.Forms.TextBox
    Private WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtStaffID As System.Windows.Forms.TextBox
    Friend WithEvents txtStaffName As System.Windows.Forms.TextBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGetFeeList As System.Windows.Forms.Button
    Friend WithEvents cmbInstallment As System.Windows.Forms.ComboBox
    Private WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Public WithEvents txtBalance As System.Windows.Forms.TextBox
    Private WithEvents Label21 As System.Windows.Forms.Label
    Public WithEvents txtTotalPaid As System.Windows.Forms.TextBox
    Private WithEvents Label20 As System.Windows.Forms.Label
    Public WithEvents txtPaymentModeDetails As System.Windows.Forms.TextBox
    Private WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmbPaymentMode As System.Windows.Forms.ComboBox
    Private WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents dtpPaymentDate As System.Windows.Forms.DateTimePicker
    Private WithEvents Label17 As System.Windows.Forms.Label
    Public WithEvents txtFine As System.Windows.Forms.TextBox
    Private WithEvents Label16 As System.Windows.Forms.Label
    Public WithEvents txtPreviousDue As System.Windows.Forms.TextBox
    Public WithEvents txtDiscount As System.Windows.Forms.TextBox
    Private WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents txtDiscountPer As System.Windows.Forms.TextBox
    Public WithEvents txtGrandTotal As System.Windows.Forms.TextBox
    Private WithEvents Label11 As System.Windows.Forms.Label
    Private WithEvents Label12 As System.Windows.Forms.Label
    Private WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Private WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents txtBusFee As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtBusHolderID As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Private WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbSession As System.Windows.Forms.ComboBox
    Friend WithEvents txtSt_ID As System.Windows.Forms.TextBox

End Class

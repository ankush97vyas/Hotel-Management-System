<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class checkout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(checkout))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmbpay = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbid = New System.Windows.Forms.ComboBox()
        Me.txtcty = New System.Windows.Forms.TextBox()
        Me.tgender = New System.Windows.Forms.TextBox()
        Me.mstno = New System.Windows.Forms.MaskedTextBox()
        Me.txtstate = New System.Windows.Forms.TextBox()
        Me.comboid = New System.Windows.Forms.ComboBox()
        Me.txtidconf = New System.Windows.Forms.TextBox()
        Me.txtadd = New System.Windows.Forms.TextBox()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lbltot = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnok = New System.Windows.Forms.Button()
        Me.btnclos = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtstay = New System.Windows.Forms.TextBox()
        Me.dtpin = New System.Windows.Forms.DateTimePicker()
        Me.dtpout = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtpre = New System.Windows.Forms.TextBox()
        Me.txtrem = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Calligraphy", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(397, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 57)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Check OUT"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(246, -3)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 118)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'cmbpay
        '
        Me.cmbpay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbpay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbpay.FormattingEnabled = True
        Me.cmbpay.Items.AddRange(New Object() {"Cash ", "Debit Card " & Global.Microsoft.VisualBasic.ChrW(9), "Credit card", "Net bankig "})
        Me.cmbpay.Location = New System.Drawing.Point(659, 362)
        Me.cmbpay.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.cmbpay.Name = "cmbpay"
        Me.cmbpay.Size = New System.Drawing.Size(178, 26)
        Me.cmbpay.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(557, 361)
        Me.Label11.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 31)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Pay :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmbid)
        Me.GroupBox1.Controls.Add(Me.txtcty)
        Me.GroupBox1.Controls.Add(Me.tgender)
        Me.GroupBox1.Controls.Add(Me.mstno)
        Me.GroupBox1.Controls.Add(Me.txtstate)
        Me.GroupBox1.Controls.Add(Me.comboid)
        Me.GroupBox1.Controls.Add(Me.txtidconf)
        Me.GroupBox1.Controls.Add(Me.txtadd)
        Me.GroupBox1.Controls.Add(Me.txtage)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 99)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(406, 422)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer's Info "
        '
        'cmbid
        '
        Me.cmbid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbid.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbid.FormattingEnabled = True
        Me.cmbid.Location = New System.Drawing.Point(173, 33)
        Me.cmbid.Name = "cmbid"
        Me.cmbid.Size = New System.Drawing.Size(205, 26)
        Me.cmbid.TabIndex = 45
        '
        'txtcty
        '
        Me.txtcty.Enabled = False
        Me.txtcty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcty.Location = New System.Drawing.Point(174, 233)
        Me.txtcty.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtcty.Name = "txtcty"
        Me.txtcty.Size = New System.Drawing.Size(204, 26)
        Me.txtcty.TabIndex = 44
        '
        'tgender
        '
        Me.tgender.Enabled = False
        Me.tgender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgender.Location = New System.Drawing.Point(174, 130)
        Me.tgender.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tgender.Name = "tgender"
        Me.tgender.Size = New System.Drawing.Size(204, 26)
        Me.tgender.TabIndex = 44
        '
        'mstno
        '
        Me.mstno.Enabled = False
        Me.mstno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mstno.Location = New System.Drawing.Point(175, 301)
        Me.mstno.Mask = "999- 000-0000"
        Me.mstno.Name = "mstno"
        Me.mstno.Size = New System.Drawing.Size(100, 24)
        Me.mstno.TabIndex = 43
        '
        'txtstate
        '
        Me.txtstate.Enabled = False
        Me.txtstate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstate.Location = New System.Drawing.Point(173, 264)
        Me.txtstate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtstate.Name = "txtstate"
        Me.txtstate.Size = New System.Drawing.Size(204, 26)
        Me.txtstate.TabIndex = 8
        '
        'comboid
        '
        Me.comboid.Enabled = False
        Me.comboid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboid.FormattingEnabled = True
        Me.comboid.Items.AddRange(New Object() {"PASSPORT ", "ADHAAR CARD"})
        Me.comboid.Location = New System.Drawing.Point(172, 328)
        Me.comboid.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.comboid.Name = "comboid"
        Me.comboid.Size = New System.Drawing.Size(204, 25)
        Me.comboid.TabIndex = 10
        '
        'txtidconf
        '
        Me.txtidconf.Enabled = False
        Me.txtidconf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidconf.Location = New System.Drawing.Point(172, 361)
        Me.txtidconf.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtidconf.Name = "txtidconf"
        Me.txtidconf.Size = New System.Drawing.Size(204, 26)
        Me.txtidconf.TabIndex = 11
        '
        'txtadd
        '
        Me.txtadd.Enabled = False
        Me.txtadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtadd.Location = New System.Drawing.Point(175, 167)
        Me.txtadd.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtadd.Multiline = True
        Me.txtadd.Name = "txtadd"
        Me.txtadd.Size = New System.Drawing.Size(204, 54)
        Me.txtadd.TabIndex = 6
        '
        'txtage
        '
        Me.txtage.Enabled = False
        Me.txtage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtage.Location = New System.Drawing.Point(175, 96)
        Me.txtage.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(204, 26)
        Me.txtage.TabIndex = 3
        '
        'txtname
        '
        Me.txtname.Enabled = False
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(175, 64)
        Me.txtname.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(204, 26)
        Me.txtname.TabIndex = 2
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(56, 301)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(118, 23)
        Me.Label23.TabIndex = 37
        Me.Label23.Text = "Mobile NO.:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(72, 166)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 23)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Address :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(96, 236)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 23)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "City :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(100, 95)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(57, 23)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "Age :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(67, 331)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(102, 23)
        Me.Label18.TabIndex = 41
        Me.Label18.Text = "ID Proof :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(85, 265)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(67, 23)
        Me.Label20.TabIndex = 42
        Me.Label20.Text = "State :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(79, 130)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(85, 23)
        Me.Label21.TabIndex = 40
        Me.Label21.Text = "Gender :"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(45, 35)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(138, 23)
        Me.Label24.TabIndex = 38
        Me.Label24.Text = "Customer ID :"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(13, 65)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(180, 23)
        Me.Label25.TabIndex = 39
        Me.Label25.Text = "Customer's Name :"
        '
        'lbltot
        '
        Me.lbltot.AutoSize = True
        Me.lbltot.BackColor = System.Drawing.Color.Transparent
        Me.lbltot.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltot.Location = New System.Drawing.Point(694, 398)
        Me.lbltot.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbltot.Name = "lbltot"
        Me.lbltot.Size = New System.Drawing.Size(216, 41)
        Me.lbltot.TabIndex = 15
        Me.lbltot.Text = "___________"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Lucida Calligraphy", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(523, 409)
        Me.Label10.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(239, 24)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Total Payment ₹/-    "
        '
        'btnok
        '
        Me.btnok.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnok.Location = New System.Drawing.Point(722, 496)
        Me.btnok.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(70, 25)
        Me.btnok.TabIndex = 18
        Me.btnok.Text = "Ok"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'btnclos
        '
        Me.btnclos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclos.Location = New System.Drawing.Point(800, 496)
        Me.btnclos.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnclos.Name = "btnclos"
        Me.btnclos.Size = New System.Drawing.Size(67, 25)
        Me.btnclos.TabIndex = 19
        Me.btnclos.Text = "Close"
        Me.btnclos.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(21, 32)
        Me.Label12.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 23)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Check In  :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(30, 62)
        Me.Label13.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 23)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Staying :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(14, 91)
        Me.Label14.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 23)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Check Out :"
        '
        'txtstay
        '
        Me.txtstay.Enabled = False
        Me.txtstay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstay.Location = New System.Drawing.Point(114, 59)
        Me.txtstay.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtstay.Name = "txtstay"
        Me.txtstay.Size = New System.Drawing.Size(202, 23)
        Me.txtstay.TabIndex = 13
        '
        'dtpin
        '
        Me.dtpin.Enabled = False
        Me.dtpin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpin.Location = New System.Drawing.Point(114, 28)
        Me.dtpin.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.dtpin.Name = "dtpin"
        Me.dtpin.Size = New System.Drawing.Size(202, 23)
        Me.dtpin.TabIndex = 12
        '
        'dtpout
        '
        Me.dtpout.Enabled = False
        Me.dtpout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpout.Location = New System.Drawing.Point(114, 89)
        Me.dtpout.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.dtpout.Name = "dtpout"
        Me.dtpout.Size = New System.Drawing.Size(202, 23)
        Me.dtpout.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(25, 121)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 23)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Prepaid :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 150)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 23)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Remain  :"
        '
        'txtpre
        '
        Me.txtpre.Enabled = False
        Me.txtpre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpre.Location = New System.Drawing.Point(116, 119)
        Me.txtpre.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtpre.Name = "txtpre"
        Me.txtpre.Size = New System.Drawing.Size(200, 23)
        Me.txtpre.TabIndex = 15
        '
        'txtrem
        '
        Me.txtrem.Enabled = False
        Me.txtrem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrem.Location = New System.Drawing.Point(116, 151)
        Me.txtrem.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtrem.Name = "txtrem"
        Me.txtrem.Size = New System.Drawing.Size(200, 23)
        Me.txtrem.TabIndex = 16
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.txtrem)
        Me.GroupBox3.Controls.Add(Me.txtpre)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.dtpout)
        Me.GroupBox3.Controls.Add(Me.dtpin)
        Me.GroupBox3.Controls.Add(Me.txtstay)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(444, 124)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(423, 198)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Other Detail"
        '
        'checkout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(889, 541)
        Me.Controls.Add(Me.btnclos)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.lbltot)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbpay)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Lucida Calligraphy", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "checkout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "5"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmbpay As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbltot As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents btnclos As System.Windows.Forms.Button
    Friend WithEvents txtstate As System.Windows.Forms.TextBox
    Friend WithEvents comboid As System.Windows.Forms.ComboBox
    Friend WithEvents txtidconf As System.Windows.Forms.TextBox
    Friend WithEvents txtadd As System.Windows.Forms.TextBox
    Friend WithEvents txtage As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtstay As System.Windows.Forms.TextBox
    Friend WithEvents dtpin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpout As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtpre As System.Windows.Forms.TextBox
    Friend WithEvents txtrem As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents mstno As System.Windows.Forms.MaskedTextBox
    Friend WithEvents tgender As System.Windows.Forms.TextBox
    Friend WithEvents txtcty As System.Windows.Forms.TextBox
    Friend WithEvents cmbid As System.Windows.Forms.ComboBox
End Class

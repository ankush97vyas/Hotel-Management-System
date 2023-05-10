<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class custinfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(custinfo))
        Me.btnclose = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbid = New System.Windows.Forms.ComboBox()
        Me.dtpout = New System.Windows.Forms.DateTimePicker()
        Me.dtpin = New System.Windows.Forms.DateTimePicker()
        Me.txtsty = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.mstno = New System.Windows.Forms.MaskedTextBox()
        Me.txtcty = New System.Windows.Forms.TextBox()
        Me.comboid = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbstate = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtidc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtadd = New System.Windows.Forms.TextBox()
        Me.txtgender = New System.Windows.Forms.TextBox()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btncon = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(863, 555)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(63, 23)
        Me.btnclose.TabIndex = 3
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(-5, 546)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(170, 39)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "  Information"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(-3, 525)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 28)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Customer"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmbid)
        Me.GroupBox1.Controls.Add(Me.dtpout)
        Me.GroupBox1.Controls.Add(Me.dtpin)
        Me.GroupBox1.Controls.Add(Me.txtsty)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.mstno)
        Me.GroupBox1.Controls.Add(Me.txtcty)
        Me.GroupBox1.Controls.Add(Me.comboid)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmbstate)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtidc)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtadd)
        Me.GroupBox1.Controls.Add(Me.txtgender)
        Me.GroupBox1.Controls.Add(Me.txtage)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(2, -4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(932, 206)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cmbid
        '
        Me.cmbid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbid.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbid.FormattingEnabled = True
        Me.cmbid.Location = New System.Drawing.Point(120, 19)
        Me.cmbid.Name = "cmbid"
        Me.cmbid.Size = New System.Drawing.Size(86, 23)
        Me.cmbid.TabIndex = 46
        '
        'dtpout
        '
        Me.dtpout.Enabled = False
        Me.dtpout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpout.Location = New System.Drawing.Point(721, 83)
        Me.dtpout.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.dtpout.Name = "dtpout"
        Me.dtpout.Size = New System.Drawing.Size(202, 20)
        Me.dtpout.TabIndex = 13
        '
        'dtpin
        '
        Me.dtpin.Enabled = False
        Me.dtpin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpin.Location = New System.Drawing.Point(721, 22)
        Me.dtpin.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.dtpin.Name = "dtpin"
        Me.dtpin.Size = New System.Drawing.Size(202, 20)
        Me.dtpin.TabIndex = 11
        '
        'txtsty
        '
        Me.txtsty.Enabled = False
        Me.txtsty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsty.Location = New System.Drawing.Point(721, 53)
        Me.txtsty.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtsty.Name = "txtsty"
        Me.txtsty.Size = New System.Drawing.Size(65, 20)
        Me.txtsty.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(624, 85)
        Me.Label14.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 17)
        Me.Label14.TabIndex = 89
        Me.Label14.Text = "Check Out :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label13.Location = New System.Drawing.Point(640, 54)
        Me.Label13.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 17)
        Me.Label13.TabIndex = 90
        Me.Label13.Text = "Staying :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(631, 26)
        Me.Label12.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 17)
        Me.Label12.TabIndex = 91
        Me.Label12.Text = "Check In  :"
        '
        'mstno
        '
        Me.mstno.Enabled = False
        Me.mstno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mstno.Location = New System.Drawing.Point(419, 85)
        Me.mstno.Mask = "999- 000-0000"
        Me.mstno.Name = "mstno"
        Me.mstno.Size = New System.Drawing.Size(100, 21)
        Me.mstno.TabIndex = 8
        '
        'txtcty
        '
        Me.txtcty.Enabled = False
        Me.txtcty.Location = New System.Drawing.Point(419, 23)
        Me.txtcty.Name = "txtcty"
        Me.txtcty.Size = New System.Drawing.Size(191, 20)
        Me.txtcty.TabIndex = 6
        '
        'comboid
        '
        Me.comboid.Enabled = False
        Me.comboid.FormattingEnabled = True
        Me.comboid.Location = New System.Drawing.Point(419, 114)
        Me.comboid.Name = "comboid"
        Me.comboid.Size = New System.Drawing.Size(191, 21)
        Me.comboid.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(315, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 17)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Mobile  NO :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(330, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 17)
        Me.Label6.TabIndex = 83
        Me.Label6.Text = "ID Proof :"
        '
        'cmbstate
        '
        Me.cmbstate.Enabled = False
        Me.cmbstate.FormattingEnabled = True
        Me.cmbstate.Location = New System.Drawing.Point(419, 53)
        Me.cmbstate.Name = "cmbstate"
        Me.cmbstate.Size = New System.Drawing.Size(191, 21)
        Me.cmbstate.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(365, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 17)
        Me.Label7.TabIndex = 80
        Me.Label7.Text = "City :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(358, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 17)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "State :"
        '
        'txtidc
        '
        Me.txtidc.Enabled = False
        Me.txtidc.Location = New System.Drawing.Point(419, 145)
        Me.txtidc.Name = "txtidc"
        Me.txtidc.Size = New System.Drawing.Size(191, 20)
        Me.txtidc.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(16, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 17)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "customer ID :"
        '
        'txtadd
        '
        Me.txtadd.Enabled = False
        Me.txtadd.Location = New System.Drawing.Point(120, 132)
        Me.txtadd.Multiline = True
        Me.txtadd.Name = "txtadd"
        Me.txtadd.Size = New System.Drawing.Size(191, 56)
        Me.txtadd.TabIndex = 5
        '
        'txtgender
        '
        Me.txtgender.Enabled = False
        Me.txtgender.Location = New System.Drawing.Point(120, 103)
        Me.txtgender.Name = "txtgender"
        Me.txtgender.Size = New System.Drawing.Size(191, 20)
        Me.txtgender.TabIndex = 4
        '
        'txtage
        '
        Me.txtage.Enabled = False
        Me.txtage.Location = New System.Drawing.Point(120, 74)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(191, 20)
        Me.txtage.TabIndex = 3
        '
        'txtname
        '
        Me.txtname.Enabled = False
        Me.txtname.Location = New System.Drawing.Point(120, 47)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(191, 20)
        Me.txtname.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(51, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 17)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Gender :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(42, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 17)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Address :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(73, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 17)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Age :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(-4, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 17)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "customer name :"
        '
        'btnupdate
        '
        Me.btnupdate.Enabled = False
        Me.btnupdate.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(689, 555)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 23)
        Me.btnupdate.TabIndex = 8
        Me.btnupdate.Text = "Edit"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btncon
        '
        Me.btncon.Enabled = False
        Me.btncon.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncon.Location = New System.Drawing.Point(771, 555)
        Me.btncon.Name = "btncon"
        Me.btncon.Size = New System.Drawing.Size(85, 23)
        Me.btncon.TabIndex = 9
        Me.btncon.Text = "Update"
        Me.btncon.UseVisualStyleBackColor = True
        '
        'custinfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(935, 586)
        Me.Controls.Add(Me.btncon)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnclose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "custinfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "custinfo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpout As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpin As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtsty As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents mstno As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtcty As System.Windows.Forms.TextBox
    Friend WithEvents comboid As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbstate As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtidc As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtadd As System.Windows.Forms.TextBox
    Friend WithEvents txtgender As System.Windows.Forms.TextBox
    Friend WithEvents txtage As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btncon As System.Windows.Forms.Button
    Friend WithEvents cmbid As System.Windows.Forms.ComboBox
End Class

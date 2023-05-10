<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class outreport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(outreport))
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Age = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.City = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.State = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mobile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Passpport = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ad_card = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Check_IN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Check_OUT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.T_member = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Child = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Adults = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Floor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remain = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.T_payment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.C_name, Me.Age, Me.Gender, Me.Address, Me.City, Me.State, Me.Mobile, Me.Passpport, Me.ad_card, Me.Check_IN, Me.Stay, Me.Check_OUT, Me.T_member, Me.Child, Me.Adults, Me.R_type, Me.R_no, Me.Floor, Me.Amount, Me.Pre, Me.Remain, Me.T_payment})
        Me.dgv.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.dgv.Location = New System.Drawing.Point(11, 111)
        Me.dgv.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(1796, 553)
        Me.dgv.TabIndex = 9
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'C_name
        '
        Me.C_name.HeaderText = "C_name"
        Me.C_name.Name = "C_name"
        Me.C_name.ReadOnly = True
        '
        'Age
        '
        Me.Age.HeaderText = "Age"
        Me.Age.Name = "Age"
        Me.Age.ReadOnly = True
        '
        'Gender
        '
        Me.Gender.HeaderText = "Gender"
        Me.Gender.Name = "Gender"
        Me.Gender.ReadOnly = True
        '
        'Address
        '
        Me.Address.HeaderText = "Address"
        Me.Address.Name = "Address"
        Me.Address.ReadOnly = True
        '
        'City
        '
        Me.City.HeaderText = "City"
        Me.City.Name = "City"
        Me.City.ReadOnly = True
        '
        'State
        '
        Me.State.HeaderText = "State"
        Me.State.Name = "State"
        Me.State.ReadOnly = True
        '
        'Mobile
        '
        Me.Mobile.HeaderText = "Mobile"
        Me.Mobile.Name = "Mobile"
        Me.Mobile.ReadOnly = True
        '
        'Passpport
        '
        Me.Passpport.HeaderText = "Passport"
        Me.Passpport.Name = "Passpport"
        Me.Passpport.ReadOnly = True
        '
        'ad_card
        '
        Me.ad_card.HeaderText = "ad_card"
        Me.ad_card.Name = "ad_card"
        Me.ad_card.ReadOnly = True
        '
        'Check_IN
        '
        Me.Check_IN.HeaderText = "Check _IN"
        Me.Check_IN.Name = "Check_IN"
        Me.Check_IN.ReadOnly = True
        '
        'Stay
        '
        Me.Stay.HeaderText = "Stay"
        Me.Stay.Name = "Stay"
        Me.Stay.ReadOnly = True
        '
        'Check_OUT
        '
        Me.Check_OUT.HeaderText = "Check_OUT"
        Me.Check_OUT.Name = "Check_OUT"
        Me.Check_OUT.ReadOnly = True
        '
        'T_member
        '
        Me.T_member.HeaderText = "T_member"
        Me.T_member.Name = "T_member"
        Me.T_member.ReadOnly = True
        '
        'Child
        '
        Me.Child.HeaderText = "Child"
        Me.Child.Name = "Child"
        Me.Child.ReadOnly = True
        '
        'Adults
        '
        Me.Adults.HeaderText = "Adults"
        Me.Adults.Name = "Adults"
        Me.Adults.ReadOnly = True
        '
        'R_type
        '
        Me.R_type.HeaderText = "R_type"
        Me.R_type.Name = "R_type"
        Me.R_type.ReadOnly = True
        '
        'R_no
        '
        Me.R_no.HeaderText = "R_no"
        Me.R_no.Name = "R_no"
        Me.R_no.ReadOnly = True
        '
        'Floor
        '
        Me.Floor.HeaderText = "Floor"
        Me.Floor.Name = "Floor"
        Me.Floor.ReadOnly = True
        '
        'Amount
        '
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        '
        'Pre
        '
        Me.Pre.HeaderText = "Pre"
        Me.Pre.Name = "Pre"
        Me.Pre.ReadOnly = True
        '
        'Remain
        '
        Me.Remain.HeaderText = "Remain"
        Me.Remain.Name = "Remain"
        Me.Remain.ReadOnly = True
        '
        'T_payment
        '
        Me.T_payment.HeaderText = "T_payment"
        Me.T_payment.Name = "T_payment"
        Me.T_payment.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Edwardian Script ITC", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(120, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 71)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Report Details"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("High Tower Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(696, 679)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(297, 28)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "TOTAL OF CUSTOMER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1029, 676)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 31)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Label2"
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1728, 671)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(79, 32)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Script", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(-1, 670)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(308, 48)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Check Out Details"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 4)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 107)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'outreport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(1827, 713)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "outreport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "outreport"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Age As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Gender As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents City As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents State As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mobile As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Passpport As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ad_card As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Check_IN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Stay As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Check_OUT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T_member As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Child As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Adults As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R_type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Floor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Remain As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T_payment As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class

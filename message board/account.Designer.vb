<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class account
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblacc2 = New System.Windows.Forms.Label()
        Me.panelcompose = New System.Windows.Forms.Panel()
        Me.cmbloc = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblsub = New System.Windows.Forms.Label()
        Me.lblto = New System.Windows.Forms.Label()
        Me.txtsub = New System.Windows.Forms.TextBox()
        Me.txtrcr = New System.Windows.Forms.TextBox()
        Me.rtb = New System.Windows.Forms.RichTextBox()
        Me.lblinbox = New System.Windows.Forms.Label()
        Me.lblsent = New System.Windows.Forms.Label()
        Me.lbltrash = New System.Windows.Forms.Label()
        Me.lbldraft = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lsbonuser = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lsboffuser = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.panelcompose.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblacc2
        '
        Me.lblacc2.AutoSize = True
        Me.lblacc2.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblacc2.ForeColor = System.Drawing.Color.Fuchsia
        Me.lblacc2.Location = New System.Drawing.Point(359, 34)
        Me.lblacc2.Name = "lblacc2"
        Me.lblacc2.Size = New System.Drawing.Size(187, 35)
        Me.lblacc2.TabIndex = 2
        Me.lblacc2.Text = "MENSAGENS"
        '
        'panelcompose
        '
        Me.panelcompose.BackColor = System.Drawing.Color.Azure
        Me.panelcompose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelcompose.Controls.Add(Me.cmbloc)
        Me.panelcompose.Controls.Add(Me.Label11)
        Me.panelcompose.Controls.Add(Me.lblsub)
        Me.panelcompose.Controls.Add(Me.lblto)
        Me.panelcompose.Controls.Add(Me.txtsub)
        Me.panelcompose.Controls.Add(Me.txtrcr)
        Me.panelcompose.Controls.Add(Me.rtb)
        Me.panelcompose.Location = New System.Drawing.Point(158, 90)
        Me.panelcompose.Name = "panelcompose"
        Me.panelcompose.Size = New System.Drawing.Size(567, 411)
        Me.panelcompose.TabIndex = 10
        '
        'cmbloc
        '
        Me.cmbloc.FormattingEnabled = True
        Me.cmbloc.Items.AddRange(New Object() {"One", "HostelA", "HostelB", "HostelC", "HostelD", "Library", "Labs", "HODs", "Office"})
        Me.cmbloc.Location = New System.Drawing.Point(87, 65)
        Me.cmbloc.Name = "cmbloc"
        Me.cmbloc.Size = New System.Drawing.Size(462, 21)
        Me.cmbloc.TabIndex = 41
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 66)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 16)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Send to Group"
        '
        'lblsub
        '
        Me.lblsub.AutoSize = True
        Me.lblsub.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsub.Location = New System.Drawing.Point(24, 111)
        Me.lblsub.Name = "lblsub"
        Me.lblsub.Size = New System.Drawing.Size(60, 16)
        Me.lblsub.TabIndex = 4
        Me.lblsub.Text = "Subject:"
        '
        'lblto
        '
        Me.lblto.AutoSize = True
        Me.lblto.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblto.Location = New System.Drawing.Point(24, 26)
        Me.lblto.Name = "lblto"
        Me.lblto.Size = New System.Drawing.Size(25, 16)
        Me.lblto.TabIndex = 3
        Me.lblto.Text = "To:"
        '
        'txtsub
        '
        Me.txtsub.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsub.Location = New System.Drawing.Point(87, 108)
        Me.txtsub.Name = "txtsub"
        Me.txtsub.Size = New System.Drawing.Size(462, 22)
        Me.txtsub.TabIndex = 2
        Me.txtsub.Text = " "
        '
        'txtrcr
        '
        Me.txtrcr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrcr.Location = New System.Drawing.Point(87, 23)
        Me.txtrcr.Name = "txtrcr"
        Me.txtrcr.Size = New System.Drawing.Size(462, 22)
        Me.txtrcr.TabIndex = 1
        '
        'rtb
        '
        Me.rtb.Location = New System.Drawing.Point(16, 136)
        Me.rtb.Name = "rtb"
        Me.rtb.Size = New System.Drawing.Size(533, 254)
        Me.rtb.TabIndex = 5
        Me.rtb.Text = ""
        '
        'lblinbox
        '
        Me.lblinbox.AutoSize = True
        Me.lblinbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinbox.ForeColor = System.Drawing.Color.Red
        Me.lblinbox.Location = New System.Drawing.Point(42, 227)
        Me.lblinbox.Name = "lblinbox"
        Me.lblinbox.Size = New System.Drawing.Size(53, 20)
        Me.lblinbox.TabIndex = 6
        Me.lblinbox.Text = "Inbox"
        '
        'lblsent
        '
        Me.lblsent.AutoSize = True
        Me.lblsent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsent.ForeColor = System.Drawing.Color.Red
        Me.lblsent.Location = New System.Drawing.Point(45, 332)
        Me.lblsent.Name = "lblsent"
        Me.lblsent.Size = New System.Drawing.Size(47, 20)
        Me.lblsent.TabIndex = 8
        Me.lblsent.Text = "Sent"
        '
        'lbltrash
        '
        Me.lbltrash.AutoSize = True
        Me.lbltrash.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltrash.ForeColor = System.Drawing.Color.Red
        Me.lbltrash.Location = New System.Drawing.Point(39, 543)
        Me.lbltrash.Name = "lbltrash"
        Me.lbltrash.Size = New System.Drawing.Size(54, 20)
        Me.lbltrash.TabIndex = 11
        Me.lbltrash.Text = "Trash"
        '
        'lbldraft
        '
        Me.lbldraft.AutoSize = True
        Me.lbldraft.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldraft.ForeColor = System.Drawing.Color.Red
        Me.lbldraft.Location = New System.Drawing.Point(23, 81)
        Me.lbldraft.Name = "lbldraft"
        Me.lbldraft.Size = New System.Drawing.Size(50, 20)
        Me.lbldraft.TabIndex = 12
        Me.lbldraft.Text = "Draft"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(217, 520)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Discard"
        '
        'lsbonuser
        '
        Me.lsbonuser.FormattingEnabled = True
        Me.lsbonuser.Location = New System.Drawing.Point(738, 339)
        Me.lsbonuser.Name = "lsbonuser"
        Me.lsbonuser.Size = New System.Drawing.Size(154, 160)
        Me.lsbonuser.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(625, 520)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 20)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Send To All"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(780, 309)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 20)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Online Users"
        '
        'lsboffuser
        '
        Me.lsboffuser.FormattingEnabled = True
        Me.lsboffuser.Location = New System.Drawing.Point(738, 137)
        Me.lsboffuser.Name = "lsboffuser"
        Me.lsboffuser.Size = New System.Drawing.Size(154, 160)
        Me.lsboffuser.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(795, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 20)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "All Users"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(738, 111)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(154, 20)
        Me.TextBox3.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(498, 520)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 20)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Send"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(816, 520)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 20)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "LogOut"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox14)
        Me.Panel1.Controls.Add(Me.lbldraft)
        Me.Panel1.Location = New System.Drawing.Point(20, 355)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(95, 100)
        Me.Panel1.TabIndex = 35
        '
        'PictureBox14
        '
        Me.PictureBox14.Image = Global.message_board.My.Resources.Resources.mail_icon
        Me.PictureBox14.Location = New System.Drawing.Point(11, 6)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(72, 72)
        Me.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox14.TabIndex = 14
        Me.PictureBox14.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(625, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 24)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Label7"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(771, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 24)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Label8"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox13
        '
        Me.PictureBox13.Image = Global.message_board.My.Resources.Resources.gear_gold
        Me.PictureBox13.Location = New System.Drawing.Point(759, 509)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(51, 48)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox13.TabIndex = 33
        Me.PictureBox13.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = Global.message_board.My.Resources.Resources.global_connect
        Me.PictureBox12.Location = New System.Drawing.Point(431, 505)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(79, 52)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox12.TabIndex = 31
        Me.PictureBox12.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = Global.message_board.My.Resources.Resources.RTEmagicC_message_board_03_jpg
        Me.PictureBox11.Location = New System.Drawing.Point(552, 34)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(45, 50)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox11.TabIndex = 29
        Me.PictureBox11.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = Global.message_board.My.Resources.Resources.communication51
        Me.PictureBox10.Location = New System.Drawing.Point(738, 71)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(51, 34)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 27
        Me.PictureBox10.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = Global.message_board.My.Resources.Resources.user_check
        Me.PictureBox9.Location = New System.Drawing.Point(738, 303)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(36, 30)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox9.TabIndex = 23
        Me.PictureBox9.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.message_board.My.Resources.Resources.delicous
        Me.PictureBox8.Location = New System.Drawing.Point(568, 505)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(51, 52)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 21
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.message_board.My.Resources.Resources.pencil
        Me.PictureBox7.Location = New System.Drawing.Point(158, 507)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(53, 52)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 18
        Me.PictureBox7.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.message_board.My.Resources.Resources.Inbox
        Me.PictureBox4.Location = New System.Drawing.Point(29, 157)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(74, 68)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 15
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.message_board.My.Resources.Resources.Empty_Trash
        Me.PictureBox5.Location = New System.Drawing.Point(29, 465)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(74, 75)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 16
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.message_board.My.Resources.Resources.send
        Me.PictureBox6.Location = New System.Drawing.Point(29, 250)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(74, 79)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 17
        Me.PictureBox6.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.message_board.My.Resources.Resources.RTEmagicC_message_board_03_jpg
        Me.PictureBox2.Location = New System.Drawing.Point(308, 33)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(45, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.message_board.My.Resources.Resources._78e8e836498a12735cecb435310996fa
        Me.PictureBox1.Location = New System.Drawing.Point(29, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(43, 131)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 20)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Chat"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 500
        '
        'account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(938, 572)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox13)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.lsboffuser)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.lsbonuser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lbltrash)
        Me.Controls.Add(Me.panelcompose)
        Me.Controls.Add(Me.lblsent)
        Me.Controls.Add(Me.lblinbox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblacc2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "account"
        Me.Text = "account"
        Me.panelcompose.ResumeLayout(False)
        Me.panelcompose.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblacc2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents panelcompose As System.Windows.Forms.Panel
    Friend WithEvents txtsub As System.Windows.Forms.TextBox
    Friend WithEvents txtrcr As System.Windows.Forms.TextBox
    Friend WithEvents lblsub As System.Windows.Forms.Label
    Friend WithEvents lblto As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents lblinbox As System.Windows.Forms.Label
    Friend WithEvents lblsent As System.Windows.Forms.Label
    Friend WithEvents lbltrash As System.Windows.Forms.Label
    Friend WithEvents lbldraft As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lsbonuser As System.Windows.Forms.ListBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lsboffuser As System.Windows.Forms.ListBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox13 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox14 As System.Windows.Forms.PictureBox
    Friend WithEvents rtb As System.Windows.Forms.RichTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbloc As System.Windows.Forms.ComboBox
End Class

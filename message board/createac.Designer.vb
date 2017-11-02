<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class createac
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
        Me.lblfname = New System.Windows.Forms.Label()
        Me.lbllogin = New System.Windows.Forms.Label()
        Me.lbllname = New System.Windows.Forms.Label()
        Me.lblrepwd = New System.Windows.Forms.Label()
        Me.lblpwd = New System.Windows.Forms.Label()
        Me.lblans = New System.Windows.Forms.Label()
        Me.lblque = New System.Windows.Forms.Label()
        Me.lblloc = New System.Windows.Forms.Label()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.txtpwd = New System.Windows.Forms.TextBox()
        Me.txtlogin = New System.Windows.Forms.TextBox()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.txtrepwd = New System.Windows.Forms.TextBox()
        Me.txtans = New System.Windows.Forms.TextBox()
        Me.cmbloc = New System.Windows.Forms.ComboBox()
        Me.cmbque = New System.Windows.Forms.ComboBox()
        Me.lblex = New System.Windows.Forms.Label()
        Me.lblhead = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.butcreate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pb22 = New System.Windows.Forms.PictureBox()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.pb12 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblfname
        '
        Me.lblfname.AutoSize = True
        Me.lblfname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblfname.Location = New System.Drawing.Point(22, 34)
        Me.lblfname.Name = "lblfname"
        Me.lblfname.Size = New System.Drawing.Size(67, 13)
        Me.lblfname.TabIndex = 0
        Me.lblfname.Text = "First Name"
        '
        'lbllogin
        '
        Me.lbllogin.AutoSize = True
        Me.lbllogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbllogin.Location = New System.Drawing.Point(22, 86)
        Me.lbllogin.Name = "lbllogin"
        Me.lbllogin.Size = New System.Drawing.Size(121, 13)
        Me.lbllogin.TabIndex = 1
        Me.lbllogin.Text = "Desired Login Name"
        '
        'lbllname
        '
        Me.lbllname.AutoSize = True
        Me.lbllname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbllname.Location = New System.Drawing.Point(22, 60)
        Me.lbllname.Name = "lbllname"
        Me.lbllname.Size = New System.Drawing.Size(67, 13)
        Me.lbllname.TabIndex = 2
        Me.lbllname.Text = "Last Name"
        '
        'lblrepwd
        '
        Me.lblrepwd.AutoSize = True
        Me.lblrepwd.BackColor = System.Drawing.Color.White
        Me.lblrepwd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblrepwd.Location = New System.Drawing.Point(20, 55)
        Me.lblrepwd.Name = "lblrepwd"
        Me.lblrepwd.Size = New System.Drawing.Size(114, 13)
        Me.lblrepwd.TabIndex = 3
        Me.lblrepwd.Text = "Re-enter Password"
        '
        'lblpwd
        '
        Me.lblpwd.AutoSize = True
        Me.lblpwd.BackColor = System.Drawing.Color.White
        Me.lblpwd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblpwd.Location = New System.Drawing.Point(20, 29)
        Me.lblpwd.Name = "lblpwd"
        Me.lblpwd.Size = New System.Drawing.Size(118, 13)
        Me.lblpwd.TabIndex = 4
        Me.lblpwd.Text = "Choose a Password"
        '
        'lblans
        '
        Me.lblans.AutoSize = True
        Me.lblans.BackColor = System.Drawing.Color.White
        Me.lblans.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblans.Location = New System.Drawing.Point(20, 108)
        Me.lblans.Name = "lblans"
        Me.lblans.Size = New System.Drawing.Size(48, 13)
        Me.lblans.TabIndex = 5
        Me.lblans.Text = "Answer"
        '
        'lblque
        '
        Me.lblque.AutoSize = True
        Me.lblque.BackColor = System.Drawing.Color.White
        Me.lblque.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblque.Location = New System.Drawing.Point(20, 81)
        Me.lblque.Name = "lblque"
        Me.lblque.Size = New System.Drawing.Size(108, 13)
        Me.lblque.TabIndex = 6
        Me.lblque.Text = "Select a Question"
        '
        'lblloc
        '
        Me.lblloc.AutoSize = True
        Me.lblloc.BackColor = System.Drawing.Color.White
        Me.lblloc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblloc.Location = New System.Drawing.Point(20, 134)
        Me.lblloc.Name = "lblloc"
        Me.lblloc.Size = New System.Drawing.Size(56, 13)
        Me.lblloc.TabIndex = 7
        Me.lblloc.Text = "Location"
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(157, 31)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(166, 20)
        Me.txtfname.TabIndex = 1
        '
        'txtpwd
        '
        Me.txtpwd.Location = New System.Drawing.Point(155, 26)
        Me.txtpwd.Name = "txtpwd"
        Me.txtpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpwd.Size = New System.Drawing.Size(166, 20)
        Me.txtpwd.TabIndex = 4
        '
        'txtlogin
        '
        Me.txtlogin.Location = New System.Drawing.Point(157, 83)
        Me.txtlogin.Name = "txtlogin"
        Me.txtlogin.Size = New System.Drawing.Size(166, 20)
        Me.txtlogin.TabIndex = 3
        '
        'txtlname
        '
        Me.txtlname.Location = New System.Drawing.Point(157, 57)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(166, 20)
        Me.txtlname.TabIndex = 2
        '
        'txtrepwd
        '
        Me.txtrepwd.Location = New System.Drawing.Point(155, 52)
        Me.txtrepwd.Name = "txtrepwd"
        Me.txtrepwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtrepwd.Size = New System.Drawing.Size(166, 20)
        Me.txtrepwd.TabIndex = 5
        '
        'txtans
        '
        Me.txtans.Location = New System.Drawing.Point(155, 105)
        Me.txtans.Name = "txtans"
        Me.txtans.Size = New System.Drawing.Size(166, 20)
        Me.txtans.TabIndex = 7
        '
        'cmbloc
        '
        Me.cmbloc.FormattingEnabled = True
        Me.cmbloc.Items.AddRange(New Object() {"HostelA", "HostelB", "HostelC", "HostelD", "Library", "Labs", "HODs", "Office"})
        Me.cmbloc.Location = New System.Drawing.Point(155, 131)
        Me.cmbloc.Name = "cmbloc"
        Me.cmbloc.Size = New System.Drawing.Size(166, 21)
        Me.cmbloc.TabIndex = 8
        '
        'cmbque
        '
        Me.cmbque.FormattingEnabled = True
        Me.cmbque.Items.AddRange(New Object() {"What is Your Pet Name ?", "What is Your Mobile Number?", "What is Your Lucky Number ?", "What is Your Vehicle Number ?", "What is Your Enroll Number ?", ""})
        Me.cmbque.Location = New System.Drawing.Point(155, 78)
        Me.cmbque.Name = "cmbque"
        Me.cmbque.Size = New System.Drawing.Size(166, 21)
        Me.cmbque.TabIndex = 6
        '
        'lblex
        '
        Me.lblex.AutoSize = True
        Me.lblex.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblex.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblex.Location = New System.Drawing.Point(164, 106)
        Me.lblex.Name = "lblex"
        Me.lblex.Size = New System.Drawing.Size(146, 16)
        Me.lblex.TabIndex = 18
        Me.lblex.Text = "ex:kunal,piyush,kk.arya"
        '
        'lblhead
        '
        Me.lblhead.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblhead.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblhead.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhead.ForeColor = System.Drawing.Color.Navy
        Me.lblhead.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblhead.Location = New System.Drawing.Point(0, 0)
        Me.lblhead.Name = "lblhead"
        Me.lblhead.Size = New System.Drawing.Size(520, 50)
        Me.lblhead.TabIndex = 22
        Me.lblhead.Tag = "MENSAGENS"
        Me.lblhead.Text = "Messenger"
        Me.lblhead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblex)
        Me.GroupBox1.Controls.Add(Me.txtlname)
        Me.GroupBox1.Controls.Add(Me.txtlogin)
        Me.GroupBox1.Controls.Add(Me.txtfname)
        Me.GroupBox1.Controls.Add(Me.lbllname)
        Me.GroupBox1.Controls.Add(Me.lbllogin)
        Me.GroupBox1.Controls.Add(Me.lblfname)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(87, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(351, 135)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter Login Detail"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cmbque)
        Me.GroupBox2.Controls.Add(Me.cmbloc)
        Me.GroupBox2.Controls.Add(Me.txtans)
        Me.GroupBox2.Controls.Add(Me.txtrepwd)
        Me.GroupBox2.Controls.Add(Me.txtpwd)
        Me.GroupBox2.Controls.Add(Me.lblloc)
        Me.GroupBox2.Controls.Add(Me.lblque)
        Me.GroupBox2.Controls.Add(Me.lblans)
        Me.GroupBox2.Controls.Add(Me.lblpwd)
        Me.GroupBox2.Controls.Add(Me.lblrepwd)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(90, 273)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(348, 171)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Enter Other Detail"
        '
        'butcreate
        '
        Me.butcreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butcreate.Location = New System.Drawing.Point(161, 497)
        Me.butcreate.Name = "butcreate"
        Me.butcreate.Size = New System.Drawing.Size(166, 29)
        Me.butcreate.TabIndex = 9
        Me.butcreate.Text = "Create My Account"
        Me.butcreate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(56, 461)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 19)
        Me.Label1.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label2.Location = New System.Drawing.Point(80, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Login"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(333, 463)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(136, 63)
        Me.Panel1.TabIndex = 35
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.message_board.My.Resources.Resources.LOGIN1
        Me.PictureBox2.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(77, 60)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 33
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.message_board.My.Resources.Resources.online_social_networking
        Me.PictureBox1.Location = New System.Drawing.Point(217, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(101, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'pb22
        '
        Me.pb22.Image = Global.message_board.My.Resources.Resources.dialog_question
        Me.pb22.InitialImage = Global.message_board.My.Resources.Resources.success_icon
        Me.pb22.Location = New System.Drawing.Point(12, 453)
        Me.pb22.Name = "pb22"
        Me.pb22.Size = New System.Drawing.Size(38, 36)
        Me.pb22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb22.TabIndex = 31
        Me.pb22.TabStop = False
        Me.pb22.Visible = False
        '
        'pb1
        '
        Me.pb1.Image = Global.message_board.My.Resources.Resources.success_icon
        Me.pb1.InitialImage = Global.message_board.My.Resources.Resources.success_icon
        Me.pb1.Location = New System.Drawing.Point(12, 453)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(38, 36)
        Me.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb1.TabIndex = 30
        Me.pb1.TabStop = False
        Me.pb1.Visible = False
        '
        'pb12
        '
        Me.pb12.Image = Global.message_board.My.Resources.Resources.RTEmagicC_message_board_03_jpg
        Me.pb12.Location = New System.Drawing.Point(98, 0)
        Me.pb12.Name = "pb12"
        Me.pb12.Size = New System.Drawing.Size(45, 50)
        Me.pb12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb12.TabIndex = 23
        Me.pb12.TabStop = False
        '
        'createac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(520, 538)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.butcreate)
        Me.Controls.Add(Me.pb22)
        Me.Controls.Add(Me.pb1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pb12)
        Me.Controls.Add(Me.lblhead)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "createac"
        Me.Text = "Welcome to LOGIN ZONE"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblfname As System.Windows.Forms.Label
    Friend WithEvents lbllogin As System.Windows.Forms.Label
    Friend WithEvents lbllname As System.Windows.Forms.Label
    Friend WithEvents lblrepwd As System.Windows.Forms.Label
    Friend WithEvents lblpwd As System.Windows.Forms.Label
    Friend WithEvents lblans As System.Windows.Forms.Label
    Friend WithEvents lblque As System.Windows.Forms.Label
    Friend WithEvents lblloc As System.Windows.Forms.Label
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents txtpwd As System.Windows.Forms.TextBox
    Friend WithEvents txtlogin As System.Windows.Forms.TextBox
    Friend WithEvents txtlname As System.Windows.Forms.TextBox
    Friend WithEvents txtrepwd As System.Windows.Forms.TextBox
    Friend WithEvents txtans As System.Windows.Forms.TextBox
    Friend WithEvents cmbloc As System.Windows.Forms.ComboBox
    Friend WithEvents cmbque As System.Windows.Forms.ComboBox
    Friend WithEvents lblex As System.Windows.Forms.Label
    Friend WithEvents pb12 As System.Windows.Forms.PictureBox
    Friend WithEvents lblhead As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents butcreate As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pb1 As System.Windows.Forms.PictureBox
    Friend WithEvents pb22 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class

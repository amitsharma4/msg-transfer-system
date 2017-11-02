<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblhead = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblex = New System.Windows.Forms.Label()
        Me.lblpwd = New System.Windows.Forms.Label()
        Me.lbluname = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblacc3 = New System.Windows.Forms.Label()
        Me.lblacc2 = New System.Windows.Forms.Label()
        Me.lblacc1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.butcreate = New System.Windows.Forms.Button()
        Me.lbltxt = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.lblhead.Size = New System.Drawing.Size(455, 50)
        Me.lblhead.TabIndex = 0
        Me.lblhead.Tag = "MENSAGENS"
        Me.lblhead.Text = "Messenger"
        Me.lblhead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lblex)
        Me.Panel1.Controls.Add(Me.lblpwd)
        Me.Panel1.Controls.Add(Me.lbluname)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.lblacc3)
        Me.Panel1.Controls.Add(Me.lblacc2)
        Me.Panel1.Controls.Add(Me.lblacc1)
        Me.Panel1.Location = New System.Drawing.Point(96, 71)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(267, 231)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.message_board.My.Resources.Resources.login_icon_button__thumb13161821
        Me.PictureBox1.Location = New System.Drawing.Point(89, 179)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(91, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'lblex
        '
        Me.lblex.AutoSize = True
        Me.lblex.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblex.Location = New System.Drawing.Point(91, 112)
        Me.lblex.Name = "lblex"
        Me.lblex.Size = New System.Drawing.Size(155, 16)
        Me.lblex.TabIndex = 7
        Me.lblex.Text = "ex:pat@messenger.com"
        '
        'lblpwd
        '
        Me.lblpwd.AutoSize = True
        Me.lblpwd.Location = New System.Drawing.Point(22, 147)
        Me.lblpwd.Name = "lblpwd"
        Me.lblpwd.Size = New System.Drawing.Size(53, 13)
        Me.lblpwd.TabIndex = 6
        Me.lblpwd.Text = "Password"
        '
        'lbluname
        '
        Me.lbluname.AutoSize = True
        Me.lbluname.Location = New System.Drawing.Point(20, 92)
        Me.lbluname.Name = "lbluname"
        Me.lbluname.Size = New System.Drawing.Size(55, 13)
        Me.lbluname.TabIndex = 5
        Me.lbluname.Text = "Username"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(92, 144)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(148, 20)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(94, 89)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(146, 20)
        Me.TextBox1.TabIndex = 3
        '
        'lblacc3
        '
        Me.lblacc3.AutoSize = True
        Me.lblacc3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblacc3.Location = New System.Drawing.Point(153, 35)
        Me.lblacc3.Name = "lblacc3"
        Me.lblacc3.Size = New System.Drawing.Size(60, 20)
        Me.lblacc3.TabIndex = 2
        Me.lblacc3.Text = "Account"
        '
        'lblacc2
        '
        Me.lblacc2.AutoSize = True
        Me.lblacc2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblacc2.ForeColor = System.Drawing.Color.Fuchsia
        Me.lblacc2.Location = New System.Drawing.Point(21, 35)
        Me.lblacc2.Name = "lblacc2"
        Me.lblacc2.Size = New System.Drawing.Size(122, 20)
        Me.lblacc2.TabIndex = 1
        Me.lblacc2.Text = "MESSENGER"
        '
        'lblacc1
        '
        Me.lblacc1.AutoSize = True
        Me.lblacc1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblacc1.ForeColor = System.Drawing.Color.Black
        Me.lblacc1.Location = New System.Drawing.Point(74, 15)
        Me.lblacc1.Name = "lblacc1"
        Me.lblacc1.Size = New System.Drawing.Size(106, 20)
        Me.lblacc1.TabIndex = 0
        Me.lblacc1.Text = "Sign in with your"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.butcreate)
        Me.Panel2.Controls.Add(Me.lbltxt)
        Me.Panel2.Location = New System.Drawing.Point(96, 331)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(267, 107)
        Me.Panel2.TabIndex = 2
        '
        'butcreate
        '
        Me.butcreate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butcreate.Location = New System.Drawing.Point(62, 44)
        Me.butcreate.Name = "butcreate"
        Me.butcreate.Size = New System.Drawing.Size(162, 35)
        Me.butcreate.TabIndex = 1
        Me.butcreate.Text = "Create an Account>>"
        Me.butcreate.UseVisualStyleBackColor = True
        '
        'lbltxt
        '
        Me.lbltxt.AutoSize = True
        Me.lbltxt.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltxt.Location = New System.Drawing.Point(3, 10)
        Me.lbltxt.Name = "lbltxt"
        Me.lbltxt.Size = New System.Drawing.Size(258, 20)
        Me.lbltxt.TabIndex = 0
        Me.lbltxt.Text = "New to MENSAGENS? It's free and easy."
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 50)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(68, 456)
        Me.Panel3.TabIndex = 15
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(392, 50)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(63, 456)
        Me.Panel4.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(68, 460)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(324, 46)
        Me.Panel5.TabIndex = 16
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.message_board.My.Resources.Resources.RTEmagicC_message_board_03_jpg
        Me.PictureBox2.Location = New System.Drawing.Point(78, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(45, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(455, 506)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblhead)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Welcome to Message Board - [Mensagens]"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblhead As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblacc2 As System.Windows.Forms.Label
    Friend WithEvents lblacc1 As System.Windows.Forms.Label
    Friend WithEvents lblacc3 As System.Windows.Forms.Label
    Friend WithEvents lblex As System.Windows.Forms.Label
    Friend WithEvents lblpwd As System.Windows.Forms.Label
    Friend WithEvents lbluname As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents butcreate As System.Windows.Forms.Button
    Friend WithEvents lbltxt As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class

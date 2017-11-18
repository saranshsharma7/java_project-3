<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim End_TimeLabel As System.Windows.Forms.Label
        Dim LocationLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim AttachmentsLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.LoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoginDataSet = New vb_pharmacy_management_system.loginDataSet()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.LoginBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.LoginBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.End_TimeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.AttachmentsTextBox = New System.Windows.Forms.TextBox()
        Me.LoginTableAdapter = New vb_pharmacy_management_system.loginDataSetTableAdapters.loginTableAdapter()
        Me.TableAdapterManager = New vb_pharmacy_management_system.loginDataSetTableAdapters.TableAdapterManager()
        IDLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        End_TimeLabel = New System.Windows.Forms.Label()
        LocationLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        AttachmentsLabel = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LoginBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(566, 648)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 9
        IDLabel.Text = "ID:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(537, 672)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(58, 13)
        UsernameLabel.TabIndex = 11
        UsernameLabel.Text = "Username:"
        AddHandler UsernameLabel.Click, AddressOf Me.UsernameLabel_Click
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(537, 685)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(56, 13)
        PasswordLabel.TabIndex = 13
        PasswordLabel.Text = "Password:"
        '
        'End_TimeLabel
        '
        End_TimeLabel.AutoSize = True
        End_TimeLabel.Location = New System.Drawing.Point(537, 705)
        End_TimeLabel.Name = "End_TimeLabel"
        End_TimeLabel.Size = New System.Drawing.Size(55, 13)
        End_TimeLabel.TabIndex = 15
        End_TimeLabel.Text = "End Time:"
        '
        'LocationLabel
        '
        LocationLabel.AutoSize = True
        LocationLabel.Location = New System.Drawing.Point(536, 722)
        LocationLabel.Name = "LocationLabel"
        LocationLabel.Size = New System.Drawing.Size(51, 13)
        LocationLabel.TabIndex = 17
        LocationLabel.Text = "Location:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(536, 748)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 19
        DescriptionLabel.Text = "Description:"
        '
        'AttachmentsLabel
        '
        AttachmentsLabel.AutoSize = True
        AttachmentsLabel.Location = New System.Drawing.Point(536, 774)
        AttachmentsLabel.Name = "AttachmentsLabel"
        AttachmentsLabel.Size = New System.Drawing.Size(69, 13)
        AttachmentsLabel.TabIndex = 21
        AttachmentsLabel.Text = "Attachments:"
        '
        'Button1
        '
        Me.Button1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Button1.BackColor = System.Drawing.Color.DarkOrange
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1191, 111)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 59)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Doctor" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkOrange
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1191, 175)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(164, 60)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "GP Appointment"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkOrange
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1191, 240)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(164, 59)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Patient"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkOrange
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(1191, 376)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(164, 60)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Pharmacy"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DarkOrange
        Me.Button5.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(1191, 445)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(164, 78)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Pharmacy office"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Button8)
        Me.Panel2.Controls.Add(Me.Button7)
        Me.Panel2.Controls.Add(Me.UsernameTextBox)
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.PasswordTextBox)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(26, 226)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(548, 297)
        Me.Panel2.TabIndex = 8
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.vb_pharmacy_management_system.My.Resources.Resources.user
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(29, 78)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(119, 118)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(83, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(370, 39)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Pharmacy login system"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.SystemColors.Menu
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(374, 223)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(136, 36)
        Me.Button8.TabIndex = 3
        Me.Button8.Text = "exit"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.Menu
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(207, 223)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(136, 36)
        Me.Button7.TabIndex = 3
        Me.Button7.Text = "clear"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoginBindingSource, "Username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(322, 101)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.UsernameTextBox.TabIndex = 12
        '
        'LoginBindingSource
        '
        Me.LoginBindingSource.DataMember = "login"
        Me.LoginBindingSource.DataSource = Me.LoginDataSet
        '
        'LoginDataSet
        '
        Me.LoginDataSet.DataSetName = "loginDataSet"
        Me.LoginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.Menu
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(29, 223)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(139, 36)
        Me.Button6.TabIndex = 2
        Me.Button6.Text = "login" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(171, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 27)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Password" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoginBindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(322, 158)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PasswordTextBox.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(171, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 27)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Username" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TextBox2.Location = New System.Drawing.Point(611, 663)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(200, 20)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TextBox1.Location = New System.Drawing.Point(611, 682)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 20)
        Me.TextBox1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LimeGreen
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Purple
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label1.Location = New System.Drawing.Point(26, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(722, 57)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PHARMACY MANAGEMENT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.LimeGreen
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(519, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(229, 57)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "SYSTEM"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1042, 667)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(311, 18)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Note: login required to access the menu bar"
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(1189, 611)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(166, 39)
        Me.Button9.TabIndex = 11
        Me.Button9.Text = "EXIT"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.vb_pharmacy_management_system.My.Resources.Resources._11006404_Pharmacy_chemist_woman_in_drugstore_Stock_Photo_pharmacy_store_pharmacist
        Me.PictureBox1.Location = New System.Drawing.Point(-4, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1359, 736)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.DarkOrange
        Me.Button10.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(1191, 306)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(164, 62)
        Me.Button10.TabIndex = 12
        Me.Button10.Text = "Payment" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button10.UseVisualStyleBackColor = False
        '
        'LoginBindingNavigator
        '
        Me.LoginBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.LoginBindingNavigator.BindingSource = Me.LoginBindingSource
        Me.LoginBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.LoginBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.LoginBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.LoginBindingNavigatorSaveItem})
        Me.LoginBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.LoginBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.LoginBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.LoginBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.LoginBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.LoginBindingNavigator.Name = "LoginBindingNavigator"
        Me.LoginBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.LoginBindingNavigator.Size = New System.Drawing.Size(1354, 25)
        Me.LoginBindingNavigator.TabIndex = 13
        Me.LoginBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'LoginBindingNavigatorSaveItem
        '
        Me.LoginBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LoginBindingNavigatorSaveItem.Image = CType(resources.GetObject("LoginBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.LoginBindingNavigatorSaveItem.Name = "LoginBindingNavigatorSaveItem"
        Me.LoginBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.LoginBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoginBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(611, 641)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IDTextBox.TabIndex = 10
        '
        'End_TimeDateTimePicker
        '
        Me.End_TimeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LoginBindingSource, "End Time", True))
        Me.End_TimeDateTimePicker.Location = New System.Drawing.Point(611, 699)
        Me.End_TimeDateTimePicker.Name = "End_TimeDateTimePicker"
        Me.End_TimeDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.End_TimeDateTimePicker.TabIndex = 16
        '
        'LocationTextBox
        '
        Me.LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoginBindingSource, "Location", True))
        Me.LocationTextBox.Location = New System.Drawing.Point(611, 719)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(200, 20)
        Me.LocationTextBox.TabIndex = 18
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoginBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(611, 745)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DescriptionTextBox.TabIndex = 20
        '
        'AttachmentsTextBox
        '
        Me.AttachmentsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoginBindingSource, "Attachments", True))
        Me.AttachmentsTextBox.Location = New System.Drawing.Point(611, 771)
        Me.AttachmentsTextBox.Name = "AttachmentsTextBox"
        Me.AttachmentsTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AttachmentsTextBox.TabIndex = 22
        '
        'LoginTableAdapter
        '
        Me.LoginTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.loginTableAdapter = Me.LoginTableAdapter
        Me.TableAdapterManager.UpdateOrder = vb_pharmacy_management_system.loginDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.LoginBindingNavigator)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(End_TimeLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.End_TimeDateTimePicker)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(LocationLabel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.LocationTextBox)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(AttachmentsLabel)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.AttachmentsTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "pharmacy mangement system"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LoginBindingNavigator.ResumeLayout(False)
        Me.LoginBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button10 As Button
    Friend WithEvents LoginDataSet As loginDataSet
    Friend WithEvents LoginBindingSource As BindingSource
    Friend WithEvents LoginTableAdapter As loginDataSetTableAdapters.loginTableAdapter
    Friend WithEvents TableAdapterManager As loginDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LoginBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents LoginBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents End_TimeDateTimePicker As DateTimePicker
    Friend WithEvents LocationTextBox As TextBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents AttachmentsTextBox As TextBox
End Class

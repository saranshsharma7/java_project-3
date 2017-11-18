<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim Patient_IDLabel As System.Windows.Forms.Label
        Dim GP_Appointment_RefLabel As System.Windows.Forms.Label
        Dim EMIS_NumberLabel As System.Windows.Forms.Label
        Dim Patient_NHS_NumberLabel As System.Windows.Forms.Label
        Dim Email_AddressLabel As System.Windows.Forms.Label
        Dim Fax_NoLabel As System.Windows.Forms.Label
        Dim Office_Phone_No_2Label As System.Windows.Forms.Label
        Dim Office_Phone_No_1Label As System.Windows.Forms.Label
        Dim Medical_Centre_RefLabel As System.Windows.Forms.Label
        Dim Post_CodeLabel As System.Windows.Forms.Label
        Dim Address_of_CentreLabel As System.Windows.Forms.Label
        Dim Medical_Centre_NameLabel As System.Windows.Forms.Label
        Dim SurnameLabel As System.Windows.Forms.Label
        Dim FirstnameLabel As System.Windows.Forms.Label
        Dim Doctor_s_NHS_NoLabel As System.Windows.Forms.Label
        Dim Doctor_s_Ref_NoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.PharmacyDataSet = New vb_pharmacy_management_system.pharmacyDataSet()
        Me.DoctorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DoctorTableAdapter = New vb_pharmacy_management_system.pharmacyDataSetTableAdapters.DoctorTableAdapter()
        Me.TableAdapterManager = New vb_pharmacy_management_system.pharmacyDataSetTableAdapters.TableAdapterManager()
        Me.DoctorBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.DoctorBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Patient_IDTextBox = New System.Windows.Forms.TextBox()
        Me.GP_Appointment_RefTextBox = New System.Windows.Forms.TextBox()
        Me.EMIS_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Patient_NHS_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Email_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Fax_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Office_Phone_No_2TextBox = New System.Windows.Forms.TextBox()
        Me.Office_Phone_No_1TextBox = New System.Windows.Forms.TextBox()
        Me.Medical_Centre_RefTextBox = New System.Windows.Forms.TextBox()
        Me.Post_CodeTextBox = New System.Windows.Forms.TextBox()
        Me.Address_of_CentreTextBox = New System.Windows.Forms.TextBox()
        Me.Medical_Centre_NameTextBox = New System.Windows.Forms.TextBox()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstnameTextBox = New System.Windows.Forms.TextBox()
        Me.Doctor_s_NHS_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Doctor_s_Ref_NoTextBox = New System.Windows.Forms.TextBox()
        Me.DoctorDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Patient_IDLabel = New System.Windows.Forms.Label()
        GP_Appointment_RefLabel = New System.Windows.Forms.Label()
        EMIS_NumberLabel = New System.Windows.Forms.Label()
        Patient_NHS_NumberLabel = New System.Windows.Forms.Label()
        Email_AddressLabel = New System.Windows.Forms.Label()
        Fax_NoLabel = New System.Windows.Forms.Label()
        Office_Phone_No_2Label = New System.Windows.Forms.Label()
        Office_Phone_No_1Label = New System.Windows.Forms.Label()
        Medical_Centre_RefLabel = New System.Windows.Forms.Label()
        Post_CodeLabel = New System.Windows.Forms.Label()
        Address_of_CentreLabel = New System.Windows.Forms.Label()
        Medical_Centre_NameLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        FirstnameLabel = New System.Windows.Forms.Label()
        Doctor_s_NHS_NoLabel = New System.Windows.Forms.Label()
        Doctor_s_Ref_NoLabel = New System.Windows.Forms.Label()
        CType(Me.PharmacyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoctorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoctorBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DoctorBindingNavigator.SuspendLayout()
        CType(Me.DoctorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Patient_IDLabel
        '
        Patient_IDLabel.AutoSize = True
        Patient_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Patient_IDLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Patient_IDLabel.Location = New System.Drawing.Point(550, 410)
        Patient_IDLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Patient_IDLabel.Name = "Patient_IDLabel"
        Patient_IDLabel.Size = New System.Drawing.Size(95, 20)
        Patient_IDLabel.TabIndex = 31
        Patient_IDLabel.Text = "Patient ID:"
        '
        'GP_Appointment_RefLabel
        '
        GP_Appointment_RefLabel.AutoSize = True
        GP_Appointment_RefLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GP_Appointment_RefLabel.ForeColor = System.Drawing.SystemColors.ControlText
        GP_Appointment_RefLabel.Location = New System.Drawing.Point(550, 370)
        GP_Appointment_RefLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        GP_Appointment_RefLabel.Name = "GP_Appointment_RefLabel"
        GP_Appointment_RefLabel.Size = New System.Drawing.Size(180, 20)
        GP_Appointment_RefLabel.TabIndex = 29
        GP_Appointment_RefLabel.Text = "GP Appointment Ref:"
        '
        'EMIS_NumberLabel
        '
        EMIS_NumberLabel.AutoSize = True
        EMIS_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EMIS_NumberLabel.ForeColor = System.Drawing.SystemColors.ControlText
        EMIS_NumberLabel.Location = New System.Drawing.Point(550, 330)
        EMIS_NumberLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        EMIS_NumberLabel.Name = "EMIS_NumberLabel"
        EMIS_NumberLabel.Size = New System.Drawing.Size(125, 20)
        EMIS_NumberLabel.TabIndex = 27
        EMIS_NumberLabel.Text = "EMIS Number:"
        '
        'Patient_NHS_NumberLabel
        '
        Patient_NHS_NumberLabel.AutoSize = True
        Patient_NHS_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Patient_NHS_NumberLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Patient_NHS_NumberLabel.Location = New System.Drawing.Point(550, 290)
        Patient_NHS_NumberLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Patient_NHS_NumberLabel.Name = "Patient_NHS_NumberLabel"
        Patient_NHS_NumberLabel.Size = New System.Drawing.Size(180, 20)
        Patient_NHS_NumberLabel.TabIndex = 25
        Patient_NHS_NumberLabel.Text = "Patient NHS Number:"
        '
        'Email_AddressLabel
        '
        Email_AddressLabel.AutoSize = True
        Email_AddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Email_AddressLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Email_AddressLabel.Location = New System.Drawing.Point(550, 178)
        Email_AddressLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Email_AddressLabel.Name = "Email_AddressLabel"
        Email_AddressLabel.Size = New System.Drawing.Size(129, 20)
        Email_AddressLabel.TabIndex = 23
        Email_AddressLabel.Text = "Email Address:"
        '
        'Fax_NoLabel
        '
        Fax_NoLabel.AutoSize = True
        Fax_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Fax_NoLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Fax_NoLabel.Location = New System.Drawing.Point(550, 138)
        Fax_NoLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Fax_NoLabel.Name = "Fax_NoLabel"
        Fax_NoLabel.Size = New System.Drawing.Size(70, 20)
        Fax_NoLabel.TabIndex = 21
        Fax_NoLabel.Text = "Fax No:"
        '
        'Office_Phone_No_2Label
        '
        Office_Phone_No_2Label.AutoSize = True
        Office_Phone_No_2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Office_Phone_No_2Label.ForeColor = System.Drawing.SystemColors.ControlText
        Office_Phone_No_2Label.Location = New System.Drawing.Point(550, 98)
        Office_Phone_No_2Label.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Office_Phone_No_2Label.Name = "Office_Phone_No_2Label"
        Office_Phone_No_2Label.Size = New System.Drawing.Size(160, 20)
        Office_Phone_No_2Label.TabIndex = 19
        Office_Phone_No_2Label.Text = "Office Phone No 2:"
        '
        'Office_Phone_No_1Label
        '
        Office_Phone_No_1Label.AutoSize = True
        Office_Phone_No_1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Office_Phone_No_1Label.ForeColor = System.Drawing.SystemColors.ControlText
        Office_Phone_No_1Label.Location = New System.Drawing.Point(550, 58)
        Office_Phone_No_1Label.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Office_Phone_No_1Label.Name = "Office_Phone_No_1Label"
        Office_Phone_No_1Label.Size = New System.Drawing.Size(160, 20)
        Office_Phone_No_1Label.TabIndex = 17
        Office_Phone_No_1Label.Text = "Office Phone No 1:"
        '
        'Medical_Centre_RefLabel
        '
        Medical_Centre_RefLabel.AutoSize = True
        Medical_Centre_RefLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Medical_Centre_RefLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Medical_Centre_RefLabel.Location = New System.Drawing.Point(30, 404)
        Medical_Centre_RefLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Medical_Centre_RefLabel.Name = "Medical_Centre_RefLabel"
        Medical_Centre_RefLabel.Size = New System.Drawing.Size(168, 20)
        Medical_Centre_RefLabel.TabIndex = 15
        Medical_Centre_RefLabel.Text = "Medical Centre Ref:"
        '
        'Post_CodeLabel
        '
        Post_CodeLabel.AutoSize = True
        Post_CodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Post_CodeLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Post_CodeLabel.Location = New System.Drawing.Point(30, 364)
        Post_CodeLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Post_CodeLabel.Name = "Post_CodeLabel"
        Post_CodeLabel.Size = New System.Drawing.Size(97, 20)
        Post_CodeLabel.TabIndex = 13
        Post_CodeLabel.Text = "Post Code:"
        '
        'Address_of_CentreLabel
        '
        Address_of_CentreLabel.AutoSize = True
        Address_of_CentreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Address_of_CentreLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Address_of_CentreLabel.Location = New System.Drawing.Point(30, 324)
        Address_of_CentreLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Address_of_CentreLabel.Name = "Address_of_CentreLabel"
        Address_of_CentreLabel.Size = New System.Drawing.Size(160, 20)
        Address_of_CentreLabel.TabIndex = 11
        Address_of_CentreLabel.Text = "Address of Centre:"
        '
        'Medical_Centre_NameLabel
        '
        Medical_Centre_NameLabel.AutoSize = True
        Medical_Centre_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Medical_Centre_NameLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Medical_Centre_NameLabel.Location = New System.Drawing.Point(30, 284)
        Medical_Centre_NameLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Medical_Centre_NameLabel.Name = "Medical_Centre_NameLabel"
        Medical_Centre_NameLabel.Size = New System.Drawing.Size(185, 20)
        Medical_Centre_NameLabel.TabIndex = 9
        Medical_Centre_NameLabel.Text = "Medical Centre Name:"
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SurnameLabel.ForeColor = System.Drawing.SystemColors.ControlText
        SurnameLabel.Location = New System.Drawing.Point(30, 172)
        SurnameLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(86, 20)
        SurnameLabel.TabIndex = 7
        SurnameLabel.Text = "Surname:"
        '
        'FirstnameLabel
        '
        FirstnameLabel.AutoSize = True
        FirstnameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FirstnameLabel.ForeColor = System.Drawing.SystemColors.ControlText
        FirstnameLabel.Location = New System.Drawing.Point(30, 132)
        FirstnameLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        FirstnameLabel.Name = "FirstnameLabel"
        FirstnameLabel.Size = New System.Drawing.Size(94, 20)
        FirstnameLabel.TabIndex = 5
        FirstnameLabel.Text = "Firstname:"
        '
        'Doctor_s_NHS_NoLabel
        '
        Doctor_s_NHS_NoLabel.AutoSize = True
        Doctor_s_NHS_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Doctor_s_NHS_NoLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Doctor_s_NHS_NoLabel.Location = New System.Drawing.Point(30, 92)
        Doctor_s_NHS_NoLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Doctor_s_NHS_NoLabel.Name = "Doctor_s_NHS_NoLabel"
        Doctor_s_NHS_NoLabel.Size = New System.Drawing.Size(150, 20)
        Doctor_s_NHS_NoLabel.TabIndex = 3
        Doctor_s_NHS_NoLabel.Text = "Doctor's NHS No:"
        '
        'Doctor_s_Ref_NoLabel
        '
        Doctor_s_Ref_NoLabel.AutoSize = True
        Doctor_s_Ref_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Doctor_s_Ref_NoLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Doctor_s_Ref_NoLabel.Location = New System.Drawing.Point(30, 52)
        Doctor_s_Ref_NoLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Doctor_s_Ref_NoLabel.Name = "Doctor_s_Ref_NoLabel"
        Doctor_s_Ref_NoLabel.Size = New System.Drawing.Size(142, 20)
        Doctor_s_Ref_NoLabel.TabIndex = 1
        Doctor_s_Ref_NoLabel.Text = "Doctor's Ref No:"
        '
        'PharmacyDataSet
        '
        Me.PharmacyDataSet.DataSetName = "pharmacyDataSet"
        Me.PharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DoctorBindingSource
        '
        Me.DoctorBindingSource.DataMember = "Doctor"
        Me.DoctorBindingSource.DataSource = Me.PharmacyDataSet
        '
        'DoctorTableAdapter
        '
        Me.DoctorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DoctorTableAdapter = Me.DoctorTableAdapter
        Me.TableAdapterManager.GP_AppointmentTableAdapter = Nothing
        Me.TableAdapterManager.PatientTableAdapter = Nothing
        Me.TableAdapterManager.PaymentTableAdapter = Nothing
        Me.TableAdapterManager.PharmacyTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = vb_pharmacy_management_system.pharmacyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DoctorBindingNavigator
        '
        Me.DoctorBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DoctorBindingNavigator.BindingSource = Me.DoctorBindingSource
        Me.DoctorBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DoctorBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DoctorBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DoctorBindingNavigatorSaveItem})
        Me.DoctorBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DoctorBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DoctorBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DoctorBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DoctorBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DoctorBindingNavigator.Name = "DoctorBindingNavigator"
        Me.DoctorBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.DoctorBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DoctorBindingNavigator.Size = New System.Drawing.Size(1329, 25)
        Me.DoctorBindingNavigator.TabIndex = 0
        Me.DoctorBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(81, 23)
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
        'DoctorBindingNavigatorSaveItem
        '
        Me.DoctorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DoctorBindingNavigatorSaveItem.Image = CType(resources.GetObject("DoctorBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DoctorBindingNavigatorSaveItem.Name = "DoctorBindingNavigatorSaveItem"
        Me.DoctorBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.DoctorBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Patient_IDTextBox
        '
        Me.Patient_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorBindingSource, "Patient ID", True))
        Me.Patient_IDTextBox.Location = New System.Drawing.Point(805, 401)
        Me.Patient_IDTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Patient_IDTextBox.Name = "Patient_IDTextBox"
        Me.Patient_IDTextBox.Size = New System.Drawing.Size(253, 26)
        Me.Patient_IDTextBox.TabIndex = 32
        '
        'GP_Appointment_RefTextBox
        '
        Me.GP_Appointment_RefTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorBindingSource, "GP Appointment Ref", True))
        Me.GP_Appointment_RefTextBox.Location = New System.Drawing.Point(805, 358)
        Me.GP_Appointment_RefTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GP_Appointment_RefTextBox.Name = "GP_Appointment_RefTextBox"
        Me.GP_Appointment_RefTextBox.Size = New System.Drawing.Size(253, 26)
        Me.GP_Appointment_RefTextBox.TabIndex = 30
        '
        'EMIS_NumberTextBox
        '
        Me.EMIS_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorBindingSource, "EMIS Number", True))
        Me.EMIS_NumberTextBox.Location = New System.Drawing.Point(805, 318)
        Me.EMIS_NumberTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.EMIS_NumberTextBox.Name = "EMIS_NumberTextBox"
        Me.EMIS_NumberTextBox.Size = New System.Drawing.Size(253, 26)
        Me.EMIS_NumberTextBox.TabIndex = 28
        '
        'Patient_NHS_NumberTextBox
        '
        Me.Patient_NHS_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorBindingSource, "Patient NHS Number", True))
        Me.Patient_NHS_NumberTextBox.Location = New System.Drawing.Point(805, 278)
        Me.Patient_NHS_NumberTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Patient_NHS_NumberTextBox.Name = "Patient_NHS_NumberTextBox"
        Me.Patient_NHS_NumberTextBox.Size = New System.Drawing.Size(253, 26)
        Me.Patient_NHS_NumberTextBox.TabIndex = 26
        '
        'Email_AddressTextBox
        '
        Me.Email_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorBindingSource, "Email Address", True))
        Me.Email_AddressTextBox.Location = New System.Drawing.Point(805, 166)
        Me.Email_AddressTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Email_AddressTextBox.Name = "Email_AddressTextBox"
        Me.Email_AddressTextBox.Size = New System.Drawing.Size(253, 26)
        Me.Email_AddressTextBox.TabIndex = 24
        '
        'Fax_NoTextBox
        '
        Me.Fax_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorBindingSource, "Fax No", True))
        Me.Fax_NoTextBox.Location = New System.Drawing.Point(805, 126)
        Me.Fax_NoTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Fax_NoTextBox.Name = "Fax_NoTextBox"
        Me.Fax_NoTextBox.Size = New System.Drawing.Size(253, 26)
        Me.Fax_NoTextBox.TabIndex = 22
        '
        'Office_Phone_No_2TextBox
        '
        Me.Office_Phone_No_2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorBindingSource, "Office Phone No 2", True))
        Me.Office_Phone_No_2TextBox.Location = New System.Drawing.Point(805, 86)
        Me.Office_Phone_No_2TextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Office_Phone_No_2TextBox.Name = "Office_Phone_No_2TextBox"
        Me.Office_Phone_No_2TextBox.Size = New System.Drawing.Size(253, 26)
        Me.Office_Phone_No_2TextBox.TabIndex = 20
        '
        'Office_Phone_No_1TextBox
        '
        Me.Office_Phone_No_1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorBindingSource, "Office Phone No 1", True))
        Me.Office_Phone_No_1TextBox.Location = New System.Drawing.Point(805, 46)
        Me.Office_Phone_No_1TextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Office_Phone_No_1TextBox.Name = "Office_Phone_No_1TextBox"
        Me.Office_Phone_No_1TextBox.Size = New System.Drawing.Size(253, 26)
        Me.Office_Phone_No_1TextBox.TabIndex = 18
        '
        'Medical_Centre_RefTextBox
        '
        Me.Medical_Centre_RefTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorBindingSource, "Medical Centre Ref", True))
        Me.Medical_Centre_RefTextBox.Location = New System.Drawing.Point(246, 404)
        Me.Medical_Centre_RefTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Medical_Centre_RefTextBox.Name = "Medical_Centre_RefTextBox"
        Me.Medical_Centre_RefTextBox.Size = New System.Drawing.Size(253, 26)
        Me.Medical_Centre_RefTextBox.TabIndex = 16
        '
        'Post_CodeTextBox
        '
        Me.Post_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorBindingSource, "Post Code", True))
        Me.Post_CodeTextBox.Location = New System.Drawing.Point(246, 364)
        Me.Post_CodeTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Post_CodeTextBox.Name = "Post_CodeTextBox"
        Me.Post_CodeTextBox.Size = New System.Drawing.Size(253, 26)
        Me.Post_CodeTextBox.TabIndex = 14
        '
        'Address_of_CentreTextBox
        '
        Me.Address_of_CentreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorBindingSource, "Address of Centre", True))
        Me.Address_of_CentreTextBox.Location = New System.Drawing.Point(246, 324)
        Me.Address_of_CentreTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Address_of_CentreTextBox.Name = "Address_of_CentreTextBox"
        Me.Address_of_CentreTextBox.Size = New System.Drawing.Size(253, 26)
        Me.Address_of_CentreTextBox.TabIndex = 12
        '
        'Medical_Centre_NameTextBox
        '
        Me.Medical_Centre_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorBindingSource, "Medical Centre Name", True))
        Me.Medical_Centre_NameTextBox.Location = New System.Drawing.Point(246, 284)
        Me.Medical_Centre_NameTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Medical_Centre_NameTextBox.Name = "Medical_Centre_NameTextBox"
        Me.Medical_Centre_NameTextBox.Size = New System.Drawing.Size(253, 26)
        Me.Medical_Centre_NameTextBox.TabIndex = 10
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorBindingSource, "Surname", True))
        Me.SurnameTextBox.Location = New System.Drawing.Point(246, 166)
        Me.SurnameTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(253, 26)
        Me.SurnameTextBox.TabIndex = 8
        '
        'FirstnameTextBox
        '
        Me.FirstnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorBindingSource, "Firstname", True))
        Me.FirstnameTextBox.Location = New System.Drawing.Point(246, 132)
        Me.FirstnameTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.FirstnameTextBox.Name = "FirstnameTextBox"
        Me.FirstnameTextBox.Size = New System.Drawing.Size(253, 26)
        Me.FirstnameTextBox.TabIndex = 6
        '
        'Doctor_s_NHS_NoTextBox
        '
        Me.Doctor_s_NHS_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorBindingSource, "Doctor's NHS No", True))
        Me.Doctor_s_NHS_NoTextBox.Location = New System.Drawing.Point(246, 89)
        Me.Doctor_s_NHS_NoTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Doctor_s_NHS_NoTextBox.Name = "Doctor_s_NHS_NoTextBox"
        Me.Doctor_s_NHS_NoTextBox.Size = New System.Drawing.Size(253, 26)
        Me.Doctor_s_NHS_NoTextBox.TabIndex = 4
        '
        'Doctor_s_Ref_NoTextBox
        '
        Me.Doctor_s_Ref_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorBindingSource, "Doctor's Ref No", True))
        Me.Doctor_s_Ref_NoTextBox.Location = New System.Drawing.Point(246, 46)
        Me.Doctor_s_Ref_NoTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Doctor_s_Ref_NoTextBox.Name = "Doctor_s_Ref_NoTextBox"
        Me.Doctor_s_Ref_NoTextBox.Size = New System.Drawing.Size(253, 26)
        Me.Doctor_s_Ref_NoTextBox.TabIndex = 2
        '
        'DoctorDataGridView
        '
        Me.DoctorDataGridView.AutoGenerateColumns = False
        Me.DoctorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DoctorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.DoctorDataGridView.DataSource = Me.DoctorBindingSource
        Me.DoctorDataGridView.Location = New System.Drawing.Point(34, 475)
        Me.DoctorDataGridView.Name = "DoctorDataGridView"
        Me.DoctorDataGridView.Size = New System.Drawing.Size(1295, 220)
        Me.DoctorDataGridView.TabIndex = 33
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Doctor's Ref No"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Doctor's Ref No"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Doctor's NHS No"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Doctor's NHS No"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Firstname"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Firstname"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Surname"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Surname"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Medical Centre Name"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Medical Centre Name"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Address of Centre"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Address of Centre"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Post Code"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Post Code"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Medical Centre Ref"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Medical Centre Ref"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Office Phone No 1"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Office Phone No 1"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Office Phone No 2"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Office Phone No 2"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Fax No"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Fax No"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Email Address"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Email Address"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Patient NHS Number"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Patient NHS Number"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "EMIS Number"
        Me.DataGridViewTextBoxColumn14.HeaderText = "EMIS Number"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "GP Appointment Ref"
        Me.DataGridViewTextBoxColumn15.HeaderText = "GP Appointment Ref"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Patient ID"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Patient ID"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnNext)
        Me.Panel1.Controls.Add(Me.btnPrevious)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Location = New System.Drawing.Point(1103, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(226, 384)
        Me.Panel1.TabIndex = 34
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(11, 37)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(201, 32)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add New"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(11, 90)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(201, 35)
        Me.btnDelete.TabIndex = 0
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(11, 204)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(201, 35)
        Me.btnPrevious.TabIndex = 0
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(11, 151)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(201, 35)
        Me.btnNext.TabIndex = 0
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(11, 261)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(201, 35)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(11, 316)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(201, 35)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(1135, 617)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DoctorDataGridView)
        Me.Controls.Add(Doctor_s_Ref_NoLabel)
        Me.Controls.Add(Me.Doctor_s_Ref_NoTextBox)
        Me.Controls.Add(Doctor_s_NHS_NoLabel)
        Me.Controls.Add(Me.Doctor_s_NHS_NoTextBox)
        Me.Controls.Add(FirstnameLabel)
        Me.Controls.Add(Me.FirstnameTextBox)
        Me.Controls.Add(SurnameLabel)
        Me.Controls.Add(Me.SurnameTextBox)
        Me.Controls.Add(Medical_Centre_NameLabel)
        Me.Controls.Add(Me.Medical_Centre_NameTextBox)
        Me.Controls.Add(Address_of_CentreLabel)
        Me.Controls.Add(Me.Address_of_CentreTextBox)
        Me.Controls.Add(Post_CodeLabel)
        Me.Controls.Add(Me.Post_CodeTextBox)
        Me.Controls.Add(Medical_Centre_RefLabel)
        Me.Controls.Add(Me.Medical_Centre_RefTextBox)
        Me.Controls.Add(Office_Phone_No_1Label)
        Me.Controls.Add(Me.Office_Phone_No_1TextBox)
        Me.Controls.Add(Office_Phone_No_2Label)
        Me.Controls.Add(Me.Office_Phone_No_2TextBox)
        Me.Controls.Add(Fax_NoLabel)
        Me.Controls.Add(Me.Fax_NoTextBox)
        Me.Controls.Add(Email_AddressLabel)
        Me.Controls.Add(Me.Email_AddressTextBox)
        Me.Controls.Add(Patient_NHS_NumberLabel)
        Me.Controls.Add(Me.Patient_NHS_NumberTextBox)
        Me.Controls.Add(EMIS_NumberLabel)
        Me.Controls.Add(Me.EMIS_NumberTextBox)
        Me.Controls.Add(GP_Appointment_RefLabel)
        Me.Controls.Add(Me.GP_Appointment_RefTextBox)
        Me.Controls.Add(Patient_IDLabel)
        Me.Controls.Add(Me.Patient_IDTextBox)
        Me.Controls.Add(Me.DoctorBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Doctor"
        CType(Me.PharmacyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoctorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoctorBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DoctorBindingNavigator.ResumeLayout(False)
        Me.DoctorBindingNavigator.PerformLayout()
        CType(Me.DoctorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PharmacyDataSet As pharmacyDataSet
    Friend WithEvents DoctorBindingSource As BindingSource
    Friend WithEvents DoctorTableAdapter As pharmacyDataSetTableAdapters.DoctorTableAdapter
    Friend WithEvents TableAdapterManager As pharmacyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DoctorBindingNavigator As BindingNavigator
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
    Friend WithEvents DoctorBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Patient_IDTextBox As TextBox
    Friend WithEvents GP_Appointment_RefTextBox As TextBox
    Friend WithEvents EMIS_NumberTextBox As TextBox
    Friend WithEvents Patient_NHS_NumberTextBox As TextBox
    Friend WithEvents Email_AddressTextBox As TextBox
    Friend WithEvents Fax_NoTextBox As TextBox
    Friend WithEvents Office_Phone_No_2TextBox As TextBox
    Friend WithEvents Office_Phone_No_1TextBox As TextBox
    Friend WithEvents Medical_Centre_RefTextBox As TextBox
    Friend WithEvents Post_CodeTextBox As TextBox
    Friend WithEvents Address_of_CentreTextBox As TextBox
    Friend WithEvents Medical_Centre_NameTextBox As TextBox
    Friend WithEvents SurnameTextBox As TextBox
    Friend WithEvents FirstnameTextBox As TextBox
    Friend WithEvents Doctor_s_NHS_NoTextBox As TextBox
    Friend WithEvents Doctor_s_Ref_NoTextBox As TextBox
    Friend WithEvents DoctorDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
End Class

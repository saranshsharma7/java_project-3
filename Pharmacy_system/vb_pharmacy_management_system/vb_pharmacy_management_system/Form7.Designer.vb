<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim NI_NumberLabel As System.Windows.Forms.Label
        Dim FirstnameLabel As System.Windows.Forms.Label
        Dim SurnameLabel As System.Windows.Forms.Label
        Dim Date_of_birthLabel As System.Windows.Forms.Label
        Dim Billing_NameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim Post_CodeLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim Home_PhoneLabel As System.Windows.Forms.Label
        Dim Mobile_PhoneLabel As System.Windows.Forms.Label
        Dim Fax_PhoneLabel As System.Windows.Forms.Label
        Dim MenoLabel As System.Windows.Forms.Label
        Dim Patient_IDLabel As System.Windows.Forms.Label
        Dim Patient_NHS_NumberLabel As System.Windows.Forms.Label
        Dim EMIS_NumberLabel As System.Windows.Forms.Label
        Dim GP_Appointment_RefLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.PharmacyDataSet = New vb_pharmacy_management_system.pharmacyDataSet()
        Me.PatientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatientTableAdapter = New vb_pharmacy_management_system.pharmacyDataSetTableAdapters.PatientTableAdapter()
        Me.TableAdapterManager = New vb_pharmacy_management_system.pharmacyDataSetTableAdapters.TableAdapterManager()
        Me.PatientBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PatientBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NI_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.FirstnameTextBox = New System.Windows.Forms.TextBox()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.Date_of_birthTextBox = New System.Windows.Forms.TextBox()
        Me.Billing_NameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Post_CodeTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.Home_PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.Mobile_PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.Fax_PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.MenoTextBox = New System.Windows.Forms.TextBox()
        Me.Patient_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Patient_NHS_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.EMIS_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.GP_Appointment_RefTextBox = New System.Windows.Forms.TextBox()
        Me.PatientDataGridView = New System.Windows.Forms.DataGridView()
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
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        NI_NumberLabel = New System.Windows.Forms.Label()
        FirstnameLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        Date_of_birthLabel = New System.Windows.Forms.Label()
        Billing_NameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        Post_CodeLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        Home_PhoneLabel = New System.Windows.Forms.Label()
        Mobile_PhoneLabel = New System.Windows.Forms.Label()
        Fax_PhoneLabel = New System.Windows.Forms.Label()
        MenoLabel = New System.Windows.Forms.Label()
        Patient_IDLabel = New System.Windows.Forms.Label()
        Patient_NHS_NumberLabel = New System.Windows.Forms.Label()
        EMIS_NumberLabel = New System.Windows.Forms.Label()
        GP_Appointment_RefLabel = New System.Windows.Forms.Label()
        CType(Me.PharmacyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PatientBindingNavigator.SuspendLayout()
        CType(Me.PatientDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NI_NumberLabel
        '
        NI_NumberLabel.AutoSize = True
        NI_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NI_NumberLabel.Location = New System.Drawing.Point(31, 60)
        NI_NumberLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        NI_NumberLabel.Name = "NI_NumberLabel"
        NI_NumberLabel.Size = New System.Drawing.Size(117, 24)
        NI_NumberLabel.TabIndex = 1
        NI_NumberLabel.Text = "NI Number:"
        '
        'FirstnameLabel
        '
        FirstnameLabel.AutoSize = True
        FirstnameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FirstnameLabel.Location = New System.Drawing.Point(31, 108)
        FirstnameLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        FirstnameLabel.Name = "FirstnameLabel"
        FirstnameLabel.Size = New System.Drawing.Size(108, 24)
        FirstnameLabel.TabIndex = 3
        FirstnameLabel.Text = "Firstname:"
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SurnameLabel.Location = New System.Drawing.Point(31, 156)
        SurnameLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(100, 24)
        SurnameLabel.TabIndex = 5
        SurnameLabel.Text = "Surname:"
        '
        'Date_of_birthLabel
        '
        Date_of_birthLabel.AutoSize = True
        Date_of_birthLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_of_birthLabel.Location = New System.Drawing.Point(31, 204)
        Date_of_birthLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Date_of_birthLabel.Name = "Date_of_birthLabel"
        Date_of_birthLabel.Size = New System.Drawing.Size(128, 24)
        Date_of_birthLabel.TabIndex = 7
        Date_of_birthLabel.Text = "Date of birth:"
        '
        'Billing_NameLabel
        '
        Billing_NameLabel.AutoSize = True
        Billing_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Billing_NameLabel.Location = New System.Drawing.Point(31, 290)
        Billing_NameLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Billing_NameLabel.Name = "Billing_NameLabel"
        Billing_NameLabel.Size = New System.Drawing.Size(134, 24)
        Billing_NameLabel.TabIndex = 9
        Billing_NameLabel.Text = "Billing Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.Location = New System.Drawing.Point(31, 338)
        AddressLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(93, 24)
        AddressLabel.TabIndex = 11
        AddressLabel.Text = "Address:"
        '
        'Post_CodeLabel
        '
        Post_CodeLabel.AutoSize = True
        Post_CodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Post_CodeLabel.Location = New System.Drawing.Point(31, 386)
        Post_CodeLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Post_CodeLabel.Name = "Post_CodeLabel"
        Post_CodeLabel.Size = New System.Drawing.Size(112, 24)
        Post_CodeLabel.TabIndex = 13
        Post_CodeLabel.Text = "Post Code:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CityLabel.Location = New System.Drawing.Point(31, 434)
        CityLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(50, 24)
        CityLabel.TabIndex = 15
        CityLabel.Text = "City:"
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CountryLabel.Location = New System.Drawing.Point(521, 65)
        CountryLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(88, 24)
        CountryLabel.TabIndex = 17
        CountryLabel.Text = "Country:"
        '
        'Home_PhoneLabel
        '
        Home_PhoneLabel.AutoSize = True
        Home_PhoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Home_PhoneLabel.Location = New System.Drawing.Point(521, 113)
        Home_PhoneLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Home_PhoneLabel.Name = "Home_PhoneLabel"
        Home_PhoneLabel.Size = New System.Drawing.Size(139, 24)
        Home_PhoneLabel.TabIndex = 19
        Home_PhoneLabel.Text = "Home Phone:"
        '
        'Mobile_PhoneLabel
        '
        Mobile_PhoneLabel.AutoSize = True
        Mobile_PhoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Mobile_PhoneLabel.Location = New System.Drawing.Point(521, 161)
        Mobile_PhoneLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Mobile_PhoneLabel.Name = "Mobile_PhoneLabel"
        Mobile_PhoneLabel.Size = New System.Drawing.Size(146, 24)
        Mobile_PhoneLabel.TabIndex = 21
        Mobile_PhoneLabel.Text = "Mobile Phone:"
        '
        'Fax_PhoneLabel
        '
        Fax_PhoneLabel.AutoSize = True
        Fax_PhoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Fax_PhoneLabel.Location = New System.Drawing.Point(521, 209)
        Fax_PhoneLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Fax_PhoneLabel.Name = "Fax_PhoneLabel"
        Fax_PhoneLabel.Size = New System.Drawing.Size(118, 24)
        Fax_PhoneLabel.TabIndex = 23
        Fax_PhoneLabel.Text = "Fax Phone:"
        '
        'MenoLabel
        '
        MenoLabel.AutoSize = True
        MenoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MenoLabel.Location = New System.Drawing.Point(521, 268)
        MenoLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        MenoLabel.Name = "MenoLabel"
        MenoLabel.Size = New System.Drawing.Size(69, 24)
        MenoLabel.TabIndex = 25
        MenoLabel.Text = "Meno:"
        '
        'Patient_IDLabel
        '
        Patient_IDLabel.AutoSize = True
        Patient_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Patient_IDLabel.Location = New System.Drawing.Point(521, 314)
        Patient_IDLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Patient_IDLabel.Name = "Patient_IDLabel"
        Patient_IDLabel.Size = New System.Drawing.Size(104, 24)
        Patient_IDLabel.TabIndex = 27
        Patient_IDLabel.Text = "Patient ID:"
        '
        'Patient_NHS_NumberLabel
        '
        Patient_NHS_NumberLabel.AutoSize = True
        Patient_NHS_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Patient_NHS_NumberLabel.Location = New System.Drawing.Point(521, 358)
        Patient_NHS_NumberLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Patient_NHS_NumberLabel.Name = "Patient_NHS_NumberLabel"
        Patient_NHS_NumberLabel.Size = New System.Drawing.Size(209, 24)
        Patient_NHS_NumberLabel.TabIndex = 29
        Patient_NHS_NumberLabel.Text = "Patient NHS Number:"
        AddHandler Patient_NHS_NumberLabel.Click, AddressOf Me.Patient_NHS_NumberLabel_Click
        '
        'EMIS_NumberLabel
        '
        EMIS_NumberLabel.AutoSize = True
        EMIS_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EMIS_NumberLabel.Location = New System.Drawing.Point(521, 404)
        EMIS_NumberLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        EMIS_NumberLabel.Name = "EMIS_NumberLabel"
        EMIS_NumberLabel.Size = New System.Drawing.Size(146, 24)
        EMIS_NumberLabel.TabIndex = 31
        EMIS_NumberLabel.Text = "EMIS Number:"
        '
        'GP_Appointment_RefLabel
        '
        GP_Appointment_RefLabel.AutoSize = True
        GP_Appointment_RefLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GP_Appointment_RefLabel.Location = New System.Drawing.Point(521, 439)
        GP_Appointment_RefLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        GP_Appointment_RefLabel.Name = "GP_Appointment_RefLabel"
        GP_Appointment_RefLabel.Size = New System.Drawing.Size(205, 24)
        GP_Appointment_RefLabel.TabIndex = 33
        GP_Appointment_RefLabel.Text = "GP Appointment Ref:"
        AddHandler GP_Appointment_RefLabel.Click, AddressOf Me.GP_Appointment_RefLabel_Click
        '
        'PharmacyDataSet
        '
        Me.PharmacyDataSet.DataSetName = "pharmacyDataSet"
        Me.PharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PatientBindingSource
        '
        Me.PatientBindingSource.DataMember = "Patient"
        Me.PatientBindingSource.DataSource = Me.PharmacyDataSet
        '
        'PatientTableAdapter
        '
        Me.PatientTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DoctorTableAdapter = Nothing
        Me.TableAdapterManager.GP_AppointmentTableAdapter = Nothing
        Me.TableAdapterManager.PatientTableAdapter = Me.PatientTableAdapter
        Me.TableAdapterManager.PaymentTableAdapter = Nothing
        Me.TableAdapterManager.PharmacyTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = vb_pharmacy_management_system.pharmacyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PatientBindingNavigator
        '
        Me.PatientBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PatientBindingNavigator.BindingSource = Me.PatientBindingSource
        Me.PatientBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PatientBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PatientBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PatientBindingNavigatorSaveItem})
        Me.PatientBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PatientBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PatientBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PatientBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PatientBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PatientBindingNavigator.Name = "PatientBindingNavigator"
        Me.PatientBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.PatientBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PatientBindingNavigator.Size = New System.Drawing.Size(1362, 25)
        Me.PatientBindingNavigator.TabIndex = 0
        Me.PatientBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(96, 23)
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
        'PatientBindingNavigatorSaveItem
        '
        Me.PatientBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PatientBindingNavigatorSaveItem.Image = CType(resources.GetObject("PatientBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PatientBindingNavigatorSaveItem.Name = "PatientBindingNavigatorSaveItem"
        Me.PatientBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PatientBindingNavigatorSaveItem.Text = "Save Data"
        '
        'NI_NumberTextBox
        '
        Me.NI_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "NI Number", True))
        Me.NI_NumberTextBox.Location = New System.Drawing.Point(206, 65)
        Me.NI_NumberTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.NI_NumberTextBox.Name = "NI_NumberTextBox"
        Me.NI_NumberTextBox.Size = New System.Drawing.Size(261, 29)
        Me.NI_NumberTextBox.TabIndex = 2
        '
        'FirstnameTextBox
        '
        Me.FirstnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "Firstname", True))
        Me.FirstnameTextBox.Location = New System.Drawing.Point(206, 113)
        Me.FirstnameTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.FirstnameTextBox.Name = "FirstnameTextBox"
        Me.FirstnameTextBox.Size = New System.Drawing.Size(261, 29)
        Me.FirstnameTextBox.TabIndex = 4
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "Surname", True))
        Me.SurnameTextBox.Location = New System.Drawing.Point(206, 158)
        Me.SurnameTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(261, 29)
        Me.SurnameTextBox.TabIndex = 6
        '
        'Date_of_birthTextBox
        '
        Me.Date_of_birthTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "Date of birth", True))
        Me.Date_of_birthTextBox.Location = New System.Drawing.Point(206, 204)
        Me.Date_of_birthTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.Date_of_birthTextBox.Name = "Date_of_birthTextBox"
        Me.Date_of_birthTextBox.Size = New System.Drawing.Size(261, 29)
        Me.Date_of_birthTextBox.TabIndex = 8
        '
        'Billing_NameTextBox
        '
        Me.Billing_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "Billing Name", True))
        Me.Billing_NameTextBox.Location = New System.Drawing.Point(206, 297)
        Me.Billing_NameTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.Billing_NameTextBox.Name = "Billing_NameTextBox"
        Me.Billing_NameTextBox.Size = New System.Drawing.Size(261, 29)
        Me.Billing_NameTextBox.TabIndex = 10
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(206, 345)
        Me.AddressTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(261, 29)
        Me.AddressTextBox.TabIndex = 12
        '
        'Post_CodeTextBox
        '
        Me.Post_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "Post Code", True))
        Me.Post_CodeTextBox.Location = New System.Drawing.Point(206, 393)
        Me.Post_CodeTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.Post_CodeTextBox.Name = "Post_CodeTextBox"
        Me.Post_CodeTextBox.Size = New System.Drawing.Size(261, 29)
        Me.Post_CodeTextBox.TabIndex = 14
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(206, 439)
        Me.CityTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(261, 29)
        Me.CityTextBox.TabIndex = 16
        '
        'CountryTextBox
        '
        Me.CountryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "Country", True))
        Me.CountryTextBox.Location = New System.Drawing.Point(750, 62)
        Me.CountryTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(261, 29)
        Me.CountryTextBox.TabIndex = 18
        '
        'Home_PhoneTextBox
        '
        Me.Home_PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "Home Phone", True))
        Me.Home_PhoneTextBox.Location = New System.Drawing.Point(750, 113)
        Me.Home_PhoneTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.Home_PhoneTextBox.Name = "Home_PhoneTextBox"
        Me.Home_PhoneTextBox.Size = New System.Drawing.Size(261, 29)
        Me.Home_PhoneTextBox.TabIndex = 20
        '
        'Mobile_PhoneTextBox
        '
        Me.Mobile_PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "Mobile Phone", True))
        Me.Mobile_PhoneTextBox.Location = New System.Drawing.Point(750, 158)
        Me.Mobile_PhoneTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.Mobile_PhoneTextBox.Name = "Mobile_PhoneTextBox"
        Me.Mobile_PhoneTextBox.Size = New System.Drawing.Size(261, 29)
        Me.Mobile_PhoneTextBox.TabIndex = 22
        '
        'Fax_PhoneTextBox
        '
        Me.Fax_PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "Fax Phone", True))
        Me.Fax_PhoneTextBox.Location = New System.Drawing.Point(750, 209)
        Me.Fax_PhoneTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.Fax_PhoneTextBox.Name = "Fax_PhoneTextBox"
        Me.Fax_PhoneTextBox.Size = New System.Drawing.Size(261, 29)
        Me.Fax_PhoneTextBox.TabIndex = 24
        '
        'MenoTextBox
        '
        Me.MenoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "Meno", True))
        Me.MenoTextBox.Location = New System.Drawing.Point(750, 263)
        Me.MenoTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.MenoTextBox.Name = "MenoTextBox"
        Me.MenoTextBox.Size = New System.Drawing.Size(261, 29)
        Me.MenoTextBox.TabIndex = 26
        '
        'Patient_IDTextBox
        '
        Me.Patient_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "Patient ID", True))
        Me.Patient_IDTextBox.Location = New System.Drawing.Point(750, 309)
        Me.Patient_IDTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.Patient_IDTextBox.Name = "Patient_IDTextBox"
        Me.Patient_IDTextBox.Size = New System.Drawing.Size(261, 29)
        Me.Patient_IDTextBox.TabIndex = 28
        '
        'Patient_NHS_NumberTextBox
        '
        Me.Patient_NHS_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "Patient NHS Number", True))
        Me.Patient_NHS_NumberTextBox.Location = New System.Drawing.Point(750, 350)
        Me.Patient_NHS_NumberTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.Patient_NHS_NumberTextBox.Name = "Patient_NHS_NumberTextBox"
        Me.Patient_NHS_NumberTextBox.Size = New System.Drawing.Size(261, 29)
        Me.Patient_NHS_NumberTextBox.TabIndex = 30
        '
        'EMIS_NumberTextBox
        '
        Me.EMIS_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "EMIS Number", True))
        Me.EMIS_NumberTextBox.Location = New System.Drawing.Point(750, 393)
        Me.EMIS_NumberTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.EMIS_NumberTextBox.Name = "EMIS_NumberTextBox"
        Me.EMIS_NumberTextBox.Size = New System.Drawing.Size(261, 29)
        Me.EMIS_NumberTextBox.TabIndex = 32
        '
        'GP_Appointment_RefTextBox
        '
        Me.GP_Appointment_RefTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "GP Appointment Ref", True))
        Me.GP_Appointment_RefTextBox.Location = New System.Drawing.Point(750, 434)
        Me.GP_Appointment_RefTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.GP_Appointment_RefTextBox.Name = "GP_Appointment_RefTextBox"
        Me.GP_Appointment_RefTextBox.Size = New System.Drawing.Size(261, 29)
        Me.GP_Appointment_RefTextBox.TabIndex = 34
        '
        'PatientDataGridView
        '
        Me.PatientDataGridView.AutoGenerateColumns = False
        Me.PatientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PatientDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17})
        Me.PatientDataGridView.DataSource = Me.PatientBindingSource
        Me.PatientDataGridView.Location = New System.Drawing.Point(21, 495)
        Me.PatientDataGridView.Name = "PatientDataGridView"
        Me.PatientDataGridView.Size = New System.Drawing.Size(1315, 220)
        Me.PatientDataGridView.TabIndex = 35
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NI Number"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NI Number"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Firstname"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Firstname"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Surname"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Surname"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Date of birth"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Date of birth"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Billing Name"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Billing Name"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Address"
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
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "City"
        Me.DataGridViewTextBoxColumn8.HeaderText = "City"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Country"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Country"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Home Phone"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Home Phone"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Mobile Phone"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Mobile Phone"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Fax Phone"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Fax Phone"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Meno"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Meno"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Patient ID"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Patient ID"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Patient NHS Number"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Patient NHS Number"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "EMIS Number"
        Me.DataGridViewTextBoxColumn16.HeaderText = "EMIS Number"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "GP Appointment Ref"
        Me.DataGridViewTextBoxColumn17.HeaderText = "GP Appointment Ref"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
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
        Me.Panel1.Location = New System.Drawing.Point(1093, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(228, 398)
        Me.Panel1.TabIndex = 36
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
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PatientDataGridView)
        Me.Controls.Add(NI_NumberLabel)
        Me.Controls.Add(Me.NI_NumberTextBox)
        Me.Controls.Add(FirstnameLabel)
        Me.Controls.Add(Me.FirstnameTextBox)
        Me.Controls.Add(SurnameLabel)
        Me.Controls.Add(Me.SurnameTextBox)
        Me.Controls.Add(Date_of_birthLabel)
        Me.Controls.Add(Me.Date_of_birthTextBox)
        Me.Controls.Add(Billing_NameLabel)
        Me.Controls.Add(Me.Billing_NameTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Post_CodeLabel)
        Me.Controls.Add(Me.Post_CodeTextBox)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(CountryLabel)
        Me.Controls.Add(Me.CountryTextBox)
        Me.Controls.Add(Home_PhoneLabel)
        Me.Controls.Add(Me.Home_PhoneTextBox)
        Me.Controls.Add(Mobile_PhoneLabel)
        Me.Controls.Add(Me.Mobile_PhoneTextBox)
        Me.Controls.Add(Fax_PhoneLabel)
        Me.Controls.Add(Me.Fax_PhoneTextBox)
        Me.Controls.Add(MenoLabel)
        Me.Controls.Add(Me.MenoTextBox)
        Me.Controls.Add(Patient_IDLabel)
        Me.Controls.Add(Me.Patient_IDTextBox)
        Me.Controls.Add(Patient_NHS_NumberLabel)
        Me.Controls.Add(Me.Patient_NHS_NumberTextBox)
        Me.Controls.Add(EMIS_NumberLabel)
        Me.Controls.Add(Me.EMIS_NumberTextBox)
        Me.Controls.Add(GP_Appointment_RefLabel)
        Me.Controls.Add(Me.GP_Appointment_RefTextBox)
        Me.Controls.Add(Me.PatientBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "patient"
        CType(Me.PharmacyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PatientBindingNavigator.ResumeLayout(False)
        Me.PatientBindingNavigator.PerformLayout()
        CType(Me.PatientDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PharmacyDataSet As pharmacyDataSet
    Friend WithEvents PatientBindingSource As BindingSource
    Friend WithEvents PatientTableAdapter As pharmacyDataSetTableAdapters.PatientTableAdapter
    Friend WithEvents TableAdapterManager As pharmacyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PatientBindingNavigator As BindingNavigator
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
    Friend WithEvents PatientBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NI_NumberTextBox As TextBox
    Friend WithEvents FirstnameTextBox As TextBox
    Friend WithEvents SurnameTextBox As TextBox
    Friend WithEvents Date_of_birthTextBox As TextBox
    Friend WithEvents Billing_NameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents Post_CodeTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents CountryTextBox As TextBox
    Friend WithEvents Home_PhoneTextBox As TextBox
    Friend WithEvents Mobile_PhoneTextBox As TextBox
    Friend WithEvents Fax_PhoneTextBox As TextBox
    Friend WithEvents MenoTextBox As TextBox
    Friend WithEvents Patient_IDTextBox As TextBox
    Friend WithEvents Patient_NHS_NumberTextBox As TextBox
    Friend WithEvents EMIS_NumberTextBox As TextBox
    Friend WithEvents GP_Appointment_RefTextBox As TextBox
    Friend WithEvents PatientDataGridView As DataGridView
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
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
End Class

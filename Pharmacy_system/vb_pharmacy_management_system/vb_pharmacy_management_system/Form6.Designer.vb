<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim Reference_NumberLabel As System.Windows.Forms.Label
        Dim Pharmacy_Patient_IDLabel As System.Windows.Forms.Label
        Dim Doctors_s_NHS_NoLabel As System.Windows.Forms.Label
        Dim Medical_Centre_NameLabel As System.Windows.Forms.Label
        Dim Doctor_EMIS_NumberLabel As System.Windows.Forms.Label
        Dim Doctor_GP_Appointment_RefLabel As System.Windows.Forms.Label
        Dim Doctor_Patient_NHS_NumberLabel As System.Windows.Forms.Label
        Dim GP_Appointment_GP_Appointment_RefLabel As System.Windows.Forms.Label
        Dim GP_Appointment_Patient_NHS_NumberLabel As System.Windows.Forms.Label
        Dim GP_Appointment_EMIS_NumberLabel As System.Windows.Forms.Label
        Dim GP_Appointment_Patient_IDLabel As System.Windows.Forms.Label
        Dim Patient_Patient_IDLabel As System.Windows.Forms.Label
        Dim Patient_Patient_NHS_NumberLabel As System.Windows.Forms.Label
        Dim Invoice_NoLabel As System.Windows.Forms.Label
        Dim Payment_Patient_IDLabel As System.Windows.Forms.Label
        Dim Payment_Patient_NHS_NumberLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.PharmacyDataSet = New vb_pharmacy_management_system.pharmacyDataSet()
        Me.Pharmacy_officeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pharmacy_officeTableAdapter = New vb_pharmacy_management_system.pharmacyDataSetTableAdapters.pharmacy_officeTableAdapter()
        Me.TableAdapterManager = New vb_pharmacy_management_system.pharmacyDataSetTableAdapters.TableAdapterManager()
        Me.Pharmacy_officeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Pharmacy_officeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Reference_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Pharmacy_Patient_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Doctors_s_NHS_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Medical_Centre_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Doctor_EMIS_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Doctor_GP_Appointment_RefTextBox = New System.Windows.Forms.TextBox()
        Me.Doctor_Patient_NHS_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.GP_Appointment_GP_Appointment_RefTextBox = New System.Windows.Forms.TextBox()
        Me.GP_Appointment_Patient_NHS_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.GP_Appointment_EMIS_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.GP_Appointment_Patient_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Patient_Patient_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Patient_Patient_NHS_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Invoice_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Payment_Patient_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Payment_Patient_NHS_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Pharmacy_officeDataGridView = New System.Windows.Forms.DataGridView()
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
        Reference_NumberLabel = New System.Windows.Forms.Label()
        Pharmacy_Patient_IDLabel = New System.Windows.Forms.Label()
        Doctors_s_NHS_NoLabel = New System.Windows.Forms.Label()
        Medical_Centre_NameLabel = New System.Windows.Forms.Label()
        Doctor_EMIS_NumberLabel = New System.Windows.Forms.Label()
        Doctor_GP_Appointment_RefLabel = New System.Windows.Forms.Label()
        Doctor_Patient_NHS_NumberLabel = New System.Windows.Forms.Label()
        GP_Appointment_GP_Appointment_RefLabel = New System.Windows.Forms.Label()
        GP_Appointment_Patient_NHS_NumberLabel = New System.Windows.Forms.Label()
        GP_Appointment_EMIS_NumberLabel = New System.Windows.Forms.Label()
        GP_Appointment_Patient_IDLabel = New System.Windows.Forms.Label()
        Patient_Patient_IDLabel = New System.Windows.Forms.Label()
        Patient_Patient_NHS_NumberLabel = New System.Windows.Forms.Label()
        Invoice_NoLabel = New System.Windows.Forms.Label()
        Payment_Patient_IDLabel = New System.Windows.Forms.Label()
        Payment_Patient_NHS_NumberLabel = New System.Windows.Forms.Label()
        CType(Me.PharmacyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pharmacy_officeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pharmacy_officeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pharmacy_officeBindingNavigator.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Pharmacy_officeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Reference_NumberLabel
        '
        Reference_NumberLabel.AutoSize = True
        Reference_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Reference_NumberLabel.Location = New System.Drawing.Point(14, 69)
        Reference_NumberLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Reference_NumberLabel.Name = "Reference_NumberLabel"
        Reference_NumberLabel.Size = New System.Drawing.Size(165, 20)
        Reference_NumberLabel.TabIndex = 1
        Reference_NumberLabel.Text = "Reference Number:"
        '
        'Pharmacy_Patient_IDLabel
        '
        Pharmacy_Patient_IDLabel.AutoSize = True
        Pharmacy_Patient_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Pharmacy_Patient_IDLabel.Location = New System.Drawing.Point(14, 109)
        Pharmacy_Patient_IDLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Pharmacy_Patient_IDLabel.Name = "Pharmacy_Patient_IDLabel"
        Pharmacy_Patient_IDLabel.Size = New System.Drawing.Size(178, 20)
        Pharmacy_Patient_IDLabel.TabIndex = 3
        Pharmacy_Patient_IDLabel.Text = "Pharmacy Patient ID:"
        '
        'Doctors_s_NHS_NoLabel
        '
        Doctors_s_NHS_NoLabel.AutoSize = True
        Doctors_s_NHS_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Doctors_s_NHS_NoLabel.Location = New System.Drawing.Point(14, 149)
        Doctors_s_NHS_NoLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Doctors_s_NHS_NoLabel.Name = "Doctors_s_NHS_NoLabel"
        Doctors_s_NHS_NoLabel.Size = New System.Drawing.Size(159, 20)
        Doctors_s_NHS_NoLabel.TabIndex = 5
        Doctors_s_NHS_NoLabel.Text = "Doctors's NHS No:"
        '
        'Medical_Centre_NameLabel
        '
        Medical_Centre_NameLabel.AutoSize = True
        Medical_Centre_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Medical_Centre_NameLabel.Location = New System.Drawing.Point(14, 189)
        Medical_Centre_NameLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Medical_Centre_NameLabel.Name = "Medical_Centre_NameLabel"
        Medical_Centre_NameLabel.Size = New System.Drawing.Size(185, 20)
        Medical_Centre_NameLabel.TabIndex = 7
        Medical_Centre_NameLabel.Text = "Medical Centre Name:"
        '
        'Doctor_EMIS_NumberLabel
        '
        Doctor_EMIS_NumberLabel.AutoSize = True
        Doctor_EMIS_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Doctor_EMIS_NumberLabel.Location = New System.Drawing.Point(14, 249)
        Doctor_EMIS_NumberLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Doctor_EMIS_NumberLabel.Name = "Doctor_EMIS_NumberLabel"
        Doctor_EMIS_NumberLabel.Size = New System.Drawing.Size(184, 20)
        Doctor_EMIS_NumberLabel.TabIndex = 9
        Doctor_EMIS_NumberLabel.Text = "Doctor EMIS Number:"
        '
        'Doctor_GP_Appointment_RefLabel
        '
        Doctor_GP_Appointment_RefLabel.AutoSize = True
        Doctor_GP_Appointment_RefLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Doctor_GP_Appointment_RefLabel.Location = New System.Drawing.Point(14, 289)
        Doctor_GP_Appointment_RefLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Doctor_GP_Appointment_RefLabel.Name = "Doctor_GP_Appointment_RefLabel"
        Doctor_GP_Appointment_RefLabel.Size = New System.Drawing.Size(239, 20)
        Doctor_GP_Appointment_RefLabel.TabIndex = 11
        Doctor_GP_Appointment_RefLabel.Text = "Doctor GP Appointment Ref:"
        '
        'Doctor_Patient_NHS_NumberLabel
        '
        Doctor_Patient_NHS_NumberLabel.AutoSize = True
        Doctor_Patient_NHS_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Doctor_Patient_NHS_NumberLabel.Location = New System.Drawing.Point(14, 329)
        Doctor_Patient_NHS_NumberLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Doctor_Patient_NHS_NumberLabel.Name = "Doctor_Patient_NHS_NumberLabel"
        Doctor_Patient_NHS_NumberLabel.Size = New System.Drawing.Size(239, 20)
        Doctor_Patient_NHS_NumberLabel.TabIndex = 13
        Doctor_Patient_NHS_NumberLabel.Text = "Doctor Patient NHS Number:"
        '
        'GP_Appointment_GP_Appointment_RefLabel
        '
        GP_Appointment_GP_Appointment_RefLabel.AutoSize = True
        GP_Appointment_GP_Appointment_RefLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GP_Appointment_GP_Appointment_RefLabel.Location = New System.Drawing.Point(14, 369)
        GP_Appointment_GP_Appointment_RefLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        GP_Appointment_GP_Appointment_RefLabel.Name = "GP_Appointment_GP_Appointment_RefLabel"
        GP_Appointment_GP_Appointment_RefLabel.Size = New System.Drawing.Size(317, 20)
        GP_Appointment_GP_Appointment_RefLabel.TabIndex = 15
        GP_Appointment_GP_Appointment_RefLabel.Text = "GP Appointment GP Appointment Ref:"
        '
        'GP_Appointment_Patient_NHS_NumberLabel
        '
        GP_Appointment_Patient_NHS_NumberLabel.AutoSize = True
        GP_Appointment_Patient_NHS_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GP_Appointment_Patient_NHS_NumberLabel.Location = New System.Drawing.Point(563, 63)
        GP_Appointment_Patient_NHS_NumberLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        GP_Appointment_Patient_NHS_NumberLabel.Name = "GP_Appointment_Patient_NHS_NumberLabel"
        GP_Appointment_Patient_NHS_NumberLabel.Size = New System.Drawing.Size(317, 20)
        GP_Appointment_Patient_NHS_NumberLabel.TabIndex = 17
        GP_Appointment_Patient_NHS_NumberLabel.Text = "GP Appointment Patient NHS Number:"
        '
        'GP_Appointment_EMIS_NumberLabel
        '
        GP_Appointment_EMIS_NumberLabel.AutoSize = True
        GP_Appointment_EMIS_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GP_Appointment_EMIS_NumberLabel.Location = New System.Drawing.Point(563, 103)
        GP_Appointment_EMIS_NumberLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        GP_Appointment_EMIS_NumberLabel.Name = "GP_Appointment_EMIS_NumberLabel"
        GP_Appointment_EMIS_NumberLabel.Size = New System.Drawing.Size(262, 20)
        GP_Appointment_EMIS_NumberLabel.TabIndex = 19
        GP_Appointment_EMIS_NumberLabel.Text = "GP Appointment EMIS Number:"
        '
        'GP_Appointment_Patient_IDLabel
        '
        GP_Appointment_Patient_IDLabel.AutoSize = True
        GP_Appointment_Patient_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GP_Appointment_Patient_IDLabel.Location = New System.Drawing.Point(563, 143)
        GP_Appointment_Patient_IDLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        GP_Appointment_Patient_IDLabel.Name = "GP_Appointment_Patient_IDLabel"
        GP_Appointment_Patient_IDLabel.Size = New System.Drawing.Size(232, 20)
        GP_Appointment_Patient_IDLabel.TabIndex = 21
        GP_Appointment_Patient_IDLabel.Text = "GP Appointment Patient ID:"
        '
        'Patient_Patient_IDLabel
        '
        Patient_Patient_IDLabel.AutoSize = True
        Patient_Patient_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Patient_Patient_IDLabel.Location = New System.Drawing.Point(563, 183)
        Patient_Patient_IDLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Patient_Patient_IDLabel.Name = "Patient_Patient_IDLabel"
        Patient_Patient_IDLabel.Size = New System.Drawing.Size(157, 20)
        Patient_Patient_IDLabel.TabIndex = 23
        Patient_Patient_IDLabel.Text = "Patient Patient ID:"
        '
        'Patient_Patient_NHS_NumberLabel
        '
        Patient_Patient_NHS_NumberLabel.AutoSize = True
        Patient_Patient_NHS_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Patient_Patient_NHS_NumberLabel.Location = New System.Drawing.Point(563, 255)
        Patient_Patient_NHS_NumberLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Patient_Patient_NHS_NumberLabel.Name = "Patient_Patient_NHS_NumberLabel"
        Patient_Patient_NHS_NumberLabel.Size = New System.Drawing.Size(242, 20)
        Patient_Patient_NHS_NumberLabel.TabIndex = 25
        Patient_Patient_NHS_NumberLabel.Text = "Patient Patient NHS Number:"
        '
        'Invoice_NoLabel
        '
        Invoice_NoLabel.AutoSize = True
        Invoice_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Invoice_NoLabel.Location = New System.Drawing.Point(563, 295)
        Invoice_NoLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Invoice_NoLabel.Name = "Invoice_NoLabel"
        Invoice_NoLabel.Size = New System.Drawing.Size(98, 20)
        Invoice_NoLabel.TabIndex = 27
        Invoice_NoLabel.Text = "Invoice No:"
        '
        'Payment_Patient_IDLabel
        '
        Payment_Patient_IDLabel.AutoSize = True
        Payment_Patient_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Payment_Patient_IDLabel.Location = New System.Drawing.Point(563, 335)
        Payment_Patient_IDLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Payment_Patient_IDLabel.Name = "Payment_Patient_IDLabel"
        Payment_Patient_IDLabel.Size = New System.Drawing.Size(169, 20)
        Payment_Patient_IDLabel.TabIndex = 29
        Payment_Patient_IDLabel.Text = "Payment Patient ID:"
        '
        'Payment_Patient_NHS_NumberLabel
        '
        Payment_Patient_NHS_NumberLabel.AutoSize = True
        Payment_Patient_NHS_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Payment_Patient_NHS_NumberLabel.Location = New System.Drawing.Point(563, 375)
        Payment_Patient_NHS_NumberLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Payment_Patient_NHS_NumberLabel.Name = "Payment_Patient_NHS_NumberLabel"
        Payment_Patient_NHS_NumberLabel.Size = New System.Drawing.Size(254, 20)
        Payment_Patient_NHS_NumberLabel.TabIndex = 31
        Payment_Patient_NHS_NumberLabel.Text = "Payment Patient NHS Number:"
        '
        'PharmacyDataSet
        '
        Me.PharmacyDataSet.DataSetName = "pharmacyDataSet"
        Me.PharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Pharmacy_officeBindingSource
        '
        Me.Pharmacy_officeBindingSource.DataMember = "pharmacy_office"
        Me.Pharmacy_officeBindingSource.DataSource = Me.PharmacyDataSet
        '
        'Pharmacy_officeTableAdapter
        '
        Me.Pharmacy_officeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.DoctorTableAdapter = Nothing
        Me.TableAdapterManager.GP_AppointmentTableAdapter = Nothing
        Me.TableAdapterManager.PatientTableAdapter = Nothing
        Me.TableAdapterManager.PaymentTableAdapter = Nothing
        Me.TableAdapterManager.PharmacyTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = vb_pharmacy_management_system.pharmacyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Pharmacy_officeBindingNavigator
        '
        Me.Pharmacy_officeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Pharmacy_officeBindingNavigator.BindingSource = Me.Pharmacy_officeBindingSource
        Me.Pharmacy_officeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Pharmacy_officeBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Pharmacy_officeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Pharmacy_officeBindingNavigatorSaveItem})
        Me.Pharmacy_officeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Pharmacy_officeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Pharmacy_officeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Pharmacy_officeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Pharmacy_officeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Pharmacy_officeBindingNavigator.Name = "Pharmacy_officeBindingNavigator"
        Me.Pharmacy_officeBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.Pharmacy_officeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Pharmacy_officeBindingNavigator.Size = New System.Drawing.Size(1362, 25)
        Me.Pharmacy_officeBindingNavigator.TabIndex = 0
        Me.Pharmacy_officeBindingNavigator.Text = "BindingNavigator1"
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
        'Pharmacy_officeBindingNavigatorSaveItem
        '
        Me.Pharmacy_officeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Pharmacy_officeBindingNavigatorSaveItem.Enabled = False
        Me.Pharmacy_officeBindingNavigatorSaveItem.Image = CType(resources.GetObject("Pharmacy_officeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Pharmacy_officeBindingNavigatorSaveItem.Name = "Pharmacy_officeBindingNavigatorSaveItem"
        Me.Pharmacy_officeBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Pharmacy_officeBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Reference_NumberTextBox
        '
        Me.Reference_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pharmacy_officeBindingSource, "Reference Number", True))
        Me.Reference_NumberTextBox.Location = New System.Drawing.Point(340, 63)
        Me.Reference_NumberTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Reference_NumberTextBox.Name = "Reference_NumberTextBox"
        Me.Reference_NumberTextBox.Size = New System.Drawing.Size(202, 26)
        Me.Reference_NumberTextBox.TabIndex = 2
        '
        'Pharmacy_Patient_IDTextBox
        '
        Me.Pharmacy_Patient_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pharmacy_officeBindingSource, "Pharmacy_Patient ID", True))
        Me.Pharmacy_Patient_IDTextBox.Location = New System.Drawing.Point(340, 103)
        Me.Pharmacy_Patient_IDTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Pharmacy_Patient_IDTextBox.Name = "Pharmacy_Patient_IDTextBox"
        Me.Pharmacy_Patient_IDTextBox.Size = New System.Drawing.Size(202, 26)
        Me.Pharmacy_Patient_IDTextBox.TabIndex = 4
        '
        'Doctors_s_NHS_NoTextBox
        '
        Me.Doctors_s_NHS_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pharmacy_officeBindingSource, "Doctors's NHS No", True))
        Me.Doctors_s_NHS_NoTextBox.Location = New System.Drawing.Point(340, 143)
        Me.Doctors_s_NHS_NoTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Doctors_s_NHS_NoTextBox.Name = "Doctors_s_NHS_NoTextBox"
        Me.Doctors_s_NHS_NoTextBox.Size = New System.Drawing.Size(202, 26)
        Me.Doctors_s_NHS_NoTextBox.TabIndex = 6
        '
        'Medical_Centre_NameTextBox
        '
        Me.Medical_Centre_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pharmacy_officeBindingSource, "Medical Centre Name", True))
        Me.Medical_Centre_NameTextBox.Location = New System.Drawing.Point(340, 183)
        Me.Medical_Centre_NameTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Medical_Centre_NameTextBox.Name = "Medical_Centre_NameTextBox"
        Me.Medical_Centre_NameTextBox.Size = New System.Drawing.Size(202, 26)
        Me.Medical_Centre_NameTextBox.TabIndex = 8
        '
        'Doctor_EMIS_NumberTextBox
        '
        Me.Doctor_EMIS_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pharmacy_officeBindingSource, "Doctor_EMIS Number", True))
        Me.Doctor_EMIS_NumberTextBox.Location = New System.Drawing.Point(340, 255)
        Me.Doctor_EMIS_NumberTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Doctor_EMIS_NumberTextBox.Name = "Doctor_EMIS_NumberTextBox"
        Me.Doctor_EMIS_NumberTextBox.Size = New System.Drawing.Size(202, 26)
        Me.Doctor_EMIS_NumberTextBox.TabIndex = 10
        '
        'Doctor_GP_Appointment_RefTextBox
        '
        Me.Doctor_GP_Appointment_RefTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pharmacy_officeBindingSource, "Doctor_GP Appointment Ref", True))
        Me.Doctor_GP_Appointment_RefTextBox.Location = New System.Drawing.Point(340, 295)
        Me.Doctor_GP_Appointment_RefTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Doctor_GP_Appointment_RefTextBox.Name = "Doctor_GP_Appointment_RefTextBox"
        Me.Doctor_GP_Appointment_RefTextBox.Size = New System.Drawing.Size(202, 26)
        Me.Doctor_GP_Appointment_RefTextBox.TabIndex = 12
        '
        'Doctor_Patient_NHS_NumberTextBox
        '
        Me.Doctor_Patient_NHS_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pharmacy_officeBindingSource, "Doctor_Patient NHS Number", True))
        Me.Doctor_Patient_NHS_NumberTextBox.Location = New System.Drawing.Point(340, 335)
        Me.Doctor_Patient_NHS_NumberTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Doctor_Patient_NHS_NumberTextBox.Name = "Doctor_Patient_NHS_NumberTextBox"
        Me.Doctor_Patient_NHS_NumberTextBox.Size = New System.Drawing.Size(202, 26)
        Me.Doctor_Patient_NHS_NumberTextBox.TabIndex = 14
        '
        'GP_Appointment_GP_Appointment_RefTextBox
        '
        Me.GP_Appointment_GP_Appointment_RefTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pharmacy_officeBindingSource, "GP Appointment_GP Appointment Ref", True))
        Me.GP_Appointment_GP_Appointment_RefTextBox.Location = New System.Drawing.Point(340, 375)
        Me.GP_Appointment_GP_Appointment_RefTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GP_Appointment_GP_Appointment_RefTextBox.Name = "GP_Appointment_GP_Appointment_RefTextBox"
        Me.GP_Appointment_GP_Appointment_RefTextBox.Size = New System.Drawing.Size(202, 26)
        Me.GP_Appointment_GP_Appointment_RefTextBox.TabIndex = 16
        '
        'GP_Appointment_Patient_NHS_NumberTextBox
        '
        Me.GP_Appointment_Patient_NHS_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pharmacy_officeBindingSource, "GP Appointment_Patient NHS Number", True))
        Me.GP_Appointment_Patient_NHS_NumberTextBox.Location = New System.Drawing.Point(900, 57)
        Me.GP_Appointment_Patient_NHS_NumberTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GP_Appointment_Patient_NHS_NumberTextBox.Name = "GP_Appointment_Patient_NHS_NumberTextBox"
        Me.GP_Appointment_Patient_NHS_NumberTextBox.Size = New System.Drawing.Size(202, 26)
        Me.GP_Appointment_Patient_NHS_NumberTextBox.TabIndex = 18
        '
        'GP_Appointment_EMIS_NumberTextBox
        '
        Me.GP_Appointment_EMIS_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pharmacy_officeBindingSource, "GP Appointment_EMIS Number", True))
        Me.GP_Appointment_EMIS_NumberTextBox.Location = New System.Drawing.Point(900, 97)
        Me.GP_Appointment_EMIS_NumberTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GP_Appointment_EMIS_NumberTextBox.Name = "GP_Appointment_EMIS_NumberTextBox"
        Me.GP_Appointment_EMIS_NumberTextBox.Size = New System.Drawing.Size(202, 26)
        Me.GP_Appointment_EMIS_NumberTextBox.TabIndex = 20
        '
        'GP_Appointment_Patient_IDTextBox
        '
        Me.GP_Appointment_Patient_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pharmacy_officeBindingSource, "GP Appointment_Patient ID", True))
        Me.GP_Appointment_Patient_IDTextBox.Location = New System.Drawing.Point(900, 137)
        Me.GP_Appointment_Patient_IDTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GP_Appointment_Patient_IDTextBox.Name = "GP_Appointment_Patient_IDTextBox"
        Me.GP_Appointment_Patient_IDTextBox.Size = New System.Drawing.Size(202, 26)
        Me.GP_Appointment_Patient_IDTextBox.TabIndex = 22
        '
        'Patient_Patient_IDTextBox
        '
        Me.Patient_Patient_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pharmacy_officeBindingSource, "Patient_Patient ID", True))
        Me.Patient_Patient_IDTextBox.Location = New System.Drawing.Point(900, 177)
        Me.Patient_Patient_IDTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Patient_Patient_IDTextBox.Name = "Patient_Patient_IDTextBox"
        Me.Patient_Patient_IDTextBox.Size = New System.Drawing.Size(202, 26)
        Me.Patient_Patient_IDTextBox.TabIndex = 24
        '
        'Patient_Patient_NHS_NumberTextBox
        '
        Me.Patient_Patient_NHS_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pharmacy_officeBindingSource, "Patient_Patient NHS Number", True))
        Me.Patient_Patient_NHS_NumberTextBox.Location = New System.Drawing.Point(900, 249)
        Me.Patient_Patient_NHS_NumberTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Patient_Patient_NHS_NumberTextBox.Name = "Patient_Patient_NHS_NumberTextBox"
        Me.Patient_Patient_NHS_NumberTextBox.Size = New System.Drawing.Size(202, 26)
        Me.Patient_Patient_NHS_NumberTextBox.TabIndex = 26
        '
        'Invoice_NoTextBox
        '
        Me.Invoice_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pharmacy_officeBindingSource, "Invoice No", True))
        Me.Invoice_NoTextBox.Location = New System.Drawing.Point(900, 289)
        Me.Invoice_NoTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Invoice_NoTextBox.Name = "Invoice_NoTextBox"
        Me.Invoice_NoTextBox.Size = New System.Drawing.Size(202, 26)
        Me.Invoice_NoTextBox.TabIndex = 28
        '
        'Payment_Patient_IDTextBox
        '
        Me.Payment_Patient_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pharmacy_officeBindingSource, "Payment_Patient ID", True))
        Me.Payment_Patient_IDTextBox.Location = New System.Drawing.Point(900, 329)
        Me.Payment_Patient_IDTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Payment_Patient_IDTextBox.Name = "Payment_Patient_IDTextBox"
        Me.Payment_Patient_IDTextBox.Size = New System.Drawing.Size(202, 26)
        Me.Payment_Patient_IDTextBox.TabIndex = 30
        '
        'Payment_Patient_NHS_NumberTextBox
        '
        Me.Payment_Patient_NHS_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pharmacy_officeBindingSource, "Payment_Patient NHS Number", True))
        Me.Payment_Patient_NHS_NumberTextBox.Location = New System.Drawing.Point(900, 369)
        Me.Payment_Patient_NHS_NumberTextBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Payment_Patient_NHS_NumberTextBox.Name = "Payment_Patient_NHS_NumberTextBox"
        Me.Payment_Patient_NHS_NumberTextBox.Size = New System.Drawing.Size(202, 26)
        Me.Payment_Patient_NHS_NumberTextBox.TabIndex = 32
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
        Me.Panel1.Location = New System.Drawing.Point(1132, 57)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(218, 338)
        Me.Panel1.TabIndex = 35
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(8, 285)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(201, 35)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(8, 231)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(201, 35)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(8, 113)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(201, 35)
        Me.btnNext.TabIndex = 0
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(8, 175)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(201, 35)
        Me.btnPrevious.TabIndex = 0
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(8, 59)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(201, 35)
        Me.btnDelete.TabIndex = 0
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(8, 10)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(201, 32)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add New"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Pharmacy_officeDataGridView
        '
        Me.Pharmacy_officeDataGridView.AutoGenerateColumns = False
        Me.Pharmacy_officeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Pharmacy_officeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.Pharmacy_officeDataGridView.DataSource = Me.Pharmacy_officeBindingSource
        Me.Pharmacy_officeDataGridView.Location = New System.Drawing.Point(18, 427)
        Me.Pharmacy_officeDataGridView.Name = "Pharmacy_officeDataGridView"
        Me.Pharmacy_officeDataGridView.Size = New System.Drawing.Size(1332, 284)
        Me.Pharmacy_officeDataGridView.TabIndex = 35
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Reference Number"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Reference Number"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Pharmacy_Patient ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Pharmacy_Patient ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Doctors's NHS No"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Doctors's NHS No"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Medical Centre Name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Medical Centre Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Doctor_EMIS Number"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Doctor_EMIS Number"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Doctor_GP Appointment Ref"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Doctor_GP Appointment Ref"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Doctor_Patient NHS Number"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Doctor_Patient NHS Number"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "GP Appointment_GP Appointment Ref"
        Me.DataGridViewTextBoxColumn8.HeaderText = "GP Appointment_GP Appointment Ref"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "GP Appointment_Patient NHS Number"
        Me.DataGridViewTextBoxColumn9.HeaderText = "GP Appointment_Patient NHS Number"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "GP Appointment_EMIS Number"
        Me.DataGridViewTextBoxColumn10.HeaderText = "GP Appointment_EMIS Number"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "GP Appointment_Patient ID"
        Me.DataGridViewTextBoxColumn11.HeaderText = "GP Appointment_Patient ID"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Patient_Patient ID"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Patient_Patient ID"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Patient_Patient NHS Number"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Patient_Patient NHS Number"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Invoice No"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Invoice No"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Payment_Patient ID"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Payment_Patient ID"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Payment_Patient NHS Number"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Payment_Patient NHS Number"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.Pharmacy_officeDataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Reference_NumberLabel)
        Me.Controls.Add(Me.Reference_NumberTextBox)
        Me.Controls.Add(Pharmacy_Patient_IDLabel)
        Me.Controls.Add(Me.Pharmacy_Patient_IDTextBox)
        Me.Controls.Add(Doctors_s_NHS_NoLabel)
        Me.Controls.Add(Me.Doctors_s_NHS_NoTextBox)
        Me.Controls.Add(Medical_Centre_NameLabel)
        Me.Controls.Add(Me.Medical_Centre_NameTextBox)
        Me.Controls.Add(Doctor_EMIS_NumberLabel)
        Me.Controls.Add(Me.Doctor_EMIS_NumberTextBox)
        Me.Controls.Add(Doctor_GP_Appointment_RefLabel)
        Me.Controls.Add(Me.Doctor_GP_Appointment_RefTextBox)
        Me.Controls.Add(Doctor_Patient_NHS_NumberLabel)
        Me.Controls.Add(Me.Doctor_Patient_NHS_NumberTextBox)
        Me.Controls.Add(GP_Appointment_GP_Appointment_RefLabel)
        Me.Controls.Add(Me.GP_Appointment_GP_Appointment_RefTextBox)
        Me.Controls.Add(GP_Appointment_Patient_NHS_NumberLabel)
        Me.Controls.Add(Me.GP_Appointment_Patient_NHS_NumberTextBox)
        Me.Controls.Add(GP_Appointment_EMIS_NumberLabel)
        Me.Controls.Add(Me.GP_Appointment_EMIS_NumberTextBox)
        Me.Controls.Add(GP_Appointment_Patient_IDLabel)
        Me.Controls.Add(Me.GP_Appointment_Patient_IDTextBox)
        Me.Controls.Add(Patient_Patient_IDLabel)
        Me.Controls.Add(Me.Patient_Patient_IDTextBox)
        Me.Controls.Add(Patient_Patient_NHS_NumberLabel)
        Me.Controls.Add(Me.Patient_Patient_NHS_NumberTextBox)
        Me.Controls.Add(Invoice_NoLabel)
        Me.Controls.Add(Me.Invoice_NoTextBox)
        Me.Controls.Add(Payment_Patient_IDLabel)
        Me.Controls.Add(Me.Payment_Patient_IDTextBox)
        Me.Controls.Add(Payment_Patient_NHS_NumberLabel)
        Me.Controls.Add(Me.Payment_Patient_NHS_NumberTextBox)
        Me.Controls.Add(Me.Pharmacy_officeBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pharmacy_office"
        CType(Me.PharmacyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pharmacy_officeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pharmacy_officeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pharmacy_officeBindingNavigator.ResumeLayout(False)
        Me.Pharmacy_officeBindingNavigator.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.Pharmacy_officeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PharmacyDataSet As pharmacyDataSet
    Friend WithEvents Pharmacy_officeBindingSource As BindingSource
    Friend WithEvents Pharmacy_officeTableAdapter As pharmacyDataSetTableAdapters.pharmacy_officeTableAdapter
    Friend WithEvents TableAdapterManager As pharmacyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Pharmacy_officeBindingNavigator As BindingNavigator
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
    Friend WithEvents Pharmacy_officeBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Reference_NumberTextBox As TextBox
    Friend WithEvents Pharmacy_Patient_IDTextBox As TextBox
    Friend WithEvents Doctors_s_NHS_NoTextBox As TextBox
    Friend WithEvents Medical_Centre_NameTextBox As TextBox
    Friend WithEvents Doctor_EMIS_NumberTextBox As TextBox
    Friend WithEvents Doctor_GP_Appointment_RefTextBox As TextBox
    Friend WithEvents Doctor_Patient_NHS_NumberTextBox As TextBox
    Friend WithEvents GP_Appointment_GP_Appointment_RefTextBox As TextBox
    Friend WithEvents GP_Appointment_Patient_NHS_NumberTextBox As TextBox
    Friend WithEvents GP_Appointment_EMIS_NumberTextBox As TextBox
    Friend WithEvents GP_Appointment_Patient_IDTextBox As TextBox
    Friend WithEvents Patient_Patient_IDTextBox As TextBox
    Friend WithEvents Patient_Patient_NHS_NumberTextBox As TextBox
    Friend WithEvents Invoice_NoTextBox As TextBox
    Friend WithEvents Payment_Patient_IDTextBox As TextBox
    Friend WithEvents Payment_Patient_NHS_NumberTextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Pharmacy_officeDataGridView As DataGridView
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
End Class

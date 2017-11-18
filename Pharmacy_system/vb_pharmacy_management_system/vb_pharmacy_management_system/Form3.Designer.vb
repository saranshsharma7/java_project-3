<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim GP_Appointment_RefLabel As System.Windows.Forms.Label
        Dim Patient_NHS_NumberLabel As System.Windows.Forms.Label
        Dim EMIS_NumberLabel As System.Windows.Forms.Label
        Dim GP_AppointmentLabel As System.Windows.Forms.Label
        Dim Patient_Full_NameLabel As System.Windows.Forms.Label
        Dim Patient_IDLabel As System.Windows.Forms.Label
        Dim Medical_Centre_NameLabel As System.Windows.Forms.Label
        Dim Doctor_s_NHS_NoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.PharmacyDataSet = New vb_pharmacy_management_system.pharmacyDataSet()
        Me.GP_AppointmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GP_AppointmentTableAdapter = New vb_pharmacy_management_system.pharmacyDataSetTableAdapters.GP_AppointmentTableAdapter()
        Me.TableAdapterManager = New vb_pharmacy_management_system.pharmacyDataSetTableAdapters.TableAdapterManager()
        Me.GP_AppointmentBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.GP_AppointmentBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.GP_Appointment_RefTextBox = New System.Windows.Forms.TextBox()
        Me.Patient_NHS_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.EMIS_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.GP_AppointmentTextBox = New System.Windows.Forms.TextBox()
        Me.Patient_Full_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Patient_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Medical_Centre_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Doctor_s_NHS_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GP_AppointmentDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        GP_Appointment_RefLabel = New System.Windows.Forms.Label()
        Patient_NHS_NumberLabel = New System.Windows.Forms.Label()
        EMIS_NumberLabel = New System.Windows.Forms.Label()
        GP_AppointmentLabel = New System.Windows.Forms.Label()
        Patient_Full_NameLabel = New System.Windows.Forms.Label()
        Patient_IDLabel = New System.Windows.Forms.Label()
        Medical_Centre_NameLabel = New System.Windows.Forms.Label()
        Doctor_s_NHS_NoLabel = New System.Windows.Forms.Label()
        CType(Me.PharmacyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GP_AppointmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GP_AppointmentBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GP_AppointmentBindingNavigator.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GP_AppointmentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GP_Appointment_RefLabel
        '
        GP_Appointment_RefLabel.AutoSize = True
        GP_Appointment_RefLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GP_Appointment_RefLabel.ForeColor = System.Drawing.SystemColors.ControlText
        GP_Appointment_RefLabel.Location = New System.Drawing.Point(66, 68)
        GP_Appointment_RefLabel.Name = "GP_Appointment_RefLabel"
        GP_Appointment_RefLabel.Size = New System.Drawing.Size(205, 24)
        GP_Appointment_RefLabel.TabIndex = 1
        GP_Appointment_RefLabel.Text = "GP Appointment Ref:"
        '
        'Patient_NHS_NumberLabel
        '
        Patient_NHS_NumberLabel.AutoSize = True
        Patient_NHS_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Patient_NHS_NumberLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Patient_NHS_NumberLabel.Location = New System.Drawing.Point(66, 106)
        Patient_NHS_NumberLabel.Name = "Patient_NHS_NumberLabel"
        Patient_NHS_NumberLabel.Size = New System.Drawing.Size(209, 24)
        Patient_NHS_NumberLabel.TabIndex = 3
        Patient_NHS_NumberLabel.Text = "Patient NHS Number:"
        '
        'EMIS_NumberLabel
        '
        EMIS_NumberLabel.AutoSize = True
        EMIS_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EMIS_NumberLabel.ForeColor = System.Drawing.SystemColors.ControlText
        EMIS_NumberLabel.Location = New System.Drawing.Point(66, 147)
        EMIS_NumberLabel.Name = "EMIS_NumberLabel"
        EMIS_NumberLabel.Size = New System.Drawing.Size(146, 24)
        EMIS_NumberLabel.TabIndex = 5
        EMIS_NumberLabel.Text = "EMIS Number:"
        '
        'GP_AppointmentLabel
        '
        GP_AppointmentLabel.AutoSize = True
        GP_AppointmentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GP_AppointmentLabel.ForeColor = System.Drawing.SystemColors.ControlText
        GP_AppointmentLabel.Location = New System.Drawing.Point(66, 189)
        GP_AppointmentLabel.Name = "GP_AppointmentLabel"
        GP_AppointmentLabel.Size = New System.Drawing.Size(168, 24)
        GP_AppointmentLabel.TabIndex = 7
        GP_AppointmentLabel.Text = "GP Appointment:"
        '
        'Patient_Full_NameLabel
        '
        Patient_Full_NameLabel.AutoSize = True
        Patient_Full_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Patient_Full_NameLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Patient_Full_NameLabel.Location = New System.Drawing.Point(66, 225)
        Patient_Full_NameLabel.Name = "Patient_Full_NameLabel"
        Patient_Full_NameLabel.Size = New System.Drawing.Size(181, 24)
        Patient_Full_NameLabel.TabIndex = 9
        Patient_Full_NameLabel.Text = "Patient Full Name:"
        '
        'Patient_IDLabel
        '
        Patient_IDLabel.AutoSize = True
        Patient_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Patient_IDLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Patient_IDLabel.Location = New System.Drawing.Point(66, 262)
        Patient_IDLabel.Name = "Patient_IDLabel"
        Patient_IDLabel.Size = New System.Drawing.Size(104, 24)
        Patient_IDLabel.TabIndex = 11
        Patient_IDLabel.Text = "Patient ID:"
        '
        'Medical_Centre_NameLabel
        '
        Medical_Centre_NameLabel.AutoSize = True
        Medical_Centre_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Medical_Centre_NameLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Medical_Centre_NameLabel.Location = New System.Drawing.Point(66, 299)
        Medical_Centre_NameLabel.Name = "Medical_Centre_NameLabel"
        Medical_Centre_NameLabel.Size = New System.Drawing.Size(218, 24)
        Medical_Centre_NameLabel.TabIndex = 13
        Medical_Centre_NameLabel.Text = "Medical Centre Name:"
        '
        'Doctor_s_NHS_NoLabel
        '
        Doctor_s_NHS_NoLabel.AutoSize = True
        Doctor_s_NHS_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Doctor_s_NHS_NoLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Doctor_s_NHS_NoLabel.Location = New System.Drawing.Point(66, 336)
        Doctor_s_NHS_NoLabel.Name = "Doctor_s_NHS_NoLabel"
        Doctor_s_NHS_NoLabel.Size = New System.Drawing.Size(174, 24)
        Doctor_s_NHS_NoLabel.TabIndex = 15
        Doctor_s_NHS_NoLabel.Text = "Doctor's NHS No:"
        '
        'PharmacyDataSet
        '
        Me.PharmacyDataSet.DataSetName = "pharmacyDataSet"
        Me.PharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GP_AppointmentBindingSource
        '
        Me.GP_AppointmentBindingSource.DataMember = "GP Appointment"
        Me.GP_AppointmentBindingSource.DataSource = Me.PharmacyDataSet
        '
        'GP_AppointmentTableAdapter
        '
        Me.GP_AppointmentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DoctorTableAdapter = Nothing
        Me.TableAdapterManager.GP_AppointmentTableAdapter = Me.GP_AppointmentTableAdapter
        Me.TableAdapterManager.PatientTableAdapter = Nothing
        Me.TableAdapterManager.PaymentTableAdapter = Nothing
        Me.TableAdapterManager.PharmacyTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = vb_pharmacy_management_system.pharmacyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GP_AppointmentBindingNavigator
        '
        Me.GP_AppointmentBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.GP_AppointmentBindingNavigator.BindingSource = Me.GP_AppointmentBindingSource
        Me.GP_AppointmentBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.GP_AppointmentBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.GP_AppointmentBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.GP_AppointmentBindingNavigatorSaveItem})
        Me.GP_AppointmentBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.GP_AppointmentBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.GP_AppointmentBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.GP_AppointmentBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.GP_AppointmentBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.GP_AppointmentBindingNavigator.Name = "GP_AppointmentBindingNavigator"
        Me.GP_AppointmentBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.GP_AppointmentBindingNavigator.Size = New System.Drawing.Size(1238, 25)
        Me.GP_AppointmentBindingNavigator.TabIndex = 0
        Me.GP_AppointmentBindingNavigator.Text = "BindingNavigator1"
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
        'GP_AppointmentBindingNavigatorSaveItem
        '
        Me.GP_AppointmentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GP_AppointmentBindingNavigatorSaveItem.Image = CType(resources.GetObject("GP_AppointmentBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.GP_AppointmentBindingNavigatorSaveItem.Name = "GP_AppointmentBindingNavigatorSaveItem"
        Me.GP_AppointmentBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.GP_AppointmentBindingNavigatorSaveItem.Text = "Save Data"
        '
        'GP_Appointment_RefTextBox
        '
        Me.GP_Appointment_RefTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GP_AppointmentBindingSource, "GP Appointment Ref", True))
        Me.GP_Appointment_RefTextBox.Location = New System.Drawing.Point(357, 68)
        Me.GP_Appointment_RefTextBox.Name = "GP_Appointment_RefTextBox"
        Me.GP_Appointment_RefTextBox.Size = New System.Drawing.Size(283, 20)
        Me.GP_Appointment_RefTextBox.TabIndex = 2
        '
        'Patient_NHS_NumberTextBox
        '
        Me.Patient_NHS_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GP_AppointmentBindingSource, "Patient NHS Number", True))
        Me.Patient_NHS_NumberTextBox.Location = New System.Drawing.Point(357, 111)
        Me.Patient_NHS_NumberTextBox.Name = "Patient_NHS_NumberTextBox"
        Me.Patient_NHS_NumberTextBox.Size = New System.Drawing.Size(283, 20)
        Me.Patient_NHS_NumberTextBox.TabIndex = 4
        '
        'EMIS_NumberTextBox
        '
        Me.EMIS_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GP_AppointmentBindingSource, "EMIS Number", True))
        Me.EMIS_NumberTextBox.Location = New System.Drawing.Point(357, 147)
        Me.EMIS_NumberTextBox.Name = "EMIS_NumberTextBox"
        Me.EMIS_NumberTextBox.Size = New System.Drawing.Size(283, 20)
        Me.EMIS_NumberTextBox.TabIndex = 6
        '
        'GP_AppointmentTextBox
        '
        Me.GP_AppointmentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GP_AppointmentBindingSource, "GP Appointment", True))
        Me.GP_AppointmentTextBox.Location = New System.Drawing.Point(357, 194)
        Me.GP_AppointmentTextBox.Name = "GP_AppointmentTextBox"
        Me.GP_AppointmentTextBox.Size = New System.Drawing.Size(283, 20)
        Me.GP_AppointmentTextBox.TabIndex = 8
        '
        'Patient_Full_NameTextBox
        '
        Me.Patient_Full_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GP_AppointmentBindingSource, "Patient Full Name", True))
        Me.Patient_Full_NameTextBox.Location = New System.Drawing.Point(357, 230)
        Me.Patient_Full_NameTextBox.Name = "Patient_Full_NameTextBox"
        Me.Patient_Full_NameTextBox.Size = New System.Drawing.Size(283, 20)
        Me.Patient_Full_NameTextBox.TabIndex = 10
        '
        'Patient_IDTextBox
        '
        Me.Patient_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GP_AppointmentBindingSource, "Patient ID", True))
        Me.Patient_IDTextBox.Location = New System.Drawing.Point(357, 266)
        Me.Patient_IDTextBox.Name = "Patient_IDTextBox"
        Me.Patient_IDTextBox.Size = New System.Drawing.Size(283, 20)
        Me.Patient_IDTextBox.TabIndex = 12
        '
        'Medical_Centre_NameTextBox
        '
        Me.Medical_Centre_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GP_AppointmentBindingSource, "Medical Centre Name", True))
        Me.Medical_Centre_NameTextBox.Location = New System.Drawing.Point(357, 299)
        Me.Medical_Centre_NameTextBox.Name = "Medical_Centre_NameTextBox"
        Me.Medical_Centre_NameTextBox.Size = New System.Drawing.Size(283, 20)
        Me.Medical_Centre_NameTextBox.TabIndex = 14
        '
        'Doctor_s_NHS_NoTextBox
        '
        Me.Doctor_s_NHS_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GP_AppointmentBindingSource, "Doctor's NHS No", True))
        Me.Doctor_s_NHS_NoTextBox.Location = New System.Drawing.Point(357, 336)
        Me.Doctor_s_NHS_NoTextBox.Name = "Doctor_s_NHS_NoTextBox"
        Me.Doctor_s_NHS_NoTextBox.Size = New System.Drawing.Size(283, 20)
        Me.Doctor_s_NHS_NoTextBox.TabIndex = 16
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
        Me.Panel1.Location = New System.Drawing.Point(676, 82)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(225, 262)
        Me.Panel1.TabIndex = 35
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(11, 212)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(201, 35)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(11, 171)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(201, 35)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(11, 88)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(201, 35)
        Me.btnNext.TabIndex = 0
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(11, 129)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(201, 35)
        Me.btnPrevious.TabIndex = 0
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(11, 47)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(201, 35)
        Me.btnDelete.TabIndex = 0
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(11, 9)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(201, 32)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add New"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'GP_AppointmentDataGridView
        '
        Me.GP_AppointmentDataGridView.AutoGenerateColumns = False
        Me.GP_AppointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GP_AppointmentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.GP_AppointmentDataGridView.DataSource = Me.GP_AppointmentBindingSource
        Me.GP_AppointmentDataGridView.Location = New System.Drawing.Point(60, 431)
        Me.GP_AppointmentDataGridView.Name = "GP_AppointmentDataGridView"
        Me.GP_AppointmentDataGridView.Size = New System.Drawing.Size(841, 220)
        Me.GP_AppointmentDataGridView.TabIndex = 35
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "GP Appointment Ref"
        Me.DataGridViewTextBoxColumn1.HeaderText = "GP Appointment Ref"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Patient NHS Number"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Patient NHS Number"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "EMIS Number"
        Me.DataGridViewTextBoxColumn3.HeaderText = "EMIS Number"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "GP Appointment"
        Me.DataGridViewTextBoxColumn4.HeaderText = "GP Appointment"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Patient Full Name"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Patient Full Name"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Patient ID"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Patient ID"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Medical Centre Name"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Medical Centre Name"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Doctor's NHS No"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Doctor's NHS No"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(1238, 672)
        Me.Controls.Add(Me.GP_AppointmentDataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(GP_Appointment_RefLabel)
        Me.Controls.Add(Me.GP_Appointment_RefTextBox)
        Me.Controls.Add(Patient_NHS_NumberLabel)
        Me.Controls.Add(Me.Patient_NHS_NumberTextBox)
        Me.Controls.Add(EMIS_NumberLabel)
        Me.Controls.Add(Me.EMIS_NumberTextBox)
        Me.Controls.Add(GP_AppointmentLabel)
        Me.Controls.Add(Me.GP_AppointmentTextBox)
        Me.Controls.Add(Patient_Full_NameLabel)
        Me.Controls.Add(Me.Patient_Full_NameTextBox)
        Me.Controls.Add(Patient_IDLabel)
        Me.Controls.Add(Me.Patient_IDTextBox)
        Me.Controls.Add(Medical_Centre_NameLabel)
        Me.Controls.Add(Me.Medical_Centre_NameTextBox)
        Me.Controls.Add(Doctor_s_NHS_NoLabel)
        Me.Controls.Add(Me.Doctor_s_NHS_NoTextBox)
        Me.Controls.Add(Me.GP_AppointmentBindingNavigator)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GD Appointment"
        CType(Me.PharmacyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GP_AppointmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GP_AppointmentBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GP_AppointmentBindingNavigator.ResumeLayout(False)
        Me.GP_AppointmentBindingNavigator.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.GP_AppointmentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PharmacyDataSet As pharmacyDataSet
    Friend WithEvents GP_AppointmentBindingSource As BindingSource
    Friend WithEvents GP_AppointmentTableAdapter As pharmacyDataSetTableAdapters.GP_AppointmentTableAdapter
    Friend WithEvents TableAdapterManager As pharmacyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GP_AppointmentBindingNavigator As BindingNavigator
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
    Friend WithEvents GP_AppointmentBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents GP_Appointment_RefTextBox As TextBox
    Friend WithEvents Patient_NHS_NumberTextBox As TextBox
    Friend WithEvents EMIS_NumberTextBox As TextBox
    Friend WithEvents GP_AppointmentTextBox As TextBox
    Friend WithEvents Patient_Full_NameTextBox As TextBox
    Friend WithEvents Patient_IDTextBox As TextBox
    Friend WithEvents Medical_Centre_NameTextBox As TextBox
    Friend WithEvents Doctor_s_NHS_NoTextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents GP_AppointmentDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class

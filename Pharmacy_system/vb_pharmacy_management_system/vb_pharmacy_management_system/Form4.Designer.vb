<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim Name_of_TabletsLabel As System.Windows.Forms.Label
        Dim Dose_mg_Label As System.Windows.Forms.Label
        Dim Number_of_TabletsLabel As System.Windows.Forms.Label
        Dim Issued_dateLabel As System.Windows.Forms.Label
        Dim Exp_dateLabel As System.Windows.Forms.Label
        Dim Daily_DoseLabel As System.Windows.Forms.Label
        Dim Possible_Side_EffectsLabel As System.Windows.Forms.Label
        Dim Further_InformationLabel As System.Windows.Forms.Label
        Dim Storage_AdviceLabel As System.Windows.Forms.Label
        Dim AdminstrationLabel As System.Windows.Forms.Label
        Dim Patient_IDLabel As System.Windows.Forms.Label
        Dim Doctors_s_NHS_NoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.PharmacyDataSet = New vb_pharmacy_management_system.pharmacyDataSet()
        Me.PharmacyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PharmacyTableAdapter = New vb_pharmacy_management_system.pharmacyDataSetTableAdapters.PharmacyTableAdapter()
        Me.TableAdapterManager = New vb_pharmacy_management_system.pharmacyDataSetTableAdapters.TableAdapterManager()
        Me.PharmacyBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PharmacyBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Reference_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Name_of_TabletsTextBox = New System.Windows.Forms.TextBox()
        Me.Dose_mg_TextBox = New System.Windows.Forms.TextBox()
        Me.Number_of_TabletsTextBox = New System.Windows.Forms.TextBox()
        Me.Issued_dateTextBox = New System.Windows.Forms.TextBox()
        Me.Exp_dateTextBox = New System.Windows.Forms.TextBox()
        Me.Daily_DoseTextBox = New System.Windows.Forms.TextBox()
        Me.Possible_Side_EffectsTextBox = New System.Windows.Forms.TextBox()
        Me.Further_InformationTextBox = New System.Windows.Forms.TextBox()
        Me.Storage_AdviceTextBox = New System.Windows.Forms.TextBox()
        Me.AdminstrationTextBox = New System.Windows.Forms.TextBox()
        Me.Patient_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Doctors_s_NHS_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.PatientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatientTableAdapter = New vb_pharmacy_management_system.pharmacyDataSetTableAdapters.PatientTableAdapter()
        Me.PharmacyDataGridView = New System.Windows.Forms.DataGridView()
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
        Reference_NumberLabel = New System.Windows.Forms.Label()
        Name_of_TabletsLabel = New System.Windows.Forms.Label()
        Dose_mg_Label = New System.Windows.Forms.Label()
        Number_of_TabletsLabel = New System.Windows.Forms.Label()
        Issued_dateLabel = New System.Windows.Forms.Label()
        Exp_dateLabel = New System.Windows.Forms.Label()
        Daily_DoseLabel = New System.Windows.Forms.Label()
        Possible_Side_EffectsLabel = New System.Windows.Forms.Label()
        Further_InformationLabel = New System.Windows.Forms.Label()
        Storage_AdviceLabel = New System.Windows.Forms.Label()
        AdminstrationLabel = New System.Windows.Forms.Label()
        Patient_IDLabel = New System.Windows.Forms.Label()
        Doctors_s_NHS_NoLabel = New System.Windows.Forms.Label()
        CType(Me.PharmacyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PharmacyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PharmacyBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PharmacyBindingNavigator.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PharmacyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Reference_NumberLabel
        '
        Reference_NumberLabel.AutoSize = True
        Reference_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Reference_NumberLabel.Location = New System.Drawing.Point(73, 54)
        Reference_NumberLabel.Name = "Reference_NumberLabel"
        Reference_NumberLabel.Size = New System.Drawing.Size(194, 24)
        Reference_NumberLabel.TabIndex = 1
        Reference_NumberLabel.Text = "Reference Number:"
        '
        'Name_of_TabletsLabel
        '
        Name_of_TabletsLabel.AutoSize = True
        Name_of_TabletsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Name_of_TabletsLabel.Location = New System.Drawing.Point(73, 80)
        Name_of_TabletsLabel.Name = "Name_of_TabletsLabel"
        Name_of_TabletsLabel.Size = New System.Drawing.Size(168, 24)
        Name_of_TabletsLabel.TabIndex = 3
        Name_of_TabletsLabel.Text = "Name of Tablets:"
        '
        'Dose_mg_Label
        '
        Dose_mg_Label.AutoSize = True
        Dose_mg_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Dose_mg_Label.Location = New System.Drawing.Point(73, 106)
        Dose_mg_Label.Name = "Dose_mg_Label"
        Dose_mg_Label.Size = New System.Drawing.Size(107, 24)
        Dose_mg_Label.TabIndex = 5
        Dose_mg_Label.Text = "Dose(mg):"
        '
        'Number_of_TabletsLabel
        '
        Number_of_TabletsLabel.AutoSize = True
        Number_of_TabletsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Number_of_TabletsLabel.Location = New System.Drawing.Point(73, 132)
        Number_of_TabletsLabel.Name = "Number_of_TabletsLabel"
        Number_of_TabletsLabel.Size = New System.Drawing.Size(188, 24)
        Number_of_TabletsLabel.TabIndex = 7
        Number_of_TabletsLabel.Text = "Number of Tablets:"
        '
        'Issued_dateLabel
        '
        Issued_dateLabel.AutoSize = True
        Issued_dateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Issued_dateLabel.Location = New System.Drawing.Point(73, 158)
        Issued_dateLabel.Name = "Issued_dateLabel"
        Issued_dateLabel.Size = New System.Drawing.Size(123, 24)
        Issued_dateLabel.TabIndex = 9
        Issued_dateLabel.Text = "Issued date:"
        '
        'Exp_dateLabel
        '
        Exp_dateLabel.AutoSize = True
        Exp_dateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Exp_dateLabel.Location = New System.Drawing.Point(73, 184)
        Exp_dateLabel.Name = "Exp_dateLabel"
        Exp_dateLabel.Size = New System.Drawing.Size(99, 24)
        Exp_dateLabel.TabIndex = 11
        Exp_dateLabel.Text = "Exp date:"
        '
        'Daily_DoseLabel
        '
        Daily_DoseLabel.AutoSize = True
        Daily_DoseLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Daily_DoseLabel.Location = New System.Drawing.Point(73, 210)
        Daily_DoseLabel.Name = "Daily_DoseLabel"
        Daily_DoseLabel.Size = New System.Drawing.Size(115, 24)
        Daily_DoseLabel.TabIndex = 13
        Daily_DoseLabel.Text = "Daily Dose:"
        '
        'Possible_Side_EffectsLabel
        '
        Possible_Side_EffectsLabel.AutoSize = True
        Possible_Side_EffectsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Possible_Side_EffectsLabel.Location = New System.Drawing.Point(699, 54)
        Possible_Side_EffectsLabel.Name = "Possible_Side_EffectsLabel"
        Possible_Side_EffectsLabel.Size = New System.Drawing.Size(211, 24)
        Possible_Side_EffectsLabel.TabIndex = 15
        Possible_Side_EffectsLabel.Text = "Possible Side Effects:"
        '
        'Further_InformationLabel
        '
        Further_InformationLabel.AutoSize = True
        Further_InformationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Further_InformationLabel.Location = New System.Drawing.Point(699, 80)
        Further_InformationLabel.Name = "Further_InformationLabel"
        Further_InformationLabel.Size = New System.Drawing.Size(193, 24)
        Further_InformationLabel.TabIndex = 17
        Further_InformationLabel.Text = "Further Information:"
        '
        'Storage_AdviceLabel
        '
        Storage_AdviceLabel.AutoSize = True
        Storage_AdviceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Storage_AdviceLabel.Location = New System.Drawing.Point(699, 106)
        Storage_AdviceLabel.Name = "Storage_AdviceLabel"
        Storage_AdviceLabel.Size = New System.Drawing.Size(158, 24)
        Storage_AdviceLabel.TabIndex = 19
        Storage_AdviceLabel.Text = "Storage Advice:"
        '
        'AdminstrationLabel
        '
        AdminstrationLabel.AutoSize = True
        AdminstrationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AdminstrationLabel.Location = New System.Drawing.Point(699, 132)
        AdminstrationLabel.Name = "AdminstrationLabel"
        AdminstrationLabel.Size = New System.Drawing.Size(143, 24)
        AdminstrationLabel.TabIndex = 21
        AdminstrationLabel.Text = "Adminstration:"
        '
        'Patient_IDLabel
        '
        Patient_IDLabel.AutoSize = True
        Patient_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Patient_IDLabel.Location = New System.Drawing.Point(699, 158)
        Patient_IDLabel.Name = "Patient_IDLabel"
        Patient_IDLabel.Size = New System.Drawing.Size(104, 24)
        Patient_IDLabel.TabIndex = 23
        Patient_IDLabel.Text = "Patient ID:"
        '
        'Doctors_s_NHS_NoLabel
        '
        Doctors_s_NHS_NoLabel.AutoSize = True
        Doctors_s_NHS_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Doctors_s_NHS_NoLabel.Location = New System.Drawing.Point(699, 184)
        Doctors_s_NHS_NoLabel.Name = "Doctors_s_NHS_NoLabel"
        Doctors_s_NHS_NoLabel.Size = New System.Drawing.Size(184, 24)
        Doctors_s_NHS_NoLabel.TabIndex = 25
        Doctors_s_NHS_NoLabel.Text = "Doctors's NHS No:"
        '
        'PharmacyDataSet
        '
        Me.PharmacyDataSet.DataSetName = "pharmacyDataSet"
        Me.PharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PharmacyBindingSource
        '
        Me.PharmacyBindingSource.DataMember = "Pharmacy"
        Me.PharmacyBindingSource.DataSource = Me.PharmacyDataSet
        '
        'PharmacyTableAdapter
        '
        Me.PharmacyTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DoctorTableAdapter = Nothing
        Me.TableAdapterManager.GP_AppointmentTableAdapter = Nothing
        Me.TableAdapterManager.PatientTableAdapter = Nothing
        Me.TableAdapterManager.PaymentTableAdapter = Nothing
        Me.TableAdapterManager.PharmacyTableAdapter = Me.PharmacyTableAdapter
        Me.TableAdapterManager.UpdateOrder = vb_pharmacy_management_system.pharmacyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PharmacyBindingNavigator
        '
        Me.PharmacyBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PharmacyBindingNavigator.BindingSource = Me.PharmacyBindingSource
        Me.PharmacyBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PharmacyBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PharmacyBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PharmacyBindingNavigatorSaveItem})
        Me.PharmacyBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PharmacyBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PharmacyBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PharmacyBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PharmacyBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PharmacyBindingNavigator.Name = "PharmacyBindingNavigator"
        Me.PharmacyBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PharmacyBindingNavigator.Size = New System.Drawing.Size(1362, 25)
        Me.PharmacyBindingNavigator.TabIndex = 0
        Me.PharmacyBindingNavigator.Text = "BindingNavigator1"
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
        'PharmacyBindingNavigatorSaveItem
        '
        Me.PharmacyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PharmacyBindingNavigatorSaveItem.Image = CType(resources.GetObject("PharmacyBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PharmacyBindingNavigatorSaveItem.Name = "PharmacyBindingNavigatorSaveItem"
        Me.PharmacyBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PharmacyBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Reference_NumberTextBox
        '
        Me.Reference_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PharmacyBindingSource, "Reference Number", True))
        Me.Reference_NumberTextBox.Location = New System.Drawing.Point(388, 54)
        Me.Reference_NumberTextBox.Name = "Reference_NumberTextBox"
        Me.Reference_NumberTextBox.Size = New System.Drawing.Size(252, 20)
        Me.Reference_NumberTextBox.TabIndex = 2
        '
        'Name_of_TabletsTextBox
        '
        Me.Name_of_TabletsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PharmacyBindingSource, "Name of Tablets", True))
        Me.Name_of_TabletsTextBox.Location = New System.Drawing.Point(388, 80)
        Me.Name_of_TabletsTextBox.Name = "Name_of_TabletsTextBox"
        Me.Name_of_TabletsTextBox.Size = New System.Drawing.Size(252, 20)
        Me.Name_of_TabletsTextBox.TabIndex = 4
        '
        'Dose_mg_TextBox
        '
        Me.Dose_mg_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PharmacyBindingSource, "Dose(mg)", True))
        Me.Dose_mg_TextBox.Location = New System.Drawing.Point(388, 106)
        Me.Dose_mg_TextBox.Name = "Dose_mg_TextBox"
        Me.Dose_mg_TextBox.Size = New System.Drawing.Size(252, 20)
        Me.Dose_mg_TextBox.TabIndex = 6
        '
        'Number_of_TabletsTextBox
        '
        Me.Number_of_TabletsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PharmacyBindingSource, "Number of Tablets", True))
        Me.Number_of_TabletsTextBox.Location = New System.Drawing.Point(388, 132)
        Me.Number_of_TabletsTextBox.Name = "Number_of_TabletsTextBox"
        Me.Number_of_TabletsTextBox.Size = New System.Drawing.Size(252, 20)
        Me.Number_of_TabletsTextBox.TabIndex = 8
        '
        'Issued_dateTextBox
        '
        Me.Issued_dateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PharmacyBindingSource, "Issued date", True))
        Me.Issued_dateTextBox.Location = New System.Drawing.Point(388, 158)
        Me.Issued_dateTextBox.Name = "Issued_dateTextBox"
        Me.Issued_dateTextBox.Size = New System.Drawing.Size(252, 20)
        Me.Issued_dateTextBox.TabIndex = 10
        '
        'Exp_dateTextBox
        '
        Me.Exp_dateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PharmacyBindingSource, "Exp date", True))
        Me.Exp_dateTextBox.Location = New System.Drawing.Point(388, 184)
        Me.Exp_dateTextBox.Name = "Exp_dateTextBox"
        Me.Exp_dateTextBox.Size = New System.Drawing.Size(252, 20)
        Me.Exp_dateTextBox.TabIndex = 12
        '
        'Daily_DoseTextBox
        '
        Me.Daily_DoseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PharmacyBindingSource, "Daily Dose", True))
        Me.Daily_DoseTextBox.Location = New System.Drawing.Point(388, 214)
        Me.Daily_DoseTextBox.Name = "Daily_DoseTextBox"
        Me.Daily_DoseTextBox.Size = New System.Drawing.Size(252, 20)
        Me.Daily_DoseTextBox.TabIndex = 14
        '
        'Possible_Side_EffectsTextBox
        '
        Me.Possible_Side_EffectsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PharmacyBindingSource, "Possible Side Effects", True))
        Me.Possible_Side_EffectsTextBox.Location = New System.Drawing.Point(954, 54)
        Me.Possible_Side_EffectsTextBox.Name = "Possible_Side_EffectsTextBox"
        Me.Possible_Side_EffectsTextBox.Size = New System.Drawing.Size(252, 20)
        Me.Possible_Side_EffectsTextBox.TabIndex = 16
        '
        'Further_InformationTextBox
        '
        Me.Further_InformationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PharmacyBindingSource, "Further Information", True))
        Me.Further_InformationTextBox.Location = New System.Drawing.Point(954, 184)
        Me.Further_InformationTextBox.Name = "Further_InformationTextBox"
        Me.Further_InformationTextBox.Size = New System.Drawing.Size(252, 20)
        Me.Further_InformationTextBox.TabIndex = 18
        '
        'Storage_AdviceTextBox
        '
        Me.Storage_AdviceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PharmacyBindingSource, "Storage Advice", True))
        Me.Storage_AdviceTextBox.Location = New System.Drawing.Point(954, 80)
        Me.Storage_AdviceTextBox.Name = "Storage_AdviceTextBox"
        Me.Storage_AdviceTextBox.Size = New System.Drawing.Size(252, 20)
        Me.Storage_AdviceTextBox.TabIndex = 20
        '
        'AdminstrationTextBox
        '
        Me.AdminstrationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PharmacyBindingSource, "Adminstration", True))
        Me.AdminstrationTextBox.Location = New System.Drawing.Point(954, 106)
        Me.AdminstrationTextBox.Name = "AdminstrationTextBox"
        Me.AdminstrationTextBox.Size = New System.Drawing.Size(252, 20)
        Me.AdminstrationTextBox.TabIndex = 22
        '
        'Patient_IDTextBox
        '
        Me.Patient_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PharmacyBindingSource, "Patient ID", True))
        Me.Patient_IDTextBox.Location = New System.Drawing.Point(954, 132)
        Me.Patient_IDTextBox.Name = "Patient_IDTextBox"
        Me.Patient_IDTextBox.Size = New System.Drawing.Size(252, 20)
        Me.Patient_IDTextBox.TabIndex = 24
        '
        'Doctors_s_NHS_NoTextBox
        '
        Me.Doctors_s_NHS_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PharmacyBindingSource, "Doctors's NHS No", True))
        Me.Doctors_s_NHS_NoTextBox.Location = New System.Drawing.Point(954, 158)
        Me.Doctors_s_NHS_NoTextBox.Name = "Doctors_s_NHS_NoTextBox"
        Me.Doctors_s_NHS_NoTextBox.Size = New System.Drawing.Size(252, 20)
        Me.Doctors_s_NHS_NoTextBox.TabIndex = 26
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
        Me.Panel1.Location = New System.Drawing.Point(322, 274)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(678, 87)
        Me.Panel1.TabIndex = 35
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(465, 44)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(201, 35)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(237, 44)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(201, 35)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(465, 3)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(201, 35)
        Me.btnNext.TabIndex = 0
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(3, 44)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(201, 35)
        Me.btnPrevious.TabIndex = 0
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(237, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(201, 35)
        Me.btnDelete.TabIndex = 0
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(3, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(201, 32)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add New"
        Me.btnAdd.UseVisualStyleBackColor = True
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
        'PharmacyDataGridView
        '
        Me.PharmacyDataGridView.AutoGenerateColumns = False
        Me.PharmacyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PharmacyDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.PharmacyDataGridView.DataSource = Me.PharmacyBindingSource
        Me.PharmacyDataGridView.Location = New System.Drawing.Point(23, 440)
        Me.PharmacyDataGridView.Name = "PharmacyDataGridView"
        Me.PharmacyDataGridView.Size = New System.Drawing.Size(1316, 220)
        Me.PharmacyDataGridView.TabIndex = 35
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Reference Number"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Reference Number"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name of Tablets"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name of Tablets"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Dose(mg)"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Dose(mg)"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Number of Tablets"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Number of Tablets"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Issued date"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Issued date"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Exp date"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Exp date"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Daily Dose"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Daily Dose"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Possible Side Effects"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Possible Side Effects"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Further Information"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Further Information"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Storage Advice"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Storage Advice"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Adminstration"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Adminstration"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Patient ID"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Patient ID"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Doctors's NHS No"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Doctors's NHS No"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(1362, 689)
        Me.Controls.Add(Me.PharmacyDataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Reference_NumberLabel)
        Me.Controls.Add(Me.Reference_NumberTextBox)
        Me.Controls.Add(Name_of_TabletsLabel)
        Me.Controls.Add(Me.Name_of_TabletsTextBox)
        Me.Controls.Add(Dose_mg_Label)
        Me.Controls.Add(Me.Dose_mg_TextBox)
        Me.Controls.Add(Number_of_TabletsLabel)
        Me.Controls.Add(Me.Number_of_TabletsTextBox)
        Me.Controls.Add(Issued_dateLabel)
        Me.Controls.Add(Me.Issued_dateTextBox)
        Me.Controls.Add(Exp_dateLabel)
        Me.Controls.Add(Me.Exp_dateTextBox)
        Me.Controls.Add(Daily_DoseLabel)
        Me.Controls.Add(Me.Daily_DoseTextBox)
        Me.Controls.Add(Possible_Side_EffectsLabel)
        Me.Controls.Add(Me.Possible_Side_EffectsTextBox)
        Me.Controls.Add(Further_InformationLabel)
        Me.Controls.Add(Me.Further_InformationTextBox)
        Me.Controls.Add(Storage_AdviceLabel)
        Me.Controls.Add(Me.Storage_AdviceTextBox)
        Me.Controls.Add(AdminstrationLabel)
        Me.Controls.Add(Me.AdminstrationTextBox)
        Me.Controls.Add(Patient_IDLabel)
        Me.Controls.Add(Me.Patient_IDTextBox)
        Me.Controls.Add(Doctors_s_NHS_NoLabel)
        Me.Controls.Add(Me.Doctors_s_NHS_NoTextBox)
        Me.Controls.Add(Me.PharmacyBindingNavigator)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pharmacy"
        CType(Me.PharmacyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PharmacyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PharmacyBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PharmacyBindingNavigator.ResumeLayout(False)
        Me.PharmacyBindingNavigator.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PharmacyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PharmacyDataSet As pharmacyDataSet
    Friend WithEvents PharmacyBindingSource As BindingSource
    Friend WithEvents PharmacyTableAdapter As pharmacyDataSetTableAdapters.PharmacyTableAdapter
    Friend WithEvents TableAdapterManager As pharmacyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PharmacyBindingNavigator As BindingNavigator
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
    Friend WithEvents PharmacyBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Reference_NumberTextBox As TextBox
    Friend WithEvents Name_of_TabletsTextBox As TextBox
    Friend WithEvents Dose_mg_TextBox As TextBox
    Friend WithEvents Number_of_TabletsTextBox As TextBox
    Friend WithEvents Issued_dateTextBox As TextBox
    Friend WithEvents Exp_dateTextBox As TextBox
    Friend WithEvents Daily_DoseTextBox As TextBox
    Friend WithEvents Possible_Side_EffectsTextBox As TextBox
    Friend WithEvents Further_InformationTextBox As TextBox
    Friend WithEvents Storage_AdviceTextBox As TextBox
    Friend WithEvents AdminstrationTextBox As TextBox
    Friend WithEvents Patient_IDTextBox As TextBox
    Friend WithEvents Doctors_s_NHS_NoTextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents PatientBindingSource As BindingSource
    Friend WithEvents PatientTableAdapter As pharmacyDataSetTableAdapters.PatientTableAdapter
    Friend WithEvents PharmacyDataGridView As DataGridView
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
End Class

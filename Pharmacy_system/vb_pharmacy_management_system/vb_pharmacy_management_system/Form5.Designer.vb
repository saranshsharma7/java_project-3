<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim Invoice_NoLabel As System.Windows.Forms.Label
        Dim Amount_PaidLabel As System.Windows.Forms.Label
        Dim Method_of_PaymentLabel As System.Windows.Forms.Label
        Dim Visa_CardLabel As System.Windows.Forms.Label
        Dim Debit_CardLabel As System.Windows.Forms.Label
        Dim Master_CardLabel As System.Windows.Forms.Label
        Dim Credit_cardLabel As System.Windows.Forms.Label
        Dim Direct_DebitLabel As System.Windows.Forms.Label
        Dim Visa_Debit_CardLabel As System.Windows.Forms.Label
        Dim Cash_PaidLabel As System.Windows.Forms.Label
        Dim Patient_IDLabel As System.Windows.Forms.Label
        Dim Patient_NHS_NumberLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.PharmacyDataSet = New vb_pharmacy_management_system.pharmacyDataSet()
        Me.PaymentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PaymentTableAdapter = New vb_pharmacy_management_system.pharmacyDataSetTableAdapters.PaymentTableAdapter()
        Me.TableAdapterManager = New vb_pharmacy_management_system.pharmacyDataSetTableAdapters.TableAdapterManager()
        Me.PaymentBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PaymentBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Invoice_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Amount_PaidTextBox = New System.Windows.Forms.TextBox()
        Me.Method_of_PaymentTextBox = New System.Windows.Forms.TextBox()
        Me.Patient_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Per_paid_PlanCheckBox = New System.Windows.Forms.CheckBox()
        Me.Patient_NHS_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.PaymentDataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.CheckBox10 = New System.Windows.Forms.CheckBox()
        Me.CheckBox11 = New System.Windows.Forms.CheckBox()
        Me.CheckBox12 = New System.Windows.Forms.CheckBox()
        Me.CheckBox13 = New System.Windows.Forms.CheckBox()
        Me.CheckBox14 = New System.Windows.Forms.CheckBox()
        Me.CheckBox15 = New System.Windows.Forms.CheckBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
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
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Invoice_NoLabel = New System.Windows.Forms.Label()
        Amount_PaidLabel = New System.Windows.Forms.Label()
        Method_of_PaymentLabel = New System.Windows.Forms.Label()
        Visa_CardLabel = New System.Windows.Forms.Label()
        Debit_CardLabel = New System.Windows.Forms.Label()
        Master_CardLabel = New System.Windows.Forms.Label()
        Credit_cardLabel = New System.Windows.Forms.Label()
        Direct_DebitLabel = New System.Windows.Forms.Label()
        Visa_Debit_CardLabel = New System.Windows.Forms.Label()
        Cash_PaidLabel = New System.Windows.Forms.Label()
        Patient_IDLabel = New System.Windows.Forms.Label()
        Patient_NHS_NumberLabel = New System.Windows.Forms.Label()
        CType(Me.PharmacyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PaymentBindingNavigator.SuspendLayout()
        CType(Me.PaymentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Invoice_NoLabel
        '
        Invoice_NoLabel.AutoSize = True
        Invoice_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Invoice_NoLabel.Location = New System.Drawing.Point(15, 55)
        Invoice_NoLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Invoice_NoLabel.Name = "Invoice_NoLabel"
        Invoice_NoLabel.Size = New System.Drawing.Size(116, 24)
        Invoice_NoLabel.TabIndex = 1
        Invoice_NoLabel.Text = "Invoice No:"
        '
        'Amount_PaidLabel
        '
        Amount_PaidLabel.AutoSize = True
        Amount_PaidLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Amount_PaidLabel.Location = New System.Drawing.Point(15, 103)
        Amount_PaidLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Amount_PaidLabel.Name = "Amount_PaidLabel"
        Amount_PaidLabel.Size = New System.Drawing.Size(135, 24)
        Amount_PaidLabel.TabIndex = 3
        Amount_PaidLabel.Text = "Amount Paid:"
        '
        'Method_of_PaymentLabel
        '
        Method_of_PaymentLabel.AutoSize = True
        Method_of_PaymentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Method_of_PaymentLabel.Location = New System.Drawing.Point(15, 151)
        Method_of_PaymentLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Method_of_PaymentLabel.Name = "Method_of_PaymentLabel"
        Method_of_PaymentLabel.Size = New System.Drawing.Size(195, 24)
        Method_of_PaymentLabel.TabIndex = 5
        Method_of_PaymentLabel.Text = "Method of Payment:"
        '
        'Visa_CardLabel
        '
        Visa_CardLabel.AutoSize = True
        Visa_CardLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Visa_CardLabel.Location = New System.Drawing.Point(15, 199)
        Visa_CardLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Visa_CardLabel.Name = "Visa_CardLabel"
        Visa_CardLabel.Size = New System.Drawing.Size(106, 24)
        Visa_CardLabel.TabIndex = 7
        Visa_CardLabel.Text = "Visa Card:"
        '
        'Debit_CardLabel
        '
        Debit_CardLabel.AutoSize = True
        Debit_CardLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Debit_CardLabel.Location = New System.Drawing.Point(20, 297)
        Debit_CardLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Debit_CardLabel.Name = "Debit_CardLabel"
        Debit_CardLabel.Size = New System.Drawing.Size(114, 24)
        Debit_CardLabel.TabIndex = 9
        Debit_CardLabel.Text = "Debit Card:"
        '
        'Master_CardLabel
        '
        Master_CardLabel.AutoSize = True
        Master_CardLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Master_CardLabel.Location = New System.Drawing.Point(20, 345)
        Master_CardLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Master_CardLabel.Name = "Master_CardLabel"
        Master_CardLabel.Size = New System.Drawing.Size(128, 24)
        Master_CardLabel.TabIndex = 11
        Master_CardLabel.Text = "Master Card:"
        '
        'Credit_cardLabel
        '
        Credit_cardLabel.AutoSize = True
        Credit_cardLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Credit_cardLabel.Location = New System.Drawing.Point(20, 393)
        Credit_cardLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Credit_cardLabel.Name = "Credit_cardLabel"
        Credit_cardLabel.Size = New System.Drawing.Size(118, 24)
        Credit_cardLabel.TabIndex = 13
        Credit_cardLabel.Text = "Credit card:"
        '
        'Direct_DebitLabel
        '
        Direct_DebitLabel.AutoSize = True
        Direct_DebitLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Direct_DebitLabel.Location = New System.Drawing.Point(20, 441)
        Direct_DebitLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Direct_DebitLabel.Name = "Direct_DebitLabel"
        Direct_DebitLabel.Size = New System.Drawing.Size(124, 24)
        Direct_DebitLabel.TabIndex = 15
        Direct_DebitLabel.Text = "Direct Debit:"
        '
        'Visa_Debit_CardLabel
        '
        Visa_Debit_CardLabel.AutoSize = True
        Visa_Debit_CardLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Visa_Debit_CardLabel.Location = New System.Drawing.Point(570, 50)
        Visa_Debit_CardLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Visa_Debit_CardLabel.Name = "Visa_Debit_CardLabel"
        Visa_Debit_CardLabel.Size = New System.Drawing.Size(160, 24)
        Visa_Debit_CardLabel.TabIndex = 17
        Visa_Debit_CardLabel.Text = "Visa Debit Card:"
        '
        'Cash_PaidLabel
        '
        Cash_PaidLabel.AutoSize = True
        Cash_PaidLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cash_PaidLabel.Location = New System.Drawing.Point(570, 98)
        Cash_PaidLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Cash_PaidLabel.Name = "Cash_PaidLabel"
        Cash_PaidLabel.Size = New System.Drawing.Size(110, 24)
        Cash_PaidLabel.TabIndex = 19
        Cash_PaidLabel.Text = "Cash Paid:"
        '
        'Patient_IDLabel
        '
        Patient_IDLabel.AutoSize = True
        Patient_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Patient_IDLabel.Location = New System.Drawing.Point(570, 146)
        Patient_IDLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Patient_IDLabel.Name = "Patient_IDLabel"
        Patient_IDLabel.Size = New System.Drawing.Size(104, 24)
        Patient_IDLabel.TabIndex = 21
        Patient_IDLabel.Text = "Patient ID:"
        '
        'Patient_NHS_NumberLabel
        '
        Patient_NHS_NumberLabel.AutoSize = True
        Patient_NHS_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Patient_NHS_NumberLabel.Location = New System.Drawing.Point(570, 247)
        Patient_NHS_NumberLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Patient_NHS_NumberLabel.Name = "Patient_NHS_NumberLabel"
        Patient_NHS_NumberLabel.Size = New System.Drawing.Size(209, 24)
        Patient_NHS_NumberLabel.TabIndex = 25
        Patient_NHS_NumberLabel.Text = "Patient NHS Number:"
        '
        'PharmacyDataSet
        '
        Me.PharmacyDataSet.DataSetName = "pharmacyDataSet"
        Me.PharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PaymentBindingSource
        '
        Me.PaymentBindingSource.DataMember = "Payment"
        Me.PaymentBindingSource.DataSource = Me.PharmacyDataSet
        '
        'PaymentTableAdapter
        '
        Me.PaymentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DoctorTableAdapter = Nothing
        Me.TableAdapterManager.GP_AppointmentTableAdapter = Nothing
        Me.TableAdapterManager.PatientTableAdapter = Nothing
        Me.TableAdapterManager.PaymentTableAdapter = Me.PaymentTableAdapter
        Me.TableAdapterManager.PharmacyTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = vb_pharmacy_management_system.pharmacyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PaymentBindingNavigator
        '
        Me.PaymentBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PaymentBindingNavigator.BindingSource = Me.PaymentBindingSource
        Me.PaymentBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PaymentBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PaymentBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PaymentBindingNavigatorSaveItem})
        Me.PaymentBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PaymentBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PaymentBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PaymentBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PaymentBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PaymentBindingNavigator.Name = "PaymentBindingNavigator"
        Me.PaymentBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.PaymentBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PaymentBindingNavigator.Size = New System.Drawing.Size(1362, 25)
        Me.PaymentBindingNavigator.TabIndex = 0
        Me.PaymentBindingNavigator.Text = "BindingNavigator1"
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
        'PaymentBindingNavigatorSaveItem
        '
        Me.PaymentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PaymentBindingNavigatorSaveItem.Image = CType(resources.GetObject("PaymentBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PaymentBindingNavigatorSaveItem.Name = "PaymentBindingNavigatorSaveItem"
        Me.PaymentBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PaymentBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Invoice_NoTextBox
        '
        Me.Invoice_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentBindingSource, "Invoice No", True))
        Me.Invoice_NoTextBox.Location = New System.Drawing.Point(255, 50)
        Me.Invoice_NoTextBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Invoice_NoTextBox.Name = "Invoice_NoTextBox"
        Me.Invoice_NoTextBox.Size = New System.Drawing.Size(204, 29)
        Me.Invoice_NoTextBox.TabIndex = 2
        '
        'Amount_PaidTextBox
        '
        Me.Amount_PaidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentBindingSource, "Amount Paid", True))
        Me.Amount_PaidTextBox.Location = New System.Drawing.Point(255, 98)
        Me.Amount_PaidTextBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Amount_PaidTextBox.Name = "Amount_PaidTextBox"
        Me.Amount_PaidTextBox.Size = New System.Drawing.Size(204, 29)
        Me.Amount_PaidTextBox.TabIndex = 4
        '
        'Method_of_PaymentTextBox
        '
        Me.Method_of_PaymentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentBindingSource, "Method of Payment", True))
        Me.Method_of_PaymentTextBox.Location = New System.Drawing.Point(255, 146)
        Me.Method_of_PaymentTextBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Method_of_PaymentTextBox.Name = "Method_of_PaymentTextBox"
        Me.Method_of_PaymentTextBox.Size = New System.Drawing.Size(204, 29)
        Me.Method_of_PaymentTextBox.TabIndex = 6
        '
        'Patient_IDTextBox
        '
        Me.Patient_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentBindingSource, "Patient ID", True))
        Me.Patient_IDTextBox.Location = New System.Drawing.Point(801, 140)
        Me.Patient_IDTextBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Patient_IDTextBox.Name = "Patient_IDTextBox"
        Me.Patient_IDTextBox.Size = New System.Drawing.Size(204, 29)
        Me.Patient_IDTextBox.TabIndex = 22
        '
        'Per_paid_PlanCheckBox
        '
        Me.Per_paid_PlanCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PaymentBindingSource, "Per paid Plan", True))
        Me.Per_paid_PlanCheckBox.Location = New System.Drawing.Point(880, 180)
        Me.Per_paid_PlanCheckBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Per_paid_PlanCheckBox.Name = "Per_paid_PlanCheckBox"
        Me.Per_paid_PlanCheckBox.Size = New System.Drawing.Size(208, 44)
        Me.Per_paid_PlanCheckBox.TabIndex = 24
        Me.Per_paid_PlanCheckBox.Text = "Yes"
        Me.Per_paid_PlanCheckBox.UseVisualStyleBackColor = True
        '
        'Patient_NHS_NumberTextBox
        '
        Me.Patient_NHS_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentBindingSource, "Patient NHS Number", True))
        Me.Patient_NHS_NumberTextBox.Location = New System.Drawing.Point(801, 244)
        Me.Patient_NHS_NumberTextBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Patient_NHS_NumberTextBox.Name = "Patient_NHS_NumberTextBox"
        Me.Patient_NHS_NumberTextBox.Size = New System.Drawing.Size(204, 29)
        Me.Patient_NHS_NumberTextBox.TabIndex = 26
        '
        'PaymentDataGridView
        '
        Me.PaymentDataGridView.AutoGenerateColumns = False
        Me.PaymentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PaymentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn12})
        Me.PaymentDataGridView.DataSource = Me.PaymentBindingSource
        Me.PaymentDataGridView.Location = New System.Drawing.Point(24, 492)
        Me.PaymentDataGridView.Name = "PaymentDataGridView"
        Me.PaymentDataGridView.Size = New System.Drawing.Size(1315, 220)
        Me.PaymentDataGridView.TabIndex = 27
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
        Me.Panel1.Location = New System.Drawing.Point(1084, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(226, 421)
        Me.Panel1.TabIndex = 35
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(11, 336)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(201, 35)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(11, 274)
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
        Me.btnPrevious.Location = New System.Drawing.Point(11, 212)
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
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(333, 204)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(64, 28)
        Me.CheckBox1.TabIndex = 36
        Me.CheckBox1.Text = "Yes"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(333, 287)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(64, 28)
        Me.CheckBox2.TabIndex = 36
        Me.CheckBox2.Text = "Yes"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(403, 340)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(56, 28)
        Me.CheckBox3.TabIndex = 36
        Me.CheckBox3.Text = "No"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(333, 389)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(64, 28)
        Me.CheckBox4.TabIndex = 36
        Me.CheckBox4.Text = "Yes"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(333, 440)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(64, 28)
        Me.CheckBox5.TabIndex = 36
        Me.CheckBox5.Text = "Yes"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(879, 103)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(64, 28)
        Me.CheckBox6.TabIndex = 36
        Me.CheckBox6.Text = "Yes"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Location = New System.Drawing.Point(879, 49)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(64, 28)
        Me.CheckBox7.TabIndex = 36
        Me.CheckBox7.Text = "Yes"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Location = New System.Drawing.Point(403, 204)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(56, 28)
        Me.CheckBox8.TabIndex = 36
        Me.CheckBox8.Text = "No"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.Location = New System.Drawing.Point(403, 287)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(56, 28)
        Me.CheckBox9.TabIndex = 36
        Me.CheckBox9.Text = "No"
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'CheckBox10
        '
        Me.CheckBox10.AutoSize = True
        Me.CheckBox10.Location = New System.Drawing.Point(333, 339)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(64, 28)
        Me.CheckBox10.TabIndex = 36
        Me.CheckBox10.Text = "Yes"
        Me.CheckBox10.UseVisualStyleBackColor = True
        '
        'CheckBox11
        '
        Me.CheckBox11.AutoSize = True
        Me.CheckBox11.Location = New System.Drawing.Point(403, 389)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(56, 28)
        Me.CheckBox11.TabIndex = 36
        Me.CheckBox11.Text = "No"
        Me.CheckBox11.UseVisualStyleBackColor = True
        '
        'CheckBox12
        '
        Me.CheckBox12.AutoSize = True
        Me.CheckBox12.Location = New System.Drawing.Point(403, 440)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(56, 28)
        Me.CheckBox12.TabIndex = 36
        Me.CheckBox12.Text = "No"
        Me.CheckBox12.UseVisualStyleBackColor = True
        '
        'CheckBox13
        '
        Me.CheckBox13.AutoSize = True
        Me.CheckBox13.Location = New System.Drawing.Point(949, 46)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.Size = New System.Drawing.Size(56, 28)
        Me.CheckBox13.TabIndex = 36
        Me.CheckBox13.Text = "No"
        Me.CheckBox13.UseVisualStyleBackColor = True
        '
        'CheckBox14
        '
        Me.CheckBox14.AutoSize = True
        Me.CheckBox14.Location = New System.Drawing.Point(949, 99)
        Me.CheckBox14.Name = "CheckBox14"
        Me.CheckBox14.Size = New System.Drawing.Size(56, 28)
        Me.CheckBox14.TabIndex = 36
        Me.CheckBox14.Text = "No"
        Me.CheckBox14.UseVisualStyleBackColor = True
        '
        'CheckBox15
        '
        Me.CheckBox15.Location = New System.Drawing.Point(949, 180)
        Me.CheckBox15.Margin = New System.Windows.Forms.Padding(6)
        Me.CheckBox15.Name = "CheckBox15"
        Me.CheckBox15.Size = New System.Drawing.Size(208, 44)
        Me.CheckBox15.TabIndex = 24
        Me.CheckBox15.Text = "No"
        Me.CheckBox15.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Aqua
        Me.TextBox2.Location = New System.Drawing.Point(574, 194)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(190, 29)
        Me.TextBox2.TabIndex = 38
        Me.TextBox2.Text = "Paid Per Plan"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Invoice No"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Invoice No"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Amount Paid"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Amount Paid"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Method of Payment"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Method of Payment"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Visa Card"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Visa Card"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Debit Card"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Debit Card"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Master Card"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Master Card"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Credit card"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Credit card"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Direct Debit"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Direct Debit"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Visa Debit Card"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Visa Debit Card"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Cash Paid"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Cash Paid"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Patient ID"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Patient ID"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Paid Per Plan"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Per paid Plan"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Patient NHS Number"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Patient NHS Number"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(255, 287)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(62, 29)
        Me.TextBox1.TabIndex = 39
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(255, 204)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(62, 29)
        Me.TextBox3.TabIndex = 39
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(255, 339)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(62, 29)
        Me.TextBox4.TabIndex = 39
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(255, 384)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(62, 29)
        Me.TextBox5.TabIndex = 39
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(255, 436)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(62, 29)
        Me.TextBox6.TabIndex = 39
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(801, 95)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(61, 29)
        Me.TextBox7.TabIndex = 40
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(801, 48)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(61, 29)
        Me.TextBox8.TabIndex = 40
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(801, 189)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(61, 29)
        Me.TextBox9.TabIndex = 40
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.CheckBox13)
        Me.Controls.Add(Me.CheckBox7)
        Me.Controls.Add(Me.CheckBox14)
        Me.Controls.Add(Me.CheckBox6)
        Me.Controls.Add(Me.CheckBox12)
        Me.Controls.Add(Me.CheckBox5)
        Me.Controls.Add(Me.CheckBox11)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox10)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox9)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox8)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PaymentDataGridView)
        Me.Controls.Add(Invoice_NoLabel)
        Me.Controls.Add(Me.Invoice_NoTextBox)
        Me.Controls.Add(Amount_PaidLabel)
        Me.Controls.Add(Me.Amount_PaidTextBox)
        Me.Controls.Add(Method_of_PaymentLabel)
        Me.Controls.Add(Me.Method_of_PaymentTextBox)
        Me.Controls.Add(Visa_CardLabel)
        Me.Controls.Add(Debit_CardLabel)
        Me.Controls.Add(Master_CardLabel)
        Me.Controls.Add(Credit_cardLabel)
        Me.Controls.Add(Direct_DebitLabel)
        Me.Controls.Add(Visa_Debit_CardLabel)
        Me.Controls.Add(Cash_PaidLabel)
        Me.Controls.Add(Patient_IDLabel)
        Me.Controls.Add(Me.Patient_IDTextBox)
        Me.Controls.Add(Me.CheckBox15)
        Me.Controls.Add(Me.Per_paid_PlanCheckBox)
        Me.Controls.Add(Patient_NHS_NumberLabel)
        Me.Controls.Add(Me.Patient_NHS_NumberTextBox)
        Me.Controls.Add(Me.PaymentBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "No"
        CType(Me.PharmacyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PaymentBindingNavigator.ResumeLayout(False)
        Me.PaymentBindingNavigator.PerformLayout()
        CType(Me.PaymentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PharmacyDataSet As pharmacyDataSet
    Friend WithEvents PaymentBindingSource As BindingSource
    Friend WithEvents PaymentTableAdapter As pharmacyDataSetTableAdapters.PaymentTableAdapter
    Friend WithEvents TableAdapterManager As pharmacyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PaymentBindingNavigator As BindingNavigator
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
    Friend WithEvents PaymentBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Invoice_NoTextBox As TextBox
    Friend WithEvents Amount_PaidTextBox As TextBox
    Friend WithEvents Method_of_PaymentTextBox As TextBox
    Friend WithEvents Patient_IDTextBox As TextBox
    Friend WithEvents Per_paid_PlanCheckBox As CheckBox
    Friend WithEvents Patient_NHS_NumberTextBox As TextBox
    Friend WithEvents PaymentDataGridView As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents CheckBox11 As CheckBox
    Friend WithEvents CheckBox12 As CheckBox
    Friend WithEvents CheckBox13 As CheckBox
    Friend WithEvents CheckBox14 As CheckBox
    Friend WithEvents CheckBox15 As CheckBox
    Friend WithEvents TextBox2 As TextBox
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
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
End Class

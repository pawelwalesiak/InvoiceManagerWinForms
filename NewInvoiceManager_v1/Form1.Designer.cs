
namespace NewInvoiceManager_v1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label customer_IDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label cityCodeLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label nipLabel;
            System.Windows.Forms.Label regonLabel;
            System.Windows.Forms.Label krsLabel;
            System.Windows.Forms.Label pkdLabel;
            System.Windows.Forms.Label nameLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceSimpleMenagerDBDataSet = new NewInvoiceManager_v1.InvoiceSimpleMenagerDBDataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new NewInvoiceManager_v1.InvoiceSimpleMenagerDBDataSetTableAdapters.CustomerTableAdapter();
            this.tableAdapterManager = new NewInvoiceManager_v1.InvoiceSimpleMenagerDBDataSetTableAdapters.TableAdapterManager();
            this.customerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.customerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_IDSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.addressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.cityTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.cityCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.phoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nipTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.regonTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.krsTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.pkdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.DeleteCompanyButton = new System.Windows.Forms.Button();
            this.UpdateCompanyButton = new System.Windows.Forms.Button();
            this.invoiceSimpleMenagerDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            customer_IDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            cityCodeLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            nipLabel = new System.Windows.Forms.Label();
            regonLabel = new System.Windows.Forms.Label();
            krsLabel = new System.Windows.Forms.Label();
            pkdLabel = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceSimpleMenagerDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingNavigator)).BeginInit();
            this.customerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_IDSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nipTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regonTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.krsTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceSimpleMenagerDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // customer_IDLabel
            // 
            customer_IDLabel.AutoSize = true;
            customer_IDLabel.Location = new System.Drawing.Point(57, 49);
            customer_IDLabel.Name = "customer_IDLabel";
            customer_IDLabel.Size = new System.Drawing.Size(68, 13);
            customer_IDLabel.TabIndex = 3;
            customer_IDLabel.Text = "Customer ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(57, 75);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(57, 101);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 7;
            addressLabel.Text = "Address:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(57, 127);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 9;
            cityLabel.Text = "City:";
            // 
            // cityCodeLabel
            // 
            cityCodeLabel.AutoSize = true;
            cityCodeLabel.Location = new System.Drawing.Point(57, 153);
            cityCodeLabel.Name = "cityCodeLabel";
            cityCodeLabel.Size = new System.Drawing.Size(55, 13);
            cityCodeLabel.TabIndex = 11;
            cityCodeLabel.Text = "City Code:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(57, 179);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 13;
            phoneLabel.Text = "Phone:";
            // 
            // nipLabel
            // 
            nipLabel.AutoSize = true;
            nipLabel.Location = new System.Drawing.Point(57, 205);
            nipLabel.Name = "nipLabel";
            nipLabel.Size = new System.Drawing.Size(26, 13);
            nipLabel.TabIndex = 15;
            nipLabel.Text = "Nip:";
            // 
            // regonLabel
            // 
            regonLabel.AutoSize = true;
            regonLabel.Location = new System.Drawing.Point(57, 231);
            regonLabel.Name = "regonLabel";
            regonLabel.Size = new System.Drawing.Size(42, 13);
            regonLabel.TabIndex = 17;
            regonLabel.Text = "Regon:";
            // 
            // krsLabel
            // 
            krsLabel.AutoSize = true;
            krsLabel.Location = new System.Drawing.Point(57, 257);
            krsLabel.Name = "krsLabel";
            krsLabel.Size = new System.Drawing.Size(25, 13);
            krsLabel.TabIndex = 19;
            krsLabel.Text = "Krs:";
            // 
            // pkdLabel
            // 
            pkdLabel.AutoSize = true;
            pkdLabel.Location = new System.Drawing.Point(57, 283);
            pkdLabel.Name = "pkdLabel";
            pkdLabel.Size = new System.Drawing.Size(29, 13);
            pkdLabel.TabIndex = 21;
            pkdLabel.Text = "Pkd:";
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(356, 49);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(38, 13);
            nameLabel1.TabIndex = 24;
            nameLabel1.Text = "Name:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.invoiceToolStripMenuItem,
            this.productToolStripMenuItem,
            this.lineItemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(878, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // invoiceToolStripMenuItem
            // 
            this.invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            this.invoiceToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.invoiceToolStripMenuItem.Text = "Invoice";
            this.invoiceToolStripMenuItem.Click += new System.EventHandler(this.invoiceToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.productToolStripMenuItem.Text = "Product";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // lineItemToolStripMenuItem
            // 
            this.lineItemToolStripMenuItem.Checked = true;
            this.lineItemToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lineItemToolStripMenuItem.Name = "lineItemToolStripMenuItem";
            this.lineItemToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.lineItemToolStripMenuItem.Text = "LineItem";
            this.lineItemToolStripMenuItem.Click += new System.EventHandler(this.lineItemToolStripMenuItem_Click);
            // 
            // invoiceSimpleMenagerDBDataSet
            // 
            this.invoiceSimpleMenagerDBDataSet.DataSetName = "InvoiceSimpleMenagerDBDataSet";
            this.invoiceSimpleMenagerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.invoiceSimpleMenagerDBDataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.InvoiceTableAdapter = null;
            this.tableAdapterManager.LineItemTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NewInvoiceManager_v1.InvoiceSimpleMenagerDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customerBindingNavigator
            // 
            this.customerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.customerBindingNavigator.BindingSource = this.customerBindingSource;
            this.customerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.customerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.customerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.customerBindingNavigatorSaveItem});
            this.customerBindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.customerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.customerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.customerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.customerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.customerBindingNavigator.Name = "customerBindingNavigator";
            this.customerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.customerBindingNavigator.Size = new System.Drawing.Size(878, 25);
            this.customerBindingNavigator.TabIndex = 1;
            this.customerBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // customerBindingNavigatorSaveItem
            // 
            this.customerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customerBindingNavigatorSaveItem.Image")));
            this.customerBindingNavigatorSaveItem.Name = "customerBindingNavigatorSaveItem";
            this.customerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.customerBindingNavigatorSaveItem.Text = "Save Data";
            this.customerBindingNavigatorSaveItem.Click += new System.EventHandler(this.customerBindingNavigatorSaveItem_Click);
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AutoGenerateColumns = false;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.customerDataGridView.DataSource = this.customerBindingSource;
            this.customerDataGridView.Location = new System.Drawing.Point(12, 341);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.Size = new System.Drawing.Size(846, 220);
            this.customerDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Customer_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Customer_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn3.HeaderText = "Address";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn4.HeaderText = "City";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CityCode";
            this.dataGridViewTextBoxColumn5.HeaderText = "CityCode";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn6.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Nip";
            this.dataGridViewTextBoxColumn7.HeaderText = "Nip";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Regon";
            this.dataGridViewTextBoxColumn8.HeaderText = "Regon";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Krs";
            this.dataGridViewTextBoxColumn9.HeaderText = "Krs";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Pkd";
            this.dataGridViewTextBoxColumn10.HeaderText = "Pkd";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // customer_IDSpinEdit
            // 
            this.customer_IDSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerBindingSource, "Customer_ID", true));
            this.customer_IDSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.customer_IDSpinEdit.Location = new System.Drawing.Point(131, 46);
            this.customer_IDSpinEdit.Name = "customer_IDSpinEdit";
            this.customer_IDSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.customer_IDSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.customer_IDSpinEdit.TabIndex = 4;
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerBindingSource, "Name", true));
            this.nameTextEdit.Location = new System.Drawing.Point(131, 72);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(100, 20);
            this.nameTextEdit.TabIndex = 6;
            // 
            // addressTextEdit
            // 
            this.addressTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerBindingSource, "Address", true));
            this.addressTextEdit.Location = new System.Drawing.Point(131, 98);
            this.addressTextEdit.Name = "addressTextEdit";
            this.addressTextEdit.Size = new System.Drawing.Size(100, 20);
            this.addressTextEdit.TabIndex = 8;
            // 
            // cityTextEdit
            // 
            this.cityTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerBindingSource, "City", true));
            this.cityTextEdit.Location = new System.Drawing.Point(131, 124);
            this.cityTextEdit.Name = "cityTextEdit";
            this.cityTextEdit.Size = new System.Drawing.Size(100, 20);
            this.cityTextEdit.TabIndex = 10;
            // 
            // cityCodeTextEdit
            // 
            this.cityCodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerBindingSource, "CityCode", true));
            this.cityCodeTextEdit.Location = new System.Drawing.Point(131, 150);
            this.cityCodeTextEdit.Name = "cityCodeTextEdit";
            this.cityCodeTextEdit.Size = new System.Drawing.Size(100, 20);
            this.cityCodeTextEdit.TabIndex = 12;
            // 
            // phoneTextEdit
            // 
            this.phoneTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerBindingSource, "Phone", true));
            this.phoneTextEdit.Location = new System.Drawing.Point(131, 176);
            this.phoneTextEdit.Name = "phoneTextEdit";
            this.phoneTextEdit.Size = new System.Drawing.Size(100, 20);
            this.phoneTextEdit.TabIndex = 14;
            // 
            // nipTextEdit
            // 
            this.nipTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerBindingSource, "Nip", true));
            this.nipTextEdit.Location = new System.Drawing.Point(131, 202);
            this.nipTextEdit.Name = "nipTextEdit";
            this.nipTextEdit.Size = new System.Drawing.Size(100, 20);
            this.nipTextEdit.TabIndex = 16;
            // 
            // regonTextEdit
            // 
            this.regonTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerBindingSource, "Regon", true));
            this.regonTextEdit.Location = new System.Drawing.Point(131, 228);
            this.regonTextEdit.Name = "regonTextEdit";
            this.regonTextEdit.Size = new System.Drawing.Size(100, 20);
            this.regonTextEdit.TabIndex = 18;
            // 
            // krsTextEdit
            // 
            this.krsTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerBindingSource, "Krs", true));
            this.krsTextEdit.Location = new System.Drawing.Point(131, 254);
            this.krsTextEdit.Name = "krsTextEdit";
            this.krsTextEdit.Size = new System.Drawing.Size(100, 20);
            this.krsTextEdit.TabIndex = 20;
            // 
            // pkdTextEdit
            // 
            this.pkdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerBindingSource, "Pkd", true));
            this.pkdTextEdit.Location = new System.Drawing.Point(131, 280);
            this.pkdTextEdit.Name = "pkdTextEdit";
            this.pkdTextEdit.Size = new System.Drawing.Size(100, 20);
            this.pkdTextEdit.TabIndex = 22;
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Location = new System.Drawing.Point(131, 307);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(100, 23);
            this.AddCustomerButton.TabIndex = 23;
            this.AddCustomerButton.Text = "AddCustomerButton";
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // nameComboBox
            // 
            this.nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Name", true));
            this.nameComboBox.DataSource = this.customerBindingSource1;
            this.nameComboBox.DisplayMember = "Name";
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(400, 46);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(121, 21);
            this.nameComboBox.TabIndex = 25;
            this.nameComboBox.ValueMember = "Name";
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "Customer";
            this.customerBindingSource1.DataSource = this.invoiceSimpleMenagerDBDataSet;
            // 
            // DeleteCompanyButton
            // 
            this.DeleteCompanyButton.Location = new System.Drawing.Point(400, 75);
            this.DeleteCompanyButton.Name = "DeleteCompanyButton";
            this.DeleteCompanyButton.Size = new System.Drawing.Size(121, 23);
            this.DeleteCompanyButton.TabIndex = 26;
            this.DeleteCompanyButton.Text = "DeleteCompanyButton";
            this.DeleteCompanyButton.UseVisualStyleBackColor = true;
            this.DeleteCompanyButton.Click += new System.EventHandler(this.DeleteCompanyButton_Click);
            // 
            // UpdateCompanyButton
            // 
            this.UpdateCompanyButton.Location = new System.Drawing.Point(237, 307);
            this.UpdateCompanyButton.Name = "UpdateCompanyButton";
            this.UpdateCompanyButton.Size = new System.Drawing.Size(121, 23);
            this.UpdateCompanyButton.TabIndex = 29;
            this.UpdateCompanyButton.Text = "UpdateCompanyButton";
            this.UpdateCompanyButton.UseVisualStyleBackColor = true;
            this.UpdateCompanyButton.Click += new System.EventHandler(this.UpdateCompanyButton_Click);
            // 
            // invoiceSimpleMenagerDBDataSetBindingSource
            // 
            this.invoiceSimpleMenagerDBDataSetBindingSource.DataSource = this.invoiceSimpleMenagerDBDataSet;
            this.invoiceSimpleMenagerDBDataSetBindingSource.Position = 0;
            // 
            // customerBindingSource2
            // 
            this.customerBindingSource2.DataMember = "Customer";
            this.customerBindingSource2.DataSource = this.invoiceSimpleMenagerDBDataSetBindingSource;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 581);
            this.Controls.Add(this.UpdateCompanyButton);
            this.Controls.Add(this.DeleteCompanyButton);
            this.Controls.Add(nameLabel1);
            this.Controls.Add(this.nameComboBox);
            this.Controls.Add(this.AddCustomerButton);
            this.Controls.Add(customer_IDLabel);
            this.Controls.Add(this.customer_IDSpinEdit);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextEdit);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextEdit);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextEdit);
            this.Controls.Add(cityCodeLabel);
            this.Controls.Add(this.cityCodeTextEdit);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextEdit);
            this.Controls.Add(nipLabel);
            this.Controls.Add(this.nipTextEdit);
            this.Controls.Add(regonLabel);
            this.Controls.Add(this.regonTextEdit);
            this.Controls.Add(krsLabel);
            this.Controls.Add(this.krsTextEdit);
            this.Controls.Add(pkdLabel);
            this.Controls.Add(this.pkdTextEdit);
            this.Controls.Add(this.customerDataGridView);
            this.Controls.Add(this.customerBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceSimpleMenagerDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingNavigator)).EndInit();
            this.customerBindingNavigator.ResumeLayout(false);
            this.customerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_IDSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nipTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regonTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.krsTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceSimpleMenagerDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineItemToolStripMenuItem;
        private InvoiceSimpleMenagerDBDataSet invoiceSimpleMenagerDBDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private InvoiceSimpleMenagerDBDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private InvoiceSimpleMenagerDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator customerBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton customerBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DevExpress.XtraEditors.SpinEdit customer_IDSpinEdit;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.TextEdit addressTextEdit;
        private DevExpress.XtraEditors.TextEdit cityTextEdit;
        private DevExpress.XtraEditors.TextEdit cityCodeTextEdit;
        private DevExpress.XtraEditors.TextEdit phoneTextEdit;
        private DevExpress.XtraEditors.TextEdit nipTextEdit;
        private DevExpress.XtraEditors.TextEdit regonTextEdit;
        private DevExpress.XtraEditors.TextEdit krsTextEdit;
        private DevExpress.XtraEditors.TextEdit pkdTextEdit;
        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.ComboBox nameComboBox;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private System.Windows.Forms.Button DeleteCompanyButton;
        private System.Windows.Forms.BindingSource customerBindingSource2;
        private System.Windows.Forms.BindingSource invoiceSimpleMenagerDBDataSetBindingSource;
        private System.Windows.Forms.Button UpdateCompanyButton;
    }
}


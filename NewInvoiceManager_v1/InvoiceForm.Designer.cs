
namespace NewInvoiceManager_v1
{
    partial class InvoiceForm
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
            System.Windows.Forms.Label invoice_NoLabel;
            System.Windows.Forms.Label customer_IDLabel;
            System.Windows.Forms.Label invoice_DateLabel;
            System.Windows.Forms.Label vatLabel;
            System.Windows.Forms.Label totalLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceSimpleMenagerDBDataSet = new NewInvoiceManager_v1.InvoiceSimpleMenagerDBDataSet();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceTableAdapter = new NewInvoiceManager_v1.InvoiceSimpleMenagerDBDataSetTableAdapters.InvoiceTableAdapter();
            this.tableAdapterManager = new NewInvoiceManager_v1.InvoiceSimpleMenagerDBDataSetTableAdapters.TableAdapterManager();
            this.invoiceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.invoiceBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.invoiceDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoice_NoComboBox = new System.Windows.Forms.ComboBox();
            this.customer_IDComboBox = new System.Windows.Forms.ComboBox();
            this.invoice_DateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.vatSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.totalSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.AddInvoiceButton = new System.Windows.Forms.Button();
            this.invoiceSimpleMenagerDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new NewInvoiceManager_v1.InvoiceSimpleMenagerDBDataSetTableAdapters.CustomerTableAdapter();
            invoice_NoLabel = new System.Windows.Forms.Label();
            customer_IDLabel = new System.Windows.Forms.Label();
            invoice_DateLabel = new System.Windows.Forms.Label();
            vatLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceSimpleMenagerDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingNavigator)).BeginInit();
            this.invoiceBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoice_DateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoice_DateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vatSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceSimpleMenagerDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // invoice_NoLabel
            // 
            invoice_NoLabel.AutoSize = true;
            invoice_NoLabel.Location = new System.Drawing.Point(58, 99);
            invoice_NoLabel.Name = "invoice_NoLabel";
            invoice_NoLabel.Size = new System.Drawing.Size(62, 13);
            invoice_NoLabel.TabIndex = 3;
            invoice_NoLabel.Text = "Invoice No:";
            // 
            // customer_IDLabel
            // 
            customer_IDLabel.AutoSize = true;
            customer_IDLabel.Location = new System.Drawing.Point(58, 126);
            customer_IDLabel.Name = "customer_IDLabel";
            customer_IDLabel.Size = new System.Drawing.Size(68, 13);
            customer_IDLabel.TabIndex = 5;
            customer_IDLabel.Text = "Customer ID:";
            // 
            // invoice_DateLabel
            // 
            invoice_DateLabel.AutoSize = true;
            invoice_DateLabel.Location = new System.Drawing.Point(58, 150);
            invoice_DateLabel.Name = "invoice_DateLabel";
            invoice_DateLabel.Size = new System.Drawing.Size(71, 13);
            invoice_DateLabel.TabIndex = 7;
            invoice_DateLabel.Text = "Invoice Date:";
            // 
            // vatLabel
            // 
            vatLabel.AutoSize = true;
            vatLabel.Location = new System.Drawing.Point(58, 176);
            vatLabel.Name = "vatLabel";
            vatLabel.Size = new System.Drawing.Size(26, 13);
            vatLabel.TabIndex = 9;
            vatLabel.Text = "Vat:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(58, 202);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(34, 13);
            totalLabel.TabIndex = 11;
            totalLabel.Text = "Total:";
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
            this.menuStrip1.Size = new System.Drawing.Size(808, 24);
            this.menuStrip1.TabIndex = 1;
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
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "Invoice";
            this.invoiceBindingSource.DataSource = this.invoiceSimpleMenagerDBDataSet;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.InvoiceTableAdapter = this.invoiceTableAdapter;
            this.tableAdapterManager.LineItemTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NewInvoiceManager_v1.InvoiceSimpleMenagerDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // invoiceBindingNavigator
            // 
            this.invoiceBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.invoiceBindingNavigator.BindingSource = this.invoiceBindingSource;
            this.invoiceBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.invoiceBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.invoiceBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.invoiceBindingNavigatorSaveItem});
            this.invoiceBindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.invoiceBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.invoiceBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.invoiceBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.invoiceBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.invoiceBindingNavigator.Name = "invoiceBindingNavigator";
            this.invoiceBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.invoiceBindingNavigator.Size = new System.Drawing.Size(808, 25);
            this.invoiceBindingNavigator.TabIndex = 2;
            this.invoiceBindingNavigator.Text = "bindingNavigator1";
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
            // invoiceBindingNavigatorSaveItem
            // 
            this.invoiceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.invoiceBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("invoiceBindingNavigatorSaveItem.Image")));
            this.invoiceBindingNavigatorSaveItem.Name = "invoiceBindingNavigatorSaveItem";
            this.invoiceBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.invoiceBindingNavigatorSaveItem.Text = "Save Data";
            this.invoiceBindingNavigatorSaveItem.Click += new System.EventHandler(this.invoiceBindingNavigatorSaveItem_Click);
            // 
            // invoiceDataGridView
            // 
            this.invoiceDataGridView.AutoGenerateColumns = false;
            this.invoiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.invoiceDataGridView.DataSource = this.invoiceBindingSource;
            this.invoiceDataGridView.Location = new System.Drawing.Point(12, 334);
            this.invoiceDataGridView.Name = "invoiceDataGridView";
            this.invoiceDataGridView.Size = new System.Drawing.Size(776, 220);
            this.invoiceDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Invoice_No";
            this.dataGridViewTextBoxColumn1.HeaderText = "Invoice_No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Customer_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Customer_ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Invoice_Date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Invoice_Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Vat";
            this.dataGridViewTextBoxColumn4.HeaderText = "Vat";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Total";
            this.dataGridViewTextBoxColumn5.HeaderText = "Total";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // invoice_NoComboBox
            // 
            this.invoice_NoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "Invoice_No", true));
            this.invoice_NoComboBox.DataSource = this.invoiceBindingSource;
            this.invoice_NoComboBox.DisplayMember = "Invoice_No";
            this.invoice_NoComboBox.FormattingEnabled = true;
            this.invoice_NoComboBox.Location = new System.Drawing.Point(135, 96);
            this.invoice_NoComboBox.Name = "invoice_NoComboBox";
            this.invoice_NoComboBox.Size = new System.Drawing.Size(121, 21);
            this.invoice_NoComboBox.TabIndex = 4;
            this.invoice_NoComboBox.ValueMember = "Invoice_No";
            // 
            // customer_IDComboBox
            // 
            this.customer_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "Customer_ID", true));
            this.customer_IDComboBox.DataSource = this.customerBindingSource;
            this.customer_IDComboBox.DisplayMember = "Customer_ID";
            this.customer_IDComboBox.FormattingEnabled = true;
            this.customer_IDComboBox.Location = new System.Drawing.Point(135, 123);
            this.customer_IDComboBox.Name = "customer_IDComboBox";
            this.customer_IDComboBox.Size = new System.Drawing.Size(121, 21);
            this.customer_IDComboBox.TabIndex = 6;
            this.customer_IDComboBox.ValueMember = "Customer_ID";
            // 
            // invoice_DateDateEdit
            // 
            this.invoice_DateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.invoiceBindingSource, "Invoice_Date", true));
            this.invoice_DateDateEdit.EditValue = null;
            this.invoice_DateDateEdit.Location = new System.Drawing.Point(135, 147);
            this.invoice_DateDateEdit.Name = "invoice_DateDateEdit";
            this.invoice_DateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.invoice_DateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.invoice_DateDateEdit.Size = new System.Drawing.Size(121, 20);
            this.invoice_DateDateEdit.TabIndex = 8;
            // 
            // vatSpinEdit
            // 
            this.vatSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.invoiceBindingSource, "Vat", true));
            this.vatSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.vatSpinEdit.Location = new System.Drawing.Point(135, 173);
            this.vatSpinEdit.Name = "vatSpinEdit";
            this.vatSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.vatSpinEdit.Size = new System.Drawing.Size(121, 20);
            this.vatSpinEdit.TabIndex = 10;
            // 
            // totalSpinEdit
            // 
            this.totalSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.invoiceBindingSource, "Total", true));
            this.totalSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.totalSpinEdit.Location = new System.Drawing.Point(135, 199);
            this.totalSpinEdit.Name = "totalSpinEdit";
            this.totalSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.totalSpinEdit.Size = new System.Drawing.Size(121, 20);
            this.totalSpinEdit.TabIndex = 12;
            // 
            // AddInvoiceButton
            // 
            this.AddInvoiceButton.Location = new System.Drawing.Point(135, 226);
            this.AddInvoiceButton.Name = "AddInvoiceButton";
            this.AddInvoiceButton.Size = new System.Drawing.Size(75, 23);
            this.AddInvoiceButton.TabIndex = 13;
            this.AddInvoiceButton.Text = "AddInvoiceButton";
            this.AddInvoiceButton.UseVisualStyleBackColor = true;
            this.AddInvoiceButton.Click += new System.EventHandler(this.AddInvoiceButton_Click);
            // 
            // invoiceSimpleMenagerDBDataSetBindingSource
            // 
            this.invoiceSimpleMenagerDBDataSetBindingSource.DataSource = this.invoiceSimpleMenagerDBDataSet;
            this.invoiceSimpleMenagerDBDataSetBindingSource.Position = 0;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.invoiceSimpleMenagerDBDataSetBindingSource;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 574);
            this.Controls.Add(this.AddInvoiceButton);
            this.Controls.Add(invoice_NoLabel);
            this.Controls.Add(this.invoice_NoComboBox);
            this.Controls.Add(customer_IDLabel);
            this.Controls.Add(this.customer_IDComboBox);
            this.Controls.Add(invoice_DateLabel);
            this.Controls.Add(this.invoice_DateDateEdit);
            this.Controls.Add(vatLabel);
            this.Controls.Add(this.vatSpinEdit);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.totalSpinEdit);
            this.Controls.Add(this.invoiceDataGridView);
            this.Controls.Add(this.invoiceBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.Name = "InvoiceForm";
            this.Text = "InvoiceForm";
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceSimpleMenagerDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingNavigator)).EndInit();
            this.invoiceBindingNavigator.ResumeLayout(false);
            this.invoiceBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoice_DateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoice_DateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vatSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceSimpleMenagerDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private InvoiceSimpleMenagerDBDataSetTableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        private InvoiceSimpleMenagerDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator invoiceBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton invoiceBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView invoiceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ComboBox invoice_NoComboBox;
        private System.Windows.Forms.ComboBox customer_IDComboBox;
        private DevExpress.XtraEditors.DateEdit invoice_DateDateEdit;
        private DevExpress.XtraEditors.SpinEdit vatSpinEdit;
        private DevExpress.XtraEditors.SpinEdit totalSpinEdit;
        private System.Windows.Forms.Button AddInvoiceButton;
        private System.Windows.Forms.BindingSource invoiceSimpleMenagerDBDataSetBindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private InvoiceSimpleMenagerDBDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
    }
}
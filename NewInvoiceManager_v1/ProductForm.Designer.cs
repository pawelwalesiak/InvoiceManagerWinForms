
namespace NewInvoiceManager_v1
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            System.Windows.Forms.Label part_NoLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label pkwiuLabel;
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label priceLabel;
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceSimpleMenagerDBDataSet = new NewInvoiceManager_v1.InvoiceSimpleMenagerDBDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new NewInvoiceManager_v1.InvoiceSimpleMenagerDBDataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new NewInvoiceManager_v1.InvoiceSimpleMenagerDBDataSetTableAdapters.TableAdapterManager();
            this.productBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.productBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.part_NoSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.descriptionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.pkwiuTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.costSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.priceSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.AddProductButton = new System.Windows.Forms.Button();
            part_NoLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            pkwiuLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceSimpleMenagerDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).BeginInit();
            this.productBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.part_NoSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkwiuTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceSpinEdit.Properties)).BeginInit();
            this.SuspendLayout();
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
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.invoiceSimpleMenagerDBDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.InvoiceTableAdapter = null;
            this.tableAdapterManager.LineItemTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.UpdateOrder = NewInvoiceManager_v1.InvoiceSimpleMenagerDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productBindingNavigator
            // 
            this.productBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productBindingNavigator.BindingSource = this.productBindingSource;
            this.productBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.productBindingNavigatorSaveItem});
            this.productBindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.productBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productBindingNavigator.Name = "productBindingNavigator";
            this.productBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productBindingNavigator.Size = new System.Drawing.Size(808, 25);
            this.productBindingNavigator.TabIndex = 2;
            this.productBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // productBindingNavigatorSaveItem
            // 
            this.productBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productBindingNavigatorSaveItem.Image")));
            this.productBindingNavigatorSaveItem.Name = "productBindingNavigatorSaveItem";
            this.productBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.productBindingNavigatorSaveItem.Text = "Save Data";
            this.productBindingNavigatorSaveItem.Click += new System.EventHandler(this.productBindingNavigatorSaveItem_Click);
            // 
            // productDataGridView
            // 
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.productDataGridView.DataSource = this.productBindingSource;
            this.productDataGridView.Location = new System.Drawing.Point(12, 331);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.Size = new System.Drawing.Size(776, 220);
            this.productDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Part_No";
            this.dataGridViewTextBoxColumn1.HeaderText = "Part_No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Pkwiu";
            this.dataGridViewTextBoxColumn3.HeaderText = "Pkwiu";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cost";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cost";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn5.HeaderText = "Price";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // part_NoLabel
            // 
            part_NoLabel.AutoSize = true;
            part_NoLabel.Location = new System.Drawing.Point(41, 83);
            part_NoLabel.Name = "part_NoLabel";
            part_NoLabel.Size = new System.Drawing.Size(46, 13);
            part_NoLabel.TabIndex = 3;
            part_NoLabel.Text = "Part No:";
            // 
            // part_NoSpinEdit
            // 
            this.part_NoSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "Part_No", true));
            this.part_NoSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.part_NoSpinEdit.Location = new System.Drawing.Point(110, 80);
            this.part_NoSpinEdit.Name = "part_NoSpinEdit";
            this.part_NoSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.part_NoSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.part_NoSpinEdit.TabIndex = 4;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(41, 109);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 5;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextEdit
            // 
            this.descriptionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "Description", true));
            this.descriptionTextEdit.Location = new System.Drawing.Point(110, 106);
            this.descriptionTextEdit.Name = "descriptionTextEdit";
            this.descriptionTextEdit.Size = new System.Drawing.Size(100, 20);
            this.descriptionTextEdit.TabIndex = 6;
            // 
            // pkwiuLabel
            // 
            pkwiuLabel.AutoSize = true;
            pkwiuLabel.Location = new System.Drawing.Point(41, 135);
            pkwiuLabel.Name = "pkwiuLabel";
            pkwiuLabel.Size = new System.Drawing.Size(39, 13);
            pkwiuLabel.TabIndex = 7;
            pkwiuLabel.Text = "Pkwiu:";
            // 
            // pkwiuTextEdit
            // 
            this.pkwiuTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "Pkwiu", true));
            this.pkwiuTextEdit.Location = new System.Drawing.Point(110, 132);
            this.pkwiuTextEdit.Name = "pkwiuTextEdit";
            this.pkwiuTextEdit.Size = new System.Drawing.Size(100, 20);
            this.pkwiuTextEdit.TabIndex = 8;
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(41, 161);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(31, 13);
            costLabel.TabIndex = 9;
            costLabel.Text = "Cost:";
            // 
            // costSpinEdit
            // 
            this.costSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "Cost", true));
            this.costSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.costSpinEdit.Location = new System.Drawing.Point(110, 158);
            this.costSpinEdit.Name = "costSpinEdit";
            this.costSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.costSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.costSpinEdit.TabIndex = 10;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(41, 187);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 11;
            priceLabel.Text = "Price:";
            // 
            // priceSpinEdit
            // 
            this.priceSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "Price", true));
            this.priceSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.priceSpinEdit.Location = new System.Drawing.Point(110, 184);
            this.priceSpinEdit.Name = "priceSpinEdit";
            this.priceSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.priceSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.priceSpinEdit.TabIndex = 12;
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(110, 229);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(100, 23);
            this.AddProductButton.TabIndex = 13;
            this.AddProductButton.Text = "AddProductButton";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 571);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(part_NoLabel);
            this.Controls.Add(this.part_NoSpinEdit);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextEdit);
            this.Controls.Add(pkwiuLabel);
            this.Controls.Add(this.pkwiuTextEdit);
            this.Controls.Add(costLabel);
            this.Controls.Add(this.costSpinEdit);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceSpinEdit);
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(this.productBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceSimpleMenagerDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).EndInit();
            this.productBindingNavigator.ResumeLayout(false);
            this.productBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.part_NoSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkwiuTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceSpinEdit.Properties)).EndInit();
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
        private System.Windows.Forms.BindingSource productBindingSource;
        private InvoiceSimpleMenagerDBDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private InvoiceSimpleMenagerDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton productBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DevExpress.XtraEditors.SpinEdit part_NoSpinEdit;
        private DevExpress.XtraEditors.TextEdit descriptionTextEdit;
        private DevExpress.XtraEditors.TextEdit pkwiuTextEdit;
        private DevExpress.XtraEditors.SpinEdit costSpinEdit;
        private DevExpress.XtraEditors.SpinEdit priceSpinEdit;
        private System.Windows.Forms.Button AddProductButton;
    }
}
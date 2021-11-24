
namespace NewInvoiceManager_v1
{
    partial class LineItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LineItemForm));
            System.Windows.Forms.Label invoice_NoLabel;
            System.Windows.Forms.Label lineItem_NoLabel;
            System.Windows.Forms.Label part_NoLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label priceLabel;
            this.invoiceSimpleMenagerDBDataSet = new NewInvoiceManager_v1.InvoiceSimpleMenagerDBDataSet();
            this.lineItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lineItemTableAdapter = new NewInvoiceManager_v1.InvoiceSimpleMenagerDBDataSetTableAdapters.LineItemTableAdapter();
            this.tableAdapterManager = new NewInvoiceManager_v1.InvoiceSimpleMenagerDBDataSetTableAdapters.TableAdapterManager();
            this.lineItemBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.lineItemBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.lineItemDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddLineItemButton = new System.Windows.Forms.Button();
            this.invoice_NoComboBox = new System.Windows.Forms.ComboBox();
            this.lineItem_NoComboBox = new System.Windows.Forms.ComboBox();
            this.part_NoComboBox = new System.Windows.Forms.ComboBox();
            this.quantitySpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.priceSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.RefreshLineitem = new System.Windows.Forms.Button();
            invoice_NoLabel = new System.Windows.Forms.Label();
            lineItem_NoLabel = new System.Windows.Forms.Label();
            part_NoLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceSimpleMenagerDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineItemBindingNavigator)).BeginInit();
            this.lineItemBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineItemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantitySpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceSpinEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // invoiceSimpleMenagerDBDataSet
            // 
            this.invoiceSimpleMenagerDBDataSet.DataSetName = "InvoiceSimpleMenagerDBDataSet";
            this.invoiceSimpleMenagerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lineItemBindingSource
            // 
            this.lineItemBindingSource.DataMember = "LineItem";
            this.lineItemBindingSource.DataSource = this.invoiceSimpleMenagerDBDataSet;
            // 
            // lineItemTableAdapter
            // 
            this.lineItemTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.InvoiceTableAdapter = null;
            this.tableAdapterManager.LineItemTableAdapter = this.lineItemTableAdapter;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NewInvoiceManager_v1.InvoiceSimpleMenagerDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lineItemBindingNavigator
            // 
            this.lineItemBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.lineItemBindingNavigator.BindingSource = this.lineItemBindingSource;
            this.lineItemBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.lineItemBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.lineItemBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.lineItemBindingNavigatorSaveItem});
            this.lineItemBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.lineItemBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.lineItemBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.lineItemBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.lineItemBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.lineItemBindingNavigator.Name = "lineItemBindingNavigator";
            this.lineItemBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.lineItemBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.lineItemBindingNavigator.TabIndex = 0;
            this.lineItemBindingNavigator.Text = "bindingNavigator1";
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
            // lineItemBindingNavigatorSaveItem
            // 
            this.lineItemBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lineItemBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("lineItemBindingNavigatorSaveItem.Image")));
            this.lineItemBindingNavigatorSaveItem.Name = "lineItemBindingNavigatorSaveItem";
            this.lineItemBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.lineItemBindingNavigatorSaveItem.Text = "Save Data";
            this.lineItemBindingNavigatorSaveItem.Click += new System.EventHandler(this.lineItemBindingNavigatorSaveItem_Click);
            // 
            // lineItemDataGridView
            // 
            this.lineItemDataGridView.AutoGenerateColumns = false;
            this.lineItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lineItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.lineItemDataGridView.DataSource = this.lineItemBindingSource;
            this.lineItemDataGridView.Location = new System.Drawing.Point(12, 279);
            this.lineItemDataGridView.Name = "lineItemDataGridView";
            this.lineItemDataGridView.Size = new System.Drawing.Size(753, 220);
            this.lineItemDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Invoice_No";
            this.dataGridViewTextBoxColumn1.HeaderText = "Invoice_No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LineItem_No";
            this.dataGridViewTextBoxColumn2.HeaderText = "LineItem_No";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Part_No";
            this.dataGridViewTextBoxColumn3.HeaderText = "Part_No";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn5.HeaderText = "Price";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // AddLineItemButton
            // 
            this.AddLineItemButton.Location = new System.Drawing.Point(116, 178);
            this.AddLineItemButton.Name = "AddLineItemButton";
            this.AddLineItemButton.Size = new System.Drawing.Size(121, 23);
            this.AddLineItemButton.TabIndex = 12;
            this.AddLineItemButton.Text = "AddLineItemButton";
            this.AddLineItemButton.UseVisualStyleBackColor = true;
            this.AddLineItemButton.Click += new System.EventHandler(this.AddLineItemButton_Click);
            // 
            // invoice_NoLabel
            // 
            invoice_NoLabel.AutoSize = true;
            invoice_NoLabel.Location = new System.Drawing.Point(40, 51);
            invoice_NoLabel.Name = "invoice_NoLabel";
            invoice_NoLabel.Size = new System.Drawing.Size(62, 13);
            invoice_NoLabel.TabIndex = 12;
            invoice_NoLabel.Text = "Invoice No:";
            // 
            // invoice_NoComboBox
            // 
            this.invoice_NoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lineItemBindingSource, "Invoice_No", true));
            this.invoice_NoComboBox.FormattingEnabled = true;
            this.invoice_NoComboBox.Location = new System.Drawing.Point(116, 48);
            this.invoice_NoComboBox.Name = "invoice_NoComboBox";
            this.invoice_NoComboBox.Size = new System.Drawing.Size(121, 21);
            this.invoice_NoComboBox.TabIndex = 13;
            // 
            // lineItem_NoLabel
            // 
            lineItem_NoLabel.AutoSize = true;
            lineItem_NoLabel.Location = new System.Drawing.Point(40, 78);
            lineItem_NoLabel.Name = "lineItem_NoLabel";
            lineItem_NoLabel.Size = new System.Drawing.Size(70, 13);
            lineItem_NoLabel.TabIndex = 14;
            lineItem_NoLabel.Text = "Line Item No:";
            // 
            // lineItem_NoComboBox
            // 
            this.lineItem_NoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lineItemBindingSource, "LineItem_No", true));
            this.lineItem_NoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.lineItemBindingSource, "Invoice_No", true));
            this.lineItem_NoComboBox.DataSource = this.lineItemBindingSource;
            this.lineItem_NoComboBox.DisplayMember = "Invoice_No";
            this.lineItem_NoComboBox.FormattingEnabled = true;
            this.lineItem_NoComboBox.Location = new System.Drawing.Point(116, 75);
            this.lineItem_NoComboBox.Name = "lineItem_NoComboBox";
            this.lineItem_NoComboBox.Size = new System.Drawing.Size(121, 21);
            this.lineItem_NoComboBox.TabIndex = 15;
            this.lineItem_NoComboBox.ValueMember = "Invoice_No";
            // 
            // part_NoLabel
            // 
            part_NoLabel.AutoSize = true;
            part_NoLabel.Location = new System.Drawing.Point(40, 105);
            part_NoLabel.Name = "part_NoLabel";
            part_NoLabel.Size = new System.Drawing.Size(46, 13);
            part_NoLabel.TabIndex = 16;
            part_NoLabel.Text = "Part No:";
            // 
            // part_NoComboBox
            // 
            this.part_NoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lineItemBindingSource, "Part_No", true));
            this.part_NoComboBox.DataSource = this.lineItemBindingSource;
            this.part_NoComboBox.DisplayMember = "LineItem_No";
            this.part_NoComboBox.FormattingEnabled = true;
            this.part_NoComboBox.Location = new System.Drawing.Point(116, 102);
            this.part_NoComboBox.Name = "part_NoComboBox";
            this.part_NoComboBox.Size = new System.Drawing.Size(121, 21);
            this.part_NoComboBox.TabIndex = 17;
            this.part_NoComboBox.ValueMember = "LineItem_No";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(40, 129);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(49, 13);
            quantityLabel.TabIndex = 18;
            quantityLabel.Text = "Quantity:";
            // 
            // quantitySpinEdit
            // 
            this.quantitySpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lineItemBindingSource, "Quantity", true));
            this.quantitySpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.quantitySpinEdit.Location = new System.Drawing.Point(116, 126);
            this.quantitySpinEdit.Name = "quantitySpinEdit";
            this.quantitySpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.quantitySpinEdit.Size = new System.Drawing.Size(121, 20);
            this.quantitySpinEdit.TabIndex = 19;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(40, 155);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 20;
            priceLabel.Text = "Price:";
            // 
            // priceSpinEdit
            // 
            this.priceSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lineItemBindingSource, "Price", true));
            this.priceSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.priceSpinEdit.Location = new System.Drawing.Point(116, 152);
            this.priceSpinEdit.Name = "priceSpinEdit";
            this.priceSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.priceSpinEdit.Size = new System.Drawing.Size(121, 20);
            this.priceSpinEdit.TabIndex = 21;
            // 
            // RefreshLineitem
            // 
            this.RefreshLineitem.Location = new System.Drawing.Point(116, 218);
            this.RefreshLineitem.Name = "RefreshLineitem";
            this.RefreshLineitem.Size = new System.Drawing.Size(121, 23);
            this.RefreshLineitem.TabIndex = 22;
            this.RefreshLineitem.Text = "RefreshLineitem";
            this.RefreshLineitem.UseVisualStyleBackColor = true;
            this.RefreshLineitem.Click += new System.EventHandler(this.RefreshLineitem_Click);
            // 
            // LineItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.RefreshLineitem);
            this.Controls.Add(invoice_NoLabel);
            this.Controls.Add(this.invoice_NoComboBox);
            this.Controls.Add(lineItem_NoLabel);
            this.Controls.Add(this.lineItem_NoComboBox);
            this.Controls.Add(part_NoLabel);
            this.Controls.Add(this.part_NoComboBox);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantitySpinEdit);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceSpinEdit);
            this.Controls.Add(this.AddLineItemButton);
            this.Controls.Add(this.lineItemDataGridView);
            this.Controls.Add(this.lineItemBindingNavigator);
            this.Name = "LineItemForm";
            this.Text = "LineItemForm";
            this.Load += new System.EventHandler(this.LineItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceSimpleMenagerDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineItemBindingNavigator)).EndInit();
            this.lineItemBindingNavigator.ResumeLayout(false);
            this.lineItemBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineItemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantitySpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceSpinEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InvoiceSimpleMenagerDBDataSet invoiceSimpleMenagerDBDataSet;
        private System.Windows.Forms.BindingSource lineItemBindingSource;
        private InvoiceSimpleMenagerDBDataSetTableAdapters.LineItemTableAdapter lineItemTableAdapter;
        private InvoiceSimpleMenagerDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator lineItemBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton lineItemBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView lineItemDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button AddLineItemButton;
        private System.Windows.Forms.ComboBox invoice_NoComboBox;
        private System.Windows.Forms.ComboBox lineItem_NoComboBox;
        private System.Windows.Forms.ComboBox part_NoComboBox;
        private DevExpress.XtraEditors.SpinEdit quantitySpinEdit;
        private DevExpress.XtraEditors.SpinEdit priceSpinEdit;
        private System.Windows.Forms.Button RefreshLineitem;
    }
}
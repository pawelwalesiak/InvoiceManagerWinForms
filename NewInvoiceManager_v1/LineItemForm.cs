using NewInvoiceManager_v1.BLL;
using NewInvoiceManager_v1.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewInvoiceManager_v1
{
    public partial class LineItemForm : Form
    {
        public LineItemForm()
        {
            InitializeComponent();
        }
        LineItemBLL u = new LineItemBLL();
        LineItemDAL dal = new LineItemDAL();
        private void lineItemBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lineItemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.invoiceSimpleMenagerDBDataSet);

        }

        private void LineItemForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'invoiceSimpleMenagerDBDataSet.LineItem' table. You can move, or remove it, as needed.
            this.lineItemTableAdapter.Fill(this.invoiceSimpleMenagerDBDataSet.LineItem);

        }

        private void AddLineItemButton_Click(object sender, EventArgs e)
        {
            u.Invoice_No = int.Parse(invoice_NoComboBox.Text);
            u.LineItem_No = int.Parse(lineItem_NoComboBox.Text);
            u.Part_No = int.Parse(part_NoComboBox.Text);
            u.Quantity = int.Parse(quantitySpinEdit.Text);
            u.Price = decimal.Parse(priceSpinEdit.Text);


            bool success = dal.Insert(u);


            //If the data is successfully inserted then the value of success will be true else it will be false
            if (success == true)
            {
                //Data Successfully Inserted
                MessageBox.Show("Successfully created");
                //Refresh data
                DataTable dt = dal.Select();
                lineItemDataGridView.DataSource = dt;
            }
            else
            {
                //Failed to insert data
                MessageBox.Show("Failed to add new company");
            }
        }

        private void RefreshLineitem_Click(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            lineItemDataGridView.DataSource = dt;
        }
    }
}

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
    public partial class InvoiceForm : Form
    {
        public InvoiceForm()
        {
            InitializeComponent();
        }

        InvoiceBLL u = new InvoiceBLL();
        InvoiceDAL dal = new InvoiceDAL();
        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmCustomer = new Form1();
            frmCustomer.Show();
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmInvoice = new InvoiceForm();
            frmInvoice.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmProduct = new ProductForm();
            frmProduct.Show();
        }

        private void lineItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmLineItem = new LineItemForm();
            frmLineItem.Show();
        }

        private void invoiceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.invoiceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.invoiceSimpleMenagerDBDataSet);

        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'invoiceSimpleMenagerDBDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.invoiceSimpleMenagerDBDataSet.Customer);
            // TODO: This line of code loads data into the 'invoiceSimpleMenagerDBDataSet.Invoice' table. You can move, or remove it, as needed.
            this.invoiceTableAdapter.Fill(this.invoiceSimpleMenagerDBDataSet.Invoice);

        }

        private void AddInvoiceButton_Click(object sender, EventArgs e)
        {
            u.Customer_ID = Convert.ToInt32(customer_IDComboBox.Text);
            //u.Customer_ID = int.Parse( customer_IDComboBox.Text);
            u.Invoice_Date = DateTime.Now;
            u.Vat = decimal.Parse(vatSpinEdit.Text);
            u.Total = decimal.Parse(totalSpinEdit.Text)*(u.Vat);


            bool success = dal.Insert(u);


            //If the data is successfully inserted then the value of success will be true else it will be false
            if (success == true)
            {
                //Data Successfully Inserted
                MessageBox.Show("Successfully created");
                //Refresh data
                DataTable dt = dal.Select();
                invoiceDataGridView.DataSource = dt;
            }
            else
            {
                //Failed to insert data
                MessageBox.Show("Failed to add new company");
            }
        }
    }
}

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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }
        ProductBLL u = new ProductBLL();
        ProductDAL dal = new ProductDAL();

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

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.invoiceSimpleMenagerDBDataSet);

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'invoiceSimpleMenagerDBDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.invoiceSimpleMenagerDBDataSet.Product);

        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
           

            u.Description = descriptionTextEdit.Text;
            u.Pkwiu = pkwiuTextEdit.Text;
            u.Cost = decimal.Parse(costSpinEdit.Text);
            u.Price = decimal.Parse(priceSpinEdit.Text);


            bool success = dal.Insert(u);


            //If the data is successfully inserted then the value of success will be true else it will be false
            if (success == true)
            {
                //Data Successfully Inserted
                MessageBox.Show("Successfully created");
                //Refresh data
                DataTable dt = dal.Select();
                productDataGridView.DataSource = dt;
            }
            else
            {
                //Failed to insert data
                MessageBox.Show("Failed to add new company");
            }
        }
    }
}

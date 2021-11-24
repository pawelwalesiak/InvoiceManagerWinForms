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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CustomerBLL u = new CustomerBLL();
        CustomerDAL dal = new CustomerDAL();

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

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.invoiceSimpleMenagerDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'invoiceSimpleMenagerDBDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.invoiceSimpleMenagerDBDataSet.Customer);

        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            u.Name = nameTextEdit.Text;
            u.Address = addressTextEdit.Text;
            u.City = cityTextEdit.Text;
            u.CityCode = cityCodeTextEdit.Text;
            u.Phone = phoneTextEdit.Text;
            u.Nip = nipTextEdit.Text;
            u.Regon = regonTextEdit.Text;
            u.Krs = krsTextEdit.Text;
            u.Pkd = pkdTextEdit.Text;


            bool success = dal.Insert(u);


            //If the data is successfully inserted then the value of success will be true else it will be false
            if (success == true)
            {
                //Data Successfully Inserted
                MessageBox.Show("Successfully created");
                Clear();
                //Refresh data
                DataTable dt = dal.Select();
                customerDataGridView.DataSource = dt;
            }
            else
            {
                //Failed to insert data
                MessageBox.Show("Failed to add new company");
            }
        }

        private void DeleteCompanyButton_Click(object sender, EventArgs e)
        {
            //GEt the ID of the product to be deleted
            //    u.Name = int.Parse(txtID.Text);
            u.Name = nameComboBox.Text;
            //Create Bool VAriable to Check if the product is deleted or not
            bool success = dal.Delete(u);

            //If prouct is deleted successfully then the value of success will true else it will be false
            if (success == true)
            {
                //Product Successfuly Deleted
                MessageBox.Show("Product successfully deleted.");
                Clear();
                //Refresh DAta Grid View
                DataTable dt = dal.Select();
                customerDataGridView.DataSource = dt;
            }
            else
            {
                //Failed to Delete Product
                MessageBox.Show("Failed to Delete Product.");
            }
        }

        public void Clear()
        {
            nameTextEdit.Text = "";
            addressTextEdit.Text = "";
            cityTextEdit.Text = "";
            cityCodeTextEdit.Text = ""; 
            phoneTextEdit.Text = "";
            nipTextEdit.Text = "";
            regonTextEdit.Text = "";
            krsTextEdit.Text = "";
            u.Pkd = pkdTextEdit.Text = "";
        }

        private void UpdateCompanyButton_Click(object sender, EventArgs e)
        {
            u.Name = nameTextEdit.Text;
            u.Address = addressTextEdit.Text;
            u.City = cityTextEdit.Text;
            u.CityCode = cityCodeTextEdit.Text;
            u.Phone = phoneTextEdit.Text;
            u.Nip = nipTextEdit.Text;
            u.Regon = regonTextEdit.Text;
            u.Krs = krsTextEdit.Text;
            u.Pkd = pkdTextEdit.Text;

            //Create a boolean variable to check if the product is updated or not
            bool success = dal.Update(u);
            //If the prouct is updated successfully then the value of success will be true else it will be false
            if (success == true)
            {
                //Product updated Successfully
                MessageBox.Show("Product Successfully Updated");
               // Clear();
                //REfresh the Data Grid View
                DataTable dt = dal.Select();
                customerDataGridView.DataSource = dt;
            }
            else
            {
                //Failed to Update Product
                MessageBox.Show("Failed to Update Product");
            }
        }
    }
}

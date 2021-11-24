using NewInvoiceManager_v1.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewInvoiceManager_v1.DAL
{
    class LineItemDAL
    {

        static string myconnstrng = ConfigurationManager.ConnectionStrings["NewInvoiceManager_v1.Properties.Settings.InvoiceSimpleMenagerDBConnectionString"].ConnectionString;

        internal DataTable Select()
        {
            //Create Sql Connection to connect Databaes
            SqlConnection conn = new SqlConnection(myconnstrng);

            //DAtaTable to hold the data from database
            DataTable dt = new DataTable();

            try
            {
                //Writing the Query to Select all the products from database
                String sql = "SELECT LineItem.Invoice_No, LineItem.LineItem_No, LineItem.Part_No, LineItem.Quantity, LineItem.Price, Customer.Name AS Expr1, Invoice.Total, Product.Description, Product.Pkwiu, Invoice.Customer_ID FROM Product INNER JOIN  LineItem ON Product.Part_No = LineItem.Part_No CROSS JOIN Invoice INNER JOIN Customer ON Invoice.Customer_ID = Customer.Customer_ID";

                //Creating SQL Command to Execute Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //SQL Data Adapter to hold the value from database temporarily
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Open DAtabase Connection
                conn.Open();

                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        internal bool Insert(LineItemBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);


            try
            {
                String sql = "INSERT INTO LineItem (Invoice_No, LineItem_No, Part_No, Quantity, Price) VALUES (@Invoice_No, @LineItem_No, @Part_No, @Quantity, @Price)";
                SqlCommand cmd = new SqlCommand(sql, conn);


                cmd.Parameters.AddWithValue("@Invoice_No", u.Invoice_No);
                cmd.Parameters.AddWithValue("@LineItem_No", u.LineItem_No);
                cmd.Parameters.AddWithValue("@Part_No", u.Part_No);
                cmd.Parameters.AddWithValue("@Quantity", u.Quantity);
                cmd.Parameters.AddWithValue("@Price", u.Price);

                conn.Open();



                int rows = cmd.ExecuteNonQuery();

                //If the query is executed Successfully then the value to rows will be greater than 0 else it will be less than 0
                if (rows > 0)
                {
                    //Query Sucessfull
                    isSuccess = true;
                }
                else
                {
                    //Query Failed
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }
}

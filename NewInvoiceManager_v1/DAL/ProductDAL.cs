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
    class ProductDAL
    {

        static string myconnstrng = ConfigurationManager.ConnectionStrings["NewInvoiceManager_v1.Properties.Settings.InvoiceSimpleMenagerDBConnectionString"].ConnectionString;

        internal bool Insert(ProductBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);


            try
            {
                String sql = "INSERT INTO Product (Description, Pkwiu, Cost, Price) VALUES (@Description, @Pkwiu, @Cost, @Price)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Description", u.Description);
                cmd.Parameters.AddWithValue("@Pkwiu", u.Pkwiu);
                cmd.Parameters.AddWithValue("@Cost", u.Cost);
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

        internal DataTable Select()
        {
            //Create Sql Connection to connect Databaes
            SqlConnection conn = new SqlConnection(myconnstrng);

            //DAtaTable to hold the data from database
            DataTable dt = new DataTable();

            try
            {
                //Writing the Query to Select all the products from database
                String sql = "SELECT * FROM Product";

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
    }
}

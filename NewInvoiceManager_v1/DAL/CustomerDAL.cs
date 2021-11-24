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
    class CustomerDAL
    {

        static string myconnstrng = ConfigurationManager.ConnectionStrings["NewInvoiceManager_v1.Properties.Settings.InvoiceSimpleMenagerDBConnectionString"].ConnectionString;

        internal bool Insert(CustomerBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);


            try
            {
                String sql = "INSERT INTO Customer (Name, Address, City, CityCode, Phone, Nip, Regon, Krs, Pkd) VALUES (@Name, @Address, @City, @CityCode, @Phone, @Nip, @Regon, @Krs, @Pkd)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Name", u.Name);
                cmd.Parameters.AddWithValue("@Address", u.Address);
                cmd.Parameters.AddWithValue("@City", u.City);
                cmd.Parameters.AddWithValue("@CityCode", u.CityCode);
                cmd.Parameters.AddWithValue("@Phone", u.Phone);
                cmd.Parameters.AddWithValue("@Nip", u.Nip);
                cmd.Parameters.AddWithValue("@Regon", u.Regon);
                cmd.Parameters.AddWithValue("@Krs", u.Krs);
                cmd.Parameters.AddWithValue("@Pkd", u.Pkd);

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
                String sql = "SELECT * FROM Customer";

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

        internal bool Delete(CustomerBLL u)
        {
            //Create Boolean Variable and Set its default value to false
            bool isSuccess = false;

            //SQL Connection for DB connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Write Query Product from DAtabase
                String sql = "DELETE FROM Customer WHERE Name=@Name";

                //Sql Command to Pass the Value
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Passing the values using cmd
                cmd.Parameters.AddWithValue("@Name", u.Name);

                //Open Database Connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //If the query is executed successfullly then the value of rows will be greated than 0 else it will be less than 0
                if (rows > 0)
                {
                    //Query Executed Successfully
                    isSuccess = true;
                }
                else
                {
                    //Failed to Execute Query
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

        internal bool Update(CustomerBLL u)
        {
            //create a boolean variable and set its initial value to false
            bool isSuccess = false;

            //Create SQL Connection for DAtabase
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //SQL Query to Update Data in dAtabase
               //   String sql = "UPDATE  Customer SET Name=@Name, Address = @Address, City = @City, CityCode = @CityCode, Phone = @Phone, Nip = @Nip, regon = @Regon, Krs = @Krs, Pkd = @Pkd WHERE Customer_ID=@Customer_ID";
                String sql = "UPDATE  Customer SET Name=@Name, Address = @Address, City = @City, CityCode = @CityCode, Phone = @Phone, Nip = @Nip, regon = @Regon, Krs = @Krs, Pkd = @Pkd WHERE Name=@Name";

                // String sql = "UPDATE tbl_products SET name=@name, category=@category, description=@description, rate=@rate, added_date=@added_date, added_by=@added_by WHERE id=@id";

                //Create SQL Cmmand to pass the value to query
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Passing the values using parameters and cmd
              //  cmd.Parameters.AddWithValue("@Customer_ID", u.Customer_ID);
                cmd.Parameters.AddWithValue("@Name", u.Name);
                cmd.Parameters.AddWithValue("@Address", u.Address);
                cmd.Parameters.AddWithValue("@City", u.City);
                cmd.Parameters.AddWithValue("@CityCode", u.CityCode);
                cmd.Parameters.AddWithValue("@Phone", u.Phone);
                cmd.Parameters.AddWithValue("@Nip", u.Nip);
                cmd.Parameters.AddWithValue("@Regon", u.Regon);
                cmd.Parameters.AddWithValue("@Krs", u.Krs);
                cmd.Parameters.AddWithValue("@Pkd", u.Pkd);

                //Open the Database connection
                conn.Open();

                //Create Int Variable to check if the query is executed successfully or not
                int rows = cmd.ExecuteNonQuery();

                //if the query is executed successfully then the value of rows will be greater than 0 else it will be less than zero
                if (rows > 0)
                {
                    //Query ExecutedSuccessfully
                    isSuccess = true;
                }
                else
                {
                    //Failed to Execute Query
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

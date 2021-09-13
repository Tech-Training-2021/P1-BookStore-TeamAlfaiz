using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows;


namespace BookStore2._0
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        protected void login(string conString)
        {
            string name = tb_Name.Text;
            string password = tb_Password.Text;
            string query = $"select * from customer where customer_Name='{name}' and customer_Password='{password}'";
            using (SqlConnection connection = new SqlConnection(conString)) 
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            Session["UserName"] = name;
                            Session["Password"] = password;
                            Response.Redirect($"Default.aspx");
                        }
                        else
                        {
                            lbl_Display.Text = "Invalid email or password";
                        }
                    }
                }
                catch (SqlException)
                {
                    throw;
                    //log errors
                }
                finally
                {
                    connection.Close();
                    
                }
            }

        }

        protected void btn_Add_Click(object sender, EventArgs e)
        {
            string conString = "Server=tcp:nspdatabase.database.windows.net,1433;Initial Catalog=Book_Store;Persist Security Info=False;User ID=nomaan;Password=Computers123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
            login(conString);
        }
    }
}
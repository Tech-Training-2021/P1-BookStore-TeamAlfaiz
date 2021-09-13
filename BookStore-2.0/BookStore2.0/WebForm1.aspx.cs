using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace BookStore2._0
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Customer_Registration(string conString)
        {
            string gender = "";
            if (rb_Male.Checked) {
                 gender = "male";
            }
            else if(rb_Female.Checked) {
                gender = "female";
            }
            string Name = tb_Name.Text;
            string Email = tb_Email.Text;
            string Phone = tb_Phone.Text;
            string address = tb_address.Text;
            string age = tb_age.Text;
            string password = tb_password.Text;
            string query = "CustomerRegistration";
            using (SqlConnection cons = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(query, cons))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter parameter;
                    parameter = cmd.Parameters.Add("@customer_Name", SqlDbType.VarChar);
                    parameter.Value = Name;
                    parameter = cmd.Parameters.Add("@customer_Email", SqlDbType.VarChar);
                    parameter.Value = Email;
                    parameter = cmd.Parameters.Add("@customer_Age", SqlDbType.VarChar);
                    parameter.Value = age;
                    parameter = cmd.Parameters.Add("@customer_Phone", SqlDbType.VarChar);
                    parameter.Value = Phone;
                    parameter = cmd.Parameters.Add("@customer_Address", SqlDbType.VarChar);
                    parameter.Value = address;
                    parameter = cmd.Parameters.Add("@customer_Password", SqlDbType.VarChar);
                    parameter.Value = password;
                    parameter = cmd.Parameters.Add("@customer_Gender", SqlDbType.VarChar);
                    parameter.Value = gender;
                    cmd.Connection = cons;
                    cons.Open();
                    cmd.ExecuteNonQuery();
                    cons.Close();
                }

            }
        }
        protected void btn_Add_Click(object sender, EventArgs e)
        {
           
        }

        protected void btn_Add_Click1(object sender, EventArgs e)
        {
            string conString = "Server=tcp:nspdatabase.database.windows.net,1433;Initial Catalog=Book_Store;Persist Security Info=False;User ID=nomaan;Password=Computers123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
            Customer_Registration(conString);
            Response.Redirect("WebForm2.aspx");
        }
    }
}
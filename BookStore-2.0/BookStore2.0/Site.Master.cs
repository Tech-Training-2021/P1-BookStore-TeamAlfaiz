using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookStore2._0
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] != null)
            {
                log.InnerHtml = "Logout";
                user_name_Set.InnerHtml = Session["UserName"].ToString();
                log.HRef = "~/logout";
            }
            else
            {
                log.InnerHtml = "Login";
                log.HRef = "~/WebForm2";
            }
        }
      
    }
}
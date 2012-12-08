using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace int422_123b24
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (User.IsInRole("admin"))
                {
                    Response.Redirect("Project/Admin/Default.aspx");
                }
                else if (User.IsInRole("user"))
                {
                    Response.Redirect("Project/User/Default.aspx");
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
            }
        }
    }
}
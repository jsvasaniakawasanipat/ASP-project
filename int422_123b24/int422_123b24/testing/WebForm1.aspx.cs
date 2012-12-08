using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace int422_123b24.testing
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MembershipCreateStatus status;    // Obviously, you will replace generic data with your own...    
            Membership.CreateUser("jayesh", "j@yesh11", "jsvasaniakawasanipat@learn.senecac.on.ca", "favorite color", "blue", true, out status);
            Roles.AddUserToRole("jayesh", "admin");
            Response.Write("Done"); 
        }
    }
}
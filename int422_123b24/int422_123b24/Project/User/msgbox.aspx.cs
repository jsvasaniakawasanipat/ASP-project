using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace int422_123b24.Project.User
{
    public partial class msgbox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnYes_Click(object sender, EventArgs e)
        {
            try
            {

                Response.Redirect("AddComment.aspx");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void BTNNo_Click(object sender, EventArgs e)
        {
            try
            {

                Response.Redirect("StudentSearch.aspx");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
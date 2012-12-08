using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using int422_123b24.classes;

namespace int422_123b24.Project.User
{
    public partial class UserMaster : System.Web.UI.MasterPage
    {
        manager mngr = new manager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void MenuUser_MenuItemClick(object sender, MenuEventArgs e)
        {
            if (MenuUser.SelectedItem.Value == "View Comment")
            {
                string otp = string.Empty;
                Label l1 = new Label();
                bool t = false;
                try
                {
                    l1.Text = mngr.viewAllComments();
                    Session["l1"] = l1.Text;
                    Response.Redirect("CommentView.aspx");
                }
                catch (Exception Ex)
                {
                    throw Ex;
                }

            }
        }
    }
}
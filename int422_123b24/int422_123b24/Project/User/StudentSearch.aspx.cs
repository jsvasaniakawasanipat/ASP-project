using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using int422_123b24.classes;
using int422_123b24.Database;

namespace int422_123b24.Project.User
{
    public partial class test3 : System.Web.UI.Page
    {
        manager mngr = new manager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTNSearch_Click(object sender, EventArgs e)
        {
            string otp = string.Empty;
            Label l1 = new Label();
            bool t = false;
            try
            {
                if (TBStdid == null || TBStdid.Text == "")
                {
                    t = mngr.ckStudent(DDLStdid.SelectedItem.Text);
                    l1.Text = mngr.studentSearch(DDLStdid.SelectedItem.Text);
                    Session["stdid"] = DDLStdid.SelectedItem.Text;
                }
                else
                {
                    t = mngr.ckStudent(TBStdid.Text);
                    l1.Text = mngr.studentSearch(TBStdid.Text);
                    Session["stdid"] = TBStdid.Text;
                }
                if (t == false)
                {
                    Response.Redirect("msgbox.aspx");
                }
                else
                {
                    Session["l1"] = l1.Text;
                    Response.Redirect("CommentView.aspx");
                }
                //Response.Redirect("Project/User/StudentSearch.aspx");
            }
            catch (Exception Ex)
            {
                LBLerr.Text = Ex.Message;
            }

        }
    }
}
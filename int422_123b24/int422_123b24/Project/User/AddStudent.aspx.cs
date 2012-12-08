using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using int422_123b24.classes;

namespace int422_123b24.Project.User
{
    public partial class test : System.Web.UI.Page
    {
        manager mngr = new manager();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label t = new Label();
            t.Text = Convert.ToString(Session["stdid"]);
            if (t == null || t.Text == "")
            {
            }
            else
            {
                TBStdNo.Text = t.Text.Substring(1);
                TBStdNo.ReadOnly = true;
            }
            TBStdName.Focus();


        }

        protected void BTNSearch_Click(object sender, EventArgs e)
        {
            try
            {
                mngr.addstudent(TBStdNo.Text, TBStdName.Text);
                LBLerr.ForeColor = System.Drawing.Color.Green;
                LBLerr.Text = "Record Saved";
                TBStdNo.Text = "";
                TBStdName.Text = "";
                TBStdName.Focus();
            }
            catch (Exception Ex)
            {
                LBLerr.Text = Ex.Message;
            }

        }
    }
}
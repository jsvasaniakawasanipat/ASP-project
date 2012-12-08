using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using int422_123b24.classes;
using int422_123b24.Database;
using System.Data;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace int422_123b24.Project.User
{
    public partial class AddComment : System.Web.UI.Page
    {
        manager mngr = new manager();
        bool f = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label t = new Label();
            t.Text = Convert.ToString(Session["stdid"]);
            Session["stdid"] = "";
            if (t == null || t.Text == "")
            {
            }
            else
            {
                TBstdId.Text = t.Text;
                TBstdId.ReadOnly = true;
                f=true;
                CKEcmt.Focus();
            }
            

        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //MembershipUser usr = Membership.GetUser();
                Guid ui = (Guid)Membership.GetUser().ProviderUserKey;
                if (f == true)
                {
                    //mngr.addstudent(TBstdId.Text, "x");
                }
                mngr.addComment(ui, TBstdId.Text, CKEcmt.Text, DateTime.Now);
                LBLaddCmntErr.ForeColor = System.Drawing.Color.Green;
                LBLaddCmntErr.Text = "Record Saved";
                TBstdId.Text = "";
                CKEcmt.Text = "";
                TBstdId.Focus();
            }//try
            catch (Exception ex)
            {
                LBLaddCmntErr.Text = ex.Message;
            }//catch
        }
    }
}
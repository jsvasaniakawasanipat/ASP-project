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
    public partial class test1 : System.Web.UI.Page
    {
        manager mngr = new manager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["l1"] == null || Session["l1"] == "" || Session["stdid"] == null || Session["stdid"] == "")
            {
            }
            else
            {
                LBLDtl.Text = Convert.ToString(Session["l1"]);
                LBLStdno.Text = Convert.ToString(Session["stdid"]);
                Session["l1"] = "";
                Session["stdid"] = "";
            }
            if (LBLStdno == null || LBLStdno.Text == "")
            {
                LBSortAdvisor.Visible = false;
                LBSortDate.Visible = false;
                PNLaddComment.Visible = false;
            }
        }

        protected void LBSortAdvisor_Click(object sender, EventArgs e)
        {
            try
            {
                mngr.viewComment(LBLStdno.Text, "Advisor");
            }
            catch (Exception Ex)
            {
                LBLerr.Text = Ex.Message;
            }
        }

        protected void LBSortDate_Click(object sender, EventArgs e)
        {
            try
            {
                mngr.viewComment(LBLStdno.Text, "Date");
            }
            catch (Exception Ex)
            {
                LBLerr.Text = Ex.Message;
            }
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Guid ui = (Guid)Membership.GetUser().ProviderUserKey;
                mngr.addComment(ui, LBLStdno.Text, CKEcmt.Text, DateTime.Now);
                LBLDtl.Text = mngr.viewComment(LBLStdno.Text, "");
                CKEcmt.Text = "";
            }//try
            catch (Exception ex)
            {
                LBLaddCmntErr.Text = ex.Message;
            }//catch
        }
    }
}
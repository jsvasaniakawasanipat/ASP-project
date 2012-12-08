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



namespace int422_123b24.Project.Admin
{
    public partial class DeleteUser : System.Web.UI.Page
    {
        manager mngr = new manager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUsers_Click(object sender, EventArgs e)
        {
            try
            {
                mngr.deleteUser(DDLusers.SelectedItem.Text);
                DDLusers.DataBind();
                LblsuccDel.Visible = true;
                LbldelErr.Visible = false;
            }
            catch (Exception ex)
            {
                LblsuccDel.Visible = false;
                LbldelErr.Visible = true;
                LbldelErr.Text = ex.Message;
            }
        }
    }
}
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
    public partial class CreateUser : System.Web.UI.Page
    {
        manager mngr = new manager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void CreateUserWizard1_CreatedUser1(object sender, EventArgs e)
        {
            bool tr = false;
            RadioButtonList RBLrole = (RadioButtonList)CreateUserWizard1.CreateUserStep.ContentTemplateContainer.FindControl("RBLrole");
            Label LblError = (Label)CreateUserWizard1.CreateUserStep.ContentTemplateContainer.FindControl("LblError");
            mngr.addRoles(CreateUserWizard1.UserName, RBLrole.SelectedItem.Value);
            Guid st = (Guid)Membership.GetUser(CreateUserWizard1.UserName).ProviderUserKey;
            try
            {
                tr = mngr.addAuthor(st, CreateUserWizard1.UserName); // call addAuthor() to add user as author
            }
            catch (Exception ex)
            {
                LblError.Visible = true;
                LblError.Text = ex.Message;
                if (tr == false)
                {
                    Membership.DeleteUser(CreateUserWizard1.UserName, true);
                    CreateUserWizard1.ActiveStepIndex = -1;
                    if (ex.GetType().ToString() == "IdentityMustBeUnique")
                    {
                        CreateUserWizard1.UserName = string.Empty;
                    }
                    else
                    {
                        LblError.Text = "We are unable to complete your request at this time - error message = " + ex.Message;
                    }
                }
            }
        }

        protected void Answer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
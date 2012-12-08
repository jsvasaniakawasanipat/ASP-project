using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lab2.classes; 

namespace int422_123b24.Lab2
{
    public partial class Lab2 : System.Web.UI.UserControl
    {
        public SenecaStudent student
        {
            get
            {
                if (Session["student"] == null)
                {
                    return new SenecaStudent();
                }
                else
                {
                    return (SenecaStudent)Session["student"];
                }
            }
            set { Session["student"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            LBLshow.Text = student.getInfo();
        }
    }
}
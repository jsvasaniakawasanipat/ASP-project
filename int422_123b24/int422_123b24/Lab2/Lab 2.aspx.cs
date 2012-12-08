using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lab2.classes;

namespace int422_123b24.Lab2
{
    public partial class Lab_2 : System.Web.UI.Page
    {
        public SenecaStudent Mystudent
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
        public void set(string sm)
        {
            SenecaStudent student = new SenecaStudent();
            student.FirstName = TBfnm.Text;
            student.LastName = TBlnm.Text;
            student.Email = TBemail.Text;
            student.StID = TBsid.Text;
            student.Cource = DDLcource.Text;
            student.Sem = sm;

            Mystudent = student;

            //student = new SenecaStudent(TBfnm.Text, TBlnm.Text, TBemail.Text, TBsid.Text);

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session.Remove("student");
                PNLget.Visible = true;
                PNLshow.Visible = false;
            }
        }

        protected void DDLcource_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DDLcource.Text == "DAD")
            {
                RBL2sem.Visible = true;
                RBL4sem.Visible = false;
                RBL6sem.Visible = false;
                RBL8sem.Visible = false;
            }
            else if (DDLcource.Text == "CPD")
            {
                RBL4sem.Visible = true;
                RBL2sem.Visible = false;
                RBL6sem.Visible = false;
                RBL8sem.Visible = false;
            }
            else if ((DDLcource.Text == "CPA") || (DDLcource.Text == "CTY"))
            {
                RBL6sem.Visible = true;
                RBL2sem.Visible = false;
                RBL4sem.Visible = false;
                RBL8sem.Visible = false;
            }
            else if ((DDLcource.Text == "BSD") || (DDLcource.Text == "IFS"))
            {
                RBL8sem.Visible = true;
                RBL2sem.Visible = false;
                RBL4sem.Visible = false;
                RBL6sem.Visible = false;
            }
        }

        protected void RBL2sem_SelectedIndexChanged(object sender, EventArgs e)
        {
            BTNsbmt.Visible = true;
            set(RBL2sem.SelectedItem.Text);
        }

        protected void RBL4sem_SelectedIndexChanged(object sender, EventArgs e)
        {
            BTNsbmt.Visible = true;
            set(RBL4sem.SelectedItem.Text);
        }

        protected void RBL6sem_SelectedIndexChanged(object sender, EventArgs e)
        {
            BTNsbmt.Visible = true;
            set(RBL6sem.SelectedItem.Text);
        }

        protected void RBL8sem_SelectedIndexChanged(object sender, EventArgs e)
        {
            BTNsbmt.Visible = true;
            set(RBL8sem.SelectedItem.Text);
        }

        protected void BTNsbmt_Click(object sender, EventArgs e)
        {
            PNLget.Visible = false;
            PNLshow.Visible = true;
        }
    }
}
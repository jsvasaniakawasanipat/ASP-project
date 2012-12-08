using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.IO;

namespace int422_123b24.Lab3
{
    public partial class Lab3 : System.Web.UI.Page
    {
        string New_Line = Environment.NewLine;
        Lab3FileManager filemanager = new Lab3FileManager();
        
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        protected void UploadButton_Click(object sender, EventArgs e)
        {
            try
            {
                filemanager.UploadFile(ref FileUpload);
                LBLFileUploadMsg.Text = "File Uploaded Successfully.";
                LBLFileUploadMsg.ForeColor = System.Drawing.Color.Green;
            }
            catch(Exception ex)
            {
                LBLFileUploadMsg.Text = ex.Message;
                LBLFileUploadMsg.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void CopyFileButton_Click(object sender, EventArgs e)
        {
            try
            {

                string source = FileListBox.SelectedItem.Text;
                int n1 = source.IndexOf(".");
                string t1 = source.Substring(0,n1);
                
                Response.Write(t1);
                filemanager.CopyFile(source, "int422_123b24");
                LBLFileErrorMsg.Visible = true;
                LBLFileErrorMsg.Text = "File Copied successfully.";
                LBLFileErrorMsg.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                LBLFileErrorMsg.Text = ex.Message;
                LBLFileErrorMsg.ForeColor = System.Drawing.Color.Red;
                LBLFileErrorMsg.Visible = true;
            }
            
        }

        protected void FileListButton_Click(object sender, EventArgs e)
        {
            FileListBox.Items.Clear();
            string list = Server.MapPath("~/uploads");
            FileListBox.Visible = true;
            try
            {
                String[] fl = Directory.GetFiles(list);
                for (int i = 0; i < fl.Length; i++)
                {
                    FileListBox.Items.Add(Path.GetFileName(fl[i]));

                }
            }
            catch (Exception ex)
            {
                FileListBox.Items.Add("There was an error while creating File List.");
                FileListBox.Items.Add(ex.Message);

            }
        }

        protected void FileReadButton_Click(object sender, EventArgs e)
        {
            try
            {
                TBDisplayFile.Text = filemanager.GetFileContents(FileListBox.SelectedItem.Text);
                TBDisplayFile.Visible = true;
            }
            catch (Exception ex)
            {
                LBLFileErrorMsg.Visible = true;
                LBLFileErrorMsg.Text = ex.Message;
            }
        }

        protected void CloseButton_Click(object sender, EventArgs e)
        {
            try
            {

                TBDisplayFile.Text = "";
                TBDisplayFile.Visible = false;
            }
            catch (Exception ex)
            {
                LBLFileErrorMsg.Text = ex.Message;
                LBLFileErrorMsg.Visible = true;
            }
        }

        protected void FileListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void BTNsearch_Click(object sender, EventArgs e)
        {
            try
            {

                TBDisplayFile.Text = filemanager.SearchFileContents(FileListBox.SelectedItem.Text, TBsrch.Text);
                TBDisplayFile.Visible = true;
            }
            catch (Exception ex)
            {
                LBLFileErrorMsg.Text = ex.Message;
                LBLFileErrorMsg.Visible = true;
            }
        }

    }
}
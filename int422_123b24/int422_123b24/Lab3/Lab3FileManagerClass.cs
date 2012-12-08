
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Text;

public class Lab3FileManager
{
    System.Web.HttpApplication _context;
    string New_Line = Environment.NewLine;
    string _uploadFolder;

    public Lab3FileManager()
    {
        _context = System.Web.HttpContext.Current.ApplicationInstance;
        _uploadFolder = _context.Server.MapPath("~/uploads/");
    }
    public List<string> FileList
    {
        // Add your own implementation
        get { return FileList; }
        
    }

    /// <summary>
    /// Upload to the file system
    /// </summary>
    /// <param name="fu">Reference to the file upload web server control</param>
    /// Throws exception if operation was not successful
    public void UploadFile(ref System.Web.UI.WebControls.FileUpload fu)
    {
        // Get the file name of the file to be uploaded
        string fn = fu.FileName;

        // Concat
        string uploadedFile = _uploadFolder + fn;

        // Perform the upload task
        try
        {

            if (fu.FileBytes.Length < 1000)
            {
                throw new fileTooSmall();
            }
            fu.SaveAs(uploadedFile);
            // Store the file name in session state
            _context.Session["uploadedFile"] = uploadedFile;
        }
        catch (Exception ex)
        {

            throw ex;
        }

    } // UploadFile

    /// <summary>
    /// Make a copy of a file in the uploads folder
    /// </summary>
    /// <param name="fileName">Name of the file to be copied</param>
    /// <param name="userName">User name, which will be added to the file copy</param>
    /// Throws exception if operation was not successful
    public void CopyFile(string fileName, string userName)
    {
        try
        {
            string fnm = fileName;
            int ct = fnm.IndexOf(".");
            fnm=fnm.Substring(0,ct);
            StringBuilder INSDATA = new StringBuilder();
            INSDATA.Append("File Copied By :    Jayeshkumar Vasani" + New_Line);
            INSDATA.Append("File Copied Date :  " + DateTime.Now.ToLongDateString() + New_Line);
            INSDATA.Append("File Copied Time :  " + DateTime.Now.ToLongTimeString() + New_Line + New_Line + New_Line);
            string filein = Path.Combine(_uploadFolder, fileName);
            string fileout = Path.Combine(_uploadFolder, fnm + "Copy.txt");
            StreamWriter sw = null;
            string sourcetext = File.ReadAllText(filein);
            sw = File.CreateText(fileout);
            sw.Write(INSDATA.ToString());
            sw.Write(sourcetext.ToString());
            sw.Close();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    /// <summary>
    /// Gets the text contents of a file in the uploads folder
    /// </summary>
    /// <param name="fileName">Name of the desired file</param>
    /// <returns>String value of the file's contents</returns>
    ///Throws exception if operation was not successful
    public string GetFileContents(string fileName)
    {
        try
        {
            string filedata = string.Empty;
            filedata = File.ReadAllText(_uploadFolder + fileName);
            return filedata;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    /// <summary>
    /// Search within a file in the uploads folder
    /// </summary>
    /// <param name="fileName">Name of the file to be searched</param>
    /// <param name="s">Search text</param>
    /// <returns>String of results, formatted for a text box web server control</returns>
    ///Throws exception if operation was not successful
    public string SearchFileContents(string fileName, string searchText)
    {
        try
        {
            List<string> fnd = new List<string>();
            string st=null;
            string line;
            string sf = _uploadFolder + fileName;
            using (var fl = new StreamReader(sf))
            {
                while ((line = fl.ReadLine()) != null)
                {
                    if (line.Contains(searchText))
                    {
                        fnd.Add(line);
                        st = st + New_Line + line;
                    }
                }
            }

            return st;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        //return "";
    }



}
public class fileTooSmall : ApplicationException
{
    public fileTooSmall(string msg = "File must be larger than 1000 bytes")
        : base(msg)
    {
    }
}

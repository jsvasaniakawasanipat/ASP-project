using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Security;
using int422_123b24.Database;
using System.Data;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace int422_123b24.classes
{
    public class manager
    {
        
        public void addRoles(string usr,string role)
        {
            try
            {
                if (usr == null || role == null)
                {
                    throw new FieldsMustNotBeBlank();
                }
                Roles.AddUserToRole(usr, role); // Add user name and its role in to aspnet_userinrole table.
            }
            catch (Exception Ex)
            {
                throw Ex;
            }

        } // end addRoles

        public bool addAuthor(Guid userId, string Username)
        {
            if (userId == null || Username == null)
            {
                throw new FieldsMustNotBeBlank();
            }
            var context = new int422_123b24Entities2(); // create object context of entity
            bool valid = false; // used variable for check error

            try
            {
                //First() means fetch only the first matching record found, if no record is found an exception is thrown
                var check = context.authors.Where(a => a.name == Username).First(); 
            }
            catch
            {
                //if an exception is thrown that means that there is no duplicate record found
                valid = true;
            }
            
            if (valid == false)
            {
                if (context.Connection.State == ConnectionState.Open)
                {
                    context.Dispose();
                }
                throw new IdentityMustBeUnique();
            }
            try
            {
                // Add new author
                context.authors.AddObject(new author() { author_id = userId, name = Username });
                context.SaveChanges();
            }
            catch
            {
                throw;
            }
            finally
            {
                if (context.Connection.State == ConnectionState.Open)
                {
                    context.Dispose();
                }
            }
            return valid;
        }
        public void deleteUser(string usrnm)
        {
            try
            {
                Membership.DeleteUser(usrnm, true);
            }
            catch
            {
                throw;
            }
        }//end userView()
        public void addComment(Guid athr, string stdId, string cntnt, DateTime dt)
        {
            var context = new int422_123b24Entities2();
            if (athr == null || stdId == null || cntnt == null)
            {
                throw new FieldsMustNotBeBlank();
            }
            try
            {
                if (!ckStudent(stdId))
                {
                    addstudent(stdId, "x");
                    //context.students.AddObject(new student() { student_id = stdId, name = "x" });
                }
                if (stdId.Length == 9)
                {
                    if (stdId[0] == '0')
                    {
                        stdId = stdId.Substring(1);
                    }
                    else
                    {
                        throw new StdNumberErr();
                    }
                }
                context.comments.AddObject(new comment() { author_id = athr, student_id = stdId, content = cntnt, created = dt });
                context.SaveChanges();
            }
            catch
            {
                throw;
            }
            finally
            {
                if (context.Connection.State == ConnectionState.Open)
                {
                    context.Dispose();
                }
            }
        }//end addComment
        
        public string viewComment(string stdId,string ord)
        {
            string s1 = string.Empty;
            try
            {
                using (var context = new int422_123b24Entities2())
                {
                    var cmnt = context.comments.Where(s => s.student_id == stdId);
                    if (ord == "Advisor")
                    {
                        cmnt = context.comments.Where(s => s.student_id == stdId).OrderBy(n => n.author.name);
                    }
                    else if (ord == "Date")
                    {
                        cmnt = context.comments.Where(s => s.student_id == stdId).OrderBy(n => n.created);
                    }
                    //s1 = "<div align='left'> Student Number: 0" + stdId + "</div>";
                    s1 = s1 + "<table border='1' width='500px'><tr><th>Comments</th><th>Date</th><th>Advisor</th></tr>";
                    foreach (var cm in cmnt)
                    {
                        s1 += "<tr><td>" + cm.content + "</td><td>" + cm.created + "</td><td>" + cm.author.name + "</td></tr>";
                    }//foreach
                    s1 += "</table>";
                }//using
                return s1;
            }//try
            catch (Exception ex)
            {
                return ex.Message;
            }//catch
        }//viewComment
        public string studentSearch(string stdid)
        {
            string s = string.Empty;
            try
            {
                if (stdid == null || stdid == "")
                {
                    throw new StdNumberEmpty();
                }
                if (stdid.Length == 8 || stdid.Length == 9)
                {
                    if (IsNumeric(stdid))
                    {
                        if (stdid.Length == 9)
                        {
                            if (stdid[0] == '0')
                            {
                                s = viewComment(stdid.Substring(1),"");
                                return s;
                            }
                            else
                            {
                                throw new StdNumberErr();
                            }
                        }

                        if (stdid.Length == 8)
                        {
                            s = viewComment(stdid,"");
                            return s;
                        }
                        return s;
                    }
                    else
                    {
                        throw new StdNumberErr();
                    }
                }
                else
                {
                    throw new StdNumber();
                }

            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }//studentSearch
        public bool IsNumeric(string s)
        {
            try
            {
                foreach (char c in s)
                {
                    if (!char.IsDigit(c) && c != '.')
                    {
                        return false;
                    }
                }
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            return true;
        }
        public bool ckStudent(string st)
        {
            var context = new int422_123b24Entities2(); // create object context of entity
            bool valid = true; // used variable for check error
            try
            {
                if (st == null || st == "")
                {
                    throw new StdNumberEmpty();
                }
                if(IsNumeric(st))
                {
                    if (st.Length == 8 || st.Length == 9)
                    {
                        //c = IsNumeric(stdid);
                        if (st.Length == 9)
                        {
                            if (st[0] == '0')
                            {
                                st = st.Substring(1);
                            }
                            else
                            {
                                throw new StdNumberErr();
                            }
                        }
                    }
                    else
                    {
                        throw new StdNumber();
                    }
                }
                else
                {
                    throw new StdNumberErr();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            try
            {
                //First() means fetch only the first matching record found, if no record is found an exception is thrown
                var check = context.students.Where(a => a.student_id == st).First();
            }
            catch
            {
                //if an exception is thrown that means that there is no duplicate record found
                valid = false;
            }
            return valid;
        }
        public void addstudent(string stdno, string stdnm)
        {
            var context = new int422_123b24Entities2();
            try
            {
                if (stdno == null || stdno == "")
                {
                    throw new FieldsMustNotBeBlank();
                }
                if (IsNumeric(stdno))
                {
                    if (stdno.Length == 8 || stdno.Length == 9)
                    {
                        //c = IsNumeric(stdid);
                        if (stdno.Length == 9)
                        {
                            if (stdno[0] == '0')
                            {
                                stdno = stdno.Substring(1);
                            }
                            else
                            {
                                throw new StdNumberErr();
                            }
                        }
                    }
                    else
                    {
                        throw new StdNumber();
                    }
                }
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            try
            {
                context.students.AddObject(new student() { student_id = stdno, name = stdnm});
                context.SaveChanges();
            }
            catch(Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (context.Connection.State == ConnectionState.Open)
                {
                    context.Dispose();
                }
            }
        }
        public string viewAllComments()
        {
            string s1 = string.Empty;
            try
            {
                using (var context = new int422_123b24Entities2())
                {
                    var cmnt = context.comments;
                    //s1 = "<div align='left'> Student Number: 0" + stdId + "</div>";
                    s1 = s1 + "<table border='1' width='500px'><tr><th>Student ID</th><th>Comments</th><th>Date</th><th>Advisor</th></tr>";
                    foreach (var cm in cmnt)
                    {
                        s1 += "<tr><td>" + cm.student_id + "</td><td>" + cm.content + "</td><td>" + cm.created + "</td><td>" + cm.author.name + "</td></tr>";
                    }//foreach
                    s1 += "</table>";
                }//using
                return s1;
            }//try
            catch (Exception ex)
            {
                return ex.Message;
            }//catch
        }
            
    }
    public class StdNumberEmpty : ApplicationException
    {
        public StdNumberEmpty(string msg = "Please Enter Student Number or Select Student Number.")
            : base(msg)
        {
        }
    }
    public class StdNumberErr : ApplicationException
    {
        public StdNumberErr(string msg = "Please Enter Valid Student Number.")
            : base(msg)
        {
        }
    }
    public class StdNumber : ApplicationException
    {
        public StdNumber(string msg = "Student Number must be 8 or 9 character Long.")
            : base(msg)
        {
        }
    }
    public class FieldsMustNotBeBlank : ApplicationException
    {
        public FieldsMustNotBeBlank(string msg = "All fields must be filled in.")
            : base(msg)
        {
        }
    }
    public class UserNameNotBeBlank : ApplicationException
    {
        public UserNameNotBeBlank(string msg = "User Name fields must be filled in.")
            : base(msg)
        {
        }
    }
    public class PasswardNotBeBlank : ApplicationException
    {
        public PasswardNotBeBlank(string msg = "Passward fields must be filled in.")
            : base(msg)
        {
        }
    }
    public class LoginError : ApplicationException
    {
        public LoginError(string msg = "User Name or Passward not valid.")
            : base(msg)
        {
        }
    }
    public class IdentityMustBeUnique : ApplicationException
    {
        //call base constructor and pass a message
        //user can pass a new message or allow the default to be passed
        public IdentityMustBeUnique(string msg = "User ID must be unique")
            : base(msg)
        {
        }

    }
    public class IdentityMustExist : ApplicationException
    {

        public IdentityMustExist(string msg = "ID must exist")
            : base(msg)
        {
        }

    }

}


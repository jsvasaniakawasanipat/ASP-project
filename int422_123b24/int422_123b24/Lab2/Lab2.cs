using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab2.classes
{
    [Serializable]

    public class Person
    {
        protected string _FirstName;
        protected string _LastName;

        public Person()
        {
            FirstName = string.Empty;
        }
        public Person(string fnm, string lnm)
        {
            FirstName = fnm;
            LastName = lnm;
        }

        public string getInfo()
        {
            return FirstName + " " + LastName;
        }
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }
    }

    [Serializable]
    public class SenecaStudent : Person
    {
        public string Email { get; set; }
        public string StID { get; set; }
        public string Cource { get; set; }
        public string Sem { get; set; }

        public SenecaStudent()
        {
            Email = string.Empty;
            StID = string.Empty;
            Cource = string.Empty;
            Sem = string.Empty;
        }

        public SenecaStudent(string fnmIn, string lnmIn, string emailIn, string stidIn, string cource, string seme)
            : base(fnmIn, lnmIn)
        {
            Email = emailIn;
            StID = stidIn;
            Cource = cource;
            Sem = seme;
        }

        public new string getInfo()
        {
            return "First Name : " + FirstName + ", Last Name : " + LastName + ", Email Address: " + Email + ", Student ID: " + StID + ", Cource:  " + Cource + ",  Semester: " + Sem;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project.Business_Logic_Layer
{
    internal class Applicant
    {
        public int ApplicantID { get; }
        public string SAIdNumber { get; }
        public string FirstName { get; }
        public string Surname { get; }
        public string Course { get; }
        public string Email { get; }
        public string Gender { get; }
        public string DocumentPath { get; }

        public Applicant(int applicantID, string saIdNumber, string firstName, string surname, string course, string email, string gender, string documentPath)
        {
            ApplicantID = applicantID;
            SAIdNumber = saIdNumber;
            FirstName = firstName;
            Surname = surname;
            Course = course;
            Email = email;
            Gender = gender;
            DocumentPath = documentPath;
        }
    }
}

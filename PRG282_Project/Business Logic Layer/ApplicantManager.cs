using PRG282_Project.Data_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project.Business_Logic_Layer
{
    internal class ApplicantManager
    {
        private ApplicantDataAccess dataAccess;

        public ApplicantManager()
        {
            dataAccess = new ApplicantDataAccess();
        }

        public void AddApplicant(string saIdNumber, string firstName, string surname, string course, string email, string gender, string documentPath)
        {
            int applicantId = GenerateUniqueApplicantId();
            Applicant applicant = new Applicant(applicantId, saIdNumber, firstName, surname, course, email, gender, documentPath);
            dataAccess.SaveApplicant(applicant);
        }

        private int GenerateUniqueApplicantId()
        {
            return dataAccess.GetNextApplicantId();
        }

        
    }
}

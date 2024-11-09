using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project.Presentation_Layer.Applicant
{
    public class QuizResult
    {
        public string ApplicantID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SAID { get; set; }
        public string Gender { get; set; }
        public string Course { get; set; }
        public string Email { get; set; }
        public string DocumentPath { get; set; }
        public int Score { get; set; }
        public int TotalQuestions { get; set; }
        public double Percentage { get; set; }
        public string Module { get; set; }
        public DateTime QuizDate { get; set; }
        
    }
}

using PRG282_Project.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG282_Project.Presentation_Layer.Applicant;

namespace PRG282_Project.Data_Layer
{
    public class ApplicantDataAccess
    {

        //public string fileName = @"C:\Users\taylo\Documents\PRG282\PRG282_Project\bin\Debug\Applicant.txt";
        //public string fileName = @"C:\Users\User\OneDrive\Desktop\PRG_Project\Applicant.txt";
        public string fileName = @"Applicant.txt";

        public void SaveApplicant(PRG282_Project.Business_Logic_Layer.Applicant applicant)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                
                writer.WriteLine($"{applicant.ApplicantID},{applicant.SAIdNumber},{applicant.FirstName}," +
                                 $"{applicant.Surname},{applicant.Course},{applicant.Email}," +
                                 $"{applicant.DocumentPath},0");
            }

            ApplicantQuiz quiz = new ApplicantQuiz(applicant.ApplicantID);
            quiz.currentApplicantID = applicant.ApplicantID; 

            quiz.ReadApplicant(applicant.ApplicantID);
            quiz.WriteApplicant(applicant.ApplicantID);
            quiz.FinishQuiz(applicant.ApplicantID);

        }

        public int GetNextApplicantId()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            int nextId = 1; 

            if (File.Exists(filePath))
            {
                var existingRecords = File.ReadAllLines(filePath)
                                          .Where(line => !string.IsNullOrWhiteSpace(line)) 
                                          .Select(line =>
                                          {
                                              string[] parts = line.Split(',');
                                              if (parts.Length > 0 && int.TryParse(parts[0], out int id))
                                              {
                                                  return id;
                                              }
                                              return -1; 
                                          })
                                          .Where(id => id != -1) 
                                          .ToList();

                if (existingRecords.Count > 0)
                {
                    nextId = existingRecords.Max() + 1;
                }
            }

            return nextId;
        }
    }
}

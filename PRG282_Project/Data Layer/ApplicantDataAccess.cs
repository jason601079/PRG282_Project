using PRG282_Project.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project.Data_Layer
{
    internal class ApplicantDataAccess
    {
       
        //public string fileName = @"C:\Users\taylo\Documents\PRG282\PRG282_Project\bin\Debug\Applicant.txt";
        public string fileName = @"C:\Users\User\OneDrive\Desktop\Project_Prg282\Applicant.txt";


        public void SaveApplicant(Applicant applicant)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
               
                writer.WriteLine($"{applicant.ApplicantID},{applicant.SAIdNumber},{applicant.FirstName},{applicant.Surname},{applicant.Course},{applicant.Email},{applicant.DocumentPath}");
            }
        }

        public int GetNextApplicantId()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            int nextId = 1; 

           
            if (File.Exists(filePath))
            {
                var existingRecords = File.ReadAllLines(filePath);
                if (existingRecords.Length > 0)
                {
                    nextId = existingRecords
                        .Select(line => int.Parse(line.Split(',')[0])) 
                        .Max() + 1; 
                }
            }

            return nextId;
        }




    }
}

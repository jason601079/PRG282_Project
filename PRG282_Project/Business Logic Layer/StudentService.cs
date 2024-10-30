using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project.Business_Logic_Layer
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly string _connectionString = @"Server=ANDYDEE\SQLEXPRESS;Database=Student Management System;Trusted_Connection=True;";

        public StudentService()
        {
            _studentRepository = new DatabaseHelper(_connectionString);
        }

        public void AddStudent(Student student)
        {
            // Generate a unique student number
            string lastStudentNumber = _studentRepository.GetLastStudentNumber();
            student.StudentNumber = GenerateNextStudentNumber(lastStudentNumber);

            // Validate other properties if necessary
            if (string.IsNullOrWhiteSpace(student.FirstName) || string.IsNullOrWhiteSpace(student.LastName))
            {
                throw new ArgumentException("First name and last name are required.");
            }

            // Call the data layer to insert the student
            _studentRepository.InsertStudent(student);
        }

        private string GenerateNextStudentNumber(string lastStudentNumber)
        {
            if (string.IsNullOrEmpty(lastStudentNumber))
            {
                return "S001"; // Start from S001 if no records exist
            }

            // Extract the numeric part, increment, and format with leading zeros
            int numericPart = int.Parse(lastStudentNumber.Substring(1)) + 1;
            return "S" + numericPart.ToString("D3");
        }
    }
}

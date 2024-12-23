﻿using System;
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
        //private readonly string _connectionString = @"Server=TRENT\SQLEXPRESS;Database=Student Management System;Trusted_Connection=True;";
       // private readonly string _connectionString = @"Data Source=RYZEN01\SQLEXPRESS;Initial Catalog=""Student Management System"";Integrated Security=True;Encrypt=False";

        public StudentService()
        {
            _studentRepository = new DatabaseHelper(_connectionString);
        }

        public void AddStudent(Student student)
        {
            try
            {
                string lastStudentNumber = _studentRepository.GetLastStudentNumber();
                student.StudentNumber = GenerateNextStudentNumber(lastStudentNumber);


                if (string.IsNullOrWhiteSpace(student.FirstName) || string.IsNullOrWhiteSpace(student.LastName))
                {
                    throw new ArgumentException("First name and last name are required.");
                }

                // Call the data layer to insert the student
                _studentRepository.InsertStudent(student);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        public string GenerateNextStudentNumber(string lastStudentNumber)
        {
            if (string.IsNullOrEmpty(lastStudentNumber))
            {
                return "S001"; 
            }

           
            int numericPart = int.Parse(lastStudentNumber.Substring(1)) + 1;
            return "S" + numericPart.ToString("D3");
        }

        public void DeleteStudent(string studentNumber)
        {
            if (string.IsNullOrWhiteSpace(studentNumber))
            {
                throw new ArgumentException("Student number is required.");
            }

            // Call the data layer to delete the student
            _studentRepository.DeleteStudent(studentNumber);
        }

        public void UpdateStudent(Student student)
        {
            _studentRepository.UpdateStudent(student);
        }
    }
}

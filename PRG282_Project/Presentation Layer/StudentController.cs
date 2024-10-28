using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PRG282_Project.Presentation_Layer
{
    public class StudentController
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        // Method to add a student
        public void AddStudent(string studentName, int studentAge, string course)
        {
            try
            {
                // Call the service to add the student
                _studentService.AddStudent(studentName, studentAge, course);

                // Optionally, you can provide feedback
                MessageBox.Show("Student added successfully!");
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may arise
                MessageBox.Show($"Error adding student: {ex.Message}");
            }
        }

        // Additional methods for managing students can be added here
    }

}

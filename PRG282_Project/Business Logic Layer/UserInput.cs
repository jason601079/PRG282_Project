using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project.Presentation_Layer
{
    internal class UserInput : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public UserInput(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository ?? throw new ArgumentNullException(nameof(studentRepository));
        }

        public void AddStudent(string studentName, int studentAge, string course)
        {
            // Call the data layer method to insert the student
            _studentRepository.InsertStudent(studentName, studentAge, course);
        }

        public bool DeleteStudent(string studentId)
        {

            try
            {
                // Attempt to delete the student via the repository
                _studentRepository.DeleteStudent(studentId);

                // If no exceptions occur, assume deletion was successful
                return true;
            }
            catch (Exception)
            {
                // If there's an error (e.g., student ID not found), return false
                return false;
            }
        }
    }
}

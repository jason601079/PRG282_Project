using PRG282_Project.Presentation_Layer;
using System;
using System.Windows.Forms;

namespace PRG282_Project
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();
            // Define your connection string
            string connectionString = @"Server=ANDYDEE\SQLEXPRESS;Database=Student Management System;Trusted_Connection=True;"; ; // Replace with your actual connection string

            // Create an instance of your student repository with the connection string
            IStudentRepository studentRepository = new DatabaseHelper(connectionString); // Pass the connection string

            // Create an instance of UserInput, passing the student repository
            IStudentService studentService = new UserInput(studentRepository);
            Application.Run(new Loading_Screen(studentService));
        }
    }
}
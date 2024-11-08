using PRG282_Project.Business_Logic_Layer;
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

            
            
            IStudentService studentService = new StudentService();



            //Application.Run(new Loading_Screen(studentService));

            

            Application.Run(new Login());
            //Application.Run(new ApplicantViewer());
            //Application.Run(new ApplicantForm());
            //Application.Run(new Home());
            

        }
    }
}
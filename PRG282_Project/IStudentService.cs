using PRG282_Project.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project
{
    public interface IStudentService
    {
        void AddStudent(Student student);
        void DeleteStudent(string studentNumber);

        void UpdateStudent(Student student);
    }
}


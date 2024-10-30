using PRG282_Project.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project
{
    public interface IStudentRepository
    {
        void InsertStudent(Student student);
        string GetLastStudentNumber();
    }
}

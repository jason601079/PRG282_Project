using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project
{
    public interface IStudentRepository
    {
        void InsertStudent(string studentName, int studentAge, string course);

        bool DeleteStudent(string studentId);
    }
}

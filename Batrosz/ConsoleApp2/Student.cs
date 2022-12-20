using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Student
    {
        public int studentNumber;
        public int averageMark;
        public bool isEligableToEnroll(string a)
        {
            return true;
        }
        public int getSeminarsTaken()
        {
            return 3;
        }
    }
}
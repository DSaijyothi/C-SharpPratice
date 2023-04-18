
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPratice
{
    internal class MultilevelInheritance
    {
        protected string RollNo = "116";
        protected string name = "Jyothi";
        public void shampain()
        {
            Console.WriteLine("RollNo :{0}", RollNo);
            Console.WriteLine("Name :{0}", name);
            Console.WriteLine();
        }
        }
    class student: Person
    {
        public string id = "something";
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Student ID:{0}", id);
        }
    }
    class stud: Student
    {
        private string StudentAddress = "LONDON UK";
        public void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Student Address :{0}", StudentAddress);

        }
    }
    class TestClass
    {
        public static void main()
        {
            student E= new student();
            E.GetInfo();
            stud stud = new stud();
            Console.WriteLine();
        }
    }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPratice
{
    public class MultilevelInheritance
    {
        protected string RollNo = "116";
        protected string name = "Jyothi";
        public virtual void GetInfo()
        {
            Console.WriteLine("RollNo :{0}", RollNo);
            Console.WriteLine("Name :{0}", name);
            Console.WriteLine();
        }
        }
    class Student: MultilevelInheritance
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
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Student Address :{0}", StudentAddress);

        }
    }
    class TestClass
    {
        public static void main()
        {
            MultilevelInheritance E= new MultilevelInheritance();
            E.GetInfo();
            stud stud = new stud();
            Console.WriteLine();
        }
    }
    }

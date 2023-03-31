using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Pratice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Enter the number");
            i=int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("Enter the even number");
                Console.Read();
            }
            else
            {
                Console.Write("Enter the odd number");
                    
                    Console.Read();
                }
            }

        }
    }

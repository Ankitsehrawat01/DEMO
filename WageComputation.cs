using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public class WageComputation
    {
        public static void EmpWage()
        {
            int Is_Present = 1;
            Random randomobj = new Random();
            int empCheck = randomobj.Next(0, 2);
            if (empCheck == Is_Present)
            {
                Console.WriteLine("Emloyee is Present");
                
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                
            }
        }
    }
}

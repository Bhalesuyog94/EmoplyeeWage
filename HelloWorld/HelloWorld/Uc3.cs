using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class UC3
    {
        public static void ParttimeEmpolyewage()
        {
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_PART_PER_HOURS = 20;
            int empHrs = 0;
            int empwage = 0;
            Random random = new Random();   
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_PART_TIME)
            {
                empHrs = 4;
            }
            else if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empwage = empHrs * EMP_PART_PER_HOURS;
            Console.WriteLine("Emp Wage :" + empwage);
            Console.ReadKey();
        }

    }
}

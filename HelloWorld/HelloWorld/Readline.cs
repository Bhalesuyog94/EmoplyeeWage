using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Readline
    {
        public void Showdatatype()
        {
            int a = 10;
            string name = "Suyog";
            double per = 3.45;
            Console.WriteLine(a);
            Console.WriteLine(name);
            Console.WriteLine(per);

        }
        public void Showdatatype2()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }


        }
        public void Showdatatype3(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);

        }
    }
}

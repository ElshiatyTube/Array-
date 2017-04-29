using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            //array
            //first: direct inetchalize
            string[] name = { "Youssef", "Hany", "Ahmed", "Mohamed","Elshiaty" };
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(name[i]);
            }
            
            //secound: Make it full
            string[] _name = new string[5];
            name[0] = "Youssef";
            name[1] = "Hany";
            name[2] = "Ahmed";
            name[3] = "Mohamed";
            name[4] = "Elshiaty";
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine(name[j]);
            }
            Console.ReadKey();



        }
    }
}

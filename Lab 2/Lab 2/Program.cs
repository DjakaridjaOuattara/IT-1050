using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("[Enter the First Couple's Information ]");
            System.Console.WriteLine("");

            Person p1 = new Person();
            p1.AskUserForNameAndAge();


            System.Console.WriteLine("");
            System.Console.WriteLine("[Enter the Second Couple's Information]");
            System.Console.WriteLine("");

            Person p2 = new Person();
            p2.AskUserForNameAndAge();

            System.Console.WriteLine("");
            System.Console.WriteLine("[Print Results]" + "");
            System.Console.WriteLine("");

            p1.PrintNameAndAge() ;
            p2.PrintNameAndAge();
           



            System.Console.WriteLine("Average Age = " + Person.AverageAge());
            System.Console.ReadKey();
        }
    }
}

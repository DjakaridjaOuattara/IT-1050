using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Middle Initial: ");
            char middleInitial = char.Parse(Console.ReadLine());

            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            string fullName = firstName + " " + middleInitial + ". " + lastName;

            Console.Write("Heigh in feet: ");
            int heightFeet = int.Parse(System.Console.ReadLine());

            Console.Write("Inches bayond based height in feet: ");
            double heightInches = double.Parse(Console.ReadLine());

            double totalHeightCM = (heightInches + (heightFeet * 12)) * 2.54;

            Console.Write("Age: ");
            int age = int.Parse(System.Console.ReadLine());

            System.Console.Write("Are you citizen? if yes answer true, if no answer false: ");
            bool isCitizen = bool.Parse(System.Console.ReadLine());
            bool canVote = isCitizen && age >= 18;

            Console.WriteLine(fullName);
            Console.WriteLine(totalHeightCM);
            Console.WriteLine(canVote);


            System.Threading.Thread.Sleep(100000);
        }
    }
}

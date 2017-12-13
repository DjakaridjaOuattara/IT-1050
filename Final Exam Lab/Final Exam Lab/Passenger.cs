using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam_Lab
{
    class Passenger
    {
        private string Name;
        private double Weight;

        public Passenger(string name, double weight)
        { Name = name; Weight = weight; }

        public string Getname()
        {
            return Name;
        }
        public double Getweight()
        {
            return Weight;
        }



    }
}

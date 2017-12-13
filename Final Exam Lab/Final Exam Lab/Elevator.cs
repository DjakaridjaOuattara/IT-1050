using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam_Lab
{
    class Elevator
    {
        private double MaxWeight;
        private Passenger[] Occupants;
        private double SumOfWeights = 0;

        public Elevator(int maxOccupants, double maxWeight)
        {
            Occupants = new Passenger[maxOccupants];
            MaxWeight = maxWeight;
        }

        public void AddOccupant(Passenger passenger, int index)
        { Occupants[index] = passenger; }

        public double GetCurrentWeight()
        {
            for (int i = 0; i < Occupants.Length; i++)
            { SumOfWeights += Occupants[i].Getweight(); }
            return SumOfWeights;
        }


        public bool IsOverMaxcapaicty()
        {
            if ( MaxWeight < GetCurrentWeight()) { return true; }
            else { return false; }
        }
    }
}

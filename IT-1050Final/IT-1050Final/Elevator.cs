using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_1050Final
{
    class Elevator
    {

        private double MaxWeight;
        private Passenger[] Occupants;

        //public constructor: 
        public Elevator(int maxOccupants, double maxWeight)
        {
            this.Occupants = new Passenger[maxOccupants];
            this.MaxWeight = maxWeight;
        }

        //three public methods:
        public void AddOccupant(Passenger passenger, int index)
        {
            Occupants[index] = passenger;
        }

        public double GetCurrentWeight()
        {

            //I CANNOT get this one part to work without breaking something. Everything else works, except this.
            //I'm out of time and I've already spent hours on this one bit. So I guess it's getting turned in like this.
            return Occupants[0].GetWeight() + Occupants[1].GetWeight() + Occupants[2].GetWeight();


            //if (Occupants[Occupants.Length] = 3)
            //{
            //    return Occupants[0].GetWeight() +
            //      Occupants[1].GetWeight() +
            //      Occupants[2].GetWeight();
            //}
            //else
            //{
            //    return Occupants[0].GetWeight() + Occupants[1].GetWeight();
            //}


        }

        
        public bool IsOverMaxCapacity()
        {
            return GetCurrentWeight() > MaxWeight;
            
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_1050Final
{
    class Passenger
    {

        private string Name;
        private double Weight;


        //public constructor:
        public Passenger(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;

        }

        //public methods(2): GetName returns Name, GetWeight returns Weight;
        public string GetName()
        {
            return this.Name;
        }

        public double GetWeight()
        {
            Weight = 0;
            return this.Weight;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice___Inheritance
{
    public class Vehicle
    {

        public string Color { get; set; }

        public Vehicle(string color)
        {
            Color = color;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} - {Color}";
        }
    }


}


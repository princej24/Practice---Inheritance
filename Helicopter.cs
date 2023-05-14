using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice___Inheritance
{
    public class Helicopter : Air
    {
        private int _numberOfPropellers;

      
        public int NumberOfPropellers { get => _numberOfPropellers; set => _numberOfPropellers = value; }

        public Helicopter(string color, int numberOfPropellers) : base(color)
        {
            NumberOfPropellers = numberOfPropellers;
        }

        public override string ToString()
        {
            return $"{base.ToString()} - Number of Propelers {_numberOfPropellers}";
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice___Inheritance
{
    public class Sea : Vehicle
    {
        private string _type;



        public string Type { get => _type; set => _type = value; }

        public Sea(string color, string type) : base(color)
        {
            Type = type;
        }

        public override string ToString()
        {
            return $"{base.ToString()} - It is a {Type}";
        }
    }
}

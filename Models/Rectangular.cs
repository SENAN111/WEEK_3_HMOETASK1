using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12.Models
{
    internal class Rectangular:Figure
    {
        public float _width;
        public float _lenght;
        public float Weight
        {
            get { return _width; }
            set { if (value >= 0) _width = value; }
        }
        public float Lenght
        {
            get { return _lenght; }
            set { if (value >= 0) _lenght = value; }
        }
        public Rectangular(float weight , float lengt)
        { 
            Weight= weight;
            Lenght= lengt;
        }
        public override void CalcArea()
        {
            float t = Weight * Lenght;
            Console.WriteLine(t);
        }
        
    }
}

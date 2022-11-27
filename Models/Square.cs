using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12.Models
{
    internal class Square : Figure
    {
        public float _side;
        public float Side
        {
            get { return _side; }
            set { if (value > 0) _side = value; }
        }
        public  Square(float side)
            { Side= side; }
        public override void CalcArea()
        {
            float c = Side * Side;
            Console.WriteLine(c);
        }
    } 

}


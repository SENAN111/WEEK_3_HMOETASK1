using ConsoleApp12.Models;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\t\t MENYU");
            Console.WriteLine("1) Square \n2) Rectangular\n3) Quit");
            string opition = Console.ReadLine();
            bool result = true;
            while (result)
            {
                switch (opition)
                {
                    case "1":
                        Square square = new Square(6f);
                        square.CalcArea();
                        result = false;
                        break;
                    case "2":
                        Rectangular rectangular = new Rectangular(6f, 1.5f);
                        rectangular.CalcArea();
                        result = false;
                        break;
                    case "3":
                        return;


                }
            }
        }
    }
}
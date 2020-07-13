using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var cont = " ";

                do
                {

                    Console.WriteLine("Enter Length:");
                    double length = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Width:");
                    double width = double.Parse(Console.ReadLine());

                    double area = length * width;
                    double perimeter = 2 * (length + width);

                    Console.WriteLine("Area: {0}", area);
                    Console.WriteLine("Perimeter: {0}", perimeter);

                    Console.WriteLine("Do you want to calculate another room? (Y/N)");
                    cont = Console.ReadLine().ToUpper();
                }
                while (cont == "Y");
            }
        }
    }
}
            
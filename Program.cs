using System.Diagnostics.Metrics;

namespace Assignment_3._1._4
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Lets identify which quandrant the coordinate is in." +
                    "\n\tEnter the x cordinate:");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\tEnter the y cordinate:");
                double y = Convert.ToDouble(Console.ReadLine());

                if (x > 0 && y > 0)
                {
                    Console.WriteLine($"The coordinate point ({x},{y}), lies in the First Quandrant.");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine($"The coordinate point ({x},{y}), lies in the Second Quandrant.");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine($"The coordinate point ({x},{y}) lies in the Third Quandrant.");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine($"The coordinate point ({x},{y}) lies in the Forth Quandrant.");
                }
                else if (x == 0 && y > 0 || y < 0 )
                {
                    Console.WriteLine($"The coordinate point ({x},{y}) lies on Y axis.");
                }
                else if (y == 0 && x > 0 || x < 0)
                {
                    Console.WriteLine($"The coordinate point ({x},{y}) lies on X axis.");
                }
                else
                {
                    Console.WriteLine($"The coordinate point ({x},{y}) lies on the origin.");
                }
                
                Console.WriteLine("\nDo you want to enter another coordinate? (Y/N):");
            } 

                while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("\t\t\t\tThis is the end of the code");



        }
    }
        
    
}

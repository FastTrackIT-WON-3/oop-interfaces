using System;

namespace OopInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = AreaCalculator.SumAreas(
                new Rectangle(10, 20),
                new SheetOfPaper(SheetOfPaperFormat.A3));
            Console.WriteLine(sum);
        }
    }
}

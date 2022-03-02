using System;

namespace OopInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(new Point(10, 10), 10, 20);
            SheetOfPaper s = new SheetOfPaper(SheetOfPaperFormat.A3);
            double sum = AreaCalculator.SumAreas(r, s);
            Console.WriteLine(sum);

            GeometryUtils.TranslateObjects(100, 150, r, s);
        }
    }
}

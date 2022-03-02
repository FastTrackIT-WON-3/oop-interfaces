using System;

namespace OopInterfaces
{
    public class SheetOfPaper : IObjectWithArea, ITranslatableObject
    {
        public SheetOfPaper(SheetOfPaperFormat format)
        {
            Format = format;
            switch (format)
            {
                case SheetOfPaperFormat.A0:
                    Area = 100;
                    break;
                case SheetOfPaperFormat.A1:
                    Area = 50;
                    break;
                case SheetOfPaperFormat.A2:
                    Area = 20;
                    break;
                case SheetOfPaperFormat.A3:
                    Area = 10;
                    break;
                case SheetOfPaperFormat.A4:
                    Area = 5;
                    break;
            }
        }

        public SheetOfPaperFormat Format { get; }

        public double Area { get; }

        public void Translate(int dx, int dy)
        {
            Console.WriteLine($"Hey, the sheet of paper is moving with ({dx}, {dy})");
        }
    }
}

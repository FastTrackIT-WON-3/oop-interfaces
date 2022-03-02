using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopInterfaces
{
    public interface IObjectWithArea
    {
        double Area { get; }
    }

    public abstract class Shape : IObjectWithArea
    {
        public abstract double Area { get; }
    }

    public class Rectangle : Shape
    {
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Height { get; }

        public int Width { get; }

        public override double Area
        {
            get
            {
                return Width * Height;
            }
        }
    }

    public class SheetOfPaper : IObjectWithArea
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
    }

    public enum SheetOfPaperFormat
    {
        A0 = 0,
        A1,
        A2, 
        A3,
        A4
    }

    public static class AreaCalculator
    {
        public static double SumAreas(params IObjectWithArea[] objects)
        {
            double sum = 0;
            foreach(IObjectWithArea obj in objects)
            {
                sum += obj.Area;
            }

            return sum;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopInterfaces
{
    public ref struct PointAsStruct
    {
        public PointAsStruct(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; private set; }

        public int Y { get; private set; }

        public readonly void Print()
        {
            Console.WriteLine($"Point coordinates: [{X}, {Y}]");
        }

        public void Translate(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }
    }
}

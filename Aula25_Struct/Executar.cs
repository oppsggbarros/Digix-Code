using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula25_Struct
{
    public class Executar
    {
        public struct Point
        {
            public int X { get; set; }
            public int Y { get; set; }

        
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
            public double Distancia(Point p)
            {
                // X = 20;
                return Math.Sqrt(Math.Pow(p.X - X, 2)
                + Math.Pow(p.Y - Y, 2));
            }
            public class Player
            {
                public string Name { get; set; }
                public Point Position { get; set; }
                public
            }
        }
    }
}
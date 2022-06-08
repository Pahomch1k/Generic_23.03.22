using System;

namespace Lb_9_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Line<int> L = new Line<int>(5,10,11,13);
            Console.WriteLine(L.ToString()); 
        }
    }

    class Point<T>
        where T : struct 
    {
        public T x;
        public T y;
        public string name { get; set; }

        public Point()
        {
            name = "";
            x = new T();
            y = new T(); 
        }

        public Point(T t, T v, string n)
        {
            name = n;
            x = t;
            y = v;
        }

    }

    class Line<T> 
        where T : struct  
    { 
        Point<T> point1;
        Point<T> point2;

        public Line()
        {
            point1 = new Point<T>();
            point2 = new Point<T>();
        }
        public Line(T x, T y, T x2, T y2)
        {
            point1 = new Point<T>(x, y, "A");
            point2 = new Point<T>(x2, y2, "B");
        }

        public override string ToString()
        {
            string n;
            n = "Координаты 1 точки\n1 - " + point1.x + " 2 - " + point1.y + "\n";
            n += "Координаты 2 точки\n1 - " + point2.x + " 2 - " + point2.y + "\n";

            return n;
        }
    } 
}

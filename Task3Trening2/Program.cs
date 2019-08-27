using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3Trening2
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure();
            figure.Draw();

            Rectangle rectangle = new Rectangle();
            rectangle.Draw();

            Square square = new Square();
            square.Draw();

            Console.ReadKey();
        }

        public class Figure
        {
            public virtual void Draw()
           {
              Console.WriteLine("Це метод з классу Figure");
           }
        }
        public class Square : Figure
        {
            public override void Draw()
            {
                Console.WriteLine("Це метод з Square классу");
            }
        }
        public class Rectangle : Figure
        {
            public override void Draw()
            {
                Console.WriteLine("Це метод з Rectanle классу");
            }
        }
    }
}

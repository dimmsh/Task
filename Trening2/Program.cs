using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trening2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Draw();

            Square square = new Square();
            square.Draw();

            Console.ReadKey();
        }

        public abstract class Figure
        {
            public abstract void Draw();
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



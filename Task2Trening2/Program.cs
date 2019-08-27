using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2Trening2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(1, 5, 7);
            rectangle.Display();

            rectangle.Draw();

            Square square = new Square(5, 10, 6 );
            square.Display();
            square.Draw();

            Console.ReadKey();
        }

        public abstract class Figure
        {
            public int X { get; set;  }

            public int Y { get; set; }
            
            public Figure(int x, int y)
            {
                X = x;
                Y = y;
            } 

            public abstract void Draw();
            public void Display()
            {
                Console.WriteLine(X);
                Console.WriteLine(Y);
            }
        }
        public class Square : Figure
        {
            public int Sum { get; set; }

            public Square(int x, int y, int sum) : base ( x, y) 
            {
                Sum = sum;
            }
            public override void Draw()
            {
                Console.WriteLine("Це метод з Square классу");
            }
        }
        public class Rectangle : Figure
        {
            public int Position { get; set; }

            public Rectangle(int x, int y, int position) : base ( x, y) 
            {
                Position = position;
            }
            public override void Draw()
            {
                Console.WriteLine("Це метод з Rectanle классу");
            }
        }
    }
}

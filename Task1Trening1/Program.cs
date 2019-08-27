using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1Trening1
{
    class Rectangle
    {
        double a;
        double b;
        double x;
        double y;
        public Rectangle(double a = 0, double b = 0, double x = 0, double y = 0)
        {
            this.a = a;
            this.b = b;
            this.x = x;
            this.y = y;
        }
        public double Perimetr()
        {
            double perimeter = a * 2 + b * 2;
            return perimeter;
        }
       /* public double Diagonal()
        {
            double diagonal = Math.Sqrt(a * a + b * b);
            return diagonal;
        }
        */
        public static Rectangle operator -(Rectangle opr1, Rectangle opr2)
        {
            Rectangle rec = new Rectangle();
            rec.x = opr1.x - opr2.x;
            rec.y = opr1.y - opr2.y;
            rec.a = opr1.a - opr2.a;
            rec.b = opr1.b - opr2.b;
            Console.WriteLine(rec.x);
            Console.WriteLine(rec.y);
            Console.WriteLine(rec.a);
            Console.Write(rec.b);
            return rec;

        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Введите число a:");
                double a = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Введите число b :");
                double b = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Введите точку x:");
                double x = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Введите точку y");
                double y = Int32.Parse(Console.ReadLine());
                Rectangle rect = new Rectangle(a, b, x, y);
                Console.WriteLine("Периметр = {0}", rect.Perimetr());
               // Console.WriteLine("Длина диагонали = {0}", rect.Diagonal());
                Rectangle rectr = new Rectangle(2, 5, 3, 9);
                Rectangle rectr2 = new Rectangle(8, 4, 5, 1);
                rectr2 = rectr - rectr2;
                Console.ReadKey();
            }
        }

    }
}



// абстрактный класс фигуры
/*abstract class Figure
{
    // абстрактный метод для получения периметра
    public abstract float Perimeter();
    // абстрактный метод для получения площади
    public abstract float Area();
}
// производный класс прямоугольника
class Rectangle : Figure
{
    public float Width { get; set; }
    public float Height { get; set; }

    public Rectangle(float width, float height)
    {
        this.Width = width;
        this.Height = height;
    }
    // переопределение получения периметра
    public override float Perimeter()
    {
        return Width * 2 + Height * 2;
    }
    // переопрелеление получения площади
    public override float Area()
    {
        return Width * Height;
    }
}
*/
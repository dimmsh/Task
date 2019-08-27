using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                // Console.WriteLine("Введіть координати точки А: ");
                // str1 = Console.ReadLine();

                // Console.WriteLine("Введіть координати точки D: ");
                // str2 = Console.ReadLine();

                // Console.WriteLine("Площа прямокутника дорівнює: " + res);

                Rectangle rect = new Rectangle();

                rect.a = 2;
                rect.b = 6;
                rect.c = 4;
                rect.d = 12;

                rect.areaPrjam();

                Console.ReadLine();
            }
        }
        public class Rectangle
        {
            public double a; //координати верхнього лівого  кута
            public double b; //координати  лівого  кута
            public double c; //координати правого нижього  кута
            public double d; //координати верхнього лівого верхнього кута

            public void areaPrjam()
            {
                Console.WriteLine("Площа прямокутника" + a * b);
            }
             
        }
    }
}       

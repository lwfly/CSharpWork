using System;
using System.Collections.Generic;
using System.Text;

namespace week3
{
    interface Graphical
    {
        double Area { get; }
        bool isLegal();
    }

    class Rectangle : Graphical
    {
        public double width
        {
            set;
            get;
        }
        public double height
        {
            set;
            get;
        }
        public double Area => width * height;
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
            Console.WriteLine("Rectangle: "+ width +" "+ height);
        }
        public bool isLegal()
        {
            return (width > 0 && height > 0);

        }
    }

    class Square : Rectangle
    {
        public Square(double w) : base(width: w, height: w) { }

    }

    class Triangle : Graphical
    {
        public double a
        {
            set;
            get;
        }
        public double b
        {
            set;
            get;
        }
        public double c
        {
            set;
            get;
        }
        public double Area => Math.Sqrt((a+b+c)*(b+c-a)*(a+b-c)*(a+c-b))/4;

        public Triangle(double a, double b,double c)  
        {
            this.a = a;
            this.b = b;
            this.c = c;
            Console.WriteLine("Triangle: " + a + " " + b+" "+c);
        }
        public bool isLegal()
        {
            if (a > 0 && b > 0 && c>0 && a+b>c && a+c>b && b+c>a)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }


}
